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
    public class EmployeeController : Controller
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
            try
            {
                string spwd;
                var result = empMgm.Login(emp,out spwd);
                if(result==null)
                {
                    data.Success = true;
                    emp.Reserved1 = spwd;
                    Session.Add("loginUser", emp);
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
                EmployeePO emp = Session["loginUser"] as EmployeePO;
                bool boolresult;
                string spwd;
                var result = empMgm.ChangePassword(emp,oldpwd,password,out boolresult,out spwd);
                data.Success = boolresult;
                data.Message = result;
                if (boolresult)
                {
                    emp.Reserved1 = spwd;
                    Session.Add("loginUser", emp);
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