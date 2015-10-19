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
    public class ConsumeItemController : BasePageController
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
                
                IConsumeItemMgm consMgm = new ConsumeItemMgm();
                result = consMgm.GetAllConsumeItems();
                //BizMocker mocker = new BizMocker();
                //result = mocker.GetAllConsumeItems();
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
        public JsonResult AddConsumeItem()
        {
            string itemName = NullHelper.Convert<string>(Request["citemName"], "");
            decimal itemPrice = NullHelper.Convert<decimal>(Request["citemPrice"], 0M);

            ConsumeItemVO conItem = new ConsumeItemVO();
            conItem.ItemName = itemName;
            conItem.ItemPrice = itemPrice;
            conItem.LastModifiedDate = DateTime.Now;
            conItem.LastModifierID = Emp.UserName;
            conItem.CreatedDate = DateTime.Now;
            conItem.CreatorID = Emp.UserName;

            ReturnedData data = new ReturnedData();
            IConsumeItemMgm conMgm = new ConsumeItemMgm();
            try
            {
                conMgm.AddConsumeItem(conItem);
                data.Success = true;
                data.Message = "消费项目添加成功";
                LogHandler.Info("员工" + Emp.UserName + "添加一条消费项目，项目名："+itemName );
            }
            catch(Exception ex)
            {
                data.Success = false;
                data.Message = "消费项目添加失败";
                LogHandler.Error("添加消费项目出现错误：" + (ex.Message.ToString()));
                data.Error = ex.ToString();
            }
            return Json(data,JsonRequestBehavior.AllowGet);
        }
        public JsonResult GetConsumeitemModel(int id)
        {
            IConsumeItemMgm conMgm = new ConsumeItemMgm();
            ReturnedData data = new ReturnedData();
            try
            {
                var result = conMgm.GetConsumeItemByID(id);
                data.Success = true;
                data.Data = result;
            }
            catch(Exception ex)
            {
                data.Success = false;
                data.Error = ex.ToString();
                data.Message = "网络错误，请稍后重试";
                LogHandler.Error("获取一项消费项目信息出现错误：" + (ex.Message.ToString()));
            }

            return Json(data,JsonRequestBehavior.AllowGet);
        }
        public JsonResult EditConsumeItem()
        {
            ReturnedData data = new ReturnedData();
            IConsumeItemMgm conMgm = new ConsumeItemMgm();
            try
            {
                int id = NullHelper.Convert<int>(Request["id"], 0);
                string itemName = NullHelper.Convert<string>(Request["citemName"], "");
                decimal itemPrice = NullHelper.Convert<decimal>(Request["citemPrice"], 0M); 

                var result = conMgm.GetConsumeItemByID(id);
                if (result != null)
                {
                    result.ItemName = itemName;
                    result.ItemPrice = itemPrice;
                    result.LastModifierID = Emp.UserName;
                    result.LastModifiedDate = DateTime.Now;
                    conMgm.EditConsumeItem(result);
                    data.Success = true;
                    data.Message = "消费项目修改成功";
                    LogHandler.Info("员工" + Emp.UserName + "修改一条消费项目，项目id：" + id);
                }
                else
                {
                    data.Success = false;
                    data.Message = "该消费项目不存在";
                }

            }
            catch (Exception ex)
            {
                data.Success = false;
                data.Message = "消费项目修改失败";
                data.Error = ex.ToString();
                LogHandler.Error("修改消费项目出现错误：" + (ex.Message.ToString()));
                throw;
            }
            return Json(data,JsonRequestBehavior.AllowGet);
        }
        public JsonResult DeleteConsumeItem(int id)
        {
            IConsumeItemMgm conMgm = new ConsumeItemMgm();
            ReturnedData data = new ReturnedData();
            try
            {
                conMgm.DelConsumeItem(id);
                data.Success = true;
                data.Message = "消费项目删除成功";
                LogHandler.Info("员工"+Emp.UserName+"删除一条消费项目，项目id："+id);
            }
            catch(Exception ex)
            {
                data.Success = false;
                data.Message = "消费项目删除失败";
                LogHandler.Error("删除消费项目出现错误：" + (ex.Message.ToString()));
                data.Error = ex.ToString();
            }
            return Json(data,JsonRequestBehavior.AllowGet);
        }
        public JsonResult GetConsumeItem()
        {
            ReturnedData data = new ReturnedData();
            try
            {
                int itemId = NullHelper.Convert<int>(Request["itemId"], 0);
                ConsumeItemMgm conMgm = new ConsumeItemMgm();
                var conItem = conMgm.GetConsumeItemByID(itemId);
                data.Data = conItem;
                data.Success = true;
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
       
	}
}