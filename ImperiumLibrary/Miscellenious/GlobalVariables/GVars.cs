using System.Net;
using System.Collections.Generic;

namespace ImperiumLibrary.Miscellenious.GlobalVariables
{
    public static class GVars
    {
        public static bool IsListening = false;
        public static int Port = 473;
        public static bool EnableUPnP;
        public static IPAddress IP = IPAddress.Any;
    }
}
