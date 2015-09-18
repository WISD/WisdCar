using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zeta.WisdCar.Model.PO;

namespace Zeta.WisdCar.Repository
{
    interface IEployeeData
    {
        int ChangePassword(string id, string password);
        EmployeePO Login(EmployeePO emp);
    }
}
