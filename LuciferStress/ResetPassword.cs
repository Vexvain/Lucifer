using SafeGuard;
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
    public partial class ResetPassword : Form
    {
        public ResetPassword()
        {
            InitializeComponent();
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            ErrorResponse err = ClientFunctions.ResetPassword(usernameTB.Text, ProgramInformation.ProgramId, passTB.Text, tokenTB.Text);
            if (err.Failure)
            {
                MessageBox.Show(err.Message, SafeGuardTitle.safeguardtitle);
            }
            else
            {
                MessageBox.Show(err.Message, SafeGuardTitle.safeguardtitle);

                ResponseInformation.loginresponse = ClientFunctions.Login(usernameTB.Text, passTB.Text, ProgramInformation.ProgramId);
                if (ResponseInformation.loginresponse.Failure)
                {
                    MessageBox.Show(ResponseInformation.loginresponse.Message, SafeGuardTitle.safeguardtitle);
                }
                else
                {
                    ResponseInformation.Password = passTB.Text;
                    MessageBox.Show(ResponseInformation.loginresponse.Message, SafeGuardTitle.safeguardtitle);
                    this.Hide();
                    //MainForm frmMain = new MainForm();
                    //frmMain.ShowDialog();
                    this.Close();
                }
            }
        }
    }
}
