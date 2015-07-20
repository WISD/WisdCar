using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Zeta.WisdCar.Online.Startup))]
namespace Zeta.WisdCar.Online
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
