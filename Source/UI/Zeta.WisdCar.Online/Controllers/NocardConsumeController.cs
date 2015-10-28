using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;
using Zeta.WisdCar.Business.CustClubCardModule;
using Zeta.WisdCar.Business.RechargeConsumeModule;
using Zeta.WisdCar.Infrastructure;
using Zeta.WisdCar.Infrastructure.Helper;
using Zeta.WisdCar.Infrastructure.Log;
using Zeta.WisdCar.Model.VO;
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
        public JsonResult SubNocardConsume()
        {
            ReturnedData data = new ReturnedData();
            try
            {
                int payType = NullHelper.Convert<int>(Request["payType"], -1);
                int custID = NullHelper.Convert<int>(Request["custID"], -1);
                string consItem = NullHelper.Convert<string>(Request["data"], "");
                var comlist= JsonSerializer(consItem);
                var cust = new CustomerMgm().GetCustomerByID(custID);
                var conlist= GetConsumeList(comlist, cust, ConsumeType.NoCard,(PayType)payType);
                ConsumeMgm conMgm = new ConsumeMgm();
                string serNo = conMgm.ConsumeForNoCard(conlist);
                data.Success = true;
                data.Message = serNo + "|" + conlist.FirstOrDefault().CreatedDate.ToString("yyyy/MM/dd HH:mm:ss");
            }
            catch(Exception ex)
            {
                data.Success = false;
                data.Message = "出现错误，请联系维护人员";
                LogHandler.Error(ex.Message.ToString());
                data.Error = ex.ToString();
            }
            return Json(data,JsonRequestBehavior.AllowGet);
        }
        private List<ComsumeItemViewModel> JsonSerializer(string data)
        {
            List<ComsumeItemViewModel> list = new List<ComsumeItemViewModel>();
            string dataitems = data.Replace("},", "}|");
            Regex re = new Regex("\"|\\[|\\]|{|}");
            dataitems = re.Replace(dataitems, "");
            string[] items = dataitems.Split('|');

            foreach (var item in items)
            {
                string[] itemAttr = item.Split(',');
                ComsumeItemViewModel comModel = new ComsumeItemViewModel();
                comModel.Itemid = NullHelper.Convert<int>(itemAttr[0].Split(':')[1], 0);
                comModel.ItemName = NullHelper.Convert<string>(itemAttr[1].Split(':')[1], "");
                comModel.ItemConNum = NullHelper.Convert<int>(itemAttr[2].Split(':')[1], 0);
                comModel.ItemTotalPrice = NullHelper.Convert<decimal>(itemAttr[3].Split(':')[1], 0M);
                list.Add(comModel);
            }


            return list;
        }
        private List<ConsumeVO> GetConsumeList(List<ComsumeItemViewModel> list,CustomerVO cust, ConsumeType conType,PayType paytype)
        {
            List<ConsumeVO> conList = new List<ConsumeVO>();
            DateTime date = DateTime.Now;
            list.ForEach(item =>
            {
                conList.Add(new ConsumeVO
                {
                    ItemID = item.Itemid,
                    ItemName = item.ItemName,
                    ConsumeStore = Emp.StroeName,
                    ConsumeCount = item.ItemConNum,
                    OriginalPrice = item.ItemTotalPrice,
                    CreatedDate = date,
                    CreatorID = Emp.UserName,
                    LastModifiedDate = date,
                    LastModifierID = Emp.UserName,
                    ConsumeDate = date,
                    ConsumeType = (int)conType,
                    ClubCardPackageID = "",
                    PackageDetailID = 0,
                    ClubCardNo = "",
                    ClubCardID = 0,
                    CustID = cust.CustomerID,
                    CustName = cust.Name,
                    OriginalStore = "",
                    RemainCount = 0,
                    Reserved1 = Emp.StoreId.ToString(),
                    Reserved2=paytype.ToString()
                });
            });
            return conList;
        }
	}
}