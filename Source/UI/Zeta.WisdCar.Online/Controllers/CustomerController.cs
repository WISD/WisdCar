using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Zeta.WisdCar.Business;
using Zeta.WisdCar.Business.CustClubCardModule;
using Zeta.WisdCar.Business.CustClubCardModule.Impl;
using Zeta.WisdCar.Infrastructure;
using Zeta.WisdCar.Infrastructure.Helper;
using Zeta.WisdCar.Infrastructure.Log;
using Zeta.WisdCar.Model.Entity;
using Zeta.WisdCar.Model.VO;
using Zeta.WisdCar.Online.App_Start;
using Zeta.WisdCar.Online.Models;

namespace Zeta.WisdCar.Online.Controllers
{
    public class CustomerController : BasePageController
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
                string sortOrder = NullHelper.Convert<string>(Request[Constants.SORT_ORDER], "desc");
                int sortIdx = NullHelper.Convert<int>(Request[Constants.SORT_IDX], 0);
                string columnKey = string.Format(Constants.SORT_NAME, sortIdx);
                string sortName = NullHelper.Convert<string>(Request[columnKey], "CustomerID");
                if(sortName=="CardFlagDesc"||sortName=="ClubCardDesc"||sortName=="CarDesc"||sortName=="Operation")
                {
                    sortName = "CustomerID";
                }
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
                ICustomerMgm coustomer = new CustomerMgm();
                var list = coustomer.GetCustomers(filter);
                if (list == null)
                {
                    list = new List<CustomerVO>();
                }

                int recordsTotal = coustomer.GetRecordCount(filter);

                foreach (var item in list)
                {
                    item.DT_RowId = item.CustomerID.ToString();
                    if (item.CardFlag == 1)
                    {
                        item.CardFlagDesc = "<i class='fa fa-check fa-lg' style='color:green;'></i>";
                        item.ClubCardDesc = "<a href='javascript:void(0)' onclick='Customer.EditClubcard(" + item.DT_RowId + ")'><i class='fa fa-search'></i> 查看</a>";
                    }
                    else
                    {
                        item.CardFlagDesc = "<i class='fa fa-times fa-lg red' style='color:red;'></i>";
                        item.ClubCardDesc = "<a href='javascript:void(0)' onclick='Customer.AddCludcard(" + item.DT_RowId + ")'> <i class='fa fa-credit-card'></i> 开卡</a>";
                    }
                    item.CarDesc = "<a href='javascript:void(0)' onclick='Customer.EditCar(" + item.DT_RowId + ")'><i class='fa fa-search'></i> 查看</a>";
                    item.Operation = "<a href='javascript:void(0)' onclick='Customer.Edit("
                        + item.DT_RowId + ")'><i class='fa fa-pencil'></i> 编辑</a>  | <a href='javascript:void(0)' onclick='Customer.Del("
                        + item.DT_RowId + ")'><i class='fa fa-times'></i> 删除</a>";
                }

                result.draw = draw;
                result.recordsTotal = recordsTotal;
                result.recordsFiltered = recordsTotal;
                result.data = list;
            }
            catch (Exception ex)
            {
                result.data = new List<CustomerVO>();
                LogHandler.Error(ex.Message.ToString());
                result.error = ex.ToString();
            }

            return Json(result, JsonRequestBehavior.AllowGet);
        }

      

        #region 客户管理
        /// <summary>
        /// 删除客户
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public JsonResult DeleteCustomer(int id)
        {
            ICustomerMgm cusmgm = new CustomerMgm();
            ICarMgm carmgm = new CarMgm();
            ReturnedData data = new ReturnedData();
            try
            {
                cusmgm.DelCustomer(id);
                data.Message = "客户删除成功";
                data.Success = true;
            }
            catch (Exception ex)
            {
                data.Success = false;
                data.Message = "客户删除失败";
                data.Error = ex.ToString();

            }

            return Json(data, JsonRequestBehavior.AllowGet);
        }
        /// <summary>
        /// 客户详细信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult CustomerDetails(int id)
        {
            var result = new CustomerAndCar();
            if (id != -1)
            {
                ICustomerMgm couMgm = new CustomerMgm();
                ICarMgm carMgm = new CarMgm();
                CustomerVO customer = couMgm.GetCustomerByID(id);
                List<CarVO> car = new List<CarVO>();
                if (customer != null)
                {
                    car = carMgm.GetCarsByCustID(customer.CustomerID);
                    result = GetcusAndcarObj(customer, car.FirstOrDefault());
                }

            }


            return View(result);
        }
        /// <summary>
        /// 客户修改提交
        /// </summary>
        /// <param name="customerandcar"></param>
        /// <returns></returns>
        public JsonResult CustomerEdiSub(CustomerAndCar customerandcar)
        {
            
            ICustomerMgm customerMgm = new CustomerMgm();

            CustomerVO customer = new CustomerVO()
            {
                CustomerID = customerandcar.Customerid,
                Name = customerandcar.Name,
                Sex = customerandcar.Sex,
                ICNo = customerandcar.ICNo,
                Birthday = customerandcar.Birthday,
                LastModifiedDate = DateTime.Now,
                CreatorID = Emp.UserName,
                LastModifierID = Emp.UserName,
                MobileNO = customerandcar.MobileNo
            };

            CarVO car = new CarVO()
            {
                CarID = customerandcar.Carid,
                CustomerID = customerandcar.Customerid,
                CarNo = customerandcar.Carno,
                Brand = customerandcar.Brand,
                CarModel = customerandcar.Carmodel,
                Capacity = customerandcar.Capacity,
                Color = customerandcar.Color,
                FrameNo = customerandcar.FrameNo,
                EngineNo = customerandcar.EngineNo,
                MaintainKM = customerandcar.Maintainkm,
                InsureDate = customerandcar.Insuredate,
                ASDate = customerandcar.Asdate,
                LastModifiedDate = DateTime.Now,
                CreatorID = Emp.UserName,
                LastModifierID = Emp.UserName,
            };

            ReturnedData data = new ReturnedData();
            try
            {
                var result = customerMgm.EditCustomer(customer, car);
                if(result)
                {
                    data.Message = "客户修改成功";
                    data.Success = true;
                }
                else
                {
                    data.Success = false;
                    data.Message = "客户修改失败";
                }
               
            }
            catch (Exception ex)
            {
                data.Success = false;
                data.Message = "客户修改失败";
                data.Error = ex.ToString();

            }

            return Json(data, JsonRequestBehavior.AllowGet);
        }
        /// <summary>
        /// 添加客户提交
        /// </summary>
        /// <param name="cusandcar"></param>
        /// <returns></returns>
        public JsonResult AddCustomerSub(CustomerAndCar cusandcar)
        {
            
            ICustomerMgm customerMgm = new CustomerMgm();
            ICarMgm carMgm = new CarMgm();
            CustomerVO customer = new CustomerVO()
            {

                Name = cusandcar.Name,
                Sex = cusandcar.Sex,
                ICNo = cusandcar.ICNo,
                Birthday = cusandcar.Birthday,
                MobileNO = cusandcar.MobileNo,
                CreatorID = Emp.UserName,
                LastModifierID = Emp.UserName,
                CreatedDate = DateTime.Now,
                LastModifiedDate = DateTime.Now,
            };

            CarVO car = new CarVO()
            {

                CarNo = cusandcar.Carno,
                Brand = cusandcar.Brand,
                CarModel = cusandcar.Carmodel,
                Capacity = cusandcar.Capacity,
                Color = cusandcar.Color,
                FrameNo = cusandcar.FrameNo,
                EngineNo = cusandcar.EngineNo,
                MaintainKM = cusandcar.Maintainkm,
                InsureDate = cusandcar.Insuredate,
                ASDate = cusandcar.Asdate,
                CreatorID = Emp.UserName,
                LastModifierID = Emp.UserName,
                CreatedDate = DateTime.Now,
                LastModifiedDate = DateTime.Now,

            };

            ReturnedData data = new ReturnedData();
            try
            {
                car.CustomerID = customerMgm.AddAllCustomer(customer, car);
                //carMgm.AddCar(car);
                data.Message = "客户添加成功";
                data.Success = true;
            }
            catch (Exception ex)
            {
                data.Success = false;
                data.Message = "客户添加失败";
                data.Error = ex.ToString();

            }

            return Json(data, JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// 模型转换
        /// </summary>
        /// <param name="customer"></param>
        /// <param name="car"></param>
        /// <returns></returns>
        private CustomerAndCar GetcusAndcarObj(CustomerVO customer, CarVO car)
        {
            CustomerAndCar cusandcar = new CustomerAndCar();
            cusandcar.Customerid = customer.CustomerID;
            cusandcar.Name = customer.Name;
            cusandcar.Sex = customer.Sex;
            cusandcar.ICNo = customer.ICNo;
            cusandcar.Birthday = customer.Birthday;
            cusandcar.Carno = car.CarNo;
            cusandcar.Brand = car.Brand;
            cusandcar.Carmodel = car.CarModel;
            cusandcar.Capacity = car.Capacity;
            cusandcar.Color = car.Color;
            cusandcar.FrameNo = car.FrameNo;
            cusandcar.EngineNo = car.EngineNo;
            cusandcar.Maintainkm = car.MaintainKM;
            cusandcar.Insuredate = car.InsureDate;
            cusandcar.Asdate = car.ASDate;
            cusandcar.MobileNo = customer.MobileNO;
            cusandcar.Carid = car.CarID;
            return cusandcar;
        }
        
        #endregion
       
        #region 车辆信息
        /// <summary>
        /// 汽车信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult CusCarinfo(int id)
        {
            ////CarVO car = new CarVO();
            ICarMgm carmgm = new CarMgm();
            var result = carmgm.GetCarsByCustID(id);
            var car = new CarVO();
            if (result.Count>0)
            {
                car = result.FirstOrDefault();
            }
            car.CustomerID = id;
            return View(car);
        }

        /// <summary>
        /// 汽车修改提交
        /// </summary>
        /// <param name="car"></param>
        /// <returns></returns>
        public JsonResult CarEdiSub(CarVO car)
        {
           
            ICarMgm carMgm = new CarMgm();
            ReturnedData data = new ReturnedData();
            try
            {

                car.LastModifierID = Emp.UserName;

                car.LastModifiedDate = DateTime.Now;
                carMgm.EditCar(car);
                data.Message = "车辆信息修改成功";
                data.Success = true;
            }
            catch (Exception ex)
            {
                data.Success = false;
                data.Message = "车辆信息修改失败";
                data.Error = ex.ToString();

            }

            return Json(data, JsonRequestBehavior.AllowGet);
        } 
        #endregion
        #region 导入客户
        public ActionResult ImportCust()
        {
            return View();
        }
        public JsonResult ReceveFiles()
        {
            ReturnedData data = new ReturnedData();
            var cusMgm = new CustomerMgm();
            //excel.
            try
            {
                cusMgm.ImprotDataTosql(Request.Files["file"].InputStream, Emp.UserName);
                data.Success = true;
                data.Message = "客户数据导入成功";
            }
            catch(Exception ex)
            {
                data.Success = false;
                data.Message = ex.ToString();
            }
            
            
            return Json(data, JsonRequestBehavior.AllowGet);
        }
        #endregion

    }
}