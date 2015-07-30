using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Zeta.WisdCar.Infrastructure.Log;

namespace Zeta.WisdCar.Business
{
    public class BusinessMocker
    {
        public static void MockLog4Net()
        {
            new Task(() => {
                while (true)
                {
                    LogHandler.Error("asdfasdf");
                    Thread.Sleep(1000);
                }
            }).Start();
        }

    }
}
