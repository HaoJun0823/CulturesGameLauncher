using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace CulturesGameLauncherLibrary
{
    internal class CFGFile
    {

        public Dictionary<string, string> Data { get; private set; }


        public CFGFile(string path)
        {
            Log.Info($"Preparing Read File {path}");

            Data = new Dictionary<string, string>();

            if (File.Exists(path))
            {
                string[] array = File.ReadAllLines(path);
                Log.Info($"Readed! Count Data:{array.Length}");
                foreach (string str in array)
                {


                    ReadLine(str);


                }
            }
            else
            {
                Directory.CreateDirectory(Path.GetDirectoryName(path));
                File.Create(path).Close();
                Log.Info($"File Not Exists:{path}, Create New CFG.");
            }




        }

        public CFGFile()
        {
            Data = new Dictionary<string, string>();
        }

        public void SaveFile(string path)
        {

            List<string> list = new List<string>();
            string header = $"-Generated from CulturesGameLauncher {DateTime.UtcNow} Original Path:{path}";
            list.Add(header);
            Log.Info($"Preparing Write {header}");
            foreach (var kv in Data)
            {
                string str = $"{kv.Key}={kv.Value}";
                list.Add(str);
                Log.Info($"Preparing Write {str}");
            }
            {

            }

            if (File.Exists(path))
            {
                File.Delete(path);
            }

            Directory.CreateDirectory(Path.GetDirectoryName(path));

            File.WriteAllLines(path, list.ToArray());
        }


        private void ReadLine(string str)
        {

            if (String.IsNullOrEmpty(str))
            {
                Log.Info($"Pass Null Line.");
                return;
            }

            if (str[0] == '-')
            {
                Log.Info($"Pass Comment Line.");
                return;
            }



            StringBuilder keyBuilder = new StringBuilder();
            StringBuilder valueBuilder = new StringBuilder();

            bool isValue = false;

            foreach (char i in str)
            {

                if (i == '=')
                {
                    isValue = true;
                }
                else
                {
                    if (isValue)
                    {
                        valueBuilder.Append(i);
                    }
                    else
                    {
                        keyBuilder.Append(i);
                    }
                }




            }
            Log.Info($"Load CFG Data Key:{keyBuilder.ToString()},Value{valueBuilder.ToString()}");
            Data.Add(keyBuilder.ToString(), valueBuilder.ToString());


        }


    }
}
