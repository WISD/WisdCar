﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zeta.WisdCar.Model.PO;
using Zeta.WisdCar.Infrastructure.Helper;
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
        public string Login(EmployeePO emp, out EmployeePO empdb)
        {

            var empdat = new EmployeeData();

            string spwd = StringHelper.MD5Encrypt(emp.Reserved1);
            empdb = empdat.Login(emp);
            string result = null;
            if (empdb == null)
            {
                return result = "用户名不存在";
            }
            if (empdb.Reserved1 != spwd)
            {
                return result = "密码错误";
            }

            return result;
        }
        public string ChangePassword(EmployeePO emp, string oldpwd, string password, out bool boolresult, out string spwd)
        {
            string result = "";
            boolresult = false;
            spwd = null;
            var empdat = new EmployeeData();
            if (emp.Reserved1 == StringHelper.MD5Encrypt(oldpwd))
            {
                var recount = empdat.ChangePassword(emp.EmployeeNo, StringHelper.MD5Encrypt(password));
                if (recount > 0)
                {
                    boolresult = true;
                    spwd = StringHelper.MD5Encrypt(password);
                    result = "密码修改成功";
                }
                else
                {
                    result = "密码修改失败";
                }
            }
            else
            {
                result = "原始密码不正确";
            }
            return result;
        }
    }
}
