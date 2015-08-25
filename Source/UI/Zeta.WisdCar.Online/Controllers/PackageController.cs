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

namespace Zeta.WisdCar.Online.Controllers
{
    public class PackageController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetAllPackages()
        {
            List<PackageVO> result = new List<PackageVO>();

            try
            {
                BizMocker mocker = new BizMocker();
                result = mocker.GetAllPackages();
                foreach (var item in result)
                {
                    item.DT_RowId = item.PackageID.ToString();
                    item.Operation = "<a href='javascript:void(0)' onclick='Package.Edit("
                        + item.DT_RowId + ")'><i class='fa fa-pencil'></i> 编辑</a>  | <a href='javascript:void(0)' onclick='Package.Del("
                        + item.DT_RowId + ")'><i class='fa fa-times'></i> 删除</a>";
                    item.TotalPriceDesc = item.TotalPrice.ToString() + " 元";
                    item.DetailOpt = "<a href='javascript:void(0)' onclick=\"Package.Detail("
                        + item.DT_RowId + ", '" + PageValidateHelper.FilterParams(item.PackageName) + "')\"><i class='fa fa-search'></i> 查看</a>";
                }
            }
            catch (Exception ex)
            {
                LogHandler.Error(ex.Message.ToString());
            }

            return Json(result, JsonRequestBehavior.AllowGet);
        }

        public ActionResult DetailItems()
        {
            try
            {
                string pkgName = NullHelper.Convert<string>(Request["pkgName"], "");
                int pkgID = NullHelper.Convert<int>(Request["id"], 0);
                ViewBag.PkgName = pkgName;
                ViewBag.PkgID = pkgID;
            }
            catch (Exception ex)
            {
                LogHandler.Error(ex.Message.ToString());
            }
            return View();
        }

        public JsonResult GetItemsByPkgId()
        {
            List<PkgItemsVO> result = new List<PkgItemsVO>();

            try
            {
                IPkgItemsMgm mocker = new BizMocker();
                result = mocker.GetItemsByPkgID(1);
                foreach (var item in result)
                {
                    item.DT_RowId = item.PackageItemID.ToString();
                    item.Operation = "<a href='javascript:void(0)' onclick='PackageItems.Del("
                        + item.DT_RowId + ")'><i class='fa fa-times'></i> 删除</a>";
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