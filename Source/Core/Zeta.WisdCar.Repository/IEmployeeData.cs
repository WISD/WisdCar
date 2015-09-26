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
        /// ��ȡ����Ա���б�
        /// </summary>
        /// <returns></returns>
        DataSet GetAllEmployees();

        /// <summary>
        /// ����Ա��ID��ȡԱ��
        /// </summary>
        /// <param name="employeeID"></param>
        /// <returns></returns>
        EmployeePO GetEmployeeByID(int employeeID);

        /// <summary>
        /// ����Ա��
        /// </summary>
        /// <param name="employee"></param>
        void AddEmployee(EmployeePO employee);

        /// <summary>
        /// �޸�Ա��
        /// </summary>
        /// <param name="employee"></param>
        void EditEmployee(EmployeePO employee);

        /// <summary>
        /// ɾ��Ա��
        /// </summary>
        /// <param name="id"></param>
        void DelEmployee(int id);
    }
}
