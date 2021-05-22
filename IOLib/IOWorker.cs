using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace IOLib
{
    /// <summary>Class doing some IO work</summary>
    public class IOWorker
    {
        /// <summary>
        /// Does the work
        /// </summary>
        /// <exception cref="IOException">IO might fail rarely</exception>
       
        // NOTE: DoWork verändert
        public async Task DoWorkAsync(string path, CancellationToken cancellationToken)
        {
            var random = new Random();

            // Simulate it sometimes failing
            if (random.Next(10_000) <= 5) throw new IOException();

            // NOTE TestÄnderung:
            //await Task.Run(() =>
            //{
            //    Thread.Sleep(random.Next(5000, 10000));
            //});



            // NOTE: Mit Thread.sleep wird ein neuer Thread benötigt, wobei async/await die Anzahl reduzieren soll
            // Anstelle von Thread.sleep wird Task.Delay aufgerufen
            // Simulate some work
            // Mit Übergabe des cancellationToken zum Abbruch
            await Task.Delay(random.Next(5000, 10000), cancellationToken);

            cancellationToken.ThrowIfCancellationRequested();
        }


        //NOTE: Methode 'vorher'
        //public void DoWork(string path)
        //{
        //    var random = new Random();

        //    // Simulate it sometimes failing
        //    if (random.Next(10_000) <= 5) throw new IOException();

        //    // Simulate some work
        //    Thread.Sleep(random.Next(5000, 10000));
        //}
    }
}
