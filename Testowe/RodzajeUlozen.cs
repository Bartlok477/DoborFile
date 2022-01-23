using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Testowe
{
    public partial class RodzajeUlozen : Form
    {
        
        
        public RodzajeUlozen()
        {
            InitializeComponent();
        }
        MainProgram dx = new MainProgram();

        private void linkLabel1_Click(object sender, EventArgs e)
        {
            dx = (MainProgram)this.Owner;
            dx.p_typ_ulozenia.SelectedIndex = 0;
            this.Close();
        }

        private void linka_A2_Click(object sender, EventArgs e)
        {
            dx = (MainProgram)this.Owner;
            dx.p_typ_ulozenia.SelectedIndex = 1;
            this.Close();
        }

        private void link_B1_Click(object sender, EventArgs e)
        {
            dx = (MainProgram)this.Owner;
            dx.p_typ_ulozenia.SelectedIndex = 2;
            this.Close();
        }

        private void link_B2_Click(object sender, EventArgs e)
        {
            dx = (MainProgram)this.Owner;
            dx.p_typ_ulozenia.SelectedIndex = 3;
            this.Close();
        }
        private void link_C_Click(object sender, EventArgs e)
        {
            dx = (MainProgram)this.Owner;
            dx.p_typ_ulozenia.SelectedIndex = 4;
            this.Close();
        }

        private void link_D_Click(object sender, EventArgs e)
        {
            dx = (MainProgram)this.Owner;
            dx.p_typ_ulozenia.SelectedIndex = 5;
            this.Close();
        }

        private void link_E_Click(object sender, EventArgs e)
        {
            dx = (MainProgram)this.Owner;
            dx.p_typ_ulozenia.SelectedIndex = 6;
            this.Close();
        }

        private void link_F_Click(object sender, EventArgs e)
        {
            dx = (MainProgram)this.Owner;
            dx.p_typ_ulozenia.SelectedIndex = 7;
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
