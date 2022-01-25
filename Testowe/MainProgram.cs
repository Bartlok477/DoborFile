using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml;
using System.IO;


namespace Testowe
{
    public partial class MainProgram : Form
    {
        
        public string FileName = System.Reflection.Assembly.GetExecutingAssembly().Location + "\\..\\Dane1.xml";

        //dane

        public int struktura_fazowa;
        public int typ_zyl;
        public string rodzaj_izolacji;
        public float cos_fi;
        public float tg_fi;
        public float moc_czynna;
        public float dlugosc_przewodu;
        public int wartosc_bezpiecznika;
        public string rodzaj_ulozenia;
        public int ilosc_torow;
        public double rodzaj_charakterystyki;
        public string typ_obciazalnosci;

        //wyniki
        public double obl_prad;
        public double spadek_napiecia;
        public double obc_pradowa;

        //inne
        public static string Valueoftext;
        public float dobrany_przekroj;
        public bool wskaznik;
        public double dopuszczalny_spadek;
        private string b;
        public string dob_obc;

        // pomocnicze
        private int clickCounter = 0;
        

        //TO DO
        //wybierasz z katalogu walą sie warunki i obliczenia 

        //Listy uzywane
        //Przewody x1
        List<string> Wirenumbers = new List<string>()
            {
            "1.5","2.5","4","6","10","16","25","35","50","70","95","120","150","185","240","300"
            };
            //Przewody x2
        List<string> Wirenumbers2 = new List<string>()
            {
            "2x1.5","2x2.5","2x4","2x6","2x10","2x16","2x25","2x35","2x50","2x70","2x95","2x120","2x150","2x185","2x240","2x300"
            };

            //Rodzaje zabezpieczeń
        List<int> Eski = new List<int>()
            {
            6,10,16,20,25,32,40,50,63,80,100,125
            };

        

        private void Get_spadek()
        {
            p_dopuszczalny_spadek_napiecia.SelectedIndex = 3;
            dopuszczalny_spadek = float.Parse(p_dopuszczalny_spadek_napiecia.Text);
        }
        public MainProgram()
        {
            

            InitializeComponent();
            //Test_wartosci_1();
            //Test_wartosci_2();
            InitializeProgram();
            Get_spadek();

        }

        public void InitializeProgram()
        {
           
            
            p_struktura_fazowa.SelectedIndex = 0;
            p_typ_zyl.SelectedIndex = 0;
            p_typ_izolacji.SelectedIndex = 0;
            p_wartosc_bezpiecznika.SelectedIndex = 0;
            p_typ_ulozenia.SelectedIndex = 0;
            typ_tor.Checked = true;
            typ_norma.Checked = true;
            p_typ_charakterystyki.SelectedIndex = 0;
        }

        public void Main()
        {
            if (Get_from_textbox() == true)
            {
                ///Wyswietl();
                //Typ norma
                if (typ_norma.Checked == true && typ_katalog.Checked == false)
                {
                    Oblicz_prad();
                    Oblicz_spadek();
                    Oblicz_zabezpieczenie();

                    
                    Dobierz_przekroj();
                    Pobierz_z_normy();
                    p_obc_pradowa.Text = this.dob_obc;
                    
                    Sprawdzenie_warunkow();
                    Wyswietlenie_warunkow();

                }
                //Typ katalog
                if (typ_norma.Checked == false && typ_katalog.Checked == true)
                {
                    Oblicz_prad();
                    Oblicz_spadek();
                    Oblicz_zabezpieczenie();
                    Sprawdzenie_warunkow();
                    Wyswietlenie_warunkow();
                }
            }
        }



        private void Oblicz_prad()
        {
            if (struktura_fazowa == 230)
            {
                obl_prad = Math.Round((moc_czynna * 1000) / 230 / cos_fi, 2);
            }
            if (struktura_fazowa == 400)
            {
                obl_prad = Math.Round((moc_czynna * 1000) / 400 / cos_fi / 1.73, 2);
            }
            p_obliczony_prad.Text = obl_prad.ToString();
        }
        private void Oblicz_zabezpieczenie()
        {
            for (int item = 1; item < Eski.Count; item++)
            {
                if (this.obl_prad > Eski[item - 1] && this.obl_prad < Eski[item])
                {
                    if (wartosc_bezpiecznika > Eski[item])
                    {
                        this.p_prop_bezpiecznik.Text = wartosc_bezpiecznika.ToString();
                    }
                    else if (wartosc_bezpiecznika < Eski[item])
                    {
                        this.p_prop_bezpiecznik.Text = Eski[item].ToString();
                    }
                    else
                    {
                        p_prop_bezpiecznik.Text = "-";
                        Valueoftext = "Nie można dobrać takiego zabezpieczenia!";
                        Kontrolki g = new Kontrolki();
                        g.Show();
                    }
                }
            }

        }

        private void Oblicz_spadek()
        {
            if (Pobierz_przekroj() == false)
            {
                if (struktura_fazowa == 230)
                {
                    spadek_napiecia = Math.Round(200 * moc_czynna * 1000 * dlugosc_przewodu / struktura_fazowa / struktura_fazowa / typ_zyl / dobrany_przekroj, 1);
                    if (spadek_napiecia < dopuszczalny_spadek)
                    {
                        p_spadek_check.Text = "✓";
                    }
                    if (spadek_napiecia > dopuszczalny_spadek)
                    {
                        p_spadek_check.Text = "X";
                    }
                }
                if (struktura_fazowa == 400)
                {
                    spadek_napiecia = Math.Round(100 * moc_czynna * 1000 * dlugosc_przewodu / struktura_fazowa / struktura_fazowa / typ_zyl / dobrany_przekroj, 1);
                    if (spadek_napiecia < dopuszczalny_spadek)
                    {
                        p_spadek_check.Text = "✓";
                    }
                    if (spadek_napiecia > dopuszczalny_spadek)
                    {
                        p_spadek_check.Text = "X";
                    }
                }
                p_spadek_napiecia.Text = spadek_napiecia.ToString();
            }
        }


        

        private bool Pobierz_przekroj()
        {
            if (typ_norma.Checked == true && p_przekroj.Text == "")
            {
                Valueoftext = "Wybierz przekrój!";
                Kontrolki g = new Kontrolki();
                g.Show();
                return true;
            }
            else if (Wirenumbers.Contains(p_przekroj.Text))
            {
                dobrany_przekroj = float.Parse(p_przekroj.Text);
                return false;
            }
            else if (Wirenumbers2.Contains(p_przekroj.Text))
            {
                dobrany_przekroj = 2 * float.Parse(p_przekroj.Text.Remove(0, 2));
                return false;
            }
            else
            {
                return true;
            }
        }
        
        private void Dobierz_przekroj()
        {
            string name = CheckDoNormy();
            string przewody;
            
            XmlReader xtr = XmlReader.Create(FileName);
            if (typ_norma.Checked == true)
            {
                while (xtr.Read())
                {
                    for (int item = 0; item < Wirenumbers.Count; item++)
                    {
                    
                        przewody = Wirenumbers[item].ToString();
                        if (xtr.NodeType == XmlNodeType.Element && xtr.Name == name)
                        {
                            if (xtr.HasAttributes)
                            {
                                if (typ_tor.Checked == true)
                                {
                                    if (xtr.GetAttribute("Przekrój") == przewody)
                                    {
                                        this.b = xtr.GetAttribute(this.rodzaj_ulozenia);
                                        if (double.Parse(b) >= obl_prad)
                                        {
                                                p_prop_przekroj.Text = Wirenumbers[item].ToString();
                                                xtr.Close();
                                                break;
 
                                        }
                                    }
                                    
                                }
                                if (typ_tory.Checked == true)
                                {
                                    if (xtr.GetAttribute("Przekrój") == przewody)
                                    {
                                        this.b = xtr.GetAttribute(this.rodzaj_ulozenia);
                                        if (2*double.Parse(b) >= obl_prad)
                                        {
                                            p_prop_przekroj.Text ="2x"+Wirenumbers[item].ToString();
                                            xtr.Close();
                                            break;

                                        }
                                    }

                                }

                            }
                            
                        }
                        
                    }
                    if(p_przekroj.Text != "")
                    {
                        break;
                    }
                    
                }
            }  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main();
        }
        private string CheckDoNormy()
        {
            // 1-f Miedź PVC P2M
            if (p_struktura_fazowa.SelectedIndex == 0 && p_typ_zyl.SelectedIndex == 1 && p_typ_izolacji.SelectedIndex == 0)
            {
                return "P2M";
            }

            //  1-f Miedź XPLE X2M
            if (p_struktura_fazowa.SelectedIndex == 0 && p_typ_zyl.SelectedIndex == 1 && p_typ_izolacji.SelectedIndex == 1)
            {
                return "X2M";
            }

            // 1-f Aluminium PVC P2A
            if (p_struktura_fazowa.SelectedIndex == 0 && p_typ_zyl.SelectedIndex == 0 && p_typ_izolacji.SelectedIndex == 0)
            {
                return "P2A";
            }

            // 1-f Aluminium XPLE X2A
            if (p_struktura_fazowa.SelectedIndex == 0 && p_typ_zyl.SelectedIndex == 0 && p_typ_izolacji.SelectedIndex == 1)
            {
                return "X2A";
            }

            // 3-f Miedz PVC P3M
            if (p_struktura_fazowa.SelectedIndex == 1 && p_typ_zyl.SelectedIndex == 1 && p_typ_izolacji.SelectedIndex == 0)
            {
                return "P3M";
            }

            //3-f Miedz XPLE X3M
            if (p_struktura_fazowa.SelectedIndex == 1 && p_typ_zyl.SelectedIndex == 1 && p_typ_izolacji.SelectedIndex == 1)
            {
                return "X3M";
            }

            //3-f Aluminium PVC P3A
            if (p_struktura_fazowa.SelectedIndex == 1 && p_typ_zyl.SelectedIndex == 0 && p_typ_izolacji.SelectedIndex == 0)
            {
                return "P3A";
            }

            //3-f Aluminium XPLE X3A
            if (p_struktura_fazowa.SelectedIndex == 1 && p_typ_zyl.SelectedIndex == 0 && p_typ_izolacji.SelectedIndex == 1)
            {
                return "X3A";
            }
            else
            {
                return string.Empty;
            }
        }
        
        private void Pobierz_z_normy()
        {
            string name = CheckDoNormy();
            XmlReader xtr = XmlReader.Create(FileName);
            while (xtr.Read())
            {
                if (xtr.NodeType == XmlNodeType.Element && xtr.Name == name)
                {
                    if (xtr.HasAttributes)
                    {
                        if (typ_tor.Checked == true)
                        {
                            if (xtr.GetAttribute("Przekrój") == p_przekroj.Text)
                            {
                                this.dob_obc=xtr.GetAttribute(rodzaj_ulozenia);
                            }
                        }

                        if (typ_tory.Checked == true)
                        {
                            try
                            {
                                if (xtr.GetAttribute("Przekrój") == p_przekroj.Text.Remove(0, 2))
                                {
                                    this.dob_obc = (2 * (float.Parse(xtr.GetAttribute(rodzaj_ulozenia)))).ToString();
                                }
                            }
                            catch
                            {
                                Valueoftext = "Nie podano przekroju!";
                                Form x = new Kontrolki();
                                x.Show();
                                break;
                            }
                        }
                       
                    }
                    
                }

             
            }
        }

        private void Test_wartosci_1()
        {
            p_moc_czynna.Text = "4";
            p_dlugosc.Text = "10";
            p_struktura_fazowa.SelectedIndex = 0;
            p_typ_zyl.SelectedIndex = 1;
            p_typ_izolacji.SelectedIndex = 0;
            p_wartosc_bezpiecznika.SelectedIndex = 1;
            p_typ_ulozenia.SelectedIndex = 1;
            typ_tor.Checked = true;
            typ_katalog.Checked = true;
            p_typ_charakterystyki.SelectedIndex = 1;
        }
        private void Test_wartosci_2()
        {
            p_moc_czynna.Text = "30";
            p_dlugosc.Text = "100";
            p_struktura_fazowa.SelectedIndex = 1;
            p_typ_zyl.SelectedIndex = 1;
            p_typ_izolacji.SelectedIndex = 1;
            p_wartosc_bezpiecznika.SelectedIndex = 1;
            p_typ_ulozenia.SelectedIndex = 0;
            typ_tor.Checked = true;
            typ_norma.Checked = true;
            p_typ_charakterystyki.SelectedIndex = 1;
        }

        public void Wyswietl()
        {
            Console.WriteLine("Struktura fazowa: {0}", struktura_fazowa);
            Console.WriteLine("Rodzaj żył {0}", typ_zyl);
            Console.WriteLine("Typ izolacji {0}", rodzaj_izolacji);
            Console.WriteLine("Cosinus fi: {0}", cos_fi);
            Console.WriteLine("Tangens fi: {0}", tg_fi);
            Console.WriteLine("Moc czynna wynosi: {0}", moc_czynna);
            Console.WriteLine("Długość przewodu wynosi {0}", dlugosc_przewodu);
            Console.WriteLine("Wartość bezpiecznika wynosi {0}", wartosc_bezpiecznika);
            Console.WriteLine("Rodzaj ułożenia {0}", rodzaj_ulozenia);
            Console.WriteLine("Podaj ilość torów {0}", ilosc_torow);
            Console.WriteLine("Typ zabezpieczenia {0}", rodzaj_charakterystyki);
            Console.WriteLine("Obciążalność prądowa na podstawie: {0}", typ_obciazalnosci);
        }

        public bool Get_from_textbox()
        {
            try
            {
                cos_fi = float.Parse(p_cos_fi.Text);
                tg_fi = float.Parse(p_tg_fi.Text);
                moc_czynna = float.Parse(p_moc_czynna.Text);
                dlugosc_przewodu = float.Parse(p_dlugosc.Text);


                if (Check_wartosci() == true)
                {
                    return true;
                }
                return false;
            }
            catch
            {
                Valueoftext = "Nie wpisano wszystkich wartości!";
                Kontrolki g = new Kontrolki();
                g.Show();
                return false;
            }
        }

        private bool GetWartoscObcPrad()
        {
            Kontrolki g = new Kontrolki();
            try
            {
                if (p_obc_pradowa.Text == "-" )
                {
                    Valueoftext = "Nie ma takiego przewodu!";
                    g.Show();
                    return false;
                }
                if(p_obc_pradowa.Text == "0")
                {
                    Valueoftext = "Obciążalność równa 0!";
                    g.Show();
                    return false;
                }
                else
                {
                    this.obc_pradowa = double.Parse(p_obc_pradowa.Text);
                    return true;
                }
            }
            catch
            {
                Valueoftext = "Nie podano obciążalności prądowej";
                g.Show();
                return false;
            }
        }

        public bool Check_wartosci()
        {
            Valueoftext = "_";
            if (p_struktura_fazowa.SelectedIndex == -1)
            {
                Valueoftext = "Nie podano struktury fazowej!";
            }
            if (p_typ_zyl.SelectedIndex == -1)
            {
                Valueoftext = "Nie podano typu żył!";
            }
            if (p_typ_izolacji.SelectedIndex == -1)
            {
                Valueoftext = "Nie podano typu izolacji!";
            }
            if (p_wartosc_bezpiecznika.SelectedIndex == -1)
            {
                Valueoftext = "Nie podano wartości bezpiecznika!";
            }
            if (p_typ_ulozenia.SelectedIndex == -1)
            {
                Valueoftext = "Nie podano typu ułożenia!";
            }
            if (p_typ_charakterystyki.SelectedIndex == -1)
            {
                Valueoftext = "Nie podano typu charakterystyki zabezpieczenia!";
            }
            if (typ_tor.Checked == false && typ_tory.Checked == false)
            {
                Valueoftext = "Nie podano ilości torów!";
            }
            if (typ_katalog.Checked == false && typ_norma.Checked == false)
            {
                Valueoftext = "Nie podano rodzaju obciążalności!";
            }

            if (p_typ_zyl.SelectedIndex == 0)
            {
                if (Wirenumbers.Contains(p_przekroj.Text))
                {
                    if (float.Parse(p_przekroj.Text) < 16)
                    {
                        Valueoftext = "Przewód aluminiowy <16mm2";
                    }
                }
            }
            if (Valueoftext == "_")
            {
                return true;
            }
            else
            {
                Kontrolki g = new Kontrolki();
                g.Show();
                return false;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (p_struktura_fazowa.SelectedIndex == 0)
            {
                struktura_fazowa = 230;
            }
            if (p_struktura_fazowa.SelectedIndex == 1)
            {
                struktura_fazowa = 400;
            }
        }

        private void typ_zyl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (p_typ_zyl.SelectedIndex == 0)
            {
                typ_zyl = 33;
            }
            if (p_typ_zyl.SelectedIndex == 1)
            {
                typ_zyl = 55;
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void typ_izolacji_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (p_typ_izolacji.SelectedIndex == 0)
            {
                rodzaj_izolacji = "PVC";
            }
            if (p_typ_izolacji.SelectedIndex == 1)
            {
                rodzaj_izolacji = "XPLE";
            }
        }

        private void p_cos_fi_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }


            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void p_tg_fi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void p_moc_czynna_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void p_dlugosc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        private void CzyscWyniki()
        {
            p_prop_przekroj.Clear();
            p_obliczony_prad.Clear();
            p_spadek_napiecia.Clear();
            p_prop_bezpiecznik.Clear();
            p_obc_pradowa.Clear();
        }
        private void typ_tor_CheckedChanged(object sender, EventArgs e)
        {
            if (typ_tor.Checked == true && typ_tory.Checked == false)
            {
                CzyscWyniki();
                ilosc_torow = 1;
            }
            if (typ_tor.Checked == false && typ_tory.Checked == true)
            {
                ilosc_torow = 2;
                CzyscWyniki();
            }
        }

        private void typ_charakterystyki_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (p_typ_charakterystyki.SelectedIndex == 0 || p_typ_charakterystyki.SelectedIndex == 1 || p_typ_charakterystyki.SelectedIndex == 2 || p_typ_charakterystyki.SelectedIndex == 3)
            {
                rodzaj_charakterystyki = 1.45;
                btn_rodzaj_wkladki.Visible = false;
            }
            if (p_typ_charakterystyki.SelectedIndex == 4)
            {
                rodzaj_charakterystyki = 1.6;
                btn_rodzaj_wkladki.Visible = true;
            }
            if (p_typ_charakterystyki.SelectedIndex == 5)
            {
                rodzaj_charakterystyki = 1.6;
                btn_rodzaj_wkladki.Visible = true;
            }
            if (p_typ_charakterystyki.SelectedIndex == 6)
            {
                rodzaj_charakterystyki = 1.6;
                btn_rodzaj_wkladki.Visible = true;
            }



        }

        private void wartosc_bezpiecznika_SelectedIndexChanged(object sender, EventArgs e)
        {
            wartosc_bezpiecznika = int.Parse(p_wartosc_bezpiecznika.Text);
        }

        private void typ_ulozenia_SelectedIndexChanged(object sender, EventArgs e)
        {
            rodzaj_ulozenia = p_typ_ulozenia.Text;
        }

        private void typ_katalog_CheckedChanged(object sender, EventArgs e)
        {
            if (typ_katalog.Checked == true && typ_norma.Checked == false)
            {
                typ_obciazalnosci = "Katalog";
                btn_minus.Visible = true;
                btn_plus.Visible = true;
                p_obc_pradowa.ReadOnly = false;
                p_prop_przekroj.Clear();

            }
            if (typ_katalog.Checked == false && typ_norma.Checked == true)
            {
                //btn_minus.Visible = false;
                //btn_plus.Visible = false;

                p_obc_pradowa.ReadOnly = true;
                typ_obciazalnosci = "Norma";
            }
        }

        private void p_cos_fi_Leave(object sender, EventArgs e)
        {

            cos_fi = float.Parse(p_cos_fi.Text);
            if (cos_fi > 1 || cos_fi < 0)
            {
                MessageBox.Show("Błędna wartość cosinusa!", "Błąd", MessageBoxButtons.OK);
                p_cos_fi.Clear();
            }
        }

        private void p_tg_fi_Leave(object sender, EventArgs e)
        {
            tg_fi = float.Parse(p_tg_fi.Text);
            if (tg_fi > 1 || tg_fi < 0)
            {
                MessageBox.Show("Błędna wartość tangensa!", "Błąd", MessageBoxButtons.OK);
                p_tg_fi.Clear();
            }
        }

        private void p_przekroj_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void p_obc_pradowa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void btn_czysc_Click(object sender, EventArgs e)
        {
            p_moc_czynna.Clear();
            p_dlugosc.Clear();
            p_przekroj.Clear();
            p_spadek_napiecia.Clear();
            p_obliczony_prad.Clear();
            p_prop_bezpiecznik.Clear();
            p_obc_pradowa.Clear();
            p_opis_warunek_1.Text = "";
            p_opis_warunek_2.Text = "";
            p_spadek_napiecia.Clear();
            p_spadek_check.Text = "";
        }

        private void btn_plus_Click(object sender, EventArgs e)
        {
            if (typ_tor.Checked == true && typ_tory.Checked == false)
            {
                //Jesli 1 tor
                if (p_przekroj.Text == "")
                {
                    p_przekroj.Text = Wirenumbers[0];
                }
                else if (Wirenumbers.Contains(p_przekroj.Text))
                {
                    int indeks = Wirenumbers.FindIndex(a => a == p_przekroj.Text);
                    if (indeks < 15)
                    {
                        p_przekroj.Text = Wirenumbers[indeks + 1];
                    }
                }
                else if (Wirenumbers2.Contains(p_przekroj.Text))
                {
                    int indeks = Wirenumbers2.FindIndex(a => a == p_przekroj.Text);
                    if (indeks < 15)
                    {
                        p_przekroj.Text = Wirenumbers[indeks + 1];
                    }
                }
            }
            if (typ_tor.Checked == false && typ_tory.Checked == true)
            {
                //Jesli 2 tor
                if (p_przekroj.Text == "")
                {
                    p_przekroj.Text = Wirenumbers2[0];
                }

                else if (Wirenumbers2.Contains(p_przekroj.Text))
                {
                    int indeks = Wirenumbers2.FindIndex(a => a == p_przekroj.Text);
                    if (indeks < 15)
                    {
                        p_przekroj.Text = Wirenumbers2[indeks + 1];
                    }
                }
                else if (Wirenumbers.Contains(p_przekroj.Text))
                {
                    int indeks = Wirenumbers.FindIndex(a => a == p_przekroj.Text);
                    if (indeks < 15)
                    {
                        p_przekroj.Text = Wirenumbers2[indeks + 1];
                    }
                }
            }

        }

        private void btn_minus_Click(object sender, EventArgs e)
        {
            if (typ_tor.Checked == true && typ_tory.Checked == false)
            {
                //Jesli 1 tor
                if (p_przekroj.Text == "")
                {
                    p_przekroj.Text = Wirenumbers[0];
                }

                else if (Wirenumbers.Contains(p_przekroj.Text))
                {
                    int indeks = Wirenumbers.FindIndex(a => a == p_przekroj.Text);
                    if (indeks > 0)
                    {
                        p_przekroj.Text = Wirenumbers[indeks - 1];
                    }
                }
                else if (Wirenumbers2.Contains(p_przekroj.Text))
                {

                    int indeks = Wirenumbers2.FindIndex(a => a == p_przekroj.Text);
                    if (indeks > 0)
                    {
                        p_przekroj.Text = Wirenumbers[indeks - 1];
                    }
                }
            }
            if (typ_tor.Checked == false && typ_tory.Checked == true)
            {
                //Jesli 2 tor
                if (p_przekroj.Text == "")
                {
                    p_przekroj.Text = Wirenumbers2[0];
                }
                else if (Wirenumbers2.Contains(p_przekroj.Text))
                {
                    int indeks = Wirenumbers2.FindIndex(a => a == p_przekroj.Text);
                    if (indeks > 0)
                    {
                        p_przekroj.Text = Wirenumbers2[indeks - 1];
                    }
                }
                else if (Wirenumbers.Contains(p_przekroj.Text))
                {
                    int indeks = Wirenumbers.FindIndex(a => a == p_przekroj.Text);
                    if (indeks > 0)
                    {
                        p_przekroj.Text = Wirenumbers2[indeks - 1];
                    }
                }
            }
        }

        //Tylko do testów
        private void typ_norma_Click(object sender, EventArgs e)
        {
            p_obc_pradowa.Clear();
            p_przekroj.Clear();
            p_prop_bezpiecznik.Clear();
            p_spadek_napiecia.Clear();
            p_opis_warunek_1.Text = "";
            p_opis_warunek_2.Text = "";
        }

        private void typ_katalog_Click(object sender, EventArgs e)
        {
            p_obc_pradowa.Clear();
            p_przekroj.Clear();
            p_prop_bezpiecznik.Clear();
            p_spadek_napiecia.Clear();
            p_opis_warunek_1.Text = "";
            p_opis_warunek_2.Text = "";
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripMenuItem1_Click_1(object sender, EventArgs e)
        {

        }

        private void normyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form a = new RodzajeObcPradowej();
            a.Owner = this;
            a.Show();
        }

        private void rodzajeUłożeńToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form b = new RodzajeUlozen();
            b.Owner = this;
            b.Show();
        }

        private void m_item_1_Click(object sender, EventArgs e)
        {
            Form c = new RodzajSpadekNapiecia();
            c.Show();
        }

        private void splitter1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        public void Sprawdzenie_warunkow()
        {
            wskaznik = GetWartoscObcPrad();
            if (p_prop_bezpiecznik.Text == "")
            {

            }
            else
            {


                if (wskaznik == true)
                {
                    if (obl_prad <= int.Parse(p_prop_bezpiecznik.Text) && int.Parse(p_prop_bezpiecznik.Text) <= float.Parse(p_obc_pradowa.Text))
                    {
                        p_opis_warunek_1.Text = "✓";
                    }
                    if (float.Parse(p_prop_bezpiecznik.Text) * rodzaj_charakterystyki < 1.45 * float.Parse(p_obc_pradowa.Text))
                    {
                        p_opis_warunek_2.Text = "✓";
                    }
                    if (obl_prad > int.Parse(p_prop_bezpiecznik.Text) || int.Parse(p_prop_bezpiecznik.Text) > float.Parse(p_obc_pradowa.Text))
                    {
                        p_opis_warunek_1.Text = "X";
                    }
                    if (float.Parse(p_prop_bezpiecznik.Text) * rodzaj_charakterystyki > 1.45 * float.Parse(p_obc_pradowa.Text))
                    {
                        p_opis_warunek_2.Text = "X";
                    }
                }
            }
        }
        private void Wyswietlenie_warunkow()
        {
            var w1z1 = "";
            var w1z2 = "";
            var w2z1 = "";
            if (p_prop_bezpiecznik.Text == "")
            {
                Form x = new Kontrolki();
                Valueoftext = "Nie można obliczyć zabezpieczenia!";
                x.Show();
            }
            else
            {


                if (wskaznik == true)
                {
                    if (obl_prad < int.Parse(p_prop_bezpiecznik.Text) && int.Parse(p_prop_bezpiecznik.Text) < float.Parse(p_obc_pradowa.Text))
                    {
                        w1z1 = "<";
                        w1z2 = "<";
                    }
                    if (obl_prad > int.Parse(p_prop_bezpiecznik.Text) && int.Parse(p_prop_bezpiecznik.Text) > float.Parse(p_obc_pradowa.Text))
                    {
                        w1z1 = ">";
                        w1z2 = ">";
                    }
                    if (obl_prad > int.Parse(p_prop_bezpiecznik.Text) && int.Parse(p_prop_bezpiecznik.Text) < float.Parse(p_obc_pradowa.Text))
                    {
                        w1z1 = ">";
                        w1z2 = "<";
                    }
                    if (obl_prad < int.Parse(p_prop_bezpiecznik.Text) && int.Parse(p_prop_bezpiecznik.Text) > float.Parse(p_obc_pradowa.Text))
                    {
                        w1z1 = "<";
                        w1z2 = ">";
                    }
                    if (float.Parse(p_prop_bezpiecznik.Text) * rodzaj_charakterystyki > 1.45 * float.Parse(p_obc_pradowa.Text))
                    {
                        w2z1 = ">";
                    }
                    if (float.Parse(p_prop_bezpiecznik.Text) * rodzaj_charakterystyki < 1.45 * float.Parse(p_obc_pradowa.Text))
                    {
                        w2z1 = "<";
                    }
                    var tmp = (float.Parse(p_prop_bezpiecznik.Text) * rodzaj_charakterystyki).ToString();
                    p_warunek_wynik_1.Text = obl_prad.ToString() + w1z1 + p_prop_bezpiecznik.Text + w1z2 + p_obc_pradowa.Text;
                    p_warunek_wynik_2.Text = tmp + w2z1 + (1.45 * float.Parse(p_obc_pradowa.Text)).ToString();
                }
            }
        }
        private void p_dopuszczalny_spadek_napiecia_SelectedIndexChanged(object sender, EventArgs e)
        {
            dopuszczalny_spadek = float.Parse(p_dopuszczalny_spadek_napiecia.Text);
        }

        private void pomocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (clickCounter <= 1)
            {
                
                Form d = new Pomoc();
                d.Show();
            }
            if (clickCounter >= 10)
            {
                Form w = new PrivTest();
                w.Owner = this;
                w.Show();
                clickCounter = 0;
            }
            else clickCounter += 1;
        }

        private void btn_rodzaj_wkładki_Click(object sender, EventArgs e)
        {

        }
    }

}
