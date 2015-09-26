using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Zeta.WisdCar.Business.BasicDataModule;
using Zeta.WisdCar.Model.PO;
using Zeta.WisdCar.Online.App_Start;
using Zeta.WisdCar.Online.Models;

namespace Zeta.WisdCar.Online.Controllers
{
    public class EmployeeController : BasePageController
    {
        //
        // GET: /Employee/
        public ActionResult Index()
        {
            return View();
        }
        [LoginCheckFilterAttribute(IsCheck = false)]
        public ActionResult Login()
        {
            return View();
        }
        [LoginCheckFilterAttribute(IsCheck = false)]
        [HttpPost]
        public JsonResult LoginSub(EmployeePO emp)
        {
            IEmployeeMgm empMgm = new EmployeeMgm();

            ReturnedData data = new ReturnedData();
            EmployeePO empdb = new EmployeePO();
            try
            {
                string spwd;
                var result = empMgm.Login(emp,out empdb);
                if(result==null)
                {
                    data.Success = true;
                    if(empdb!=null)
                    {
                        SetLoginUser(empdb);
                    }
                    
                }
                else
                {
                    data.Success = false;
                    
                }
                data.Message = result;
                
            }
            catch (Exception ex)
            {
                data.Success = false;
                data.Message = "出现错误，请联系维护人员";
                data.Error = ex.ToString();

            }
            return Json(data, JsonRequestBehavior.AllowGet);
           

            
        }
        
        public ActionResult ResetPassword()
        { 
            return View();
        }
        public JsonResult ResetPwdsub(string oldpwd,string password)
        {
            IEmployeeMgm empMgm = new EmployeeMgm();

            ReturnedData data = new ReturnedData();
            try
            {
                var emp = Session["loginUser"] as EmployeeViewModel;
                bool boolresult;
                string spwd;
                var emppo = new EmployeePO() 
                {
                    EmployeeID=emp.UserId,
                    EmployeeNo=emp.UserName,
                    Reserved1=emp.UserPassword,
                    StoreID=emp.StoreId,
                    Name=emp.Name
                };
                var result = empMgm.ChangePassword(emppo,oldpwd,password,out boolresult,out spwd);
                data.Success = boolresult;
                data.Message = result;
                if (boolresult)
                {
                    emppo.Reserved1 = spwd;
                    SetLoginUser(emppo);
                }
            }
            catch (Exception ex)
            {
                data.Success = false;
                data.Message = "出现错误，请联系维护人员";
                data.Error = ex.ToString();

            }
            return Json(data, JsonRequestBehavior.AllowGet);
        }
        public ActionResult SinOut()
        {
            Session["loginUser"] = null;
            return RedirectToAction("Login");
        }
	}
}