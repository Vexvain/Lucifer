using Newtonsoft.Json;
using SafeGuard;
using SafeGuardTemplate;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SafeGuard
{
    public partial class AttackLog
    {
        public long Id { get; set; }
        public string AttkIp { get; set; }
        public int AttkPort { get; set; }
        public int AttkTime { get; set; }
        public string AttkMethod { get; set; }
        public string Client { get; set; }
        public string ClientIp { get; set; }
        public long ProgramId { get; set; }
        public System.DateTime Timestamp { get; set; }
        public bool ManuallyStopped { get; set; }
        public long TimeInMS { get; set; }
    }
    public partial class MethodStats
    {
        public string Method { get; set; }
        public int Count { get; set; }
    }
    internal static class SafeGuardAttackInfo
    {
        internal static List<AttackLog> RunningAttacks;
        internal static List<AttackLog> PastAttacks;
        internal static List<MethodStats> MethodInformation;
        
        public static List<AttackLog> GetRunningAttacks()
        {
            try
            {
                RunningAttacks = JsonConvert.DeserializeObject<List<AttackLog>>(Tools.getRequest($"https://safeguardauth.us/GetOnGoingAttacks?programid={ProgramInformation.ProgramId}&username={ResponseInformation.loginresponse.UserName}"));
            }
            catch
            {
                RunningAttacks = new List<AttackLog>();
            }
            return RunningAttacks;
        }
        public static List<AttackLog> GetAmountOfAttacks(int num)
        {
            try
            {
                PastAttacks = JsonConvert.DeserializeObject<List<AttackLog>>(Tools.getRequest($"https://safeguardauth.us/GetPassedAttacks?programid={ProgramInformation.ProgramId}&username={ResponseInformation.loginresponse.UserName}&num={num}"));
            }
            catch
            {
                PastAttacks = new List<AttackLog>();
            }
            return PastAttacks;
        }
        public static List<MethodStats> GetMethodInformation()
        {
            try
            {
                MethodInformation = JsonConvert.DeserializeObject<List<MethodStats>>(Tools.getRequest($"https://safeguardauth.us/GetMethodStats?programid={ProgramInformation.ProgramId}&username={ResponseInformation.loginresponse.UserName}"));
            }
            catch
            {
                MethodInformation = new List<MethodStats>();
            }
            return MethodInformation;
        }
    }
    internal static class DiscordLogging
    {
        public static void DiscordLog(string action, string username, string ip, string geolocatedip = "")
        {
            action = action.ToLower();
            string message;
            string actionTitle;
            string picture = "https://i.imgur.com/6leptM3.jpg";
            switch (action)
            {
                case "login":
                    message = $"{username} Has Just Logged In From {ip}!";
                    actionTitle = "Infinity Login";
                    break;
                case "geoip":
                    message = $"{username} Has Just GeoLocated this ip: {geolocatedip} from IP: {ip}!";
                    actionTitle = "Infinity GeoIP";
                    break;
                case "register":
                    message = $"{username} Has Registered!";
                    actionTitle = "Infinity Registrations";
                    break;
                case "attack":
                    message = $"{username} Has Just Sent An Attack to {ip}!";
                    actionTitle = "Infinity Attack";
                    break;
                default:
                    message = $"{username} Has Done Unknown Function";
                    actionTitle = "Infinity Unknown";
                    break;
            }

            LogToDiscord("", new DiscordHookObject()
            {
                Message = message,
                Title = actionTitle,
                Picture = picture,
                ProgramId = ProgramInformation.ProgramId
            });
        }
        static bool LogToDiscord(string apikey, DiscordHookObject DiscordObject)
        {
            if (DiscordObject == null)
                return false;
            try
            {
                Tools.postRequest($"https://safeguardauth.us/LogToDiscordv2?apikey={apikey}", DiscordObject);
            }
            catch
            {
                return false;
            }
            return true;
        }
    }
    public class DiscordHookObject
    {
        public string Message { get; set; }
        public string Title { get; set; }
        public string Picture { get; set; }
        public string ProgramId { get; set; }
    }
    internal static class Update
    {
        internal static string version = "4";
        internal static void update()
        {
            ClientFunctions.AutoUpdate(version, ProgramInformation.ProgramId);
        }
    }
    internal static class ResponseInformation
    {
        internal static string Password;
        internal static LoginResponse loginresponse;
        internal static RegisterInformationObject registerinfo;
        internal static Count count;
        internal static AccountGen accountgen;
    }
    internal static class ProgramInformation
    {
        internal static string ProgramId = "7f6cf820-406c-4aad-8f55-7a8e04ea719f";
    }
    internal static class SafeGuardTitle
    {
        public static string safeguardtitle = "LuciferStress";
    }
    internal class SafeCheck
    {
        internal static string CurrentDllMD5 = "3307FC407D88BA40ABEAC87266F4558D";
        internal static string CurrentDllSHA1 = "3B85FC7EC65D4E26720516866E72B240598CEDCE";
        internal static string CurrentDllSHA256 = "B215110D42BDEC6069D1328E429C959F68C1BEE08333C4852BD3F5299B95173F";
        internal static string CurrentDllSize = "1741312";

        internal static string CurrentNewtonSoftMD5 = "F33CBE589B769956284868104686CC2D";
        internal static string CurrentNewtonSoftSHA1 = "2FB0BE100DE03680FC4309C9FA5A29E69397A980";
        internal static string CurrentNewtonSoftSHA256 = "973FD70CE48E5AC433A101B42871680C51E2FEBA2AEEC3D400DEA4115AF3A278";
        internal static string CurrentNewtonSoftSize = "653824";
        internal static void Md5Check()
        {
            if (ComputeHash($"{AppDomain.CurrentDomain.BaseDirectory}SafeGuard.dll", "MD5") != CurrentDllMD5)
            {
                MessageBox.Show("Invalid SafeGuard.dll. Exiting Program.", SafeGuardTitle.safeguardtitle);
                Environment.Exit(2134);
            }
            if (ComputeHash($"{AppDomain.CurrentDomain.BaseDirectory}SafeGuard.dll", "SHA1") != CurrentDllSHA1)
            {
                MessageBox.Show("Invalid SafeGuard.dll. Exiting Program.", SafeGuardTitle.safeguardtitle);
                Environment.Exit(2134);
            }
            if (ComputeHash($"{AppDomain.CurrentDomain.BaseDirectory}SafeGuard.dll", "SHA256") != CurrentDllSHA256)
            {
                MessageBox.Show("Invalid SafeGuard.dll. Exiting Program.", SafeGuardTitle.safeguardtitle);
                Environment.Exit(2134);
            }
            if (ComputeHash($"{AppDomain.CurrentDomain.BaseDirectory}SafeGuard.dll", "SIZE") != CurrentDllSize)
            {
                MessageBox.Show("Invalid SafeGuard.dll. Exiting Program.", SafeGuardTitle.safeguardtitle);
                Environment.Exit(2134);
            }

            if (ComputeHash($"{AppDomain.CurrentDomain.BaseDirectory}Newtonsoft.Json.dll", "MD5") != CurrentNewtonSoftMD5)
            {
                MessageBox.Show("Invalid Newtonsoft.Json.dll. Exiting Program.", SafeGuardTitle.safeguardtitle);
                Environment.Exit(2134);
            }
            if (ComputeHash($"{AppDomain.CurrentDomain.BaseDirectory}Newtonsoft.Json.dll", "SHA1") != CurrentNewtonSoftSHA1)
            {
                MessageBox.Show("Invalid Newtonsoft.Json.dll. Exiting Program.", SafeGuardTitle.safeguardtitle);
                Environment.Exit(2134);
            }
            if (ComputeHash($"{AppDomain.CurrentDomain.BaseDirectory}Newtonsoft.Json.dll", "SHA256") != CurrentNewtonSoftSHA256)
            {
                MessageBox.Show("Invalid Newtonsoft.Json.dll. Exiting Program.", SafeGuardTitle.safeguardtitle);
                Environment.Exit(2134);
            }
            if (ComputeHash($"{AppDomain.CurrentDomain.BaseDirectory}Newtonsoft.Json.dll", "SIZE") != CurrentNewtonSoftSize)
            {
                MessageBox.Show("Invalid Newtonsoft.Json.dll. Exiting Program.", SafeGuardTitle.safeguardtitle);
                Environment.Exit(2134);
            }
        }

        internal static string ComputeHash(string s, string hashtype)
        {
            switch (hashtype)
            {
                case "MD5":
                    using (var md5 = MD5.Create())
                    {
                        try
                        {
                            using (var stream = File.OpenRead(s))
                            {
                                byte[] hash = md5.ComputeHash(stream);
                                StringBuilder sb = new StringBuilder();
                                for (int i = 0; i < hash.Length; i++)
                                {
                                    sb.Append(hash[i].ToString("X2"));
                                }

                                return sb.ToString();
                            }
                        }
                        catch
                        {
                            return "MD5 Error";
                        }
                    }
                case "SHA1":
                    using (var sha1 = SHA1.Create())
                    {
                        try
                        {
                            using (var stream = File.OpenRead(s))
                            {
                                byte[] hash = sha1.ComputeHash(stream);
                                StringBuilder sb = new StringBuilder();
                                for (int i = 0; i < hash.Length; i++)
                                {
                                    sb.Append(hash[i].ToString("X2"));
                                }

                                return sb.ToString();
                            }
                        }
                        catch
                        {
                            return "SHA1 Error";
                        }

                    }
                case "SHA256":
                    using (var sha256 = SHA256.Create())
                    {
                        try
                        {
                            using (var stream = File.OpenRead(s))
                            {
                                byte[] hash = sha256.ComputeHash(stream);
                                StringBuilder sb = new StringBuilder();
                                for (int i = 0; i < hash.Length; i++)
                                {
                                    sb.Append(hash[i].ToString("X2"));
                                }

                                return sb.ToString();
                            }
                        }
                        catch
                        {
                            return "SHA256 Error";
                        }
                    }
                case "SIZE":
                    try
                    {
                        using (var stream = File.OpenRead(s))
                        {
                            long length = new System.IO.FileInfo(s).Length;
                            return length.ToString();
                        }
                    }
                    catch
                    {
                        return "File Size Error";
                    }
                default:
                    return "Invalid Type";
            }
        }
    }
}
