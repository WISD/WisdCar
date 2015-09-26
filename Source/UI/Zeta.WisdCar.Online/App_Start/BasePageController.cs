using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Zeta.WisdCar.Business.BasicDataModule;
using Zeta.WisdCar.Model.PO;
using Zeta.WisdCar.Online.Models;

namespace Zeta.WisdCar.Online.App_Start
{
    public class BasePageController:Controller
    {
        public BasePageController()
        {
            
        }
        EmployeeViewModel emp;
        public EmployeeViewModel Emp
        {
            get {
                if (Session["loginUser"] != null)
                {
                    emp = Session["loginUser"] as EmployeeViewModel;
                }
                else
                {
                    emp = null;
                }
                return emp;
            }
           
           
        }
        public void SetLoginUser(EmployeePO empo)
        {
            emp = new EmployeeViewModel();
            StoreMgm storeMgm = new StoreMgm();
            emp.UserId = empo.EmployeeID;
            emp.UserName = empo.EmployeeNo;
            emp.Name = empo.Name;
            emp.StoreId = empo.StoreID;
            emp.StroeName = storeMgm.GetModel(empo.StoreID).StoreName;
            emp.UserPassword = empo.Reserved1;

            Session.Add("loginUser", emp);
        }
       
    }
}