using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zeta.WisdCar.Model.PO;
using Zeta.WisdCar.Model.VO;
using Zeta.WisdCar.Business.AutoMapper;
using AutoMapper;
using Zeta.WisdCar.Repository.Impl;

namespace Zeta.WisdCar.Business.BasicDataModule
{
    public class KVCategoryMgm : IKVCategoryMgm
    {
        public List<Model.VO.KVCategoryVO> GetAllCategorys()
        {
            KVCategoryData kvCategoryData = new KVCategoryData();
            List<KVCategoryVO> kvCategoryVOList = new List<KVCategoryVO>();

            DataSet ds = kvCategoryData.GetAllCategorys();

            List<KVCategoryPO> kvCategoryPOList = ds.GetEntity<List<KVCategoryPO>>();

            kvCategoryPOList.ForEach(i =>
            {
                kvCategoryVOList.Add(Mapper.Map<KVCategoryPO, KVCategoryVO>(i));
            });

            return kvCategoryVOList;
        }

        public Model.VO.KVCategoryVO GetCategoryByID(int categoryID)
        {
            KVCategoryData kvCategoryData = new KVCategoryData();
            KVCategoryVO kvCategoryVO = new KVCategoryVO();
            KVCategoryPO kvCategoryPO = kvCategoryData.GetCategoryByID(categoryID);
            kvCategoryVO = Mapper.Map<KVCategoryPO, KVCategoryVO>(kvCategoryPO);

            return kvCategoryVO;
        }

        public void AddCategory(Model.VO.KVCategoryVO category)
        {
            KVCategoryData kvCategoryData = new KVCategoryData();
            kvCategoryData.AddCategory(Mapper.Map<KVCategoryVO, KVCategoryPO>(category));
        }

        public void EditCategory(Model.VO.KVCategoryVO category)
        {
            KVCategoryData kvCategoryData = new KVCategoryData();
            kvCategoryData.EditCategory(Mapper.Map<KVCategoryVO, KVCategoryPO>(category));
        }

        public void DelCategory(int id)
        {
            KVCategoryData kvCategoryData = new KVCategoryData();
            kvCategoryData.DelCategory(id);
        }
    }
}
