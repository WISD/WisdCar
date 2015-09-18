using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Zeta.WisdCar.Business.CustClubCardModule;
using Zeta.WisdCar.Business.MarktingPlanModule;
using Zeta.WisdCar.Infrastructure;
using Zeta.WisdCar.Infrastructure.Helper;
using Zeta.WisdCar.Infrastructure.Log;
using Zeta.WisdCar.Model.Entity;
using Zeta.WisdCar.Model.VO;
using Zeta.WisdCar.Online.App_Start;
using Zeta.WisdCar.Online.Models;

namespace Zeta.WisdCar.Online.Controllers
{
    public class ClubCardController :BasePageController
    {
        //
        // GET: /ClubCard/ 
        public ActionResult Index()
        {
            return View();
        }
        public JsonResult GetCludCardList()
        {
            DatatablesResult<ClubCardVO> result = new DatatablesResult<ClubCardVO>();
            try{
                int start = NullHelper.Convert<int>(Request[Constants.PAGE_START], 0);
                int length = NullHelper.Convert<int>(Request[Constants.PAGE_LENGTH], 10);
                int draw = NullHelper.Convert<int>(Request[Constants.REQ_DRAW], 1);
                string sortOrder = NullHelper.Convert<string>(Request[Constants.SORT_ORDER], "asc");
                int sortIdx = NullHelper.Convert<int>(Request[Constants.SORT_IDX], 0);
                string columnKey = string.Format(Constants.SORT_NAME, sortIdx);
                string sortName = NullHelper.Convert<string>(Request[columnKey], "ClubcardNO");

                string cardno = NullHelper.Convert<string>(Request["ClubcardNO"], "");
                int cardtype = NullHelper.Convert<int>(Request["ClubcardType"], -1);
                string custName = NullHelper.Convert<string>(Request["CustomerName"], "");
                string mobileNo = NullHelper.Convert<string>(Request["MobileNo"], "");
                int cardstatus = NullHelper.Convert<int>(Request["CardStatus"], -1);
                string storename = NullHelper.Convert<string>(Request["SaleCardStore"], "");
                
                if(sortName=="MobileNo"||sortName=="CardStatusDesc")
                {
                    sortName="ClubcardNO";
                }

                ClubCardTypeMgm clucardbMgm = new ClubCardTypeMgm();
                ClubCardTypeVO clubcardtype = clucardbMgm.GetCardTypeByID(cardtype);
                IClubCardMgm clubcardMgm = new ClubCardMgm(); 

                ClubCardQueryEntity filter = new ClubCardQueryEntity()
                {
                    Start = start, Length = length, SortOrder= sortOrder,SortName=sortName, ClubCardNo = cardno,
                    ClubCardTypeID = cardtype,ClubCardTypeName ="", MobileNo=mobileNo, Name=custName,
                    StoreName = storename,CardStatus = cardstatus
                };

                var list = clubcardMgm.GetClubCards(filter);

                int recordsTotal = list.Count;
                list.ForEach(i => i.MobileNo = new CustomerMgm().GetCustomerByID(i.CustomerID).MobileNO);
                foreach (var item in list)
                {
                    item.DT_RowId = item.ClubCardID.ToString();

                    switch(item.CardStatus)
                    {
                        case (int)ClubCardStatus.OpenCard: item.CardStatusDesc = "已开卡";
                            break;
                        case (int)ClubCardStatus.Froze: item.CardStatusDesc = "已冻结";
                            break;
                        case (int)ClubCardStatus.ReportLoss: item.CardStatusDesc = "已挂失";
                            break;
                        case (int)ClubCardStatus.LogOff: item.CardStatusDesc = "已注销";
                            break;
                        case (int)ClubCardStatus.Expire: item.CardStatusDesc = "已过期";
                            break;
                    }
                    item.Operation = " <div class='btn-group'><button onclick='ClubCard.Operation("
                        + item.DT_RowId + ")' class='btn blue dropdown-toggle' type='button' data-toggle='dropdown'>操作 <i class='fa fa-angle-down'></i></button> <ul class='dropdown-menu pull-right' role='menu'><li><a href='" + @Url.Action("ClubCardDetails", "ClubCard") + "?type=card&id=" + item.DT_RowId + "'>查看</a></li><li><a href='#'>套餐余额</a></li><li><a href='" + @Url.Action("ResetPassword", "ClubCard") + "?id=" + item.DT_RowId + "'>修改密码</a></li><li class='divider'></li><li><a href='" + @Url.Action("SetCardStatus", "ClubCard") + "?id=" + item.DT_RowId + "'>挂失/冻结</a></li>{0}<li><a href=''>套餐充值</a></li> <li><a href=''>会员消费</a></li><li><a href=''>已完结套餐查询</a></li></ul></div>";
                    string strChangeno = "<li><a href='javascript:;' onclick='alert(\"该会员卡不处于挂失状态，不能补办会员卡\")' >补办会员卡</a></li>";
                    if (item.CardStatus == 1)
                    {
                        
                        strChangeno = "<li><a href='" + @Url.Action("ChangeCardNo", "ClubCard") + "?id=" + item.DT_RowId + "'>补办会员卡</a></li>";
                    }
                    item.Operation = string.Format(item.Operation, strChangeno);
                }
                
                result.draw = draw;
                result.recordsTotal = recordsTotal;
                result.recordsFiltered = recordsTotal;
                result.data = list;
             }
            catch (Exception ex)
            {
                result.data = new List<ClubCardVO>();
                LogHandler.Error(ex.Message.ToString());
                result.error = ex.ToString();
            }

            return Json(result, JsonRequestBehavior.AllowGet);
            
        }
        public ActionResult ClubcardDetails(int id,string type)
        {
            CustomerAndCard cusAndCard = new CustomerAndCard();
            CustomerMgm custMgm = new CustomerMgm();
            ClubCardMgm cardMgm = new ClubCardMgm();
            if(type=="cust")
            {
                
                var recust = custMgm.GetCustomerByID(id);
                ClubCardVO recard = new ClubCardVO();
                if(recust.CardFlag==1)
                {
                    recard = cardMgm.GetClubCardByCustID(recust.CustomerID);
                }
               
                cusAndCard = GetCusAndCardModel(recard, recust);
            }
            else if(type == "card")
            {
                var recard = cardMgm.GetClubCardByID(id);
                var recust = custMgm.GetCustomerByID(recard.CustomerID);
                cusAndCard = GetCusAndCardModel(recard, recust);
            }
            
            return View(cusAndCard);
        }
        #region 会员卡信息
        private CustomerAndCard GetCusAndCardModel(ClubCardVO recard, CustomerVO recust)
        { 
            if(recard!=null&&recust!=null)
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
                return cuandcard;
            }
            return new CustomerAndCard();
            
            
        }
        public JsonResult SearchCustomer(string mobilno)
        {
            ICustomerMgm custMgm = new CustomerMgm();
            CustomerVO cust = custMgm.GetCustomerByMobileNo(mobilno);
            ClubCardVO card = new ClubCardMgm().GetClubCardByCustID(cust.CustomerID);
            ReturnedData data = new ReturnedData();
            if(cust.CustomerID==0)
            {
                data.Success = false;
                data.Message = "该手机号没有客户";
            }
            else
            {
                data.Success = true;
            }
            if(card==null)
            {
                card = new ClubCardVO();
            }
            CustomerAndCard custandcard = GetCusAndCardModel(card, cust);
            data.Data = custandcard;
            return Json(data, JsonRequestBehavior.AllowGet);
        }
        /// <summary>
        /// 提交信息
        /// </summary>
        /// <returns></returns>
        public JsonResult ClubCardDetailSub(CustomerAndCard cusandcard)
        {
            ReturnedData data = null;
            //添加会员卡
            if(cusandcard.CardID==0)
            {
                data = CustomerCardAddSub(GetCardModel(cusandcard));
            }
            else//修改会员卡
            {
                data = CustomerCardEdiSub(GetCardModel(cusandcard));
            }
            return Json(data, JsonRequestBehavior.AllowGet);
        }
        private ClubCardVO GetCardModel(CustomerAndCard cusandcard)
        {
            ClubCardVO clubcard = new ClubCardVO()
            {
                CustomerID = cusandcard.CustID,
                CustName = cusandcard.CustName,
                ClubCardID = cusandcard.CardID,
                ClubCardNo = cusandcard.CardNo,
                ClubCardTypeID=cusandcard.CardType,
                SalesMan = cusandcard.SaleMan,
                OpenCardStore = cusandcard.OpenCardStore,
                CardStatus = cusandcard.CardStatu
            };
            return clubcard;
        }
       
       
        /// <summary>
        /// 修改会员卡
        /// </summary>
        /// <param name="customer"></param>
        /// <returns></returns>
        private ReturnedData CustomerCardEdiSub(ClubCardVO clubcard)
        {
            IClubCardMgm cusmgm = new ClubCardMgm();
            ReturnedData data = new ReturnedData();
            try
            {
                clubcard.LastModifiedDate = DateTime.Now;
                clubcard.ClubCardTypeName = new ClubCardTypeMgm().GetCardTypeByID(clubcard.ClubCardTypeID).CardTypeName;
                clubcard.LastModifierID = Emp.UserName;
                cusmgm.Update(clubcard);
                data.Message = "会员信息修改成功";
                data.Success = true;
            }
            catch (Exception ex)
            {
                data.Success = false;
                data.Message = "会员信息修改失败";
                data.Error = ex.ToString();

            }

            return data;
        }
      
        /// <summary>
        /// 添加会员卡
        /// </summary>
        /// <param name="clubcard"></param>
        /// <returns></returns>
        public ReturnedData CustomerCardAddSub(ClubCardVO clubcard)
        {

            IClubCardMgm clubCardMgm = new ClubCardMgm();
            clubcard.CreatedDate = DateTime.Now;
            clubcard.LastModifiedDate = DateTime.Now;
            clubcard.SalesTime = DateTime.Now;
            clubcard.ExpireDate = clubcard.SalesTime.AddYears(2);
            clubcard.CreatorID = Emp.UserName;
            clubcard.LastModifierID = Emp.UserName;
            clubcard.ClubCardTypeName = new ClubCardTypeMgm().GetCardTypeByID(clubcard.ClubCardTypeID).CardTypeName;

            clubcard.ClubCardPwd = "123456";
            //clubcard.OpenCardStore = Emp.StroeName;
            //clubcard.SalesMan = Emp.Name;//存疑
            ReturnedData data = new ReturnedData();
            try
            {
                clubCardMgm.AddClubCard(clubcard);
                ICustomerMgm cusMgm = new CustomerMgm();
                var cust = cusMgm.GetCustomerByID(clubcard.CustomerID);
                cust.CardFlag = 1;
                cusMgm.EditCustomer(cust);
                data.Message = "开卡成功";
                data.Success = true;
            }
            catch (Exception ex)
            {
                data.Success = false;
                data.Message = "开卡失败";
                data.Error = ex.ToString();

            }

            return data;
        }
        #endregion

        public ActionResult ResetPassword(int id)
        {
            IClubCardMgm cardMgm = new ClubCardMgm();
            ClubCardVO card = cardMgm.GetClubCardByID(id);
            return View(card);
        }
        public JsonResult ResetPasswordSub(int id,string oldpwd,string newpwd)
        {
            IClubCardMgm cardMgm = new ClubCardMgm();
            string result= cardMgm.UpdatePwd(id, oldpwd, newpwd);
            ReturnedData data = new ReturnedData();
            if(result==null)
            {
                data.Success = true;
                data.Message = "密码重置成功";
            }
            else
            {
                data.Success = false;
                data.Message = result;
            }
            return Json(data, JsonRequestBehavior.AllowGet);
        }

        public ActionResult SetCardStatus(int id)
        {
            IClubCardMgm cardMgm = new ClubCardMgm();
            ClubCardVO card = cardMgm.GetClubCardByID(id);
            return View(card);
        }
        public JsonResult SetgCardStatusSub(int id,int status)
        {
            IClubCardMgm cardMgm = new ClubCardMgm();
            ReturnedData data = new ReturnedData();
            try
            {
                cardMgm.UpdateClubCardStatus(id, status);
                data.Success = true;
                data.Message = "会员卡状态修改成功";
            }
            catch (Exception ex)
            {
                LogHandler.Error(ex.ToString());
                data.Success = false;
                data.Message = "会员卡状态修改成功";
            }
            
            
            return Json(data, JsonRequestBehavior.AllowGet);
        }
        public ActionResult ChangeCardNo(int id)
        {
            IClubCardMgm cardMgm = new ClubCardMgm();
            ClubCardVO card = cardMgm.GetClubCardByID(id);
            return View(card);
        }
        public JsonResult ChangeCardNoSub(int id, string CardNo)
        {
            IClubCardMgm cardMgm = new ClubCardMgm();
            
            ReturnedData data = new ReturnedData();
            try
            {
                ClubCardVO card = cardMgm.GetClubCardByID(id);
                if (card.CardStatus == 1)
                {
                    cardMgm.UpdateClubCardNo(id, CardNo);
                    data.Success = true;
                    data.Message = "会员卡补卡成功";
                }
                else
                {
                    data.Success = false;
                    data.Message = "该会员卡不处于挂失状态，不需要补卡";
                }
                
            }
            catch (Exception ex)
            {
                LogHandler.Error(ex.ToString());
                data.Success = false;
                data.Message = "会员卡补卡成功";
            }


            return Json(data, JsonRequestBehavior.AllowGet);
        }
	}
}