namespace MinecraftServerLauncher
{
    partial class MCServerLauncherMainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MCServerLauncherMainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.ServerWorldListBox = new System.Windows.Forms.ComboBox();
            this.NewWorldButton = new System.Windows.Forms.Button();
            this.CopyWorldButton = new System.Windows.Forms.Button();
            this.DeleteWorldButton = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GamemodeListBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DifficultyListBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.HardcoreCheckbox = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.PVPCheckBox = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.HostnameBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.MapSeedBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.AnimalsCheckbox = new System.Windows.Forms.CheckBox();
            this.MonstersCheckbox = new System.Windows.Forms.CheckBox();
            this.NPCsCheckbox = new System.Windows.Forms.CheckBox();
            this.label14 = new System.Windows.Forms.Label();
            this.EnforeWhitelistCheckBox = new System.Windows.Forms.CheckBox();
            this.label15 = new System.Windows.Forms.Label();
            this.GenerateStructureCheckbox = new System.Windows.Forms.CheckBox();
            this.label16 = new System.Windows.Forms.Label();
            this.FilesDropdown = new System.Windows.Forms.ToolStripMenuItem();
            this.FilesDropdownConfig = new System.Windows.Forms.ToolStripMenuItem();
            this.FilesDropdownProperties = new System.Windows.Forms.ToolStripMenuItem();
            this.whitelistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteWhitelistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bannedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deletePlayersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iPsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteIPSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oPsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteOPSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FoldersDropdown = new System.Windows.Forms.ToolStripMenuItem();
            this.FoldersDropdownData = new System.Windows.Forms.ToolStripMenuItem();
            this.FoldersDropdownWorlds = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mOTDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.EnableCMDBlockCheckBox = new System.Windows.Forms.CheckBox();
            this.ServerStartButton = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.WhitelistEnabledCheckBox = new System.Windows.Forms.CheckBox();
            this.PathFoundLabel2 = new System.Windows.Forms.Label();
            this.LaunchTypeJAR2 = new System.Windows.Forms.RadioButton();
            this.LaunchTypeBAT2 = new System.Windows.Forms.RadioButton();
            this.label18 = new System.Windows.Forms.Label();
            this.programToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Minecraftia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 444);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "World Select:";
            // 
            // ServerWorldListBox
            // 
            this.ServerWorldListBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ServerWorldListBox.Font = new System.Drawing.Font("Minecraftia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServerWorldListBox.FormattingEnabled = true;
            this.ServerWorldListBox.Location = new System.Drawing.Point(133, 442);
            this.ServerWorldListBox.Name = "ServerWorldListBox";
            this.ServerWorldListBox.Size = new System.Drawing.Size(294, 23);
            this.ServerWorldListBox.TabIndex = 4;
            this.ServerWorldListBox.Click += new System.EventHandler(this.ServerWorldListBox_Click);
            // 
            // NewWorldButton
            // 
            this.NewWorldButton.BackColor = System.Drawing.Color.Silver;
            this.NewWorldButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.NewWorldButton.FlatAppearance.BorderSize = 2;
            this.NewWorldButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewWorldButton.Font = new System.Drawing.Font("Minecraftia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewWorldButton.ForeColor = System.Drawing.Color.White;
            this.NewWorldButton.Location = new System.Drawing.Point(65, 389);
            this.NewWorldButton.Name = "NewWorldButton";
            this.NewWorldButton.Size = new System.Drawing.Size(100, 30);
            this.NewWorldButton.TabIndex = 5;
            this.NewWorldButton.Text = "New";
            this.NewWorldButton.UseVisualStyleBackColor = false;
            this.NewWorldButton.Click += new System.EventHandler(this.NewWorldButton_Click);
            // 
            // CopyWorldButton
            // 
            this.CopyWorldButton.BackColor = System.Drawing.Color.Silver;
            this.CopyWorldButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.CopyWorldButton.FlatAppearance.BorderSize = 2;
            this.CopyWorldButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CopyWorldButton.Font = new System.Drawing.Font("Minecraftia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CopyWorldButton.ForeColor = System.Drawing.Color.White;
            this.CopyWorldButton.Location = new System.Drawing.Point(182, 389);
            this.CopyWorldButton.Name = "CopyWorldButton";
            this.CopyWorldButton.Size = new System.Drawing.Size(100, 30);
            this.CopyWorldButton.TabIndex = 6;
            this.CopyWorldButton.Text = "Copy";
            this.CopyWorldButton.UseVisualStyleBackColor = false;
            this.CopyWorldButton.Click += new System.EventHandler(this.CopyWorldButton_Click);
            // 
            // DeleteWorldButton
            // 
            this.DeleteWorldButton.BackColor = System.Drawing.Color.Silver;
            this.DeleteWorldButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.DeleteWorldButton.FlatAppearance.BorderSize = 2;
            this.DeleteWorldButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteWorldButton.Font = new System.Drawing.Font("Minecraftia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteWorldButton.ForeColor = System.Drawing.Color.White;
            this.DeleteWorldButton.Location = new System.Drawing.Point(299, 389);
            this.DeleteWorldButton.Name = "DeleteWorldButton";
            this.DeleteWorldButton.Size = new System.Drawing.Size(100, 30);
            this.DeleteWorldButton.TabIndex = 7;
            this.DeleteWorldButton.Text = "Delete";
            this.DeleteWorldButton.UseVisualStyleBackColor = false;
            this.DeleteWorldButton.Click += new System.EventHandler(this.DeleteWorldButton_Click);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Minecraftia", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(116, 39);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(377, 35);
            this.Title.TabIndex = 8;
            this.Title.Text = "Minecraft Server Launcher";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Minecraftia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 21);
            this.label2.TabIndex = 9;
            this.label2.Text = "Gamemode";
            // 
            // GamemodeListBox
            // 
            this.GamemodeListBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GamemodeListBox.Font = new System.Drawing.Font("Minecraftia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GamemodeListBox.FormattingEnabled = true;
            this.GamemodeListBox.Items.AddRange(new object[] {
            "Survival",
            "Creative",
            "Adventure",
            "Spectator"});
            this.GamemodeListBox.Location = new System.Drawing.Point(119, 122);
            this.GamemodeListBox.Name = "GamemodeListBox";
            this.GamemodeListBox.Size = new System.Drawing.Size(106, 23);
            this.GamemodeListBox.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Minecraftia", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(53, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 26);
            this.label3.TabIndex = 11;
            this.label3.Text = "World Settings";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Minecraftia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 21);
            this.label4.TabIndex = 12;
            this.label4.Text = "Difficulty";
            // 
            // DifficultyListBox
            // 
            this.DifficultyListBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DifficultyListBox.Font = new System.Drawing.Font("Minecraftia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DifficultyListBox.FormattingEnabled = true;
            this.DifficultyListBox.Items.AddRange(new object[] {
            "Peaceful",
            "Easy",
            "Normal",
            "Hard"});
            this.DifficultyListBox.Location = new System.Drawing.Point(119, 152);
            this.DifficultyListBox.Name = "DifficultyListBox";
            this.DifficultyListBox.Size = new System.Drawing.Size(106, 23);
            this.DifficultyListBox.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Minecraftia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(34, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 21);
            this.label5.TabIndex = 14;
            this.label5.Text = "Hardcore";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // HardcoreCheckbox
            // 
            this.HardcoreCheckbox.AutoSize = true;
            this.HardcoreCheckbox.Location = new System.Drawing.Point(160, 189);
            this.HardcoreCheckbox.Name = "HardcoreCheckbox";
            this.HardcoreCheckbox.Size = new System.Drawing.Size(15, 14);
            this.HardcoreCheckbox.TabIndex = 15;
            this.HardcoreCheckbox.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Minecraftia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(34, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 21);
            this.label6.TabIndex = 16;
            this.label6.Text = "PVP Enabled";
            // 
            // PVPCheckBox
            // 
            this.PVPCheckBox.AutoSize = true;
            this.PVPCheckBox.Location = new System.Drawing.Point(160, 210);
            this.PVPCheckBox.Name = "PVPCheckBox";
            this.PVPCheckBox.Size = new System.Drawing.Size(15, 14);
            this.PVPCheckBox.TabIndex = 17;
            this.PVPCheckBox.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Minecraftia", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(382, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(172, 26);
            this.label7.TabIndex = 18;
            this.label7.Text = "Server Settings";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Minecraftia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(339, 124);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 21);
            this.label8.TabIndex = 19;
            this.label8.Text = "Hostname";
            // 
            // HostnameBox
            // 
            this.HostnameBox.Location = new System.Drawing.Point(424, 122);
            this.HostnameBox.Name = "HostnameBox";
            this.HostnameBox.Size = new System.Drawing.Size(164, 20);
            this.HostnameBox.TabIndex = 20;
            this.HostnameBox.TextChanged += new System.EventHandler(this.HostnameBox_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Minecraftia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(339, 153);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 21);
            this.label9.TabIndex = 21;
            this.label9.Text = "Map Seed";
            // 
            // MapSeedBox
            // 
            this.MapSeedBox.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.MapSeedBox.Location = new System.Drawing.Point(424, 152);
            this.MapSeedBox.Name = "MapSeedBox";
            this.MapSeedBox.Size = new System.Drawing.Size(164, 20);
            this.MapSeedBox.TabIndex = 22;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Minecraftia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(34, 294);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 21);
            this.label12.TabIndex = 26;
            this.label12.Text = "Monsters";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Minecraftia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(34, 316);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 21);
            this.label13.TabIndex = 27;
            this.label13.Text = "NPCs";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Minecraftia", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(53, 245);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(160, 26);
            this.label10.TabIndex = 28;
            this.label10.Text = "Spawn Settings";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Minecraftia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(34, 273);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 21);
            this.label11.TabIndex = 29;
            this.label11.Text = "Animals";
            // 
            // AnimalsCheckbox
            // 
            this.AnimalsCheckbox.AutoSize = true;
            this.AnimalsCheckbox.Location = new System.Drawing.Point(122, 276);
            this.AnimalsCheckbox.Name = "AnimalsCheckbox";
            this.AnimalsCheckbox.Size = new System.Drawing.Size(15, 14);
            this.AnimalsCheckbox.TabIndex = 30;
            this.AnimalsCheckbox.UseVisualStyleBackColor = true;
            // 
            // MonstersCheckbox
            // 
            this.MonstersCheckbox.AutoSize = true;
            this.MonstersCheckbox.Location = new System.Drawing.Point(122, 296);
            this.MonstersCheckbox.Name = "MonstersCheckbox";
            this.MonstersCheckbox.Size = new System.Drawing.Size(15, 14);
            this.MonstersCheckbox.TabIndex = 31;
            this.MonstersCheckbox.UseVisualStyleBackColor = true;
            // 
            // NPCsCheckbox
            // 
            this.NPCsCheckbox.AutoSize = true;
            this.NPCsCheckbox.Location = new System.Drawing.Point(122, 316);
            this.NPCsCheckbox.Name = "NPCsCheckbox";
            this.NPCsCheckbox.Size = new System.Drawing.Size(15, 14);
            this.NPCsCheckbox.TabIndex = 32;
            this.NPCsCheckbox.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Minecraftia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(339, 208);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(125, 21);
            this.label14.TabIndex = 33;
            this.label14.Text = "Enfore Whitelist";
            // 
            // EnforeWhitelistCheckBox
            // 
            this.EnforeWhitelistCheckBox.AutoSize = true;
            this.EnforeWhitelistCheckBox.Location = new System.Drawing.Point(517, 209);
            this.EnforeWhitelistCheckBox.Name = "EnforeWhitelistCheckBox";
            this.EnforeWhitelistCheckBox.Size = new System.Drawing.Size(15, 14);
            this.EnforeWhitelistCheckBox.TabIndex = 34;
            this.EnforeWhitelistCheckBox.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Minecraftia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(34, 337);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(166, 21);
            this.label15.TabIndex = 35;
            this.label15.Text = "Generate Structures";
            // 
            // GenerateStructureCheckbox
            // 
            this.GenerateStructureCheckbox.AutoSize = true;
            this.GenerateStructureCheckbox.Location = new System.Drawing.Point(210, 339);
            this.GenerateStructureCheckbox.Name = "GenerateStructureCheckbox";
            this.GenerateStructureCheckbox.Size = new System.Drawing.Size(15, 14);
            this.GenerateStructureCheckbox.TabIndex = 36;
            this.GenerateStructureCheckbox.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Minecraftia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(339, 229);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(169, 21);
            this.label16.TabIndex = 37;
            this.label16.Text = "Enable Command Block";
            // 
            // FilesDropdown
            // 
            this.FilesDropdown.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FilesDropdownConfig,
            this.FilesDropdownProperties,
            this.whitelistToolStripMenuItem,
            this.bannedToolStripMenuItem,
            this.oPsToolStripMenuItem});
            this.FilesDropdown.Name = "FilesDropdown";
            this.FilesDropdown.Size = new System.Drawing.Size(57, 25);
            this.FilesDropdown.Text = "Files";
            // 
            // FilesDropdownConfig
            // 
            this.FilesDropdownConfig.Name = "FilesDropdownConfig";
            this.FilesDropdownConfig.Size = new System.Drawing.Size(161, 26);
            this.FilesDropdownConfig.Text = "Config";
            this.FilesDropdownConfig.Click += new System.EventHandler(this.FilesDropdownConfig_Click);
            // 
            // FilesDropdownProperties
            // 
            this.FilesDropdownProperties.Name = "FilesDropdownProperties";
            this.FilesDropdownProperties.Size = new System.Drawing.Size(161, 26);
            this.FilesDropdownProperties.Text = "Properties";
            this.FilesDropdownProperties.Click += new System.EventHandler(this.FilesDropdownProperties_Click);
            // 
            // whitelistToolStripMenuItem
            // 
            this.whitelistToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteWhitelistToolStripMenuItem});
            this.whitelistToolStripMenuItem.Name = "whitelistToolStripMenuItem";
            this.whitelistToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.whitelistToolStripMenuItem.Text = "Whitelist";
            this.whitelistToolStripMenuItem.Click += new System.EventHandler(this.whitelistToolStripMenuItem_Click);
            // 
            // deleteWhitelistToolStripMenuItem
            // 
            this.deleteWhitelistToolStripMenuItem.Font = new System.Drawing.Font("Minecraftia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteWhitelistToolStripMenuItem.Name = "deleteWhitelistToolStripMenuItem";
            this.deleteWhitelistToolStripMenuItem.Size = new System.Drawing.Size(120, 24);
            this.deleteWhitelistToolStripMenuItem.Text = "Delete";
            this.deleteWhitelistToolStripMenuItem.Click += new System.EventHandler(this.deleteWhitelistToolStripMenuItem_Click);
            // 
            // bannedToolStripMenuItem
            // 
            this.bannedToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playersToolStripMenuItem,
            this.iPsToolStripMenuItem});
            this.bannedToolStripMenuItem.Name = "bannedToolStripMenuItem";
            this.bannedToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.bannedToolStripMenuItem.Text = "Banned";
            // 
            // playersToolStripMenuItem
            // 
            this.playersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deletePlayersToolStripMenuItem});
            this.playersToolStripMenuItem.Name = "playersToolStripMenuItem";
            this.playersToolStripMenuItem.Size = new System.Drawing.Size(139, 26);
            this.playersToolStripMenuItem.Text = "Players";
            this.playersToolStripMenuItem.Click += new System.EventHandler(this.playersToolStripMenuItem_Click);
            // 
            // deletePlayersToolStripMenuItem
            // 
            this.deletePlayersToolStripMenuItem.Font = new System.Drawing.Font("Minecraftia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletePlayersToolStripMenuItem.Name = "deletePlayersToolStripMenuItem";
            this.deletePlayersToolStripMenuItem.Size = new System.Drawing.Size(120, 24);
            this.deletePlayersToolStripMenuItem.Text = "Delete";
            this.deletePlayersToolStripMenuItem.Click += new System.EventHandler(this.deletePlayersToolStripMenuItem_Click);
            // 
            // iPsToolStripMenuItem
            // 
            this.iPsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteIPSToolStripMenuItem});
            this.iPsToolStripMenuItem.Name = "iPsToolStripMenuItem";
            this.iPsToolStripMenuItem.Size = new System.Drawing.Size(139, 26);
            this.iPsToolStripMenuItem.Text = "IPs";
            this.iPsToolStripMenuItem.Click += new System.EventHandler(this.iPsToolStripMenuItem_Click);
            // 
            // deleteIPSToolStripMenuItem
            // 
            this.deleteIPSToolStripMenuItem.Font = new System.Drawing.Font("Minecraftia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteIPSToolStripMenuItem.Name = "deleteIPSToolStripMenuItem";
            this.deleteIPSToolStripMenuItem.Size = new System.Drawing.Size(120, 24);
            this.deleteIPSToolStripMenuItem.Text = "Delete";
            this.deleteIPSToolStripMenuItem.Click += new System.EventHandler(this.deleteIPSToolStripMenuItem_Click);
            // 
            // oPsToolStripMenuItem
            // 
            this.oPsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteOPSToolStripMenuItem});
            this.oPsToolStripMenuItem.Name = "oPsToolStripMenuItem";
            this.oPsToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.oPsToolStripMenuItem.Text = "OPs";
            this.oPsToolStripMenuItem.Click += new System.EventHandler(this.oPsToolStripMenuItem_Click);
            // 
            // deleteOPSToolStripMenuItem
            // 
            this.deleteOPSToolStripMenuItem.Font = new System.Drawing.Font("Minecraftia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteOPSToolStripMenuItem.Name = "deleteOPSToolStripMenuItem";
            this.deleteOPSToolStripMenuItem.Size = new System.Drawing.Size(120, 24);
            this.deleteOPSToolStripMenuItem.Text = "Delete";
            this.deleteOPSToolStripMenuItem.Click += new System.EventHandler(this.deleteOPSToolStripMenuItem_Click);
            // 
            // FoldersDropdown
            // 
            this.FoldersDropdown.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programToolStripMenuItem,
            this.FoldersDropdownData,
            this.FoldersDropdownWorlds});
            this.FoldersDropdown.Name = "FoldersDropdown";
            this.FoldersDropdown.Size = new System.Drawing.Size(81, 25);
            this.FoldersDropdown.Text = "Folders";
            // 
            // FoldersDropdownData
            // 
            this.FoldersDropdownData.Name = "FoldersDropdownData";
            this.FoldersDropdownData.Size = new System.Drawing.Size(180, 26);
            this.FoldersDropdownData.Text = "Data";
            this.FoldersDropdownData.Click += new System.EventHandler(this.FoldersDropdownData_Click);
            // 
            // FoldersDropdownWorlds
            // 
            this.FoldersDropdownWorlds.Name = "FoldersDropdownWorlds";
            this.FoldersDropdownWorlds.Size = new System.Drawing.Size(180, 26);
            this.FoldersDropdownWorlds.Text = "Worlds";
            this.FoldersDropdownWorlds.Click += new System.EventHandler(this.FoldersDropdownWorlds_Click);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(84, 25);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(54, 25);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // mOTDToolStripMenuItem
            // 
            this.mOTDToolStripMenuItem.Name = "mOTDToolStripMenuItem";
            this.mOTDToolStripMenuItem.Size = new System.Drawing.Size(58, 25);
            this.mOTDToolStripMenuItem.Text = "MOTD";
            this.mOTDToolStripMenuItem.Click += new System.EventHandler(this.mOTDToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Minecraftia", 9F);
            this.menuStrip1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FilesDropdown,
            this.FoldersDropdown,
            this.refreshToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.mOTDToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(620, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // EnableCMDBlockCheckBox
            // 
            this.EnableCMDBlockCheckBox.AutoSize = true;
            this.EnableCMDBlockCheckBox.Location = new System.Drawing.Point(517, 231);
            this.EnableCMDBlockCheckBox.Name = "EnableCMDBlockCheckBox";
            this.EnableCMDBlockCheckBox.Size = new System.Drawing.Size(15, 14);
            this.EnableCMDBlockCheckBox.TabIndex = 39;
            this.EnableCMDBlockCheckBox.UseVisualStyleBackColor = true;
            // 
            // ServerStartButton
            // 
            this.ServerStartButton.BackColor = System.Drawing.Color.Silver;
            this.ServerStartButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ServerStartButton.FlatAppearance.BorderSize = 2;
            this.ServerStartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ServerStartButton.Font = new System.Drawing.Font("Minecraftia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServerStartButton.ForeColor = System.Drawing.Color.White;
            this.ServerStartButton.Location = new System.Drawing.Point(468, 389);
            this.ServerStartButton.Name = "ServerStartButton";
            this.ServerStartButton.Size = new System.Drawing.Size(129, 76);
            this.ServerStartButton.TabIndex = 40;
            this.ServerStartButton.Text = "START SERVER";
            this.ServerStartButton.UseVisualStyleBackColor = false;
            this.ServerStartButton.Click += new System.EventHandler(this.ServerStartButton_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Minecraftia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(339, 187);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(122, 21);
            this.label17.TabIndex = 41;
            this.label17.Text = "Enable Whitelist";
            // 
            // WhitelistEnabledCheckBox
            // 
            this.WhitelistEnabledCheckBox.AutoSize = true;
            this.WhitelistEnabledCheckBox.Location = new System.Drawing.Point(517, 189);
            this.WhitelistEnabledCheckBox.Name = "WhitelistEnabledCheckBox";
            this.WhitelistEnabledCheckBox.Size = new System.Drawing.Size(15, 14);
            this.WhitelistEnabledCheckBox.TabIndex = 42;
            this.WhitelistEnabledCheckBox.UseVisualStyleBackColor = true;
            // 
            // PathFoundLabel2
            // 
            this.PathFoundLabel2.AutoSize = true;
            this.PathFoundLabel2.Font = new System.Drawing.Font("Minecraftia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PathFoundLabel2.Location = new System.Drawing.Point(444, 287);
            this.PathFoundLabel2.Name = "PathFoundLabel2";
            this.PathFoundLabel2.Size = new System.Drawing.Size(153, 19);
            this.PathFoundLabel2.TabIndex = 46;
            this.PathFoundLabel2.Text = "Check for Executable!";
            // 
            // LaunchTypeJAR2
            // 
            this.LaunchTypeJAR2.AutoSize = true;
            this.LaunchTypeJAR2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LaunchTypeJAR2.Font = new System.Drawing.Font("Minecraftia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LaunchTypeJAR2.Location = new System.Drawing.Point(369, 297);
            this.LaunchTypeJAR2.Name = "LaunchTypeJAR2";
            this.LaunchTypeJAR2.Size = new System.Drawing.Size(58, 25);
            this.LaunchTypeJAR2.TabIndex = 45;
            this.LaunchTypeJAR2.TabStop = true;
            this.LaunchTypeJAR2.Text = ".JAR";
            this.LaunchTypeJAR2.UseVisualStyleBackColor = true;
            this.LaunchTypeJAR2.CheckedChanged += new System.EventHandler(this.LaunchTypeJAR2_CheckedChanged);
            // 
            // LaunchTypeBAT2
            // 
            this.LaunchTypeBAT2.AutoSize = true;
            this.LaunchTypeBAT2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LaunchTypeBAT2.Font = new System.Drawing.Font("Minecraftia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LaunchTypeBAT2.Location = new System.Drawing.Point(369, 271);
            this.LaunchTypeBAT2.Name = "LaunchTypeBAT2";
            this.LaunchTypeBAT2.Size = new System.Drawing.Size(58, 25);
            this.LaunchTypeBAT2.TabIndex = 44;
            this.LaunchTypeBAT2.TabStop = true;
            this.LaunchTypeBAT2.Text = ".BAT";
            this.LaunchTypeBAT2.UseVisualStyleBackColor = true;
            this.LaunchTypeBAT2.CheckedChanged += new System.EventHandler(this.LaunchTypeBAT2_CheckedChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Minecraftia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(339, 250);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(106, 21);
            this.label18.TabIndex = 43;
            this.label18.Text = "Launch Type:";
            // 
            // programToolStripMenuItem
            // 
            this.programToolStripMenuItem.Name = "programToolStripMenuItem";
            this.programToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.programToolStripMenuItem.Text = "Program";
            this.programToolStripMenuItem.Click += new System.EventHandler(this.programToolStripMenuItem_Click);
            // 
            // MCServerLauncherMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 487);
            this.Controls.Add(this.PathFoundLabel2);
            this.Controls.Add(this.LaunchTypeJAR2);
            this.Controls.Add(this.LaunchTypeBAT2);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.WhitelistEnabledCheckBox);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.ServerStartButton);
            this.Controls.Add(this.EnableCMDBlockCheckBox);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.GenerateStructureCheckbox);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.EnforeWhitelistCheckBox);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.NPCsCheckbox);
            this.Controls.Add(this.MonstersCheckbox);
            this.Controls.Add(this.AnimalsCheckbox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.MapSeedBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.HostnameBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.PVPCheckBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.HardcoreCheckbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DifficultyListBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.GamemodeListBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.DeleteWorldButton);
            this.Controls.Add(this.CopyWorldButton);
            this.Controls.Add(this.NewWorldButton);
            this.Controls.Add(this.ServerWorldListBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MCServerLauncherMainForm";
            this.Text = "Minecraft Server Launcher";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MCServerLauncherMainForm_FormClosing);
            this.Load += new System.EventHandler(this.MCServerLauncherMainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ServerWorldListBox;
        private System.Windows.Forms.Button NewWorldButton;
        private System.Windows.Forms.Button CopyWorldButton;
        private System.Windows.Forms.Button DeleteWorldButton;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox GamemodeListBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox DifficultyListBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox HardcoreCheckbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox PVPCheckBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox HostnameBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox MapSeedBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox AnimalsCheckbox;
        private System.Windows.Forms.CheckBox MonstersCheckbox;
        private System.Windows.Forms.CheckBox NPCsCheckbox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckBox EnforeWhitelistCheckBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.CheckBox GenerateStructureCheckbox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ToolStripMenuItem FilesDropdown;
        private System.Windows.Forms.ToolStripMenuItem FilesDropdownConfig;
        private System.Windows.Forms.ToolStripMenuItem FilesDropdownProperties;
        private System.Windows.Forms.ToolStripMenuItem FoldersDropdown;
        private System.Windows.Forms.ToolStripMenuItem FoldersDropdownData;
        private System.Windows.Forms.ToolStripMenuItem FoldersDropdownWorlds;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mOTDToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.CheckBox EnableCMDBlockCheckBox;
        private System.Windows.Forms.Button ServerStartButton;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.CheckBox WhitelistEnabledCheckBox;
        private System.Windows.Forms.Label PathFoundLabel2;
        private System.Windows.Forms.RadioButton LaunchTypeJAR2;
        private System.Windows.Forms.RadioButton LaunchTypeBAT2;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ToolStripMenuItem whitelistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bannedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iPsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oPsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deletePlayersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteIPSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteOPSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteWhitelistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem programToolStripMenuItem;
    }
}