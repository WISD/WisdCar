using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Zeta.WisdCar.Online.App_Start
{
    public class LoginCheckFilterAttribute : ActionFilterAttribute    
    {
        public bool IsCheck { get; set; }
        public override void  OnActionExecuting(ActionExecutingContext filterContext)
        {
            base.OnActionExecuting(filterContext);
            if (IsCheck)
            {
                //校验用户是否已经登录	       
                if (filterContext.HttpContext.Session["loginUser"] == null)
                {

                    //跳转到登陆页				   
                    filterContext.HttpContext.Response.Redirect("~/Employee/Login");

                }
               
            }
            
        }
    }
}