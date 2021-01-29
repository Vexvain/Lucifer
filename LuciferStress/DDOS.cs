using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;
using SafeGuard;

namespace SafeGuardTemplate
{
    public partial class DDOS : Form
    {
        WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();
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
        private bool mouseDown;
        private Point lastLocation;
        public DDOS()
        {
            InitializeComponent();
            timer1.Start();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25)); 
          }
        private void siticoneRoundedButton13_Click(object sender, EventArgs e)
        {
            MessageBox.Show($" API 1 : ONLINE {Environment.NewLine} API 2 : ONLINE {Environment.NewLine} API 3 : ONLINE {Environment.NewLine} API 4 : ONLINE {Environment.NewLine} API 5 : ONLINE", "Lucifer Stress");
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void label11_Click(object sender, EventArgs e)
        {

        }
        private void label12_Click(object sender, EventArgs e)
        {

        }
        private void label14_Click(object sender, EventArgs e)
        {

        }
        private void label24_Click(object sender, EventArgs e)
        {

        }
        private void label27_Click(object sender, EventArgs e)
        {

        }
        private void label7_Click(object sender, EventArgs e)
        {

        }
        private void label10_Click(object sender, EventArgs e)
        {

        }
        private void label16_Click(object sender, EventArgs e)
        {

        }
        private void label17_Click(object sender, EventArgs e)
        {

        }
        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
        private void customdesign()
        {
            toolsmenu.Visible = false;
            UIBar.Visible = false;
            sidemenubar.Visible = false;
            Other.Visible = false;
        }
        private void hideUIbar()
        {
            if (UIBar.Visible == true)
                UIBar.Visible = false;
        }
        private void DisplayStatts()
        {

        }
        private void hideStats()
        {

        }
        private void hidesidebar()
        {
            if (sidemenubar.Visible == true)
                sidemenubar.Visible = false;
        }
        private void HideOtherbar()
        {
            if (Other.Visible == true)
                Other.Visible = false;
        }
        private void Displaysidebar(Panel sidebar)
        {
            if (sidemenubar.Visible == false)
            {
                hidesidebar();
                sidemenubar.Visible = true;
            }
            else
                sidemenubar.Visible = false;
        }
        private void Displayotherbar()
        {
            if (Other.Visible == false)
            {
                HideOtherbar();
                Other.Visible = true;
            }
            else
                Other.Visible = false;
        }
        private void displayUIBar(Panel account)
        {
            if (UIBar.Visible == false)
            {
                hideUIbar();
                UIBar.Visible = true;
            }
            else
                UIBar.Visible = false;
        }
        private void hidetools()
        {
            if (toolsmenu.Visible == true)
                toolsmenu.Visible = false;
        }
        private void displaypanels(Panel toolsmenu)
        {
            if (toolsmenu.Visible == false)
            {
                hidetools();
                toolsmenu.Visible = true;
            }
            else
                toolsmenu.Visible = false;
        }
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }
        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }
        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }
        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }
        private void panel17_Paint(object sender, PaintEventArgs e)
        {

        }
        private void panel16_Paint(object sender, PaintEventArgs e)
        {

        }
        private void label8_Click(object sender, EventArgs e)
        {
            Displaysidebar(sidemenubar);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            displaypanels(toolsmenu);
        }
        private void button10_Click(object sender, EventArgs e)
        {

        }
        private void button6_Click(object sender, EventArgs e)
        {
            displayUIBar(UIBar);
        }
        private void DDOS_Load(object sender, EventArgs e)
        {
            MessageBox.Show("THIS SHIT  IS A RAT");
            MessageBox.Show("THIS SHIT  IS A RAT");
            WebClient usersssss = new WebClient();
            string userss = usersssss.DownloadString("https://pastebin.com/raw/EsEXSALd");
            label15.Text = userss;
            label2.Text = SafeGuard.ResponseInformation.count.UserCount.ToString();
            label4.Text = SafeGuard.ResponseInformation.count.BotnetCount.ToString();
            {
                switch (SafeGuard.ResponseInformation.loginresponse.Level)
                {
                    case 1:
                        label24.Text = "400";
                        to.Text = "1-400";
                        label5.Text = "1";
                        break;
                    case 2:
                        label24.Text = "800";
                        to.Text = "1-800";
                        label5.Text = "2";
                        break;
                    case 3:
                        label5.Text = "2";
                        label24.Text = "1200";
                        to.Text = "1-1200";
                        break;
                    case 4:
                        label5.Text = "3";
                        label24.Text = "3600";
                        to.Text = "1-3600";
                        break;
                    case 10:
                        label5.Text = "4";
                        label24.Text = "3600";
                        to.Text = "1-3600";
                        break;
                }
            }
        }
        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("THIS SHIT  IS A RAT");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start("CMD.exe", $"/K ping {IP.Text} -t");
        }
        private void button4_Click(object sender, EventArgs e)
        {
            WebClient wc = new WebClient { }; string iplookup = wc.DownloadString("http://ip-api.com/line/" + IP.Text); MessageBox.Show(this, iplookup);
            if (iplookup.Contains("Comcast"))
            {
                MessageBox.Show(IP.Text + " This IP is Blacklisted ");
                return;
            }
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void panel16_Paint_1(object sender, PaintEventArgs e)
        {

        }
        private void label55_Click(object sender, EventArgs e)
        {
             
        }
        private void label2_Click(object sender, EventArgs e)
        {
             
        }
        private void label3_Click(object sender, EventArgs e)
        { 
           
        }
        private void siticoneRoundedButton9_Click(object sender, EventArgs e)
        {

        }
        private void siticoneRoundedButton6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("THIS SHIT  IS A RAT");
        }

        private void siticoneRoundedButton7_Click(object sender, EventArgs e)
        {

        }

        private void siticoneRoundedButton2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://discord.link/uVW4zed");
        }

        private void siticoneRoundedButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Coming Soon");
        }
        int time = 99999;
        private void Start_Click(object sender, EventArgs e)
        {
            WebClient sw = new WebClient();
            string blacklist = new System.Net.WebClient() { Proxy = null }.DownloadString("https://pastebin.com/raw/F9S0tyRu");
            string ws = sw.DownloadString("https://pastebin.com/raw/gSd4AVAG");
            if (blacklist.Contains(IP.Text))
            {
                MessageBox.Show(IP.Text + " This IP is Blacklisted ");
                return;
            }
            if (IP.Text == $"{SafeGuard.Tools.GetClientIP()}")
            {
                MessageBox.Show("Your Trying To Hit Your Current IP");
                return;
            }
            if (ws.Contains(Methods.Text))
            {
                try
                {
                    time = Int32.Parse(to.Text);
                }
                catch
                {
                    MessageBox.Show(" Time Input Must Be A Number ");
                    return;
                }
                if (time > 200)
                {
                    MessageBox.Show("You Can Only Hit For 200 Seconds Using This Method", "Lucifer Stress");
                    return;
                }
            }
            else
            {

            }
            try
            {
                time = Int32.Parse(to.Text);
            }
            catch
            {
                MessageBox.Show("Time Input Must Be A Number");
                return;
            }
            try
            {
                time = Int32.Parse(to.Text);
            }
            catch
            {
                MessageBox.Show("Time Input Must Be A Number");
                return;
            }
            try
            {
                time = Int32.Parse(to.Text);
            }
            catch
            {
                MessageBox.Show("Time Input Must Be A Number");
                return;
            }
            if (time > 3600)
            {
                MessageBox.Show("Time Must Be Lower Than 3600 Seconds");
                return;
            }
            else
            {
                try
                {
                    time = Int32.Parse(to.Text);
                }
                catch
                {
                    MessageBox.Show("Time Input Must Be A Number");
                    return;
                }
                if (time > 99999999)
                {
                    MessageBox.Show("Time Must Be Lower Than 99999999 Seconds");
                    return;
                }
                else
                {
                    MessageBox.Show("THIS SHIT  IS A RAT");
                }
            }
        } 
        int max;
        private void timer1_Tick(object sender, EventArgs e)
        {

            #region CoolDown
            {
                if (SafeGuard.ResponseInformation.loginresponse.Level == 1)
                {
                    max = 1500;
                }
                if (SafeGuard.ResponseInformation.loginresponse.Level == 2)
                {
                    max = 1500;
                }
                if (SafeGuard.ResponseInformation.loginresponse.Level == 3)
                {
                    max = 1500;
                }
                if (SafeGuard.ResponseInformation.loginresponse.Level == 4)
                {
                    max = 250;
                }
                if (SafeGuard.ResponseInformation.loginresponse.Level == 10)
                {
                    max = 100;
                }
            }
            siticoneProgressBar2.Maximum = max;
            if (siticoneProgressBar2.Value < siticoneProgressBar2.Maximum)
            {
                siticoneProgressBar2.Value = siticoneProgressBar2.Value + 1;
            }
            if (siticoneProgressBar2.Value == siticoneProgressBar2.Maximum)
            {
                timerbar.Stop();
                MessageBox.Show("CoolDown Has Finished", "Lucifer Stress");
                siticoneProgressBar2.Value = siticoneProgressBar2.Maximum;
                Start.Enabled = true;
            }
            #endregion
        }
        private void siticoneRoundedButton8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("THIS SHIT  IS A RAT");
        }
        private void siticoneRoundedButton3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://discord.gg/uVW4zed");
        }
        private void label35_Click(object sender, EventArgs e)
        {

        }
        private void Methods_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void siticoneRoundedButton10_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ALL METHODS SLAP", "Lucifer Stress");
        }
        private void siticoneRoundedButton11_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ALL METHODS HIT DIFFERENT", "Lucifer Stress");
        }
        private void down(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }
        private void up(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
        private void move(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }
        private void siticoneProgressBar1_ValueChanged(object sender, EventArgs e)
        {

        }
        private void MethodStatsDV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void siticoneRoundedButton4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("THIS SHIT  IS A RAT");
        }
        private void button11_Click(object sender, EventArgs e)
        {

        }
        private void button9_Click(object sender, EventArgs e)
        {
            DisplayStatts();
        }
        private void button10_Click_1(object sender, EventArgs e)
        {
            Displayotherbar();
        }
        private void button13_Click(object sender, EventArgs e)
        {
            MessageBox.Show("THIS SHIT  IS A RAT");
        }
        private void button14_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }
        private void pictureBox21_Click(object sender, EventArgs e)
        {
            MessageBox.Show("THIS SHIT  IS A RAT");
        }
        private void pictureBox22_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox21_Click_1(object sender, EventArgs e)
        {

        }
        private void pictureBox22_Click_1(object sender, EventArgs e)
        {

        }
        private void pictureBox21_Click_2(object sender, EventArgs e)
        { 
            
        }
        private void pictureBox22_Click_2(object sender, EventArgs e)
        {
            MessageBox.Show("THIS SHIT  IS A RAT");
        }
        private void siticoneRoundedButton4_Click_1(object sender, EventArgs e)
        {

        }
        private void SiticoneRoundedButton4_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
        private void siticoneRoundedTextBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void label53_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox16_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }
        private void timer1_Tick_1(object sender, EventArgs e)
        {

        }
        private void pictureBox22_Click_3(object sender, EventArgs e)
        {
            MessageBox.Show("THIS SHIT  IS A RAT");
        }
        private void timer1_Tick_2(object sender, EventArgs e)
        {

        }
        private void siticoneProgressBar2_ValueChanged(object sender, EventArgs e)
        {

        }
        private void label9_Click(object sender, EventArgs e)
        {

        }
        private void label18_Click(object sender, EventArgs e)
        {

        }
        private void label17_Click_1(object sender, EventArgs e)
        {

        }
        private void label16_Click_1(object sender, EventArgs e)
        {

        }
        private void label15_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }
        private void label32_Click(object sender, EventArgs e)
        {

        }
        private void label7_Click_1(object sender, EventArgs e)
        {

        }
        private void label9_Click_1(object sender, EventArgs e)
        {

        }
        private void label30_Click(object sender, EventArgs e)
        {

        }
        private void label4_Click_1(object sender, EventArgs e)
        {

        }
        private void siticoneRoundedButton6_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("THIS SHIT  IS A RAT");
        }
        private void siticoneRoundedButton5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("THIS SHIT  IS A RAT");
        }
        private void siticoneRoundedButton7_Click_1(object sender, EventArgs e)
        {
            pictureBox20.Show();
        }
        private void siticoneRoundedButton2_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("THIS SHIT  IS A RAT");
        }
        private void button11_Click_1(object sender, EventArgs e)
        {

        }
        private void Netflix_Click(object sender, EventArgs e)
        {
            MessageBox.Show("THIS SHIT  IS A RAT");
        }
        private void button12_Click(object sender, EventArgs e)
        {
            MessageBox.Show("THIS SHIT  IS A RAT");
        }
        private void button13_Click_1(object sender, EventArgs e)
        {

        }
        private void button8_Click_1(object sender, EventArgs e)
        {
            
        }

        private void ColorChanger2()
        {
            MessageBox.Show("THIS SHIT  IS A RAT");
        }

            private void ColorChanger()
            {
            MessageBox.Show("QRATS IS A RAT");
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                System.Drawing.Color color2 = colorDialog1.Color;
                Properties.Settings.Default.colorc2 = color2;
                Properties.Settings.Default.Save();
                ColorChanger2();
            }
        }
        private void button5_Click_1(object sender, EventArgs e)
        {
            string strCmdText;
            //For TCP PING
            strCmdText = "/K pingg" + " " + IP.Text + " " + "-p" + " " + Port.Text;
            System.Diagnostics.Process.Start("CMD.exe", strCmdText);
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            string strCmdText;
            strCmdText = "/K ping" + " " + IP.Text + " " + "-t";
            System.Diagnostics.Process.Start("CMD.exe", strCmdText);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            WebClient wc = new WebClient { }; string portscan = wc.DownloadString("https://api.hackertarget.com/nmap/?q=" + IP.Text); MessageBox.Show(this, portscan);
        }
        private void button4_Click_1(object sender, EventArgs e)
        {
            Task.Run(() => ("geoip", ResponseInformation.loginresponse.UserName, Tools.GetClientIP(), IP.Text));

            string res = SafeGuard.Tools.GeoIP(IP.Text, ResponseInformation.loginresponse.UserName, ResponseInformation.Password, ProgramInformation.ProgramId);
            res = res.Replace("\"", string.Empty);
            res = res.Replace("\\r\\n", Environment.NewLine);
            MessageBox.Show(res, "Lucifer Stress");
        }
        private void label19_Click(object sender, EventArgs e)
        {

        }
        private void siticoneRoundedButton9_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show($"Your IP Is {SafeGuard.Tools.GetClientIP()}");
        }
        private void siticoneRoundedButton12_Click(object sender, EventArgs e)
        {

        }
        private void siticoneRoundedButton15_Click(object sender, EventArgs e)
        {
            var newss = new WebClient().DownloadString("https://pastebin.com/raw/wyPT1hLS");
            MessageBox.Show($"{newss}", "HOME LIST");
        }
        private void siticoneRoundedButton12_Click_1(object sender, EventArgs e)
        {
            var newss = new WebClient().DownloadString("https://pastebin.com/raw/nbPx1Gtf");
            MessageBox.Show($"{newss}", "HYDRA LIST");
        }
        private void siticoneRoundedButton16_Click(object sender, EventArgs e)
        {
            var newss = new WebClient().DownloadString("https://pastebin.com/raw/Cdekn62f");
            MessageBox.Show($"{newss}", "NORD LIST");
        }
        private void siticoneRoundedButton17_Click(object sender, EventArgs e)
        {
            var newss = new WebClient().DownloadString("https://pastebin.com/raw/H26dHfyu");
            MessageBox.Show($"{newss}", "SITE LIST");
        }
        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }
        private void siticoneRoundedButton14_Click(object sender, EventArgs e)
        {
            var newss = new WebClient().DownloadString("https://pastebin.com/raw/H26dHfyu");
            MessageBox.Show($"{newss}", "COURVIX LIST");
        }
        private void pictureBox17_Click(object sender, EventArgs e)
        {

        }
        private void siticoneRoundedButton3_Click_1(object sender, EventArgs e)
        {
            player.controls.play();
        }
        private void siticoneRoundedButton4_Click_2(object sender, EventArgs e)
        {
            player.controls.pause();
        }
        private void label35_Click_1(object sender, EventArgs e)
        {

        }
        private void siticoneRoundedButton18_Click(object sender, EventArgs e)
        {
            if (player.settings.volume < 90)
            {
                player.settings.volume = (player.settings.volume + 10);
            }
        }
        private void siticoneRoundedButton19_Click(object sender, EventArgs e)
        {
            if (player.settings.volume > 1)
            {
                player.settings.volume = (player.settings.volume - (player.settings.volume / 2));
            }
        }
        private void siticoneRoundedButton20_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ABSOLUTLY NOTHING");
        }
        private void siticoneRoundedButton21_Click(object sender, EventArgs e)
        {
            MessageBox.Show("NO STATS AVAILABLE");
        }
        private void pictureBox23_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox3_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }
        private void panel12_Paint(object sender, PaintEventArgs e)
        {

        }
        private void button14_Click_1(object sender, EventArgs e)
        {

        }
        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }
        private void richTextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
        private void button9_Click_1(object sender, EventArgs e)
        {
            string strCmdText;
            strCmdText = "/K ping" + " " + "1.1.1.1" + " " + "-t";
            System.Diagnostics.Process.Start("CMD.exe", strCmdText);
        }

        private void to_TextChanged(object sender, EventArgs e)
        {

        }

        private void Methods_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void pictureBox27_Click(object sender, EventArgs e)
        {
          
        }

        private void pictureBox21_Click_3(object sender, EventArgs e)
        {
          
        }

        private void xuiCustomGroupbox29_Enter(object sender, EventArgs e)
        {

        }

        private void xuiCustomGroupbox28_Enter(object sender, EventArgs e)
        {

        }

        private void xuiCustomGroupbox27_Enter(object sender, EventArgs e)
        {

        }

        private void xuiCustomGroupbox30_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox32_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox28_Click(object sender, EventArgs e)
        {

        }

        private void siticoneRoundedButton3_Click_2(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Image image = Image.FromFile(ofd.FileName);
                pictureBox2.BackgroundImage = image;
                pictureBox20.Visible = false;
                Properties.Settings.Default.exitchecker = 1;
                Properties.Settings.Default.savepath = ofd.FileName;
                Properties.Settings.Default.Save();
                pictureBox2.Show();
            }
        }

        private void siticoneRoundedButton18_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void siticoneRoundedButton19_Click_1(object sender, EventArgs e)
        {
            if (timerbar.Enabled == true)
            {
                MessageBox.Show("Please Wait Until CoolDown Is Finished!", "Lucifer Stress");
                return;
            }
            else
            {
                this.Refresh();
                MessageBox.Show("Successfully Refreshed Page", "Lucifer Stress");
            }
        }

        private void siticoneRoundedButton4_Click_3(object sender, EventArgs e)
        {
            switch (SafeGuard.ResponseInformation.loginresponse.Level)
            {
                case 1:
                    if (timerbar.Enabled == true)
                    {
                        MessageBox.Show("Please Wait Till Your Cooldown Is Finished");
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Lucifer  Status : Closing", "Lucifer Stress");
                        Environment.Exit(0);
                    }
                    break;
                case 2:
                    if (timerbar.Enabled == true)
                    {
                        MessageBox.Show("Please Wait Till Your Cooldown Is Finished");
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Lucifer  Status : Closing", "Lucifer Stress");
                        Environment.Exit(0);
                    }
                    break;
                case 3:
                    if (timerbar.Enabled == true)
                    {
                        MessageBox.Show("Please Wait Till Your Cooldown Is Finished");
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Lucifer  Status : Closing", "Lucifer Stress");
                        Environment.Exit(0);
                    }
                    break;
                case 4:
                    if (timerbar.Enabled == true)
                    {
                        MessageBox.Show("Please Wait Till Your Cooldown Is Finished");
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Lucifer Status : Closing", "Lucifer Stress");
                        Environment.Exit(0);
                    }
                    break;
                case 10:
                    MessageBox.Show("Lucifer  Status : Closing", "Lucifer Stress");
                    Environment.Exit(0);
                    break;
            }
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click_2(object sender, EventArgs e)
        {
             
        }

        private void button14_Click_2(object sender, EventArgs e)
        {
            string response = ClientFunctions.AttackRequest(ResponseInformation.loginresponse.UserName, ResponseInformation.Password, ProgramInformation.ProgramId, IP.Text, Port.Text, "STOP", to.Text, true);
        }

        private void siticoneRoundedButton9_Click_2(object sender, EventArgs e)
        {
            pictureBox2.Hide();
        }

        private void button11_Click_3(object sender, EventArgs e)
        {
            pictureBox2.Show();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Process[] processlist = Process.GetProcesses();
            foreach (Process process in processlist)
            {
                ListViewItem list = new ListViewItem(process.ProcessName);
                list.Tag = process;
                Properties.Settings.Default.text = process.ProcessName; 
                if (Properties.Settings.Default.text.Contains("AnyDesk"))
                { 
                    this.Close();
                    process.Kill(); 
                } 
            }
        }

        private void IP_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
