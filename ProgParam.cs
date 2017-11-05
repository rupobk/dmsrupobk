using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;


namespace DMSRupObk
{

    public class ProgParam
    {
        // statische Felder gehören nicht zur Klasse, sondern zum "allgemeinen" Programm
        // sie werden daher natürlich nicht ins json geschrieben!!
        private static ProgParam PrgPrm = null;
        public static string AnwendungsPfad = Application.StartupPath;
        public static string PfadJSONDateiParam = Path.Combine(AnwendungsPfad, "dmsrupobk.json");

        [JsonProperty] // ins json-File schreiben.
        public string RootVerzeichnisDok { get; set; }
        [JsonProperty] // ins json-File schreiben.
        public string PfadJSONDateiMetadaten { get; set; }
        [JsonProperty] // ins json-File schreiben.
        public string PfadJSONDateiVolltext { get; set; }
        [JsonProperty] // ins json-File schreiben.
        public string ImportVerzeichnisDok { get; set; }
        [JsonProperty] // ins json-File schreiben.
        public string ImportVerzeichnisFehler { get; set; }
        [JsonProperty] // ins json-File schreiben.
        public string IndexVerzeichnis { get; set; }
        [JsonProperty] // ins json-File schreiben.
        public bool VolltextindizierungDefault { get; set; }
        [JsonProperty] // ins json-File schreiben.
        public int AnzDokProVerzeichnis { get; set; }
        [JsonProperty] // ins json-File schreiben.
        public int AnzahlArchivierteDokumente { get; set; }
        [JsonProperty] // ins json-File schreiben.
        public int DatengroesseInMB { get; set; }
        [JsonProperty] // ins json-File schreiben.
        public int DokID { get; set; }

        //damit AlleDokumentenarten immer beim get sortiert sind, macht man das so:
        //hat aber den Nachteil, dass dann sowohl _AlleDokumentenarten als auch AlleDokumentenarten in die json geschrieben werden
        //[JsonIgnore]  // nicht ins json-File schreiben
        //public List<Dokumentenart> _AlleDokumentenarten = new List<Dokumentenart>();
        //[JsonProperty] // schon ins json-File schreiben. Dient hier nur als Beispiel
        //public List<Dokumentenart> AlleDokumentenarten { get { return _AlleDokumentenarten.OrderBy(o => o.Name).ToList(); } set { this._AlleDokumentenarten = value; } }
        //[JsonIgnore]  // nicht ins json-File schreiben
        //public List<Lieferant> _AlleLieferanten = new List<Lieferant>();
        //public List<Lieferant> AlleLieferanten { get { return _AlleLieferanten.OrderBy(o => o.Name).ToList(); } set { this._AlleLieferanten = value; } }
        //[JsonIgnore]  // nicht ins json-File schreiben
        //public List<string> _Ordner = new List<string>();
        //public List<string> Ordner { get { _Ordner.Sort(); return _Ordner; } set { this._Ordner = value; } }
        [JsonProperty] // ins json-File schreiben.
        public List<string> Dokumentenstatus { get; set; }
        [JsonProperty] // ins json-File schreiben.
        public List<Dokumentenart> AlleDokumentenarten { get; set; }
        [JsonProperty] // ins json-File schreiben.
        public List<Lieferant> AlleLieferanten { get; set; }
        [JsonProperty] // ins json-File schreiben.
        public List<string> Ordner { get; set; }


        private ProgParam()
        {
            //iniDateiLesen();
        }

        public static ProgParam Erstellen()
        {
            if (PrgPrm == null)
            {
                //PrgPrm = new ProgParam();  nicht notwendig wird durch Json-Lesen automatisch ausgeführt
                // wird PrgPrm erstellt, dann müssen natürlich alle Parameter auch mit eingelesen werden:
                JsonDateiParamLesen();
                PrgPrm.VerzeichnisseEinrichten();
            }
            return PrgPrm;
        }

        public int DokIDGenerieren()
        {
            DokID++;
            //iniDatenAktualisieren(DokID);
            JsonDateiParamSchreiben();
            return DokID;
        }

        private void VerzeichnisseEinrichten()
        {
            string ordner="";
            try
            {
                foreach (var item in Ordner)
                {
                    ordner = Path.Combine(RootVerzeichnisDok,item);
                    
                    if (!Directory.Exists(ordner))
                        Directory.CreateDirectory(ordner);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kann Ordner " + ordner + " nicht anlegen. Fehler:" + ex.Message + "\nProgramm wird beendet ...");
                Environment.Exit(1);
            }
        }

        public static void JsonDateiParamLesen()
        {
            try
            {
                PrgPrm = JsonConvert.DeserializeObject<ProgParam>(File.ReadAllText(PfadJSONDateiParam));
            }
            catch (System.IO.FileNotFoundException)
            {
                MessageBox.Show("dmsrupobk.json nicht gefunden. Programm wird beendet ...");
                Environment.Exit(1);
            }
        }

        public void JsonDateiParamSchreiben()
        {
            try
            {
                File.WriteAllText(PfadJSONDateiParam, JsonConvert.SerializeObject(this, Formatting.Indented));
            }
            catch (Exception ex)
            {
                MessageBox.Show("dmsrupobk.json kann nicht geschrieben werden. Fehler:" + ex.Message + "\nProgramm wird beendet ...");
                Environment.Exit(1);
            }
        }

        public void NeuerLieferant(int Key, string Name)
        {
            AlleLieferanten.Add(new Lieferant(Key, Name));
            JsonDateiParamSchreiben();
        }

        public void NeueDokumentenart(int Key, string Name)
        {
            AlleDokumentenarten.Add(new Dokumentenart(Key, Name));
            JsonDateiParamSchreiben();
        }

        public void NeuerOrdner(string Name)
        {
            string ordner = "";
            try
            {
                ordner = Path.Combine(RootVerzeichnisDok,Name);
                if (!Directory.Exists(ordner))
                {
                    Directory.CreateDirectory(ordner);
                    this.Ordner.Add(Name);
                    JsonDateiParamSchreiben();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kann neuen Ordner " + ordner + " nicht anlegen. Fehler:" + ex.Message);
            }

        }

        public string NeuerDateiname(string id)
        {
            return "d_"+id+"_"+ DateTime.Now.ToString("yyyyMMdd");
        }
    }

    public class Lieferant
    {
        public int Key { get; private set; }
        public string Name { get; private set; }

        //Achtung: Felder im Konstruktordeklaration (Key, Name) müssen genau so heissen, wie Felder im json, ansonsten liest der Deserializer nur Null-Werte
        public Lieferant(int Key, string Name)
        {
            this.Key = Key;
            this.Name = Name;
        }
    }

    public class Dokumentenart
    {
        //Achtung: Felder im Konstruktordeklaration (Key, Name) müssen genau so heissen, wie Felder im json, ansonsten liest der Deserializer nur Null-Werte
        public int Key { get; private set; }
        public string Name { get; private set; }

        public Dokumentenart(int Key, string Name)
        {
            this.Key = Key;
            this.Name = Name;
        }
    }
}

//public class JsonDateiParam
//{
//    public List<Dokumentenart> Dokumentenarten { get; set; }
//    public List<Lieferant> Lieferanten { get; set; }
//    public List<string> Ordner { get; set; }

//    public JsonDateiParam(List<Dokumentenart> dok, List<Lieferant> lief, List<string> ord)
//    {
//        Dokumentenarten = dok;
//        Lieferanten = lief;
//        Ordner = ord;
//    }
//}


//private void DokumentenartenLesen()
//{
// Methode, wenn Dokumentenarten noch in der ini-Datei waren
//Dokumentenarten = new Dictionary<int, string>();
//string dokart = (iniFile.GetValue("Indizierung-Verschlagwortung", "dokumentenarten1") + "," +
//                iniFile.GetValue("Indizierung-Verschlagwortung", "dokumentenarten2") + "," +
//                iniFile.GetValue("Indizierung-Verschlagwortung", "dokumentenarten3")).ToLower();
//string[] tmp = dokart.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
//string[] tmp2 = null;
//foreach (var item in tmp)
//{
//    tmp2 = item.Split(':');
//    Dokumentenarten.Add(int.Parse(tmp2[0]), tmp2[1]);
//}
//}

//private void LieferantenLesen()
//{
// Methode, wenn Lieferanten noch in der ini-Datei waren
//Lieferanten = new Dictionary<int, string>();
//string lief = (iniFile.GetValue("Indizierung-Verschlagwortung", "lieferanten1") + "," +
//              iniFile.GetValue("Indizierung-Verschlagwortung", "lieferanten2") + "," +
//              iniFile.GetValue("Indizierung-Verschlagwortung", "lieferanten3") + "," +
//              iniFile.GetValue("Indizierung-Verschlagwortung", "lieferanten4") + "," +
//              iniFile.GetValue("Indizierung-Verschlagwortung", "lieferanten5") + "," +
//              iniFile.GetValue("Indizierung-Verschlagwortung", "lieferanten6") + "," +
//              iniFile.GetValue("Indizierung-Verschlagwortung", "lieferanten7") + "," +
//              iniFile.GetValue("Indizierung-Verschlagwortung", "lieferanten8")).ToLower();
//string[] tmp = lief.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
//string[] tmp2 = null;
//foreach (var item in tmp)
//{
//    tmp2 = item.Split(':');
//    Lieferanten.Add(int.Parse(tmp2[0]), tmp2[1]);
//}
//}

//public void iniDateiLesen()
//{
//    try
//    {
//        iniFile = new INIFile(PfadINIDatei);
//        // Wert in INI-Datei speichern
//        //iniFile.SetValue("anwender", "name", textBox.Text);
//        // Wert aus INI-Datei auslesen
//        RootVerzeichnisDok = iniFile.GetValue("dateistruktur", "rootverzeichnisdok") + "\\";
//        AnzDokProVerzeichnis = int.Parse(iniFile.GetValue("dateistruktur", "AnzahlDokumenteProVerzeichnis"));
//        DokID = int.Parse(iniFile.GetValue("dokumentenimport", "DokID"));

//        ImportVerzeichnisDok = RootVerzeichnisDok + iniFile.GetValue("dokumentenimport", "importverzeichnisdok") + "\\";
//        ImportVerzeichnisFehler = RootVerzeichnisDok + iniFile.GetValue("dokumentenimport", "importverzeichnisfehler") + "\\";

//        IndexVerzeichnis = iniFile.GetValue("Indizierung-Verschlagwortung", "verzeichnisindex") + "\\";
//        VolltextindizierungDefault = (iniFile.GetValue("Indizierung-Verschlagwortung", "VolltextindizierungDefault") == "ja") ? true : false;

//        AnzahlArchivierteDokumente = int.Parse(iniFile.GetValue("Archivstatistik", "AnzahlArchivierteDokumente"));
//        DatengroesseInMB = int.Parse(iniFile.GetValue("Archivstatistik", "DatengroesseInMB"));

//        // Dokumentenarten, Lieferanten, Ordner einlesen
//        //JsonDateiParamLesen2();
//        JsonDateiParamSchreiben();
//        VerzeichnisseEinrichten();
//    }
//    catch (System.IO.FileNotFoundException)
//    {
//        MessageBox.Show("ini-Datei dmsrupobk.ini oder dmsrupobk.json nicht gefunden. Programm wird beendet ...");
//        Environment.Exit(1);
//    }
//}

//public void iniDatenAktualisieren(int anzdok, int datgroes)   //anzdok=Anzahl Dokumente; datgroes=Dateigrösse in Byte
//{
//    AnzahlArchivierteDokumente += anzdok;
//    DatengroesseInMB += datgroes / 1048576;
//    iniFile.SetValue("Archivstatistik", "AnzahlArchivierteDokumente", AnzahlArchivierteDokumente.ToString());
//    iniFile.SetValue("Archivstatistik", "DatengroesseInMB", DatengroesseInMB.ToString());
//}

//public void iniDatenAktualisieren(int DokID)   //fortlaufende dokid
//{
//    iniFile.SetValue("Dokumentenimport", "DokID", DokID.ToString());
//}
