using System;

namespace GLS
{
    public class Datacenter
    {
        public String Name { get; set; }
        public World[] Worlds { get; set; }
        public String AuthServer { get; set; }
        public String PatchServer { get; set; }
        public String LauncherConfigurationServer { get; set; }
    }
}