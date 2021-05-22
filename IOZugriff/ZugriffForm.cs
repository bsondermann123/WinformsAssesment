using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
// NOTE: Mit System.Threading.Tasks stellt Klassen bereit, mit denen Aufgaben überwacht/analysiert werden können
using System.Threading.Tasks;

using System.Threading;

// NOTE: Projektverweis auf die Klassenbibliothek, um IOWorker aufzurufen
using IOLib;


//TODO1: Erstellen Sie eine WinForm Oberfläche, über die ein Ordner ausgewählt
// und anschließend mit einem Button der IOWorker angestoßen wird.
// Zeigen Sie Fehler, die der IOWorker ggf. wirft, in der Oberfläche an.

//TODO2: Beim Ausführen blockiert der IOWorker die Oberfläche.
// Passen Sie die DoWork() Methode so an, dass diese die WinForms Oberfläche nicht mehr blockiert.
// Während der IOWorker arbeitet, darf kein neuer IOWorker angestoßen werden.

//TODO3: Bauen Sie einen weiteren Button in die Oberfläche, über die der IOWorker abgebrochen werden kann.
// Dieser Button soll nur aktiv sein, wenn auch wirklich gearbeitet wird.

//TODO4: (Aus Email) IOWorker soll asynchron aufgerufen werden (also dem Zugriffform erlauben weiter zu arbeiten) 
// dabei sollen async
// (- asynchron / Asynchrone Methoden werden bis zum await synchron ausgeführt. Dann wird angehalten und Steuerung abgegeben)
// und await
// (- Schlüsselwort, wenn Thread nicht blockiert werden soll und Ergebnis benötigt wird -> Oberfläche wird nicht gesperrt und bleibt 'ansprechbar')
// zur Anwendung kommen

namespace IOZugriff
{
    public partial class ZugriffForm : Form
    {
        //NOTE: IOWorker in IOLib
        private IOWorker worker = new IOWorker();

        //NOTE: b_inBearebeitung ist true, wenn IOWorker 'beschäftigt' ist (wird true bei Auswahl Ordner)
        private bool b_inBearbeitung = false;
        
        //NOTE: Wird benötigt, um Worker zu signalsieren, das er abgebrochen werden soll
        CancellationTokenSource s_cts = null;

        public ZugriffForm()
        {
            InitializeComponent();
        }

        private void ZugriffForm_Load(object sender, EventArgs e)
        {

        }

        // NOTE: Klick-Ereignis auf den Button 'Ordner öffnen'
        // - öffnet den folderBrowserDialog1 und stößt IOWorker aus IOLib an
        private void Btn_OrdnerOeffnen_Click(object sender, EventArgs e)
        {
            //NOTE: Dialog zum Öffnen eines Ordners anzeigen
            folderBrowserDialog1.ShowDialog();
            //NOTE: Ausgewählter Ordner wird in Zeichenkette gespeichert
            string OrdnerPfad = folderBrowserDialog1.SelectedPath;
            //NOTE: Label zur Ausgabe des Work-Status wird entleert (Testzwecke)
            lbl_Ausgabe.Text = "";
            

            //NOTE: Solange der IOWorker gestartet ist, soll kein weiterer IOWorker angestoßen werden
            if (!b_inBearbeitung)
            {
                //NOTE: Die Aufgabe IOWorker.DoWork wird in einem Task-Objekt behalten
                Task Myworker = Btn_OrdnerOeffnenAsync(folderBrowserDialog1.SelectedPath);                
            }
            else
            {
                //NOTE: Info, das der IOWorker noch arbeitet
                lbl_Ausgabe.Text = OrdnerPfad + " ist noch in Bearbeitung.";
            }
           

            //NOTE: Anzeige des Ordnernamens in der Textbox txt_OrdnerName
            txt_OrdnerName.Text = folderBrowserDialog1.SelectedPath;
            txt_OrdnerName.Show();          

        }


        public async Task Btn_OrdnerOeffnenAsync(string derPfad)
        {
            b_inBearbeitung = true;

            //NOTE: Neue Instanz einer CancellationTokenSource (wird mit Disposed freigegeben)
            s_cts = new CancellationTokenSource();
            var token = s_cts.Token;

            //NOTE: Aufruf der IOWorkerklasse mit Übergabe des Ordnerpfades, der vom Dialog zurückgegeben wurde
            // Aufruf erfolg asynchron
            try
            {
                // Sobald der IOWorker-Aufruf startet soll (sein) Abbruch-Button angezeigt werden
                btn_Abbruch.Show();        

                await worker.DoWorkAsync(derPfad, s_cts.Token);         
                           
                lbl_Ausgabe.Text = derPfad + " fertig";                
            }
            catch(Exception ex)
            {
                //NOTE: Ausgabe möglicher Fehler (IOExeption oder Cancel)
                lbl_Ausgabe.Text = "Fehler " + ex.Message;               
            }
            finally
            {
                // NOTE: Freigabe CancellationTokenSource
                s_cts.Dispose();
            }

           
            lbl_Ausgabe.Show();
            b_inBearbeitung = false;
            btn_Abbruch.Hide();            
        }

            private void btn_Abbruch_Click(object sender, EventArgs e)
        {
            b_inBearbeitung = false;
            s_cts.Cancel();
        }
    }
}
