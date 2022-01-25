using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;

namespace Testowe
{
    public partial class RodzajeObcPradowej : Form
    {
        //public string FileName = System.Reflection.Assembly.GetExecutingAssembly().Location;

        //public string FileName = AppDomain.CurrentDomain.BaseDirectory + @"\Dane1.xml";

        public string FileName = System.Reflection.Assembly.GetExecutingAssembly().Location + "\\..\\Dane1.xml";

        private int str_faz;
        private int typ_z; 
        private int typ_iz;

        MainProgram da = new MainProgram();
        public RodzajeObcPradowej()
        {
            
            InitializeComponent();
            Set_params();
        }

        private void Get_params()
        {
            this.str_faz = p_struktura_fazowa.SelectedIndex;
            this.typ_z = p_typ_zyl.SelectedIndex;
            this.typ_iz = p_typ_izolacji.SelectedIndex;
        }
        private void Set_params()
        {
            p_struktura_fazowa.SelectedIndex = 0;
            p_typ_zyl.SelectedIndex = 0;
            p_typ_izolacji.SelectedIndex = 0;
        }


        private void GetFromXML()
        {
            DataSet ds = new DataSet();
            ds.ReadXml(FileName);
            //"E:/Testy C#/Testowe/Testowe/Dane1.xml"
            if (this.str_faz ==0 && this.typ_z==1 && this.typ_iz==0)
            {
                d_grid_1.DataSource = ds.Tables["P2M"];
            }
            if(this.str_faz ==0 && this.typ_z==1 && this.typ_iz == 1)
            {
                d_grid_1.DataSource = ds.Tables["X2M"];
            }
            if (this.str_faz == 0 && this.typ_z == 0 && this.typ_iz == 0)
            {
                d_grid_1.DataSource = ds.Tables["P2A"];
            }
            if (this.str_faz == 0 && this.typ_z == 0 && this.typ_iz == 1)
            {
                d_grid_1.DataSource = ds.Tables["X2A"];
            }
            if(this.str_faz==1 && this.typ_z == 1 && this.typ_iz == 0)
            {
                d_grid_1.DataSource = ds.Tables["P3M"];
            }
            if (this.str_faz == 1 && this.typ_z == 1 && this.typ_iz == 1)
            {
                d_grid_1.DataSource = ds.Tables["X3M"];
            }
            if (this.str_faz == 1 && this.typ_z == 0 && this.typ_iz == 0)
            {
                d_grid_1.DataSource = ds.Tables["P3A"];
            }
            if (this.str_faz == 1 && this.typ_z == 0 && this.typ_iz == 1)
            {
                d_grid_1.DataSource = ds.Tables["X3A"];
            }

        }
        private void Form2_Load(object sender, EventArgs e)
        {
            Set_params(); 
        }

        private void p_typ_izolacji_SelectedIndexChanged(object sender, EventArgs e)
        {
            Get_params();
            GetFromXML();
        }

        private void p_typ_zyl_SelectedIndexChanged(object sender, EventArgs e)
        {
            Get_params();
            GetFromXML();
        }

        private void p_struktura_fazowa_SelectedIndexChanged(object sender, EventArgs e)
        {
            Get_params();
            GetFromXML();
        }

        private void GetData()
        {
            da = (MainProgram)this.Owner;
            if (this.p_struktura_fazowa.SelectedIndex == 0)
            {
                da.p_struktura_fazowa.SelectedIndex = 0;
            }
            if(this.p_struktura_fazowa.SelectedIndex == 1)
            {
                da.p_struktura_fazowa.SelectedIndex = 1;
            }
            if(this.p_typ_zyl.SelectedIndex == 0)
            {
                da.p_typ_zyl.SelectedIndex = 0;
            }
            if (this.p_typ_zyl.SelectedIndex == 1)
            {
                da.p_typ_zyl.SelectedIndex = 1;
            }
            if (this.p_typ_izolacji.SelectedIndex == 0)
            {
                da.p_typ_izolacji.SelectedIndex = 0;
            }
            if (this.p_typ_izolacji.SelectedIndex == 1)
            {
                da.p_typ_izolacji.SelectedIndex = 1;
            }
        }

        private void GetUlozenie()
        {
            string ulozenie = d_grid_1.SelectedCells[0].OwningColumn.HeaderText.ToString();
            
            da = (MainProgram)this.Owner;
            if (ulozenie == "A1")
            {
                da.p_typ_ulozenia.SelectedIndex = 0;
            }
            if(ulozenie == "A2")
            {
                da.p_typ_ulozenia.SelectedIndex = 1;
            }
            if (ulozenie == "B1")
            {
                da.p_typ_ulozenia.SelectedIndex = 2;
            }
            if (ulozenie == "B2")
            {
                da.p_typ_ulozenia.SelectedIndex = 3;
            }
            if (ulozenie == "C")
            {
                da.p_typ_ulozenia.SelectedIndex = 4;
            }
            if (ulozenie == "D")
            {
                da.p_typ_ulozenia.SelectedIndex = 5;
            }
            if (ulozenie == "E")
            {
                da.p_typ_ulozenia.SelectedIndex = 6;
            }
            if (ulozenie == "F")
            {
                da.p_typ_ulozenia.SelectedIndex = 7;
            }
        }
        private void d_grid_1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
            if(da.typ_tor.Checked == true && da.typ_norma.Checked==true)
            {
                GetData();
                
                da = (MainProgram)this.Owner;
                GetUlozenie();
                if (d_grid_1.CurrentCell.Value.ToString() !="-" || d_grid_1.CurrentCell.Value.ToString() != "0")
                {

                    
                    if(da.typ_tor.Checked == true)
                    {
                        da.p_obc_pradowa.Text = d_grid_1.CurrentCell.Value.ToString();
                        da.p_przekroj.Text = d_grid_1[0, d_grid_1.CurrentCell.RowIndex].Value.ToString();
                    }

                    if(da.typ_tory.Checked == true)
                    {
                        double tmp = Convert.ToDouble(d_grid_1.CurrentCell.Value);
                        tmp = 2 * tmp;
                        da.p_obc_pradowa.Text = tmp.ToString();
                        string tmp2;
                        tmp2 = Convert.ToString(d_grid_1[0, d_grid_1.CurrentCell.RowIndex].Value);
                        tmp2 = "2x" + tmp2;
                        da.p_przekroj.Text = tmp2;

                    }

                    this.Close();
                }
                else
                {

                }
                

                    

                   
                
            }
            
            
        }
    }
}
