using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zeta.WisdCar.Model.Entity;
using Zeta.WisdCar.Model.VO;

namespace Zeta.WisdCar.Business.CustClubCardModule
{
    public interface ICustomerMgm
    {
        /// <summary>
        /// 根据查询条件获取客户信息
        /// 服务端分页
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        List<CustomerVO> GetCustomers(CustomerQueryEntity filter);

        /// <summary>
        /// 根据前端输入关键词（姓名或手机号码）查询客户信息
        /// 模糊查询
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        List<CustomerVO> GetCustomers(string key);

        /// <summary>
        /// 根据客户ID获取客户信息
        /// </summary>
        /// <returns></returns>
        CustomerVO GetCustomerByID(int custID);

        /// <summary>
        /// 检查手机号码是否存在
        /// true：存在
        /// false：不存在
        /// </summary>
        /// <param name="phoneNo"></param>
        /// <returns></returns>
        bool CheckPhoneNo(string phoneNo);

        /// <summary>
        /// 新增客户
        /// </summary>
        /// <param name="cust"></param>
        void AddCustomer(CustomerVO cust);

        /// <summary>
        /// 修改客户
        /// </summary>
        /// <param name="cust"></param>
        void EditCustomer(CustomerVO cust);
        /// <summary>
        /// 修改客户事务版
        /// </summary>
        /// <param name="cust"></param>
        bool EditCustomer(CustomerVO cust, CarVO car);
        /// <summary>
        /// 删除客户
        /// </summary>
        /// <param name="id"></param>
        void DelCustomer(int id);
        
        /// <summary>
        /// 添加客户和汽车
        /// </summary>
        /// <param name="customer"></param>
        /// <param name="car"></param>
        /// <returns></returns>
        int AddAllCustomer(CustomerVO customer, CarVO car);
        /// <summary>
        /// 手机号查询客户
        /// </summary>
        /// <param name="mno"></param>
        /// <returns></returns>
        CustomerVO GetCustomerByMobileNo(string mno);

        CustomerVO GetCustomerByCarNo(string carno);
    }
}
