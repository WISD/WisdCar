using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zeta.WisdCar.Repository.CRUD;

namespace Zeta.WisdCar.Repository.Impl
{
    public class StoreData : IStoreData
    {
        private Store _daoStore = new Store();

        public System.Data.DataSet GetAllStores()
        {
            return _daoStore.GetList("");
        }

        public Model.PO.StorePO GetStoreByID(int storeID)
        {
            return _daoStore.GetModel(storeID);
        }

        public void AddStore(Model.PO.StorePO store)
        {
            _daoStore.Add(store);
        }

        public void EditStore(Model.PO.StorePO store)
        {
            _daoStore.Update(store);
        }

        public void DelStore(int id)
        {
            _daoStore.Delete(id);
        }
    }
}
