using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zeta.WisdCar.Repository.CRUD;

namespace Zeta.WisdCar.Repository.Impl
{
    public class StoreData:IStoreData
    {
        private Store _store = new Store();
        public Model.PO.StorePO GetModel(int id)
        {
            return _store.GetModel(id);
        }
    }
}
