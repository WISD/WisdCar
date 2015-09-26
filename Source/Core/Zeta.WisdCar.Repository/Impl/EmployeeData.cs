using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zeta.WisdCar.Model.PO;
using Zeta.WisdCar.Repository.CRUD;

namespace Zeta.WisdCar.Repository.Impl
{
    public class EmployeeData : IEmployeeData
    {
        private Employee _daoEmployee = new Employee();
        public EmployeePO Login(EmployeePO emp)
        {
            return _daoEmployee.GetModelByEmployeeNo(emp.EmployeeNo);
        }

        public int ChangePassword(string id,string password)
        {
            return _daoEmployee.ChangePassword(id,password);
        }

        public System.Data.DataSet GetAllEmployees()
        {
            return _daoEmployee.GetList("");
        }

        public EmployeePO GetEmployeeByID(int employeeID)
        {
            return _daoEmployee.GetModel(employeeID);
        }

        public void AddEmployee(EmployeePO employee)
        {
            _daoEmployee.Add(employee);
        }

        public void EditEmployee(EmployeePO employee)
        {
            _daoEmployee.Update(employee);
        }


        public void DelEmployee(int id)
        {
            _daoEmployee.Delete(id);
        }
    }
}
