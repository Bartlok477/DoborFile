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
    public partial class Kontrolki : Form
    {
        public Kontrolki()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button_Load(object sender, EventArgs e)
        {
            label1.Text = MainProgram.Valueoftext;
        }
    }
}
