using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Zeta.WisdCar.Infrastructure.DBUtility;

namespace Zeta.WisdCar.Repository.CRUD
{
	/// <summary>
	/// 数据访问类:Car
	/// </summary>
	internal partial class Car
	{
		public Car()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("CarID", "Car"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int CarID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Car");
			strSql.Append(" where CarID=@CarID");
			SqlParameter[] parameters = {
					new SqlParameter("@CarID", SqlDbType.Int,4)
			};
			parameters[0].Value = CarID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(WisdCar.Model.PO.CarPO model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Car(");
			strSql.Append("CarNo,Brand,CarModel,Capacity,Color,FrameNo,EngineNo,MaintainKM,InsureDate,ASDate,CustomerID,LogicalStatus,CreatorID,CreatedDate,LastModifierID,LastModifiedDate,Reserved1,Reserved2,Reserved3)");
			strSql.Append(" values (");
			strSql.Append("@CarNo,@Brand,@CarModel,@Capacity,@Color,@FrameNo,@EngineNo,@MaintainKM,@InsureDate,@ASDate,@CustomerID,@LogicalStatus,@CreatorID,@CreatedDate,@LastModifierID,@LastModifiedDate,@Reserved1,@Reserved2,@Reserved3)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@CarNo", SqlDbType.NVarChar,50),
					new SqlParameter("@Brand", SqlDbType.NVarChar,50),
					new SqlParameter("@CarModel", SqlDbType.NVarChar,50),
					new SqlParameter("@Capacity", SqlDbType.NVarChar,50),
					new SqlParameter("@Color", SqlDbType.NVarChar,50),
					new SqlParameter("@FrameNo", SqlDbType.NVarChar,50),
					new SqlParameter("@EngineNo", SqlDbType.NVarChar,50),
					new SqlParameter("@MaintainKM", SqlDbType.NVarChar,50),
					new SqlParameter("@InsureDate", SqlDbType.DateTime),
					new SqlParameter("@ASDate", SqlDbType.DateTime),
					new SqlParameter("@CustomerID", SqlDbType.Int,4),
					new SqlParameter("@LogicalStatus", SqlDbType.Int,4),
					new SqlParameter("@CreatorID", SqlDbType.NVarChar,50),
					new SqlParameter("@CreatedDate", SqlDbType.DateTime),
					new SqlParameter("@LastModifierID", SqlDbType.NVarChar,50),
					new SqlParameter("@LastModifiedDate", SqlDbType.DateTime),
					new SqlParameter("@Reserved1", SqlDbType.NVarChar,100),
					new SqlParameter("@Reserved2", SqlDbType.NVarChar,100),
					new SqlParameter("@Reserved3", SqlDbType.NVarChar,100)};
			parameters[0].Value = model.CarNo;
			parameters[1].Value = model.Brand;
			parameters[2].Value = model.CarModel;
			parameters[3].Value = model.Capacity;
			parameters[4].Value = model.Color;
			parameters[5].Value = model.FrameNo;
			parameters[6].Value = model.EngineNo;
			parameters[7].Value = model.MaintainKM;
			parameters[8].Value = model.InsureDate;
			parameters[9].Value = model.ASDate;
			parameters[10].Value = model.CustomerID;
			parameters[11].Value = model.LogicalStatus;
			parameters[12].Value = model.CreatorID;
			parameters[13].Value = model.CreatedDate;
			parameters[14].Value = model.LastModifierID;
			parameters[15].Value = model.LastModifiedDate;
			parameters[16].Value = model.Reserved1;
			parameters[17].Value = model.Reserved2;
			parameters[18].Value = model.Reserved3;

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
		public bool Update(WisdCar.Model.PO.CarPO model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Car set ");
			strSql.Append("CarNo=@CarNo,");
			strSql.Append("Brand=@Brand,");
			strSql.Append("CarModel=@CarModel,");
			strSql.Append("Capacity=@Capacity,");
			strSql.Append("Color=@Color,");
			strSql.Append("FrameNo=@FrameNo,");
			strSql.Append("EngineNo=@EngineNo,");
			strSql.Append("MaintainKM=@MaintainKM,");
			strSql.Append("InsureDate=@InsureDate,");
			strSql.Append("ASDate=@ASDate,");
			strSql.Append("CustomerID=@CustomerID,");
			strSql.Append("LogicalStatus=@LogicalStatus,");
			strSql.Append("CreatorID=@CreatorID,");
			strSql.Append("CreatedDate=@CreatedDate,");
			strSql.Append("LastModifierID=@LastModifierID,");
			strSql.Append("LastModifiedDate=@LastModifiedDate,");
			strSql.Append("Reserved1=@Reserved1,");
			strSql.Append("Reserved2=@Reserved2,");
			strSql.Append("Reserved3=@Reserved3");
			strSql.Append(" where CarID=@CarID");
			SqlParameter[] parameters = {
					new SqlParameter("@CarNo", SqlDbType.NVarChar,50),
					new SqlParameter("@Brand", SqlDbType.NVarChar,50),
					new SqlParameter("@CarModel", SqlDbType.NVarChar,50),
					new SqlParameter("@Capacity", SqlDbType.NVarChar,50),
					new SqlParameter("@Color", SqlDbType.NVarChar,50),
					new SqlParameter("@FrameNo", SqlDbType.NVarChar,50),
					new SqlParameter("@EngineNo", SqlDbType.NVarChar,50),
					new SqlParameter("@MaintainKM", SqlDbType.NVarChar,50),
					new SqlParameter("@InsureDate", SqlDbType.DateTime),
					new SqlParameter("@ASDate", SqlDbType.DateTime),
					new SqlParameter("@CustomerID", SqlDbType.Int,4),
					new SqlParameter("@LogicalStatus", SqlDbType.Int,4),
					new SqlParameter("@CreatorID", SqlDbType.NVarChar,50),
					new SqlParameter("@CreatedDate", SqlDbType.DateTime),
					new SqlParameter("@LastModifierID", SqlDbType.NVarChar,50),
					new SqlParameter("@LastModifiedDate", SqlDbType.DateTime),
					new SqlParameter("@Reserved1", SqlDbType.NVarChar,100),
					new SqlParameter("@Reserved2", SqlDbType.NVarChar,100),
					new SqlParameter("@Reserved3", SqlDbType.NVarChar,100),
					new SqlParameter("@CarID", SqlDbType.Int,4)};
			parameters[0].Value = model.CarNo;
			parameters[1].Value = model.Brand;
			parameters[2].Value = model.CarModel;
			parameters[3].Value = model.Capacity;
			parameters[4].Value = model.Color;
			parameters[5].Value = model.FrameNo;
			parameters[6].Value = model.EngineNo;
			parameters[7].Value = model.MaintainKM;
			parameters[8].Value = model.InsureDate;
			parameters[9].Value = model.ASDate;
			parameters[10].Value = model.CustomerID;
			parameters[11].Value = model.LogicalStatus;
			parameters[12].Value = model.CreatorID;
			parameters[13].Value = model.CreatedDate;
			parameters[14].Value = model.LastModifierID;
			parameters[15].Value = model.LastModifiedDate;
			parameters[16].Value = model.Reserved1;
			parameters[17].Value = model.Reserved2;
			parameters[18].Value = model.Reserved3;
			parameters[19].Value = model.CarID;

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
		public bool Delete(int CarID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Car ");
			strSql.Append(" where CarID=@CarID");
			SqlParameter[] parameters = {
					new SqlParameter("@CarID", SqlDbType.Int,4)
			};
			parameters[0].Value = CarID;

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
		public bool DeleteList(string CarIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Car ");
			strSql.Append(" where CarID in ("+CarIDlist + ")  ");
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
		public WisdCar.Model.PO.CarPO GetModel(int CarID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 CarID,CarNo,Brand,CarModel,Capacity,Color,FrameNo,EngineNo,MaintainKM,InsureDate,ASDate,CustomerID,LogicalStatus,CreatorID,CreatedDate,LastModifierID,LastModifiedDate,Reserved1,Reserved2,Reserved3 from Car ");
			strSql.Append(" where CarID=@CarID");
			SqlParameter[] parameters = {
					new SqlParameter("@CarID", SqlDbType.Int,4)
			};
			parameters[0].Value = CarID;

			WisdCar.Model.PO.CarPO model=new WisdCar.Model.PO.CarPO();
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
		public WisdCar.Model.PO.CarPO DataRowToModel(DataRow row)
		{
			WisdCar.Model.PO.CarPO model=new WisdCar.Model.PO.CarPO();
			if (row != null)
			{
				if(row["CarID"]!=null && row["CarID"].ToString()!="")
				{
					model.CarID=int.Parse(row["CarID"].ToString());
				}
				if(row["CarNo"]!=null)
				{
					model.CarNo=row["CarNo"].ToString();
				}
				if(row["Brand"]!=null)
				{
					model.Brand=row["Brand"].ToString();
				}
				if(row["CarModel"]!=null)
				{
					model.CarModel=row["CarModel"].ToString();
				}
				if(row["Capacity"]!=null)
				{
					model.Capacity=row["Capacity"].ToString();
				}
				if(row["Color"]!=null)
				{
					model.Color=row["Color"].ToString();
				}
				if(row["FrameNo"]!=null)
				{
					model.FrameNo=row["FrameNo"].ToString();
				}
				if(row["EngineNo"]!=null)
				{
					model.EngineNo=row["EngineNo"].ToString();
				}
				if(row["MaintainKM"]!=null)
				{
					model.MaintainKM=row["MaintainKM"].ToString();
				}
				if(row["InsureDate"]!=null && row["InsureDate"].ToString()!="")
				{
					model.InsureDate=DateTime.Parse(row["InsureDate"].ToString());
				}
				if(row["ASDate"]!=null && row["ASDate"].ToString()!="")
				{
					model.ASDate=DateTime.Parse(row["ASDate"].ToString());
				}
				if(row["CustomerID"]!=null && row["CustomerID"].ToString()!="")
				{
					model.CustomerID=int.Parse(row["CustomerID"].ToString());
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
			strSql.Append("select CarID,CarNo,Brand,CarModel,Capacity,Color,FrameNo,EngineNo,MaintainKM,InsureDate,ASDate,CustomerID,LogicalStatus,CreatorID,CreatedDate,LastModifierID,LastModifiedDate,Reserved1,Reserved2,Reserved3 ");
			strSql.Append(" FROM Car ");
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
			strSql.Append(" CarID,CarNo,Brand,CarModel,Capacity,Color,FrameNo,EngineNo,MaintainKM,InsureDate,ASDate,CustomerID,LogicalStatus,CreatorID,CreatedDate,LastModifierID,LastModifiedDate,Reserved1,Reserved2,Reserved3 ");
			strSql.Append(" FROM Car ");
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
			strSql.Append("select count(1) FROM Car ");
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
				strSql.Append("order by T.CarID desc");
			}
			strSql.Append(")AS Row, T.*  from Car T ");
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
			parameters[0].Value = "Car";
			parameters[1].Value = "CarID";
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

