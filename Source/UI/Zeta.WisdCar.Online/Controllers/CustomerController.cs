using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Zeta.WisdCar.Business;
using Zeta.WisdCar.Business.CustClubCardModule;
using Zeta.WisdCar.Infrastructure;
using Zeta.WisdCar.Infrastructure.Helper;
using Zeta.WisdCar.Infrastructure.Log;
using Zeta.WisdCar.Model.Entity;
using Zeta.WisdCar.Model.VO;
using Zeta.WisdCar.Online.Models;

namespace Zeta.WisdCar.Online.Controllers
{
    public class CustomerController : Controller
    {
        //
        // GET: /Customer/
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult GetCustomers()
        {
            DatatablesResult<CustomerVO> result = new DatatablesResult<CustomerVO>();

            try
            {
                int start = NullHelper.Convert<int>(Request[Constants.PAGE_START], 0);
                int length = NullHelper.Convert<int>(Request[Constants.PAGE_LENGTH], 10);
                int draw = NullHelper.Convert<int>(Request[Constants.REQ_DRAW], 1);
                string sortOrder = NullHelper.Convert<string>(Request[Constants.SORT_ORDER], "asc");
                int sortIdx = NullHelper.Convert<int>(Request[Constants.SORT_IDX], 0);
                string columnKey = string.Format(Constants.SORT_NAME, sortIdx);
                string sortName = NullHelper.Convert<string>(Request[columnKey], "Name");

                string name = NullHelper.Convert<string>(Request["Name"], "");
                string icNo = NullHelper.Convert<string>(Request["ICNo"], "");
                string mobileNo = NullHelper.Convert<string>(Request["MobileNo"], "");
                int cardFlag = NullHelper.Convert<int>(Request["CardFlag"], -1);

                CustomerQueryEntity filter = new CustomerQueryEntity(){
                    Start = start,
                    Length = length,
                    SortOrder = sortOrder,
                    SortName = sortName,
                    Name = name,
                    ICNo = icNo,
                    MobileNo = mobileNo,
                    CardFlag = cardFlag
                };

                var mocker = new BizMocker();
                var list = mocker.GetCustomers(filter);
                int recordsTotal = list.Count;

                foreach (var item in list)
                {
                    item.DT_RowId = item.CustomerID.ToString();
                    if (item.CardFlag == 1)
                    {
                        item.CardFlagDesc = "<i class='fa fa-check fa-lg' style='color:green;'></i>";
                        item.ClubCardDesc = "<a href='javascript:void(0)'><i class='fa fa-search'></i> 查看</a>";
                    }
                    else
                    {
                        item.CardFlagDesc = "<i class='fa fa-times fa-lg red' style='color:red;'></i>";
                        item.ClubCardDesc = "<a href='javascript:void(0)'> <i class='fa fa-credit-card'></i> 开卡</a>";
                    }
                    item.CarDesc = "<a href='javascript:void(0)'><i class='fa fa-search'></i> 查看</a>";
                    item.Operation = "<a href='javascript:void(0)' onclick='Customer.Edit("
                        + item.DT_RowId + ")'><i class='fa fa-pencil'></i> 编辑</a>  | <a href='javascript:void(0)' onclick='Package.Del("
                        + item.DT_RowId + ")'><i class='fa fa-times'></i> 删除</a>";
                }

                result.draw = draw;
                result.recordsTotal = recordsTotal;
                result.recordsFiltered = recordsTotal;
                result.data = list;
            }
            catch (Exception ex)
            {
                LogHandler.Error(ex.Message.ToString());
            }

            return Json(result, JsonRequestBehavior.AllowGet);
        }
	}
}