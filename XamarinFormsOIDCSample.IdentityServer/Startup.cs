using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using IdentityServer3.Core.Configuration;
using Owin;
using XamarinFormsOIDCSample.IdentityServer.Config;

namespace XamarinFormsOIDCSample.IdentityServer
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {

            app.Map("/identity", idsrvApp =>
            {
                var idServerServiceFactory = new IdentityServerServiceFactory()
                                .UseInMemoryClients(Clients.Get())
                                .UseInMemoryUsers(Users.Get())
                                .UseInMemoryScopes(Scopes.Get());

                var options = new IdentityServerOptions
                {
                    Factory = idServerServiceFactory,
                    SiteName = "Xamarin Sample STS",
                    IssuerUri = "https://xamarinsamplests/identity",
                    PublicOrigin = "https://xamarinoidcsamplests.azurewebsites.net/",
                    SigningCertificate = LoadCertificate(),
                    RequireSsl = true                  
                };

                idsrvApp.UseIdentityServer(options);
            });
        }

        X509Certificate2 LoadCertificate()
        {
            return new X509Certificate2(
                string.Format(@"{0}\Certificates\idsrv3test.pfx",
                AppDomain.CurrentDomain.BaseDirectory), "idsrv3test");
        }
    }
}
