using AutoMapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zeta.WisdCar.Model.PO;
using Zeta.WisdCar.Model.VO;
using Zeta.WisdCar.Repository.Impl;
using Zeta.WisdCar.Business.AutoMapper;
using Zeta.WisdCar.Infrastructure.Helper;
using Zeta.WisdCar.Infrastructure;
using Zeta.WisdCar.Business.Handler;

namespace Zeta.WisdCar.Business.CustClubCardModule
{
    public class ClubCardMgm : IClubCardMgm
    {
        public List<Model.VO.ClubCardVO> GetClubCards(Model.Entity.ClubCardQueryEntity entity)
        {
            ClubCardData clubCardData = new ClubCardData();
            List<ClubCardVO> clubCardVOList = new List<ClubCardVO>();

            DataSet ds = clubCardData.GetClubCards(entity);
            List<ClubCardPO> clubCardPOList = ds.GetEntity<List<ClubCardPO>>();

            clubCardPOList.ForEach(i =>
            {
                clubCardVOList.Add(Mapper.Map<ClubCardPO, ClubCardVO>(i));
            });

            return clubCardVOList;
        }
        public Model.VO.ClubCardVO GetClubCardByID(int id)
        {
            ClubCardData clubCardData = new ClubCardData();
            ClubCardVO clubCardVO = new ClubCardVO();
            ClubCardPO clubCardPO = clubCardData.GetClubCardByID(id);
            clubCardVO = Mapper.Map<ClubCardPO, ClubCardVO>(clubCardPO);

            return clubCardVO;
        }




        public List<Model.VO.ClubCardVO> GetClubCards(string key)
        {
            ClubCardData clubCardData = new ClubCardData();
            List<ClubCardVO> clubCardVOList = new List<ClubCardVO>();

            DataSet ds = clubCardData.GetClubCards(key);
            List<ClubCardPO> clubCardPOList = ds.GetEntity<List<ClubCardPO>>();

            clubCardPOList.ForEach(i =>
            {
                clubCardVOList.Add(Mapper.Map<ClubCardPO, ClubCardVO>(i));
            });

            return clubCardVOList;
        }

        public decimal GetBalanceByClubCardID(int id)
        {
            ClubCardVO clubCardVO = GetClubCardByID(id);
            return clubCardVO.Balance;

        }

        public int GetCardStatusByClubCardID(int id)
        {
            ClubCardVO clubCardVO = GetClubCardByID(id);
            return clubCardVO.CardStatus;
        }

        public void AddClubCard(Model.VO.ClubCardVO clubCard)
        {
            ClubCardData clubCardData = new ClubCardData();
            clubCard.ClubCardNo = SerialNoGenerator.GenClubCardNo();
            clubCard.ClubCardPwd = PwdHelper.MD5Encrypt(clubCard.ClubCardPwd);
            clubCardData.AddClubCard(Mapper.Map<ClubCardVO, ClubCardPO>(clubCard));
        }

        public List<Model.VO.ClubCardPkgVO> GetAvailablePkgs(int clubCardID)
        {
            ClubCardData clubCardData = new ClubCardData();

            List<ClubCardPkgVO> clubCardPkgVOList = new List<ClubCardPkgVO>();

            DataSet ds = clubCardData.GetAvailablePkgs(clubCardID);
            List<ClubCardPackagePO> clubCardPkgPOList = ds.GetEntity<List<ClubCardPackagePO>>();

            clubCardPkgPOList.ForEach(i =>
            {
                clubCardPkgVOList.Add(Mapper.Map<ClubCardPackagePO, ClubCardPkgVO>(i));
            });

            return clubCardPkgVOList;
        }

        public List<Model.VO.ClubCardPkgVO> GetUnavailablePkgs(int clubCardID)
        {
            ClubCardData clubCardData = new ClubCardData();

            List<ClubCardPkgVO> clubCardPkgVOList = new List<ClubCardPkgVO>();

            DataSet ds = clubCardData.GetUnavailablePkgs(clubCardID);
            List<ClubCardPackagePO> clubCardPkgPOList = ds.GetEntity<List<ClubCardPackagePO>>();

            clubCardPkgPOList.ForEach(i =>
            {
                clubCardPkgVOList.Add(Mapper.Map<ClubCardPackagePO, ClubCardPkgVO>(i));
            });

            return clubCardPkgVOList;
        }

        public List<Model.VO.ClubCardPkgDetailVO> GetDetailByClubCardPkgID(string id)
        {
            ClubCardData clubCardData = new ClubCardData();

            List<ClubCardPkgDetailVO> clubCardPkgDetailVOList = new List<ClubCardPkgDetailVO>();

            DataSet ds = clubCardData.GetDetailByClubCardPkgID(id);
            List<ClubCardPackageDetailPO> clubCardPkgDetailPOList = ds.GetEntity<List<ClubCardPackageDetailPO>>();

            clubCardPkgDetailPOList.ForEach(i =>
            {
                clubCardPkgDetailVOList.Add(Mapper.Map<ClubCardPackageDetailPO, ClubCardPkgDetailVO>(i));
            });

            return clubCardPkgDetailVOList;
        }

        public Model.VO.ClubCardPkgDetailVO GetClubCardPkgDetailByID(int id)
        {
            ClubCardData clubCardData = new ClubCardData();
            ClubCardPkgDetailVO clubCardPkgDetailVO = new ClubCardPkgDetailVO();
            ClubCardPackageDetailPO clubCardPkgDetailPO = clubCardData.GetClubCardPkgDetailByID(id);
            clubCardPkgDetailVO = Mapper.Map<ClubCardPackageDetailPO, ClubCardPkgDetailVO>(clubCardPkgDetailPO);

            return clubCardPkgDetailVO;
        }

        public Model.VO.ClubCardPkgVO GetClubCardPkgByID(string id)
        {
            ClubCardData clubCardData = new ClubCardData();
            ClubCardPkgVO clubCardPkgVO = new ClubCardPkgVO();
            ClubCardPackagePO clubCardPkgPO = clubCardData.GetClubCardPkgByID(id);
            clubCardPkgVO = Mapper.Map<ClubCardPackagePO, ClubCardPkgVO>(clubCardPkgPO);

            return clubCardPkgVO;
        }

        public bool CheckPwd(int clubCardID, string pwd)
        {
            ClubCardVO clubCardVO = GetClubCardByID(clubCardID);
            string dbPwd = clubCardVO.ClubCardPwd;
            string encryptPwd = PwdHelper.MD5Encrypt(pwd);

            if (encryptPwd.CompareTo(dbPwd) == 0)
                return true;
            else
                return false;
        }

        public void UpdatePwd(int clubCardID, string newPwd)
        {
            ClubCardData clubCardData = new ClubCardData();
            ClubCardVO clubCardVO = GetClubCardByID(clubCardID);

            string encryptPwd = PwdHelper.MD5Encrypt(newPwd);
            clubCardVO.ClubCardPwd = encryptPwd;

            clubCardData.UpdateClubCard(Mapper.Map<ClubCardVO, ClubCardPO>(clubCardVO));
        }

        public void UpdateClubCardStatus(int clubCardID, int status)
        {
            ClubCardData clubCardData = new ClubCardData();
            ClubCardVO clubCardVO = GetClubCardByID(clubCardID);

            if ((status != Convert.ToInt32(ClubCardStatus.OpenCard)) && (status != Convert.ToInt32(ClubCardStatus.ReportLoss)) && (status != Convert.ToInt32(ClubCardStatus.Froze)) && (status != Convert.ToInt32(ClubCardStatus.LogOff)) && (status != Convert.ToInt32(ClubCardStatus.Expire)))
            {
                throw new Exception("ClubCard Status invalid");
            }

            clubCardVO.CardStatus = status;
            clubCardData.UpdateClubCard(Mapper.Map<ClubCardVO, ClubCardPO>(clubCardVO));
        }

        public void UpdateClubCardNo(int clubCardID, string newClubCardNo)
        {
            ClubCardData clubCardData = new ClubCardData();
            ClubCardVO clubCardVO = GetClubCardByID(clubCardID);

            if (!string.IsNullOrEmpty(newClubCardNo.Trim()))
            {
                throw new Exception("New ClubCardNo cannot empty ");
            }

            clubCardVO.ClubCardNo = newClubCardNo;
            clubCardData.UpdateClubCard(Mapper.Map<ClubCardVO, ClubCardPO>(clubCardVO));
        }
    }
}
