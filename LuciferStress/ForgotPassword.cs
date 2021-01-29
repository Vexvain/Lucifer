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
    public partial class ForgotPassword : Form
    {
        public ForgotPassword()
        {
            InitializeComponent();
        }

        private void forgotBtn_Click(object sender, EventArgs e)
        {
            ErrorResponse err = ClientFunctions.ForgotPassword(usernameTB.Text, ProgramInformation.ProgramId);
            if (err.Failure)
            {
                MessageBox.Show(err.Message, SafeGuardTitle.safeguardtitle);
            }
            else
            {
                MessageBox.Show("Check Email For Password Reset Token", SafeGuardTitle.safeguardtitle);
                this.Hide();
                ResetPassword frmReg = new ResetPassword();
                frmReg.ShowDialog();
                this.Close();
            }
        }
    }
}
