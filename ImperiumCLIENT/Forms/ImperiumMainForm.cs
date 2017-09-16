using System;
using System.Net;
using System.Threading;
using System.Windows.Forms;
using ImperiumLibrary.Networking.TCP;
using ImperiumLibrary.Miscellenious.GlobalVariables;

namespace ImperiumCLIENT
{
    public partial class ImperiumMainForm : Form
    {
        public ImperiumMainForm()
        {
            InitializeComponent();
        }

        private delegate void DELEGATE();

        private void ChangeLabel()
        {

                if (GVars.IsListening)
                {
                    LBL_ListeningStatus.Text = "Listening: true";
                }
                else
                {
                    LBL_ListeningStatus.Text = "Listening: false";
                }
        }

        private void MI_Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MI_Settings_Click(object sender, EventArgs e)
        {
            Forms.ImperiumSettingsForm _ISF = new Forms.ImperiumSettingsForm();
            _ISF.Show();
        }

        private void MI_About_Click(object sender, EventArgs e)
        {
            Forms.AboutImperiumForm _AIF = new Forms.AboutImperiumForm();
            _AIF.Show();
        }

        private void MI_Builder_Click(object sender, EventArgs e)
        {
            Forms.BuilderForm _BF = new Forms.BuilderForm();
            _BF.Show();
        }

        private void TSMI_Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TSMI_Settings_Click(object sender, EventArgs e)
        {
            Forms.ImperiumSettingsForm _ISF = new Forms.ImperiumSettingsForm();
            _ISF.Show();
        }

        private void TSMI_Builder_Click(object sender, EventArgs e)
        {
            Forms.BuilderForm _BF = new Forms.BuilderForm();
            _BF.Show();
        }

        private void TSMI_About_Click(object sender, EventArgs e)
        {
            Forms.AboutImperiumForm _AIF = new Forms.AboutImperiumForm();
            _AIF.Show();
        }

        private void ImperiumMainForm_Load(object sender, EventArgs e)
        {
            CheckIfStillListeningWorker.RunWorkerAsync();
        }

        private void CheckIfStillListeningWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            while (true)
            {
                try
                {

                Delegate ChangeTheLabel = new DELEGATE(ChangeLabel);
                Invoke(ChangeTheLabel);
                Thread.Sleep(1000);
                }
                catch (Exception)
                {
                }
            }
        }
    }
}
