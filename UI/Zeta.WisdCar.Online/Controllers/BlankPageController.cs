using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Zeta.WisdCar.Online.Controllers
{
    public class BlankPageController : Controller
    {
        //
        // GET: /TestLayout/
        public ActionResult Index()
        {
            Business.BusinessMocker.MockLog4Net();

            return View();
        }
    }
}