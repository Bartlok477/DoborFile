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
    public partial class Pomoc : Form
    {
        public Pomoc()
        {
            InitializeComponent();
        }

        private void Pomoc_Load(object sender, EventArgs e)
        {

        }

       
        private void linkLabel6_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Jeśli dobiera się przewód za pomocą normy, uzupełnia się automatycznie. Jeśli wybrano dobór na podstawie katalogu, należy uzupełnić samemu");
        }
    }
}
