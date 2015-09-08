using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zeta.WisdCar.Infrastructure.DBUtility;
using Zeta.WisdCar.Model.PO;
using Zeta.WisdCar.Repository.CRUD;

namespace Zeta.WisdCar.Repository.Impl
{
    public class ClubCardPackageData : IClubCardPackageData
    {
        private ClubCardPackage _daoClubCardPackage = new ClubCardPackage();
        public System.Data.DataSet GetPkgsByClubCardID(int clubCardID)
        {
            StringBuilder strSql = new StringBuilder();
            string strWhere = "";
            strSql.AppendFormat(" ClubCardID = %{0}% ", clubCardID);

            strWhere = strSql.ToString();
            return _daoClubCardPackage.GetList(strWhere);
        }

        public Model.PO.ClubCardPackagePO GetClubCardPkgByID(int clubCardPkgID)
        {
            return _daoClubCardPackage.GetModel(clubCardPkgID);
        }

        public System.Data.DataSet GetClubCardPkgDetailsByID(int clubCardPkgID)
        {
            ClubCardPackageDetail _daoClubCardPkgDetail = new ClubCardPackageDetail();
            StringBuilder strSql = new StringBuilder();
            string strWhere = "";
            strSql.AppendFormat(" ClubCardPackageID = %{0}% ", clubCardPkgID);

            strWhere = strSql.ToString();
            return _daoClubCardPkgDetail.GetList(strWhere);
        }

        public void AddClubCardPkg(Model.PO.ClubCardPackagePO clubCardpkg)
        {
            _daoClubCardPackage.Add(clubCardpkg);
        }

        public void AddClubCardPkgDetail(Model.PO.ClubCardPackageDetailPO clubCardpkgDetail)
        {
            ClubCardPackageDetail _daoClubCardPkgDetail = new ClubCardPackageDetail();
            _daoClubCardPkgDetail.Add(clubCardpkgDetail);
        }

        public void AddClubCardPkgDetailList(List<Model.PO.ClubCardPackageDetailPO> clubCardpkgDetailList)
        {
            foreach (var item in clubCardpkgDetailList)
            {
                AddClubCardPkgDetail(item);
            }
        }

        public void EditClubCardPkg(Model.PO.ClubCardPackagePO clubCardpkg)
        {
            _daoClubCardPackage.Update(clubCardpkg);
        }

        public void EditClubCardPkgDetail(ClubCardPackageDetailPO clubCardpkgDetail)
        {
            ClubCardPackageDetail _daoClubCardPkgDetail = new ClubCardPackageDetail();
            _daoClubCardPkgDetail.Update(clubCardpkgDetail);
        }

        public void EditClubCardPkgDetailList(List<ClubCardPackageDetailPO> clubCardpkgDetailList)
        {
            foreach (var item in clubCardpkgDetailList)
            {
                EditClubCardPkgDetail(item);
            }
        }

        public void DelClubCardPkg(int id)
        {
            _daoClubCardPackage.Delete(id);
        }

        public void DelClubCardPkgDetail(int clubCardPkgID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from ClubCardPackageDetail ");
            strSql.Append(" where ClubCardPackageID=@ClubCardPackageID");
            SqlParameter[] parameters = {
					new SqlParameter("@ClubCardPackageID", SqlDbType.Int,4)
			};
            parameters[0].Value = clubCardPkgID;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                //succ
            }
            else
            {
                throw new Exception("删除套餐明细失败");
            }
        }

    }
}
