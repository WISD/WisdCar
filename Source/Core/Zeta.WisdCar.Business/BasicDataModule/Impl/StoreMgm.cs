using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zeta.WisdCar.Model.PO;
using Zeta.WisdCar.Model.VO;
using Zeta.WisdCar.Repository.Impl;

namespace Zeta.WisdCar.Business.BasicDataModule
{
    public class StoreMgm : IStoreMgm
    {
        public StoreVO GetModel(int id)
        {
            StoreData storedata = new StoreData();

            //StoreData
            return Mapper.Map<StorePO, StoreVO>(storedata.GetModel(id));
        }
        public List<Model.VO.StoreVO> GetAllStores()
        {
            throw new NotImplementedException();
        }

        public Model.VO.StoreVO GetStoreByID(int storeID)
        {
            throw new NotImplementedException();
        }

        public void AddStore(Model.VO.StoreVO store)
        {
            throw new NotImplementedException();
        }

        public void EditStore(Model.VO.StoreVO store)
        {
            throw new NotImplementedException();
        }

        public void DelStore(int id)
        {
            throw new NotImplementedException();
        }
    }
}
