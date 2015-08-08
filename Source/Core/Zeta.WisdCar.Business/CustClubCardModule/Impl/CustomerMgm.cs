using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zeta.WisdCar.Model.VO;
using Zeta.WisdCar.Model.Entity;
using Zeta.WisdCar.Repository.Impl;
using System.Data;
using Zeta.WisdCar.Model.PO;
using AutoMapper;
using Zeta.WisdCar.Business.AutoMapper;

namespace Zeta.WisdCar.Business.CustClubCardModule
{
    public class CustomerMgm : ICustomerMgm
    {
        public List<CustomerVO> GetCustomers(CustomerQueryEntity filter)
        {
            CustomerData customerData = new CustomerData();
            List<CustomerVO> customerVOList = new List<CustomerVO>();

            DataSet ds = customerData.GetCustomers(filter);
            List<CustomerPO> customerPOList = ds.GetEntity<List<CustomerPO>>();

            customerPOList.ForEach(i =>
            {
                customerVOList.Add(Mapper.Map<CustomerPO, CustomerVO>(i));
            });

            return customerVOList;
        }

        public void AddCustomer(Model.VO.CustomerVO cust)
        {
            CustomerData customerData = new CustomerData();
            customerData.AddCustomer(Mapper.Map<CustomerVO, CustomerPO>(cust));
        }

        public void EditCustomer(Model.VO.CustomerVO cust)
        {
            CustomerData customerData = new CustomerData();
            customerData.EditCustomer(Mapper.Map<CustomerVO, CustomerPO>(cust));
        }

        public void DelCustomer(int id)
        {
            CustomerData customerData = new CustomerData();
            customerData.DelCustomer(id);
        }

        public Model.VO.CustomerVO GetCustomerByID(int custID)
        {
            CustomerData customerData = new CustomerData();
            CustomerVO customerVO = new CustomerVO();
            CustomerPO customerPO = customerData.GetCustomerByID(custID);
            customerVO = Mapper.Map<CustomerPO, CustomerVO>(customerPO);

            return customerVO;
        }
    }
}
