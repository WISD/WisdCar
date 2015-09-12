using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zeta.WisdCar.Business.RechargeConsumeModule;
using Zeta.WisdCar.Model.VO;
using AutoMapper;
using Zeta.WisdCar.Model.PO;
using Zeta.WisdCar.Business.AutoMapper;
using Zeta.WisdCar.Business.MarktingPlanModule;
using System.Collections.Generic;
using System.Data;

namespace Zeta.WisdCar.Business.Test
{
    [TestClass]
    public class UnitTest3
    {
        [TestMethod]
        public void TestMethod1()
        {
            RechargeMgm clubMgm = new RechargeMgm();
            RechargeVO entity = new RechargeVO();
            clubMgm.RechargeCash(entity);

        }

        [TestMethod]
        public void TestMethod2()
        {
            RechargeVO entity = new RechargeVO();
            entity.ActualRechargeAmount = 200;
            entity.ClubCardID = 4;
            entity.ClubCardNo = 00001;
            entity.ClubCardPackageID = "1";

            entity.CreatedDate = DateTime.Now;
            entity.CreatorID = "001";
            entity.LastModifiedDate = DateTime.Now;
            entity.LastModifierID = "002";
            entity.LogicalStatus = 1;
            entity.CustID = 1;
            entity.CustName = "qingsong";
            entity.DiscountInfo = "sssss";
            entity.DiscountRate = 0.5M;
            entity.OriginalStore = "minangqu";
            entity.PayType = 0;
            entity.PlatformRechargeAmount = 400;
            entity.RechargeDate = DateTime.Now;
            entity.RechargeStore = "xuhui";
            entity.RechargeType = 0;
            entity.SalesMan = "songge";
            entity.SerialNo = "11101010101";


            //VO to PO
            Mapper.CreateMap<RechargeVO, RechargeLogPO>().ForMember(dest => dest.RechargeSerialNo, opt => opt.MapFrom(src => src.SerialNo)); 

            Mapper.CreateMap<ClubCardPO, ClubCardVO>().IgnoreUnmappedProperties();
            Mapper.CreateMap<PackageVO, PackagePO>();
            Mapper.CreateMap<PackagePO, PackageVO>().IgnoreUnmappedProperties();

            Mapper.CreateMap<IDataReader, PackageItemMappingPO>();
            Mapper.CreateMap<PackageItemMappingPO, PkgItemVO>();

            RechargeMgm clubMgm = new RechargeMgm();

            clubMgm.RechargePkg(entity);

        }


        [TestMethod]
        public void TestMethod3()
        {
            PackageVO entity = new PackageVO();
            entity.PackageName = "2015超级套餐";
            entity.TotalPrice = 500.0M;

            entity.CreatedDate = DateTime.Now;
            entity.CreatorID = "001";
            entity.LastModifiedDate = DateTime.Now;
            entity.LastModifierID = "002";
            entity.LogicalStatus = 1;


            //VO to PO
            Mapper.CreateMap<PackageVO, PackagePO>();

            PackageMgm pkgMgm = new PackageMgm();

            pkgMgm.AddPackage(entity);
        }

        [TestMethod]
        public void TestMethod4()
        {
            ConsumeItemVO entity = new ConsumeItemVO();
            entity.ItemName = "peng qi";
            entity.ItemPrice = 80M;

            entity.CreatedDate = DateTime.Now;
            entity.CreatorID = "001";
            entity.LastModifiedDate = DateTime.Now;
            entity.LastModifierID = "002";
            entity.LogicalStatus = 1;


            //VO to PO
            Mapper.CreateMap<ConsumeItemVO, ConsumeItemPO>();

            ConsumeItemMgm consumeItemMgm = new ConsumeItemMgm();

            consumeItemMgm.AddConsumeItem(entity);
        }

        [TestMethod]
        public void TestMethod5()
        {
            List<PkgItemVO> entityList = new List<PkgItemVO>();
            PkgItemVO entity = new PkgItemVO();

            entity.ItemID = 1;
            entity.ItemName = "clean car";
            entity.PackageID = 1;
            entity.PackageName = "2015超级套餐";
            entity.ConsumeCount = 10;

            entity.CreatedDate = DateTime.Now;
            entity.CreatorID = "001";
            entity.LastModifiedDate = DateTime.Now;
            entity.LastModifierID = "002";
            entity.LogicalStatus = 1;

            PkgItemVO entity1 = new PkgItemVO();

            entity1.ItemID = 2;
            entity1.ItemName = "peng qi";
            entity1.PackageID = 1;
            entity1.PackageName = "2015超级套餐";
            entity1.ConsumeCount = 20;

            entity1.CreatedDate = DateTime.Now;
            entity1.CreatorID = "001";
            entity1.LastModifiedDate = DateTime.Now;
            entity1.LastModifierID = "002";
            entity1.LogicalStatus = 1;

            entityList.Add(entity);
            entityList.Add(entity1);

            //VO to PO
            Mapper.CreateMap<PkgItemVO, PackageItemMappingPO>();

            PkgItemsMgm pkgItemsMgm = new PkgItemsMgm();

            pkgItemsMgm.AddPkgItems(entityList);
        }
    }
}
