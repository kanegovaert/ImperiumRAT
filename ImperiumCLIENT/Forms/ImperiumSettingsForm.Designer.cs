namespace ImperiumCLIENT.Forms
{
    partial class ImperiumSettingsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.NUD_PortToListenOn = new System.Windows.Forms.NumericUpDown();
            this.BTN_StartListening = new System.Windows.Forms.Button();
            this.CB_ListenForNewConnectionsOnStartup = new System.Windows.Forms.CheckBox();
            this.CB_TryToAutomaticallyPortForward = new System.Windows.Forms.CheckBox();
            this.CB_ShowPopUpOnNewConnection = new System.Windows.Forms.CheckBox();
            this.LBL_Password = new System.Windows.Forms.Label();
            this.TB_Password = new System.Windows.Forms.TextBox();
            this.BTN_Save = new System.Windows.Forms.Button();
            this.BTN_Cancel = new System.Windows.Forms.Button();
            this.CB_EnableIPv6Support = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_PortToListenOn)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Port to listen on:";
            // 
            // NUD_PortToListenOn
            // 
            this.NUD_PortToListenOn.Location = new System.Drawing.Point(130, 13);
            this.NUD_PortToListenOn.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.NUD_PortToListenOn.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUD_PortToListenOn.Name = "NUD_PortToListenOn";
            this.NUD_PortToListenOn.Size = new System.Drawing.Size(89, 22);
            this.NUD_PortToListenOn.TabIndex = 1;
            this.NUD_PortToListenOn.Value = new decimal(new int[] {
            4768,
            0,
            0,
            0});
            // 
            // BTN_StartListening
            // 
            this.BTN_StartListening.Location = new System.Drawing.Point(225, 10);
            this.BTN_StartListening.Name = "BTN_StartListening";
            this.BTN_StartListening.Size = new System.Drawing.Size(144, 31);
            this.BTN_StartListening.TabIndex = 2;
            this.BTN_StartListening.Text = "Start listening";
            this.BTN_StartListening.UseVisualStyleBackColor = true;
            this.BTN_StartListening.Click += new System.EventHandler(this.BTN_StartListening_Click);
            // 
            // CB_ListenForNewConnectionsOnStartup
            // 
            this.CB_ListenForNewConnectionsOnStartup.AutoSize = true;
            this.CB_ListenForNewConnectionsOnStartup.Location = new System.Drawing.Point(16, 126);
            this.CB_ListenForNewConnectionsOnStartup.Name = "CB_ListenForNewConnectionsOnStartup";
            this.CB_ListenForNewConnectionsOnStartup.Size = new System.Drawing.Size(266, 21);
            this.CB_ListenForNewConnectionsOnStartup.TabIndex = 4;
            this.CB_ListenForNewConnectionsOnStartup.Text = "Listen for new connections on startup";
            this.CB_ListenForNewConnectionsOnStartup.UseVisualStyleBackColor = true;
            // 
            // CB_TryToAutomaticallyPortForward
            // 
            this.CB_TryToAutomaticallyPortForward.AutoSize = true;
            this.CB_TryToAutomaticallyPortForward.Location = new System.Drawing.Point(16, 153);
            this.CB_TryToAutomaticallyPortForward.Name = "CB_TryToAutomaticallyPortForward";
            this.CB_TryToAutomaticallyPortForward.Size = new System.Drawing.Size(279, 21);
            this.CB_TryToAutomaticallyPortForward.TabIndex = 5;
            this.CB_TryToAutomaticallyPortForward.Text = "Try to automatically portforward (UPnP)";
            this.CB_TryToAutomaticallyPortForward.UseVisualStyleBackColor = true;
            // 
            // CB_ShowPopUpOnNewConnection
            // 
            this.CB_ShowPopUpOnNewConnection.AutoSize = true;
            this.CB_ShowPopUpOnNewConnection.Location = new System.Drawing.Point(16, 180);
            this.CB_ShowPopUpOnNewConnection.Name = "CB_ShowPopUpOnNewConnection";
            this.CB_ShowPopUpOnNewConnection.Size = new System.Drawing.Size(314, 21);
            this.CB_ShowPopUpOnNewConnection.TabIndex = 6;
            this.CB_ShowPopUpOnNewConnection.Text = "Show popup notification on a new connection";
            this.CB_ShowPopUpOnNewConnection.UseVisualStyleBackColor = true;
            // 
            // LBL_Password
            // 
            this.LBL_Password.AutoSize = true;
            this.LBL_Password.Location = new System.Drawing.Point(13, 49);
            this.LBL_Password.Name = "LBL_Password";
            this.LBL_Password.Size = new System.Drawing.Size(73, 17);
            this.LBL_Password.TabIndex = 7;
            this.LBL_Password.Text = "Password:";
            // 
            // TB_Password
            // 
            this.TB_Password.Location = new System.Drawing.Point(130, 47);
            this.TB_Password.Name = "TB_Password";
            this.TB_Password.Size = new System.Drawing.Size(239, 22);
            this.TB_Password.TabIndex = 8;
            this.TB_Password.Text = "password123";
            this.TB_Password.UseSystemPasswordChar = true;
            // 
            // BTN_Save
            // 
            this.BTN_Save.Location = new System.Drawing.Point(249, 365);
            this.BTN_Save.Name = "BTN_Save";
            this.BTN_Save.Size = new System.Drawing.Size(120, 28);
            this.BTN_Save.TabIndex = 9;
            this.BTN_Save.Text = "Save";
            this.BTN_Save.UseVisualStyleBackColor = true;
            this.BTN_Save.Click += new System.EventHandler(this.BTN_Save_Click);
            // 
            // BTN_Cancel
            // 
            this.BTN_Cancel.Location = new System.Drawing.Point(123, 365);
            this.BTN_Cancel.Name = "BTN_Cancel";
            this.BTN_Cancel.Size = new System.Drawing.Size(120, 28);
            this.BTN_Cancel.TabIndex = 10;
            this.BTN_Cancel.Text = "Cancel";
            this.BTN_Cancel.UseVisualStyleBackColor = true;
            this.BTN_Cancel.Click += new System.EventHandler(this.BTN_Cancel_Click);
            // 
            // CB_EnableIPv6Support
            // 
            this.CB_EnableIPv6Support.AutoSize = true;
            this.CB_EnableIPv6Support.Location = new System.Drawing.Point(16, 99);
            this.CB_EnableIPv6Support.Name = "CB_EnableIPv6Support";
            this.CB_EnableIPv6Support.Size = new System.Drawing.Size(157, 21);
            this.CB_EnableIPv6Support.TabIndex = 3;
            this.CB_EnableIPv6Support.Text = "Enable IPv6 support";
            this.CB_EnableIPv6Support.UseVisualStyleBackColor = true;
            // 
            // ImperiumSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 405);
            this.Controls.Add(this.BTN_Cancel);
            this.Controls.Add(this.BTN_Save);
            this.Controls.Add(this.TB_Password);
            this.Controls.Add(this.LBL_Password);
            this.Controls.Add(this.CB_ShowPopUpOnNewConnection);
            this.Controls.Add(this.CB_TryToAutomaticallyPortForward);
            this.Controls.Add(this.CB_ListenForNewConnectionsOnStartup);
            this.Controls.Add(this.CB_EnableIPv6Support);
            this.Controls.Add(this.BTN_StartListening);
            this.Controls.Add(this.NUD_PortToListenOn);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(399, 452);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(399, 452);
            this.Name = "ImperiumSettingsForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.ImperiumSettingsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NUD_PortToListenOn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown NUD_PortToListenOn;
        private System.Windows.Forms.Button BTN_StartListening;
        private System.Windows.Forms.CheckBox CB_ListenForNewConnectionsOnStartup;
        private System.Windows.Forms.CheckBox CB_TryToAutomaticallyPortForward;
        private System.Windows.Forms.CheckBox CB_ShowPopUpOnNewConnection;
        private System.Windows.Forms.Label LBL_Password;
        private System.Windows.Forms.TextBox TB_Password;
        private System.Windows.Forms.Button BTN_Save;
        private System.Windows.Forms.Button BTN_Cancel;
        private System.Windows.Forms.CheckBox CB_EnableIPv6Support;
    }
}