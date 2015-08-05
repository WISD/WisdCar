using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Zeta.WisdCar.Repository.Test
{
    [TestClass]
    public class ConTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataMocker mocker = new DataMocker();
            mocker.TestCon();
        }
    }
}
