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
    public class ConsumeItemController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetAllConsumeItems()
        {
            List<ConsumeItemVO> result = new List<ConsumeItemVO>();

            try
            {
                BizMocker mocker = new BizMocker();
                result = mocker.GetAllConsumeItems();
                foreach (var item in result)
                {
                    item.DT_RowId = item.ItemID.ToString();
                    item.Operation = "<a href='javascript:void(0)' onclick='ConsumeItem.Edit("
                        + item.DT_RowId + ")'><i class='fa fa-pencil'></i> 编辑</a>  | <a href='javascript:void(0)' onclick='ConsumeItem.Del("
                        + item.DT_RowId + ")'><i class='fa fa-times'></i> 删除</a>";
                    item.ItemPriceDesc = item.ItemPrice.ToString() + " 元";
                }
            }
            catch (Exception ex)
            {
                LogHandler.Error(ex.Message.ToString());
            }

            return Json(result, JsonRequestBehavior.AllowGet);
        }

	}
}