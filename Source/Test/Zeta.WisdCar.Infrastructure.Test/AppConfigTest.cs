using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Zeta.WisdCar.Infrastructure.Test
{
    [TestClass]
    public class AppConfigTest
    {
        [TestMethod]
        public void GetCacheInterval()
        {
            var result = AppSettings.DashboardUrl;
        }
    }
}
