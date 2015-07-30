using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Zeta.WisdCar.Infrastructure.DBUtility;
namespace Zeta.WisdCar.Repository.CRUD
{
	/// <summary>
	/// 数据访问类:PackageItemMapping
	/// </summary>
    internal partial class PackageItemMapping
	{
		public PackageItemMapping()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("PackageItemID", "PackageItemMapping"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int PackageItemID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from PackageItemMapping");
			strSql.Append(" where PackageItemID=@PackageItemID");
			SqlParameter[] parameters = {
					new SqlParameter("@PackageItemID", SqlDbType.Int,4)
			};
			parameters[0].Value = PackageItemID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(WisdCar.Model.PO.PackageItemMappingPO model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into PackageItemMapping(");
			strSql.Append("ConsumeCount,PackageID,ItemID,LogicalStatus,CreatorID,CreatedDate,LastModifierID,LastModifiedDate,Reserved1,Reserved2,Reserved3)");
			strSql.Append(" values (");
			strSql.Append("@ConsumeCount,@PackageID,@ItemID,@LogicalStatus,@CreatorID,@CreatedDate,@LastModifierID,@LastModifiedDate,@Reserved1,@Reserved2,@Reserved3)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@ConsumeCount", SqlDbType.Int,4),
					new SqlParameter("@PackageID", SqlDbType.Int,4),
					new SqlParameter("@ItemID", SqlDbType.Int,4),
					new SqlParameter("@LogicalStatus", SqlDbType.Int,4),
					new SqlParameter("@CreatorID", SqlDbType.NVarChar,50),
					new SqlParameter("@CreatedDate", SqlDbType.DateTime),
					new SqlParameter("@LastModifierID", SqlDbType.NVarChar,50),
					new SqlParameter("@LastModifiedDate", SqlDbType.DateTime),
					new SqlParameter("@Reserved1", SqlDbType.NVarChar,100),
					new SqlParameter("@Reserved2", SqlDbType.NVarChar,100),
					new SqlParameter("@Reserved3", SqlDbType.NVarChar,100)};
			parameters[0].Value = model.ConsumeCount;
			parameters[1].Value = model.PackageID;
			parameters[2].Value = model.ItemID;
			parameters[3].Value = model.LogicalStatus;
			parameters[4].Value = model.CreatorID;
			parameters[5].Value = model.CreatedDate;
			parameters[6].Value = model.LastModifierID;
			parameters[7].Value = model.LastModifiedDate;
			parameters[8].Value = model.Reserved1;
			parameters[9].Value = model.Reserved2;
			parameters[10].Value = model.Reserved3;

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
		public bool Update(WisdCar.Model.PO.PackageItemMappingPO model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update PackageItemMapping set ");
			strSql.Append("ConsumeCount=@ConsumeCount,");
			strSql.Append("PackageID=@PackageID,");
			strSql.Append("ItemID=@ItemID,");
			strSql.Append("LogicalStatus=@LogicalStatus,");
			strSql.Append("CreatorID=@CreatorID,");
			strSql.Append("CreatedDate=@CreatedDate,");
			strSql.Append("LastModifierID=@LastModifierID,");
			strSql.Append("LastModifiedDate=@LastModifiedDate,");
			strSql.Append("Reserved1=@Reserved1,");
			strSql.Append("Reserved2=@Reserved2,");
			strSql.Append("Reserved3=@Reserved3");
			strSql.Append(" where PackageItemID=@PackageItemID");
			SqlParameter[] parameters = {
					new SqlParameter("@ConsumeCount", SqlDbType.Int,4),
					new SqlParameter("@PackageID", SqlDbType.Int,4),
					new SqlParameter("@ItemID", SqlDbType.Int,4),
					new SqlParameter("@LogicalStatus", SqlDbType.Int,4),
					new SqlParameter("@CreatorID", SqlDbType.NVarChar,50),
					new SqlParameter("@CreatedDate", SqlDbType.DateTime),
					new SqlParameter("@LastModifierID", SqlDbType.NVarChar,50),
					new SqlParameter("@LastModifiedDate", SqlDbType.DateTime),
					new SqlParameter("@Reserved1", SqlDbType.NVarChar,100),
					new SqlParameter("@Reserved2", SqlDbType.NVarChar,100),
					new SqlParameter("@Reserved3", SqlDbType.NVarChar,100),
					new SqlParameter("@PackageItemID", SqlDbType.Int,4)};
			parameters[0].Value = model.ConsumeCount;
			parameters[1].Value = model.PackageID;
			parameters[2].Value = model.ItemID;
			parameters[3].Value = model.LogicalStatus;
			parameters[4].Value = model.CreatorID;
			parameters[5].Value = model.CreatedDate;
			parameters[6].Value = model.LastModifierID;
			parameters[7].Value = model.LastModifiedDate;
			parameters[8].Value = model.Reserved1;
			parameters[9].Value = model.Reserved2;
			parameters[10].Value = model.Reserved3;
			parameters[11].Value = model.PackageItemID;

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
		public bool Delete(int PackageItemID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from PackageItemMapping ");
			strSql.Append(" where PackageItemID=@PackageItemID");
			SqlParameter[] parameters = {
					new SqlParameter("@PackageItemID", SqlDbType.Int,4)
			};
			parameters[0].Value = PackageItemID;

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
		public bool DeleteList(string PackageItemIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from PackageItemMapping ");
			strSql.Append(" where PackageItemID in ("+PackageItemIDlist + ")  ");
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
		public WisdCar.Model.PO.PackageItemMappingPO GetModel(int PackageItemID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 PackageItemID,ConsumeCount,PackageID,ItemID,LogicalStatus,CreatorID,CreatedDate,LastModifierID,LastModifiedDate,Reserved1,Reserved2,Reserved3 from PackageItemMapping ");
			strSql.Append(" where PackageItemID=@PackageItemID");
			SqlParameter[] parameters = {
					new SqlParameter("@PackageItemID", SqlDbType.Int,4)
			};
			parameters[0].Value = PackageItemID;

			WisdCar.Model.PO.PackageItemMappingPO model=new WisdCar.Model.PO.PackageItemMappingPO();
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
		public WisdCar.Model.PO.PackageItemMappingPO DataRowToModel(DataRow row)
		{
			WisdCar.Model.PO.PackageItemMappingPO model=new WisdCar.Model.PO.PackageItemMappingPO();
			if (row != null)
			{
				if(row["PackageItemID"]!=null && row["PackageItemID"].ToString()!="")
				{
					model.PackageItemID=int.Parse(row["PackageItemID"].ToString());
				}
				if(row["ConsumeCount"]!=null && row["ConsumeCount"].ToString()!="")
				{
					model.ConsumeCount=int.Parse(row["ConsumeCount"].ToString());
				}
				if(row["PackageID"]!=null && row["PackageID"].ToString()!="")
				{
					model.PackageID=int.Parse(row["PackageID"].ToString());
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
			strSql.Append("select PackageItemID,ConsumeCount,PackageID,ItemID,LogicalStatus,CreatorID,CreatedDate,LastModifierID,LastModifiedDate,Reserved1,Reserved2,Reserved3 ");
			strSql.Append(" FROM PackageItemMapping ");
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
			strSql.Append(" PackageItemID,ConsumeCount,PackageID,ItemID,LogicalStatus,CreatorID,CreatedDate,LastModifierID,LastModifiedDate,Reserved1,Reserved2,Reserved3 ");
			strSql.Append(" FROM PackageItemMapping ");
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
			strSql.Append("select count(1) FROM PackageItemMapping ");
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
				strSql.Append("order by T.PackageItemID desc");
			}
			strSql.Append(")AS Row, T.*  from PackageItemMapping T ");
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
			parameters[0].Value = "PackageItemMapping";
			parameters[1].Value = "PackageItemID";
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

