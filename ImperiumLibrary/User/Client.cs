using System;
using Newtonsoft.Json;
using System.Net;
using System.IO;

namespace ImperiumLibrary.User
{
    class Client
    {
        string IP;
        string OnlineStatus;
        string Username;
        string OS;
        
        void GetCountry(string IP)
        {
            WebClient wc = new System.Net.WebClient();
            Stream stream = wc.OpenRead("http://geoip.nekudo.com/api/" + IP);
            StreamReader reader = new StreamReader(stream);

            Newtonsoft.Json.Linq.JObject jObject = Newtonsoft.Json.Linq.JObject.Parse(reader.ReadLine());

            Console.WriteLine((string)jObject["ip"][0]["country"]);
            stream.Close();
        }
    }
}
