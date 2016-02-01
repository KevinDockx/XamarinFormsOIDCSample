using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using IdentityServer3.AccessTokenValidation;
using Owin;

namespace XamarinFormsOIDCSample.API
{
    public class Startup
    {
        public object JwtSecurityTokenHandler { get; private set; }

        public void Configuration(IAppBuilder app)
        {

            app.UseIdentityServerBearerTokenAuthentication(new
            IdentityServerBearerTokenAuthenticationOptions
            {
                Authority = "https://xamarinoidcsamplests.azurewebsites.net/identity",
                RequiredScopes = new[] { "cowsapi" }
            });

            var httpConfig = WebApiConfig.Register();

            // enable authorization
            httpConfig.Filters.Add(new AuthorizeAttribute());
            // configure webapi
            app.UseWebApi(httpConfig); 
        }
    }
}
