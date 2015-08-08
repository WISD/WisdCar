using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Zeta.WisdCar.Infrastructure.Log;

namespace Zeta.WisdCar.Online.Controllers
{
    public class DashboardController : Controller
    {
        //
        // GET: /TestLayout/
        public ActionResult Index()
        {
            Business.BizMocker.MockLog4Net();

            return View();
        }
    }
}