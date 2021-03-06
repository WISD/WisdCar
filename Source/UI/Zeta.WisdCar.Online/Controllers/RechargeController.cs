﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Zeta.WisdCar.Business.CustClubCardModule;
using Zeta.WisdCar.Business.Handler;
using Zeta.WisdCar.Business.MarktingPlanModule;
using Zeta.WisdCar.Business.RechargeConsumeModule;
using Zeta.WisdCar.Infrastructure;
using Zeta.WisdCar.Infrastructure.Helper;
using Zeta.WisdCar.Infrastructure.Log;
using Zeta.WisdCar.Model.VO;
using Zeta.WisdCar.Online.App_Start;
using Zeta.WisdCar.Online.Models;

namespace Zeta.WisdCar.Online.Controllers
{
    public class RechargeController : BasePageController
    {
        //
        // GET: /ClubcardRecharge/
        public ActionResult Index()
        {
            int id = NullHelper.Convert<int>(Request["id"], 0);
            CustomerAndCard cuscard = new CustomerAndCard();
            if(id>0)
            {
                IClubCardMgm cardMgm = new ClubCardMgm();
                ClubCardVO card = cardMgm.GetClubCardByID(id);
                ICustomerMgm custMgm = new CustomerMgm();
                CustomerVO cust = custMgm.GetCustomerByID(card.CustomerID);
                cuscard = GetCusAndCardModel(card, cust);
            }
            return View(cuscard);
        }
        public JsonResult SearchCustomerAndCard()
        {
            string mobileno = NullHelper.Convert<string>(Request["MobileNo"], "");
            string cardNo = NullHelper.Convert<string>(Request["CardNo"], "");
            ReturnedData data = new ReturnedData();
            if(!string.IsNullOrEmpty(mobileno)||!string.IsNullOrEmpty(cardNo))
            {
                ICustomerMgm custMgm = new CustomerMgm();
                IClubCardMgm cardMgm = new ClubCardMgm();
                //有缺陷
                if(!string.IsNullOrEmpty(mobileno))
                {
                    CustomerVO cust = custMgm.GetCustomerByMobileNo(mobileno);
                    if(cust!=null)
                    {
                        ClubCardVO card = cardMgm.GetClubCardByCustID(cust.CustomerID);
                        data.Data = GetCusAndCardModel(card, cust);
                        data.Success = true;
                    }
                    else
                    {
                        data.Success = false;
                        data.Message = "当前手机号无用户";
                    }
                    
                }
                else if(!string.IsNullOrEmpty(cardNo))
                {
                    ClubCardVO card = cardMgm.GetClubCardByCardNo(cardNo);
                    if(card!=null)
                    {
                        CustomerVO cust = custMgm.GetCustomerByID(card.CustomerID);
                        data.Data = GetCusAndCardModel(card, cust);
                        data.Success = true;
                    }
                    else
                    {
                        data.Success = false;
                        data.Message = "当前会员卡号无用户";
                    }    
                }  
            }
            else
            {
                data.Success = false;
                data.Message = "请输入会员卡号或用户手机号码";
            }
            return Json(data,JsonRequestBehavior.AllowGet);
        }
        private CustomerAndCard GetCusAndCardModel(ClubCardVO recard, CustomerVO recust)
        {
            if (recard != null && recust != null)
            {
                CustomerAndCard cuandcard = new CustomerAndCard()
                {
                    CustID = recust.CustomerID,
                    CustName = recust.Name,
                    ICNo = recust.ICNo,
                    MobileNo = recust.MobileNO,
                    Birthday = recust.Birthday,
                    CardID = recard.ClubCardID,
                    CardNo = recard.ClubCardNo,
                    CardType = recard.ClubCardTypeID,
                    CardStatu = recard.CardStatus,
                    OpenCardStore = recard.OpenCardStore,
                    SaleMan = recard.SalesMan,
                    SaleTime = recard.SalesTime,
                    ExpireDate = recard.ExpireDate
                };
                cuandcard.CardTypeName = recard.ClubCardTypeName;
                switch(recard.CardStatus)
                {
                    case (int)ClubCardStatus.OpenCard: cuandcard.CardStatuName = "开卡";
                        break;
                    case (int)ClubCardStatus.Expire: cuandcard.CardStatuName = "过期";
                        break;
                    case (int)ClubCardStatus.Froze: cuandcard.CardStatuName = "冻结";
                        break;
                    case (int)ClubCardStatus.LogOff: cuandcard.CardStatuName = "注销";
                        break;
                    case (int)ClubCardStatus.ReportLoss: cuandcard.CardStatuName = "挂失";
                        break;
                }
                return cuandcard;
            }
            return new CustomerAndCard();
        }
        [HttpGet]
        public ActionResult RechargeCash()
        {
            int cardid = NullHelper.Convert<int>(Request["id"],0);
            if(cardid>0)
            {
                IClubCardMgm cardMgm = new ClubCardMgm();
                var card = cardMgm.GetClubCardByID(cardid);
                IClubCardTypeMgm ctypeMgm = new ClubCardTypeMgm();
                var ctype = ctypeMgm.GetCardTypeByID(card.ClubCardTypeID);
                ViewData["name"] = card.CustName;
                ViewData["cno"] = card.ClubCardNo;
                ViewData["ctype"] = card.ClubCardTypeName;
                ViewData["discount"] = ctype.PayDiscount;
            }
            else
            {
                ViewData["name"] = "";
                ViewData["cno"] = "";
                ViewData["ctype"] = "";
                ViewData["discount"] = "";
            }
            
            //recharge.
            return View();
        }
        [HttpPost]
        public JsonResult RechargeCashSub()
        {
            ReturnedData data = new ReturnedData();

            try
            {
                string cardno = NullHelper.Convert<string>(Request["cno"], "");
                decimal rechargeAmount = NullHelper.Convert<decimal>(Request["rechargeAcc"], 0M);
                decimal rechargeDiscount = NullHelper.Convert<decimal>(Request["discount"], 0M);
                IClubCardMgm cardMgm = new ClubCardMgm();
             

                var card = cardMgm.GetClubCardByCardNo(cardno);
                RechargeVO recharge = new RechargeVO();
                recharge.ClubCardID = card.ClubCardID;
                recharge.ClubCardNo = card.ClubCardNo;
                recharge.ActualRechargeAmount = rechargeAmount;
                recharge.CustID = card.CustomerID;
                recharge.CustName = card.CustName;
                recharge.DiscountRate = rechargeDiscount;
                if (rechargeDiscount == 0)
                {
                    rechargeDiscount = 1;
                }
                recharge.PlatformRechargeAmount =Math.Round(rechargeAmount/ rechargeDiscount,2);
                recharge.RechargeDate = DateTime.Now;
                recharge.RechargeStore = Emp.StroeName;
                recharge.OriginalStore = card.OpenCardStore;
                recharge.PayType = (int)PayType.Cash;
                recharge.LastModifierID = Emp.UserName;
                recharge.LastModifiedDate = DateTime.Now;
                recharge.CreatedDate = DateTime.Now;
                recharge.CreatorID = Emp.UserName;
                recharge.DiscountInfo = "会员现金折扣";
                recharge.ClubCardPackageID = "";
                recharge.RechargeType = (int)RechargeType.ClubCash;
                recharge.RechargeSerialNo = SerialNoGenerator.GenRechargeSerialNo(Emp.StoreId);
                recharge.SalesMan = card.SalesMan;

                IRechargeMgm rechargeMgm = new RechargeMgm();
                rechargeMgm.RechargeCash(recharge);
                data.Success = true;
                Session.Add("recharge", recharge);
            }
            catch (Exception ex)
            {
                data.Success = false;
                data.Error = ex.ToString();
                data.Message = "充值失败";
                
            }
            
            return Json(data,JsonRequestBehavior.AllowGet);
        }
        public ActionResult RechargeSuccess()
        {
            RechargeVO recharge = new RechargeVO();
            if(Session["recharge"]!=null)
            {
                recharge = Session["recharge"] as RechargeVO;
                Session.Remove("recharge");
            }

            return View(recharge);
        }
        public ActionResult RechargePkg()
        {
            
            int cardid = NullHelper.Convert<int>(Request["id"], 0);
            ClubCardMgm cardMgm = new ClubCardMgm();
            var card = cardMgm.GetClubCardByID(cardid);
            ViewData["PkgBag"] = GetddlList(DDLlist.Pkg, false, null, null);
            ViewBag.Data = card;
            return View();
        }
        public JsonResult GetPkgItems()
        {
            ReturnedData data = new ReturnedData();
            try
            {
                int pkgId = NullHelper.Convert<int>(Request["id"], -1);
                PkgItemsMgm pkgMgm = new PkgItemsMgm();
                PackageMgm pkMgm = new PackageMgm();

                var pkg = pkMgm.GetPackageByID(pkgId);
                var pkgitem = pkgMgm.GetItemsByPkgID(pkgId);
                data.Success = true;
                data.Message = pkg.TotalPrice.ToString();
                data.Data = pkgitem;
            }
            catch (Exception ex)
            {
                data.Success = false;
                data.Message = "系统错误，请联系维护人员";
                data.Error = ex.ToString();
                LogHandler.Error(ex.Message.ToString());
            }
            return Json(data, JsonRequestBehavior.AllowGet);
        }
        public JsonResult RechargePkgSub()
        {
            ReturnedData data = new ReturnedData();
            try
            {
                string cardNo = NullHelper.Convert<string>(Request["cardNo"], null);
                int pkgId = NullHelper.Convert<int>(Request["pkgId"], -1);
                decimal disCount = NullHelper.Convert<decimal>(Request["disCount"], 0M);
                decimal rechAmount = NullHelper.Convert<decimal>(Request["rechAmount"], 0M);
                decimal pkgPrice = NullHelper.Convert<decimal>(Request["pkgPrice"], 0M);
                IClubCardMgm cardMgm = new ClubCardMgm();
                RechargeMgm rechMgm = new RechargeMgm();

                var card = cardMgm.GetClubCardByCardNo(cardNo);
                RechargeVO recharge = new RechargeVO();
                recharge.ClubCardID = card.ClubCardID;
                recharge.ClubCardNo = card.ClubCardNo;
                recharge.ActualRechargeAmount = rechAmount;
                recharge.CustID = card.CustomerID;
                recharge.CustName = card.CustName;
                recharge.DiscountRate = disCount;
                recharge.Reserved1 = card.ClubCardTypeName;

                recharge.PlatformRechargeAmount = pkgPrice;
                recharge.RechargeDate = DateTime.Now;
                recharge.RechargeStore = Emp.StroeName;
                recharge.OriginalStore = card.OpenCardStore;
                recharge.PayType = (int)PayType.Cash;
                recharge.LastModifierID = Emp.UserName;
                recharge.LastModifiedDate = DateTime.Now;
                recharge.CreatedDate = DateTime.Now;
                recharge.CreatorID = Emp.UserName;
                recharge.DiscountInfo = "会员套餐折扣";
                recharge.ClubCardPackageID =pkgId.ToString();
                recharge.RechargeType = (int)RechargeType.ClubPackage;
                recharge.RechargeSerialNo = SerialNoGenerator.GenRechargeSerialNo(Emp.StoreId);
                recharge.SalesMan = card.SalesMan;

                var reMes= rechMgm.RechargePkg(recharge);
                if (reMes == 1)
                {
                    Session.Add("rehPkg", recharge);
                    data.Success = true;
                    data.Message = "套餐购买成功";
                }
                else
                {
                    data.Success = false;
                    data.Message = "套餐购买失败";
                }

            }
            catch(Exception ex)
            {
                data.Success = false;
                data.Message = "系统错误，请联系维护人员";
                data.Error = ex.ToString();
                LogHandler.Error(ex.Message.ToString());
            }
            return Json(data,JsonRequestBehavior.AllowGet);
        }
        public ActionResult RechargePkgSuccess()
        {
            RechargeVO recharge = new RechargeVO();
            string pkgName = null;
            if (Session["rehPkg"] != null)
            {
                recharge = Session["rehPkg"] as RechargeVO;
                pkgName = new PackageMgm().GetPackageByID(int.Parse(recharge.ClubCardPackageID)).PackageName;
                Session.Remove("rehPkg");
            }
            ViewBag.PkgName = pkgName;
            ViewBag.Rechbag = recharge;
            return View();
        }
	}
}