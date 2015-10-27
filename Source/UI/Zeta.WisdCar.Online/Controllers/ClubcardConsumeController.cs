using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
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
    public class ClubcardConsumeController : BasePageController
    {
        //
        // GET: /ClubcardConsume/
        public ActionResult Index()
        {
            ViewData["ConItem"] = GetddlList(DDLlist.PkgItem, false, null, null,null);
            //ViewData["CardPkgItem"]=GetddlList(DDLlist.CardPkg,null,null,null,)
            int id = NullHelper.Convert<int>(Request["id"], 0);
            ViewBag.StoreName = Emp.StroeName;
            ViewBag.Recivor = Emp.UserName;
            CustomerAndCard cuscard = new CustomerAndCard();
            if (id > 0)
            {
                IClubCardMgm cardMgm = new ClubCardMgm();
                ClubCardVO card = cardMgm.GetClubCardByID(id);
                ICustomerMgm custMgm = new CustomerMgm();
                CustomerVO cust = custMgm.GetCustomerByID(card.CustomerID);
                cuscard = GetCusAndCardModel(card, cust);
            }
            return View(cuscard);
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
                switch (recard.CardStatus)
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
        #region 验证会员密码
        public JsonResult CheckCardPassword()
        {
            ReturnedData data = new ReturnedData();
            try
            {
                string cardNo = NullHelper.Convert<string>(Request["cardNo"], "");
                string pwd = NullHelper.Convert<string>(Request["pwd"], "");

                ClubCardMgm cardMgm = new ClubCardMgm();
                var card = cardMgm.GetClubCardByCardNo(cardNo);
                int erroNum = 0;
                if (!string.IsNullOrEmpty(card.Reserved1))
                {
                    erroNum = NullHelper.Convert<int>(card.Reserved1, 0);
                }

                if (erroNum < 3 && card.CardStatus == (int)ClubCardStatus.OpenCard)
                {
                    var result = cardMgm.CheckPwd(card.ClubCardID, pwd);
                    if (!result)
                    {
                        card.Reserved1 = (erroNum + 1).ToString();
                        if (erroNum == 2)
                        {
                            card.CardStatus = (int)ClubCardStatus.Froze;
                            card.Reserved1 = "0";
                            data.Message = "密码输入错误三次，会员卡被冻结";
                        }
                        else
                        {
                            data.Message = "密码输入错误，还剩" + (2 - erroNum) + "次机会";
                        }
                        cardMgm.Update(card);
                        data.Success = false;

                    }
                    else
                    {
                        if (erroNum > 0)
                        {
                            card.Reserved1 = "0";
                            cardMgm.Update(card);
                        }
                        data.Success = true;
                        data.Message = "密码验证成功";

                    }
                }
                else
                {
                    data.Success = false;
                    data.Message = "当前会员卡不能正常使用，请联系管理员";
                }


            }
            catch (Exception ex)
            {
                data.Success = false;
                data.Message = "出现错误，请联系维护人员";
                LogHandler.Error(ex.Message.ToString());
                data.Error = ex.ToString();
            }
            return Json(data, JsonRequestBehavior.AllowGet);
        } 
        #endregion
        #region 会员现金消费
        public JsonResult SumCardCarshConsumeItems()
        {
            ReturnedData data = new ReturnedData();
            try
            {
                string cardNo = NullHelper.Convert<string>(Request["cardNo"], "");
                string itemData = NullHelper.Convert<string>(Request["itemData"], "");
                //[{\"itemid\":\"12\",\"itemName\":\"喷漆\",\"itemSum\":\"1\",\"itemSubPrice\":\"150\"}]
                //JavaScriptSerializer jsonSerializer = new JavaScriptSerializer();
                //List<ComsumeItemViewModel> list = (List<ComsumeItemViewModel>)jsonSerializer.Deserialize(itemData,typeof(ComsumeItemViewModel));

                if (!string.IsNullOrEmpty(itemData))
                {
                    List<ComsumeItemViewModel> list = JsonSerializer(itemData,ConsumeType.ClubCash);
                    ClubCardMgm cardMgm = new ClubCardMgm();
                    var card = cardMgm.GetClubCardByCardNo(cardNo);
                    var conlist = GetConsumeList(list, card, ConsumeType.ClubCash);
                    ConsumeMgm conMgm = new ConsumeMgm();
                    var consSerNo = conMgm.ConsumeCash(conlist);
                    data.Success = true;
                    LogHandler.Info(Emp.UserName + "添加会员现金消费，时间：" + DateTime.Now);
                    data.Message = consSerNo + "|" + conlist.FirstOrDefault().CreatedDate.ToString("yyyy/MM/dd HH:mm:ss");
                    data.Data = cardMgm.GetBalanceByClubCardID(card.ClubCardID);
                }

            }
            catch (Exception ex)
            {
                data.Success = false;
                data.Message = "会员现金消费过程出现异常，请联系维护人员";
                data.Error = ex.ToString();
                LogHandler.Error(ex.Message.ToString());
            }
            return Json(data, JsonRequestBehavior.AllowGet);
        }
        private List<ConsumeVO> GetConsumeList(List<ComsumeItemViewModel> list, ClubCardVO card, ConsumeType conType)
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
                    ClubCardNo = card.ClubCardNo,
                    ClubCardID = card.ClubCardID,
                    CustID = card.CustomerID,
                    CustName = card.CustName,
                    OriginalStore = card.OpenCardStore,
                    RemainCount = 0,
                    Reserved1 = Emp.StoreId.ToString()
                });
            });
            return conList;
        }
        private List<ConsumeVO> GetConsumeList(List<ConsumePkgViewModel> list, ClubCardVO card, ConsumeType conType)
        {
            List<ConsumeVO> conList = new List<ConsumeVO>();
            DateTime date = DateTime.Now;
            
            list.ForEach(item =>
            {
                conList.Add(new ConsumeVO
                {
                    ItemID = 0,
                    ItemName = item.ItemName,
                    ConsumeStore = Emp.StroeName,
                    ConsumeCount = item.ItemConNum,
                    OriginalPrice = 0,
                    CreatedDate = date,
                    CreatorID = Emp.UserName,
                    LastModifiedDate = date,
                    LastModifierID = Emp.UserName,
                    ConsumeDate = date,
                    ConsumeType = (int)conType,
                    ClubCardPackageID = item.PkgId,
                    PackageDetailID = item.ItemId,
                    ClubCardNo = card.ClubCardNo,
                    ClubCardID = card.ClubCardID,
                    CustID = card.CustomerID,
                    CustName = card.CustName,
                    OriginalStore = card.OpenCardStore,
                    RemainCount = 0,
                    Reserved1 = Emp.StoreId.ToString()
                });
            });
            return conList;
        }
        private List<ComsumeItemViewModel> JsonSerializer(string data, ConsumeType conType)
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
        private List<ConsumePkgViewModel> JsonSerializerPkg(string data, ConsumeType conType)
        {
            List<ConsumePkgViewModel> list = new List<ConsumePkgViewModel>();
            string dataitems = data.Replace("},", "}|");
            Regex re = new Regex("\"|\\[|\\]|{|}");
            dataitems = re.Replace(dataitems, "");
            string[] items = dataitems.Split('|');

            foreach (var item in items)
            {
                string[] itemAttr = item.Split(',');
                ConsumePkgViewModel comModel = new ConsumePkgViewModel();
                comModel.PkgId = NullHelper.Convert<string>(itemAttr[0].Split(':')[1], "");
                comModel.ItemId = NullHelper.Convert<int>(itemAttr[1].Split(':')[1], 0);
                comModel.ItemName = NullHelper.Convert<string>(itemAttr[2].Split(':')[1], "");
                comModel.ItemConNum = NullHelper.Convert<int>(itemAttr[3].Split(':')[1], 0);
                list.Add(comModel);
            }

            return list;
        } 
        #endregion
        #region 会员套餐消费
        /// <summary>
        /// 获取会员卡所有套餐
        /// </summary>
        /// <returns></returns>
        public JsonResult GetCardPkgList()
        {
            ReturnedData data = new ReturnedData();
            try
            {
                int cardId = NullHelper.Convert<int>(Request["cardId"], 0);

                var list = GetddlList(DDLlist.CardPkg,false, null, null, cardId);
                data.Success = true;
                data.Data = list;
            }
            catch (Exception ex)
            {
                LogHandler.Error(ex.Message.ToString());
                data.Success = false;
                data.Message = "出现错误，请联系维护人员";
                data.Error = ex.ToString();
            }
            return Json(data, JsonRequestBehavior.AllowGet);
        }
        /// <summary>
        /// 获取会员卡套餐消费项目
        /// </summary>
        /// <returns></returns>
        public JsonResult GetCardPkgItemList()
        {
            ReturnedData data = new ReturnedData();
            try
            {
                string cardPkgId = NullHelper.Convert<string>(Request["cardPkgId"],"-1");
                ClubCardMgm cardMgm = new ClubCardMgm();
                var result = cardMgm.GetDetailByClubCardPkgID(cardPkgId);
                List<SelectListItem> itemList = new List<SelectListItem>();
                result = result.SkipWhile(i => i.RemainCount == 0).ToList();
                if(result!=null&&result.Count>0)
                {
                    result.ForEach(item => {
                        if (item.RemainCount > 0)
                        {
                            if (itemList.Count <= 0)
                                itemList.Add(new SelectListItem() { Text = item.ItemName, Value = item.PackageDetailID.ToString(), Selected = true });
                            else
                                itemList.Add(new SelectListItem() { Text = item.ItemName, Value = item.PackageDetailID.ToString() });
                        } 
                    });
                }
                else
                {
                    itemList.Add(new SelectListItem() { Text = "套餐无可用项目", Value = "-1", Selected = true });
                }
                data.Success = true;
                data.Data = itemList;
            }
            catch(Exception ex)
            {
                LogHandler.Error(ex.Message.ToString());
                data.Success = false;
                data.Message = "出现错误，请联系维护人员";
                data.Error = ex.ToString();
            }
            return Json(data, JsonRequestBehavior.AllowGet);
        }
        public JsonResult GetCardPkgItemDetail()
        {
            ReturnedData data = new ReturnedData();
            try
            {
                int id = NullHelper.Convert<int>(Request["itemId"], -1);
                ClubCardMgm cardMgm = new ClubCardMgm();
                var item = cardMgm.GetClubCardPkgDetailByID(id);
                if (item != null && item.ItemID > 0)
                {
                    data.Success = true;
                    data.Data = item;
                }
                else
                {
                    data.Success = false;
                    data.Message = "该消费项目不存在";
                }
            }
            catch(Exception ex)
            {
                data.Success = false;
                data.Message = "出现错误，请联系维护人员";
                data.Error = ex.ToString();
                LogHandler.Error(ex.Message.ToString());
            }
            return Json(data, JsonRequestBehavior.AllowGet);
        }
        public JsonResult SumCardPkgConsumeItems()
        {
            ReturnedData data = new ReturnedData();
            try
            {
                string cardNo = NullHelper.Convert<string>(Request["cardNo"], "");
                string itemData = NullHelper.Convert<string>(Request["itemData"], "");
                if (!string.IsNullOrEmpty(itemData))
                {
                    List<ConsumePkgViewModel> list = JsonSerializerPkg(itemData, ConsumeType.ClubPackage);
                    ClubCardMgm cardMgm = new ClubCardMgm();
                    var card = cardMgm.GetClubCardByCardNo(cardNo);
                    var conlist = GetConsumeList(list, card, ConsumeType.ClubPackage);
                    ConsumeMgm conMgm = new ConsumeMgm();
                    var consSerNo = conMgm.ConsumePkg(conlist);
                    data.Success = true;
                    LogHandler.Info(Emp.UserName + "添加会员套餐消费，时间：" + DateTime.Now);
                    data.Message = consSerNo + "|" + conlist.FirstOrDefault().CreatedDate.ToString("yyyy/MM/dd HH:mm:ss");
                    data.Data = cardMgm.GetDetailByClubCardPkgID(list[0].PkgId);
                }
            }
            catch (Exception ex)
            {
                data.Success = false;
                data.Message = "出现错误，请联系维护人员";
                data.Error = ex.ToString();
                LogHandler.Error(ex.Message.ToString());
            }
            return Json(data, JsonRequestBehavior.AllowGet);
        }
        #endregion
    }
}