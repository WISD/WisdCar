using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AutoMapper;
using Zeta.WisdCar.Model.PO;
using Zeta.WisdCar.Model.VO;
using System.Data;
using Zeta.WisdCar.Business.MarktingPlanModule;

namespace Zeta.WisdCar.Business.Test
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestMethod1()
        {
            //for DB record to PO
            Mapper.CreateMap<IDataReader, ClubCardTypePO>();
            //PO to VO
            Mapper.CreateMap<ClubCardTypePO, ClubCardTypeVO>();
            //VO to PO
            //Mapper.CreateMap<ClubCardTypeVO, ClubCardTypePO>();
            ClubCardTypeMgm clubMgm = new ClubCardTypeMgm();
            clubMgm.GetAllCardType();
        }

        [TestMethod]
        public void TestMethod2()
        {
            ClubCardTypeMgm clubMgm = new ClubCardTypeMgm();
            clubMgm.DelCardType(2);
        }
    }
}
