using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DMSRupObk
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]

        
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Lizenz für Dokumentenviewer-Objekt einmal aktivieren
            Gnostice.Documents.Framework.ActivateLicense("E851-06B8-F97A-E39A-69AD-014C-F7C4-D3FD-55CE-ECBA-D607-941D");

            //Application.Run(new frmHauptfenster());

            //TODO: Laurin fragen: warum Methode DatenLaden, ansonsten Endlosschleife u. wohin damit
            ProgParam PrgPrm = ProgParam.Erstellen();
            Archiv DokArchiv = Archiv.Erstellen();
            Archiv.DatenLaden();

            Application.Run(new frmDokBearbeiten());
        }
    }
}
