using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Zeta.WisdCar.Business;
using Zeta.WisdCar.Infrastructure.Log;
using Zeta.WisdCar.Model.VO;

namespace Zeta.WisdCar.Online.Controllers
{
    public class ClubcardTypeController : Controller
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
                BizMocker mocker = new BizMocker();
                result = mocker.GetAllCardType();
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
	}
}