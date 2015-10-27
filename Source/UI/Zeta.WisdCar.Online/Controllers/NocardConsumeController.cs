using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Zeta.WisdCar.Business.CustClubCardModule;
using Zeta.WisdCar.Infrastructure;
using Zeta.WisdCar.Infrastructure.Log;
using Zeta.WisdCar.Online.App_Start;
using Zeta.WisdCar.Online.Models;

namespace Zeta.WisdCar.Online.Controllers
{
    public class NocardConsumeController : BasePageController
    {
        //
        // GET: /NocardConsume/
        public ActionResult Index()
        {
            ViewData["ConItem"] = GetddlList(DDLlist.PkgItem, false, null, null, null);
            ViewBag.StoreName = Emp.StroeName;
            ViewBag.Recivor = Emp.UserName;
            return View();
        }
        public JsonResult GetCustomerModel(string phoneNo)
        {
            ReturnedData data = new ReturnedData();
            CustomerMgm custMgm = new CustomerMgm();
            try
            {
                var cust = custMgm.GetCustomerByMobileNo(phoneNo);
                if(cust!=null&&cust.CustomerID>0)
                {
                    data.Success = true;
                    data.Data = cust;
                //    if(cust.CardFlag==(int)CardFlag.OpenCard)
                //    {
                        
                //    }
                //    else
                //    {
                //        data.Success = false;
                //        data.Message = "该客户为会员，请使用会员消费功能";
                //    }
                }
                else
                {
                    data.Success = false;
                    data.Message = "没有相关客户信息";
                }
            }
            catch(Exception ex)
            {
                data.Success = true;
                data.Message = "出现错误，请联系维护人员";
                data.Error = ex.ToString();
                LogHandler.Error(ex.Message.ToString());
            }

            return Json(data, JsonRequestBehavior.AllowGet);
        }
	}
}