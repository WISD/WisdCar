using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zeta.WisdCar.Infrastructure
{
    public class Constants
    {
        //更新缓存最大间隔，用于HealthCheck
        public const int MAX_ROUTE_CACHE_INTERVAL = 1 * 60 * 1000;    //1分钟

    }
}
