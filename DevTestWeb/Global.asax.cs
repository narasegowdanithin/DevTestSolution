using System;
using System.Configuration;
using System.IO;
using System.Runtime.Remoting;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;

namespace Wescale.DevTestWeb {

    public class Global : HttpApplication {

        void Application_Start(object sender, EventArgs e) {
            // Code, der beim Anwendungsstart ausgeführt wird
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            // Remoting konfigurieren
            try {
                string filename = Path.Combine(HttpRuntime.AppDomainAppPath, "RemotingClient.config");
                RemotingConfiguration.Configure(filename, false);
            } catch (Exception ex) {
                throw new ConfigurationErrorsException("Cannot initialize remoting", ex);
            }
        }

    }
}