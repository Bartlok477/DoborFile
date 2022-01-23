namespace Testowe
{
    partial class MainProgram
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainProgram));
            this.p_struktura_fazowa = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.p_typ_zyl = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.p_typ_izolacji = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.p_cos_fi = new System.Windows.Forms.TextBox();
            this.p_tg_fi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_oblicz = new System.Windows.Forms.Button();
            this.p_moc_czynna = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.p_dlugosc = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.p_wartosc_bezpiecznika = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.p_typ_ulozenia = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.p_typ_charakterystyki = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.typ_tory = new System.Windows.Forms.RadioButton();
            this.typ_tor = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.typ_norma = new System.Windows.Forms.RadioButton();
            this.typ_katalog = new System.Windows.Forms.RadioButton();
            this.btn_czysc = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.p_obliczony_prad = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.p_spadek_napiecia = new System.Windows.Forms.TextBox();
            this.p_prop_bezpiecznik = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.p_przekroj = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.btn_minus = new System.Windows.Forms.Button();
            this.btn_plus = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.p_obc_pradowa = new System.Windows.Forms.TextBox();
            this.p_spadek_check = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.m_item_0 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.m_item_2 = new System.Windows.Forms.ToolStripMenuItem();
            this.m_item_3 = new System.Windows.Forms.ToolStripMenuItem();
            this.m_pomoc = new System.Windows.Forms.ToolStripMenuItem();
            this.normyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rodzajeUłożeńToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pomocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.p_warunek_wynik_1 = new System.Windows.Forms.TextBox();
            this.p_warunek_wynik_2 = new System.Windows.Forms.TextBox();
            this.p_opis_warunek_1 = new System.Windows.Forms.Label();
            this.p_opis_warunek_2 = new System.Windows.Forms.Label();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.p_dopuszczalny_spadek_napiecia = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.p_prop_przekroj = new System.Windows.Forms.TextBox();
            this.btn_rodzaj_wkladki = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // p_struktura_fazowa
            // 
            this.p_struktura_fazowa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.p_struktura_fazowa.FormattingEnabled = true;
            this.p_struktura_fazowa.Items.AddRange(new object[] {
            "1-faz",
            "3-faz"});
            this.p_struktura_fazowa.Location = new System.Drawing.Point(32, 60);
            this.p_struktura_fazowa.Name = "p_struktura_fazowa";
            this.p_struktura_fazowa.Size = new System.Drawing.Size(121, 21);
            this.p_struktura_fazowa.TabIndex = 0;
            this.p_struktura_fazowa.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Liczba faz:";
            // 
            // p_typ_zyl
            // 
            this.p_typ_zyl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.p_typ_zyl.FormattingEnabled = true;
            this.p_typ_zyl.Items.AddRange(new object[] {
            "Aluminium",
            "Miedź"});
            this.p_typ_zyl.Location = new System.Drawing.Point(168, 60);
            this.p_typ_zyl.Name = "p_typ_zyl";
            this.p_typ_zyl.Size = new System.Drawing.Size(121, 21);
            this.p_typ_zyl.TabIndex = 2;
            this.p_typ_zyl.SelectedIndexChanged += new System.EventHandler(this.typ_zyl_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(165, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Typ żył:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(302, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Rodzaj izolacji:";
            // 
            // p_typ_izolacji
            // 
            this.p_typ_izolacji.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.p_typ_izolacji.FormattingEnabled = true;
            this.p_typ_izolacji.Items.AddRange(new object[] {
            "PVC",
            "XPLE"});
            this.p_typ_izolacji.Location = new System.Drawing.Point(305, 60);
            this.p_typ_izolacji.Name = "p_typ_izolacji";
            this.p_typ_izolacji.Size = new System.Drawing.Size(121, 21);
            this.p_typ_izolacji.TabIndex = 4;
            this.p_typ_izolacji.SelectedIndexChanged += new System.EventHandler(this.typ_izolacji_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(442, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "cos fi:";
            // 
            // p_cos_fi
            // 
            this.p_cos_fi.Location = new System.Drawing.Point(445, 61);
            this.p_cos_fi.MaxLength = 4;
            this.p_cos_fi.Name = "p_cos_fi";
            this.p_cos_fi.Size = new System.Drawing.Size(121, 20);
            this.p_cos_fi.TabIndex = 7;
            this.p_cos_fi.Text = "0.93";
            this.p_cos_fi.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.p_cos_fi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.p_cos_fi_KeyPress);
            this.p_cos_fi.Leave += new System.EventHandler(this.p_cos_fi_Leave);
            // 
            // p_tg_fi
            // 
            this.p_tg_fi.Location = new System.Drawing.Point(445, 104);
            this.p_tg_fi.MaxLength = 4;
            this.p_tg_fi.Name = "p_tg_fi";
            this.p_tg_fi.Size = new System.Drawing.Size(121, 20);
            this.p_tg_fi.TabIndex = 9;
            this.p_tg_fi.Text = "0.4";
            this.p_tg_fi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.p_tg_fi_KeyPress);
            this.p_tg_fi.Leave += new System.EventHandler(this.p_tg_fi_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(442, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "tg fi:";
            // 
            // btn_oblicz
            // 
            this.btn_oblicz.Location = new System.Drawing.Point(32, 530);
            this.btn_oblicz.Name = "btn_oblicz";
            this.btn_oblicz.Size = new System.Drawing.Size(121, 43);
            this.btn_oblicz.TabIndex = 10;
            this.btn_oblicz.Text = "Oblicz";
            this.btn_oblicz.UseVisualStyleBackColor = true;
            this.btn_oblicz.Click += new System.EventHandler(this.button1_Click);
            // 
            // p_moc_czynna
            // 
            this.p_moc_czynna.Location = new System.Drawing.Point(168, 104);
            this.p_moc_czynna.Name = "p_moc_czynna";
            this.p_moc_czynna.Size = new System.Drawing.Size(121, 20);
            this.p_moc_czynna.TabIndex = 11;
            this.p_moc_czynna.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.p_moc_czynna_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Podaj moc czynną [kW]:";
            // 
            // p_dlugosc
            // 
            this.p_dlugosc.Location = new System.Drawing.Point(168, 141);
            this.p_dlugosc.Name = "p_dlugosc";
            this.p_dlugosc.Size = new System.Drawing.Size(121, 20);
            this.p_dlugosc.TabIndex = 13;
            this.p_dlugosc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.p_dlugosc_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Podaj długość przewodu:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 181);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Wartość bezpiecznika:";
            // 
            // p_wartosc_bezpiecznika
            // 
            this.p_wartosc_bezpiecznika.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.p_wartosc_bezpiecznika.FormattingEnabled = true;
            this.p_wartosc_bezpiecznika.Items.AddRange(new object[] {
            "2",
            "6",
            "10",
            "16",
            "20",
            "25",
            "32",
            "40",
            "50",
            "63",
            "80",
            "100",
            "125"});
            this.p_wartosc_bezpiecznika.Location = new System.Drawing.Point(168, 178);
            this.p_wartosc_bezpiecznika.Name = "p_wartosc_bezpiecznika";
            this.p_wartosc_bezpiecznika.Size = new System.Drawing.Size(121, 21);
            this.p_wartosc_bezpiecznika.TabIndex = 17;
            this.p_wartosc_bezpiecznika.SelectedIndexChanged += new System.EventHandler(this.wartosc_bezpiecznika_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(29, 214);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Rodzaj ułożenia:";
            // 
            // p_typ_ulozenia
            // 
            this.p_typ_ulozenia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.p_typ_ulozenia.FormattingEnabled = true;
            this.p_typ_ulozenia.Items.AddRange(new object[] {
            "A1",
            "A2",
            "B1",
            "B2",
            "C",
            "D",
            "E",
            "F"});
            this.p_typ_ulozenia.Location = new System.Drawing.Point(168, 211);
            this.p_typ_ulozenia.Name = "p_typ_ulozenia";
            this.p_typ_ulozenia.Size = new System.Drawing.Size(121, 21);
            this.p_typ_ulozenia.TabIndex = 19;
            this.p_typ_ulozenia.SelectedIndexChanged += new System.EventHandler(this.typ_ulozenia_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(29, 306);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Ilość torów:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(29, 371);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(114, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Ch-ka zabezpieczenia:";
            // 
            // p_typ_charakterystyki
            // 
            this.p_typ_charakterystyki.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.p_typ_charakterystyki.FormattingEnabled = true;
            this.p_typ_charakterystyki.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "gG",
            "gF",
            "gTr"});
            this.p_typ_charakterystyki.Location = new System.Drawing.Point(168, 363);
            this.p_typ_charakterystyki.Name = "p_typ_charakterystyki";
            this.p_typ_charakterystyki.Size = new System.Drawing.Size(121, 21);
            this.p_typ_charakterystyki.TabIndex = 23;
            this.p_typ_charakterystyki.SelectedIndexChanged += new System.EventHandler(this.typ_charakterystyki_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(29, 463);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(118, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "Obciążalność prądowa:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.typ_tory);
            this.groupBox1.Controls.Add(this.typ_tor);
            this.groupBox1.Location = new System.Drawing.Point(168, 256);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(98, 76);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            // 
            // typ_tory
            // 
            this.typ_tory.AutoSize = true;
            this.typ_tory.Location = new System.Drawing.Point(7, 50);
            this.typ_tory.Name = "typ_tory";
            this.typ_tory.Size = new System.Drawing.Size(51, 17);
            this.typ_tory.TabIndex = 1;
            this.typ_tory.TabStop = true;
            this.typ_tory.Text = "2-tory";
            this.typ_tory.UseVisualStyleBackColor = true;
            // 
            // typ_tor
            // 
            this.typ_tor.AutoSize = true;
            this.typ_tor.Location = new System.Drawing.Point(7, 15);
            this.typ_tor.Name = "typ_tor";
            this.typ_tor.Size = new System.Drawing.Size(46, 17);
            this.typ_tor.TabIndex = 0;
            this.typ_tor.TabStop = true;
            this.typ_tor.Text = "1-tor";
            this.typ_tor.UseVisualStyleBackColor = true;
            this.typ_tor.CheckedChanged += new System.EventHandler(this.typ_tor_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.typ_norma);
            this.groupBox2.Controls.Add(this.typ_katalog);
            this.groupBox2.Location = new System.Drawing.Point(168, 411);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(98, 76);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            // 
            // typ_norma
            // 
            this.typ_norma.AutoSize = true;
            this.typ_norma.Location = new System.Drawing.Point(7, 50);
            this.typ_norma.Name = "typ_norma";
            this.typ_norma.Size = new System.Drawing.Size(54, 17);
            this.typ_norma.TabIndex = 1;
            this.typ_norma.TabStop = true;
            this.typ_norma.Text = "norma";
            this.typ_norma.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.typ_norma.UseVisualStyleBackColor = true;
            this.typ_norma.Click += new System.EventHandler(this.typ_norma_Click);
            // 
            // typ_katalog
            // 
            this.typ_katalog.AutoSize = true;
            this.typ_katalog.Location = new System.Drawing.Point(7, 15);
            this.typ_katalog.Name = "typ_katalog";
            this.typ_katalog.Size = new System.Drawing.Size(60, 17);
            this.typ_katalog.TabIndex = 0;
            this.typ_katalog.TabStop = true;
            this.typ_katalog.Text = "katalog";
            this.typ_katalog.UseVisualStyleBackColor = true;
            this.typ_katalog.CheckedChanged += new System.EventHandler(this.typ_katalog_CheckedChanged);
            this.typ_katalog.Click += new System.EventHandler(this.typ_katalog_Click);
            // 
            // btn_czysc
            // 
            this.btn_czysc.Location = new System.Drawing.Point(175, 530);
            this.btn_czysc.Name = "btn_czysc";
            this.btn_czysc.Size = new System.Drawing.Size(121, 43);
            this.btn_czysc.TabIndex = 28;
            this.btn_czysc.Text = "Czyść";
            this.btn_czysc.UseVisualStyleBackColor = true;
            this.btn_czysc.Click += new System.EventHandler(this.btn_czysc_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(302, 167);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(96, 13);
            this.label13.TabIndex = 29;
            this.label13.Text = "Obliczony prąd [A]:";
            // 
            // p_obliczony_prad
            // 
            this.p_obliczony_prad.Location = new System.Drawing.Point(445, 167);
            this.p_obliczony_prad.MaxLength = 4;
            this.p_obliczony_prad.Name = "p_obliczony_prad";
            this.p_obliczony_prad.ReadOnly = true;
            this.p_obliczony_prad.Size = new System.Drawing.Size(121, 20);
            this.p_obliczony_prad.TabIndex = 30;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(302, 207);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(104, 13);
            this.label14.TabIndex = 31;
            this.label14.Text = "Spadek napięcia[%]:";
            // 
            // p_spadek_napiecia
            // 
            this.p_spadek_napiecia.Location = new System.Drawing.Point(445, 204);
            this.p_spadek_napiecia.MaxLength = 4;
            this.p_spadek_napiecia.Name = "p_spadek_napiecia";
            this.p_spadek_napiecia.ReadOnly = true;
            this.p_spadek_napiecia.Size = new System.Drawing.Size(121, 20);
            this.p_spadek_napiecia.TabIndex = 32;
            // 
            // p_prop_bezpiecznik
            // 
            this.p_prop_bezpiecznik.Location = new System.Drawing.Point(445, 241);
            this.p_prop_bezpiecznik.MaxLength = 4;
            this.p_prop_bezpiecznik.Name = "p_prop_bezpiecznik";
            this.p_prop_bezpiecznik.ReadOnly = true;
            this.p_prop_bezpiecznik.Size = new System.Drawing.Size(121, 20);
            this.p_prop_bezpiecznik.TabIndex = 33;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(303, 244);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(95, 13);
            this.label15.TabIndex = 34;
            this.label15.Text = "Prop. Bezpiecznik:";
            // 
            // p_przekroj
            // 
            this.p_przekroj.Location = new System.Drawing.Point(445, 277);
            this.p_przekroj.MaxLength = 10;
            this.p_przekroj.Name = "p_przekroj";
            this.p_przekroj.ReadOnly = true;
            this.p_przekroj.Size = new System.Drawing.Size(121, 20);
            this.p_przekroj.TabIndex = 35;
            this.p_przekroj.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.p_przekroj_KeyPress);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(302, 280);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(90, 13);
            this.label16.TabIndex = 36;
            this.label16.Text = "Dobrany przekrój:";
            // 
            // btn_minus
            // 
            this.btn_minus.Location = new System.Drawing.Point(407, 275);
            this.btn_minus.Name = "btn_minus";
            this.btn_minus.Size = new System.Drawing.Size(32, 23);
            this.btn_minus.TabIndex = 37;
            this.btn_minus.Text = "-";
            this.btn_minus.UseVisualStyleBackColor = true;
            this.btn_minus.Click += new System.EventHandler(this.btn_minus_Click);
            // 
            // btn_plus
            // 
            this.btn_plus.Location = new System.Drawing.Point(572, 275);
            this.btn_plus.Name = "btn_plus";
            this.btn_plus.Size = new System.Drawing.Size(32, 23);
            this.btn_plus.TabIndex = 38;
            this.btn_plus.Text = "+";
            this.btn_plus.UseVisualStyleBackColor = true;
            this.btn_plus.Click += new System.EventHandler(this.btn_plus_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(302, 322);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(118, 13);
            this.label17.TabIndex = 39;
            this.label17.Text = "Obciążalność prądowa:";
            // 
            // p_obc_pradowa
            // 
            this.p_obc_pradowa.Location = new System.Drawing.Point(445, 319);
            this.p_obc_pradowa.MaxLength = 5;
            this.p_obc_pradowa.Name = "p_obc_pradowa";
            this.p_obc_pradowa.Size = new System.Drawing.Size(121, 20);
            this.p_obc_pradowa.TabIndex = 40;
            this.p_obc_pradowa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.p_obc_pradowa_KeyPress);
            // 
            // p_spadek_check
            // 
            this.p_spadek_check.AutoSize = true;
            this.p_spadek_check.Location = new System.Drawing.Point(572, 207);
            this.p_spadek_check.Name = "p_spadek_check";
            this.p_spadek_check.Size = new System.Drawing.Size(0, 13);
            this.p_spadek_check.TabIndex = 41;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label18.Location = new System.Drawing.Point(303, 371);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(149, 13);
            this.label18.TabIndex = 43;
            this.label18.Text = "Warunki przeciążalności:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(304, 401);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(63, 13);
            this.label19.TabIndex = 46;
            this.label19.Text = "Warunek 1:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(303, 429);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(63, 13);
            this.label20.TabIndex = 47;
            this.label20.Text = "Warunek 2:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_item_0,
            this.m_pomoc,
            this.pomocToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(622, 24);
            this.menuStrip1.TabIndex = 48;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // m_item_0
            // 
            this.m_item_0.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.m_item_2,
            this.m_item_3});
            this.m_item_0.Name = "m_item_0";
            this.m_item_0.Size = new System.Drawing.Size(76, 20);
            this.m_item_0.Text = "Ustawienia";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // m_item_2
            // 
            this.m_item_2.Name = "m_item_2";
            this.m_item_2.Size = new System.Drawing.Size(180, 22);
            this.m_item_2.Text = "toolStripMenuItem3";
            // 
            // m_item_3
            // 
            this.m_item_3.Name = "m_item_3";
            this.m_item_3.Size = new System.Drawing.Size(180, 22);
            this.m_item_3.Text = "toolStripMenuItem4";
            // 
            // m_pomoc
            // 
            this.m_pomoc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.normyToolStripMenuItem,
            this.rodzajeUłożeńToolStripMenuItem});
            this.m_pomoc.Name = "m_pomoc";
            this.m_pomoc.Size = new System.Drawing.Size(60, 20);
            this.m_pomoc.Text = "Dodatki";
            this.m_pomoc.Click += new System.EventHandler(this.toolStripMenuItem1_Click_1);
            // 
            // normyToolStripMenuItem
            // 
            this.normyToolStripMenuItem.Name = "normyToolStripMenuItem";
            this.normyToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.normyToolStripMenuItem.Text = "Ułożenie przewodów";
            this.normyToolStripMenuItem.Click += new System.EventHandler(this.normyToolStripMenuItem_Click);
            // 
            // rodzajeUłożeńToolStripMenuItem
            // 
            this.rodzajeUłożeńToolStripMenuItem.Name = "rodzajeUłożeńToolStripMenuItem";
            this.rodzajeUłożeńToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.rodzajeUłożeńToolStripMenuItem.Text = "Rodzaj ułożenia";
            this.rodzajeUłożeńToolStripMenuItem.Click += new System.EventHandler(this.rodzajeUłożeńToolStripMenuItem_Click);
            // 
            // pomocToolStripMenuItem
            // 
            this.pomocToolStripMenuItem.Name = "pomocToolStripMenuItem";
            this.pomocToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.pomocToolStripMenuItem.Text = "Pomoc";
            this.pomocToolStripMenuItem.Click += new System.EventHandler(this.pomocToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // p_warunek_wynik_1
            // 
            this.p_warunek_wynik_1.Location = new System.Drawing.Point(431, 398);
            this.p_warunek_wynik_1.MaxLength = 5;
            this.p_warunek_wynik_1.Name = "p_warunek_wynik_1";
            this.p_warunek_wynik_1.Size = new System.Drawing.Size(141, 20);
            this.p_warunek_wynik_1.TabIndex = 49;
            // 
            // p_warunek_wynik_2
            // 
            this.p_warunek_wynik_2.Location = new System.Drawing.Point(431, 423);
            this.p_warunek_wynik_2.MaxLength = 5;
            this.p_warunek_wynik_2.Name = "p_warunek_wynik_2";
            this.p_warunek_wynik_2.Size = new System.Drawing.Size(141, 20);
            this.p_warunek_wynik_2.TabIndex = 50;
            // 
            // p_opis_warunek_1
            // 
            this.p_opis_warunek_1.AutoSize = true;
            this.p_opis_warunek_1.Location = new System.Drawing.Point(379, 401);
            this.p_opis_warunek_1.Name = "p_opis_warunek_1";
            this.p_opis_warunek_1.Size = new System.Drawing.Size(0, 13);
            this.p_opis_warunek_1.TabIndex = 51;
            // 
            // p_opis_warunek_2
            // 
            this.p_opis_warunek_2.AutoSize = true;
            this.p_opis_warunek_2.Location = new System.Drawing.Point(379, 428);
            this.p_opis_warunek_2.Name = "p_opis_warunek_2";
            this.p_opis_warunek_2.Size = new System.Drawing.Size(0, 13);
            this.p_opis_warunek_2.TabIndex = 52;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // p_dopuszczalny_spadek_napiecia
            // 
            this.p_dopuszczalny_spadek_napiecia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.p_dopuszczalny_spadek_napiecia.FormattingEnabled = true;
            this.p_dopuszczalny_spadek_napiecia.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "3.5",
            "4",
            "5"});
            this.p_dopuszczalny_spadek_napiecia.Location = new System.Drawing.Point(307, 552);
            this.p_dopuszczalny_spadek_napiecia.Name = "p_dopuszczalny_spadek_napiecia";
            this.p_dopuszczalny_spadek_napiecia.Size = new System.Drawing.Size(121, 21);
            this.p_dopuszczalny_spadek_napiecia.TabIndex = 54;
            this.p_dopuszczalny_spadek_napiecia.SelectedIndexChanged += new System.EventHandler(this.p_dopuszczalny_spadek_napiecia_SelectedIndexChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(304, 533);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(157, 13);
            this.label21.TabIndex = 55;
            this.label21.Text = "Dopuszczalny spadek napięcia:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(302, 141);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(118, 13);
            this.label22.TabIndex = 56;
            this.label22.Text = "Proponowany przekrój: ";
            // 
            // p_prop_przekroj
            // 
            this.p_prop_przekroj.Location = new System.Drawing.Point(445, 137);
            this.p_prop_przekroj.MaxLength = 10;
            this.p_prop_przekroj.Name = "p_prop_przekroj";
            this.p_prop_przekroj.ReadOnly = true;
            this.p_prop_przekroj.Size = new System.Drawing.Size(121, 20);
            this.p_prop_przekroj.TabIndex = 57;
            // 
            // btn_rodzaj_wkladki
            // 
            this.btn_rodzaj_wkladki.Location = new System.Drawing.Point(32, 387);
            this.btn_rodzaj_wkladki.Name = "btn_rodzaj_wkladki";
            this.btn_rodzaj_wkladki.Size = new System.Drawing.Size(111, 27);
            this.btn_rodzaj_wkladki.TabIndex = 58;
            this.btn_rodzaj_wkladki.Text = "Wybierz rodzaj";
            this.btn_rodzaj_wkladki.UseVisualStyleBackColor = true;
            this.btn_rodzaj_wkladki.Click += new System.EventHandler(this.btn_rodzaj_wkładki_Click);
            // 
            // MainProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(622, 623);
            this.Controls.Add(this.btn_rodzaj_wkladki);
            this.Controls.Add(this.p_prop_przekroj);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.p_dopuszczalny_spadek_napiecia);
            this.Controls.Add(this.p_opis_warunek_2);
            this.Controls.Add(this.p_opis_warunek_1);
            this.Controls.Add(this.p_warunek_wynik_2);
            this.Controls.Add(this.p_warunek_wynik_1);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.p_spadek_check);
            this.Controls.Add(this.p_obc_pradowa);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.btn_plus);
            this.Controls.Add(this.btn_minus);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.p_przekroj);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.p_prop_bezpiecznik);
            this.Controls.Add(this.p_spadek_napiecia);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.p_obliczony_prad);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btn_czysc);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.p_typ_charakterystyki);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.p_typ_ulozenia);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.p_wartosc_bezpiecznika);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.p_dlugosc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.p_moc_czynna);
            this.Controls.Add(this.btn_oblicz);
            this.Controls.Add(this.p_tg_fi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.p_cos_fi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.p_typ_izolacji);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.p_typ_zyl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.p_struktura_fazowa);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(500, 500);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainProgram";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dobór przewodów i zabezpieczeń";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox p_cos_fi;
        private System.Windows.Forms.TextBox p_tg_fi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_oblicz;
        private System.Windows.Forms.TextBox p_moc_czynna;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox p_dlugosc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox p_wartosc_bezpiecznika;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox p_typ_charakterystyki;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton typ_katalog;
        private System.Windows.Forms.Button btn_czysc;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox p_spadek_napiecia;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btn_minus;
        private System.Windows.Forms.Button btn_plus;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label p_spadek_check;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem m_item_0;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem m_item_2;
        private System.Windows.Forms.ToolStripMenuItem m_item_3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem m_pomoc;
        private System.Windows.Forms.ToolStripMenuItem normyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rodzajeUłożeńToolStripMenuItem;
        private System.Windows.Forms.TextBox p_warunek_wynik_1;
        private System.Windows.Forms.TextBox p_warunek_wynik_2;
        private System.Windows.Forms.Label p_opis_warunek_1;
        private System.Windows.Forms.Label p_opis_warunek_2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ComboBox p_dopuszczalny_spadek_napiecia;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ToolStripMenuItem pomocToolStripMenuItem;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button btn_rodzaj_wkladki;
        public System.Windows.Forms.TextBox p_prop_przekroj;
        public System.Windows.Forms.TextBox p_obliczony_prad;
        public System.Windows.Forms.TextBox p_prop_bezpiecznik;
        public System.Windows.Forms.TextBox p_przekroj;
        public System.Windows.Forms.TextBox p_obc_pradowa;
        public System.Windows.Forms.ComboBox p_typ_ulozenia;
        public System.Windows.Forms.ComboBox p_struktura_fazowa;
        public System.Windows.Forms.ComboBox p_typ_zyl;
        public System.Windows.Forms.ComboBox p_typ_izolacji;
        public System.Windows.Forms.RadioButton typ_tory;
        public System.Windows.Forms.RadioButton typ_tor;
        public System.Windows.Forms.RadioButton typ_norma;
    }
}

