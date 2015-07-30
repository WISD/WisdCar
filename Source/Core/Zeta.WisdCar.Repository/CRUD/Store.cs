using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Zeta.WisdCar.Infrastructure.DBUtility;
namespace Zeta.WisdCar.Repository.CRUD
{
	/// <summary>
	/// 数据访问类:Store
	/// </summary>
    internal partial class Store
	{
		public Store()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("StoreID", "Store"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int StoreID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Store");
			strSql.Append(" where StoreID=@StoreID");
			SqlParameter[] parameters = {
					new SqlParameter("@StoreID", SqlDbType.Int,4)
			};
			parameters[0].Value = StoreID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(WisdCar.Model.PO.StorePO model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Store(");
			strSql.Append("StoreName,StoreAddress,StorePhone,Fax,LogicalStatus,CreatorID,CreatedDate,LastModifierID,LastModifiedDate,Reserved1,Reserved2,Reserved3)");
			strSql.Append(" values (");
			strSql.Append("@StoreName,@StoreAddress,@StorePhone,@Fax,@LogicalStatus,@CreatorID,@CreatedDate,@LastModifierID,@LastModifiedDate,@Reserved1,@Reserved2,@Reserved3)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@StoreName", SqlDbType.NVarChar,50),
					new SqlParameter("@StoreAddress", SqlDbType.NVarChar,50),
					new SqlParameter("@StorePhone", SqlDbType.NVarChar,50),
					new SqlParameter("@Fax", SqlDbType.NVarChar,50),
					new SqlParameter("@LogicalStatus", SqlDbType.Int,4),
					new SqlParameter("@CreatorID", SqlDbType.NVarChar,50),
					new SqlParameter("@CreatedDate", SqlDbType.DateTime),
					new SqlParameter("@LastModifierID", SqlDbType.NVarChar,50),
					new SqlParameter("@LastModifiedDate", SqlDbType.DateTime),
					new SqlParameter("@Reserved1", SqlDbType.NVarChar,100),
					new SqlParameter("@Reserved2", SqlDbType.NVarChar,100),
					new SqlParameter("@Reserved3", SqlDbType.NVarChar,100)};
			parameters[0].Value = model.StoreName;
			parameters[1].Value = model.StoreAddress;
			parameters[2].Value = model.StorePhone;
			parameters[3].Value = model.Fax;
			parameters[4].Value = model.LogicalStatus;
			parameters[5].Value = model.CreatorID;
			parameters[6].Value = model.CreatedDate;
			parameters[7].Value = model.LastModifierID;
			parameters[8].Value = model.LastModifiedDate;
			parameters[9].Value = model.Reserved1;
			parameters[10].Value = model.Reserved2;
			parameters[11].Value = model.Reserved3;

			object obj = DbHelperSQL.GetSingle(strSql.ToString(),parameters);
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
		public bool Update(WisdCar.Model.PO.StorePO model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Store set ");
			strSql.Append("StoreName=@StoreName,");
			strSql.Append("StoreAddress=@StoreAddress,");
			strSql.Append("StorePhone=@StorePhone,");
			strSql.Append("Fax=@Fax,");
			strSql.Append("LogicalStatus=@LogicalStatus,");
			strSql.Append("CreatorID=@CreatorID,");
			strSql.Append("CreatedDate=@CreatedDate,");
			strSql.Append("LastModifierID=@LastModifierID,");
			strSql.Append("LastModifiedDate=@LastModifiedDate,");
			strSql.Append("Reserved1=@Reserved1,");
			strSql.Append("Reserved2=@Reserved2,");
			strSql.Append("Reserved3=@Reserved3");
			strSql.Append(" where StoreID=@StoreID");
			SqlParameter[] parameters = {
					new SqlParameter("@StoreName", SqlDbType.NVarChar,50),
					new SqlParameter("@StoreAddress", SqlDbType.NVarChar,50),
					new SqlParameter("@StorePhone", SqlDbType.NVarChar,50),
					new SqlParameter("@Fax", SqlDbType.NVarChar,50),
					new SqlParameter("@LogicalStatus", SqlDbType.Int,4),
					new SqlParameter("@CreatorID", SqlDbType.NVarChar,50),
					new SqlParameter("@CreatedDate", SqlDbType.DateTime),
					new SqlParameter("@LastModifierID", SqlDbType.NVarChar,50),
					new SqlParameter("@LastModifiedDate", SqlDbType.DateTime),
					new SqlParameter("@Reserved1", SqlDbType.NVarChar,100),
					new SqlParameter("@Reserved2", SqlDbType.NVarChar,100),
					new SqlParameter("@Reserved3", SqlDbType.NVarChar,100),
					new SqlParameter("@StoreID", SqlDbType.Int,4)};
			parameters[0].Value = model.StoreName;
			parameters[1].Value = model.StoreAddress;
			parameters[2].Value = model.StorePhone;
			parameters[3].Value = model.Fax;
			parameters[4].Value = model.LogicalStatus;
			parameters[5].Value = model.CreatorID;
			parameters[6].Value = model.CreatedDate;
			parameters[7].Value = model.LastModifierID;
			parameters[8].Value = model.LastModifiedDate;
			parameters[9].Value = model.Reserved1;
			parameters[10].Value = model.Reserved2;
			parameters[11].Value = model.Reserved3;
			parameters[12].Value = model.StoreID;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
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
		public bool Delete(int StoreID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Store ");
			strSql.Append(" where StoreID=@StoreID");
			SqlParameter[] parameters = {
					new SqlParameter("@StoreID", SqlDbType.Int,4)
			};
			parameters[0].Value = StoreID;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
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
		public bool DeleteList(string StoreIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Store ");
			strSql.Append(" where StoreID in ("+StoreIDlist + ")  ");
			int rows=DbHelperSQL.ExecuteSql(strSql.ToString());
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
		public WisdCar.Model.PO.StorePO GetModel(int StoreID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 StoreID,StoreName,StoreAddress,StorePhone,Fax,LogicalStatus,CreatorID,CreatedDate,LastModifierID,LastModifiedDate,Reserved1,Reserved2,Reserved3 from Store ");
			strSql.Append(" where StoreID=@StoreID");
			SqlParameter[] parameters = {
					new SqlParameter("@StoreID", SqlDbType.Int,4)
			};
			parameters[0].Value = StoreID;

			WisdCar.Model.PO.StorePO model=new WisdCar.Model.PO.StorePO();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
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
		public WisdCar.Model.PO.StorePO DataRowToModel(DataRow row)
		{
			WisdCar.Model.PO.StorePO model=new WisdCar.Model.PO.StorePO();
			if (row != null)
			{
				if(row["StoreID"]!=null && row["StoreID"].ToString()!="")
				{
					model.StoreID=int.Parse(row["StoreID"].ToString());
				}
				if(row["StoreName"]!=null)
				{
					model.StoreName=row["StoreName"].ToString();
				}
				if(row["StoreAddress"]!=null)
				{
					model.StoreAddress=row["StoreAddress"].ToString();
				}
				if(row["StorePhone"]!=null)
				{
					model.StorePhone=row["StorePhone"].ToString();
				}
				if(row["Fax"]!=null)
				{
					model.Fax=row["Fax"].ToString();
				}
				if(row["LogicalStatus"]!=null && row["LogicalStatus"].ToString()!="")
				{
					model.LogicalStatus=int.Parse(row["LogicalStatus"].ToString());
				}
				if(row["CreatorID"]!=null)
				{
					model.CreatorID=row["CreatorID"].ToString();
				}
				if(row["CreatedDate"]!=null && row["CreatedDate"].ToString()!="")
				{
					model.CreatedDate=DateTime.Parse(row["CreatedDate"].ToString());
				}
				if(row["LastModifierID"]!=null)
				{
					model.LastModifierID=row["LastModifierID"].ToString();
				}
				if(row["LastModifiedDate"]!=null && row["LastModifiedDate"].ToString()!="")
				{
					model.LastModifiedDate=DateTime.Parse(row["LastModifiedDate"].ToString());
				}
				if(row["Reserved1"]!=null)
				{
					model.Reserved1=row["Reserved1"].ToString();
				}
				if(row["Reserved2"]!=null)
				{
					model.Reserved2=row["Reserved2"].ToString();
				}
				if(row["Reserved3"]!=null)
				{
					model.Reserved3=row["Reserved3"].ToString();
				}
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select StoreID,StoreName,StoreAddress,StorePhone,Fax,LogicalStatus,CreatorID,CreatedDate,LastModifierID,LastModifiedDate,Reserved1,Reserved2,Reserved3 ");
			strSql.Append(" FROM Store ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			if(Top>0)
			{
				strSql.Append(" top "+Top.ToString());
			}
			strSql.Append(" StoreID,StoreName,StoreAddress,StorePhone,Fax,LogicalStatus,CreatorID,CreatedDate,LastModifierID,LastModifiedDate,Reserved1,Reserved2,Reserved3 ");
			strSql.Append(" FROM Store ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM Store ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
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
			StringBuilder strSql=new StringBuilder();
			strSql.Append("SELECT * FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");
			if (!string.IsNullOrEmpty(orderby.Trim()))
			{
				strSql.Append("order by T." + orderby );
			}
			else
			{
				strSql.Append("order by T.StoreID desc");
			}
			strSql.Append(")AS Row, T.*  from Store T ");
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
			parameters[0].Value = "Store";
			parameters[1].Value = "StoreID";
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

