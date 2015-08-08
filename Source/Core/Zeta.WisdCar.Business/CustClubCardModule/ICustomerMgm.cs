using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        List<CustomerVO> GetCustomers(CustomerQueryVO filter);

        /// <summary>
        /// 根据客户ID获取客户信息
        /// </summary>
        /// <returns></returns>
        CustomerVO GetCustomerByID(int custID);

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
        /// 删除客户
        /// </summary>
        /// <param name="id"></param>
        void DelCustomer(int id);
    }
}
