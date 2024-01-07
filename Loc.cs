using System;
using System.Collections.Generic;
using System.Text;


namespace CulturesGameLauncherLibrary
{
    internal static class Loc
    {


        public static Dictionary<string, string> Data = new Dictionary<string, string>();

        private static Dictionary<string, Dictionary<string, string>> DataMap = new Dictionary<string, Dictionary<string, string>>();

        


        public static void ReadCFGData(CFGFile cfg)
        {

            string[] types = cfg.Data["Launcher_Language_Type"].Split(',');

            foreach (string type in types)
            {
                DataMap.Add(type, cfg.Data);
            }

        }

    }
}
