using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Salaros.Configuration;

namespace MinecraftServerLauncher
{
    internal static class Program
    {

        /// <summary>
        /// The main entry point for the application.
        /// </summary>


        [STAThread]
        static void Main()
        {
            string appConfig = Application.StartupPath + @"\appConfig.ini";
            var PassInfo = new ConfigParser(appConfig);
            var IsFirstTime = PassInfo.GetValue("CONFIG", "FTL");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (IsFirstTime == null)
            {
                //create new config file then launch FirstTimeLaunchFrom
                var config = new ConfigParser();
                config.SetValue("CONFIG", "FTL", "TRUE");
                config.Save(appConfig);

                FirstTimeLaunchForm FirstTimeLaunchForm = new FirstTimeLaunchForm();
                FirstTimeLaunchForm.Show();
                Application.Run();
            }
            else
            {
                var checkMainPath = PassInfo.GetValue("PATHS", "MINECRAFT SERVER FILES");
                var checkWorldsPath = PassInfo.GetValue("PATHS", "SERVER WORLD FILES");

                if (IsFirstTime.ToLower() == "true")
                {
                    FirstTimeLaunchForm FirstTimeLaunchForm = new FirstTimeLaunchForm();
                    FirstTimeLaunchForm.Show();
                    Application.Run();
                }
                else if (IsFirstTime.ToLower() == "false")
                {
                    if (Directory.Exists(checkMainPath) && Directory.Exists(checkWorldsPath))
                    {
                        MCServerLauncherMainForm MCServerLauncherMainForm = new MCServerLauncherMainForm();
                        MCServerLauncherMainForm.Show();
                        Application.Run();
                    }
                    else
                    {
                        MessageBox.Show("Critical launch error. Check appConfig.ini in application startup path.", "WHOOPS");
                    }
                }
            }
        }
    }
}
