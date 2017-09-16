using System.Net;
using System.Net.Sockets;

namespace ImperiumSTUB
{
    public static class Variables
    {
        public static int Port;
        public static IPAddress IPAddress = null;
        public static TcpClient TCPClient;
        public static string ConnectTo;
    }
}
