using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Newtonsoft.Json.Serialization;

namespace XamarinFormsOIDCSample.API
{
    public static class WebApiConfig
    {
        public static HttpConfiguration Register()
        {
            // Web API configuration and services
            var config = new HttpConfiguration();

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            // no XML
            config.Formatters.XmlFormatter.SupportedMediaTypes.Clear();

            // results should come out
            // - with indentation for readability
            // - in camelCase

            var json = config.Formatters.JsonFormatter;
            json.SerializerSettings.Formatting = Newtonsoft.Json.Formatting.Indented;
            json.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
            
            return config;
        }
    }
}
