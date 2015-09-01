using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zeta.WisdCar.Infrastructure
{
    /// <summary>
    /// 协议
    /// </summary>
    public enum Proto
    {
        Tcp = 0,
        Http = 1
    }

    public enum ClubCardStatus
    {
        OpenCard = 0,    //开卡
        ReportLoss = 1,    //挂失
        Froze = 2,    //冻结
        LogOff = 3,    //注销
        Expire = 4    //过期
    }

}
