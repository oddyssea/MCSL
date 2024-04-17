using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Salaros.Configuration;
using System.Xml.Schema;

namespace MinecraftServerLauncher
{
    public partial class FirstTimeLaunchForm : Form
    {
        //****************************************************************************************************
        //DECLARE VARIABLES
        //****************************************************************************************************

        private string appConfig = Application.StartupPath + @"\appConfig.ini";
        private bool CloseToken = false; //ensures anything but OK closes form 1
        //private string LaunchExecutablePath;

        //****************************************************************************************************
        //FORM LOAD :: FORM CLOSE
        //****************************************************************************************************

        public FirstTimeLaunchForm()
        {
            InitializeComponent();
        }

        private void FirstTimeLaunchForm_Load(object sender, EventArgs e)
        {

        }

        private void FirstTimeLaunchForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //check if user pressed OK or 'X'
            if (CloseToken == false)
            {
                Application.Exit();

            }
            else if (CloseToken == true)
            {
                MCServerLauncherMainForm mainForm = new MCServerLauncherMainForm();
                mainForm.Show();

            }

        }

        //****************************************************************************************************
        //BUTTONS :: CLICKS
        //****************************************************************************************************

        private void FirstTimeOKButton_Click(object sender, EventArgs e)
        {
            string MainPath = MCSFilesDirectoryBox.Text;
            string WorldsPath = MCSWorldsDirectoryBox.Text;
            string CurrentWorld = CurrentWorldBox.Text;
            string ServerPropertiesFile = MainPath + "\\server.properties";

            var PassInfo = new ConfigParser(appConfig);

            //check for blank fields
            if (MCSFilesDirectoryBox.Text == "" || MCSWorldsDirectoryBox.Text == "" || CurrentWorldBox.Text == "")
            {
                MessageBox.Show("You must complete all the fields to continue!", "Warning!");
                return;
            }

            //check if server path exists
            try
            {
                Directory.GetFiles(MCSFilesDirectoryBox.Text);
            }
            catch
            {
                MessageBox.Show("Plese enter a valid server path.", "Warning!");
                return;
            }

            //chech if properties file exists, do nothing
            try
            {
                File.Exists(ServerPropertiesFile);
            }
            catch
            {
                MessageBox.Show("Server properties file not found. Check Minecraft sever main folder.", "Config Error!");
            }

            //write to config file
            PassInfo.SetValue("PATHS", "MINECRAFT SERVER FILES", MainPath);
            PassInfo.SetValue("PATHS", "SERVER WORLD FILES", WorldsPath);
            //PassInfo.SetValue("PATHS", "EXECUTABLE", LaunchExecutablePath);
            PassInfo.SetValue("PATHS", "PROPERTIES FILE", ServerPropertiesFile);
            PassInfo.SetValue("WORLD", "CURRENT WORLD NAME", CurrentWorld);
            PassInfo.SetValue("CONFIG", "FTL", "FALSE");

           PassInfo.Save(); //save config file
            CloseToken = true; //ensures mainform loads
            this.Close();
        }

        private void FirstTimeCloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

    }
}
