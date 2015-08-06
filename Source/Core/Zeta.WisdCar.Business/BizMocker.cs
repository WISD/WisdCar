using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Zeta.WisdCar.Business.SysMgmModule;
using Zeta.WisdCar.Infrastructure.Log;

namespace Zeta.WisdCar.Business
{
    public class BizMocker : IPermissionMgm
    {
        public static void MockLog4Net()
        {
            new Task(() =>
            {
                while (true)
                {
                    LogHandler.Error("我错了。。。");
                    Thread.Sleep(1000);
                }
            }).Start();
        }
        
        /// <summary>
        /// 获取当前登录的用户帐号
        /// </summary>
        /// <returns></returns>
        public string GetCurUserName()
        {
            return "zltian";
        }
    }
}
