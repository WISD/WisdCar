using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zeta.WisdCar.Model.PO;
using Zeta.WisdCar.Model.VO;
using AutoMapper;
using Zeta.WisdCar.Repository.Impl;

namespace Zeta.WisdCar.Business.MarktingPlanModule
{
    public class ClubCardTypeMgm : IClubCardTypeMgm
    {
        public List<Model.VO.ClubCardTypeVO> GetAllCardType()
        {
            ClubCardTypeData cardTypeData = new ClubCardTypeData();
            List<ClubCardTypeVO> cardTypeVOList = new List<ClubCardTypeVO>();
            List<ClubCardTypePO> cardTypePOList = cardTypeData.GetAllCardType();

            foreach (var i in cardTypePOList)
            {
                cardTypeVOList.Add(Mapper.Map<ClubCardTypePO, ClubCardTypeVO>(i));
            }

            //cardTypeData.GetAllCardType().ForEach(i =>
            //{
            //    cardTypeVOList.Add(Mapper.Map<ClubCardTypePO, ClubCardTypeVO>(i));
            //});

            return cardTypeVOList;
        }

        public void AddCardType(Model.VO.ClubCardTypeVO cardType)
        {
            ClubCardTypeData cardTypeData = new ClubCardTypeData();
            cardTypeData.AddCardType(Mapper.Map<ClubCardTypeVO, ClubCardTypePO>(cardType));
        }

        public void EditCardType(Model.VO.ClubCardTypeVO cardType)
        {
            ClubCardTypeData cardTypeData = new ClubCardTypeData();
            cardTypeData.EditCardType(Mapper.Map<ClubCardTypeVO, ClubCardTypePO>(cardType));
        }

        public void DelCardType(int id)
        {
            ClubCardTypeData cardTypeData = new ClubCardTypeData();
            cardTypeData.DelCardType(id);
        }
    }
}
