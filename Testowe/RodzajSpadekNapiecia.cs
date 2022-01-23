using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace Testowe
{
    public partial class RodzajSpadekNapiecia : Form
    {
        public double dopuszczalny_spadek =3.5;
        public RodzajSpadekNapiecia()
        {
            InitializeComponent();
            p_spadek_napiecia.SelectedIndex = 0;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            //Console.WriteLine(p_spadek_napiecia.Text);
            this.dopuszczalny_spadek = double.Parse(p_spadek_napiecia.Text);
            this.Close();   
        }
    }
}
