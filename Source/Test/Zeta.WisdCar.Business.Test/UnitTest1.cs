using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AutoMapper;
using Zeta.WisdCar.Model.PO;
using Zeta.WisdCar.Business.MarktingPlanModule;
using Zeta.WisdCar.Model.VO;

namespace Zeta.WisdCar.Business.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //VO to PO
            Mapper.CreateMap<ClubCardTypeVO, ClubCardTypePO>();
            ClubCardTypeMgm clubMgm = new ClubCardTypeMgm();
            ClubCardTypeVO clubCardTypeVO = new ClubCardTypeVO();
            clubCardTypeVO.CardTypeName = "Gold";
            clubCardTypeVO.ClubCardTypeID = 1;
            clubCardTypeVO.CreatedDate = DateTime.Now;
            clubCardTypeVO.CreatorID = "001";
            clubCardTypeVO.LastModifiedDate = DateTime.Now;
            clubCardTypeVO.LastModifierID = "002";
            clubCardTypeVO.LogicalStatus = 1;
            clubCardTypeVO.Operation = "add";
            clubCardTypeVO.PackageDiscount = 0.5M;
            clubCardTypeVO.PayDiscount = 0.5M;

            clubMgm.AddCardType(clubCardTypeVO);
        }
        [TestMethod]
        public void TestMethod2()
        {
            ClubCardTypeVO clubCardTypeVO = new ClubCardTypeVO();
            clubCardTypeVO.CardTypeName = "Gold111111117777";
            clubCardTypeVO.ClubCardTypeID = 3;
            clubCardTypeVO.CreatedDate = DateTime.Now;
            clubCardTypeVO.CreatorID = "001";
            clubCardTypeVO.LastModifiedDate = DateTime.Now;
            clubCardTypeVO.LastModifierID = "002";
            clubCardTypeVO.LogicalStatus = 1;
            clubCardTypeVO.Operation = "add";
            clubCardTypeVO.PackageDiscount = 0.8M;
            clubCardTypeVO.PayDiscount = 0.2M;

            //VO to PO
            Mapper.CreateMap<ClubCardTypeVO, ClubCardTypePO>();

            ClubCardTypeMgm clubMgm = new ClubCardTypeMgm();
            clubMgm.EditCardType(clubCardTypeVO);
        }
    }
}
