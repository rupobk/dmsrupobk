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

        public void OpenDokument()
        {
            //Hei du, Dokument, zeige dich !! Hier wird ausprogrammiert, mit welchem Programm ein Dokument sinnvoll angezeigt werden kann!!! Pdf mit Adobe Reader
            //z. B. Process.Start(Dateiname) ungefähr;
        }

        public void DeleteDokument()
        {

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
    }

}
