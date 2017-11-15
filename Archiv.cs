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
            }
            return DokArchiv;
        }

        //TODO: testen
        public void Loeschen(string id)
        {
            var rec = from a in Archiv.Erstellen().alleDokumente
                      where a.DokID == int.Parse(id)
                      select a;

            foreach (Dokument d in rec)
            {
                try
                {
                    ProgParam PrgPrm = ProgParam.Erstellen();
                    string pfad = Path.Combine(PrgPrm.RootVerzeichnisDok, d.Pfad, d.Dateiname);
                    FileInfo fi = new FileInfo(pfad);
                    File.Delete(pfad);
                    alleDokumente.Remove(d);
                    Speichern();
                    PrgPrm.AnzahlArchivierteDokumente--;
                    PrgPrm.DokDatengroesseInKB -= Convert.ToDecimal(fi.Length / 1024);
                    PrgPrm.Schreiben();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Konnte Dokument nicht löschen. Fehler: " + ex.Message + "\nProgramm wird beendet!");
                    Environment.Exit(1);
                }
            }
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
