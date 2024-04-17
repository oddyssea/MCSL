using Salaros.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using System.Diagnostics;
using System.Collections;
using System.Runtime.CompilerServices;

namespace MinecraftServerLauncher
{
    public partial class MCServerLauncherMainForm : Form
    {
        //****************************************************************************************************
        //DECLARE VARIABLES
        //****************************************************************************************************

        private string appConfig = Application.StartupPath + @"\appConfig.ini";
        private string MainPath;
        private string WorldsPath;
        private string LaunchExecutablePath;
        private string ServerPropertiesFile;
        private string CurrentWorldName;
        private string CurrentWorldPath;
        private string CurrentWorldSelection;
        private string CurrentWorldSelectionPath;
        private bool CanLaunch = true;

        //For properties file
        private string Gamemode;
        private string Difficulty;
        private string HardcoreEnabled;
        private string PVPEnabled;
        private string SpawnAnimals;
        private string SpawnMonsters;
        private string SpawnNPC;
        private string GenerateStructures;
        private string Hostname;
        private string MapSeed;
        private string EnableWhitelist;
        private string EnforeWhitelist;
        private string EnableCMDBlock;

        //****************************************************************************************************
        //FORM LOAD :: FORM CLOSE
        //****************************************************************************************************

        public MCServerLauncherMainForm()
        {
            InitializeComponent();
        }

        private void MCServerLauncherMainForm_Load(object sender, EventArgs e)
        {
            ReloadConfig();
            ReadWorldFiles();
            PopulateFields();
        }

        private void MCServerLauncherMainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();

        }

        //****************************************************************************************************
        //FUNCTIONS :: FUNCTIONS
        //****************************************************************************************************

        void OpenFolder(string folderPath)
        {
            if (Directory.Exists(folderPath))
            {
                Process.Start("explorer.exe", folderPath);
            }
            else if (File.Exists(folderPath))
            {
                Process.Start("notepad.exe", folderPath);
            }
            else
            {
                // Handle the case when the folder does not exist
                MessageBox.Show("Folder does not exist: " + folderPath);
            }
        }

        void OpenFile(string filePath)
        {
            if (File.Exists(filePath))
            {
                Process.Start(filePath);
            }
            else
            {
                MessageBox.Show("File cannot be found. Check paths in config.", "File not found");
            }
        }

        void ReloadConfig()
        {
            //grab config settings
            var ConfigFile = new ConfigParser(appConfig);
            var MainPathVar = ConfigFile.GetValue("PATHS", "MINECRAFT SERVER FILES");
            var WorldsPathVar = ConfigFile.GetValue("PATHS", "SERVER WORLD FILES");
            var LaunchExecutablePathVar = ConfigFile.GetValue("PATHS", "EXECUTABLE");
            var CurrentWorldVar = ConfigFile.GetValue("WORLD", "CURRENT WORLD NAME");

            //pass config settings to global string
            MainPath = MainPathVar;
            WorldsPath = WorldsPathVar;
            LaunchExecutablePath = LaunchExecutablePathVar;

            CheckValidPropertiesFile();

            ServerPropertiesFile = MainPathVar + "\\server.properties";
            ConfigFile.SetValue("PATHS", "PROPERTIES FILE", ServerPropertiesFile);
            ConfigFile.Save();

            CurrentWorldName = CurrentWorldVar;
            CurrentWorldSelection = ServerWorldListBox.Text;
            CurrentWorldPath = MainPath + "\\world";

            //grab properties file
            var PropertiesFile = new ConfigParser(MainPath + "\\server.properties");
            var GamemodeVar = PropertiesFile.GetValue("PROPERTIES", "gamemode");
            var DifficultyVar = PropertiesFile.GetValue("PROPERTIES", "difficulty");
            var HardcoreEnabledVar = PropertiesFile.GetValue("PROPERTIES", "hardcore");
            var PVPEnabledVar = PropertiesFile.GetValue("PROPERTIES", "pvp");
            var SpawnAnimalsVar = PropertiesFile.GetValue("PROPERTIES", "spawn-animals");
            var SpawnMonstersVar = PropertiesFile.GetValue("PROPERTIES", "spawn-monsters");
            var SpawnNPCVar = PropertiesFile.GetValue("PROPERTIES", "spawn-npcs");
            var GenerateStructuresVar = PropertiesFile.GetValue("PROPERTIES", "generate-structures");
            var HostnameVar = PropertiesFile.GetValue("PROPERTIES", "server-ip");
            var MapSeedVar = PropertiesFile.GetValue("PROPERTIES", "level-seed");
            var EnableWhitelistVar = PropertiesFile.GetValue("PROPERTIES", "white-list");
            var EnforeWhitelistVar = PropertiesFile.GetValue("PROPERTIES", "enforce-whitelist");
            var EnableCMDBlockVar = PropertiesFile.GetValue("PROPERTIES", "enable-command-block");

            //pass properties to global string
            Gamemode = GamemodeVar;
            Difficulty = DifficultyVar;
            HardcoreEnabled = HardcoreEnabledVar;
            PVPEnabled = PVPEnabledVar;
            SpawnAnimals = SpawnAnimalsVar;
            SpawnMonsters = SpawnMonstersVar;
            SpawnNPC = SpawnNPCVar;
            GenerateStructures = GenerateStructuresVar;
            Hostname = HostnameVar;
            MapSeed = MapSeedVar;
            EnableWhitelist = EnableWhitelistVar;
            EnforeWhitelist = EnforeWhitelistVar;
            EnableCMDBlock = EnableCMDBlockVar;

        }

        void ReadWorldFiles()
        {
            ServerWorldListBox.Items.Clear(); // clear listbox
            ServerWorldListBox.Items.Add(CurrentWorldName); //add current world to the list of maps

            //search for world folders in worlds path
            try
            {
                string[] worldsOutput = Directory.GetDirectories(WorldsPath);

                foreach (string path in worldsOutput)
                {
                    string name = Path.GetFileName(path);
                    ServerWorldListBox.Items.Add(name);
                }
            }
            catch
            {
                MessageBox.Show("Error reading Minecraft worlds folder.", "Config Error");
                return;
            }
        }

        void PopulateFields()
        {
            //textboxs
            GamemodeListBox.Text = Gamemode;
            DifficultyListBox.Text = Difficulty;
            HostnameBox.Text = Hostname;
            MapSeedBox.Text = MapSeed;
            ServerWorldListBox.Text = CurrentWorldName;

            //checkboxs
            HardcoreCheckbox.Checked = stringToBool(HardcoreEnabled);
            PVPCheckBox.Checked = stringToBool(PVPEnabled);
            AnimalsCheckbox.Checked = stringToBool(SpawnAnimals);
            MonstersCheckbox.Checked = stringToBool(SpawnMonsters);
            NPCsCheckbox.Checked = stringToBool(SpawnNPC);
            GenerateStructureCheckbox.Checked = stringToBool(GenerateStructures);
            WhitelistEnabledCheckBox.Checked = stringToBool(EnableWhitelist);
            EnforeWhitelistCheckBox.Checked = stringToBool(EnforeWhitelist);
            EnableCMDBlockCheckBox.Checked = stringToBool(EnableCMDBlock);
            if (LaunchExecutablePath.Contains(".bat"))
            {
                LaunchTypeBAT2.Checked = true;
                PathFoundLabel2.Text = "BAT executable found!";
            }
            else if (LaunchExecutablePath.Contains(".jar"))
            {
                LaunchTypeJAR2.Checked = true;
                PathFoundLabel2.Text = "JAR executable found!";
            }
            else
            {
                LaunchTypeJAR2.Checked = false;
                LaunchTypeBAT2.Checked = false;
            }
        }

        void CheckValidPropertiesFile()
        {
            string filePath = MainPath + "\\server.properties";
            string searchString = "[PROPERTIES]=";
            List<string> lines = File.ReadAllLines(filePath).ToList();

            if (!lines[2].Contains(searchString))
            {
                lines[1] += Environment.NewLine + searchString;
                File.WriteAllLines(filePath, lines);
            }
        }

        void WriteToProperties()
        {
            string checkFile = MainPath + "\\server.properties";

            if (File.Exists(checkFile))
            {
                var PassInfo = new ConfigParser(MainPath + "\\server.properties");
                PassInfo.SetValue("PROPERTIES", "gamemode", GamemodeListBox.Text.ToLower());
                PassInfo.SetValue("PROPERTIES", "difficulty", DifficultyListBox.Text.ToLower());
                PassInfo.SetValue("PROPERTIES", "hardcore", HardcoreCheckbox.Checked.ToString());
                PassInfo.SetValue("PROPERTIES", "pvp", PVPCheckBox.Checked.ToString().ToLower());
                PassInfo.SetValue("PROPERTIES", "spawn-animals", AnimalsCheckbox.Checked.ToString().ToLower());
                PassInfo.SetValue("PROPERTIES", "spawn-monsters", MonstersCheckbox.Checked.ToString().ToLower());
                PassInfo.SetValue("PROPERTIES", "spawn-npcs", NPCsCheckbox.Checked.ToString().ToLower());
                PassInfo.SetValue("PROPERTIES", "generate-structures", GenerateStructureCheckbox.Checked.ToString().ToLower());
                PassInfo.SetValue("PROPERTIES", "server-ip", HostnameBox.Text.ToString().ToLower());
                PassInfo.SetValue("PROPERTIES", "level-seed", MapSeedBox.Text);
                PassInfo.SetValue("PROPERTIES", "white-list", WhitelistEnabledCheckBox.Checked.ToString().ToLower());
                PassInfo.SetValue("PROPERTIES", "enforce-whitelist", EnforeWhitelistCheckBox.Checked.ToString().ToLower());
                PassInfo.SetValue("PROPERTIES", "enable-command-block", EnableCMDBlockCheckBox.Checked.ToString().ToLower());
                PassInfo.Save();
            }
            else
            {
                CanLaunch = false;
            }
        }

        public bool stringToBool(string checkValue)
        {
            bool result;
            if (bool.TryParse(checkValue, out result) && result)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static string ShowInputDialog(string prompt)
        {
            Form promptForm = new Form()
            {
                Width = 500,
                Height = 150,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = prompt,
                StartPosition = FormStartPosition.CenterScreen
            };

            TextBox textBox = new TextBox() { Left = 50, Top = 20, Width = 400 };
            Button confirmation = new Button() { Text = "OK", Left = 350, Width = 100, Top = 50 };

            confirmation.Click += (sender, e) => { promptForm.Close(); };

            promptForm.Controls.Add(textBox);
            promptForm.Controls.Add(confirmation);
            promptForm.ShowDialog();

            return textBox.Text;
        }

        public static void CopyDirectory(string sourcePath, string destinationPath)
        {
            try
            {
                // Create the destination directory if it doesn't exist
                if (!Directory.Exists(destinationPath))
                {
                    Directory.CreateDirectory(destinationPath);
                }

                // Copy files
                foreach (string file in Directory.GetFiles(sourcePath))
                {
                    string destFile = Path.Combine(destinationPath, Path.GetFileName(file));
                    File.Copy(file, destFile, true);
                }

                // Copy subdirectories
                foreach (string subDirectory in Directory.GetDirectories(sourcePath))
                {
                    string destDir = Path.Combine(destinationPath, Path.GetFileName(subDirectory));
                    CopyDirectory(subDirectory, destDir);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error copying directory: {ex.Message}", "Copy Error");
            }
        }

        void StartMinecraftServer()
        {
            //define process startup information
            ProcessStartInfo start = new ProcessStartInfo();
            start.WorkingDirectory = MainPath;
            start.FileName = LaunchExecutablePath;
            int exitCode; //initialize

            if (CanLaunch == true)
            {
                if (File.Exists(LaunchExecutablePath) && Directory.Exists(MainPath))
                {
                    using (Process proc = new Process())
                    {
                        proc.StartInfo = start;
                        proc.Start(); //start server executable
                        proc.WaitForExit(); //suspend until process exits
                        exitCode = proc.ExitCode; // Retrieve the app's exit code
                    }
                }
                else
                {
                    MessageBox.Show("Executable not found! Check server files directory for executable!", "Warning!");
                }
            }
            else
            {
                MessageBox.Show("Cannot launch Minecraft Server. Check configuration paths.", "Critical Error");
            }
        }

        void MoveWorldFolders()
        {
            //check world folder for currentselection and assign path
            string[] worldsOutput = Directory.GetDirectories(WorldsPath);
            foreach (string path in worldsOutput)
            {
                string name = Path.GetFileName(path);
                if (name == CurrentWorldSelection)
                {
                    CurrentWorldSelectionPath = path;
                    break;
                }
                else
                {

                }
            }
            //move folders around so the launch map is correct
            Directory.Move(CurrentWorldPath, WorldsPath + "\\" + CurrentWorldName);
            Directory.Move(CurrentWorldSelectionPath, MainPath + "\\" + "world");

            //update global variables
            var PassInfo = new ConfigParser(appConfig);
            PassInfo.SetValue("WORLD", "CURRENT WORLD NAME", CurrentWorldSelection); //update INI file
            CurrentWorldName = CurrentWorldSelection; //update global variable
            PassInfo.Save();
        }

        //****************************************************************************************************
        //BUTTONS :: CLICKS
        //****************************************************************************************************

        private void ServerStartButton_Click(object sender, EventArgs e)
        {
            CurrentWorldSelection = ServerWorldListBox.Text;

            if (CurrentWorldSelection == CurrentWorldName)
            {
                WriteToProperties();
                StartMinecraftServer();
            }
            else if (CurrentWorldSelection == "")
            {
                //check for selection
                MessageBox.Show("You must select a world to load!", "Warning!");
            }
            else
            {
                MoveWorldFolders();
                WriteToProperties();
                StartMinecraftServer(); //start with new world map
            }
        }

        private void NewWorldButton_Click(object sender, EventArgs e)
        {
            string NewWorldName;
            NewWorldName = ShowInputDialog("Enter a new world name:");
            Directory.CreateDirectory(WorldsPath + "\\" + NewWorldName);
        }

        private void ServerWorldListBox_Click(object sender, EventArgs e)
        {
            ReadWorldFiles();
            CurrentWorldSelection = ServerWorldListBox.Text;
        }

        private void CopyWorldButton_Click(object sender, EventArgs e)
        {
            string NewWorldName;
            string sourceDirectory;
            CurrentWorldSelection = ServerWorldListBox.Text;

            //copy directories
            if (CurrentWorldSelection == CurrentWorldName) //check if copying current loaded map
            {
                NewWorldName = ShowInputDialog("Enter a new world name:");
                CopyDirectory(CurrentWorldPath, WorldsPath + "\\" + NewWorldName);
            }
            else
            {
                NewWorldName = ShowInputDialog("Enter a new world name:");

                string[] worldsOutput = Directory.GetDirectories(WorldsPath);
                foreach (string path in worldsOutput)
                {
                    string filename = Path.GetFileName(path);
                    if (filename == CurrentWorldSelection)
                    {
                        sourceDirectory = path;
                        CopyDirectory(sourceDirectory, WorldsPath + "\\" + NewWorldName);
                        MessageBox.Show(NewWorldName + "  successfully created!" + "Attention!");
                        break;
                    }
                }
            }
            ReloadConfig();//reload config
            ReadWorldFiles();//reread world files
        }

        private void DeleteWorldButton_Click(object sender, EventArgs e)
        {
            string DeleteWorldName = ServerWorldListBox.Text;
            string DeleteWorldPath;

            if (DeleteWorldName == CurrentWorldName)
            {
                //delete current map 'world'
                DeleteWorldPath = MainPath + "\\" + "world";
                Directory.Delete(DeleteWorldPath, true);
                ServerWorldListBox.Items.Clear();
                MessageBox.Show(DeleteWorldName + " deleted.", "Warning!");

                string[] worldsOutput = Directory.GetDirectories(WorldsPath);
                string passToCurrent = Path.GetFileName(worldsOutput[0]); //select first in world list for next 'current selection'
                CurrentWorldName = passToCurrent; //save to global variable

                var PassInfo = new ConfigParser(appConfig);
                PassInfo.SetValue("WORLD", "CURRENT WORLD NAME", CurrentWorldName);//update INI file
                PassInfo.Save();

                //move new current map to mainpath
                Directory.Move(worldsOutput[0], MainPath + "\\" + "world");
                ReloadConfig();
                ReadWorldFiles();
            }
            else
            {
                //search for path to delete then delete
                string[] worldsOutput = Directory.GetDirectories(WorldsPath);
                foreach (string path in worldsOutput)
                {
                    string filename = Path.GetFileName(path);
                    if (filename == DeleteWorldName)
                    {
                        DeleteWorldPath = path;
                        Directory.Delete(DeleteWorldPath, true);
                        MessageBox.Show(DeleteWorldName + " has been deleted.", "Attention!");
                        ReloadConfig();//reload config
                        ReadWorldFiles();//reread world files
                        break;
                    }
                }
            }
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string checkFile = Application.StartupPath + "\\HELP.ME";

            if (File.Exists(checkFile))
            {
                Process.Start(checkFile);
            }
            else
            {
                MessageBox.Show("Help file cannot be found.", "Path Not Found");
            }
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReloadConfig();
            ReadWorldFiles();
            PopulateFields();
        }

        private void FilesDropdownConfig_Click(object sender, EventArgs e)
        {
            string filePath = Application.StartupPath + @"\appConfig.ini";
            OpenFile(filePath);

        }

        private void FilesDropdownProperties_Click(object sender, EventArgs e)
        {
            string filePath = MainPath + "\\server.properties";
            OpenFile(filePath);

        }

        private void FoldersDropdownData_Click(object sender, EventArgs e)
        {
            OpenFolder(MainPath);
        }

        private void FoldersDropdownWorlds_Click(object sender, EventArgs e)
        {
            OpenFolder(WorldsPath);
        }

        private void programToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFolder(Application.StartupPath);
        }

        private void mOTDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var PropertiesFile = new ConfigParser(MainPath + "\\server.properties"); //initialize
            var motdVar = PropertiesFile.GetValue("PROPERTIES", "motd"); //grab MOTD from properties file

            //display current MOTD, ask if user wants to change it
            DialogResult dialogResult = MessageBox.Show("'" + motdVar + "'" + Environment.NewLine + Environment.NewLine + "Would you like to change it?", "Message of the Day", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                string motdNewText = ShowInputDialog("Enter the message of the day:"); //ask for user input
                PropertiesFile.SetValue("PROPERTIES", "motd", motdNewText); //write to properties file
                PropertiesFile.Save();
            }
            else
            {
                return;
            }
        }

        private void whitelistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFolder(MainPath + "\\whitelist.json");
        }

        private void playersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //loads banned players file
            OpenFolder(MainPath + "\\banned-players.json");
        }

        private void iPsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //loads banned ips file
            OpenFolder(MainPath + "\\banned-ips.json");
        }

        private void oPsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //loads op'd players file
            OpenFolder(MainPath + "\\ops.json");
        }

        private void deletePlayersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string filePath = MainPath + "\\banned-players.json";
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }
        }

        private void deleteIPSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string filePath = MainPath + "\\banned-ips.json";
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }
        }

        private void deleteOPSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string filePath = MainPath + "\\ops.json";
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }
        }

        private void deleteWhitelistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string filePath = MainPath + "\\whitelist.json";
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }
        }

        private void LaunchTypeBAT2_CheckedChanged(object sender, EventArgs e)
        {
            string CheckPath = MainPath;
            bool IsPathValid = true;

            //check if main directory box path is valid
            try
            {
                Directory.GetFiles(CheckPath);
            }
            catch
            {
                MessageBox.Show("Plese enter a valid server path in the config.", "Warning!");
                IsPathValid = false;
            }

            //search main directory for .bat and return path
            if (IsPathValid == true)
            {
                string[] filesOutput = Directory.GetFiles(CheckPath);
                foreach (string files in filesOutput)
                {
                    if (files.Contains(".bat"))
                    {
                        LaunchExecutablePath = files;
                        var ConfigFile = new ConfigParser(appConfig);
                        ConfigFile.SetValue("PATHS", "EXECUTABLE", LaunchExecutablePath);
                        ConfigFile.Save();
                        PathFoundLabel2.Text = "BAT executable found!";
                        return;
                    }
                    PathFoundLabel2.Text = "Executable not found!";
                }
            }
            else
            {
                PathFoundLabel2.Text = "Executable not found!";
            }
        }

        private void LaunchTypeJAR2_CheckedChanged(object sender, EventArgs e)
        {
            string CheckPath = MainPath;
            bool IsPathValid = true;

            //check if main directory box path is valid
            try
            {
                Directory.GetFiles(CheckPath);
            }
            catch
            {
                MessageBox.Show("Plese enter a valid server path in the config.", "Warning!");
                IsPathValid = false;
            }

            //search main directory for .jar and return path
            if (IsPathValid == true)
            {
                string[] filesOutput = Directory.GetFiles(CheckPath);
                foreach (string files in filesOutput)
                {
                    if (files.Contains(".jar"))
                    {
                        LaunchExecutablePath = files;
                        var ConfigFile = new ConfigParser(appConfig);
                        ConfigFile.SetValue("PATHS", "EXECUTABLE", LaunchExecutablePath);
                        ConfigFile.Save();
                        PathFoundLabel2.Text = "JAR executable found!";
                        return;
                    }
                    PathFoundLabel2.Text = "Executable not found!";
                }
            }
            else
            {

            }
        }

        //****************************************************************************************************
        //NOT USED :: NOT USED
        //****************************************************************************************************

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void HostnameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }


    }
}
