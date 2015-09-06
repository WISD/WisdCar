using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Zeta.WisdCar.Infrastructure.DBUtility;
namespace Zeta.WisdCar.Repository.CRUD
{
	/// <summary>
	/// 数据访问类:RechargeLog
	/// </summary>
    internal partial class RechargeLog
	{
		public RechargeLog()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("RechargeLogID", "RechargeLog"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int RechargeLogID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from RechargeLog");
			strSql.Append(" where RechargeLogID=@RechargeLogID");
			SqlParameter[] parameters = {
					new SqlParameter("@RechargeLogID", SqlDbType.Int,4)
			};
			parameters[0].Value = RechargeLogID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(WisdCar.Model.PO.RechargeLogPO model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into RechargeLog(");
			strSql.Append("RechargeSerialNo,ClubCardID,ClubCardNo,CustID,CustName,RechargeDate,SalesMan,RechargeStore,OriginalStore,ActualRechargeAmount,RechargeType,PayType,ClubCardPackageID,PlatformRechargeAmount,DiscountRate,DiscountInfo,LogicalStatus,CreatorID,CreatedDate,LastModifierID,LastModifiedDate,Reserved1,Reserved2,Reserved3)");
			strSql.Append(" values (");
			strSql.Append("@RechargeSerialNo,@ClubCardID,@ClubCardNo,@CustID,@CustName,@RechargeDate,@SalesMan,@RechargeStore,@OriginalStore,@ActualRechargeAmount,@RechargeType,@PayType,@ClubCardPackageID,@PlatformRechargeAmount,@DiscountRate,@DiscountInfo,@LogicalStatus,@CreatorID,@CreatedDate,@LastModifierID,@LastModifiedDate,@Reserved1,@Reserved2,@Reserved3)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@RechargeSerialNo", SqlDbType.NVarChar,50),
					new SqlParameter("@ClubCardID", SqlDbType.Int,4),
					new SqlParameter("@ClubCardNo", SqlDbType.Int,4),
					new SqlParameter("@CustID", SqlDbType.Int,4),
					new SqlParameter("@CustName", SqlDbType.NVarChar,50),
					new SqlParameter("@RechargeDate", SqlDbType.DateTime),
					new SqlParameter("@SalesMan", SqlDbType.NVarChar,50),
					new SqlParameter("@RechargeStore", SqlDbType.NVarChar,50),
					new SqlParameter("@OriginalStore", SqlDbType.NVarChar,50),
					new SqlParameter("@ActualRechargeAmount", SqlDbType.Decimal,5),
					new SqlParameter("@RechargeType", SqlDbType.Int,4),
					new SqlParameter("@PayType", SqlDbType.Int,4),
					new SqlParameter("@ClubCardPackageID", SqlDbType.Int,4),
					new SqlParameter("@PlatformRechargeAmount", SqlDbType.Decimal,5),
					new SqlParameter("@DiscountRate", SqlDbType.Decimal,5),
					new SqlParameter("@DiscountInfo", SqlDbType.NVarChar,50),
					new SqlParameter("@LogicalStatus", SqlDbType.Int,4),
					new SqlParameter("@CreatorID", SqlDbType.NVarChar,50),
					new SqlParameter("@CreatedDate", SqlDbType.DateTime),
					new SqlParameter("@LastModifierID", SqlDbType.NVarChar,50),
					new SqlParameter("@LastModifiedDate", SqlDbType.DateTime),
					new SqlParameter("@Reserved1", SqlDbType.NVarChar,100),
					new SqlParameter("@Reserved2", SqlDbType.NVarChar,100),
					new SqlParameter("@Reserved3", SqlDbType.NVarChar,100)};
			parameters[0].Value = model.RechargeSerialNo;
			parameters[1].Value = model.ClubCardID;
			parameters[2].Value = model.ClubCardNo;
			parameters[3].Value = model.CustID;
			parameters[4].Value = model.CustName;
			parameters[5].Value = model.RechargeDate;
			parameters[6].Value = model.SalesMan;
			parameters[7].Value = model.RechargeStore;
			parameters[8].Value = model.OriginalStore;
			parameters[9].Value = model.ActualRechargeAmount;
			parameters[10].Value = model.RechargeType;
			parameters[11].Value = model.PayType;
			parameters[12].Value = model.ClubCardPackageID;
			parameters[13].Value = model.PlatformRechargeAmount;
			parameters[14].Value = model.DiscountRate;
			parameters[15].Value = model.DiscountInfo;
			parameters[16].Value = model.LogicalStatus;
			parameters[17].Value = model.CreatorID;
			parameters[18].Value = model.CreatedDate;
			parameters[19].Value = model.LastModifierID;
			parameters[20].Value = model.LastModifiedDate;
			parameters[21].Value = model.Reserved1;
			parameters[22].Value = model.Reserved2;
			parameters[23].Value = model.Reserved3;

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
		public bool Update(WisdCar.Model.PO.RechargeLogPO model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update RechargeLog set ");
			strSql.Append("RechargeSerialNo=@RechargeSerialNo,");
			strSql.Append("ClubCardID=@ClubCardID,");
			strSql.Append("ClubCardNo=@ClubCardNo,");
			strSql.Append("CustID=@CustID,");
			strSql.Append("CustName=@CustName,");
			strSql.Append("RechargeDate=@RechargeDate,");
			strSql.Append("SalesMan=@SalesMan,");
			strSql.Append("RechargeStore=@RechargeStore,");
			strSql.Append("OriginalStore=@OriginalStore,");
			strSql.Append("ActualRechargeAmount=@ActualRechargeAmount,");
			strSql.Append("RechargeType=@RechargeType,");
			strSql.Append("PayType=@PayType,");
			strSql.Append("ClubCardPackageID=@ClubCardPackageID,");
			strSql.Append("PlatformRechargeAmount=@PlatformRechargeAmount,");
			strSql.Append("DiscountRate=@DiscountRate,");
			strSql.Append("DiscountInfo=@DiscountInfo,");
			strSql.Append("LogicalStatus=@LogicalStatus,");
			strSql.Append("CreatorID=@CreatorID,");
			strSql.Append("CreatedDate=@CreatedDate,");
			strSql.Append("LastModifierID=@LastModifierID,");
			strSql.Append("LastModifiedDate=@LastModifiedDate,");
			strSql.Append("Reserved1=@Reserved1,");
			strSql.Append("Reserved2=@Reserved2,");
			strSql.Append("Reserved3=@Reserved3");
			strSql.Append(" where RechargeLogID=@RechargeLogID");
			SqlParameter[] parameters = {
					new SqlParameter("@RechargeSerialNo", SqlDbType.NVarChar,50),
					new SqlParameter("@ClubCardID", SqlDbType.Int,4),
					new SqlParameter("@ClubCardNo", SqlDbType.Int,4),
					new SqlParameter("@CustID", SqlDbType.Int,4),
					new SqlParameter("@CustName", SqlDbType.NVarChar,50),
					new SqlParameter("@RechargeDate", SqlDbType.DateTime),
					new SqlParameter("@SalesMan", SqlDbType.NVarChar,50),
					new SqlParameter("@RechargeStore", SqlDbType.NVarChar,50),
					new SqlParameter("@OriginalStore", SqlDbType.NVarChar,50),
					new SqlParameter("@ActualRechargeAmount", SqlDbType.Decimal,5),
					new SqlParameter("@RechargeType", SqlDbType.Int,4),
					new SqlParameter("@PayType", SqlDbType.Int,4),
					new SqlParameter("@ClubCardPackageID", SqlDbType.Int,4),
					new SqlParameter("@PlatformRechargeAmount", SqlDbType.Decimal,5),
					new SqlParameter("@DiscountRate", SqlDbType.Decimal,5),
					new SqlParameter("@DiscountInfo", SqlDbType.NVarChar,50),
					new SqlParameter("@LogicalStatus", SqlDbType.Int,4),
					new SqlParameter("@CreatorID", SqlDbType.NVarChar,50),
					new SqlParameter("@CreatedDate", SqlDbType.DateTime),
					new SqlParameter("@LastModifierID", SqlDbType.NVarChar,50),
					new SqlParameter("@LastModifiedDate", SqlDbType.DateTime),
					new SqlParameter("@Reserved1", SqlDbType.NVarChar,100),
					new SqlParameter("@Reserved2", SqlDbType.NVarChar,100),
					new SqlParameter("@Reserved3", SqlDbType.NVarChar,100),
					new SqlParameter("@RechargeLogID", SqlDbType.Int,4)};
			parameters[0].Value = model.RechargeSerialNo;
			parameters[1].Value = model.ClubCardID;
			parameters[2].Value = model.ClubCardNo;
			parameters[3].Value = model.CustID;
			parameters[4].Value = model.CustName;
			parameters[5].Value = model.RechargeDate;
			parameters[6].Value = model.SalesMan;
			parameters[7].Value = model.RechargeStore;
			parameters[8].Value = model.OriginalStore;
			parameters[9].Value = model.ActualRechargeAmount;
			parameters[10].Value = model.RechargeType;
			parameters[11].Value = model.PayType;
			parameters[12].Value = model.ClubCardPackageID;
			parameters[13].Value = model.PlatformRechargeAmount;
			parameters[14].Value = model.DiscountRate;
			parameters[15].Value = model.DiscountInfo;
			parameters[16].Value = model.LogicalStatus;
			parameters[17].Value = model.CreatorID;
			parameters[18].Value = model.CreatedDate;
			parameters[19].Value = model.LastModifierID;
			parameters[20].Value = model.LastModifiedDate;
			parameters[21].Value = model.Reserved1;
			parameters[22].Value = model.Reserved2;
			parameters[23].Value = model.Reserved3;
			parameters[24].Value = model.RechargeLogID;

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
		public bool Delete(int RechargeLogID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from RechargeLog ");
			strSql.Append(" where RechargeLogID=@RechargeLogID");
			SqlParameter[] parameters = {
					new SqlParameter("@RechargeLogID", SqlDbType.Int,4)
			};
			parameters[0].Value = RechargeLogID;

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
		public bool DeleteList(string RechargeLogIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from RechargeLog ");
			strSql.Append(" where RechargeLogID in ("+RechargeLogIDlist + ")  ");
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
		public WisdCar.Model.PO.RechargeLogPO GetModel(int RechargeLogID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 RechargeLogID,RechargeSerialNo,ClubCardID,ClubCardNo,CustID,CustName,RechargeDate,SalesMan,RechargeStore,OriginalStore,ActualRechargeAmount,RechargeType,PayType,ClubCardPackageID,PlatformRechargeAmount,DiscountRate,DiscountInfo,LogicalStatus,CreatorID,CreatedDate,LastModifierID,LastModifiedDate,Reserved1,Reserved2,Reserved3 from RechargeLog ");
			strSql.Append(" where RechargeLogID=@RechargeLogID");
			SqlParameter[] parameters = {
					new SqlParameter("@RechargeLogID", SqlDbType.Int,4)
			};
			parameters[0].Value = RechargeLogID;

			WisdCar.Model.PO.RechargeLogPO model=new WisdCar.Model.PO.RechargeLogPO();
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
		public WisdCar.Model.PO.RechargeLogPO DataRowToModel(DataRow row)
		{
			WisdCar.Model.PO.RechargeLogPO model=new WisdCar.Model.PO.RechargeLogPO();
			if (row != null)
			{
				if(row["RechargeLogID"]!=null && row["RechargeLogID"].ToString()!="")
				{
					model.RechargeLogID=int.Parse(row["RechargeLogID"].ToString());
				}
				if(row["RechargeSerialNo"]!=null)
				{
					model.RechargeSerialNo=row["RechargeSerialNo"].ToString();
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
				if(row["RechargeDate"]!=null && row["RechargeDate"].ToString()!="")
				{
					model.RechargeDate=DateTime.Parse(row["RechargeDate"].ToString());
				}
				if(row["SalesMan"]!=null)
				{
					model.SalesMan=row["SalesMan"].ToString();
				}
				if(row["RechargeStore"]!=null)
				{
					model.RechargeStore=row["RechargeStore"].ToString();
				}
				if(row["OriginalStore"]!=null)
				{
					model.OriginalStore=row["OriginalStore"].ToString();
				}
				if(row["ActualRechargeAmount"]!=null && row["ActualRechargeAmount"].ToString()!="")
				{
					model.ActualRechargeAmount=decimal.Parse(row["ActualRechargeAmount"].ToString());
				}
				if(row["RechargeType"]!=null && row["RechargeType"].ToString()!="")
				{
					model.RechargeType=int.Parse(row["RechargeType"].ToString());
				}
				if(row["PayType"]!=null && row["PayType"].ToString()!="")
				{
					model.PayType=int.Parse(row["PayType"].ToString());
				}
				if(row["ClubCardPackageID"]!=null && row["ClubCardPackageID"].ToString()!="")
				{
					model.ClubCardPackageID=int.Parse(row["ClubCardPackageID"].ToString());
				}
				if(row["PlatformRechargeAmount"]!=null && row["PlatformRechargeAmount"].ToString()!="")
				{
					model.PlatformRechargeAmount=decimal.Parse(row["PlatformRechargeAmount"].ToString());
				}
				if(row["DiscountRate"]!=null && row["DiscountRate"].ToString()!="")
				{
					model.DiscountRate=decimal.Parse(row["DiscountRate"].ToString());
				}
				if(row["DiscountInfo"]!=null)
				{
					model.DiscountInfo=row["DiscountInfo"].ToString();
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
			strSql.Append("select RechargeLogID,RechargeSerialNo,ClubCardID,ClubCardNo,CustID,CustName,RechargeDate,SalesMan,RechargeStore,OriginalStore,ActualRechargeAmount,RechargeType,PayType,ClubCardPackageID,PlatformRechargeAmount,DiscountRate,DiscountInfo,LogicalStatus,CreatorID,CreatedDate,LastModifierID,LastModifiedDate,Reserved1,Reserved2,Reserved3 ");
			strSql.Append(" FROM RechargeLog ");
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
			strSql.Append(" RechargeLogID,RechargeSerialNo,ClubCardID,ClubCardNo,CustID,CustName,RechargeDate,SalesMan,RechargeStore,OriginalStore,ActualRechargeAmount,RechargeType,PayType,ClubCardPackageID,PlatformRechargeAmount,DiscountRate,DiscountInfo,LogicalStatus,CreatorID,CreatedDate,LastModifierID,LastModifiedDate,Reserved1,Reserved2,Reserved3 ");
			strSql.Append(" FROM RechargeLog ");
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
			strSql.Append("select count(1) FROM RechargeLog ");
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
				strSql.Append("order by T.RechargeLogID desc");
			}
			strSql.Append(")AS Row, T.*  from RechargeLog T ");
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
			parameters[0].Value = "RechargeLog";
			parameters[1].Value = "RechargeLogID";
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

