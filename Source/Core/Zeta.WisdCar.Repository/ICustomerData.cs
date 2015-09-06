using System;
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
    }
}
