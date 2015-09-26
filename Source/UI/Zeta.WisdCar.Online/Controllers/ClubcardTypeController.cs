using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Zeta.WisdCar.Business;
using Zeta.WisdCar.Business.MarktingPlanModule;
using Zeta.WisdCar.Infrastructure.Helper;
using Zeta.WisdCar.Infrastructure.Log;
using Zeta.WisdCar.Model.VO;
using Zeta.WisdCar.Online.App_Start;
using Zeta.WisdCar.Online.Models;

namespace Zeta.WisdCar.Online.Controllers
{
    public class ClubcardTypeController :BasePageController
    {
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// 获取所有的会员卡类型
        /// </summary>
        /// <returns></returns>
        public JsonResult GetAllClubCardType()
        {
            List<ClubCardTypeVO> result = new List<ClubCardTypeVO>();

            try
            {
                //BizMocker mocker = new BizMocker();
                //result = mocker.GetAllCardType();
                IClubCardTypeMgm ctypMgm = new ClubCardTypeMgm();
                result = ctypMgm.GetAllCardType();
                foreach (var item in result)
                { 
                    item.DT_RowId = item.ClubCardTypeID.ToString();
                    item.Operation = "<a href='javascript:void(0)' onclick='ClubCardType.Edit(" 
                        + item.DT_RowId + ")'><i class='fa fa-pencil'></i> 编辑</a>  | <a href='javascript:void(0)' onclick='ClubCardType.Del(" 
                        + item.DT_RowId + ")'><i class='fa fa-times'></i> 删除</a>";
                    item.PayDiscountDesc = ConvertDiscount(item.PayDiscount);
                    item.PackageDiscountDesc = ConvertDiscount(item.PackageDiscount);
                }
            }
            catch (Exception ex)
            {
                LogHandler.Error(ex.Message.ToString());
            }

            return Json(result, JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// 折扣转化
        /// </summary>
        /// <param name="d"></param>
        /// <returns></returns>
        private string ConvertDiscount(decimal d)
        {
            return (d * 100).ToString().TrimEnd('0').TrimEnd('.').TrimEnd('0') + " 折";
        }
        public JsonResult GetClubCardTypeModel(int id)
        {
            IClubCardTypeMgm ctmgm = new ClubCardTypeMgm();
            ReturnedData data = new ReturnedData();
            try
            {
                var ctype = ctmgm.GetCardTypeByID(id);
                if(ctype!=null)
                {
                    data.Success = true;
                    data.Data = ctype;
                }
                else
                {
                    data.Success = false;
                    data.Message = "当前没有该会员类型记录";
                }
            }
            catch (Exception ex)
            {
                data.Success = false;
                data.Message = "网络异常";
            }
            return Json(data, JsonRequestBehavior.AllowGet);
        }
        public JsonResult DeleteClubCardTypeModel(int id)
        {
            IClubCardTypeMgm ctmgm = new ClubCardTypeMgm();
            ReturnedData data = new ReturnedData();
            try
            {
                ctmgm.DelCardType(id);
                data.Success = true;
                data.Message = "删除成功";
            }
            catch(Exception ex)
            {
                data.Success = false;
                data.Message = "删除失败,该会员卡类型有会员卡存在";
            }
            return Json(data,JsonRequestBehavior.AllowGet); 
        }
        public JsonResult EditeClubCardTypeModel()
        {
            IClubCardTypeMgm ctmgm = new ClubCardTypeMgm();
            
            int ctid = NullHelper.Convert<int>(Request["id"],0);
            string ctypename = NullHelper.Convert<string>(Request["ctype"], null);
            decimal cdis = NullHelper.Convert<decimal>(Request["cdiscount"], 0M);
            decimal pdis = NullHelper.Convert<decimal>(Request["pkgdiscount"], 0M);
            var cardtype = new ClubCardTypeMgm().GetCardTypeByID(ctid);
            if (cardtype == null)
                cardtype = new ClubCardTypeVO();
            cardtype.CardTypeName = ctypename;
            cardtype.PackageDiscount = pdis;
            cardtype.PayDiscount = cdis;
            var data = GetValidata(cardtype);
            if(data.Success)
            {
                if(ctid>0)
                {
                    try
                    {
                        cardtype.LastModifiedDate = DateTime.Now;
                        cardtype.LastModifierID = Emp.UserName;
                        data.Success = ctmgm.EditCardType(cardtype);
                        if(data.Success)
                        {
                            data.Message = "会员卡类型更新成功";
                        }
                        else
                        {
                            data.Message = "会员卡类型更新失败";
                        }
                        
                    }
                    catch (Exception ex)
                    {
                        data.Success = false;
                        data.Message = "会员卡类型更新失败";
                        data.Error = ex.ToString();
                    }
                }
                else
                {
                    data.Success = false;
                    data.Message = "当前会员卡类型不能修改";
                }
               
            }

           
            return Json(data, JsonRequestBehavior.AllowGet);
        }
        public ReturnedData GetValidata(ClubCardTypeVO ctype)
        {
            ReturnedData data = new ReturnedData();
            if(!string.IsNullOrEmpty(ctype.CardTypeName))
            {
                data.Success = false;
                data.Message = "请输入会员卡类型";
            }
            if(ctype.PayDiscount<=0||ctype.PayDiscount>=1)
            {
                data.Success = false;
                data.Message = "充值折扣输入错误";
            }
            if(ctype.PackageDiscount<=0||ctype.PackageDiscount>=1)
            {
                data.Success = false;
                data.Message = "套餐折扣输入错误";
            }
            else
            {
                data.Success = true;
            }
            return data;
        }
        public JsonResult AddClubCardTypeModel()
        {
            IClubCardTypeMgm ctmgm = new ClubCardTypeMgm();
            
            string ctypename = NullHelper.Convert<string>(Request["ctype"], null);
            decimal cdis = NullHelper.Convert<decimal>(Request["cdiscount"], 0M);
            decimal pdis = NullHelper.Convert<decimal>(Request["pkgdiscount"], 0M);

            ClubCardTypeVO cardtype = new ClubCardTypeVO()
            {
                CardTypeName=ctypename,
                PackageDiscount=pdis,
                PayDiscount=cdis,
                CreatedDate=DateTime.Now,
                CreatorID=Emp.UserName,
                LastModifierID=Emp.UserName,
                LastModifiedDate=DateTime.Now
            };
            var data = GetValidata(cardtype);
            if (data.Success)
            {
                try
                {
                    ctmgm.AddCardType(cardtype);
                    data.Success = true;
                    data.Message = "会员卡类型添加成功";
                }
                catch (Exception ex)
                {
                    data.Success = false;
                    data.Message = "会员卡类型添加失败";
                    data.Error = ex.ToString();
                }
            }
           
            return Json(data, JsonRequestBehavior.AllowGet);
        }
	}
}