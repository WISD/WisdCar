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
    public class KVLookupMgm : IKVLookupMgm
    {
        public List<Model.VO.KVLookupVO> GetKVByCategoryID(int id)
        {
            KVLookupData kvLookupData = new KVLookupData();
            List<KVLookupVO> kvLookupVOList = new List<KVLookupVO>();

            DataSet ds = kvLookupData.GetKVByCategoryID(id);

            List<KVLookupPO> kvLookupPOList = ds.GetEntity<List<KVLookupPO>>();

            kvLookupPOList.ForEach(i =>
            {
                kvLookupVOList.Add(Mapper.Map<KVLookupPO, KVLookupVO>(i));
            });

            return kvLookupVOList;
        }

        public Model.VO.KVLookupVO GetKVByID(int id)
        {
            KVLookupData kvLookupData = new KVLookupData();
            KVLookupVO kvLookupVO = new KVLookupVO();
            KVLookupPO kvLookupPO = kvLookupData.GetKVByID(id);
            kvLookupVO = Mapper.Map<KVLookupPO, KVLookupVO>(kvLookupPO);

            return kvLookupVO;
        }

        public void AddKV(Model.VO.KVLookupVO kv)
        {
            KVLookupData kvLookupData = new KVLookupData();
            kvLookupData.AddKV(Mapper.Map<KVLookupVO, KVLookupPO>(kv));
        }

        public void EditKV(Model.VO.KVLookupVO kv)
        {
            KVLookupData kvLookupData = new KVLookupData();
            kvLookupData.EditKV(Mapper.Map<KVLookupVO, KVLookupPO>(kv));
        }

        public void DelKV(int id)
        {
            KVLookupData kvLookupData = new KVLookupData();
            kvLookupData.DelKV(id);
        }
    }
}
