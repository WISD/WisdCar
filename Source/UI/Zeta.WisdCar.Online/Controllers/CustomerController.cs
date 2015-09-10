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
                ICustomerMgm coustomer = new CustomerMgm();
                var list = coustomer.GetCustomers(filter);
                if (list == null)
                {
                    list = new List<CustomerVO>();
                }
                //var mocker = new BizMocker();
                //var list = mocker.GetCustomers(filter);
                //if (cardFlag != -1)
                //{
                //    list = list.Where(a => a.CardFlag == cardFlag).ToList();
                //}
                //list = list.Where(a => cardFlag == -1 || a.CardFlag == cardFlag).ToList();
                int recordsTotal = list.Count;

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
        //public JsonResult GetOneCustomer()
        //{
        //    var result = new BizMocker().GetCustomerByID(1);

        //    return Json(result, JsonRequestBehavior.AllowGet);
        //}
        
        public ActionResult Cuscardinfo(int id)
        {
            //var result = new BizMocker().GetCustomerByID(1);
            ICustomerMgm cusmgm = new CustomerMgm();
            var result = cusmgm.GetCustomerByID(id);
            if(result==null)
            {
                result = new CustomerVO();
            }
            return View(result);
        }
       
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
        
        public ActionResult CusCarinfo(int id)
        {
            ////CarVO car = new CarVO();
            ICarMgm carmgm = new CarMgm();
            var result = carmgm.GetCarsByCustID(id);
            if(result==null)
            {
                result = new CarVO();
            }
            result.CustomerID = id;
            return View(result);
        }
        
        public ActionResult CustomerDetails(int id)
        {
            var result = new CustomerAndCar();
            if (id != -1)
            {
                ICustomerMgm couMgm = new CustomerMgm();
                ICarMgm carMgm = new CarMgm();
                CustomerVO customer = couMgm.GetCustomerByID(id);
                CarVO car = new CarVO();
                if(customer!=null)
                {
                    car= carMgm.GetCarsByCustID(customer.CustomerID);
                    result = GetcusAndcarObj(customer, car);
                }
                
            }

            
            return View(result);
        }
        public JsonResult CustomerEdiSub(CustomerAndCar customerandcar)
        {
            ICustomerMgm customerMgm = new CustomerMgm();
            ICarMgm carMgm = new CarMgm();
            CustomerVO customer = new CustomerVO()
            {
                CustomerID = customerandcar.Customerid,
                Name = customerandcar.Name,
                Sex = customerandcar.Sex,
                ICNo = customerandcar.ICNo,
                Birthday = customerandcar.Birthday,
                LastModifiedDate = DateTime.Now,
                CreatorID = "10010",
                LastModifierID = "10010",
                MobileNO=customerandcar.MobileNo
            };

            CarVO car = new CarVO()
            {
                CarID=customerandcar.Carid,
                CustomerID = customerandcar.Customerid,
                CarNo = customerandcar.Carno,
                Brand = customerandcar.Brand,
                CarModel = customerandcar.Carmodel,
                Capacity = customerandcar.Capacity,
                Color = customerandcar.Color,
                FrameNo = customerandcar.Frameno,
                EngineNo = customerandcar.Engineno,
                MaintainKM = customerandcar.Maintainkm,
                InsureDate = customerandcar.Insuredate,
                ASDate = customerandcar.Asdate,
                LastModifiedDate = DateTime.Now,
                CreatorID = "10010",
                LastModifierID = "10010",
            };

            ReturnedData data = new ReturnedData();
            try
            {
                customerMgm.EditCustomer(customer);
                carMgm.EditCar(car);
                data.Message = "客户修改成功";
                data.Success = true;
            }
            catch (Exception ex)
            {
                data.Success = false;
                data.Message = "客户修改成功";
                data.Error = ex.ToString();

            }

            return Json(data, JsonRequestBehavior.AllowGet);
        }
        public JsonResult CustomerCardEdiSub(CustomerVO customer)
        {
            ICustomerMgm cusmgm = new CustomerMgm();
            ReturnedData data = new ReturnedData();
            try
            {
                 customer.LastModifiedDate = DateTime.Now;
                 customer.CardFlag = 1;
                 customer.LastModifierID = "10010";
                cusmgm.EditCustomer(customer);
                data.Message = "会员信息修改成功";
                data.Success = true;
            }
            catch (Exception ex)
            {
                data.Success = false;
                data.Message = "会员信息修改失败";
                data.Error = ex.ToString();

            }

            return Json(data, JsonRequestBehavior.AllowGet);
        }
        public JsonResult CarEdiSub(CarVO car)
        {
            ICarMgm carMgm = new CarMgm();
            ReturnedData data = new ReturnedData();
            try
            {
                
                car.LastModifierID = "10010";
                
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
        public JsonResult AddClubcardSub(ClubCardVO clubcard)
        {

            IClubCardMgm clubCardMgm = new ClubCardMgm();
            clubcard.CreatedDate = DateTime.Now;
            clubcard.LastModifiedDate = DateTime.Now;
            clubcard.SalesTime = DateTime.Now;
            clubcard.ExpireDate = Convert.ToDateTime("2021-10-20");
            clubcard.CreatorID = "10010";
            clubcard.LastModifierID = "10010";
            clubcard.ClubCardTypeID =clubcard.ClubCardTypeName=="金卡"? 1:2;
            clubcard.ClubCardPwd = "123456";
            clubcard.OpenCardStore = "苏州4s店";
            clubcard.SalesMan = "符冬冬";
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

            return Json(data, JsonRequestBehavior.AllowGet);
        }
        public JsonResult AddCustomerSub(CustomerAndCar cusandcar)
        {
          
            ICustomerMgm customerMgm = new CustomerMgm();
            ICarMgm carMgm = new CarMgm();
            CustomerVO customer = new CustomerVO() { 
               
                Name=cusandcar.Name,
                Sex=cusandcar.Sex,
                ICNo = cusandcar.ICNo,
                Birthday =cusandcar.Birthday,
                MobileNO=cusandcar.MobileNo,
                CreatorID="10010",
                LastModifierID="10010",
                CreatedDate = DateTime.Now,
                LastModifiedDate = DateTime.Now,
            };
            
            CarVO car = new CarVO() { 
                
                CarNo=cusandcar.Carno,
                Brand=cusandcar.Brand,
                CarModel = cusandcar.Carmodel,
                Capacity = cusandcar.Capacity,
                Color = cusandcar.Color,
                FrameNo = cusandcar.Frameno,
                EngineNo = cusandcar.Engineno,
                MaintainKM = cusandcar.Maintainkm,
                InsureDate = cusandcar.Insuredate,
                ASDate = cusandcar.Asdate,
                CreatorID = "10010",
                LastModifierID = "10010",
                CreatedDate=DateTime.Now,
                LastModifiedDate=DateTime.Now,
                
            };
            
            ReturnedData data = new ReturnedData();
            try
            {
                car.CustomerID= customerMgm.AddAllCustomer(customer);
                carMgm.AddCar(car);
                data.Message = "客户添加成功";
                data.Success = true;
            }
            catch (Exception ex)
            {
                data.Success = false;
                data.Message = "客户添加失败|"+ex.ToString();
                data.Error = ex.ToString();

            }

            return Json(data, JsonRequestBehavior.AllowGet);
        }
        
        public ActionResult AddClubCard(int id)
        {
            ICustomerMgm cusMgm = new CustomerMgm();
            CustomerVO cuctomer = cusMgm.GetCustomerByID(id);
            ClubCardVO clubcard = new ClubCardVO() { 
                CustName=cuctomer.Name,
                MobileNo=cuctomer.MobileNO,
                CustomerID=cuctomer.CustomerID
            };
            return View(clubcard);
        }
        private CustomerAndCar GetcusAndcarObj(CustomerVO customer, CarVO car)
        {
            CustomerAndCar cusandcar = new CustomerAndCar();
            cusandcar.Name = customer.Name;
            cusandcar.Sex = customer.Sex;
            cusandcar.ICNo = customer.ICNo;
            cusandcar.Birthday = customer.Birthday;
            cusandcar.Carno = car.CarNo;
            cusandcar.Brand = car.Brand;
            cusandcar.Carmodel = car.CarModel;
            cusandcar.Capacity = car.Capacity;
            cusandcar.Color = car.Color;
            cusandcar.Frameno = car.FrameNo;
            cusandcar.Engineno = car.EngineNo;
            cusandcar.Maintainkm = car.MaintainKM;
            cusandcar.Insuredate = car.InsureDate;
            cusandcar.Asdate = car.ASDate;
            cusandcar.MobileNo = customer.MobileNO;
            return cusandcar;
        }
	}
}