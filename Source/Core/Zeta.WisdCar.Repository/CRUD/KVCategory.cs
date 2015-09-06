using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Zeta.WisdCar.Infrastructure.DBUtility;
namespace Zeta.WisdCar.Repository.CRUD
{
	/// <summary>
    /// 数据访问类:KVCategory
	/// </summary>
    internal partial class KVCategory
	{
        public KVCategory()
		{}
        #region  BasicMethod

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperSQL.GetMaxID("CategoryID", "KVCategory");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int CategoryID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from KVCategory");
            strSql.Append(" where CategoryID=@CategoryID");
            SqlParameter[] parameters = {
					new SqlParameter("@CategoryID", SqlDbType.Int,4)
			};
            parameters[0].Value = CategoryID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(WisdCar.Model.PO.KVCategoryPO model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into KVCategory(");
            strSql.Append("CategoryName,LogicalStatus,CreatorID,CreatedDate,LastModifierID,LastModifiedDate,Reserved1,Reserved2,Reserved3)");
            strSql.Append(" values (");
            strSql.Append("@CategoryName,@LogicalStatus,@CreatorID,@CreatedDate,@LastModifierID,@LastModifiedDate,@Reserved1,@Reserved2,@Reserved3)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@CategoryName", SqlDbType.NVarChar,50),
					new SqlParameter("@LogicalStatus", SqlDbType.Int,4),
					new SqlParameter("@CreatorID", SqlDbType.NVarChar,50),
					new SqlParameter("@CreatedDate", SqlDbType.DateTime),
					new SqlParameter("@LastModifierID", SqlDbType.NVarChar,50),
					new SqlParameter("@LastModifiedDate", SqlDbType.DateTime),
					new SqlParameter("@Reserved1", SqlDbType.NVarChar,100),
					new SqlParameter("@Reserved2", SqlDbType.NVarChar,100),
					new SqlParameter("@Reserved3", SqlDbType.NVarChar,100)};
            parameters[0].Value = model.CategoryName;
            parameters[1].Value = model.LogicalStatus;
            parameters[2].Value = model.CreatorID;
            parameters[3].Value = model.CreatedDate;
            parameters[4].Value = model.LastModifierID;
            parameters[5].Value = model.LastModifiedDate;
            parameters[6].Value = model.Reserved1;
            parameters[7].Value = model.Reserved2;
            parameters[8].Value = model.Reserved3;

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
        public bool Update(WisdCar.Model.PO.KVCategoryPO model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update KVCategory set ");
            strSql.Append("CategoryName=@CategoryName,");
            strSql.Append("LogicalStatus=@LogicalStatus,");
            strSql.Append("CreatorID=@CreatorID,");
            strSql.Append("CreatedDate=@CreatedDate,");
            strSql.Append("LastModifierID=@LastModifierID,");
            strSql.Append("LastModifiedDate=@LastModifiedDate,");
            strSql.Append("Reserved1=@Reserved1,");
            strSql.Append("Reserved2=@Reserved2,");
            strSql.Append("Reserved3=@Reserved3");
            strSql.Append(" where CategoryID=@CategoryID");
            SqlParameter[] parameters = {
					new SqlParameter("@CategoryName", SqlDbType.NVarChar,50),
					new SqlParameter("@LogicalStatus", SqlDbType.Int,4),
					new SqlParameter("@CreatorID", SqlDbType.NVarChar,50),
					new SqlParameter("@CreatedDate", SqlDbType.DateTime),
					new SqlParameter("@LastModifierID", SqlDbType.NVarChar,50),
					new SqlParameter("@LastModifiedDate", SqlDbType.DateTime),
					new SqlParameter("@Reserved1", SqlDbType.NVarChar,100),
					new SqlParameter("@Reserved2", SqlDbType.NVarChar,100),
					new SqlParameter("@Reserved3", SqlDbType.NVarChar,100),
					new SqlParameter("@CategoryID", SqlDbType.Int,4)};
            parameters[0].Value = model.CategoryName;
            parameters[1].Value = model.LogicalStatus;
            parameters[2].Value = model.CreatorID;
            parameters[3].Value = model.CreatedDate;
            parameters[4].Value = model.LastModifierID;
            parameters[5].Value = model.LastModifiedDate;
            parameters[6].Value = model.Reserved1;
            parameters[7].Value = model.Reserved2;
            parameters[8].Value = model.Reserved3;
            parameters[9].Value = model.CategoryID;

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
        public bool Delete(int CategoryID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from KVCategory ");
            strSql.Append(" where CategoryID=@CategoryID");
            SqlParameter[] parameters = {
					new SqlParameter("@CategoryID", SqlDbType.Int,4)
			};
            parameters[0].Value = CategoryID;

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
        public bool DeleteList(string CategoryIDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from KVCategory ");
            strSql.Append(" where CategoryID in (" + CategoryIDlist + ")  ");
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
        public WisdCar.Model.PO.KVCategoryPO GetModel(int CategoryID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 CategoryID,CategoryName,LogicalStatus,CreatorID,CreatedDate,LastModifierID,LastModifiedDate,Reserved1,Reserved2,Reserved3 from KVCategory ");
            strSql.Append(" where CategoryID=@CategoryID");
            SqlParameter[] parameters = {
					new SqlParameter("@CategoryID", SqlDbType.Int,4)
			};
            parameters[0].Value = CategoryID;

            WisdCar.Model.PO.KVCategoryPO model = new WisdCar.Model.PO.KVCategoryPO();
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
        public WisdCar.Model.PO.KVCategoryPO DataRowToModel(DataRow row)
        {
            WisdCar.Model.PO.KVCategoryPO model = new WisdCar.Model.PO.KVCategoryPO();
            if (row != null)
            {
                if (row["CategoryID"] != null && row["CategoryID"].ToString() != "")
                {
                    model.CategoryID = int.Parse(row["CategoryID"].ToString());
                }
                if (row["CategoryName"] != null)
                {
                    model.CategoryName = row["CategoryName"].ToString();
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
            strSql.Append("select CategoryID,CategoryName,LogicalStatus,CreatorID,CreatedDate,LastModifierID,LastModifiedDate,Reserved1,Reserved2,Reserved3 ");
            strSql.Append(" FROM KVCategory ");
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
            strSql.Append(" CategoryID,CategoryName,LogicalStatus,CreatorID,CreatedDate,LastModifierID,LastModifiedDate,Reserved1,Reserved2,Reserved3 ");
            strSql.Append(" FROM KVCategory ");
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
            strSql.Append("select count(1) FROM KVCategory ");
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
                strSql.Append("order by T.CategoryID desc");
            }
            strSql.Append(")AS Row, T.*  from KVCategory T ");
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
            parameters[0].Value = "KVCategory";
            parameters[1].Value = "CategoryID";
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

