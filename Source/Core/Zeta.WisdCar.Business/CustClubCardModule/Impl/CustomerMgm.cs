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
            if(customerPOList==null)
            {
                customerPOList = new List<CustomerPO>();
            }
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
        public bool EditCustomer(Model.VO.CustomerVO cust, Model.VO.CarVO car)
        {
            CustomerData customerData = new CustomerData();
            return customerData.EditCustomer(Mapper.Map<CustomerVO, CustomerPO>(cust), Mapper.Map<CarVO, CarPO>(car));
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



        public List<CustomerVO> GetCustomers(string key)
        {
            CustomerData customerData = new CustomerData();
            List<CustomerVO> customerVOList = new List<CustomerVO>();

            DataSet ds = customerData.GetCustomers(key);
            List<CustomerPO> customerPOList = ds.GetEntity<List<CustomerPO>>();

            customerPOList.ForEach(i =>
            {
                customerVOList.Add(Mapper.Map<CustomerPO, CustomerVO>(i));
            });

            return customerVOList;
        }

        public bool CheckPhoneNo(string phoneNo)
        {
            CustomerData customerData = new CustomerData();

            StringBuilder strSql = new StringBuilder();
            string strWhere = "";
            if (!string.IsNullOrEmpty(phoneNo.Trim()))
            {
                strSql.AppendFormat(" MobileNO = '{0}' ", phoneNo);
            }

            strWhere = strSql.ToString();
            int cnt = customerData.GetRecordCount(strWhere);

            if (cnt > 0)
                return true;
            else
                return false;
        }
        public int AddAllCustomer(CustomerVO cust, CarVO car)
        {
            CustomerData customerData = new CustomerData();
            var result = customerData.AddAllCustomer(Mapper.Map<CustomerVO, CustomerPO>(cust), Mapper.Map<CarVO, CarPO>(car));
            if (result <= 0)
            {
                throw new Exception("添加出现错误");
            }
            return result;
        }



        public CustomerVO GetCustomerByMobileNo(string mno)
        {
            CustomerData custdata = new CustomerData();
            CustomerPO result = custdata.GetCustomerByMobileNo(mno);
            if (result != null)
            {
                return Mapper.Map<CustomerPO, CustomerVO>(result);
            }
            else
            {
                return new CustomerVO();
            }

        }
        public CustomerVO GetCustomerByCarNo(string carno)
        {
            CustomerData custdata = new CustomerData();
            CustomerPO result = custdata.GetCustomerByCarNo(carno);
            if (result != null)
            {
                return Mapper.Map<CustomerPO, CustomerVO>(result);
            }
            else
            {
                return new CustomerVO();
            }
        }
    }
}
