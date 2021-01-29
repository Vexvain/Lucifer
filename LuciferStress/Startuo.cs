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
    public partial class Startuo : Form
    {
        public Startuo()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("THIS SHIT  IS A RAT");
        }
       
        private void d_Load(object sender, EventArgs e)
        {
            MessageBox.Show("THIS SHIT  IS A RAT");
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < progressBar1.Maximum)
            {
                progressBar1.Value = progressBar1.Value + 4;
            }
            if (progressBar1.Value == progressBar1.Maximum)
            {
                timer1.Stop();
                this.Hide();
                MainForm f2 = new MainForm();
                f2.ShowDialog();
                progressBar1.Value = progressBar1.Maximum;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("THIS SHIT  IS A RAT");
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("THIS SHIT  IS A RAT");
        }
    }
}
