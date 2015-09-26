using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zeta.WisdCar.Model.PO;
using Zeta.WisdCar.Model.VO;

namespace Zeta.WisdCar.Repository
{
    public interface IEmployeeData
    {
        /// <summary>
        /// 获取所有员工列表
        /// </summary>
        /// <returns></returns>
        DataSet GetAllEmployees();

        /// <summary>
        /// 根据员工ID获取员工
        /// </summary>
        /// <param name="employeeID"></param>
        /// <returns></returns>
        EmployeePO GetEmployeeByID(int employeeID);

        /// <summary>
        /// 新增员工
        /// </summary>
        /// <param name="employee"></param>
        void AddEmployee(EmployeePO employee);

        /// <summary>
        /// 修改员工
        /// </summary>
        /// <param name="employee"></param>
        void EditEmployee(EmployeePO employee);

        /// <summary>
        /// 删除员工
        /// </summary>
        /// <param name="id"></param>
        void DelEmployee(int id);
    }
}
