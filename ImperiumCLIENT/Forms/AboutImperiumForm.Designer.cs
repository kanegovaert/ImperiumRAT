namespace ImperiumCLIENT.Forms
{
    partial class AboutImperiumForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutImperiumForm));
            this.PB_ImperiumAboutPicture = new System.Windows.Forms.PictureBox();
            this.ImageWorker = new System.ComponentModel.BackgroundWorker();
            this.LBL_Version = new System.Windows.Forms.Label();
            this.LBL_AProjectBy = new System.Windows.Forms.Label();
            this.LBL_GithubKaneke = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.PB_ImperiumAboutPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // PB_ImperiumAboutPicture
            // 
            this.PB_ImperiumAboutPicture.Image = ((System.Drawing.Image)(resources.GetObject("PB_ImperiumAboutPicture.Image")));
            this.PB_ImperiumAboutPicture.Location = new System.Drawing.Point(57, 2);
            this.PB_ImperiumAboutPicture.Name = "PB_ImperiumAboutPicture";
            this.PB_ImperiumAboutPicture.Size = new System.Drawing.Size(473, 433);
            this.PB_ImperiumAboutPicture.TabIndex = 0;
            this.PB_ImperiumAboutPicture.TabStop = false;
            // 
            // ImageWorker
            // 
            this.ImageWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.ImageWorker_DoWork);
            // 
            // LBL_Version
            // 
            this.LBL_Version.AutoSize = true;
            this.LBL_Version.BackColor = System.Drawing.SystemColors.Control;
            this.LBL_Version.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.LBL_Version.Location = new System.Drawing.Point(12, 438);
            this.LBL_Version.Name = "LBL_Version";
            this.LBL_Version.Size = new System.Drawing.Size(93, 17);
            this.LBL_Version.TabIndex = 1;
            this.LBL_Version.Text = "%VERSION%";
            // 
            // LBL_AProjectBy
            // 
            this.LBL_AProjectBy.AutoSize = true;
            this.LBL_AProjectBy.Location = new System.Drawing.Point(173, 438);
            this.LBL_AProjectBy.Name = "LBL_AProjectBy";
            this.LBL_AProjectBy.Size = new System.Drawing.Size(87, 17);
            this.LBL_AProjectBy.TabIndex = 2;
            this.LBL_AProjectBy.Text = "A project by:";
            // 
            // LBL_GithubKaneke
            // 
            this.LBL_GithubKaneke.AutoSize = true;
            this.LBL_GithubKaneke.Location = new System.Drawing.Point(266, 438);
            this.LBL_GithubKaneke.Name = "LBL_GithubKaneke";
            this.LBL_GithubKaneke.Size = new System.Drawing.Size(132, 17);
            this.LBL_GithubKaneke.TabIndex = 3;
            this.LBL_GithubKaneke.TabStop = true;
            this.LBL_GithubKaneke.Text = "Github.com/Kaneke";
            this.LBL_GithubKaneke.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LBL_GithubKaneke_LinkClicked);
            // 
            // AboutImperiumForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 464);
            this.Controls.Add(this.LBL_GithubKaneke);
            this.Controls.Add(this.LBL_AProjectBy);
            this.Controls.Add(this.LBL_Version);
            this.Controls.Add(this.PB_ImperiumAboutPicture);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(553, 456);
            this.Name = "AboutImperiumForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "About";
            this.Load += new System.EventHandler(this.AboutImperiumForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PB_ImperiumAboutPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PB_ImperiumAboutPicture;
        private System.ComponentModel.BackgroundWorker ImageWorker;
        private System.Windows.Forms.Label LBL_Version;
        private System.Windows.Forms.Label LBL_AProjectBy;
        private System.Windows.Forms.LinkLabel LBL_GithubKaneke;
    }
}