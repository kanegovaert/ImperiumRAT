using System;
using System.Collections.Generic;
using ImperiumLibrary.Generate;
using System.Windows.Forms;

namespace ImperiumCLIENT.Forms
{
    public partial class BuilderForm : Form
    {
        public BuilderForm()
        {
            InitializeComponent();
        }

        private void BuilderForm_Load(object sender, EventArgs e)
        {
            RB_UserAppData.Checked = true;
            TB_RandomMutex.Text = GenerateMutex.GenerateRandomMutex();
        }

        private void BTN_RandomMutexGenerator_Click(object sender, EventArgs e)
        {
            TB_RandomMutex.Text = GenerateMutex.GenerateRandomMutex();
        }

        private void TSMI_Remove_Click(object sender, EventArgs e)
        {
            {
                int SelectedIndex = LB_ConnectionHosts.SelectedIndex;
                LB_ConnectionHosts.Items.Remove(SelectedIndex);

            }
        }

        private void TMSI_Clear_Click(object sender, EventArgs e)
        {
            LB_ConnectionHosts.Items.Clear();
        }

        private void BTN_AddHost_Click(object sender, EventArgs e)
        {
            LB_ConnectionHosts.Items.Add(TB_IPHostname.Text + ":" + Convert.ToString(NUD_Port.Value));
        }

        private void LB_ConnectionHosts_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var Index = LB_ConnectionHosts.IndexFromPoint(e.Location);
                if (Index >= 0 && LB_ConnectionHosts.GetItemRectangle(Index).Contains(e.Location))
                {
                    LB_ConnectionHosts.SelectedIndex = Index;
                    CMS_LB_ConnectionHosts.Show(LB_ConnectionHosts, e.Location);
                }
            }
        }

        private void CB_ShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (CB_ShowPassword.Checked)
            {
                TB_EncryptedPassword.UseSystemPasswordChar = false;
            }
            else
            {
                TB_EncryptedPassword.UseSystemPasswordChar = true;
            }
        }

        private void CB_InstallClient_CheckedChanged(object sender, EventArgs e)
        {
            if (CB_InstallClient.Checked)
            {
                RB_ProgramFiles.Enabled = true;
                RB_System.Enabled = true;
                RB_UserAppData.Enabled = true;
                TB_SubDirectory.Enabled = true;
                TB_Name.Enabled = true;
                CB_SetSubDirectoryToHidden.Enabled = true;
                CB_SetFileAttributeHidden.Enabled = true;
            } else
            {
                RB_ProgramFiles.Enabled = false;
                RB_System.Enabled = false;
                RB_UserAppData.Enabled = false;
                TB_SubDirectory.Enabled = false;
                TB_Name.Enabled = false;
                CB_SetSubDirectoryToHidden.Enabled = false;
                CB_SetFileAttributeHidden.Enabled = false;
            }
        }
    }
}
