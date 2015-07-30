using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Zeta.WisdCar.H5.Startup))]
namespace Zeta.WisdCar.H5
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
