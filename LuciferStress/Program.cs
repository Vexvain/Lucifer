using Newtonsoft.Json;
using SafeGuard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SafeGuardTemplate
{
    static class Program
    { 
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false); 
            SafeGuard.Tools.ProcessCheck();
            SafeCheck.Md5Check();
            SafeGuard.Update.update();
            ResponseInformation.count = DeveloperFunctions.CountCall(ProgramInformation.ProgramId); 
            if (Properties.Settings.Default.Username != "" || Properties.Settings.Default.Username != string.Empty)
            {
                ResponseInformation.loginresponse = ClientFunctions.Login(Properties.Settings.Default.Username, Properties.Settings.Default.PassWord, ProgramInformation.ProgramId); 
                ResponseInformation.Password = Properties.Settings.Default.PassWord;
                if (ResponseInformation.loginresponse.Failure)
                {
                    //Message will be the reason for failed login
                    MessageBox.Show(ResponseInformation.loginresponse.Message);
                    Application.Run(new MainForm());
                }
                else
                {
                    //Message will be "Successfully Logged In"
                    Task.Run(() => SafeGuard.DiscordLogging.DiscordLog("login", ResponseInformation.loginresponse.UserName, SafeGuard.Tools.GetClientIP()));
                    MessageBox.Show($"Hey {ResponseInformation.loginresponse.UserName} thanks for signing in!");
                    Application.Run(new DDOS());
                }
            }
            else
            {
                Application.Run(new MainForm());
            }

        }
    }
}
