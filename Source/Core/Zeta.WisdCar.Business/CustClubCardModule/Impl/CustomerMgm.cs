using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zeta.WisdCar.Model.VO;
using Zeta.WisdCar.Model.Entity;

namespace Zeta.WisdCar.Business.CustClubCardModule
{
    public class CustomerMgm : ICustomerMgm
    {
        public List<CustomerVO> GetCustomers(CustomerQueryEntity filter)
        {
            throw new NotImplementedException();
        }

        public void AddCustomer(Model.VO.CustomerVO cust)
        {
            throw new NotImplementedException();
        }

        public void EditCustomer(Model.VO.CustomerVO cust)
        {
            throw new NotImplementedException();
        }

        public void DelCustomer(int id)
        {
            throw new NotImplementedException();
        }

        public Model.VO.CustomerVO GetCustomerByID(int custID)
        {
            throw new NotImplementedException();
        }
    }
}
