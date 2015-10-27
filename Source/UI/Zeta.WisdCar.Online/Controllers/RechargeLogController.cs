using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Zeta.WisdCar.Business.RechargeConsumeModule;
using Zeta.WisdCar.Infrastructure.Helper;
using Zeta.WisdCar.Infrastructure.Log;
using Zeta.WisdCar.Model.Entity;
using Zeta.WisdCar.Online.App_Start;
using Zeta.WisdCar.Online.Models;

namespace Zeta.WisdCar.Online.Controllers
{
    public class RechargeLogController : BasePageController
    {
        //
        // GET: /RechargeLog/
        public ActionResult Index()
        {
            return View();
        }
        public JsonResult GetRechargeLogList()
        {
            ReturnedData data = new ReturnedData();
            try
            {
                string custName = NullHelper.Convert<string>(Request["Name"], "");
                string cardNo = NullHelper.Convert<string>(Request["CardNo"], "");
                string reStroe = NullHelper.Convert<string>(Request["Dore"], "");
                string beginDate = NullHelper.Convert<string>(Request["from"], null);
                string endDate = NullHelper.Convert<string>(Request["to"], null);
                string creator = NullHelper.Convert<string>(Request["Operator"], "");

                RechargeMgm recMgm = new RechargeMgm();
                RechargeLogQueryEntity entity = new RechargeLogQueryEntity()
                { 
                    CustName=custName,
                    Creator=creator,
                    ClubCardNO=cardNo,
                    StoreID=reStroe,
                    StartDate=string.IsNullOrEmpty(beginDate)?null:(DateTime?)Convert.ToDateTime(beginDate),
                    EndDate = string.IsNullOrEmpty(endDate)? null : (DateTime?)Convert.ToDateTime(endDate)
                };
                
                var list = recMgm.GetRechargeCashLog(entity);
                data.Success = true;
                data.Data = list;
            }
            catch(Exception ex)
            {
                data.Success = false;
                data.Message = "出现错误，请联系维护人员";
                LogHandler.Error(ex.Message.ToString());
                data.Error = ex.ToString();
            }
            return Json(data, JsonRequestBehavior.AllowGet);
        }
	}
}