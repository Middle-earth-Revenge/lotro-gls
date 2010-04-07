using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace GLS
{
    /// <summary>
    /// Provies front end clients with a description of the services that comprise a game
    /// </summary>
    [WebService(Namespace = "http://www.turbine.com/SE/GLS", Description = "Provies front end clients with a description of the services that comprise a game", Name = "GLS Datacenter Info Server")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    public class Service : System.Web.Services.WebService
    {

        [WebMethod(Description = "Returns a description of the services related to a particular game. An array of datacenter structures will be returned that contain information about game worlds and services related to them ( chat servers, patch servers, etc. ). This information can be used to find the access points necessary to access all game related services.")]
        public Datacenter[] GetDatacenters(String game)
        {
            World world = new World();
            world.Name = "[XY] My Own";
            world.LoginServerUrl = "(invalid service specified)";
            world.ChatServerUrl = "192.168.1.145:2900"; // Change this
            world.StatusServerUrl = "http://lotroeugls.com/status/cache_myown.xml";
            world.Order = 0;

            Datacenter datacenter = new Datacenter();
            datacenter = new Datacenter();
            datacenter.Name = "LOTROEU";
            datacenter.AuthServer = "http://lotroeugls.com/GLS.AuthServer/Service.asmx";
            datacenter.PatchServer = "94.75.194.24:5015";
            datacenter.LauncherConfigurationServer = "http://lotroeugls.com/Launcher/lotrolauncher.server.config.xml";
            datacenter.Worlds = new World[] { world };

            return new Datacenter[] { datacenter };
        }
    }
}