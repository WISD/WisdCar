using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zeta.WisdCar.Repository.CRUD;

namespace Zeta.WisdCar.Repository
{
    public class DataMocker
    {
        private Car _dao = new Car();

        public void TestCon()
        {
            var list = _dao.GetList("");

        }
    }
}
