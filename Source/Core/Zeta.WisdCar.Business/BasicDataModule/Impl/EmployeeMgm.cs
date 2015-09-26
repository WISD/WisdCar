using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zeta.WisdCar.Model.PO;
using Zeta.WisdCar.Model.VO;
using Zeta.WisdCar.Business.AutoMapper;
using AutoMapper;
using Zeta.WisdCar.Repository.Impl;

namespace Zeta.WisdCar.Business.BasicDataModule
{
    public class EmployeeMgm : IEmployeeMgm
    {
        public List<EmployeeVO> GetAllEmployees()
        {
            EmployeeData employeeData = new EmployeeData();
            List<EmployeeVO> employeeVOList = new List<EmployeeVO>();

            DataSet ds = employeeData.GetAllEmployees();

            List<EmployeePO> employeePOList = ds.GetEntity<List<EmployeePO>>();

            employeePOList.ForEach(i =>
            {
                employeeVOList.Add(Mapper.Map<EmployeePO, EmployeeVO>(i));
            });

            return employeeVOList;
        }

        public EmployeeVO GetEmployeeByID(int employeeID)
        {
            EmployeeData employeeData = new EmployeeData();
            EmployeeVO employeeVO = new EmployeeVO();
            EmployeePO employeePO = employeeData.GetEmployeeByID(employeeID);
            employeeVO = Mapper.Map<EmployeePO, EmployeeVO>(employeePO);

            return employeeVO;
        }

        public void AddEmployee(EmployeeVO employee)
        {
            EmployeeData employeeData = new EmployeeData();
            employeeData.AddEmployee(Mapper.Map<EmployeeVO, EmployeePO>(employee));
        }

        public void EditEmployee(EmployeeVO employee)
        {
            EmployeeData employeeData = new EmployeeData();
            employeeData.EditEmployee(Mapper.Map<EmployeeVO, EmployeePO>(employee));
        }

        public void DelEmployee(int id)
        {
            EmployeeData employeeData = new EmployeeData();
            employeeData.DelEmployee(id);
        }
    }
}
