using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Zeta.WisdCar.Infrastructure.Log;

namespace Zeta.WisdCar.Online.Controllers
{
    public class BlankPageController : Controller
    {
        //
        // GET: /TestLayout/
        public ActionResult Index()
        {
            try
            {
                var i = 0;
                var result = 100 / i;
            }
            catch (Exception ex)
            {
                LogHandler.Error("asdfsadfasdfasdf");
            }

            Business.BizMocker.MockLog4Net();

            return View();
        }
    }
}