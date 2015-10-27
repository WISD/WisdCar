using AutoMapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zeta.WisdCar.Business.Handler;
using Zeta.WisdCar.Infrastructure;
using Zeta.WisdCar.Infrastructure.DBUtility;
using Zeta.WisdCar.Model.PO;
using Zeta.WisdCar.Model.VO;
using Zeta.WisdCar.Repository.Impl;
using Zeta.WisdCar.Business.AutoMapper;

namespace Zeta.WisdCar.Business.RechargeConsumeModule
{
    public class ConsumeMgm : IConsumeMgm
    {
        public string ConsumeCash(List<Model.VO.ConsumeVO> list)
        {
            string strBatchNo = "";
            CustClubCardModule.ClubCardMgm clubCardMgm = new CustClubCardModule.ClubCardMgm();
            int clubCardStat = clubCardMgm.GetCardStatusByClubCardID(list[0].ClubCardID);
            if (clubCardStat != Convert.ToInt32(ClubCardStatus.OpenCard))
            {
                throw new Exception("非有效会员卡，请联系后台管理员");
            }

            ConsumeLogData consumeLogData = new ConsumeLogData();
            ClubCardData clubCardData = new ClubCardData();
            ClubCardPO clubCardPO = clubCardData.GetClubCardByID(list[0].ClubCardID);

            SqlConnection conn = new SqlConnection(PubConstant.ConnectionString);
            conn.Open();
            SqlTransaction tx = conn.BeginTransaction();
            int storeId = Convert.ToInt32(list.FirstOrDefault().Reserved1);
            list.ForEach(itm => itm.Reserved1 = null);
            try
            {
                decimal dConsumeAmount = 0.0M;
                strBatchNo = SerialNoGenerator.GenConsumeBatchNo(storeId);
                foreach (var item in list)
                {
                    dConsumeAmount += item.OriginalPrice;
                    item.ConsumeBatchNo = strBatchNo;
                    consumeLogData.AddConsumeLog(Mapper.Map<ConsumeVO, ConsumeLogPO>(item));
                }
                clubCardPO.Balance = clubCardPO.Balance - dConsumeAmount;
                clubCardData.UpdateClubCard(clubCardPO);
                tx.Commit();
            }
            catch
            {
                tx.Rollback();
                throw new Exception("会员现金消费失败");
            }
            return strBatchNo;
        }

        public string ConsumePkg(List<Model.VO.ConsumeVO> list)
        {
            if (list.Count < 1)
            {
                throw new Exception("请选择套餐消费项目");
            }

            string strBatchNo = "";
            CustClubCardModule.ClubCardMgm clubCardMgm = new CustClubCardModule.ClubCardMgm();
            int clubCardStat = clubCardMgm.GetCardStatusByClubCardID(list[0].ClubCardID);
            if (clubCardStat != Convert.ToInt32(ClubCardStatus.OpenCard))
            {
                throw new Exception("非有效会员卡，请联系后台管理员");
            }

            ConsumeLogData consumeLogData = new ConsumeLogData();
            ClubCardData clubCardData = new ClubCardData();
            DataSet ds = clubCardData.GetDetailByClubCardPkgID(list[0].ClubCardPackageID.ToString());
            List<ClubCardPackageDetailPO> clubCardPkgDetailPOList = ds.GetEntity<List<ClubCardPackageDetailPO>>();


            SqlConnection conn = new SqlConnection(PubConstant.ConnectionString);
            conn.Open();
            SqlTransaction tx = conn.BeginTransaction();
            int storeId = Convert.ToInt32(list.FirstOrDefault().Reserved1);
            list.ForEach(itm => itm.Reserved1 = null);
            try
            {
                strBatchNo = SerialNoGenerator.GenConsumeBatchNo(storeId);
                foreach (var item in list)
                {
                    ClubCardPackageDetailPO tmpPkgDetail = null;
                    foreach(var item1 in clubCardPkgDetailPOList)
                    {
                        if(item.PackageDetailID == item1.PackageDetailID)
                        {
                            item1.RemainCount -= item.ConsumeCount;
                            tmpPkgDetail = item1;
                            item.ItemID = item1.ItemID;
                            break;
                        }
                    }

                    if(tmpPkgDetail == null)
                    {
                        throw new Exception("消费项目套餐中不存在");
                    }

                    ClubCardPackageData clubCardPackageData = new ClubCardPackageData();
                    clubCardPackageData.EditClubCardPkgDetail(tmpPkgDetail);

                    item.ConsumeBatchNo = strBatchNo;
                    consumeLogData.AddConsumeLog(Mapper.Map<ConsumeVO, ConsumeLogPO>(item));
                    
                }
                if (clubCardPkgDetailPOList.Any(i=>i.RemainCount==0))
                {
                    var cardPkg= new ClubCardPackageData();
                    var cardPkgData = cardPkg.GetClubCardPkgByID(list[0].ClubCardPackageID);
                    cardPkgData.PackageStatus = (int)CardSPackageStatus.Unavailable;
                    cardPkg.EditClubCardPkg(cardPkgData);
                }
                tx.Commit();
            }
            catch
            {
                tx.Rollback();
                throw new Exception("会员套餐消费失败");
            }
            return strBatchNo;
        }

        public string ConsumeForNoCard(List<Model.VO.ConsumeVO> list)
        {
            if (list.Count < 1)
            {
                throw new Exception("请选择消费项目");
            }

            string strBatchNo = "";
            CustClubCardModule.ClubCardMgm clubCardMgm = new CustClubCardModule.ClubCardMgm();
            ClubCardVO clubCardVO = clubCardMgm.GetClubCardByID(list[0].ClubCardID);
            if (clubCardVO.ClubCardNo.Trim() != "" )
            {
                throw new Exception("会员卡用户，请选择会员消费");
            }

            ConsumeLogData consumeLogData = new ConsumeLogData();

            SqlConnection conn = new SqlConnection(PubConstant.ConnectionString);
            conn.Open();
            SqlTransaction tx = conn.BeginTransaction();
            int storeId = Convert.ToInt32(list.FirstOrDefault().Reserved1);
            list.ForEach(itm => itm.Reserved1 = null);
            try
            {
                decimal dConsumeAmount = 0.0M;
                strBatchNo = SerialNoGenerator.GenConsumeBatchNo(storeId);
                foreach (var item in list)
                {
                    dConsumeAmount += item.OriginalPrice;//为后面的记录总账
                    item.ConsumeBatchNo = strBatchNo;
                    consumeLogData.AddConsumeLog(Mapper.Map<ConsumeVO, ConsumeLogPO>(item));
                }
                tx.Commit();
            }
            catch
            {
                tx.Rollback();
                throw new Exception("非会员现金消费失败");
            }
            return strBatchNo;
        }

        public List<Model.VO.ConsumeVO> GetConsumeInfoByBatchNo(string batchNo)
        {
            ConsumeLogData consumeLogData = new ConsumeLogData();

            List<ConsumeVO> consumeVOList = new List<ConsumeVO>();

            DataSet ds = consumeLogData.GetConsumeInfoByBatchNo(batchNo);
            List<ConsumeLogPO> consumeLogPOList = ds.GetEntity<List<ConsumeLogPO>>();

            consumeLogPOList.ForEach(i =>
            {
                consumeVOList.Add(Mapper.Map<ConsumeLogPO, ConsumeVO>(i));
            });

            return consumeVOList;
        }

        public List<Model.VO.ConsumeQueryVO> GetConsumeLog(Model.Entity.ConsumeLogQueryEntity entity)
        {
            ConsumeLogData consumeLogData = new ConsumeLogData();

            List<ConsumeQueryVO> consumeQueryVOList = new List<ConsumeQueryVO>();

            DataSet ds = consumeLogData.GetConsumeLogs(entity);
            List<ConsumeLogPO> consumeLogPOList = ds.GetEntity<List<ConsumeLogPO>>();

            consumeLogPOList.ForEach(i =>
            {
                consumeQueryVOList.Add(Mapper.Map<ConsumeLogPO, ConsumeQueryVO>(i));
            });

            return consumeQueryVOList;
        }
    }
}
