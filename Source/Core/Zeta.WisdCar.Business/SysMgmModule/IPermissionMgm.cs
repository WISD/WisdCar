﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zeta.WisdCar.Model.Entity;

namespace Zeta.WisdCar.Business.SysMgmModule
{
    public interface IPermissionMgm
    {
        UserProfileEntity GetCurUser();

    }
}
