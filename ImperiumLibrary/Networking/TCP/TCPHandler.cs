using System.Net;
using System.Threading;
using System.Net.Sockets;

namespace ImperiumLibrary.Networking.TCP
{
    public class TCPListenerHandler
    {
        public static TcpListener Listener;
        public static void StartListening(string IPOrHostname, int Port)
        {
            Thread TCPThread = new Thread(unused => AwaitConnection(Port));
            TCPThread.Start();
        }
        public static void AwaitConnection(int Port)
        {
            while (true)
            {
                Listener = new TcpListener(IPAddress.Any, Port);
                Listener.Start();
                Listener.AcceptSocket();
                Thread.Sleep(10);
            }
        }
    }
}
