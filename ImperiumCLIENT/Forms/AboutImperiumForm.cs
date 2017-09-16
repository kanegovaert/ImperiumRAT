using System;
using System.ComponentModel;

using System.Windows.Forms;

namespace ImperiumCLIENT.Forms
{
    public partial class AboutImperiumForm : Form
    {
        private delegate void DELEGATE();

        string Version = "1.0";
        public AboutImperiumForm()
        {
            InitializeComponent();
        }

        private void AboutImperiumForm_Load(object sender, EventArgs e)
        {
            LBL_Version.Text = Version;
            ImageWorker.RunWorkerAsync();
        }

        private void ImageWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                try
                {

                System.Threading.Thread.Sleep(1000);
                Delegate ChangeVisibleStatus = new DELEGATE(ChangeImageVisibility);
                Invoke(ChangeVisibleStatus);
                }
                catch (Exception)
                {

                }
            }
        }

        private void ChangeImageVisibility()
        {
            PB_ImperiumAboutPicture.Visible = !PB_ImperiumAboutPicture.Visible;
        }

        private void LBL_GithubKaneke_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.github.com/Kaneke/");
        }
    }
}
