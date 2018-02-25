namespace ethminerGUI
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editProfilesXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.setEthminerexeLocationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setDefaultsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.saveEXEConfigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.defaultMISCSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ETHMINERHelpFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TextBoxAccount = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ButtonRemoveProfile = new System.Windows.Forms.Button();
            this.ButtonAddProfile = new System.Windows.Forms.Button();
            this.labelProfiles = new System.Windows.Forms.Label();
            this.ListBoxProfiles = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TextBoxPool1 = new System.Windows.Forms.TextBox();
            this.enableWatchdog = new System.Windows.Forms.CheckBox();
            this.watchdogtimeout = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TextBoxPool2 = new System.Windows.Forms.TextBox();
            this.EnableBenchmark = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.benchmarkseconds = new System.Windows.Forms.TextBox();
            this.benchmarktrialsecs = new System.Windows.Forms.TextBox();
            this.benchmarktrials = new System.Windows.Forms.TextBox();
            this.EnableSimulation = new System.Windows.Forms.CheckBox();
            this.TextBoxSimblock = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.ButtonStartMining = new System.Windows.Forms.Button();
            this.checkBoxSave = new System.Windows.Forms.CheckBox();
            this.ButtonLoadProfile = new System.Windows.Forms.Button();
            this.Worktype = new System.Windows.Forms.GroupBox();
            this.TextBoxRecheck = new System.Windows.Forms.TextBox();
            this.labelRecheck = new System.Windows.Forms.Label();
            this.RadioStratumMode = new System.Windows.Forms.RadioButton();
            this.RadioFarmMode = new System.Windows.Forms.RadioButton();
            this.GroupBoxBenchmark = new System.Windows.Forms.GroupBox();
            this.GroupBoxSimulation = new System.Windows.Forms.GroupBox();
            this.GroupBoxWatchDog = new System.Windows.Forms.GroupBox();
            this.CheckBoxCreateLog = new System.Windows.Forms.CheckBox();
            this.GroupBoxPools = new System.Windows.Forms.GroupBox();
            this.TextBoxPoolPort2 = new System.Windows.Forms.TextBox();
            this.TextBoxPoolPort1 = new System.Windows.Forms.TextBox();
            this.TextBoxEmail = new System.Windows.Forms.TextBox();
            this.TextBoxWorker = new System.Windows.Forms.TextBox();
            this.LabelEmail = new System.Windows.Forms.Label();
            this.LabelWorker = new System.Windows.Forms.Label();
            this.groupBoxGPU = new System.Windows.Forms.GroupBox();
            this.RadioButtonMixedCards = new System.Windows.Forms.RadioButton();
            this.CheckBoxHWMON = new System.Windows.Forms.CheckBox();
            this.RadioButtonOpenCL = new System.Windows.Forms.RadioButton();
            this.RadioButtonCUDA = new System.Windows.Forms.RadioButton();
            this.RadioButtonSC1 = new System.Windows.Forms.RadioButton();
            this.RadioButtonSC2 = new System.Windows.Forms.RadioButton();
            this.GroupBoxClientType = new System.Windows.Forms.GroupBox();
            this.GroupBoxStratumProtocol = new System.Windows.Forms.GroupBox();
            this.CheckBoxRH = new System.Windows.Forms.CheckBox();
            this.RadioButtonSP2 = new System.Windows.Forms.RadioButton();
            this.RadioButtonSP1 = new System.Windows.Forms.RadioButton();
            this.RadioButtonSP0 = new System.Windows.Forms.RadioButton();
            this.GroupBoxMisc = new System.Windows.Forms.GroupBox();
            this.CheckBoxNoWarnings = new System.Windows.Forms.CheckBox();
            this.CheckBoxSaveOnExit = new System.Windows.Forms.CheckBox();
            this.CheckBoxIdle = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBoxIdleMins = new System.Windows.Forms.TextBox();
            this.TextBoxExtra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CheckBoxExtra = new System.Windows.Forms.CheckBox();
            this.labelVerbosity = new System.Windows.Forms.Label();
            this.ComboBoxVerbosity = new System.Windows.Forms.ComboBox();
            this.LCurrentCommand = new System.Windows.Forms.Label();
            this.ToolTipEGUI = new System.Windows.Forms.ToolTip(this.components);
            this.TextBoxProfileSaveName = new System.Windows.Forms.TextBox();
            this.ButtonSaveProfileName = new System.Windows.Forms.Button();
            this.GroupBoxProfileSave = new System.Windows.Forms.GroupBox();
            this.LabelCommand = new System.Windows.Forms.Label();
            this.LabelProfileNameLoaded = new System.Windows.Forms.Label();
            this.ButtonCancelProfileName = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.Worktype.SuspendLayout();
            this.GroupBoxBenchmark.SuspendLayout();
            this.GroupBoxSimulation.SuspendLayout();
            this.GroupBoxWatchDog.SuspendLayout();
            this.GroupBoxPools.SuspendLayout();
            this.groupBoxGPU.SuspendLayout();
            this.GroupBoxClientType.SuspendLayout();
            this.GroupBoxStratumProtocol.SuspendLayout();
            this.GroupBoxMisc.SuspendLayout();
            this.GroupBoxProfileSave.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(823, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editProfilesXMLToolStripMenuItem,
            this.toolStripSeparator1,
            this.setEthminerexeLocationToolStripMenuItem,
            this.setDefaultsToolStripMenuItem,
            this.toolStripSeparator2,
            this.saveEXEConfigToolStripMenuItem,
            this.defaultMISCSettingsToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // editProfilesXMLToolStripMenuItem
            // 
            this.editProfilesXMLToolStripMenuItem.Name = "editProfilesXMLToolStripMenuItem";
            this.editProfilesXMLToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.editProfilesXMLToolStripMenuItem.Text = "Edit profiles.xml";
            this.editProfilesXMLToolStripMenuItem.Click += new System.EventHandler(this.editProfilesXMLToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(185, 6);
            // 
            // setEthminerexeLocationToolStripMenuItem
            // 
            this.setEthminerexeLocationToolStripMenuItem.Name = "setEthminerexeLocationToolStripMenuItem";
            this.setEthminerexeLocationToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.setEthminerexeLocationToolStripMenuItem.Text = "Set EXE Location";
            this.setEthminerexeLocationToolStripMenuItem.Click += new System.EventHandler(this.setEthminerexeLocationToolStripMenuItem_Click);
            // 
            // setDefaultsToolStripMenuItem
            // 
            this.setDefaultsToolStripMenuItem.Name = "setDefaultsToolStripMenuItem";
            this.setDefaultsToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.setDefaultsToolStripMenuItem.Text = "Set Default Location";
            this.setDefaultsToolStripMenuItem.Click += new System.EventHandler(this.setDefaultsToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(185, 6);
            // 
            // saveEXEConfigToolStripMenuItem
            // 
            this.saveEXEConfigToolStripMenuItem.Name = "saveEXEConfigToolStripMenuItem";
            this.saveEXEConfigToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.saveEXEConfigToolStripMenuItem.Text = "Save MISC Settings";
            this.saveEXEConfigToolStripMenuItem.Click += new System.EventHandler(this.saveEXEConfigToolStripMenuItem_Click);
            // 
            // defaultMISCSettingsToolStripMenuItem
            // 
            this.defaultMISCSettingsToolStripMenuItem.Name = "defaultMISCSettingsToolStripMenuItem";
            this.defaultMISCSettingsToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.defaultMISCSettingsToolStripMenuItem.Text = "Default MISC Settings";
            this.defaultMISCSettingsToolStripMenuItem.Click += new System.EventHandler(this.defaultMISCSettingsToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ETHMINERHelpFileToolStripMenuItem,
            this.AboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // ETHMINERHelpFileToolStripMenuItem
            // 
            this.ETHMINERHelpFileToolStripMenuItem.Name = "ETHMINERHelpFileToolStripMenuItem";
            this.ETHMINERHelpFileToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.ETHMINERHelpFileToolStripMenuItem.Text = "ETHMINER Help File";
            this.ETHMINERHelpFileToolStripMenuItem.Click += new System.EventHandler(this.eTHMINERHelpFileToolStripMenuItem_Click);
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            this.AboutToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.AboutToolStripMenuItem.Text = "About";
            this.AboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // TextBoxAccount
            // 
            this.TextBoxAccount.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxAccount.Location = new System.Drawing.Point(73, 64);
            this.TextBoxAccount.Name = "TextBoxAccount";
            this.TextBoxAccount.Size = new System.Drawing.Size(265, 20);
            this.TextBoxAccount.TabIndex = 7;
            this.TextBoxAccount.TextChanged += new System.EventHandler(this.TextBoxAccount_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Account (-O)";
            // 
            // ButtonRemoveProfile
            // 
            this.ButtonRemoveProfile.Location = new System.Drawing.Point(710, 440);
            this.ButtonRemoveProfile.Name = "ButtonRemoveProfile";
            this.ButtonRemoveProfile.Size = new System.Drawing.Size(95, 23);
            this.ButtonRemoveProfile.TabIndex = 16;
            this.ButtonRemoveProfile.Text = "Remove";
            this.ButtonRemoveProfile.UseVisualStyleBackColor = true;
            this.ButtonRemoveProfile.Click += new System.EventHandler(this.ButtonRemoveProfile_Click);
            // 
            // ButtonAddProfile
            // 
            this.ButtonAddProfile.Location = new System.Drawing.Point(609, 440);
            this.ButtonAddProfile.Name = "ButtonAddProfile";
            this.ButtonAddProfile.Size = new System.Drawing.Size(95, 23);
            this.ButtonAddProfile.TabIndex = 15;
            this.ButtonAddProfile.Text = "Add";
            this.ButtonAddProfile.UseVisualStyleBackColor = true;
            this.ButtonAddProfile.Click += new System.EventHandler(this.ButtonAddProfile_Click);
            // 
            // labelProfiles
            // 
            this.labelProfiles.AutoSize = true;
            this.labelProfiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProfiles.Location = new System.Drawing.Point(606, 36);
            this.labelProfiles.Name = "labelProfiles";
            this.labelProfiles.Size = new System.Drawing.Size(49, 13);
            this.labelProfiles.TabIndex = 12;
            this.labelProfiles.Text = "Profiles";
            // 
            // ListBoxProfiles
            // 
            this.ListBoxProfiles.FormattingEnabled = true;
            this.ListBoxProfiles.Location = new System.Drawing.Point(609, 55);
            this.ListBoxProfiles.Name = "ListBoxProfiles";
            this.ListBoxProfiles.Size = new System.Drawing.Size(196, 355);
            this.ListBoxProfiles.TabIndex = 13;
            this.ListBoxProfiles.SelectedIndexChanged += new System.EventHandler(this.ListBoxProfiles_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Pool / Port";
            // 
            // TextBoxPool1
            // 
            this.TextBoxPool1.Location = new System.Drawing.Point(73, 16);
            this.TextBoxPool1.Name = "TextBoxPool1";
            this.TextBoxPool1.Size = new System.Drawing.Size(219, 20);
            this.TextBoxPool1.TabIndex = 1;
            this.TextBoxPool1.TextChanged += new System.EventHandler(this.TextBoxPool1_TextChanged);
            // 
            // enableWatchdog
            // 
            this.enableWatchdog.AutoSize = true;
            this.enableWatchdog.Location = new System.Drawing.Point(6, 19);
            this.enableWatchdog.Name = "enableWatchdog";
            this.enableWatchdog.Size = new System.Drawing.Size(59, 17);
            this.enableWatchdog.TabIndex = 0;
            this.enableWatchdog.Text = "Enable";
            this.enableWatchdog.UseVisualStyleBackColor = true;
            // 
            // watchdogtimeout
            // 
            this.watchdogtimeout.Location = new System.Drawing.Point(6, 42);
            this.watchdogtimeout.MaxLength = 4;
            this.watchdogtimeout.Name = "watchdogtimeout";
            this.watchdogtimeout.Size = new System.Drawing.Size(38, 20);
            this.watchdogtimeout.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(50, 49);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(115, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Restart Timeout (Secs)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Extra Pool";
            // 
            // TextBoxPool2
            // 
            this.TextBoxPool2.Location = new System.Drawing.Point(73, 38);
            this.TextBoxPool2.Name = "TextBoxPool2";
            this.TextBoxPool2.Size = new System.Drawing.Size(219, 20);
            this.TextBoxPool2.TabIndex = 4;
            this.TextBoxPool2.TextChanged += new System.EventHandler(this.TextBoxPool2_TextChanged);
            // 
            // EnableBenchmark
            // 
            this.EnableBenchmark.AutoSize = true;
            this.EnableBenchmark.Location = new System.Drawing.Point(9, 19);
            this.EnableBenchmark.Name = "EnableBenchmark";
            this.EnableBenchmark.Size = new System.Drawing.Size(151, 17);
            this.EnableBenchmark.TabIndex = 0;
            this.EnableBenchmark.Text = "Enable Benchmarking (-M)";
            this.EnableBenchmark.UseVisualStyleBackColor = true;
            this.EnableBenchmark.CheckStateChanged += new System.EventHandler(this.EnableBenchmark_CheckStateChanged);
            this.EnableBenchmark.Click += new System.EventHandler(this.EnableBenchmark_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "benchmark-warmup <seconds>";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "benchmark-trial <seconds>";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(15, 86);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(145, 13);
            this.label12.TabIndex = 5;
            this.label12.Text = "benchmark-trials <Default: 5>";
            // 
            // benchmarkseconds
            // 
            this.benchmarkseconds.Enabled = false;
            this.benchmarkseconds.Location = new System.Drawing.Point(175, 38);
            this.benchmarkseconds.MaxLength = 5;
            this.benchmarkseconds.Name = "benchmarkseconds";
            this.benchmarkseconds.Size = new System.Drawing.Size(50, 20);
            this.benchmarkseconds.TabIndex = 2;
            this.benchmarkseconds.TextChanged += new System.EventHandler(this.benchmarkseconds_TextChanged);
            // 
            // benchmarktrialsecs
            // 
            this.benchmarktrialsecs.Enabled = false;
            this.benchmarktrialsecs.Location = new System.Drawing.Point(175, 61);
            this.benchmarktrialsecs.MaxLength = 5;
            this.benchmarktrialsecs.Name = "benchmarktrialsecs";
            this.benchmarktrialsecs.Size = new System.Drawing.Size(50, 20);
            this.benchmarktrialsecs.TabIndex = 4;
            this.benchmarktrialsecs.TextChanged += new System.EventHandler(this.benchmarktrialsecs_TextChanged);
            // 
            // benchmarktrials
            // 
            this.benchmarktrials.Enabled = false;
            this.benchmarktrials.Location = new System.Drawing.Point(175, 83);
            this.benchmarktrials.MaxLength = 2;
            this.benchmarktrials.Name = "benchmarktrials";
            this.benchmarktrials.Size = new System.Drawing.Size(50, 20);
            this.benchmarktrials.TabIndex = 6;
            this.benchmarktrials.TextChanged += new System.EventHandler(this.benchmarktrials_TextChanged);
            // 
            // EnableSimulation
            // 
            this.EnableSimulation.AutoSize = true;
            this.EnableSimulation.Location = new System.Drawing.Point(6, 19);
            this.EnableSimulation.Name = "EnableSimulation";
            this.EnableSimulation.Size = new System.Drawing.Size(129, 17);
            this.EnableSimulation.TabIndex = 0;
            this.EnableSimulation.Text = "Enable Simulation (-Z)";
            this.EnableSimulation.UseVisualStyleBackColor = true;
            this.EnableSimulation.CheckStateChanged += new System.EventHandler(this.EnableSimulation_CheckStateChanged);
            this.EnableSimulation.Click += new System.EventHandler(this.EnableSimulation_Click);
            // 
            // TextBoxSimblock
            // 
            this.TextBoxSimblock.Enabled = false;
            this.TextBoxSimblock.Location = new System.Drawing.Point(111, 36);
            this.TextBoxSimblock.MaxLength = 9;
            this.TextBoxSimblock.Name = "TextBoxSimblock";
            this.TextBoxSimblock.Size = new System.Drawing.Size(66, 20);
            this.TextBoxSimblock.TabIndex = 2;
            this.TextBoxSimblock.TextChanged += new System.EventHandler(this.simblock_TextChanged);
            this.TextBoxSimblock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxSimblock_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 39);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(86, 13);
            this.label13.TabIndex = 1;
            this.label13.Text = "Optional Block #";
            // 
            // ButtonStartMining
            // 
            this.ButtonStartMining.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonStartMining.ForeColor = System.Drawing.Color.Red;
            this.ButtonStartMining.Location = new System.Drawing.Point(398, 334);
            this.ButtonStartMining.Name = "ButtonStartMining";
            this.ButtonStartMining.Size = new System.Drawing.Size(158, 36);
            this.ButtonStartMining.TabIndex = 11;
            this.ButtonStartMining.Text = "Start Miner";
            this.ButtonStartMining.UseVisualStyleBackColor = true;
            this.ButtonStartMining.Click += new System.EventHandler(this.ButtonStartMining_Click);
            // 
            // checkBoxSave
            // 
            this.checkBoxSave.AutoSize = true;
            this.checkBoxSave.Location = new System.Drawing.Point(619, 470);
            this.checkBoxSave.Name = "checkBoxSave";
            this.checkBoxSave.Size = new System.Drawing.Size(176, 17);
            this.checkBoxSave.TabIndex = 17;
            this.checkBoxSave.Text = "Keep last profile loaded on exit?";
            this.checkBoxSave.UseVisualStyleBackColor = true;
            // 
            // ButtonLoadProfile
            // 
            this.ButtonLoadProfile.Location = new System.Drawing.Point(609, 416);
            this.ButtonLoadProfile.Name = "ButtonLoadProfile";
            this.ButtonLoadProfile.Size = new System.Drawing.Size(196, 21);
            this.ButtonLoadProfile.TabIndex = 14;
            this.ButtonLoadProfile.Text = "Load";
            this.ButtonLoadProfile.UseVisualStyleBackColor = true;
            this.ButtonLoadProfile.Click += new System.EventHandler(this.buttonLoadProfile_Click);
            // 
            // Worktype
            // 
            this.Worktype.Controls.Add(this.TextBoxRecheck);
            this.Worktype.Controls.Add(this.labelRecheck);
            this.Worktype.Controls.Add(this.RadioStratumMode);
            this.Worktype.Controls.Add(this.RadioFarmMode);
            this.Worktype.Location = new System.Drawing.Point(19, 36);
            this.Worktype.Name = "Worktype";
            this.Worktype.Size = new System.Drawing.Size(320, 68);
            this.Worktype.TabIndex = 0;
            this.Worktype.TabStop = false;
            this.Worktype.Text = "Work Method";
            // 
            // TextBoxRecheck
            // 
            this.TextBoxRecheck.Location = new System.Drawing.Point(163, 42);
            this.TextBoxRecheck.MaxLength = 5;
            this.TextBoxRecheck.Name = "TextBoxRecheck";
            this.TextBoxRecheck.Size = new System.Drawing.Size(43, 20);
            this.TextBoxRecheck.TabIndex = 3;
            this.TextBoxRecheck.Text = "500";
            this.TextBoxRecheck.TextChanged += new System.EventHandler(this.TextBoxRecheck_TextChanged);
            // 
            // labelRecheck
            // 
            this.labelRecheck.AutoSize = true;
            this.labelRecheck.Location = new System.Drawing.Point(6, 45);
            this.labelRecheck.Name = "labelRecheck";
            this.labelRecheck.Size = new System.Drawing.Size(149, 13);
            this.labelRecheck.TabIndex = 2;
            this.labelRecheck.Text = "--farm-recheck (microseconds)";
            // 
            // RadioStratumMode
            // 
            this.RadioStratumMode.AutoSize = true;
            this.RadioStratumMode.Checked = true;
            this.RadioStratumMode.Location = new System.Drawing.Point(6, 19);
            this.RadioStratumMode.Name = "RadioStratumMode";
            this.RadioStratumMode.Size = new System.Drawing.Size(110, 17);
            this.RadioStratumMode.TabIndex = 0;
            this.RadioStratumMode.TabStop = true;
            this.RadioStratumMode.Text = "Stratum Mode (-S)";
            this.RadioStratumMode.UseVisualStyleBackColor = true;
            this.RadioStratumMode.CheckedChanged += new System.EventHandler(this.radioStratumMode_CheckedChanged);
            // 
            // RadioFarmMode
            // 
            this.RadioFarmMode.AutoSize = true;
            this.RadioFarmMode.Location = new System.Drawing.Point(122, 19);
            this.RadioFarmMode.Name = "RadioFarmMode";
            this.RadioFarmMode.Size = new System.Drawing.Size(96, 17);
            this.RadioFarmMode.TabIndex = 1;
            this.RadioFarmMode.Text = "Farm Mode (-F)";
            this.RadioFarmMode.UseVisualStyleBackColor = true;
            this.RadioFarmMode.CheckedChanged += new System.EventHandler(this.radioFarmMode_CheckedChanged);
            // 
            // GroupBoxBenchmark
            // 
            this.GroupBoxBenchmark.Controls.Add(this.EnableBenchmark);
            this.GroupBoxBenchmark.Controls.Add(this.label4);
            this.GroupBoxBenchmark.Controls.Add(this.label5);
            this.GroupBoxBenchmark.Controls.Add(this.label12);
            this.GroupBoxBenchmark.Controls.Add(this.benchmarkseconds);
            this.GroupBoxBenchmark.Controls.Add(this.benchmarktrialsecs);
            this.GroupBoxBenchmark.Controls.Add(this.benchmarktrials);
            this.GroupBoxBenchmark.Location = new System.Drawing.Point(369, 36);
            this.GroupBoxBenchmark.Name = "GroupBoxBenchmark";
            this.GroupBoxBenchmark.Size = new System.Drawing.Size(231, 110);
            this.GroupBoxBenchmark.TabIndex = 8;
            this.GroupBoxBenchmark.TabStop = false;
            this.GroupBoxBenchmark.Text = "Benchmarking Mode:";
            // 
            // GroupBoxSimulation
            // 
            this.GroupBoxSimulation.Controls.Add(this.EnableSimulation);
            this.GroupBoxSimulation.Controls.Add(this.TextBoxSimblock);
            this.GroupBoxSimulation.Controls.Add(this.label13);
            this.GroupBoxSimulation.Location = new System.Drawing.Point(369, 152);
            this.GroupBoxSimulation.Name = "GroupBoxSimulation";
            this.GroupBoxSimulation.Size = new System.Drawing.Size(231, 68);
            this.GroupBoxSimulation.TabIndex = 9;
            this.GroupBoxSimulation.TabStop = false;
            this.GroupBoxSimulation.Text = "Simulation Mode:";
            // 
            // GroupBoxWatchDog
            // 
            this.GroupBoxWatchDog.Controls.Add(this.enableWatchdog);
            this.GroupBoxWatchDog.Controls.Add(this.watchdogtimeout);
            this.GroupBoxWatchDog.Controls.Add(this.label11);
            this.GroupBoxWatchDog.Location = new System.Drawing.Point(369, 226);
            this.GroupBoxWatchDog.Name = "GroupBoxWatchDog";
            this.GroupBoxWatchDog.Size = new System.Drawing.Size(231, 72);
            this.GroupBoxWatchDog.TabIndex = 10;
            this.GroupBoxWatchDog.TabStop = false;
            this.GroupBoxWatchDog.Text = "Watchdog Options (Future):";
            // 
            // CheckBoxCreateLog
            // 
            this.CheckBoxCreateLog.AutoSize = true;
            this.CheckBoxCreateLog.Location = new System.Drawing.Point(11, 70);
            this.CheckBoxCreateLog.Name = "CheckBoxCreateLog";
            this.CheckBoxCreateLog.Size = new System.Drawing.Size(84, 17);
            this.CheckBoxCreateLog.TabIndex = 1;
            this.CheckBoxCreateLog.Text = "Create Log?";
            this.CheckBoxCreateLog.UseVisualStyleBackColor = true;
            this.CheckBoxCreateLog.CheckStateChanged += new System.EventHandler(this.CheckBoxCreateLog_CheckStateChanged);
            // 
            // GroupBoxPools
            // 
            this.GroupBoxPools.Controls.Add(this.TextBoxPoolPort2);
            this.GroupBoxPools.Controls.Add(this.TextBoxPoolPort1);
            this.GroupBoxPools.Controls.Add(this.TextBoxEmail);
            this.GroupBoxPools.Controls.Add(this.TextBoxWorker);
            this.GroupBoxPools.Controls.Add(this.LabelEmail);
            this.GroupBoxPools.Controls.Add(this.TextBoxPool1);
            this.GroupBoxPools.Controls.Add(this.LabelWorker);
            this.GroupBoxPools.Controls.Add(this.TextBoxAccount);
            this.GroupBoxPools.Controls.Add(this.label8);
            this.GroupBoxPools.Controls.Add(this.label10);
            this.GroupBoxPools.Controls.Add(this.TextBoxPool2);
            this.GroupBoxPools.Controls.Add(this.label6);
            this.GroupBoxPools.Location = new System.Drawing.Point(19, 110);
            this.GroupBoxPools.Name = "GroupBoxPools";
            this.GroupBoxPools.Size = new System.Drawing.Size(344, 135);
            this.GroupBoxPools.TabIndex = 1;
            this.GroupBoxPools.TabStop = false;
            // 
            // TextBoxPoolPort2
            // 
            this.TextBoxPoolPort2.Location = new System.Drawing.Point(298, 38);
            this.TextBoxPoolPort2.MaxLength = 5;
            this.TextBoxPoolPort2.Name = "TextBoxPoolPort2";
            this.TextBoxPoolPort2.Size = new System.Drawing.Size(40, 20);
            this.TextBoxPoolPort2.TabIndex = 5;
            this.TextBoxPoolPort2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxPoolPort2_KeyPress);
            // 
            // TextBoxPoolPort1
            // 
            this.TextBoxPoolPort1.Location = new System.Drawing.Point(298, 16);
            this.TextBoxPoolPort1.MaxLength = 5;
            this.TextBoxPoolPort1.Name = "TextBoxPoolPort1";
            this.TextBoxPoolPort1.Size = new System.Drawing.Size(40, 20);
            this.TextBoxPoolPort1.TabIndex = 2;
            this.TextBoxPoolPort1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxPoolPort1_KeyPress);
            // 
            // TextBoxEmail
            // 
            this.TextBoxEmail.Location = new System.Drawing.Point(122, 103);
            this.TextBoxEmail.MaxLength = 254;
            this.TextBoxEmail.Name = "TextBoxEmail";
            this.TextBoxEmail.Size = new System.Drawing.Size(216, 20);
            this.TextBoxEmail.TabIndex = 10;
            this.TextBoxEmail.TextChanged += new System.EventHandler(this.TextBoxEmail_TextChanged);
            // 
            // TextBoxWorker
            // 
            this.TextBoxWorker.Location = new System.Drawing.Point(11, 103);
            this.TextBoxWorker.MaxLength = 8;
            this.TextBoxWorker.Name = "TextBoxWorker";
            this.TextBoxWorker.Size = new System.Drawing.Size(105, 20);
            this.TextBoxWorker.TabIndex = 9;
            this.TextBoxWorker.TextChanged += new System.EventHandler(this.TextBoxWorker_TextChanged);
            // 
            // LabelEmail
            // 
            this.LabelEmail.AutoSize = true;
            this.LabelEmail.Location = new System.Drawing.Point(258, 87);
            this.LabelEmail.Name = "LabelEmail";
            this.LabelEmail.Size = new System.Drawing.Size(80, 13);
            this.LabelEmail.TabIndex = 11;
            this.LabelEmail.Text = "Email (Optional)";
            // 
            // LabelWorker
            // 
            this.LabelWorker.AutoSize = true;
            this.LabelWorker.Location = new System.Drawing.Point(8, 87);
            this.LabelWorker.Name = "LabelWorker";
            this.LabelWorker.Size = new System.Drawing.Size(90, 13);
            this.LabelWorker.TabIndex = 8;
            this.LabelWorker.Text = "Worker (Optional)";
            // 
            // groupBoxGPU
            // 
            this.groupBoxGPU.Controls.Add(this.RadioButtonMixedCards);
            this.groupBoxGPU.Controls.Add(this.CheckBoxHWMON);
            this.groupBoxGPU.Controls.Add(this.RadioButtonOpenCL);
            this.groupBoxGPU.Controls.Add(this.RadioButtonCUDA);
            this.groupBoxGPU.Location = new System.Drawing.Point(19, 251);
            this.groupBoxGPU.Name = "groupBoxGPU";
            this.groupBoxGPU.Size = new System.Drawing.Size(320, 71);
            this.groupBoxGPU.TabIndex = 2;
            this.groupBoxGPU.TabStop = false;
            this.groupBoxGPU.Text = "GPU";
            // 
            // RadioButtonMixedCards
            // 
            this.RadioButtonMixedCards.AutoSize = true;
            this.RadioButtonMixedCards.Location = new System.Drawing.Point(6, 41);
            this.RadioButtonMixedCards.Name = "RadioButtonMixedCards";
            this.RadioButtonMixedCards.Size = new System.Drawing.Size(102, 17);
            this.RadioButtonMixedCards.TabIndex = 2;
            this.RadioButtonMixedCards.Text = "Mixed Cards (-X)";
            this.RadioButtonMixedCards.UseVisualStyleBackColor = true;
            this.RadioButtonMixedCards.CheckedChanged += new System.EventHandler(this.RadioButtonMixedCards_CheckedChanged);
            // 
            // CheckBoxHWMON
            // 
            this.CheckBoxHWMON.AutoSize = true;
            this.CheckBoxHWMON.Location = new System.Drawing.Point(113, 42);
            this.CheckBoxHWMON.Name = "CheckBoxHWMON";
            this.CheckBoxHWMON.Size = new System.Drawing.Size(189, 17);
            this.CheckBoxHWMON.TabIndex = 3;
            this.CheckBoxHWMON.Text = "Hardware Monitoring (-HWMON) ?";
            this.CheckBoxHWMON.UseVisualStyleBackColor = true;
            this.CheckBoxHWMON.CheckedChanged += new System.EventHandler(this.CheckBoxHWMON_CheckedChanged);
            // 
            // RadioButtonOpenCL
            // 
            this.RadioButtonOpenCL.AutoSize = true;
            this.RadioButtonOpenCL.Checked = true;
            this.RadioButtonOpenCL.Location = new System.Drawing.Point(6, 19);
            this.RadioButtonOpenCL.Name = "RadioButtonOpenCL";
            this.RadioButtonOpenCL.Size = new System.Drawing.Size(119, 17);
            this.RadioButtonOpenCL.TabIndex = 0;
            this.RadioButtonOpenCL.TabStop = true;
            this.RadioButtonOpenCL.Text = "OpenCL (-G / AMD)";
            this.RadioButtonOpenCL.UseVisualStyleBackColor = true;
            this.RadioButtonOpenCL.CheckedChanged += new System.EventHandler(this.RadioButtonOpenCL_CheckedChanged);
            // 
            // RadioButtonCUDA
            // 
            this.RadioButtonCUDA.AutoSize = true;
            this.RadioButtonCUDA.Location = new System.Drawing.Point(131, 19);
            this.RadioButtonCUDA.Name = "RadioButtonCUDA";
            this.RadioButtonCUDA.Size = new System.Drawing.Size(122, 17);
            this.RadioButtonCUDA.TabIndex = 1;
            this.RadioButtonCUDA.Text = "CUDA (-U / NVIDIA)";
            this.RadioButtonCUDA.UseVisualStyleBackColor = true;
            this.RadioButtonCUDA.CheckedChanged += new System.EventHandler(this.RadioButtonCUDA_CheckedChanged);
            // 
            // RadioButtonSC1
            // 
            this.RadioButtonSC1.AutoSize = true;
            this.RadioButtonSC1.Checked = true;
            this.RadioButtonSC1.Location = new System.Drawing.Point(6, 19);
            this.RadioButtonSC1.Name = "RadioButtonSC1";
            this.RadioButtonSC1.Size = new System.Drawing.Size(116, 17);
            this.RadioButtonSC1.TabIndex = 0;
            this.RadioButtonSC1.TabStop = true;
            this.RadioButtonSC1.Text = "async client (-SC 1)";
            this.RadioButtonSC1.UseVisualStyleBackColor = true;
            this.RadioButtonSC1.CheckedChanged += new System.EventHandler(this.RadioButtonSC1_CheckedChanged);
            // 
            // RadioButtonSC2
            // 
            this.RadioButtonSC2.AutoSize = true;
            this.RadioButtonSC2.Location = new System.Drawing.Point(131, 19);
            this.RadioButtonSC2.Name = "RadioButtonSC2";
            this.RadioButtonSC2.Size = new System.Drawing.Size(148, 17);
            this.RadioButtonSC2.TabIndex = 1;
            this.RadioButtonSC2.Text = "synchronous client (-SC 2)";
            this.RadioButtonSC2.UseVisualStyleBackColor = true;
            this.RadioButtonSC2.CheckedChanged += new System.EventHandler(this.RadioButtonSC2_CheckedChanged);
            // 
            // GroupBoxClientType
            // 
            this.GroupBoxClientType.Controls.Add(this.RadioButtonSC2);
            this.GroupBoxClientType.Controls.Add(this.RadioButtonSC1);
            this.GroupBoxClientType.Location = new System.Drawing.Point(19, 328);
            this.GroupBoxClientType.Name = "GroupBoxClientType";
            this.GroupBoxClientType.Size = new System.Drawing.Size(320, 53);
            this.GroupBoxClientType.TabIndex = 3;
            this.GroupBoxClientType.TabStop = false;
            this.GroupBoxClientType.Text = "Client Type";
            // 
            // GroupBoxStratumProtocol
            // 
            this.GroupBoxStratumProtocol.Controls.Add(this.CheckBoxRH);
            this.GroupBoxStratumProtocol.Controls.Add(this.RadioButtonSP2);
            this.GroupBoxStratumProtocol.Controls.Add(this.RadioButtonSP1);
            this.GroupBoxStratumProtocol.Controls.Add(this.RadioButtonSP0);
            this.GroupBoxStratumProtocol.Location = new System.Drawing.Point(19, 387);
            this.GroupBoxStratumProtocol.Name = "GroupBoxStratumProtocol";
            this.GroupBoxStratumProtocol.Size = new System.Drawing.Size(461, 73);
            this.GroupBoxStratumProtocol.TabIndex = 4;
            this.GroupBoxStratumProtocol.TabStop = false;
            this.GroupBoxStratumProtocol.Text = "Stratum Protocol";
            // 
            // CheckBoxRH
            // 
            this.CheckBoxRH.AutoSize = true;
            this.CheckBoxRH.Location = new System.Drawing.Point(176, 42);
            this.CheckBoxRH.Name = "CheckBoxRH";
            this.CheckBoxRH.Size = new System.Drawing.Size(141, 17);
            this.CheckBoxRH.TabIndex = 3;
            this.CheckBoxRH.Text = "Report Hashrate (-RH) ?";
            this.CheckBoxRH.UseVisualStyleBackColor = true;
            this.CheckBoxRH.CheckedChanged += new System.EventHandler(this.CheckBoxRH_CheckedChanged);
            // 
            // RadioButtonSP2
            // 
            this.RadioButtonSP2.AutoSize = true;
            this.RadioButtonSP2.Location = new System.Drawing.Point(311, 19);
            this.RadioButtonSP2.Name = "RadioButtonSP2";
            this.RadioButtonSP2.Size = new System.Drawing.Size(129, 17);
            this.RadioButtonSP2.TabIndex = 2;
            this.RadioButtonSP2.Text = "nicehash spec (-SP 2)";
            this.RadioButtonSP2.UseVisualStyleBackColor = true;
            this.RadioButtonSP2.CheckedChanged += new System.EventHandler(this.RadioButtonSP2_CheckedChanged);
            // 
            // RadioButtonSP1
            // 
            this.RadioButtonSP1.AutoSize = true;
            this.RadioButtonSP1.Location = new System.Drawing.Point(176, 19);
            this.RadioButtonSP1.Name = "RadioButtonSP1";
            this.RadioButtonSP1.Size = new System.Drawing.Size(129, 17);
            this.RadioButtonSP1.TabIndex = 1;
            this.RadioButtonSP1.Text = "eth-proxy spec (-SP 1)";
            this.RadioButtonSP1.UseVisualStyleBackColor = true;
            this.RadioButtonSP1.CheckedChanged += new System.EventHandler(this.RadioButtonSP1_CheckedChanged);
            // 
            // RadioButtonSP0
            // 
            this.RadioButtonSP0.AutoSize = true;
            this.RadioButtonSP0.Checked = true;
            this.RadioButtonSP0.Location = new System.Drawing.Point(6, 19);
            this.RadioButtonSP0.Name = "RadioButtonSP0";
            this.RadioButtonSP0.Size = new System.Drawing.Size(164, 17);
            this.RadioButtonSP0.TabIndex = 0;
            this.RadioButtonSP0.TabStop = true;
            this.RadioButtonSP0.Text = "official stratum/default (-SP 0)";
            this.RadioButtonSP0.UseVisualStyleBackColor = true;
            this.RadioButtonSP0.CheckedChanged += new System.EventHandler(this.RadioButtonSP0_CheckedChanged);
            // 
            // GroupBoxMisc
            // 
            this.GroupBoxMisc.Controls.Add(this.CheckBoxNoWarnings);
            this.GroupBoxMisc.Controls.Add(this.CheckBoxSaveOnExit);
            this.GroupBoxMisc.Controls.Add(this.CheckBoxCreateLog);
            this.GroupBoxMisc.Controls.Add(this.CheckBoxIdle);
            this.GroupBoxMisc.Controls.Add(this.label2);
            this.GroupBoxMisc.Controls.Add(this.TextBoxIdleMins);
            this.GroupBoxMisc.Controls.Add(this.TextBoxExtra);
            this.GroupBoxMisc.Controls.Add(this.label1);
            this.GroupBoxMisc.Controls.Add(this.CheckBoxExtra);
            this.GroupBoxMisc.Controls.Add(this.labelVerbosity);
            this.GroupBoxMisc.Controls.Add(this.ComboBoxVerbosity);
            this.GroupBoxMisc.Location = new System.Drawing.Point(19, 466);
            this.GroupBoxMisc.Name = "GroupBoxMisc";
            this.GroupBoxMisc.Size = new System.Drawing.Size(581, 93);
            this.GroupBoxMisc.TabIndex = 5;
            this.GroupBoxMisc.TabStop = false;
            this.GroupBoxMisc.Text = "Miscellaneous";
            // 
            // CheckBoxNoWarnings
            // 
            this.CheckBoxNoWarnings.AutoSize = true;
            this.CheckBoxNoWarnings.Location = new System.Drawing.Point(101, 70);
            this.CheckBoxNoWarnings.Name = "CheckBoxNoWarnings";
            this.CheckBoxNoWarnings.Size = new System.Drawing.Size(131, 17);
            this.CheckBoxNoWarnings.TabIndex = 23;
            this.CheckBoxNoWarnings.Text = "Warn Before Starting?";
            this.CheckBoxNoWarnings.UseVisualStyleBackColor = true;
            // 
            // CheckBoxSaveOnExit
            // 
            this.CheckBoxSaveOnExit.AutoSize = true;
            this.CheckBoxSaveOnExit.Location = new System.Drawing.Point(238, 70);
            this.CheckBoxSaveOnExit.Name = "CheckBoxSaveOnExit";
            this.CheckBoxSaveOnExit.Size = new System.Drawing.Size(168, 17);
            this.CheckBoxSaveOnExit.TabIndex = 21;
            this.CheckBoxSaveOnExit.Text = "Save Miscellanenous on Exit?";
            this.CheckBoxSaveOnExit.UseVisualStyleBackColor = true;
            // 
            // CheckBoxIdle
            // 
            this.CheckBoxIdle.AutoSize = true;
            this.CheckBoxIdle.Location = new System.Drawing.Point(327, 23);
            this.CheckBoxIdle.Name = "CheckBoxIdle";
            this.CheckBoxIdle.Size = new System.Drawing.Size(119, 17);
            this.CheckBoxIdle.TabIndex = 2;
            this.CheckBoxIdle.Text = "Mine only on IDLE?";
            this.CheckBoxIdle.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(483, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Delay (Minutes)";
            // 
            // TextBoxIdleMins
            // 
            this.TextBoxIdleMins.Location = new System.Drawing.Point(452, 20);
            this.TextBoxIdleMins.MaxLength = 2;
            this.TextBoxIdleMins.Name = "TextBoxIdleMins";
            this.TextBoxIdleMins.Size = new System.Drawing.Size(25, 20);
            this.TextBoxIdleMins.TabIndex = 5;
            // 
            // TextBoxExtra
            // 
            this.TextBoxExtra.Location = new System.Drawing.Point(113, 44);
            this.TextBoxExtra.MaxLength = 1024;
            this.TextBoxExtra.Name = "TextBoxExtra";
            this.TextBoxExtra.Size = new System.Drawing.Size(450, 20);
            this.TextBoxExtra.TabIndex = 7;
            this.TextBoxExtra.TextChanged += new System.EventHandler(this.TextBoxExtra_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 3;
            // 
            // CheckBoxExtra
            // 
            this.CheckBoxExtra.AutoSize = true;
            this.CheckBoxExtra.Location = new System.Drawing.Point(11, 46);
            this.CheckBoxExtra.Name = "CheckBoxExtra";
            this.CheckBoxExtra.Size = new System.Drawing.Size(103, 17);
            this.CheckBoxExtra.TabIndex = 6;
            this.CheckBoxExtra.Text = "Additional Flags:";
            this.CheckBoxExtra.UseVisualStyleBackColor = true;
            this.CheckBoxExtra.CheckedChanged += new System.EventHandler(this.CheckBoxExtra_CheckedChanged);
            // 
            // labelVerbosity
            // 
            this.labelVerbosity.AutoSize = true;
            this.labelVerbosity.Location = new System.Drawing.Point(48, 23);
            this.labelVerbosity.Name = "labelVerbosity";
            this.labelVerbosity.Size = new System.Drawing.Size(50, 13);
            this.labelVerbosity.TabIndex = 1;
            this.labelVerbosity.Text = "Verbosity";
            // 
            // ComboBoxVerbosity
            // 
            this.ComboBoxVerbosity.FormattingEnabled = true;
            this.ComboBoxVerbosity.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.ComboBoxVerbosity.Location = new System.Drawing.Point(12, 20);
            this.ComboBoxVerbosity.Name = "ComboBoxVerbosity";
            this.ComboBoxVerbosity.Size = new System.Drawing.Size(30, 21);
            this.ComboBoxVerbosity.TabIndex = 0;
            this.ComboBoxVerbosity.Text = "8";
            this.ComboBoxVerbosity.SelectedIndexChanged += new System.EventHandler(this.ComboBoxVerbosity_SelectedIndexChanged);
            // 
            // LCurrentCommand
            // 
            this.LCurrentCommand.AutoSize = true;
            this.LCurrentCommand.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCurrentCommand.Location = new System.Drawing.Point(6, 584);
            this.LCurrentCommand.Name = "LCurrentCommand";
            this.LCurrentCommand.Size = new System.Drawing.Size(79, 13);
            this.LCurrentCommand.TabIndex = 0;
            this.LCurrentCommand.Text = "ethminer.exe";
            // 
            // TextBoxProfileSaveName
            // 
            this.TextBoxProfileSaveName.Location = new System.Drawing.Point(6, 19);
            this.TextBoxProfileSaveName.MaxLength = 24;
            this.TextBoxProfileSaveName.Name = "TextBoxProfileSaveName";
            this.TextBoxProfileSaveName.Size = new System.Drawing.Size(137, 20);
            this.TextBoxProfileSaveName.TabIndex = 0;
            // 
            // ButtonSaveProfileName
            // 
            this.ButtonSaveProfileName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSaveProfileName.Location = new System.Drawing.Point(149, 14);
            this.ButtonSaveProfileName.Name = "ButtonSaveProfileName";
            this.ButtonSaveProfileName.Size = new System.Drawing.Size(53, 25);
            this.ButtonSaveProfileName.TabIndex = 1;
            this.ButtonSaveProfileName.Text = "Save";
            this.ButtonSaveProfileName.UseVisualStyleBackColor = true;
            this.ButtonSaveProfileName.Click += new System.EventHandler(this.ButtonSaveProfileName_Click);
            // 
            // GroupBoxProfileSave
            // 
            this.GroupBoxProfileSave.Controls.Add(this.LabelCommand);
            this.GroupBoxProfileSave.Controls.Add(this.LabelProfileNameLoaded);
            this.GroupBoxProfileSave.Controls.Add(this.ButtonCancelProfileName);
            this.GroupBoxProfileSave.Controls.Add(this.ButtonSaveProfileName);
            this.GroupBoxProfileSave.Controls.Add(this.TextBoxProfileSaveName);
            this.GroupBoxProfileSave.Location = new System.Drawing.Point(610, 493);
            this.GroupBoxProfileSave.Name = "GroupBoxProfileSave";
            this.GroupBoxProfileSave.Size = new System.Drawing.Size(208, 81);
            this.GroupBoxProfileSave.TabIndex = 18;
            this.GroupBoxProfileSave.TabStop = false;
            this.GroupBoxProfileSave.Text = "Profile Name";
            // 
            // LabelCommand
            // 
            this.LabelCommand.AutoSize = true;
            this.LabelCommand.Location = new System.Drawing.Point(3, 45);
            this.LabelCommand.Name = "LabelCommand";
            this.LabelCommand.Size = new System.Drawing.Size(113, 13);
            this.LabelCommand.TabIndex = 21;
            this.LabelCommand.Text = "Current profile loaded: ";
            // 
            // LabelProfileNameLoaded
            // 
            this.LabelProfileNameLoaded.AutoSize = true;
            this.LabelProfileNameLoaded.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelProfileNameLoaded.Location = new System.Drawing.Point(1, 60);
            this.LabelProfileNameLoaded.Name = "LabelProfileNameLoaded";
            this.LabelProfileNameLoaded.Size = new System.Drawing.Size(43, 15);
            this.LabelProfileNameLoaded.TabIndex = 20;
            this.LabelProfileNameLoaded.Text = "(none)";
            // 
            // ButtonCancelProfileName
            // 
            this.ButtonCancelProfileName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonCancelProfileName.Location = new System.Drawing.Point(149, 45);
            this.ButtonCancelProfileName.Name = "ButtonCancelProfileName";
            this.ButtonCancelProfileName.Size = new System.Drawing.Size(53, 25);
            this.ButtonCancelProfileName.TabIndex = 2;
            this.ButtonCancelProfileName.Text = "Cancel";
            this.ButtonCancelProfileName.UseVisualStyleBackColor = true;
            this.ButtonCancelProfileName.Click += new System.EventHandler(this.ButtonCancelProfileName_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbel", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 562);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Hover mouse for full command:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 617);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.GroupBoxProfileSave);
            this.Controls.Add(this.LCurrentCommand);
            this.Controls.Add(this.GroupBoxMisc);
            this.Controls.Add(this.GroupBoxStratumProtocol);
            this.Controls.Add(this.GroupBoxClientType);
            this.Controls.Add(this.groupBoxGPU);
            this.Controls.Add(this.GroupBoxPools);
            this.Controls.Add(this.GroupBoxWatchDog);
            this.Controls.Add(this.GroupBoxSimulation);
            this.Controls.Add(this.GroupBoxBenchmark);
            this.Controls.Add(this.Worktype);
            this.Controls.Add(this.ButtonLoadProfile);
            this.Controls.Add(this.checkBoxSave);
            this.Controls.Add(this.ButtonStartMining);
            this.Controls.Add(this.ButtonRemoveProfile);
            this.Controls.Add(this.ButtonAddProfile);
            this.Controls.Add(this.labelProfiles);
            this.Controls.Add(this.ListBoxProfiles);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "ethminerGUI";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.Worktype.ResumeLayout(false);
            this.Worktype.PerformLayout();
            this.GroupBoxBenchmark.ResumeLayout(false);
            this.GroupBoxBenchmark.PerformLayout();
            this.GroupBoxSimulation.ResumeLayout(false);
            this.GroupBoxSimulation.PerformLayout();
            this.GroupBoxWatchDog.ResumeLayout(false);
            this.GroupBoxWatchDog.PerformLayout();
            this.GroupBoxPools.ResumeLayout(false);
            this.GroupBoxPools.PerformLayout();
            this.groupBoxGPU.ResumeLayout(false);
            this.groupBoxGPU.PerformLayout();
            this.GroupBoxClientType.ResumeLayout(false);
            this.GroupBoxClientType.PerformLayout();
            this.GroupBoxStratumProtocol.ResumeLayout(false);
            this.GroupBoxStratumProtocol.PerformLayout();
            this.GroupBoxMisc.ResumeLayout(false);
            this.GroupBoxMisc.PerformLayout();
            this.GroupBoxProfileSave.ResumeLayout(false);
            this.GroupBoxProfileSave.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.TextBox TextBoxAccount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button ButtonRemoveProfile;
        private System.Windows.Forms.Button ButtonAddProfile;
        private System.Windows.Forms.Label labelProfiles;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TextBoxPool1;
        private System.Windows.Forms.CheckBox enableWatchdog;
        private System.Windows.Forms.TextBox watchdogtimeout;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TextBoxPool2;
        private System.Windows.Forms.CheckBox EnableBenchmark;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox benchmarkseconds;
        private System.Windows.Forms.TextBox benchmarktrialsecs;
        private System.Windows.Forms.TextBox benchmarktrials;
        private System.Windows.Forms.CheckBox EnableSimulation;
        private System.Windows.Forms.TextBox TextBoxSimblock;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button ButtonStartMining;
        private System.Windows.Forms.CheckBox checkBoxSave;
        private System.Windows.Forms.Button ButtonLoadProfile;
        private System.Windows.Forms.GroupBox Worktype;
        private System.Windows.Forms.RadioButton RadioStratumMode;
        private System.Windows.Forms.RadioButton RadioFarmMode;
        public System.Windows.Forms.ListBox ListBoxProfiles;
        private System.Windows.Forms.GroupBox GroupBoxBenchmark;
        private System.Windows.Forms.GroupBox GroupBoxSimulation;
        private System.Windows.Forms.GroupBox GroupBoxWatchDog;
        private System.Windows.Forms.GroupBox GroupBoxPools;
        private System.Windows.Forms.GroupBox groupBoxGPU;
        private System.Windows.Forms.RadioButton RadioButtonMixedCards;
        private System.Windows.Forms.CheckBox CheckBoxHWMON;
        private System.Windows.Forms.RadioButton RadioButtonOpenCL;
        private System.Windows.Forms.RadioButton RadioButtonCUDA;
        private System.Windows.Forms.TextBox TextBoxWorker;
        private System.Windows.Forms.Label LabelWorker;
        private System.Windows.Forms.TextBox TextBoxEmail;
        private System.Windows.Forms.Label LabelEmail;
        private System.Windows.Forms.RadioButton RadioButtonSC1;
        private System.Windows.Forms.RadioButton RadioButtonSC2;
        private System.Windows.Forms.GroupBox GroupBoxClientType;
        private System.Windows.Forms.GroupBox GroupBoxStratumProtocol;
        private System.Windows.Forms.RadioButton RadioButtonSP0;
        private System.Windows.Forms.RadioButton RadioButtonSP1;
        private System.Windows.Forms.RadioButton RadioButtonSP2;
        private System.Windows.Forms.TextBox TextBoxRecheck;
        private System.Windows.Forms.Label labelRecheck;
        private System.Windows.Forms.CheckBox CheckBoxRH;
        private System.Windows.Forms.GroupBox GroupBoxMisc;
        private System.Windows.Forms.Label labelVerbosity;
        private System.Windows.Forms.ComboBox ComboBoxVerbosity;
        private System.Windows.Forms.TextBox TextBoxExtra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox CheckBoxExtra;
        private System.Windows.Forms.CheckBox CheckBoxIdle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBoxIdleMins;
        private System.Windows.Forms.Label LCurrentCommand;
        private System.Windows.Forms.ToolTip ToolTipEGUI;
        private System.Windows.Forms.TextBox TextBoxProfileSaveName;
        private System.Windows.Forms.Button ButtonSaveProfileName;
        private System.Windows.Forms.GroupBox GroupBoxProfileSave;
        private System.Windows.Forms.Button ButtonCancelProfileName;
        private System.Windows.Forms.Label LabelProfileNameLoaded;
        private System.Windows.Forms.TextBox TextBoxPoolPort2;
        private System.Windows.Forms.TextBox TextBoxPoolPort1;
        private System.Windows.Forms.CheckBox CheckBoxCreateLog;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editProfilesXMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ETHMINERHelpFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setEthminerexeLocationToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem saveEXEConfigToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setDefaultsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.CheckBox CheckBoxSaveOnExit;
        private System.Windows.Forms.ToolStripMenuItem defaultMISCSettingsToolStripMenuItem;
        private System.Windows.Forms.Label LabelCommand;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox CheckBoxNoWarnings;
    }
}

