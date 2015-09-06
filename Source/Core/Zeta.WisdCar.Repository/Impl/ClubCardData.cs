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
                strSql1.AppendFormat(" And ClubCardNo like '%{0}%' ", entity.ClubCardNo);
            }

            if (!string.IsNullOrEmpty(entity.Name.Trim()))
            {
                strSql1.AppendFormat(" And Name like '%{0}%' ", entity.Name);
            }

            if (!string.IsNullOrEmpty(entity.MobileNo.Trim()))
            {
                strSql1.AppendFormat(" And MobileNO like '%{0}%' ", entity.MobileNo);
            }

            strSql1.AppendFormat(" And ClubCardTypeID like '%{0}%' ", entity.ClubCardTypeID);
            //strSql1.AppendFormat(" And ICNo like '%{0}%' ", entity.ClubCardType);
            strSql1.AppendFormat(" And OpenCardStore = {0} ", entity.StoreID);

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

        public void AddClubCard(Model.PO.ClubCardPO clubCard)
        {
            _daoClubCard.Add(clubCard);
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

        public System.Data.DataSet GetDetailByClubCardPkgID(int id)
        {
            ClubCardPackageDetail _daoClubCardPkgDetail = new ClubCardPackageDetail();
            StringBuilder strSql = new StringBuilder();
            string strWhere = "";

            strSql.AppendFormat(" ClubCardPackageID = '%{0}%' ", id);
            strWhere = strSql.ToString();

            return _daoClubCardPkgDetail.GetList(strWhere);
        }

        public Model.PO.ClubCardPackageDetailPO GetClubCardPkgDetailByID(int id)
        {
            ClubCardPackageDetail _daoClubCardPkgDetail = new ClubCardPackageDetail();
            return _daoClubCardPkgDetail.GetModel(id);
        }

        public Model.PO.ClubCardPackagePO GetClubCardPkgByID(int id)
        {
            ClubCardPackage _daoClubCardPkg = new ClubCardPackage();
            return _daoClubCardPkg.GetModel(id);
        }

        public void UpdateClubCard(Model.PO.ClubCardPO clubCard)
        {
            _daoClubCard.Update(clubCard);
        }
    }
}
