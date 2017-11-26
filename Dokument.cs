using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace DMSRupObk
{
    public class Dokument
    {
        public int DokID { get; set; }
        public string Pfad { get; set; }
        public string Dateiname { get; set; }
        public string Dateityp { get; set; }
        public DateTime Archivierungsdatum { get; set; }
        public DateTime Aenderungsdatum { get; set; }
        public int Jahr { get; set; }
        public string Periode { get; set; }
        public int DokumentenartKey { get; set; }
        public string DokumentenartName { get; set; }
        public int LieferantKey { get; set; }
        public string LieferantName { get; set; }
        public string Verschlagwortung { get; set; }
        public string Dokumentenstatus { get; set; }

        public Dokument(int DokID, int DokumentenartKey, string DokumentenartName, string Pfad, string Dateiname, string Dateityp, string Verschlagwortung,
                        int Jahr, string Dokumentenstatus, DateTime Archivierungsdatum, DateTime Aenderungsdatum, int LieferantKey, string LieferantName,
                        string Periode)
        // nur Pflichtfelder werden übergeben, optionale Felder werden in Klasse DokBearbeiten gesetzt, weil diese könnten auch leer bzw. null sein
        {
            Archiv DokArchiv = Archiv.Erstellen();

            this.DokID = DokID;
            this.Pfad = Pfad;
            this.Dateiname = Dateiname;
            this.Dateityp = Dateityp;
            this.Archivierungsdatum = Archivierungsdatum;
            this.Aenderungsdatum = Aenderungsdatum;
            this.Jahr = Jahr;
            this.Periode = Periode;
            this.DokumentenartKey = DokumentenartKey;
            this.DokumentenartName = DokumentenartName;
            this.LieferantKey = LieferantKey;
            this.LieferantName = LieferantName;
            this.Verschlagwortung = Verschlagwortung;
            this.Dokumentenstatus = Dokumentenstatus;

            DokArchiv.alleDokumente.Add(this);

            if (this.DokumentenartName == "Rechnung")
                DokArchiv.alleRechnungen.Add(this);
        }

        public void OeffneDich()
        {
            System.Diagnostics.Process.Start(Path.Combine(ProgParam.Erstellen().RootVerzeichnisDok, this.Pfad, this.Dateiname));
        }

        //TODO: testen
        public void Loeschen()
        {
            try
            {
                ProgParam PrgPrm = ProgParam.Erstellen();
                string pfad = Path.Combine(PrgPrm.RootVerzeichnisDok, this.Pfad, this.Dateiname);
                FileInfo fi = new FileInfo(pfad);
                File.Delete(pfad);
                Archiv.Erstellen().alleDokumente.Remove(this);
                Archiv.Erstellen().Speichern();
                PrgPrm.AnzahlArchivierteDokumente--;
                PrgPrm.DokDatengroesseInKB -= Convert.ToDecimal(fi.Length / 1024d);
                PrgPrm.Schreiben();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Konnte Dokument nicht löschen. Fehler: " + ex.Message + "\nProgramm wird beendet!");
                Environment.Exit(-1);
            }
        }

    }

    public class Volltextindex
    {
        public int DokID { get; set; }
        public string Index { get; set; }
        public string Pfad { get; set; }
        public string Dateiname { get; set; }
        public string Dateityp { get; set; }

        public Volltextindex(int DokID, string Index, string Pfad, string Dateiname, string Dateityp)
        {
            this.DokID = DokID;
            this.Index = Index;
            this.Pfad = Pfad;
            this.Dateiname = Dateiname;
            this.Dateityp = Dateityp;

            Volltext vt = Volltext.Erstellen();
            vt.alleVolltexte.Add(this);
        }

        //TODO: testen
        public void Loeschen()
        {
            try
            {
                ProgParam PrgPrm = ProgParam.Erstellen();
                Volltext.Erstellen().alleVolltexte.Remove(this);
                Volltext.Erstellen().Speichern();
                FileInfo fi = new FileInfo(Path.Combine(ProgParam.Erstellen().RootVerzeichnisDok, ProgParam.Erstellen().PfadJSONDateiVolltext));
                PrgPrm.VolltextDatengroesseInKB = Convert.ToDecimal(fi.Length / 1024);
                PrgPrm.Schreiben();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Konnte Volltext zum Dokument nicht löschen. Fehler: " + ex.Message + "\nProgramm wird beendet!");
                Environment.Exit(-1);
            }
        }
    }

}
