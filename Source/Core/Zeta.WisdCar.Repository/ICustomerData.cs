﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zeta.WisdCar.Model.Entity;
using Zeta.WisdCar.Model.PO;
using Zeta.WisdCar.Model.VO;

namespace Zeta.WisdCar.Repository
{
    public interface ICustomerData
    {
        /// <summary>
        /// 根据查询条件获取客户信息
        /// 服务端分页
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        DataSet GetCustomers(CustomerQueryEntity filter);

        /// <summary>
        /// 根据前端输入关键词（姓名或手机号码）查询客户信息
        /// 模糊查询
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        DataSet GetCustomers(string key);

        /// <summary>
        /// 根据客户ID获取客户信息
        /// </summary>
        /// <returns></returns>
        CustomerPO GetCustomerByID(int custID);

        /// <summary>
        /// 新增客户
        /// </summary>
        /// <param name="cust"></param>
        void AddCustomer(CustomerPO cust);

        /// <summary>
        /// 修改客户
        /// </summary>
        /// <param name="cust"></param>
        void EditCustomer(CustomerPO cust);

        /// <summary>
        /// 删除客户
        /// </summary>
        /// <param name="id"></param>
        void DelCustomer(int id);

        /// <summary>
        /// 根据条件查询客户记录数
        /// </summary>
        /// <param name="strWhere"></param>
        /// <returns>int</returns>
        int GetRecordCount(string strWhere);
        #region fudongdong's function
         /// <summary>
        /// 添加客户和汽车
        /// </summary>
        /// <param name="cust"></param>
        /// <param name="car"></param>
        /// <returns></returns>
        int AddAllCustomer(CustomerPO cust, CarPO car);
        /// <summary>
        /// 修改客户信息带车辆信息。
        /// </summary>
        /// <param name="cust"></param>
        /// <param name="car"></param>
       bool EditCustomer(CustomerPO cust, CarPO car);
        /// <summary>
        /// 根据手机号码查询客户信息
        /// </summary>
        /// <param name="mno"></param>
        /// <returns></returns>
       CustomerPO GetCustomerByMobileNo(string mno);
        /// <summary>
        /// 根据车牌号查询客户信息
        /// </summary>
        /// <param name="carno"></param>
        /// <returns></returns>
       CustomerPO GetCustomerByCarNo(string carno);
        #endregion
    }
}
