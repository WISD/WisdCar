using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zeta.WisdCar.Model.PO;
using Zeta.WisdCar.Model.VO;
using Zeta.WisdCar.Repository;
using Zeta.WisdCar.Repository.Impl;

namespace Zeta.WisdCar.Business.CustClubCardModule
{
    public class ClubCardMgm : IClubCardMgm
    {

        public List<Model.VO.ClubCardVO> GetClubCards(Model.Entity.ClubCardQueryEntity entity)
        {
            throw new NotImplementedException();
        }

        public Model.VO.ClubCardVO GetClubCardByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Model.VO.ClubCardVO> GetClubCards(string key)
        {
            throw new NotImplementedException();
        }

        public decimal GetBalanceByClubCardID(int id)
        {
            throw new NotImplementedException();
        }

        public void AddClubCard(Model.VO.ClubCardVO clubCard)
        {
            ClubCardData clubCarddal = new ClubCardData();
            clubCarddal.AddCard(Mapper.Map<ClubCardVO, ClubCardPO>(clubCard));
        }

        public List<Model.VO.ClubCardPkgVO> GetAvailablePkgs(int clubCardID)
        {
            throw new NotImplementedException();
        }

        public List<Model.VO.ClubCardPkgVO> GetUnavailablePkgs(int clubCardID)
        {
            throw new NotImplementedException();
        }

        public List<Model.VO.ClubCardPkgDetailVO> GetDetailByClubCardPkgID(int id)
        {
            throw new NotImplementedException();
        }

        public Model.VO.ClubCardPkgDetailVO GetClubCardPkgDetailByID(int id)
        {
            throw new NotImplementedException();
        }

        public Model.VO.ClubCardPkgVO GetClubCardPkgByID(int id)
        {
            throw new NotImplementedException();
        }

        public bool CheckPwd(int clubCardID, string pwd)
        {
            throw new NotImplementedException();
        }

        public void UpdatePwd(int clubCardID, string newPwd)
        {
            throw new NotImplementedException();
        }

        public void UpdateClubCardStatus(int clubCardID, int status)
        {
            throw new NotImplementedException();
        }

        public void UpdateClubCardNo(int clubCardID, string newClubCardNo)
        {
            throw new NotImplementedException();
        }
    }
}
