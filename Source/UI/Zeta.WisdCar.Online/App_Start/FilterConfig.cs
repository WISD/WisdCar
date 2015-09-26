using System.Web;
using System.Web.Mvc;
using Zeta.WisdCar.Online.App_Start;

namespace Zeta.WisdCar.Online
{
    public class FilterConfig
    {
       
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new LoginCheckFilterAttribute() { IsCheck = true });
        }
    }
}
