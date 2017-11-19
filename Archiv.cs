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
        public static string PfadJsonMetadaten;
        private static Archiv DokArchiv = null;

        //Singleton Klasse für Datenbehälter
        public List<Dokument> alleDokumente { get; set; } = new List<Dokument>();
        [JsonIgnore]
        public List<Dokument> alleRechnungen { get; set; } = new List<Dokument>(); // um schneller bei der Suche zu sein, weil das Meiste Rechnungen sind

        private Archiv()
        { }

        public static Archiv Erstellen()
        {
            if (DokArchiv == null)
            {
                DokArchiv = new Archiv();
                PfadJsonMetadaten = Path.Combine(ProgParam.Erstellen().RootVerzeichnisDok, ProgParam.Erstellen().PfadJSONDateiMetadaten);
                Laden();
            }
            return DokArchiv;
        }


        //public Searchtree Suchbaum { get; set; }

        public void Speichern()
        {
            try
            {
                File.WriteAllText(Archiv.PfadJsonMetadaten, JsonConvert.SerializeObject(this, Formatting.Indented));
            }
            catch (Exception ex)
            {
                MessageBox.Show(PfadJsonMetadaten + " kann nicht geschrieben werden. Fehler:" + ex.Message + "\nProgramm wird beendet ...");
                Environment.Exit(1);
            }
        }

        public static void Laden()
        {
            try
            {
                DokArchiv = JsonConvert.DeserializeObject<Archiv>(File.ReadAllText(Archiv.PfadJsonMetadaten));
            }
            catch (System.IO.FileNotFoundException)
            {
                MessageBox.Show("metadaten.json nicht gefunden. Programm wird beendet ...");
                Environment.Exit(1);
            }
        }
    }
}
