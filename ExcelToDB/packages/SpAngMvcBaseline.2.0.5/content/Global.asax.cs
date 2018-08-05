using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using SP.OpenData.UI.Portal.App_Start;

namespace SP.OpenData.UI.Portal
{
    public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            AutoMapperConfig.RegisterMappings();

            //custom engine so as we can place our views whereever we want..
            //{0} is the name of the view, {1} would be the mvc controller name but we are largely using 
            //angular controllers so is irrelevant for our purposes
            var razorEngine = ViewEngines.Engines.OfType<RazorViewEngine>().First();
            razorEngine.ViewLocationFormats = razorEngine.ViewLocationFormats.Concat(new[]
            {"~/Views/{1}/{0}.cshtml", 
                "~/Views/Shared/{0}.cshtml", 
                "~/ng-app/views/{0}.cshtml",  
                "~/ng-app/views/{0}/{0}.cshtml",  
                "~/ng-app/views/{0}/{0}.html"}).ToArray();
        }
    }
}