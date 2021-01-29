using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SafeGuardTemplate
{
    public partial class Opacity2 : Form
    {
        public Opacity2()
        {
            InitializeComponent();
        }
        public static double opac;
        private void button1_Click(object sender, EventArgs e)
        {
             
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            MessageBox.Show("THIS SHIT  IS A RAT");
        }
    }
}
