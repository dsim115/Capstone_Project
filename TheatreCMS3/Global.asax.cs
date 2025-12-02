using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace TheatreCMS3
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            // IMPORTANT: no Database.SetInitializer here.
            // The initializer is handled inside ApplicationDbContext.

            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
