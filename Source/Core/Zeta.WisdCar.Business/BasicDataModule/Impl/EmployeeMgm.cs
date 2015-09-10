using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using Zeta.WisdCar.Model.PO;
using Zeta.WisdCar.Repository.Impl;
using Zeta.WisdCar.Repository;
using System.Security.Cryptography;

namespace Zeta.WisdCar.Business.BasicDataModule
{
    public class EmployeeMgm : IEmployeeMgm
    {
        public string Login(EmployeePO emp,out string spwd)
        {
           
            var empdat = new EmployeeData();

            spwd = MD5Encrypt(emp.Reserved1);
            var empdb = empdat.Login(emp);
            string result=null;
            if(empdb==null)
            {
                return result = "用户名不存在";
            }
            if(empdb.Reserved1!=spwd)
            {
                return result = "密码错误";
            }
            return result;
        }
        public string ChangePassword(EmployeePO emp,string oldpwd,string password,out bool boolresult,out string spwd)
        {
            string result = "";
            boolresult = false;
            spwd = null;
            var empdat = new EmployeeData();
            if(emp.Reserved1==MD5Encrypt(oldpwd))
            {
                var recount = empdat.ChangePassword(emp.EmployeeNo, MD5Encrypt(password));
                if(recount>0)
                {
                    boolresult = true;
                    spwd = MD5Encrypt(password);
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
        private string MD5Encrypt(string strEnc)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] res = md5.ComputeHash(Encoding.Default.GetBytes(strEnc), 0, strEnc.Length);
            string result = "";
            foreach (byte b in res)
            {
                result += b.ToString("X");
            }
            //char[] temp = new char[res.Length];
            //System.Array.Copy(res, temp, res.Length);
            return result;
            
           
        }  
    }
}
