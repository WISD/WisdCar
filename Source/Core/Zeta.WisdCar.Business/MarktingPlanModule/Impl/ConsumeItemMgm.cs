using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Zeta.WisdCar.Model.VO;
using Zeta.WisdCar.Repository.Impl;
using Zeta.WisdCar.Model.PO;
using System.Data;
using Zeta.WisdCar.Business.AutoMapper;

namespace Zeta.WisdCar.Business.MarktingPlanModule
{
    public class ConsumeItemMgm : IConsumeItemMgm
    {
        public List<Model.VO.ConsumeItemVO> GetAllConsumeItem()
        {
            ConsumeItemData consumeItemData = new ConsumeItemData();
            List<ConsumeItemVO> consumeItemVOList = new List<ConsumeItemVO>();

            DataSet ds = consumeItemData.GetAllConsumeItem();
            List<ConsumeItemPO> consumeItemPOList = ds.GetEntity<List<ConsumeItemPO>>();

            consumeItemPOList.ForEach(i =>
            {
                consumeItemVOList.Add(Mapper.Map<ConsumeItemPO, ConsumeItemVO>(i));
            });

            return consumeItemVOList;
        }

        public void AddConsumeItem(Model.VO.ConsumeItemVO consumeItem)
        {
            ConsumeItemData consumeItemData = new ConsumeItemData();
            consumeItemData.AddConsumeItem(Mapper.Map<ConsumeItemVO, ConsumeItemPO>(consumeItem));
        }

        public void EditConsumeItem(Model.VO.ConsumeItemVO consumeItem)
        {
            ConsumeItemData consumeItemData = new ConsumeItemData();
            consumeItemData.EditConsumeItem(Mapper.Map<ConsumeItemVO, ConsumeItemPO>(consumeItem));
        }

        public void DelConsumeItem(int id)
        {
            ConsumeItemData consumeItemData = new ConsumeItemData();
            consumeItemData.DelConsumeItem(id);
        }


        public ConsumeItemVO GetConsumeItemByID(int consumeItemID)
        {
            throw new NotImplementedException();
        }
    }
}
