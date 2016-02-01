using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IdentityServer3.Core.Models;

namespace XamarinFormsOIDCSample.IdentityServer.Config
{
    public static class Clients
    {
        public static IEnumerable<Client> Get()
        {
            return new[]
             {
                new Client
                {
                    ClientId = "xamarinsampleimplicit",
                    ClientName = "Xamarin Sample (Implicit)",
                    Flow = Flows.Implicit,
                    AllowAccessToAllScopes = true,
                    RequireConsent = true,
                                   
                    // redirect = URI of the Xamarin Application
                    RedirectUris = new List<string>
                    {
                        "https://xamarin-oidc-sample/redirect"
                    }
                }
            };
        }
    }
}
