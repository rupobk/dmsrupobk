using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DMSRupObk
{
    class Volltext
    {
        public static string PfadJsonVolltext;
        private static Volltext DokVolltext = null;

        //Singleton Klasse für Datenbehälter
        public List<Volltextindex> alleVolltexte { get; set; } = new List<Volltextindex>();

        private Volltext()
        { }

        public static Volltext Erstellen()
        {
            if (DokVolltext == null)
            {
                DokVolltext = new Volltext();
                PfadJsonVolltext = Path.Combine(ProgParam.Erstellen().RootVerzeichnisDok, ProgParam.Erstellen().PfadJSONDateiVolltext);
            }
            return DokVolltext;
        }



        //public Searchtree Suchbaum { get; set; }

        //TODO: testen
        public void Loeschen(string id)
        {
            var rec = from a in Volltext.Erstellen().alleVolltexte
                      where a.DokID == int.Parse(id)
                      select a;

            foreach (Volltextindex d in rec)
            {
                try
                {
                    ProgParam PrgPrm = ProgParam.Erstellen();
                    alleVolltexte.Remove(d);
                    Speichern();
                    FileInfo fi = new FileInfo(Path.Combine(ProgParam.Erstellen().RootVerzeichnisDok, ProgParam.Erstellen().PfadJSONDateiVolltext));
                    PrgPrm.VolltextDatengroesseInKB = Convert.ToDecimal(fi.Length / 1024);
                    PrgPrm.Schreiben();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Konnte Volltext zum Dokument nicht löschen. Fehler: " + ex.Message + "\nProgramm wird beendet!");
                    Environment.Exit(1);
                }
            }
        }

        public void Speichern()
        {
            try
            {
                File.WriteAllText(Volltext.PfadJsonVolltext, JsonConvert.SerializeObject(this, Formatting.Indented));
            }
            catch (Exception ex)
            {
                MessageBox.Show(PfadJsonVolltext + " kann nicht geschrieben werden. Fehler:" + ex.Message + "\nProgramm wird beendet ...");
                Environment.Exit(1);
            }
        }

        public static void Laden()
        {
            try
            {
                DokVolltext = JsonConvert.DeserializeObject<Volltext>(File.ReadAllText(Volltext.PfadJsonVolltext));
            }
            catch (System.IO.FileNotFoundException)
            {
                MessageBox.Show(PfadJsonVolltext + " nicht gefunden. Programm wird beendet ...");
                Environment.Exit(1);
            }
        }

    }
}
