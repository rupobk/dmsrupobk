using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
using System.Windows.Forms;

namespace DMSRupObk
{
    class Archiv
    {
        private static Archiv DokArchiv = null;

        //Singleton Klasse für Datenbehälter
        public List<Dokument> alleDokumente { get; set; } = new List<Dokument>();
        [JsonIgnore]
        public List<Dokument> alleRechnungen { get; set; } = new List<Dokument>();  // um schneller bei der Suche zu sein, weil das Meiste Rechnungen sind

        private Archiv()
        {
            DatenLaden();
        }

        public static Archiv Erstellen()
        {
            if (DokArchiv == null)
            {
                DokArchiv = new Archiv();
                //readJson
            }
            return DokArchiv;
        }



        //public Searchtree Suchbaum { get; set; }

        public void DatenSpeichern()
        {
            try
            {
                string pfadjsondatei = Path.Combine(ProgParam.Erstellen().RootVerzeichnisDok, ProgParam.Erstellen().PfadJSONDateiMetadaten);
                File.WriteAllText(pfadjsondatei, JsonConvert.SerializeObject(this, Formatting.Indented));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ProgParam.Erstellen().PfadJSONDateiMetadaten+" kann nicht geschrieben werden. Fehler:" + ex.Message + "\nProgramm wird beendet ...");
                Environment.Exit(1);
            }
        }

        public void DatenLaden()
        { }
    }
}
