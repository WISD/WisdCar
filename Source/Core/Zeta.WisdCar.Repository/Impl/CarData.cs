using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zeta.WisdCar.Model.PO;
using Zeta.WisdCar.Repository.CRUD;

namespace Zeta.WisdCar.Repository.Impl
{
    public class CarData : ICarData
    {
        private Car _daoCar = new Car();
        public System.Data.DataSet GetCarsByCustID(int custID)
        {
            StringBuilder strSql = new StringBuilder();
            string strWhere = "";
            
            strSql.AppendFormat(" CustomerID = {0} ", custID);

            strWhere = strSql.ToString();
            return _daoCar.GetList(strWhere);
        }

        public void AddCar(Model.PO.CarPO car)
        {
            _daoCar.Add(car);
        }

        public void EditCar(Model.PO.CarPO car)
        {
            _daoCar.Update(car);
        }

        public void DelCar(int id)
        {
            _daoCar.Delete(id);
        }
    }
}
