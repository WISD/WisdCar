using AutoMapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zeta.WisdCar.Model.PO;
using Zeta.WisdCar.Model.VO;
using Zeta.WisdCar.Repository.Impl;
using Zeta.WisdCar.Business.AutoMapper;

namespace Zeta.WisdCar.Business.BasicDataModule
{
    public class StoreMgm : IStoreMgm
    {
        public List<Model.VO.StoreVO> GetAllStores()
        {
            StoreData storeData = new StoreData();
            List<StoreVO> storeVOList = new List<StoreVO>();

            DataSet ds = storeData.GetAllStores();

            List<StorePO> storePOList = ds.GetEntity<List<StorePO>>();

            storePOList.ForEach(i =>
            {
                storeVOList.Add(Mapper.Map<StorePO, StoreVO>(i));
            });

            return storeVOList;
        }

        public Model.VO.StoreVO GetStoreByID(int storeID)
        {
            StoreData storeData = new StoreData();
            StoreVO storeVO = new StoreVO();
            StorePO storePO = storeData.GetStoreByID(storeID);
            storeVO = Mapper.Map<StorePO, StoreVO>(storePO);

            return storeVO;
        }

        public void AddStore(Model.VO.StoreVO store)
        {
            StoreData storeData = new StoreData();
            storeData.AddStore(Mapper.Map<StoreVO, StorePO>(store));
        }

        public void EditStore(Model.VO.StoreVO store)
        {
            StoreData storeData = new StoreData();
            storeData.EditStore(Mapper.Map<StoreVO, StorePO>(store));
        }

        public void DelStore(int id)
        {
            StoreData storeData = new StoreData();
            storeData.DelStore(id);
        }
    }
}
