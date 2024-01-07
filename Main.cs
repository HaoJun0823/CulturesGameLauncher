using CulturesGameLauncherLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CulturesGameLauncher
{
    public partial class CulturesGameLauncher : Form
    {


        private CFGFile LauncherCFG;
        private CFGFile UserCFG;

        private bool IsDebug = false;

        public CulturesGameLauncher()
        {

            LauncherCFG = new CFGFile($"{GetLauncherDataDictionary()}\\global.cfg");

            

            IsDebug = Convert.ToBoolean(LauncherCFG.Data["DEBUG"]);

            InitializeComponent();




        }

        private void CulturesGameLauncher_Load(object sender, EventArgs e)
        {
            SetLanguage();
            if (IsDebug)
            {
                DumpObjectTextMap();
            }
        }

        private void SetLanguage()
        {

        }

        private void DumpObjectTextMap()
        {
            CFGFile cfg = new CFGFile();

            foreach (Control control in this.Controls)
            {
                cfg.Data.Add(control.Name, control.Text);

                if (control.Controls.Count > 0)
                {
                    foreach (Control control2 in control.Controls)
                    {
                        cfg.Data.Add($"{control.Name}.{control2.Name}", control2.Text);
                    }
                }

            }

            cfg.SaveFile($"{GetLauncherDataDictionary()}\\ObjectDump.log");

        }

        private string GetWorkDictionary()
        {
            return System.Environment.CurrentDirectory;
        }

        private string GetLauncherDataDictionary()
        {
            return $"{GetWorkDictionary()}\\Launcher_Data";
        }

    }
}
