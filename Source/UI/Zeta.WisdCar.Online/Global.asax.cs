using Metrics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Zeta.WisdCar.Business.AutoMapper;
using Zeta.WisdCar.Infrastructure;


namespace Zeta.WisdCar.Online
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            RegisterMetric();
            RegisterAutoMapper();
        }
		
        private void RegisterMetric()
        {
            Metric.Config
                .WithHttpEndpoint(AppSettings.DashboardUrl)
                .WithAllCounters();
        }

        private void RegisterAutoMapper()
        {
			AutoMapperConfiguration.Configure();
        }				
    }
}
