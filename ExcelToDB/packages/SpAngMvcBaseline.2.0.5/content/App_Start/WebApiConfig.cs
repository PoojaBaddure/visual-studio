using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;

namespace SP.OpenData.UI.Portal
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            config.EnableCors(new EnableCorsAttribute("*", "*", "*"));
            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}"
            );

            config.Routes.MapHttpRoute(
               name: "IdApi",
               routeTemplate: "api/{controller}/{id}",
               constraints: new { id = @"^\d+$" },
               defaults: new { id = RouteParameter.Optional }
           );

            config.Routes.MapHttpRoute(
                name: "TypeApi",
                routeTemplate: "api/{controller}/{type}",
               defaults: new { type = RouteParameter.Optional }
            );

            config.Routes.MapHttpRoute(
                name: "TypeAndIdApi",
                routeTemplate: "api/{controller}/{id}/{type}",
               defaults: new { id = RouteParameter.Optional, type = RouteParameter.Optional }
            );
        }
    }
}
