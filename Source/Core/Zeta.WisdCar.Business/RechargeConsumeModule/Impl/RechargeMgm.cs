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
            clubCardPO.Balance = entity.PlatformRechargeAmount;

            SqlConnection conn = new SqlConnection(PubConstant.ConnectionString);
            conn.Open();
            SqlTransaction tx = conn.BeginTransaction();

            try
            {
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
            //尚未完成
            CustClubCardModule.ClubCardMgm clubCardMgm = new CustClubCardModule.ClubCardMgm();
            int clubCardID = clubCardMgm.GetCardStatusByClubCardID(entity.ClubCardID);
            if (clubCardID != Convert.ToInt32(ClubCardStatus.OpenCard))
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

            PackageVO packageVO = pkgMgm.GetPackageByID(entity.ClubCardPackageID);
            PackagePO packagePO = Mapper.Map<PackageVO, PackagePO>(packageVO);
            List<PkgItemVO> pkgItemList = pkgItemsMgm.GetItemsByPkgID(entity.ClubCardPackageID);


            clubCardPkgPO.PackageID = 1;
            clubCardPkgPO.PackageName = "";
            clubCardPkgPO.OriginalAmount = entity.PlatformRechargeAmount;
            clubCardPkgPO.ActualAmount = entity.ActualRechargeAmount;
            clubCardPkgPO.DiscountRate = entity.DiscountRate;
            clubCardPkgPO.DiscountInfo = entity.DiscountInfo;
            clubCardPkgPO.DiscountInfo = Convert.ToString(CardSPackageStatus.Available);
            clubCardPkgPO.Salesman = entity.SalesMan;
            clubCardPkgPO.SalesTime = DateTime.Now;
            clubCardPkgPO.SaleStore = "";//从login信息中获取

            foreach (var item in pkgItemList)
	        {
		        ClubCardPackageDetailPO clubCardPkgDetailPO = new ClubCardPackageDetailPO();
                clubCardPkgDetailPO.ClubCardPackageID = 10000;
                clubCardPkgDetailPO.ItemID = item.ItemID;
                clubCardPkgDetailPO.ItemName = item.ItemName;
                
                clubCardPkgDetailPOList.Add(clubCardPkgDetailPO);
	        }


            SqlConnection conn = new SqlConnection(PubConstant.ConnectionString);
            conn.Open();
            SqlTransaction tx = conn.BeginTransaction();

            try
            {
                clubCardPkgData.AddClubCardPkg(clubCardPkgPO);
                clubCardPkgData.AddClubCardPkgDetailList(clubCardPkgDetailPOList);
                rechargeLogData.AddRechargeLog(Mapper.Map<RechargeVO, RechargeLogPO>(entity));
                //clubCardData.UpdateClubCard(clubCardPO);
                tx.Commit();
            }
            catch
            {
                tx.Rollback();
                throw new Exception("套餐充值失败");
            }
            return 1;
        }
    }
}
