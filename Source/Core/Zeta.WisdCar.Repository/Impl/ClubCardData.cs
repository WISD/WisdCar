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

        public System.Data.DataSet GetClubCards(Model.Entity.ClubCardQueryEntity entity)
        {
            StringBuilder strSql1 = new StringBuilder();
            StringBuilder strSql2 = new StringBuilder();

            if (!string.IsNullOrEmpty(entity.ClubCardNo.Trim()))
            {
                strSql1.AppendFormat(" ClubCardNo like '%{0}%' ", entity.ClubCardNo);
            }

            if (!string.IsNullOrEmpty(entity.Name.Trim()))
            {
                if (strSql1.Length > 0)
                    strSql1.AppendFormat(" And ");
                strSql1.AppendFormat(" Name like '%{0}%' ", entity.Name);
            }

            if (!string.IsNullOrEmpty(entity.MobileNo.Trim()))
            {

                if (strSql1.Length > 0)
                    strSql1.AppendFormat(" And ");
                strSql1.AppendFormat(" MobileNO like '%{0}%' ", entity.MobileNo);
            }

            if (strSql1.Length > 0)
                strSql1.AppendFormat(" And ");
            strSql1.AppendFormat(" ClubCardTypeID like %{0}% ", entity.ClubCardTypeID);

            //if (strSql1.Length > 0)
            //    strSql1.AppendFormat(" And ");
            //strSql1.AppendFormat(" OpenCardStore = {0} ", entity.StoreID);

            if (!string.IsNullOrEmpty(entity.SortName.Trim()))
            {
                strSql2.Append(entity.SortName);
                strSql2.Append(" ");
                strSql2.Append(entity.SortOrder.Trim());
            }
            string strWhere = strSql1.ToString();
            string orderby = strSql2.ToString();
            int startIndex = entity.Start;
            int endIndex = startIndex + entity.Length;
            return _daoClubCard.GetListByPage(strWhere, orderby, startIndex, endIndex);
        }

        public Model.PO.ClubCardPO GetClubCardByID(int id)
        {
            return _daoClubCard.GetModel(id);
        }
        public Model.PO.ClubCardPO GetCardByID(int cardid, int type)
        {
            return _daoClubCard.GetModel(cardid, type);
        }
        public Model.PO.ClubCardPO GetCardByCardNo(string cardNo)
        {
            return _daoClubCard.GetCardByCardNo(cardNo);
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
