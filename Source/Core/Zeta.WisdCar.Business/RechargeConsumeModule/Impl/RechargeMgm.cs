using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zeta.WisdCar.Model.VO;
using Zeta.WisdCar.Repository.Impl;
using Zeta.WisdCar.Model.PO;
using Zeta.WisdCar.Infrastructure.DBUtility;
using System.Data.SqlClient;
using Zeta.WisdCar.Infrastructure;
using Zeta.WisdCar.Business.Handler;
using System.Data;
using Zeta.WisdCar.Business.AutoMapper;

namespace Zeta.WisdCar.Business.RechargeConsumeModule
{
    public class RechargeMgm : IRechargeMgm
    {
        public void RechargeCash(Model.VO.RechargeVO entity)
        {
            CustClubCardModule.ClubCardMgm clubCardMgm = new CustClubCardModule.ClubCardMgm();
            int clubCardID = clubCardMgm.GetCardStatusByClubCardID(entity.ClubCardID);
            if(clubCardID != Convert.ToInt32(ClubCardStatus.OpenCard))
            {
                throw new Exception("非有效会员卡，请联系后台管理员");
            }

            RechargeLogData rechargeLogData = new RechargeLogData();
            ClubCardData clubCardData = new ClubCardData();
            ClubCardPO clubCardPO = clubCardData.GetClubCardByID(entity.ClubCardID);
            clubCardPO.Balance += entity.PlatformRechargeAmount;


            SqlConnection conn = new SqlConnection(PubConstant.ConnectionString);
            conn.Open();
            SqlTransaction tx = conn.BeginTransaction();

            try
            {
                entity.SerialNo = SerialNoGenerator.GenRechargeSerialNo();
                rechargeLogData.AddRechargeLog(Mapper.Map<RechargeVO, RechargeLogPO>(entity));
                clubCardData.UpdateClubCard(clubCardPO);
                tx.Commit();
            }
            catch
            {
                tx.Rollback();
                throw new Exception("现金充值失败");
            }
        }

        public int RechargePkg(Model.VO.RechargeVO entity)
        {
            //尚需完善
            CustClubCardModule.ClubCardMgm clubCardMgm = new CustClubCardModule.ClubCardMgm();

            int clubCardState = clubCardMgm.GetCardStatusByClubCardID(entity.ClubCardID);
            if (clubCardState != Convert.ToInt32(ClubCardStatus.OpenCard))
            {
                throw new Exception("非有效会员卡，请联系后台管理员");
            }

            RechargeLogData rechargeLogData = new RechargeLogData();
            ClubCardPackagePO clubCardPkgPO = new ClubCardPackagePO();
            
            List<ClubCardPackageDetailPO> clubCardPkgDetailPOList = new List<ClubCardPackageDetailPO>();

            ClubCardPackageData clubCardPkgData = new ClubCardPackageData();


            MarktingPlanModule.PackageMgm pkgMgm = new MarktingPlanModule.PackageMgm(); 
            MarktingPlanModule.IPkgItemsMgm pkgItemsMgm = new MarktingPlanModule.PkgItemsMgm();

            //PackageData packageData = new PackageData();
            //PkgItemsData pkgItemsData = new PkgItemsData();

            PackageVO packageVO = pkgMgm.GetPackageByID(Convert.ToInt32(entity.ClubCardPackageID));//此处ClubCardPackageID即为PackageID
            PackagePO packagePO = Mapper.Map<PackageVO, PackagePO>(packageVO);
            List<PkgItemVO> pkgItemList = pkgItemsMgm.GetItemsByPkgID(packagePO.PackageID);


            clubCardPkgPO.PackageID = packagePO.PackageID;
            clubCardPkgPO.ClubCardID = entity.ClubCardID;
            clubCardPkgPO.PackageName = packagePO.PackageName;
            clubCardPkgPO.OriginalAmount = entity.PlatformRechargeAmount;
            clubCardPkgPO.ActualAmount = entity.ActualRechargeAmount;
            clubCardPkgPO.DiscountRate = entity.DiscountRate;
            clubCardPkgPO.DiscountInfo = entity.DiscountInfo;
            clubCardPkgPO.DiscountRate = Convert.ToDecimal(CardSPackageStatus.Available);
            clubCardPkgPO.Salesman = entity.SalesMan;
            clubCardPkgPO.SalesTime = DateTime.Now;
            clubCardPkgPO.SaleStore = "1111";//从login信息中获取
            clubCardPkgPO.CreatedDate = DateTime.Now;
            clubCardPkgPO.CreatorID = "001";
            clubCardPkgPO.LastModifiedDate = DateTime.Now;
            clubCardPkgPO.LastModifierID = "002";
            clubCardPkgPO.ClubCardPackageID = SerialNoGenerator.GenClubCardPkgID();

            foreach (var item in pkgItemList)
	        {
		        ClubCardPackageDetailPO clubCardPkgDetailPO = new ClubCardPackageDetailPO();
                clubCardPkgDetailPO.ClubCardPackageID = clubCardPkgPO.ClubCardPackageID;
                clubCardPkgDetailPO.ItemID = item.ItemID;
                clubCardPkgDetailPO.ItemName = item.ItemName;

                clubCardPkgDetailPO.CreatedDate = DateTime.Now;
                clubCardPkgDetailPO.CreatorID = "001";
                clubCardPkgDetailPO.LastModifiedDate = DateTime.Now;
                clubCardPkgDetailPO.LastModifierID = "002";
                
                clubCardPkgDetailPOList.Add(clubCardPkgDetailPO);
	        }

            ClubCardData clubCardData = new ClubCardData();
            ClubCardPO clubCardPO = clubCardData.GetClubCardByID(entity.ClubCardID);
            clubCardPO.Balance = clubCardPO.Balance + entity.PlatformRechargeAmount;
            clubCardPO.LastModifiedDate = DateTime.Now;
            clubCardPO.LastModifierID = "TianXX";


            SqlConnection conn = new SqlConnection(PubConstant.ConnectionString);
            conn.Open();
            SqlTransaction tx = conn.BeginTransaction();

            try
            {
                clubCardPkgData.AddClubCardPkg(clubCardPkgPO);
                clubCardPkgData.AddClubCardPkgDetailList(clubCardPkgDetailPOList);

                entity.SerialNo = SerialNoGenerator.GenRechargeSerialNo();
                rechargeLogData.AddRechargeLog(Mapper.Map<RechargeVO, RechargeLogPO>(entity));
                tx.Commit();
            }
            catch
            {
                tx.Rollback();
                throw new Exception("套餐充值失败");
            }
            return 1;
        }


        public List<CashRechargeQueryVO> GetRechargeCashLog(Model.Entity.RechargeLogQueryEntity entity)
        {
            RechargeLogData rechargeLogData = new RechargeLogData();

            List<CashRechargeQueryVO> cashRechargeQueryVOList = new List<CashRechargeQueryVO>();

            DataSet ds = rechargeLogData.GetRechargeLogs(entity);
            List<RechargeLogPO> rechargeLogPOList = ds.GetEntity<List<RechargeLogPO>>();

            rechargeLogPOList.ForEach(i =>
            {
                cashRechargeQueryVOList.Add(Mapper.Map<RechargeLogPO, CashRechargeQueryVO>(i));
            });

            return cashRechargeQueryVOList;
        }

        public List<PkgRechargeQueryVO> GetRechargePkgLog(Model.Entity.RechargeLogQueryEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
