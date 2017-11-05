using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using System.Windows.Input;

namespace DMSRupObk
{
    /// <summary>
    /// ComboBox, die es ermöglicht, die darin enthaltenen
    /// Einträge zu suchen, jedoch keine neuen anzulegen.
    /// </summary>
    public class SearchableComboBox : ComboBox
    {
        /// <summary>
        /// Initialisiert eine durchsuchbare ComboBox.
        /// </summary>
        public SearchableComboBox()
        {
            // Autovervollständigung einschalten
            this.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.AutoCompleteSource = AutoCompleteSource.ListItems;

            // Einfügen von Text mittels Kontextmenüs verhindern
            this.ContextMenu = new ContextMenu();

            // Einzelne Tastendrücke abfangen
            this.KeyPress += new KeyPressEventHandler(SearchableComboBox_KeyPress);
        }

        /// <summary>
        /// Wird aufgerufen, wenn eine Taste gedrückt wird.
        /// Überprüft, ob es sich um eine gültige Taste handelt.
        /// </summary>
        private void SearchableComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Bei der Löschtaste die Methode verlassen
            if (e.KeyChar == '\b')
                return;

            string searchString = string.Concat(this.SelectedText != string.Empty ? this.Text.Replace(this.SelectedText, string.Empty) : this.Text, e.KeyChar.ToString());
            bool success = false;

            bool readFromProperty = this.DisplayMember != string.Empty;
            string fieldText;

            // Alle Einträge überprüfen, ob ein passender gefunden werden kann
            foreach (object item in this.Items)
            {
                fieldText = item.ToString();

                if (readFromProperty)
                {
                    System.Reflection.PropertyInfo tmpInfo = item.GetType().GetProperty(this.DisplayMember);

                    if (tmpInfo != null)
                    {
                        fieldText = tmpInfo.GetValue(item, null).ToString();
                    }
                }

                if (fieldText.StartsWith(searchString))
                {
                    success = true;
                    break;
                }
            }

            // Wenn es nicht erfolgreich war, den Tastendruck verhindern
            if (!success)
                e.Handled = true;
        }

        /// <summary>
        /// Verhindert das Einfügen von Text mithilfe von Strg + V.
        /// </summary>
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.V))
                return true;
            else
                return base.ProcessCmdKey(ref msg, keyData);
        }
    }


    // TODO: noch so umbauen, das auch Minus u. Komma erlaubt ist, und zwar ganz vorne u. Anzahl der Stellen begrenzen
    /// <summary>
    /// Primitive Klasse, die zur Zeit nur numerische Tasten, Backspace u. Pfeiltasten zulässt
    /// Noch nicht ausgereift
    /// </summary>
    public class NumTextBox : TextBox
    {
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;

            base.OnKeyPress(e);
        }
    }
    


    // TODO: noch nicht verwendet, ist noch zu testen!!!!
    /// <summary>
    /// Klasse:  ValueBox  ; abgeleitet von TextBox, Nur Zahlen zugelassen
    /// -------
    /// 
    /// Diese ValueBox ist eine angepasste TextBox in der man nur Zahlen eingeben kann (incl. MIUNUS,PLUS- und KOMMA-Zeichen).
    /// 
    /// 
    /// Zwei statische Members:
    /// -----------------------
    /// 1. ValueBox.CreateValueBox(myWindowsForm-Objekt, Location_X, Location_y , myFont , myColor , deltaLänge, deltaHöhe, AnzahlZeichen); 
    ///    Diese Funktion erstellt ein TextBox bzw. ValuBox-Objekt und legt es in der WindowsForm an.
    ///    Die Eigenschaft gibt zusätzlich ein ValueBox-Objekt zurück. (wird ggf. für die 2. Funktion Set_Layout_ValueBox  benötigt)
    ///    
    /// 2. ValueBox.Set_Layout_ValueBox( ValueBox-Objekt , Location_X, Location_y , myFont , myColor ,deltaLänge ,deltaBreite, AnzahlZeichen); 
    ///    Mit dieser Funktion kann man die Eigenschaften eines bestehenden ValueBox-Objekt nachträglich ändern:
    ///    -Position(Location), die Länge, die Höhe, die Schriftart, die Schriftfarbe, die AnzahlDerZeichen
    ///    
    /// 
    /// 3. In der Eigenschaft:  myValueBox.ZAHL  steht die Zahl(double) zur weitern Verwendung zu Verfügung. 
    ///    -------------------------------------------------------------------------------------------------
    ///    
    /// z.B:
    ///     private ValueBox myValueBox;  //bitte Global !!!  
    ///     ....
    ///     z.B in Form1_Load
    ///     myValueBox=ValueBox.CreateValueBox(this , 10 , 100 , textBox1.Font , Color.Black , 0 , 0 , "9999"); //ValueBox anlegen
    ///     ....
    ///     z.B. in einen  button1_Click  oder sonst wo... (Zusatzfunktion)
    ///     ValueBox.Set_Layout_ValueBox(myValueBox , 10 , 200 , (new Font(new FontFamily("Arial"),8,
    ///                                                    FontStyle.Regular, GraphicsUnit.Pixel)) , Color.Red , 0 , 0 , "99999999999");
    ///    
    ///     ....
    ///     doubel wert=myValueBox.ZAHL; // <----- der Inhalt der ValueBox steht hier drin
    ///     
    /// 4. weiter Eigenschaften sind (myValueBox.)
    ///     -MIN und MAX -> Eingabe der Zahl eingrenzen (double)
    ///     -KOMMA       -> ZAHL mit oder ohne Komma     (bool)   
    ///     -AUTO_SIZE   -> die Boxlänge automatisch anhand der MaxLength anpassen  (bool)
    ///     -MIT_MINUS   -> Minuszeichen zugelassen oder nicht  (bool)
    ///     
    /// 
    /// </summary>

    public class ValueBox : TextBox
    {
        #region div. Eigenschaften
        private bool MINUS = false;
        private double dZahl = 0;
        private double dmin = 0;
        private double dmax = 0;
        private bool mit_komma = true;
        private bool mit_minus = true;
        private bool mit_autosize = false;
        //private ValueBoxValues valueBox_Values;


        // hier wird der Wert der ValueBox abgelegt
        // Aufruf: myValueBox.ZAHL als double
        [Description("Double-Value of the textbox")]
        public double ZAHL
        {
            get { return dZahl; }
            private set { dZahl = value; }
        }


        [Description("Minimum Value of the textbox")]
        public double MIN
        {
            get { return dmin; }
            set { dmin = value; }
        }
        [Description("Maximum Value of the textbox")]
        public double MAX
        {
            get { return dmax; }
            set { dmax = value; }
        }
        [Description("Value with or without comma")]
        public bool KOMMA
        {
            get { return mit_komma; }
            set { mit_komma = value; }
        }
        [Description("Textbox Autosize TRUE or FALSE")]
        public bool AUTO_SIZE
        {
            get { return mit_autosize; }
            set { mit_autosize = value; }
        }
        [Description("With or without minus sign")]
        public bool MIT_MINUS
        {
            get { return mit_minus; }
            set { mit_minus = value; }
        }

        #endregion


        // Konstructor...

        public ValueBox()
        {
            //this.MaxLength="123456789012".Length;
            this.ZAHL = 0;
            this.Text = "";
            this.Refresh();

        }

        // -----------------------------------------------------------------------------------------------------------------------------

        #region zwei statische Members - ValueBox.CreateValueBox(....) und  ValueBox.Set_Layout_ValueBox(...)

        /// <summary>
        /// ValueBox  erzeugen und in einer Windows-Form  anlegen
        /// 
        /// </summary>
        /// <param name="f"> Form Formobjekt</param>
        /// <param name="x"> int Location_X</param>
        /// <param name="y"> int Location_y</param>
        /// <param name="myf"> Font (z.B. from anyTexbox.Font)</param>
        /// <param name="myC"> Color (z.B. Color.Black)</param>
        /// <param name="withdx"> int zusatzLaenge zu der ValueBoxLaenge (um die Box zusätzlich zu verlängern)</param>
        /// <param name="heightdx"> int zusatzHoehe zu der ValueBoxHoehe (um die Box zusätzlich zu erhöhen)</param>
        /// <param name="anzZeichen"> int AnzahlZeichen der ValueBox (hiermit wird die Länge der ValueBox festgelegt)</param>
        /// <returns>ein erzeugtes Valueobjekt </returns>
        public static ValueBox CreateValueBox(Form f, int x, int y, Font myf, Color myC, int withdx, int heightdx, string anzZeichen)
        {
            ValueBox myvBox = null;
            try
            {
                myvBox = new ValueBox();

                bool ok = Set_Layout_ValueBox(myvBox, x, y, myf, myC, withdx, heightdx, anzZeichen);
                if (ok == true)
                {
                    f.Controls.Add(myvBox);

                }
                else
                {
                    myvBox = null;
                }
            }
            catch (Exception ex)
            {
                //fehler
                MessageBox.Show("Fehler in Member: CreateValueBox\n\n" + ex.Message);
            }


            return myvBox;
        }


        /// <summary>
        /// Das Layout der ValueBox  festlegen  -  (Location,Länge,Höhe,maxAnzahlZeichen,Font,Color)
        /// </summary>
        /// 
        /// <param name="vb"> ValueBox-object</param>
        /// <param name="x"> int Location_X</param>
        /// <param name="y"> int Location_y</param>
        /// <param name="myf"> Font (z.B. from anyTexbox.Font)</param>
        /// <param name="myC"> Color (z.B. Color.Black)</param>
        /// <param name="withdx"> int zusatzLaenge zu der ValueBoxLaenge</param>
        /// <param name="heightdx"> int zusatzHoehe zu der ValueBoxHoehe</param>
        /// <param name="anzZeichen"> int AnzahlZeichen der ValueBox (hiermit wird die Länge der ValueBox festgelegt)</param>
        /// <returns>bool  true/false </returns>
        public static bool Set_Layout_ValueBox(ValueBox vb, int x, int y, Font myf, Color myC, int withdx, int heightdx, string anzZeichen)
        {
            bool ok = true;
            try
            {
                Graphics g = vb.CreateGraphics();

                SizeF mySsingle = (g.MeasureString(anzZeichen, myf)).ToSize();
                mySsingle.Width += withdx + 6;

                mySsingle.Height += heightdx;
                int xa = 0, ya = 1;

                //textbox innerhalb des panels
                vb.Location = new Point(xa, ya);
                vb.Font = myf;
                vb.ForeColor = myC;
                vb.Size = mySsingle.ToSize();
                vb.MaxLength = anzZeichen.Length;
                vb.Location = new Point(x, y);
                vb.ZAHL = 0;
                vb.Text = "";
                vb.Refresh();


            }
            catch (Exception ex)
            {
                //fehler
                MessageBox.Show("Fehler in Funktion: Set_Layout_ValueBox\n" + ex.Message);
                ok = false;
            }

            return ok;
        }

        #endregion


        // -----------------------------------------------------------------------------------------------------------------------------


        // privates


        #region div. private Members...
        // TextBoxMemeber OnKeyPress überschreiben, um die nur Zahlen,Minuszeichen,Kommar und Conrtollsteuerzeichen auszufiltern !!!
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            try
            {
                // wenn dezimalpunkt dann in komma !!!
                if (e.KeyChar == '.')
                    e.KeyChar = ',';


                if (e.KeyChar == '-' && MIT_MINUS == true) // minus eingegeben
                {

                    if (Anzahl_EinesZeichens_ImText(this.Text, '-') == 0)
                    {
                        MINUS = false;
                    }

                    if (MINUS == false)
                    {
                        this.Text = this.Text.Insert(0, "-");
                        MINUS = true;
                        this.Select(this.Text.Length, 0);

                    }

                    if (Anzahl_EinesZeichens_ImText(this.Text, '-') > 1)
                    {
                        e.Handled = true;
                    }

                }

                if (e.KeyChar == '+') // bei eingabe des pluszeichen evt. das minuszeichen wieder rausnehmen
                {

                    if (MINUS == true && this.Text[0] == '-')
                    {
                        this.Text = this.Text.Remove(0, 1);  // minuszeichen wieder rausnehmen
                        this.Select(this.Text.Length, 0);
                        MINUS = false;  // und MINUS-Flag zuruecksetzen, um das MINUS-Zeichen erneut setzen zu koennen
                    }
                    e.Handled = true;
                    return;

                }

                //pruefen, ob mehr als ein komma eingegeben wurde

                if (e.KeyChar == ',' && KOMMA == true) // komma eingegeben
                {

                    if (Anzahl_EinesZeichens_ImText(this.Text + e.KeyChar, ',') > 1)
                    {
                        e.Handled = true;
                    }

                }


                // pruefen auf -> zahl , control-steuerzeichen oder ein komma 
                if (KOMMA == true)
                {
                    if ((!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) && !(e.KeyChar == ','))
                        e.Handled = true; // wenn nein, dann eingabe ignorieren 
                }
                else
                {
                    if ((!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)))
                        e.Handled = true; // wenn nein, dann eingabe ignorieren 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler in Member ValueBox.OnKeyPress\n\n" + ex.Message);
            }
        }


        // TextBoxMemeber OnLeave überschreiben, um die Eigenschaft "ZAHL" zu füllen
        // in der Eigenschaft "ZAHL" steht der innhalt der ValueBox !!!!!!!!!!!!!!!!
        // Die Eigenschaften MIN und MAX werden nur abgefragt, wenn eine von beiden nicht NULL ist.
        // (sprich: wenn beide auf NULL gestzt sind wird nicht abgefragt)
        protected override void OnLeave(EventArgs e)
        {



            try
            {
                if (!(this.Text == "" || this.Text.Length <= 0))
                {
                    ZAHL = Convert.ToDouble(this.Text);

                    if (!(dmin == 0 && dmax == 0))
                    {
                        //MessageBox.Show(MIN.ToString()+" "+MAX.ToString());
                        if (ZAHL < MIN)
                        {
                            MessageBox.Show(ZAHL.ToString() + " < " + MIN.ToString() + "(MIN)");
                            this.Focus();

                        }
                        if (ZAHL > MAX)
                        {
                            MessageBox.Show(ZAHL.ToString() + " > " + MAX.ToString() + "(MAX)");
                            this.Focus();
                        }
                    }
                }
                else
                {
                    ZAHL = 0;
                    this.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler in Member ValueBox.OnLeave\n\nZAHL auf Null gesetzt\n" + ex.Message);
                ZAHL = 0;
            }

            base.OnLeave(e);
        }

        // TextBoxMemeber OnENTER überschreiben, um bei AUTOSIZE=TRUE die Textbox-Grössen automatisch anzupassen !!!
        protected override void OnEnter(EventArgs e)
        {


            if (AUTO_SIZE == true)
            {
                if (this.MaxLength <= 50)
                {
                    StringBuilder s = new StringBuilder();
                    for (int i = 0; i < this.MaxLength; i++)
                        s.Append("0");
                    Set_Layout_ValueBox(this, this.Location.X, this.Location.Y, this.Font, this.ForeColor, 0, 0, s.ToString());
                    AUTO_SIZE = false;
                }
                //else
                //    MessageBox.Show("NO AUTOZICE avalible!  maxLenght("+this.MaxLength+") > 50");
            }

            base.OnEnter(e);
        }

        // TextBoxMemeber OnKeyDown überschreiben, bei Enter -  eingabe beenden - simuliert TAB-Taste
        protected override void OnKeyDown(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.Handled = true;
            }

            base.OnKeyDown(e);
        }

        // Anzahl eines Zeichens im Text ermitteln
        private int Anzahl_EinesZeichens_ImText(string text, char zeichen)
        {
            int z = 0;
            foreach (char s in text)
            {
                if (s == zeichen)
                    z++;

            }

            return z;
        }
        #endregion

    }

}
