using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zeta.WisdCar.Model.VO;

namespace Zeta.WisdCar.Business.BasicDataModule
{
    public interface IEmployeeMgm
    {
        /// <summary>
        /// 获取所有员工列表
        /// </summary>
        /// <returns></returns>
        List<EmployeeVO> GetAllEmployees();

        /// <summary>
        /// 根据员工ID获取员工
        /// </summary>
        /// <param name="employeeID"></param>
        /// <returns></returns>
        EmployeeVO GetEmployeeByID(int employeeID);

        /// <summary>
        /// 新增员工
        /// </summary>
        /// <param name="employee"></param>
        void AddEmployee(EmployeeVO employee);

        /// <summary>
        /// 修改员工
        /// </summary>
        /// <param name="employee"></param>
        void EditEmployee(EmployeeVO employee);

        /// <summary>
        /// 删除员工
        /// </summary>
        /// <param name="id"></param>
        void DelEmployee(int id);
    }
}
