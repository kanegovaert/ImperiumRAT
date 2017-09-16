using NATUPNPLib;

namespace ImperiumLibrary.Networking.UPnP
{
    public static class UPnPHandler
    {
           public static UPnPNAT UPnPNAT = new UPnPNAT();
           public static IStaticPortMappingCollection MappingCollection = UPnPNAT.StaticPortMappingCollection;
        public static void AddPortForward(int Port, string IP)
        {
            MappingCollection.Add(Port, "TCP", Port, IP, true, "Imperium Remote Administration Tool");
        }
        public static void RemovePortForward(int Port)
        {
            MappingCollection.Remove(Port, "TCP");
        }
    }
}
