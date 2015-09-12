using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AutoMapper;
using Zeta.WisdCar.Model.PO;
using Zeta.WisdCar.Business.MarktingPlanModule;
using Zeta.WisdCar.Model.VO;
using Zeta.WisdCar.Business.CustClubCardModule;

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

        [TestMethod]
        public void TestMethod3()
        {
            //add ClubCard
            ClubCardVO clubCardVO = new ClubCardVO();
            clubCardVO.Balance = 0.0M;
            clubCardVO.Birthday = "19860909";
            clubCardVO.CardStatus = 0;
            clubCardVO.ClubCardNo = "00001";
            clubCardVO.ClubCardPwd = "11111";
            clubCardVO.ClubCardTypeID = 1;
            clubCardVO.ClubCardTypeName = "金卡";
            clubCardVO.CustName = "tianx";
            clubCardVO.CustomerID = 1;
            clubCardVO.ExpireDate = DateTime.Parse("2025/09/09 12:00");
            clubCardVO.SalesMan = "songge";
            clubCardVO.SalesTime = DateTime.Parse("2015/09/09 12:00");

            clubCardVO.OpenCardStore = "minhangqu";

            clubCardVO.CreatedDate = DateTime.Now;
            clubCardVO.CreatorID = "001";
            clubCardVO.LastModifiedDate = DateTime.Now;
            clubCardVO.LastModifierID = "002";
            clubCardVO.LogicalStatus = 1;
            clubCardVO.PackageDiscount = 0.8M;
            clubCardVO.PayDiscount = 0.2M;

            //VO to PO
            Mapper.CreateMap<ClubCardVO, ClubCardPO>();

            ClubCardMgm clubMgm = new ClubCardMgm();
            clubMgm.AddClubCard(clubCardVO);
        }


        [TestMethod]
        public void TestMethod4()
        {
            //add customer
            CustomerVO customerVO = new CustomerVO();
            customerVO.Birthday = "19860907";
            customerVO.CardFlag = 1;
            customerVO.Company = "phillip";

            customerVO.CreatedDate = DateTime.Now;
            customerVO.CreatorID = "001";
            customerVO.LastModifiedDate = DateTime.Now;
            customerVO.LastModifierID = "002";
            customerVO.LogicalStatus = 1;
            customerVO.ICNo = "32092319860907331x";
            customerVO.MobileNO = "18516251396";
            customerVO.Name = "zhuqingsong";
            customerVO.Sex = "M";
            customerVO.Weixin = "chadzhu";

            //VO to PO
            Mapper.CreateMap<CustomerVO, CustomerPO>();

            CustomerMgm customerMgm = new CustomerMgm();
            customerMgm.AddCustomer(customerVO);
        }
    }
}
