using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Zeta.WisdCar.Infrastructure.DBUtility;
namespace Zeta.WisdCar.Repository.CRUD
{
	/// <summary>
	/// 数据访问类:ConsumeLog
	/// </summary>
    internal partial class ConsumeLog
	{
		public ConsumeLog()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ConsumeLogID", "ConsumeLog"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ConsumeLogID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from ConsumeLog");
			strSql.Append(" where ConsumeLogID=@ConsumeLogID");
			SqlParameter[] parameters = {
					new SqlParameter("@ConsumeLogID", SqlDbType.Int,4)
			};
			parameters[0].Value = ConsumeLogID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(WisdCar.Model.PO.ConsumeLogPO model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into ConsumeLog(");
			strSql.Append("ClubCardID,ClubCardNo,CustID,CustName,ConsumeDate,ConsumeStore,OriginalStore,ConsumeType,ClubCardPackageID,PackageDetailID,ItemName,ConsumeCount,OriginalPrice,ItemID,LogicalStatus,CreatorID,CreatedDate,LastModifierID,LastModifiedDate,Reserved1,Reserved2,Reserved3)");
			strSql.Append(" values (");
			strSql.Append("@ClubCardID,@ClubCardNo,@CustID,@CustName,@ConsumeDate,@ConsumeStore,@OriginalStore,@ConsumeType,@ClubCardPackageID,@PackageDetailID,@ItemName,@ConsumeCount,@OriginalPrice,@ItemID,@LogicalStatus,@CreatorID,@CreatedDate,@LastModifierID,@LastModifiedDate,@Reserved1,@Reserved2,@Reserved3)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@ClubCardID", SqlDbType.Int,4),
					new SqlParameter("@ClubCardNo", SqlDbType.Int,4),
					new SqlParameter("@CustID", SqlDbType.Int,4),
					new SqlParameter("@CustName", SqlDbType.NVarChar,50),
					new SqlParameter("@ConsumeDate", SqlDbType.DateTime),
					new SqlParameter("@ConsumeStore", SqlDbType.NVarChar,50),
					new SqlParameter("@OriginalStore", SqlDbType.NVarChar,50),
					new SqlParameter("@ConsumeType", SqlDbType.Int,4),
					new SqlParameter("@ClubCardPackageID", SqlDbType.Int,4),
					new SqlParameter("@PackageDetailID", SqlDbType.Int,4),
					new SqlParameter("@ItemName", SqlDbType.NVarChar,50),
					new SqlParameter("@ConsumeCount", SqlDbType.Int,4),
					new SqlParameter("@OriginalPrice", SqlDbType.Decimal,5),
					new SqlParameter("@ItemID", SqlDbType.Int,4),
					new SqlParameter("@LogicalStatus", SqlDbType.Int,4),
					new SqlParameter("@CreatorID", SqlDbType.NVarChar,50),
					new SqlParameter("@CreatedDate", SqlDbType.DateTime),
					new SqlParameter("@LastModifierID", SqlDbType.NVarChar,50),
					new SqlParameter("@LastModifiedDate", SqlDbType.DateTime),
					new SqlParameter("@Reserved1", SqlDbType.NVarChar,100),
					new SqlParameter("@Reserved2", SqlDbType.NVarChar,100),
					new SqlParameter("@Reserved3", SqlDbType.NVarChar,100)};
			parameters[0].Value = model.ClubCardID;
			parameters[1].Value = model.ClubCardNo;
			parameters[2].Value = model.CustID;
			parameters[3].Value = model.CustName;
			parameters[4].Value = model.ConsumeDate;
			parameters[5].Value = model.ConsumeStore;
			parameters[6].Value = model.OriginalStore;
			parameters[7].Value = model.ConsumeType;
			parameters[8].Value = model.ClubCardPackageID;
			parameters[9].Value = model.PackageDetailID;
			parameters[10].Value = model.ItemName;
			parameters[11].Value = model.ConsumeCount;
			parameters[12].Value = model.OriginalPrice;
			parameters[13].Value = model.ItemID;
			parameters[14].Value = model.LogicalStatus;
			parameters[15].Value = model.CreatorID;
			parameters[16].Value = model.CreatedDate;
			parameters[17].Value = model.LastModifierID;
			parameters[18].Value = model.LastModifiedDate;
			parameters[19].Value = model.Reserved1;
			parameters[20].Value = model.Reserved2;
			parameters[21].Value = model.Reserved3;

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
		public bool Update(WisdCar.Model.PO.ConsumeLogPO model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update ConsumeLog set ");
			strSql.Append("ClubCardID=@ClubCardID,");
			strSql.Append("ClubCardNo=@ClubCardNo,");
			strSql.Append("CustID=@CustID,");
			strSql.Append("CustName=@CustName,");
			strSql.Append("ConsumeDate=@ConsumeDate,");
			strSql.Append("ConsumeStore=@ConsumeStore,");
			strSql.Append("OriginalStore=@OriginalStore,");
			strSql.Append("ConsumeType=@ConsumeType,");
			strSql.Append("ClubCardPackageID=@ClubCardPackageID,");
			strSql.Append("PackageDetailID=@PackageDetailID,");
			strSql.Append("ItemName=@ItemName,");
			strSql.Append("ConsumeCount=@ConsumeCount,");
			strSql.Append("OriginalPrice=@OriginalPrice,");
			strSql.Append("ItemID=@ItemID,");
			strSql.Append("LogicalStatus=@LogicalStatus,");
			strSql.Append("CreatorID=@CreatorID,");
			strSql.Append("CreatedDate=@CreatedDate,");
			strSql.Append("LastModifierID=@LastModifierID,");
			strSql.Append("LastModifiedDate=@LastModifiedDate,");
			strSql.Append("Reserved1=@Reserved1,");
			strSql.Append("Reserved2=@Reserved2,");
			strSql.Append("Reserved3=@Reserved3");
			strSql.Append(" where ConsumeLogID=@ConsumeLogID");
			SqlParameter[] parameters = {
					new SqlParameter("@ClubCardID", SqlDbType.Int,4),
					new SqlParameter("@ClubCardNo", SqlDbType.Int,4),
					new SqlParameter("@CustID", SqlDbType.Int,4),
					new SqlParameter("@CustName", SqlDbType.NVarChar,50),
					new SqlParameter("@ConsumeDate", SqlDbType.DateTime),
					new SqlParameter("@ConsumeStore", SqlDbType.NVarChar,50),
					new SqlParameter("@OriginalStore", SqlDbType.NVarChar,50),
					new SqlParameter("@ConsumeType", SqlDbType.Int,4),
					new SqlParameter("@ClubCardPackageID", SqlDbType.Int,4),
					new SqlParameter("@PackageDetailID", SqlDbType.Int,4),
					new SqlParameter("@ItemName", SqlDbType.NVarChar,50),
					new SqlParameter("@ConsumeCount", SqlDbType.Int,4),
					new SqlParameter("@OriginalPrice", SqlDbType.Decimal,5),
					new SqlParameter("@ItemID", SqlDbType.Int,4),
					new SqlParameter("@LogicalStatus", SqlDbType.Int,4),
					new SqlParameter("@CreatorID", SqlDbType.NVarChar,50),
					new SqlParameter("@CreatedDate", SqlDbType.DateTime),
					new SqlParameter("@LastModifierID", SqlDbType.NVarChar,50),
					new SqlParameter("@LastModifiedDate", SqlDbType.DateTime),
					new SqlParameter("@Reserved1", SqlDbType.NVarChar,100),
					new SqlParameter("@Reserved2", SqlDbType.NVarChar,100),
					new SqlParameter("@Reserved3", SqlDbType.NVarChar,100),
					new SqlParameter("@ConsumeLogID", SqlDbType.Int,4)};
			parameters[0].Value = model.ClubCardID;
			parameters[1].Value = model.ClubCardNo;
			parameters[2].Value = model.CustID;
			parameters[3].Value = model.CustName;
			parameters[4].Value = model.ConsumeDate;
			parameters[5].Value = model.ConsumeStore;
			parameters[6].Value = model.OriginalStore;
			parameters[7].Value = model.ConsumeType;
			parameters[8].Value = model.ClubCardPackageID;
			parameters[9].Value = model.PackageDetailID;
			parameters[10].Value = model.ItemName;
			parameters[11].Value = model.ConsumeCount;
			parameters[12].Value = model.OriginalPrice;
			parameters[13].Value = model.ItemID;
			parameters[14].Value = model.LogicalStatus;
			parameters[15].Value = model.CreatorID;
			parameters[16].Value = model.CreatedDate;
			parameters[17].Value = model.LastModifierID;
			parameters[18].Value = model.LastModifiedDate;
			parameters[19].Value = model.Reserved1;
			parameters[20].Value = model.Reserved2;
			parameters[21].Value = model.Reserved3;
			parameters[22].Value = model.ConsumeLogID;

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
		public bool Delete(int ConsumeLogID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ConsumeLog ");
			strSql.Append(" where ConsumeLogID=@ConsumeLogID");
			SqlParameter[] parameters = {
					new SqlParameter("@ConsumeLogID", SqlDbType.Int,4)
			};
			parameters[0].Value = ConsumeLogID;

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
		public bool DeleteList(string ConsumeLogIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ConsumeLog ");
			strSql.Append(" where ConsumeLogID in ("+ConsumeLogIDlist + ")  ");
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
		public WisdCar.Model.PO.ConsumeLogPO GetModel(int ConsumeLogID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ConsumeLogID,ClubCardID,ClubCardNo,CustID,CustName,ConsumeDate,ConsumeStore,OriginalStore,ConsumeType,ClubCardPackageID,PackageDetailID,ItemName,ConsumeCount,OriginalPrice,ItemID,LogicalStatus,CreatorID,CreatedDate,LastModifierID,LastModifiedDate,Reserved1,Reserved2,Reserved3 from ConsumeLog ");
			strSql.Append(" where ConsumeLogID=@ConsumeLogID");
			SqlParameter[] parameters = {
					new SqlParameter("@ConsumeLogID", SqlDbType.Int,4)
			};
			parameters[0].Value = ConsumeLogID;

			WisdCar.Model.PO.ConsumeLogPO model=new WisdCar.Model.PO.ConsumeLogPO();
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
		public WisdCar.Model.PO.ConsumeLogPO DataRowToModel(DataRow row)
		{
			WisdCar.Model.PO.ConsumeLogPO model=new WisdCar.Model.PO.ConsumeLogPO();
			if (row != null)
			{
				if(row["ConsumeLogID"]!=null && row["ConsumeLogID"].ToString()!="")
				{
					model.ConsumeLogID=int.Parse(row["ConsumeLogID"].ToString());
				}
				if(row["ClubCardID"]!=null && row["ClubCardID"].ToString()!="")
				{
					model.ClubCardID=int.Parse(row["ClubCardID"].ToString());
				}
				if(row["ClubCardNo"]!=null && row["ClubCardNo"].ToString()!="")
				{
					model.ClubCardNo=int.Parse(row["ClubCardNo"].ToString());
				}
				if(row["CustID"]!=null && row["CustID"].ToString()!="")
				{
					model.CustID=int.Parse(row["CustID"].ToString());
				}
				if(row["CustName"]!=null)
				{
					model.CustName=row["CustName"].ToString();
				}
				if(row["ConsumeDate"]!=null && row["ConsumeDate"].ToString()!="")
				{
					model.ConsumeDate=DateTime.Parse(row["ConsumeDate"].ToString());
				}
				if(row["ConsumeStore"]!=null)
				{
					model.ConsumeStore=row["ConsumeStore"].ToString();
				}
				if(row["OriginalStore"]!=null)
				{
					model.OriginalStore=row["OriginalStore"].ToString();
				}
				if(row["ConsumeType"]!=null && row["ConsumeType"].ToString()!="")
				{
					model.ConsumeType=int.Parse(row["ConsumeType"].ToString());
				}
				if(row["ClubCardPackageID"]!=null && row["ClubCardPackageID"].ToString()!="")
				{
					model.ClubCardPackageID=int.Parse(row["ClubCardPackageID"].ToString());
				}
				if(row["PackageDetailID"]!=null && row["PackageDetailID"].ToString()!="")
				{
					model.PackageDetailID=int.Parse(row["PackageDetailID"].ToString());
				}
				if(row["ItemName"]!=null)
				{
					model.ItemName=row["ItemName"].ToString();
				}
				if(row["ConsumeCount"]!=null && row["ConsumeCount"].ToString()!="")
				{
					model.ConsumeCount=int.Parse(row["ConsumeCount"].ToString());
				}
				if(row["OriginalPrice"]!=null && row["OriginalPrice"].ToString()!="")
				{
					model.OriginalPrice=decimal.Parse(row["OriginalPrice"].ToString());
				}
				if(row["ItemID"]!=null && row["ItemID"].ToString()!="")
				{
					model.ItemID=int.Parse(row["ItemID"].ToString());
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
			strSql.Append("select ConsumeLogID,ClubCardID,ClubCardNo,CustID,CustName,ConsumeDate,ConsumeStore,OriginalStore,ConsumeType,ClubCardPackageID,PackageDetailID,ItemName,ConsumeCount,OriginalPrice,ItemID,LogicalStatus,CreatorID,CreatedDate,LastModifierID,LastModifiedDate,Reserved1,Reserved2,Reserved3 ");
			strSql.Append(" FROM ConsumeLog ");
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
			strSql.Append(" ConsumeLogID,ClubCardID,ClubCardNo,CustID,CustName,ConsumeDate,ConsumeStore,OriginalStore,ConsumeType,ClubCardPackageID,PackageDetailID,ItemName,ConsumeCount,OriginalPrice,ItemID,LogicalStatus,CreatorID,CreatedDate,LastModifierID,LastModifiedDate,Reserved1,Reserved2,Reserved3 ");
			strSql.Append(" FROM ConsumeLog ");
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
			strSql.Append("select count(1) FROM ConsumeLog ");
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
				strSql.Append("order by T.ConsumeLogID desc");
			}
			strSql.Append(")AS Row, T.*  from ConsumeLog T ");
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
			parameters[0].Value = "ConsumeLog";
			parameters[1].Value = "ConsumeLogID";
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

