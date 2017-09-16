using System;
using System.Net;
using System.Windows.Forms;
using ImperiumLibrary.Networking.TCP;
using ImperiumLibrary.Miscellenious.EnableSettings;
using ImperiumLibrary.Miscellenious.GlobalVariables;

namespace ImperiumCLIENT.Forms
{
    public partial class ImperiumSettingsForm : Form
    {

        #region Variables
        private bool ChangeListenStatus;
        private bool IsListening = GVars.IsListening;
        #endregion

        public ImperiumSettingsForm()
        {
            InitializeComponent();
        }

        private void BTN_Cancel_Click(object sender, EventArgs e)
        {
            ChangeListenStatus = false;
            Close();
        }

        private void BTN_StartListening_Click(object sender, EventArgs e)
        {
            ChangeListenStatus = true;
            IsListening = !IsListening;
            ChangeListeningButtonTextDependingOnListeningStatus(IsListening);
            SettingsHandler.Handle();
        }

        private void ChangeListeningStatus()
        {
             GVars.IsListening = !GVars.IsListening;
            TCPListenerHandler.StartListening(Convert.ToString(IPAddress.Any), Convert.ToInt32(NUD_PortToListenOn.Value));
            ChangeListeningButtonTextDependingOnListeningStatus(GVars.IsListening);
        }

        private void ChangeListeningButtonTextDependingOnListeningStatus(bool IsListening)
        {
            if (IsListening)
            {
                BTN_StartListening.Text = "Stop Listening";
            }
            else
            {
                BTN_StartListening.Text = "Start Listening";
            }
        }

        private void BTN_Save_Click(object sender, EventArgs e)
        {
            if (ChangeListenStatus)
            {
                ChangeListeningStatus();
            }
            GVars.Port = Convert.ToInt32(NUD_PortToListenOn.Value);
            GVars.EnableUPnP = CB_TryToAutomaticallyPortForward.Checked;
            System.Threading.Thread EnableAllSettings = new System.Threading.Thread(new System.Threading.ThreadStart(SettingsHandler.Handle));

            Close();
        }

        private void ImperiumSettingsForm_Load(object sender, EventArgs e)
        {
            ChangeListeningButtonTextDependingOnListeningStatus(GVars.IsListening);
            CB_TryToAutomaticallyPortForward.Checked = GVars.EnableUPnP;
            NUD_PortToListenOn.Value = GVars.Port;
        }
    }
}
