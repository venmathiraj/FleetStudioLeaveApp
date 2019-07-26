using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Formatting;
using System.Web.Http;

namespace FleetStudioLeaveApp
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
//            GlobalConfiguration.Configuration.Formatters.JsonFormatter.MediaTypeMappings
//.Add(new System.Net.Http.Formatting.RequestHeaderMapping("Accept",
//                              "text/html",
//                              StringComparison.InvariantCultureIgnoreCase,
//                              true,
//                              "application/json"));

            config.Formatters.Clear(); //because there are defaults of XML..
            config.Formatters.Add(new JsonMediaTypeFormatter());
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
