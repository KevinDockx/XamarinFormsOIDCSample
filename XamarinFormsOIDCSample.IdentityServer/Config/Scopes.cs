using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IdentityServer3.Core.Models;

namespace XamarinFormsOIDCSample.IdentityServer.Config
{
    public static class Scopes
    {
        public static IEnumerable<Scope> Get()
        {
            return new List<Scope>
                {
                    StandardScopes.OpenId,
                    StandardScopes.ProfileAlwaysInclude,
                    new Scope
                    {
                        Name = "cowsapi",
                        DisplayName = "Cows API Access",
                        Description = "Allow the application to access the Cows API on your behalf.",
                        Type = ScopeType.Resource,
                         
                    } 
                };
        }
    }
}
