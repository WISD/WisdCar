﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zeta.WisdCar.Model.PO;
using Zeta.WisdCar.Model.VO;
using AutoMapper;
using Zeta.WisdCar.Repository.Impl;
using System.Data;
using Zeta.WisdCar.Business.AutoMapper;

namespace Zeta.WisdCar.Business.MarktingPlanModule
{
    public class ClubCardTypeMgm : IClubCardTypeMgm
    {
        public List<Model.VO.ClubCardTypeVO> GetAllCardType()
        {
            ClubCardTypeData cardTypeData = new ClubCardTypeData();
            List<ClubCardTypeVO> cardTypeVOList = new List<ClubCardTypeVO>();

            DataSet ds = cardTypeData.GetAllCardType();

            List<ClubCardTypePO> cardTypePOList = ds.GetEntity<List<ClubCardTypePO>>();

            //foreach (var i in cardTypePOList)
            //{
            //    cardTypeVOList.Add(Mapper.Map<ClubCardTypePO, ClubCardTypeVO>(i));
            //}
            if (cardTypePOList != null && cardTypePOList.Count > 0)
            {
                cardTypePOList.ForEach(i =>
                {
                    cardTypeVOList.Add(Mapper.Map<ClubCardTypePO, ClubCardTypeVO>(i));
                });
            }
            return cardTypeVOList;
        }

        public void AddCardType(Model.VO.ClubCardTypeVO cardType)
        {
            ClubCardTypeData cardTypeData = new ClubCardTypeData();
            cardTypeData.AddCardType(Mapper.Map<ClubCardTypeVO, ClubCardTypePO>(cardType));
        }

        public bool EditCardType(Model.VO.ClubCardTypeVO cardType)
        {
            ClubCardTypeData cardTypeData = new ClubCardTypeData();
            return cardTypeData.EditCardType(Mapper.Map<ClubCardTypeVO, ClubCardTypePO>(cardType));
        }

        public void DelCardType(int id)
        {
            ClubCardTypeData cardTypeData = new ClubCardTypeData();
            cardTypeData.DelCardType(id);
        }


        public ClubCardTypeVO GetCardTypeByID(int cardTypeID)
        {
            ClubCardTypeData cardTypeData = new ClubCardTypeData();
            ClubCardTypeVO cardTypeVO = new ClubCardTypeVO();
            ClubCardTypePO cardTypePO = cardTypeData.GetCardTypeByID(cardTypeID);
            cardTypeVO = Mapper.Map<ClubCardTypePO, ClubCardTypeVO>(cardTypePO);

            return cardTypeVO;
        }
    }
}
