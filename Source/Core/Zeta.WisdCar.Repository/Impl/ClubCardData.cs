using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zeta.WisdCar.Infrastructure;
using Zeta.WisdCar.Repository.CRUD;

namespace Zeta.WisdCar.Repository.Impl
{
    public class ClubCardData : IClubCardData
    {
        private ClubCard _daoClubCard = new ClubCard();

        public System.Data.DataSet GetClubCards(Model.Entity.ClubCardQueryEntity filter)
        {
            StringBuilder strsql1 = new StringBuilder();
            StringBuilder strsql2 = new StringBuilder();
            if (!string.IsNullOrEmpty(filter.ClubCardNo))
            {
                strsql1.Append(string.Format(" and clubcardno like '%{0}%'", filter.ClubCardNo));
            }
            if (filter.ClubCardTypeID > 0)
            {
                strsql1.AppendFormat(" and clubcardtypeid ={0}", filter.ClubCardTypeID);
            }
            if (!string.IsNullOrEmpty(filter.MobileNo))
            {
                strsql1.AppendFormat(" and mobileno like '%{0}%'", filter.MobileNo);
            }
            if (!string.IsNullOrEmpty(filter.Name))
            {
                strsql1.AppendFormat(" and custname like '%{0}%'", filter.Name);
            }
            if (!string.IsNullOrEmpty(filter.StoreName))
            {
                strsql1.AppendFormat(" and opencardstore like '%{0}%'", filter.StoreName);
            }
            if (filter.CardStatus >= 0)
            {
                strsql1.AppendFormat(" and cardstatus={0}", filter.CardStatus);
            }

            if (!string.IsNullOrEmpty(filter.SortName.Trim()))
            {
                strsql2.Append(filter.SortName);
                strsql2.Append(" ");
                strsql2.Append(filter.SortOrder.Trim());
            }

            string sqlWhere = strsql1.ToString();
            string orderby = strsql2.ToString();
            int startindex = filter.Start;
            int endindex = filter.Start + filter.Length;

            return _daoClubCard.GetListByPage(sqlWhere, orderby, startindex, endindex);
        }

        public Model.PO.ClubCardPO GetClubCardByID(int id)
        {
            return _daoClubCard.GetModel(id);
        }
        public Model.PO.ClubCardPO GetCardByID(int cardid, int type)
        {
            return _daoClubCard.GetModel(cardid, type);
        }
        public System.Data.DataSet GetClubCards(string key)
        {
            StringBuilder strSql = new StringBuilder();
            string strWhere = "";
            if (!string.IsNullOrEmpty(key.Trim()))
            {
                strSql.AppendFormat(" MobileNO like '%{0}%' OR  ClubCardNo like '%{1}%' ", key,key);
            }
            strWhere = strSql.ToString();
            return _daoClubCard.GetList(strWhere);
        }
        public void AddCard(Model.PO.ClubCardPO card)
        {
            _daoClubCard.Add(card);
        }
        public void AddClubCard(Model.PO.ClubCardPO clubCard)
        {
            _daoClubCard.Add(clubCard);
        }
        public void EditCard(Model.PO.ClubCardPO card)
        {
            _daoClubCard.UpdateModel(card);
        }
        public void UpdatePwd(int clubCardID, string p)
        {
            _daoClubCard.UpdatePwd(clubCardID, p);
        }
        public void UpdateClubCardStatus(int clubCardID, int status)
        {
            _daoClubCard.UpdateClubCardStatus(clubCardID, status);
        }
        public void UpdateClubCardNo(int clubCardID, string newClubCardNo)
        {
            _daoClubCard.UpdateClubCardNo(clubCardID, newClubCardNo);
        }
        public System.Data.DataSet GetAvailablePkgs(int clubCardID)
        {
            ClubCardPackage _daoClubCardPkg = new ClubCardPackage();
            StringBuilder strSql = new StringBuilder();
            string strWhere = "";

            strSql.AppendFormat(" ClubCardID = '%{0}%' AND  PackageStatus = %{1}% ", clubCardID, CardSPackageStatus.Available);
            strWhere = strSql.ToString();

            return _daoClubCardPkg.GetList(strWhere);
        }

        public System.Data.DataSet GetUnavailablePkgs(int clubCardID)
        {
            ClubCardPackage _daoClubCardPkg = new ClubCardPackage();
            StringBuilder strSql = new StringBuilder();
            string strWhere = "";

            strSql.AppendFormat(" ClubCardID = '%{0}%' AND  PackageStatus = %{1}% ", clubCardID, CardSPackageStatus.Unavailable);
            strWhere = strSql.ToString();

            return _daoClubCardPkg.GetList(strWhere);
        }

        public System.Data.DataSet GetDetailByClubCardPkgID(string id)
        {
            ClubCardPackageDetail _daoClubCardPkgDetail = new ClubCardPackageDetail();
            StringBuilder strSql = new StringBuilder();
            string strWhere = "";

            strSql.AppendFormat(" ClubCardPackageID = '{0}' ", id);
            strWhere = strSql.ToString();

            return _daoClubCardPkgDetail.GetList(strWhere);
        }

        public Model.PO.ClubCardPackageDetailPO GetClubCardPkgDetailByID(int id)
        {
            ClubCardPackageDetail _daoClubCardPkgDetail = new ClubCardPackageDetail();
            return _daoClubCardPkgDetail.GetModel(id);
        }

        public Model.PO.ClubCardPackagePO GetClubCardPkgByID(string id)
        {
            ClubCardPackage _daoClubCardPkg = new ClubCardPackage();
            return _daoClubCardPkg.GetModel(id);
        }

        public void UpdateClubCard(Model.PO.ClubCardPO clubCard)
        {
            _daoClubCard.Update(clubCard);
        }


        public void DelCard(int id)
        {
            _daoClubCard.Delete(id);
        }
    }
}
