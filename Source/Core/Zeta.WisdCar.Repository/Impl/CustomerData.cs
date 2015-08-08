using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zeta.WisdCar.Model.Entity;
using Zeta.WisdCar.Model.PO;
using Zeta.WisdCar.Repository.CRUD;

namespace Zeta.WisdCar.Repository.Impl
{
    public class CustomerData : ICustomerData
    {
        public System.Data.DataSet GetCustomers(CustomerQueryEntity filter)
        {
            throw new NotImplementedException();
        }

        public CustomerPO GetCustomerByID(int custID)
        {
            throw new NotImplementedException();
        }

        public void AddCustomer(CustomerPO cust)
        {
            throw new NotImplementedException();
        }

        public void EditCustomer(CustomerPO cust)
        {
            throw new NotImplementedException();
        }

        public void DelCustomer(int id)
        {
            throw new NotImplementedException();
        }
    }
}
