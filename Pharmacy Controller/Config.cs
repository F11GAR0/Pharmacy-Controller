using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_Controller
{
    class Config
    {
        private string config_path;

        //cfg params
        public string last_bd_path = "&0";


        private void WriteParam(string param_name, string value)
        {
            StreamWriter writer = File.AppendText(config_path);
            writer.WriteLine(param_name + " = " + value);
            writer.Close();
        }
        public void UpdateParam(string param_name, string value)
        {
            StreamReader reader = new StreamReader(config_path);
            List<string> file = new List<string>();
            while (!reader.EndOfStream)
            {
                file.Add(reader.ReadLine());
            }
            reader.Close();
            string new_cfg = "";
            for (int i = 0; i < file.Count; i++)
            {
                file[i] = file[i].TrimStart(new char[] { ' ', '\t', });
                if (file[i].Length == 0)
                {
                    //empty string
                    continue;
                }
                if (file[i].StartsWith("#"))
                {
                    new_cfg += file[i] + "\n\r";
                    //commentary
                    continue;
                }
                if (!file[i].Contains('='))
                {
                    new_cfg += file[i] + "\n\r";
                    Globals.Log("Error! Missing '=' operator at " + i + " line");
                    continue;
                }
                string[] argvs = file[i].Split(new char[] { '=' }, StringSplitOptions.RemoveEmptyEntries);
                if(argvs.Length < 2)
                {
                    Globals.Log("Error, argvs < 2 at " + i + " line");
                    continue;
                }
                argvs[0] = argvs[0].TrimEnd(new char[] { ' ' });
                argvs[1] = argvs[1].TrimStart(new char[] { ' ' });
                if (argvs[0] == param_name)
                {
                    new_cfg += argvs[0] + " = " + value + "\n\r";
                }
                else
                {
                    new_cfg += file[i] + "\n\r";
                }
            }
            File.Delete(config_path);
            StreamWriter writer = File.AppendText(config_path);
            writer.Write(new_cfg);
            writer.Close();
        }
        private void CreateNewCFG()
        {
            WriteParam("last_bd_path", "&0");
        }

        private string GetParam(string param_name)
        {
            StreamReader reader = new StreamReader(config_path);
            List<string> file = new List<string>();
            while (!reader.EndOfStream)
            {
                file.Add(reader.ReadLine());
            }
            reader.Close();
            for(int i = 0; i < file.Count; i++)
            {
                file[i] = file[i].TrimStart(new char[] { ' ', '\t', });
                if(file[i].Length == 0)
                {
                    //empty string
                    continue;
                }
                if (file[i].StartsWith("#"))
                {
                    //commentary
                    continue;
                }
                if (!file[i].Contains('='))
                {
                    Globals.Log("Error! Missing '=' operator at " + i + " line");
                    continue;
                }
                string[] argvs = file[i].Split(new char[] { '=' }, StringSplitOptions.RemoveEmptyEntries);
                if (argvs.Length < 2)
                {
                    Globals.Log("Error, argvs < 2 at " + i + " line");
                    continue;
                }
                argvs[0] = argvs[0].TrimEnd(new char[] { ' ' });
                argvs[1] = argvs[1].TrimStart(new char[] { ' ' });
                if (argvs[0] == param_name)
                {
                    return argvs[1];
                }
            }
            return "";
        }

        public Config()
        {
            config_path = Environment.CurrentDirectory + "\\config.cfg";
            if(!File.Exists(config_path))
            {
                CreateNewCFG();
                return;
            }
            last_bd_path = GetParam("last_bd_path");
        }
    }
}
