using Metrics;
using Microsoft.Owin;
using Owin;
using Zeta.WisdCar.Infrastructure;

[assembly: OwinStartupAttribute(typeof(Zeta.WisdCar.Online.Startup))]
namespace Zeta.WisdCar.Online
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);

            Metric.Config
                .WithHttpEndpoint(AppSettings.DashboardUrl)
                .WithAllCounters();
        }
    }
}
