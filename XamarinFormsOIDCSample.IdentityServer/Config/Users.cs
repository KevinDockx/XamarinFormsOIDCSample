using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using IdentityServer3.Core;
using IdentityServer3.Core.Services.InMemory;

namespace XamarinFormsOIDCSample.IdentityServer.Config
{
    public static class Users
    {
        public static List<InMemoryUser> Get()
        {
            return new List<InMemoryUser>() {
                       new InMemoryUser
                       {
                            Username = "Kevin",
                            Password = "secret",
                            Subject = "123",
                            Claims = new[]
                            {
                                new Claim(Constants.ClaimTypes.GivenName, "Kevin"),
                                new Claim(Constants.ClaimTypes.FamilyName, "Dockx")
                            }
                         }
                 };
        }
    }
}
