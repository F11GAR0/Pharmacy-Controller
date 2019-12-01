using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirebirdSql.Data.FirebirdClient;
using System.IO;

namespace Pharmacy_Controller
{
    class Globals
    {
        public static void ClearLogfile()
        {
            string dir = Environment.CurrentDirectory;
            string path = dir + "\\syslog.log";
            File.WriteAllText(path, "");
        }
        public static void Log(string mess)
        {
            string dir = Environment.CurrentDirectory;
            string path = dir + "\\syslog.log";
            StreamWriter writer = File.AppendText(path);
            writer.WriteLine("[" + DateTime.Now.ToShortDateString() + "||" + DateTime.Now.ToLongTimeString() + "]: " + mess);
            writer.Close();
        }
        public static Config cfg;
        public static StartPageForm start_page_form;
        public static string bdpath = "";
        public static long seller_id;
        public static string seller_fio;
        public static bool bd_opened = false;
        public static bool bd_connected = false;
        public static bool form_check_inited = false;
        public static PFBController controller;
        public static FbConnection connection;
    }
}
