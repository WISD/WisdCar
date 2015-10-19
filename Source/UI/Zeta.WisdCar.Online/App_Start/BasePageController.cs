using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Zeta.WisdCar.Business.BasicDataModule;
using Zeta.WisdCar.Business.MarktingPlanModule;
using Zeta.WisdCar.Infrastructure;
using Zeta.WisdCar.Model.PO;
using Zeta.WisdCar.Model.VO;
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
            emp.StroeName = storeMgm.GetStoreByID(empo.StoreID).StoreName;
            emp.UserPassword = empo.Reserved1;

            Session.Add("loginUser", emp);
        }
        /// <summary>
        /// 获取下拉列表集合
        /// </summary>
        /// <param name="type">下拉列表类型</param>
        /// <param name="nullopt">是否默认选项</param>
        /// <param name="key">默认选项显示内容</param>
        /// <param name="value">默认选项值</param>
        /// <returns></returns>
        public List<SelectListItem> GetddlList(DDLlist type, bool nullopt, string key, string value,params object[]where)
        {
            List<SelectListItem> ddllist = new List<SelectListItem>();
            if (nullopt)
            {
                if (string.IsNullOrEmpty(key))
                {
                    key = "--请选择--";
                    value = "-1";
                }
                ddllist.Add(new SelectListItem() { Text=key,Value=value,Selected=true});
            }
            switch(type)
            {
                case DDLlist.CardType: ddllist = GetClubCardType(ddllist, where);
                    break;
                case DDLlist.PkgItem: ddllist = GetConsumeItems(ddllist, where);
                    break;
                case DDLlist.Pkg: GetPackage(ddllist, where);
                    break;
            }
           
            return ddllist;
        }
        private List<SelectListItem> GetClubCardType(List<SelectListItem>ddllist,params object[]where)
        {
            IClubCardTypeMgm ctmgm = new ClubCardTypeMgm();
            List<ClubCardTypeVO> list = ctmgm.GetAllCardType();
            if (list.Count>0)
            {

                list.ForEach(ct =>
                {
                    if (ddllist.Count == 0)
                    {
                        ddllist.Add(new SelectListItem() { Text = ct.CardTypeName, Value = ct.ClubCardTypeID.ToString(), Selected = true });
                    }
                    else
                    {
                        ddllist.Add(new SelectListItem() { Text = ct.CardTypeName, Value = ct.ClubCardTypeID.ToString() });
                    }
                });
            }
            return ddllist;
        }
        private List<SelectListItem> GetConsumeItems(List<SelectListItem>ddllist,params object[]where)
        {
            ConsumeItemMgm conMgm = new ConsumeItemMgm();
            List<ConsumeItemVO> list = null;
            if (where != null)
            {
                list = conMgm.GetAllConsumeItems((int)where[0]);
            }
            else
            {
                list = conMgm.GetAllConsumeItems();
            }
            if (list.Count > 0)
            {
                if (ddllist.Count == 0)
                {
                    list.ForEach(ct =>
                    {
                        ddllist.Add(new SelectListItem() { Text = ct.ItemName, Value = ct.ItemID.ToString(), Selected = true });
                    });
                }

            }
            else
            {
                ddllist.Add(new SelectListItem() { Text = "无可添加消费项目", Value = "-1", Selected = true });
            }
            return ddllist;
        }
        private List<SelectListItem> GetPackage(List<SelectListItem>ddllist,params object[]where)
        {
            PackageMgm pkgMgm = new PackageMgm();
            List<PackageVO> list = pkgMgm.GetAllPackages();
            if(list.Count>0)
            {
                list.ForEach(ct => { ddllist.Add(new SelectListItem() { Text = ct.PackageName, Value = ct.PackageID.ToString() }); });
            }
            return ddllist;
        }
    }
}