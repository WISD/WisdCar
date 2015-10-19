using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Zeta.WisdCar.Model.Entity;

namespace Zeta.WisdCar.Business.SysMgmModule
{
    public class PermissionMgm : IPermissionMgm
    {
        public static Model.Entity.UserProfileEntity GetCurUser1()
        {

            UserProfileEntity curUser = new UserProfileEntity();
            curUser.UserName = "xxx";
            curUser.MobileNO = "13773601486";
            curUser.StoreID = "1";
            curUser.StoreName = "上海市闵行区七宝店";

            return curUser;
        }

        public UserProfileEntity GetCurUser()
        {
            throw new NotImplementedException();
        }
    }
}
