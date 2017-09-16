using System.Net;
using System.Net.Sockets;
using ImperiumLibrary.Networking.UPnP;
using System;
using ImperiumLibrary.Miscellenious.GlobalVariables;

namespace ImperiumLibrary.Miscellenious.EnableSettings
{
    public static class SettingsHandler
    {
        public static void Handle()
        {
            if (GlobalVariables.GVars.EnableUPnP)
            {
               UPnPHandler.AddPortForward(GVars.Port, Convert.ToString(GVars.IP));
            }
        }
    }
}
