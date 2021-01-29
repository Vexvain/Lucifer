using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SafeGuard;

namespace SafeGuardTemplate
{
    public partial class Register : Form
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
        public Register()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }
        private void Register_Load(object sender, EventArgs e)
        {

        }
        private void Start_Click(object sender, EventArgs e)
        {
            //Here, once register is successfull you can login automatically and show your main form
            ResponseInformation.registerinfo = ClientFunctions.Register(username.Text, password.Text, token.Text,
            email.Text, ProgramInformation.ProgramId);
            if (!ResponseInformation.registerinfo.Failure)
            {
                //Here we commense the login method
                ResponseInformation.loginresponse = ClientFunctions.Login(username.Text, password.Text, ProgramInformation.ProgramId);
                if (ResponseInformation.loginresponse.Failure)
                {
                    MessageBox.Show(ResponseInformation.loginresponse.Message);
                }
                else
                {
                    MessageBox.Show($"Successful Registration {SafeGuard.ResponseInformation.loginresponse.UserName}");
                    ResponseInformation.Password = password.Text;
                    this.Hide();
                    Login frmMain = new Login();
                    frmMain.ShowDialog();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show(ResponseInformation.registerinfo.Message);
            }
        }
        private void siticoneRoundedButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm frmMain = new MainForm();
            frmMain.ShowDialog();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Lucifer  Status : Closing", "Lucifer Stress");
            Environment.Exit(0);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void siticoneRoundedButton2_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }
    }
}
