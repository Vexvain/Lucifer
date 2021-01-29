using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Runtime.InteropServices;
using System.Drawing.Drawing2D;

namespace SafeGuardTemplate
{
    public partial class MainForm : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
            (
            int nLeftRect,
            int nTopRect,
            int RightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
            );
        public void RecRound(Graphics g, Pen p, float X, float Y, float width, float height, float radius)
        {
            GraphicsPath gp = new GraphicsPath();
            //Upper-right arc:
            gp.AddArc(X + width - (radius * 2), Y, radius * 2, radius * 2, 270, 90);
            //Lower-right arc:
            gp.AddArc(X + width - (radius * 2), Y + height - (radius * 2), radius * 2, radius * 2, 0, 90);
            //Lower-left arc:
            gp.AddArc(X, Y + height - (radius * 2), radius * 2, radius * 2, 90, 90);
            //Upper-left arc:
            gp.AddArc(X, Y, radius * 2, radius * 2, 180, 90);
            gp.CloseFigure();
            g.DrawPath(p, gp);
            gp.Dispose();
        }
        public MainForm()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var newss = new WebClient().DownloadString("https://pastebin.com/raw/qsZk3DWc");
            richTextBox1.Text = newss;      
        }
        private void customizedesign()
        {
            mediasubmenu.Visible = false;
        }
        private void hidesubmenu()
        {
            if (mediasubmenu.Visible == true)
                mediasubmenu.Visible = false;
        }
        private void displaysub(Panel subMenu)
        {
            if (mediasubmenu.Visible == false)
            {
                hidesubmenu();
                mediasubmenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }
        private void safeguard_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var Online = new WebClient().DownloadString("https://pastebin.com/raw/A0qNz1UK").Split('\n');
            safeguard.Text = Online[new Random().Next(0, Online.Length)];
            if (safeguard.Text == "OFFLINE")
            {
                safeguard.LinkColor = Color.DarkRed;
            }
        }

        private void mainhub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var Online = new WebClient().DownloadString("https://pastebin.com/raw/A0qNz1UK").Split('\n');
            mainhub.Text = Online[new Random().Next(0, Online.Length)];
            if (mainhub.Text == "OFFLINE")
            {
                mainhub.LinkColor = Color.DarkRed;
            }
        }

        private void register_Click(object sender, EventArgs e)
        {
           
        }

        private void login_Click(object sender, EventArgs e)
        {
           
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void main_Click(object sender, EventArgs e)
        {
            displaysub(mediasubmenu);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Lucifer  Status : Closing", "Lucifer Stress");
            Environment.Exit(0);
        }

        private void login_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Login frm1 = new Login();
            frm1.ShowDialog();
        }

        private void register_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Register frm1 = new Register();
            frm1.ShowDialog();
        }

        private void sidemenupanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void gunaCirclePictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
