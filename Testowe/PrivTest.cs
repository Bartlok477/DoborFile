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
    
    public partial class PrivTest : Form
    {
        MainProgram dx = new MainProgram();
        public PrivTest()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            dx = (MainProgram)this.Owner;
            
            dx.p_prop_przekroj.Clear();
            dx.p_obliczony_prad.Clear();
            dx.p_prop_bezpiecznik.Clear();
            dx.p_przekroj.Clear();
            dx.p_obc_pradowa.Clear();
        }
    }
}
