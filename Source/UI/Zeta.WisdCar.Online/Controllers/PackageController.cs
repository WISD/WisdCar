using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Zeta.WisdCar.Business;
using Zeta.WisdCar.Business.MarktingPlanModule;
using Zeta.WisdCar.Infrastructure;
using Zeta.WisdCar.Infrastructure.Helper;
using Zeta.WisdCar.Infrastructure.Log;
using Zeta.WisdCar.Model.VO;
using Zeta.WisdCar.Online.App_Start;
using Zeta.WisdCar.Online.Models;

namespace Zeta.WisdCar.Online.Controllers
{
    public class PackageController : BasePageController
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
                PackageMgm pkgMgm = new PackageMgm();
                //BizMocker mocker = new BizMocker();
                result = pkgMgm.GetAllPackages();
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
                string v = HttpUtility.UrlDecode(pkgName);
                ViewBag.PkgName = v;
                ViewBag.PkgID = pkgID;
            }
            catch (Exception ex)
            {
                LogHandler.Error(ex.Message.ToString());
            }
            return View();
        }
        //套餐基本信息页
        public ActionResult DetailPkg()
        {
           
            try
            {
                int pkgId = NullHelper.Convert<int>(Request["id"], -1);
                if(pkgId>0)
                {
                    PackageMgm pkgMgm = new PackageMgm();
                    var pkg = pkgMgm.GetPackageByID(pkgId);
                    ViewBag.pkgName = pkg.PackageName;
                    ViewBag.pkgPrice = pkg.TotalPrice;
                    ViewBag.pkgId = pkg.PackageID;
                }
                else
                {
                    ViewBag.pkgName = "";
                    ViewBag.pkgPrice = "";
                    ViewBag.pkgId = -1;
                }
            }
            catch(Exception ex)
            {
                LogHandler.Error(ex.Message.ToString());
            }
            return View();
        }
        //添加/修改 套餐基本信息
        public JsonResult SubPkg()
        {
            ReturnedData data = new ReturnedData();
            try
            {
                int id = NullHelper.Convert<int>(Request["id"], -1);
                string pkgName = NullHelper.Convert<string>(Request["pkgName"], "");
                decimal pkgPrice = NullHelper.Convert<decimal>(Request["pkgPrice"], 0M);

                if (id == -1)
                {
                    data = AddPkg(pkgName, pkgPrice);
                }
                else
                {
                    data = EditePkg(id, pkgName, pkgPrice);
                }
            }
            catch (Exception ex)
            {
                data.Success = false;
                data.Message = "出现错误，请联系维护人员";
                data.Error = ex.ToString();
                LogHandler.Error(ex.Message.ToString());
            }
            return Json(data,JsonRequestBehavior.AllowGet);
        }
        private ReturnedData AddPkg(string pkgName,decimal pkgPrice)
        {
            ReturnedData data = new ReturnedData();
            PackageMgm pkgMgm = new PackageMgm();
            PackageVO pkg = new PackageVO();
            pkg.PackageName = pkgName;
            pkg.TotalPrice = pkgPrice;
            pkg.CreatedDate = DateTime.Now;
            pkg.CreatorID = Emp.UserName;
            pkg.LastModifiedDate = DateTime.Now;
            pkg.LastModifierID = Emp.UserName;
            try
            {
                data.Data = pkgMgm.AddPackage(pkg);
                data.Success = true;
                data.Message = "套餐基本信息添加成功";
                LogHandler.Info("用户：" + Emp.UserName + "于 "+pkg.CreatedDate.ToString()+" 添加套餐基本信息，项目名：" + pkgName);
            }
            catch (Exception ex)
            {
                data.Success = false;
                data.Message = "套餐基本信息添加失败";
                data.Error = ex.ToString();
                LogHandler.Error("套餐基本信息添加错误：" + ex.Message.ToString());
            }
            return data;
        }
        private ReturnedData EditePkg(int id,string pkgName,decimal pkgPrice)
        {
            ReturnedData data = new ReturnedData();
            PackageMgm pkgMgm = new PackageMgm();
           
            try
            {
                var pkg = pkgMgm.GetPackageByID(id);
                if(pkg.PackageID>0)
                {
                    pkg.PackageName = pkgName;
                    pkg.TotalPrice = pkgPrice;
                    pkg.LastModifiedDate = DateTime.Now;
                    pkg.LastModifierID = Emp.UserName;
                    pkgMgm.EditPackage(pkg);
                    data.Success = true;
                    data.Message = "套餐基本信息修改成功";
                    LogHandler.Info("用户：" + Emp.UserName + "于 " + pkg.CreatedDate.ToString() + " 修改套餐基本信息，项目名：" + pkgName);
                }
                else
                {
                    data.Success = false;
                    data.Message = "所选套餐项目不存在,请刷新网页后重试";
                }
               
            }
            catch(Exception ex)
            {
                data.Success = false;
                data.Message = "套餐基本信息修改失败";
                LogHandler.Error("套餐基本信息修改错误：" + ex.Message.ToString());
            }
            return data;
        }
        public JsonResult DeletePackage(int id)
        {
            ReturnedData data = new ReturnedData();
            PackageMgm pkgMgm = new PackageMgm();
            try
            {
                pkgMgm.DelPackage(id);
                data.Success = true;
                data.Message = "套餐基本信息删除成功";
                LogHandler.Info("用户：" + Emp.UserName + "于 " + DateTime.Now.ToString() + " 删除套餐基本信息，项目id：" + id);
            }
            catch(Exception ex)
            {
                data.Success = false;
                data.Message = "套餐基础信息删除失败，请先删除该套餐下的消费项目后再尝试";
                data.Error = ex.ToString();
                LogHandler.Error("套餐基本信息删除错误：" + ex.Message.ToString());
            }
            return Json(data, JsonRequestBehavior.AllowGet);
        }
        public JsonResult GetItemsByPkgId()
        {
            List<PkgItemVO> result = new List<PkgItemVO>();

            try
            {
                int id = NullHelper.Convert<int>(Request["id"], -1);
                //var mocker = new BizMocker();
                PkgItemsMgm pkgItemMgm = new PkgItemsMgm();
                result = pkgItemMgm.GetItemsByPkgID(id);
                foreach (var item in result)
                {
                    item.DT_RowId = item.PackageItemID.ToString();
                    item.Operation = "<a href='javascript:void(0)' onclick=\"PackageItems.Del("
                        + item.DT_RowId + ",'" + PageValidateHelper.FilterParams(item.ItemName) + "')\"><i class='fa fa-times'></i> 删除</a>";
                }
            }
            catch (Exception ex)
            {
                LogHandler.Error(ex.Message.ToString());
            }

            return Json(result, JsonRequestBehavior.AllowGet);
        }
        public ActionResult PkgItemDetail()
        {
            string pkgName = NullHelper.Convert<string>(Request["pkgName"], "");
            int pkgID = NullHelper.Convert<int>(Request["id"], 0);
            ViewBag.PkgName = pkgName;
            ViewBag.PkgID = pkgID;
            ViewData["ConItem"] = GetddlList(DDLlist.PkgItem, false, null, null, pkgID);
            return View();
        }
        public JsonResult AddPkgItem()
        {
            ReturnedData data = new ReturnedData();

            try
            {
                int pkItemId = NullHelper.Convert<int>(Request["pkItemId"], 0);
                int pkgid = NullHelper.Convert<int>(Request["pkgId"], 0);
                int conNum = NullHelper.Convert<int>(Request["conNum"], 0);
                string pkgName = NullHelper.Convert<string>(Request["pkgName"], "");
                string itemName = NullHelper.Convert<string>(Request["itemName"], "");

                PkgItemsMgm pkgItMgm = new PkgItemsMgm();
                PkgItemVO pkgItem = new PkgItemVO();
                pkgItem.ItemID = pkItemId;
                pkgItem.PackageID = pkgid;
                pkgItem.ConsumeCount = conNum;
                pkgItem.CreatedDate = DateTime.Now;
                pkgItem.CreatorID = Emp.UserName;
                pkgItem.LastModifiedDate = DateTime.Now;
                pkgItem.LastModifierID = Emp.UserName;
                pkgItem.ItemName = itemName;

                pkgItMgm.AddPkgItem(pkgItem);
                data.Success = true;
                data.Message = "套餐消费项目添加成功";
                LogHandler.Info("用户：" + Emp.UserName + "于 " + DateTime.Now.ToString() + " 为套餐："+pkgName+" 添加消费项目："+itemName);
            }
            catch (Exception ex)
            {
                data.Success = false;
                data.Message = "套餐消费项目添加失败";
                data.Error = ex.ToString();
                LogHandler.Error(ex.Message.ToString()); 
            }
            return Json(data, JsonRequestBehavior.AllowGet);
        }
        public JsonResult DeletePkgItem(int id,string pkgName,string itemName)
        {
            PkgItemsMgm pkgItMgm = new PkgItemsMgm();
            ReturnedData data = new ReturnedData();
            try
            {
                pkgItMgm.DelPkgItem(id);
                data.Success = true;
                data.Message = "套餐项目删除成功";
                LogHandler.Info("用户：" + Emp.UserName + "于 " + DateTime.Now.ToString() + " 为套餐：" + pkgName + " 删除消费项目：" + itemName);
            }
            catch(Exception ex)
            {
                data.Success = false;
                data.Message = "套餐项目删除失败";
                data.Error = ex.ToString();
                LogHandler.Error(ex.Message.ToString());
            }
            return Json(data, JsonRequestBehavior.AllowGet);
        }
    }
}