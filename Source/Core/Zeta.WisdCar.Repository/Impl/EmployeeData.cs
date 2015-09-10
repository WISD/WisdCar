using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zeta.WisdCar.Model.PO;
using Zeta.WisdCar.Repository.CRUD;

namespace Zeta.WisdCar.Repository.Impl
{
    public class EmployeeData:IEployeeData
    {
        private Employee _daoEmployee = new Employee();
        public EmployeePO Login(EmployeePO emp)
        {
            return _daoEmployee.GetModel(emp.EmployeeNo);
        }
        public int ChangePassword(int id,string password)
        {
            return _daoEmployee.ChangePassword(id,password);
        }
    }
}
