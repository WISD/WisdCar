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

namespace Zeta.WisdCar.Business.RechargeConsumeModule
{
    public class RechargeMgm : IRechargeMgm
    {
        public void RechargeCash(Model.VO.RechargeVO entity)
        {
            //待开发
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
            throw new NotImplementedException();
        }
    }
}
