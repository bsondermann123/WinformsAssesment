using System;
using System.IO;
using System.Threading;

namespace IOLib
{
    /// <summary>Class doing some IO work</summary>
    public class IOWorker
    {
        /// <summary>
        /// Does the work
        /// </summary>
        /// <exception cref="IOException">IO might fail rarely</exception>
        public void DoWork()
        {
            var random = new Random();

            // Simulate it sometimes failing
            if (random.Next(10_000) <= 5) throw new IOException();

            // Simulate some work
            Thread.Sleep(random.Next(5000, 10000));
        }
    }
}
