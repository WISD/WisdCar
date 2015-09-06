using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zeta.WisdCar.Business.SysMgmModule
{
    public class PermissionMgm : IPermissionMgm
    {
        Model.Entity.UserProfileEntity IPermissionMgm.GetCurUser()
        {
            throw new NotImplementedException();
        }
    }
}
