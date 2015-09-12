using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Zeta.WisdCar.Infrastructure.DBUtility;
namespace Zeta.WisdCar.Repository.CRUD
{
	/// <summary>
	/// 数据访问类:ClubCardPackage
	/// </summary>
	internal partial class ClubCardPackage
	{
		public ClubCardPackage()
		{}
        #region  BasicMethod

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperSQL.GetMaxID("ClubCardPackageID", "ClubCardPackage");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string ClubCardPackageID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from ClubCardPackage");
            strSql.Append(" where ClubCardPackageID=@ClubCardPackageID");
            SqlParameter[] parameters = {
					new SqlParameter("@ClubCardPackageID", SqlDbType.NVarChar,50)
			};
            parameters[0].Value = ClubCardPackageID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(WisdCar.Model.PO.ClubCardPackagePO model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into ClubCardPackage(");
            strSql.Append("ClubCardPackageID,PackageName,OriginalAmount,ActualAmount,DiscountRate,DiscountInfo,PackageStatus,Salesman,SalesTime,SaleStore,PackageID,ClubCardID,LogicalStatus,CreatorID,CreatedDate,LastModifierID,LastModifiedDate,Reserved1,Reserved2,Reserved3)");
            strSql.Append(" values (");
            strSql.Append("@ClubCardPackageID,@PackageName,@OriginalAmount,@ActualAmount,@DiscountRate,@DiscountInfo,@PackageStatus,@Salesman,@SalesTime,@SaleStore,@PackageID,@ClubCardID,@LogicalStatus,@CreatorID,@CreatedDate,@LastModifierID,@LastModifiedDate,@Reserved1,@Reserved2,@Reserved3)");
            SqlParameter[] parameters = {
					new SqlParameter("@ClubCardPackageID", SqlDbType.NVarChar,50),
					new SqlParameter("@PackageName", SqlDbType.NVarChar,50),
					new SqlParameter("@OriginalAmount", SqlDbType.Decimal,5),
					new SqlParameter("@ActualAmount", SqlDbType.Decimal,5),
					new SqlParameter("@DiscountRate", SqlDbType.Decimal,5),
					new SqlParameter("@DiscountInfo", SqlDbType.NVarChar,50),
					new SqlParameter("@PackageStatus", SqlDbType.Int,4),
					new SqlParameter("@Salesman", SqlDbType.NVarChar,50),
					new SqlParameter("@SalesTime", SqlDbType.DateTime),
					new SqlParameter("@SaleStore", SqlDbType.NVarChar,50),
					new SqlParameter("@PackageID", SqlDbType.Int,4),
					new SqlParameter("@ClubCardID", SqlDbType.Int,4),
					new SqlParameter("@LogicalStatus", SqlDbType.Int,4),
					new SqlParameter("@CreatorID", SqlDbType.NVarChar,50),
					new SqlParameter("@CreatedDate", SqlDbType.DateTime),
					new SqlParameter("@LastModifierID", SqlDbType.NVarChar,50),
					new SqlParameter("@LastModifiedDate", SqlDbType.DateTime),
					new SqlParameter("@Reserved1", SqlDbType.NVarChar,100),
					new SqlParameter("@Reserved2", SqlDbType.NVarChar,100),
					new SqlParameter("@Reserved3", SqlDbType.NVarChar,100)};
			parameters[0].Value = model.ClubCardPackageID;
			parameters[1].Value = model.PackageName;
			parameters[2].Value = model.OriginalAmount;
			parameters[3].Value = model.ActualAmount;
			parameters[4].Value = model.DiscountRate;
			parameters[5].Value = model.DiscountInfo;
			parameters[6].Value = model.PackageStatus;
			parameters[7].Value = model.Salesman;
			parameters[8].Value = model.SalesTime;
			parameters[9].Value = model.SaleStore;
			parameters[10].Value = model.PackageID;
			parameters[11].Value = model.ClubCardID;
			parameters[12].Value = model.LogicalStatus;
			parameters[13].Value = model.CreatorID;
			parameters[14].Value = model.CreatedDate;
			parameters[15].Value = model.LastModifierID;
			parameters[16].Value = model.LastModifiedDate;
			parameters[17].Value = model.Reserved1;
			parameters[18].Value = model.Reserved2;
			parameters[19].Value = model.Reserved3;

            object obj = DbHelperSQL.GetSingle(strSql.ToString(), parameters);
            if (obj == null)
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(obj);
            }
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(WisdCar.Model.PO.ClubCardPackagePO model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update ClubCardPackage set ");
            strSql.Append("PackageName=@PackageName,");
            strSql.Append("OriginalAmount=@OriginalAmount,");
            strSql.Append("ActualAmount=@ActualAmount,");
            strSql.Append("DiscountRate=@DiscountRate,");
            strSql.Append("DiscountInfo=@DiscountInfo,");
            strSql.Append("PackageStatus=@PackageStatus,");
            strSql.Append("Salesman=@Salesman,");
            strSql.Append("SalesTime=@SalesTime,");
            strSql.Append("SaleStore=@SaleStore,");
            strSql.Append("PackageID=@PackageID,");
            strSql.Append("ClubCardID=@ClubCardID,");
            strSql.Append("LogicalStatus=@LogicalStatus,");
            strSql.Append("CreatorID=@CreatorID,");
            strSql.Append("CreatedDate=@CreatedDate,");
            strSql.Append("LastModifierID=@LastModifierID,");
            strSql.Append("LastModifiedDate=@LastModifiedDate,");
            strSql.Append("Reserved1=@Reserved1,");
            strSql.Append("Reserved2=@Reserved2,");
            strSql.Append("Reserved3=@Reserved3");
            strSql.Append(" where ClubCardPackageID=@ClubCardPackageID");
            SqlParameter[] parameters = {
					new SqlParameter("@PackageName", SqlDbType.NVarChar,50),
					new SqlParameter("@OriginalAmount", SqlDbType.Decimal,5),
					new SqlParameter("@ActualAmount", SqlDbType.Decimal,5),
					new SqlParameter("@DiscountRate", SqlDbType.Decimal,5),
					new SqlParameter("@DiscountInfo", SqlDbType.NVarChar,50),
					new SqlParameter("@PackageStatus", SqlDbType.Int,4),
					new SqlParameter("@Salesman", SqlDbType.NVarChar,50),
					new SqlParameter("@SalesTime", SqlDbType.DateTime),
					new SqlParameter("@SaleStore", SqlDbType.NVarChar,50),
					new SqlParameter("@PackageID", SqlDbType.Int,4),
					new SqlParameter("@ClubCardID", SqlDbType.Int,4),
					new SqlParameter("@LogicalStatus", SqlDbType.Int,4),
					new SqlParameter("@CreatorID", SqlDbType.NVarChar,50),
					new SqlParameter("@CreatedDate", SqlDbType.DateTime),
					new SqlParameter("@LastModifierID", SqlDbType.NVarChar,50),
					new SqlParameter("@LastModifiedDate", SqlDbType.DateTime),
					new SqlParameter("@Reserved1", SqlDbType.NVarChar,100),
					new SqlParameter("@Reserved2", SqlDbType.NVarChar,100),
					new SqlParameter("@Reserved3", SqlDbType.NVarChar,100),
					new SqlParameter("@ClubCardPackageID", SqlDbType.NVarChar,50)};
            parameters[0].Value = model.PackageName;
            parameters[1].Value = model.OriginalAmount;
            parameters[2].Value = model.ActualAmount;
            parameters[3].Value = model.DiscountRate;
            parameters[4].Value = model.DiscountInfo;
            parameters[5].Value = model.PackageStatus;
            parameters[6].Value = model.Salesman;
            parameters[7].Value = model.SalesTime;
            parameters[8].Value = model.SaleStore;
            parameters[9].Value = model.PackageID;
            parameters[10].Value = model.ClubCardID;
            parameters[11].Value = model.LogicalStatus;
            parameters[12].Value = model.CreatorID;
            parameters[13].Value = model.CreatedDate;
            parameters[14].Value = model.LastModifierID;
            parameters[15].Value = model.LastModifiedDate;
            parameters[16].Value = model.Reserved1;
            parameters[17].Value = model.Reserved2;
            parameters[18].Value = model.Reserved3;
            parameters[19].Value = model.ClubCardPackageID;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(string ClubCardPackageID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from ClubCardPackage ");
            strSql.Append(" where ClubCardPackageID=@ClubCardPackageID");
            SqlParameter[] parameters = {
					new SqlParameter("@ClubCardPackageID", SqlDbType.NVarChar,50)
			};
            parameters[0].Value = ClubCardPackageID;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 批量删除数据
        /// </summary>
        public bool DeleteList(string ClubCardPackageIDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from ClubCardPackage ");
            strSql.Append(" where ClubCardPackageID in (" + ClubCardPackageIDlist + ")  ");
            int rows = DbHelperSQL.ExecuteSql(strSql.ToString());
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public WisdCar.Model.PO.ClubCardPackagePO GetModel(string ClubCardPackageID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ClubCardPackageID,PackageName,OriginalAmount,ActualAmount,DiscountRate,DiscountInfo,PackageStatus,Salesman,SalesTime,SaleStore,PackageID,ClubCardID,LogicalStatus,CreatorID,CreatedDate,LastModifierID,LastModifiedDate,Reserved1,Reserved2,Reserved3 from ClubCardPackage ");
            strSql.Append(" where ClubCardPackageID=@ClubCardPackageID");
            SqlParameter[] parameters = {
					new SqlParameter("@ClubCardPackageID", SqlDbType.NVarChar,50)
			};
            parameters[0].Value = ClubCardPackageID;

            WisdCar.Model.PO.ClubCardPackagePO model = new WisdCar.Model.PO.ClubCardPackagePO();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                return DataRowToModel(ds.Tables[0].Rows[0]);
            }
            else
            {
                return null;
            }
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public WisdCar.Model.PO.ClubCardPackagePO DataRowToModel(DataRow row)
        {
            WisdCar.Model.PO.ClubCardPackagePO model = new WisdCar.Model.PO.ClubCardPackagePO();
            if (row != null)
            {
                if (row["ClubCardPackageID"] != null && row["ClubCardPackageID"].ToString() != "")
                {
                    model.ClubCardPackageID = row["ClubCardPackageID"].ToString();
                }
                if (row["PackageName"] != null)
                {
                    model.PackageName = row["PackageName"].ToString();
                }
                if (row["OriginalAmount"] != null && row["OriginalAmount"].ToString() != "")
                {
                    model.OriginalAmount = decimal.Parse(row["OriginalAmount"].ToString());
                }
                if (row["ActualAmount"] != null && row["ActualAmount"].ToString() != "")
                {
                    model.ActualAmount = decimal.Parse(row["ActualAmount"].ToString());
                }
                if (row["DiscountRate"] != null && row["DiscountRate"].ToString() != "")
                {
                    model.DiscountRate = decimal.Parse(row["DiscountRate"].ToString());
                }
                if (row["DiscountInfo"] != null)
                {
                    model.DiscountInfo = row["DiscountInfo"].ToString();
                }
                if (row["PackageStatus"] != null && row["PackageStatus"].ToString() != "")
                {
                    model.PackageStatus = int.Parse(row["PackageStatus"].ToString());
                }
                if (row["Salesman"] != null)
                {
                    model.Salesman = row["Salesman"].ToString();
                }
                if (row["SalesTime"] != null && row["SalesTime"].ToString() != "")
                {
                    model.SalesTime = DateTime.Parse(row["SalesTime"].ToString());
                }
                if (row["SaleStore"] != null)
                {
                    model.SaleStore = row["SaleStore"].ToString();
                }
                if (row["PackageID"] != null && row["PackageID"].ToString() != "")
                {
                    model.PackageID = int.Parse(row["PackageID"].ToString());
                }
                if (row["ClubCardID"] != null && row["ClubCardID"].ToString() != "")
                {
                    model.ClubCardID = int.Parse(row["ClubCardID"].ToString());
                }
                if (row["LogicalStatus"] != null && row["LogicalStatus"].ToString() != "")
                {
                    model.LogicalStatus = int.Parse(row["LogicalStatus"].ToString());
                }
                if (row["CreatorID"] != null)
                {
                    model.CreatorID = row["CreatorID"].ToString();
                }
                if (row["CreatedDate"] != null && row["CreatedDate"].ToString() != "")
                {
                    model.CreatedDate = DateTime.Parse(row["CreatedDate"].ToString());
                }
                if (row["LastModifierID"] != null)
                {
                    model.LastModifierID = row["LastModifierID"].ToString();
                }
                if (row["LastModifiedDate"] != null && row["LastModifiedDate"].ToString() != "")
                {
                    model.LastModifiedDate = DateTime.Parse(row["LastModifiedDate"].ToString());
                }
                if (row["Reserved1"] != null)
                {
                    model.Reserved1 = row["Reserved1"].ToString();
                }
                if (row["Reserved2"] != null)
                {
                    model.Reserved2 = row["Reserved2"].ToString();
                }
                if (row["Reserved3"] != null)
                {
                    model.Reserved3 = row["Reserved3"].ToString();
                }
            }
            return model;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ClubCardPackageID,PackageName,OriginalAmount,ActualAmount,DiscountRate,DiscountInfo,PackageStatus,Salesman,SalesTime,SaleStore,PackageID,ClubCardID,LogicalStatus,CreatorID,CreatedDate,LastModifierID,LastModifiedDate,Reserved1,Reserved2,Reserved3 ");
            strSql.Append(" FROM ClubCardPackage ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ");
            if (Top > 0)
            {
                strSql.Append(" top " + Top.ToString());
            }
            strSql.Append(" ClubCardPackageID,PackageName,OriginalAmount,ActualAmount,DiscountRate,DiscountInfo,PackageStatus,Salesman,SalesTime,SaleStore,PackageID,ClubCardID,LogicalStatus,CreatorID,CreatedDate,LastModifierID,LastModifiedDate,Reserved1,Reserved2,Reserved3 ");
            strSql.Append(" FROM ClubCardPackage ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM ClubCardPackage ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            object obj = DbHelperSQL.GetSingle(strSql.ToString());
            if (obj == null)
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(obj);
            }
        }
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT * FROM ( ");
            strSql.Append(" SELECT ROW_NUMBER() OVER (");
            if (!string.IsNullOrEmpty(orderby.Trim()))
            {
                strSql.Append("order by T." + orderby);
            }
            else
            {
                strSql.Append("order by T.ClubCardPackageID desc");
            }
            strSql.Append(")AS Row, T.*  from ClubCardPackage T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return DbHelperSQL.Query(strSql.ToString());
        }

        /*
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetList(int PageSize,int PageIndex,string strWhere)
        {
            SqlParameter[] parameters = {
                    new SqlParameter("@tblName", SqlDbType.VarChar, 255),
                    new SqlParameter("@fldName", SqlDbType.VarChar, 255),
                    new SqlParameter("@PageSize", SqlDbType.Int),
                    new SqlParameter("@PageIndex", SqlDbType.Int),
                    new SqlParameter("@IsReCount", SqlDbType.Bit),
                    new SqlParameter("@OrderType", SqlDbType.Bit),
                    new SqlParameter("@strWhere", SqlDbType.VarChar,1000),
                    };
            parameters[0].Value = "ClubCardPackage";
            parameters[1].Value = "ClubCardPackageID";
            parameters[2].Value = PageSize;
            parameters[3].Value = PageIndex;
            parameters[4].Value = 0;
            parameters[5].Value = 0;
            parameters[6].Value = strWhere;	
            return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
        }*/

        #endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

