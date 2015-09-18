using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Zeta.WisdCar.Infrastructure.DBUtility;
using System.Collections.Generic;
using System.Collections;
namespace Zeta.WisdCar.Repository.CRUD
{
	/// <summary>
	/// 数据访问类:Customer
	/// </summary>
    internal partial class Customer
	{
		public Customer()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("CustomerID", "Customer"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int CustomerID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Customer");
			strSql.Append(" where CustomerID=@CustomerID");
			SqlParameter[] parameters = {
					new SqlParameter("@CustomerID", SqlDbType.Int,4)
			};
			parameters[0].Value = CustomerID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(WisdCar.Model.PO.CustomerPO model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Customer(");
			strSql.Append("Name,MobileNO,Sex,Birthday,ICNo,Weixin,Company,CardFlag,LogicalStatus,CreatorID,CreatedDate,LastModifierID,LastModifiedDate,Reserved1,Reserved2,Reserved3)");
			strSql.Append(" values (");
			strSql.Append("@Name,@MobileNO,@Sex,@Birthday,@ICNo,@Weixin,@Company,@CardFlag,@LogicalStatus,@CreatorID,@CreatedDate,@LastModifierID,@LastModifiedDate,@Reserved1,@Reserved2,@Reserved3)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@Name", SqlDbType.NVarChar,50),
					new SqlParameter("@MobileNO", SqlDbType.NVarChar,50),
					new SqlParameter("@Sex", SqlDbType.NVarChar,50),
					new SqlParameter("@Birthday", SqlDbType.NVarChar,50),
					new SqlParameter("@ICNo", SqlDbType.NVarChar,50),
					new SqlParameter("@Weixin", SqlDbType.NVarChar,50),
					new SqlParameter("@Company", SqlDbType.NVarChar,50),
					new SqlParameter("@CardFlag", SqlDbType.Int,4),
					new SqlParameter("@LogicalStatus", SqlDbType.Int,4),
					new SqlParameter("@CreatorID", SqlDbType.NVarChar,50),
					new SqlParameter("@CreatedDate", SqlDbType.DateTime),
					new SqlParameter("@LastModifierID", SqlDbType.NVarChar,50),
					new SqlParameter("@LastModifiedDate", SqlDbType.DateTime),
					new SqlParameter("@Reserved1", SqlDbType.NVarChar,100),
					new SqlParameter("@Reserved2", SqlDbType.NVarChar,100),
					new SqlParameter("@Reserved3", SqlDbType.NVarChar,100)};
			parameters[0].Value = model.Name;
			parameters[1].Value = model.MobileNO;
			parameters[2].Value = model.Sex;
			parameters[3].Value = model.Birthday;
			parameters[4].Value = model.ICNo;
			parameters[5].Value = model.Weixin;
			parameters[6].Value = model.Company;
			parameters[7].Value = model.CardFlag;
			parameters[8].Value = model.LogicalStatus;
			parameters[9].Value = model.CreatorID;
			parameters[10].Value = model.CreatedDate;
			parameters[11].Value = model.LastModifierID;
			parameters[12].Value = model.LastModifiedDate;
			parameters[13].Value = model.Reserved1;
			parameters[14].Value = model.Reserved2;
			parameters[15].Value = model.Reserved3;

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
        public bool Update(WisdCar.Model.PO.CustomerPO model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Customer set ");
            strSql.Append("Name=@Name,");
            //strSql.Append("MobileNO=@MobileNO,");
            strSql.Append("Sex=@Sex,");
            strSql.Append("Birthday=@Birthday,");
            strSql.Append("ICNo=@ICNo,");
            strSql.Append("Weixin=@Weixin,");
            strSql.Append("Company=@Company,");
            strSql.Append("CardFlag=@CardFlag,");
            strSql.Append("LogicalStatus=@LogicalStatus,");
            //strSql.Append("CreatorID=@CreatorID,");
            //strSql.Append("CreatedDate=@CreatedDate,");
            strSql.Append("LastModifierID=@LastModifierID,");
            strSql.Append("LastModifiedDate=@LastModifiedDate,");
            strSql.Append("Reserved1=@Reserved1,");
            strSql.Append("Reserved2=@Reserved2,");
            strSql.Append("Reserved3=@Reserved3");
            strSql.Append(" where CustomerID=@CustomerID");
            SqlParameter[] parameters = {
					new SqlParameter("@Name", SqlDbType.NVarChar,50),
					new SqlParameter("@MobileNO", SqlDbType.NVarChar,50),
					new SqlParameter("@Sex", SqlDbType.NVarChar,50),
					new SqlParameter("@Birthday", SqlDbType.NVarChar,50),
					new SqlParameter("@ICNo", SqlDbType.NVarChar,50),
					new SqlParameter("@Weixin", SqlDbType.NVarChar,50),
					new SqlParameter("@Company", SqlDbType.NVarChar,50),
					new SqlParameter("@CardFlag", SqlDbType.Int,4),
					new SqlParameter("@LogicalStatus", SqlDbType.Int,4),
                    //new SqlParameter("@CreatorID", SqlDbType.NVarChar,50),
                    //new SqlParameter("@CreatedDate", SqlDbType.DateTime),
					new SqlParameter("@LastModifierID", SqlDbType.NVarChar,50),
					new SqlParameter("@LastModifiedDate", SqlDbType.DateTime),
					new SqlParameter("@Reserved1", SqlDbType.NVarChar,100),
					new SqlParameter("@Reserved2", SqlDbType.NVarChar,100),
					new SqlParameter("@Reserved3", SqlDbType.NVarChar,100),
					new SqlParameter("@CustomerID", SqlDbType.Int,4)};
            parameters[0].Value = model.Name;
            parameters[1].Value = model.MobileNO;
            parameters[2].Value = model.Sex;
            parameters[3].Value = model.Birthday;
            parameters[4].Value = model.ICNo;
            parameters[5].Value = model.Weixin;
            parameters[6].Value = model.Company;
            parameters[7].Value = model.CardFlag;
            parameters[8].Value = model.LogicalStatus;
            //parameters[9].Value = model.CreatorID;
            //parameters[10].Value = model.CreatedDate;
            parameters[9].Value = model.LastModifierID;
            parameters[10].Value = model.LastModifiedDate;
            parameters[11].Value = model.Reserved1;
            parameters[12].Value = model.Reserved2;
            parameters[13].Value = model.Reserved3;
            parameters[14].Value = model.CustomerID;

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
        /// 更新一条数据带事务
        /// </summary>
        public bool Update(WisdCar.Model.PO.CustomerPO customer, WisdCar.Model.PO.CarPO car)
        {
            StringBuilder strSqlcus = new StringBuilder();
            strSqlcus.Append("update Customer set ");
            strSqlcus.Append("Name=@Name,");
            strSqlcus.Append("MobileNO=@MobileNO,");
            strSqlcus.Append("Sex=@Sex,");
            strSqlcus.Append("Birthday=@Birthday,");
            strSqlcus.Append("ICNo=@ICNo,");
            strSqlcus.Append("Weixin=@Weixin,");
            strSqlcus.Append("Company=@Company,");
            strSqlcus.Append("CardFlag=@CardFlag,");
            strSqlcus.Append("LogicalStatus=@LogicalStatus,");
            //strSql.Append("CreatorID=@CreatorID,");
            //strSql.Append("CreatedDate=@CreatedDate,");
            strSqlcus.Append("LastModifierID=@LastModifierID,");
            strSqlcus.Append("LastModifiedDate=@LastModifiedDate");
            strSqlcus.Append(" where CustomerID=@CustomerID");
            SqlParameter[] spcus = {
					new SqlParameter("@Name", SqlDbType.NVarChar,50),
					new SqlParameter("@MobileNO", SqlDbType.NVarChar,50),
					new SqlParameter("@Sex", SqlDbType.NVarChar,50),
					new SqlParameter("@Birthday", SqlDbType.NVarChar,50),
					new SqlParameter("@ICNo", SqlDbType.NVarChar,50),
					new SqlParameter("@Weixin", SqlDbType.NVarChar,50),
					new SqlParameter("@Company", SqlDbType.NVarChar,50),
					new SqlParameter("@CardFlag", SqlDbType.Int,4),
					new SqlParameter("@LogicalStatus", SqlDbType.Int,4),
                    //new SqlParameter("@CreatorID", SqlDbType.NVarChar,50),
                    //new SqlParameter("@CreatedDate", SqlDbType.DateTime),
					new SqlParameter("@LastModifierID", SqlDbType.NVarChar,50),
					new SqlParameter("@LastModifiedDate", SqlDbType.DateTime),
					new SqlParameter("@CustomerID", SqlDbType.Int,4)};
            spcus[0].Value = customer.Name;
            spcus[1].Value = customer.MobileNO;
            spcus[2].Value = customer.Sex;
            spcus[3].Value = customer.Birthday;
            spcus[4].Value = customer.ICNo;
            spcus[5].Value = customer.Weixin;
            spcus[6].Value = customer.Company;
            spcus[7].Value = customer.CardFlag;
            spcus[8].Value = customer.LogicalStatus;
            //parameters[9].Value = model.CreatorID;
            //parameters[10].Value = model.CreatedDate;
            spcus[9].Value = customer.LastModifierID;
            spcus[10].Value = customer.LastModifiedDate;
            spcus[11].Value = customer.CustomerID;

            StringBuilder strSqlcar = new StringBuilder();
            strSqlcar.Append("update Car set ");
            strSqlcar.Append("CarNo=@CarNo,");
            strSqlcar.Append("Brand=@Brand,");
            strSqlcar.Append("CarModel=@CarModel,");
            strSqlcar.Append("Capacity=@Capacity,");
            strSqlcar.Append("Color=@Color,");
            strSqlcar.Append("FrameNo=@FrameNo,");
            strSqlcar.Append("EngineNo=@EngineNo,");
            strSqlcar.Append("MaintainKM=@MaintainKM,");
            strSqlcar.Append("InsureDate=@InsureDate,");
            strSqlcar.Append("ASDate=@ASDate,");
            strSqlcar.Append("CustomerID=@CustomerID,");
            strSqlcar.Append("LogicalStatus=@LogicalStatus,");
            //strSql.Append("CreatorID=@CreatorID,");
            //strSql.Append("CreatedDate=@CreatedDate,");
            strSqlcar.Append("LastModifierID=@LastModifierID,");
            strSqlcar.Append("LastModifiedDate=@LastModifiedDate");
            strSqlcar.Append(" where CarID=@CarID");
            SqlParameter[] pscar = {
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
                    //new SqlParameter("@CreatorID", SqlDbType.NVarChar,50),
                    //new SqlParameter("@CreatedDate", SqlDbType.DateTime),
					new SqlParameter("@LastModifierID", SqlDbType.NVarChar,50),
					new SqlParameter("@LastModifiedDate", SqlDbType.DateTime),
					new SqlParameter("@CarID", SqlDbType.Int,4)};
            pscar[0].Value = car.CarNo;
            pscar[1].Value = car.Brand;
            pscar[2].Value = car.CarModel;
            pscar[3].Value = car.Capacity;
            pscar[4].Value = car.Color;
            pscar[5].Value = car.FrameNo;
            pscar[6].Value = car.EngineNo;
            pscar[7].Value = car.MaintainKM;
            pscar[8].Value = car.InsureDate;
            pscar[9].Value = car.ASDate;
            pscar[10].Value = customer.CustomerID;
            pscar[11].Value = customer.LogicalStatus;
            //parameters[12].Value = model.CreatorID;
            //parameters[13].Value = model.CreatedDate;
            pscar[12].Value = car.LastModifierID;
            pscar[13].Value = car.LastModifiedDate;
            pscar[14].Value = car.CarID;

            Hashtable hs = new Hashtable();
            hs.Add(strSqlcus, spcus);
            hs.Add(strSqlcar, pscar);
            try
            {
                DbHelperSQL.ExecuteSqlTranWithIndentity(hs);
                return true;
            }
            catch
            {
                return false;
            }
            


        }

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int CustomerID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Customer ");
			strSql.Append(" where CustomerID=@CustomerID");
			SqlParameter[] parameters = {
					new SqlParameter("@CustomerID", SqlDbType.Int,4)
			};
			parameters[0].Value = CustomerID;

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
		public bool DeleteList(string CustomerIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Customer ");
			strSql.Append(" where CustomerID in ("+CustomerIDlist + ")  ");
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
		public WisdCar.Model.PO.CustomerPO GetModel(int CustomerID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 CustomerID,Name,MobileNO,Sex,Birthday,ICNo,Weixin,Company,CardFlag,LogicalStatus,CreatorID,CreatedDate,LastModifierID,LastModifiedDate,Reserved1,Reserved2,Reserved3 from Customer ");
			strSql.Append(" where CustomerID=@CustomerID");
			SqlParameter[] parameters = {
					new SqlParameter("@CustomerID", SqlDbType.Int,4)
			};
			parameters[0].Value = CustomerID;

			WisdCar.Model.PO.CustomerPO model=new WisdCar.Model.PO.CustomerPO();
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
		public WisdCar.Model.PO.CustomerPO DataRowToModel(DataRow row)
		{
			WisdCar.Model.PO.CustomerPO model=new WisdCar.Model.PO.CustomerPO();
			if (row != null)
			{
				if(row["CustomerID"]!=null && row["CustomerID"].ToString()!="")
				{
					model.CustomerID=int.Parse(row["CustomerID"].ToString());
				}
				if(row["Name"]!=null)
				{
					model.Name=row["Name"].ToString();
				}
				if(row["MobileNO"]!=null)
				{
					model.MobileNO=row["MobileNO"].ToString();
				}
				if(row["Sex"]!=null)
				{
					model.Sex=row["Sex"].ToString();
				}
				if(row["Birthday"]!=null)
				{
					model.Birthday=row["Birthday"].ToString();
				}
				if(row["ICNo"]!=null)
				{
					model.ICNo=row["ICNo"].ToString();
				}
				if(row["Weixin"]!=null)
				{
					model.Weixin=row["Weixin"].ToString();
				}
				if(row["Company"]!=null)
				{
					model.Company=row["Company"].ToString();
				}
				if(row["CardFlag"]!=null && row["CardFlag"].ToString()!="")
				{
					model.CardFlag=int.Parse(row["CardFlag"].ToString());
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
			strSql.Append("select CustomerID,Name,MobileNO,Sex,Birthday,ICNo,Weixin,Company,CardFlag,LogicalStatus,CreatorID,CreatedDate,LastModifierID,LastModifiedDate,Reserved1,Reserved2,Reserved3 ");
			strSql.Append(" FROM Customer ");
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
			strSql.Append(" CustomerID,Name,MobileNO,Sex,Birthday,ICNo,Weixin,Company,CardFlag,LogicalStatus,CreatorID,CreatedDate,LastModifierID,LastModifiedDate,Reserved1,Reserved2,Reserved3 ");
			strSql.Append(" FROM Customer ");
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
			strSql.Append("select count(1) FROM Customer ");
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
				strSql.Append("order by T.CustomerID desc");
			}
			strSql.Append(")AS Row, T.*  from Customer T ");
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
			parameters[0].Value = "Customer";
			parameters[1].Value = "CustomerID";
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

        public int AddAll(Model.PO.CustomerPO cust, Model.PO.CarPO car)
        {
            int result;
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into Customer(");
            strSql.Append("Name,MobileNO,Sex,Birthday,ICNo,Weixin,Company,CardFlag,LogicalStatus,CreatorID,CreatedDate,LastModifierID,LastModifiedDate)");
            strSql.Append(" values (");
            strSql.Append("@Name,@MobileNO,@Sex,@Birthday,@ICNo,@Weixin,@Company,@CardFlag,@LogicalStatus,@CreatorID,@CreatedDate,@LastModifierID,@LastModifiedDate)");
            strSql.Append("select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@Name", SqlDbType.NVarChar,50),
					new SqlParameter("@MobileNO", SqlDbType.NVarChar,50),
					new SqlParameter("@Sex", SqlDbType.NVarChar,50),
					new SqlParameter("@Birthday", SqlDbType.NVarChar,50),
					new SqlParameter("@ICNo", SqlDbType.NVarChar,50),
					new SqlParameter("@Weixin", SqlDbType.NVarChar,50),
					new SqlParameter("@Company", SqlDbType.NVarChar,50),
					new SqlParameter("@CardFlag", SqlDbType.Int,4),
					new SqlParameter("@LogicalStatus", SqlDbType.Int,4),
					new SqlParameter("@CreatorID", SqlDbType.NVarChar,50),
					new SqlParameter("@CreatedDate", SqlDbType.DateTime),
					new SqlParameter("@LastModifierID", SqlDbType.NVarChar,50),
					new SqlParameter("@LastModifiedDate", SqlDbType.DateTime)
					};
            parameters[0].Value = cust.Name;
            parameters[1].Value = cust.MobileNO;
            parameters[2].Value = cust.Sex;
            parameters[3].Value = cust.Birthday;
            parameters[4].Value = cust.ICNo;
            parameters[5].Value = cust.Weixin;
            parameters[6].Value = cust.Company;
            parameters[7].Value = cust.CardFlag;
            parameters[8].Value = cust.LogicalStatus;
            parameters[9].Value = cust.CreatorID;
            parameters[10].Value = cust.CreatedDate;
            parameters[11].Value = cust.LastModifierID;
            parameters[12].Value = cust.LastModifiedDate;

            StringBuilder strSqlcar = new StringBuilder();
            strSqlcar.Append("insert into Car(");
            strSqlcar.Append("CarNo,Brand,CarModel,Capacity,Color,FrameNo,EngineNo,MaintainKM,InsureDate,ASDate,CustomerID,LogicalStatus,CreatorID,CreatedDate,LastModifierID,LastModifiedDate)");
            strSqlcar.Append(" values (");
            strSqlcar.Append("@CarNo,@Brand,@CarModel,@Capacity,@Color,@FrameNo,@EngineNo,@MaintainKM,@InsureDate,@ASDate,@carcuid,@LogicalStatus,@CreatorID,@CreatedDate,@LastModifierID,@LastModifiedDate)");
            strSqlcar.Append("select @@IDENTITY");
            SqlParameter[] parameterscar = {
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
					new SqlParameter("@carcuid", SqlDbType.Int,4),
					new SqlParameter("@LogicalStatus", SqlDbType.Int,4),
					new SqlParameter("@CreatorID", SqlDbType.NVarChar,50),
					new SqlParameter("@CreatedDate", SqlDbType.DateTime),
					new SqlParameter("@LastModifierID", SqlDbType.NVarChar,50),
					new SqlParameter("@LastModifiedDate", SqlDbType.DateTime)
					};
            parameterscar[0].Value = car.CarNo;
            parameterscar[1].Value = car.Brand;
            parameterscar[2].Value = car.CarModel;
            parameterscar[3].Value = car.Capacity;
            parameterscar[4].Value = car.Color;
            parameterscar[5].Value = car.FrameNo;
            parameterscar[6].Value = car.EngineNo;
            parameterscar[7].Value = car.MaintainKM;
            parameterscar[8].Value = car.InsureDate;
            parameterscar[9].Value = car.ASDate;
            parameterscar[10].Value = -1;
            parameterscar[11].Value = car.LogicalStatus;
            parameterscar[12].Value = car.CreatorID;
            parameterscar[13].Value = car.CreatedDate;
            parameterscar[14].Value = car.LastModifierID;
            parameterscar[15].Value = car.LastModifiedDate;

            Dictionary<string, object> dicsqls = new Dictionary<string, object>();
            dicsqls.Add(strSql.ToString(), parameters);
            dicsqls.Add(strSqlcar.ToString(), parameterscar);

            try
            {
                DbHelperSQL.ExecutesqltranWithIndentity(dicsqls);
                result = 1;
            }
            catch (Exception ex)
            {
                result = 0;
            }

            return result;
        }

        public Model.PO.CustomerPO GetModel(string mno)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 CustomerID,Name,MobileNO,Sex,Birthday,ICNo,Weixin,Company,CardFlag,LogicalStatus,CreatorID,CreatedDate,LastModifierID,LastModifiedDate,Reserved1,Reserved2,Reserved3 from Customer ");
            strSql.Append(" where mobileno=@mno");
            SqlParameter[] parameters = {
					new SqlParameter("@mno", SqlDbType.NVarChar)
			};
            parameters[0].Value = mno;

            WisdCar.Model.PO.CustomerPO model = new WisdCar.Model.PO.CustomerPO();
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
	}
}

