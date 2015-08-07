using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zeta.WisdCar.Model.PO;
using Zeta.WisdCar.Repository.CRUD;

namespace Zeta.WisdCar.Repository.Impl
{
    public class CustomerData : ICustomerData
    {
        public void addCustomer(CustomerPO customer)
        {
            Customer custDB = new Customer();
            custDB.Add(customer);
        }
    }
}
