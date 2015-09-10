using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zeta.WisdCar.Model.PO;

namespace Zeta.WisdCar.Business.BasicDataModule
{
    public interface IEmployeeMgm
    {
        string Login(Model.PO.EmployeePO emp,out string spwd);
        string ChangePassword(EmployeePO emp, string oldpwd, string password,out bool boolresult,out string spwd);
    }
}
