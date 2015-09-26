using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Zeta.WisdCar.Infrastructure.DBUtility;
namespace Zeta.WisdCar.Repository.CRUD
{
	/// <summary>
	/// 数据访问类:Employee
	/// </summary>
    internal partial class Employee
	{
		public Employee()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("EmployeeID", "Employee"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int EmployeeID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Employee");
			strSql.Append(" where EmployeeID=@EmployeeID");
			SqlParameter[] parameters = {
					new SqlParameter("@EmployeeID", SqlDbType.Int,4)
			};
			parameters[0].Value = EmployeeID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(WisdCar.Model.PO.EmployeePO model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Employee(");
            strSql.Append("EmployeeNo,Name,Sex,Phone,JobType,EmployeeAddr,EmployeeResume,StoreID,StoreName,LogicalStatus,CreatorID,CreatedDate,LastModifierID,LastModifiedDate,Reserved1,Reserved2,Reserved3)");
			strSql.Append(" values (");
            strSql.Append("@EmployeeNo,@Name,@Sex,@Phone,@JobType,@EmployeeAddr,@EmployeeResume,@StoreID,@StoreName,@LogicalStatus,@CreatorID,@CreatedDate,@LastModifierID,@LastModifiedDate,@Reserved1,@Reserved2,@Reserved3)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@EmployeeNo", SqlDbType.NVarChar,50),
					new SqlParameter("@Name", SqlDbType.NVarChar,50),
					new SqlParameter("@Sex", SqlDbType.NVarChar,50),
					new SqlParameter("@Phone", SqlDbType.NVarChar,50),
					new SqlParameter("@JobType", SqlDbType.NVarChar,50),
					new SqlParameter("@EmployeeAddr", SqlDbType.NVarChar,50),
					new SqlParameter("@EmployeeResume", SqlDbType.NVarChar,50),
					new SqlParameter("@StoreID", SqlDbType.Int,4),
                    new SqlParameter("@StoreName", SqlDbType.NVarChar,50),
					new SqlParameter("@LogicalStatus", SqlDbType.Int,4),
					new SqlParameter("@CreatorID", SqlDbType.NVarChar,50),
					new SqlParameter("@CreatedDate", SqlDbType.DateTime),
					new SqlParameter("@LastModifierID", SqlDbType.NVarChar,50),
					new SqlParameter("@LastModifiedDate", SqlDbType.DateTime),
					new SqlParameter("@Reserved1", SqlDbType.NVarChar,100),
					new SqlParameter("@Reserved2", SqlDbType.NVarChar,100),
					new SqlParameter("@Reserved3", SqlDbType.NVarChar,100)};
			parameters[0].Value = model.EmployeeNo;
			parameters[1].Value = model.Name;
			parameters[2].Value = model.Sex;
			parameters[3].Value = model.Phone;
			parameters[4].Value = model.JobType;
			parameters[5].Value = model.EmployeeAddr;
			parameters[6].Value = model.EmployeeResume;
			parameters[7].Value = model.StoreID;
            parameters[8].Value = model.StoreName;
			parameters[9].Value = model.LogicalStatus;
			parameters[10].Value = model.CreatorID;
			parameters[11].Value = model.CreatedDate;
			parameters[12].Value = model.LastModifierID;
			parameters[13].Value = model.LastModifiedDate;
			parameters[14].Value = model.Reserved1;
			parameters[15].Value = model.Reserved2;
			parameters[16].Value = model.Reserved3;

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
		public bool Update(WisdCar.Model.PO.EmployeePO model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Employee set ");
			strSql.Append("EmployeeNo=@EmployeeNo,");
			strSql.Append("Name=@Name,");
			strSql.Append("Sex=@Sex,");
			strSql.Append("Phone=@Phone,");
			strSql.Append("JobType=@JobType,");
			strSql.Append("EmployeeAddr=@EmployeeAddr,");
			strSql.Append("EmployeeResume=@EmployeeResume,");
			strSql.Append("StoreID=@StoreID,");
            strSql.Append("StoreName=@StoreName,");
			strSql.Append("LogicalStatus=@LogicalStatus,");
			strSql.Append("CreatorID=@CreatorID,");
			strSql.Append("CreatedDate=@CreatedDate,");
			strSql.Append("LastModifierID=@LastModifierID,");
			strSql.Append("LastModifiedDate=@LastModifiedDate,");
			strSql.Append("Reserved1=@Reserved1,");
			strSql.Append("Reserved2=@Reserved2,");
			strSql.Append("Reserved3=@Reserved3");
			strSql.Append(" where EmployeeID=@EmployeeID");
			SqlParameter[] parameters = {
					new SqlParameter("@EmployeeNo", SqlDbType.NVarChar,50),
					new SqlParameter("@Name", SqlDbType.NVarChar,50),
					new SqlParameter("@Sex", SqlDbType.NVarChar,50),
					new SqlParameter("@Phone", SqlDbType.NVarChar,50),
					new SqlParameter("@JobType", SqlDbType.NVarChar,50),
					new SqlParameter("@EmployeeAddr", SqlDbType.NVarChar,50),
					new SqlParameter("@EmployeeResume", SqlDbType.NVarChar,50),
					new SqlParameter("@StoreID", SqlDbType.Int,4),
					new SqlParameter("@StoreName", SqlDbType.NVarChar,50),
					new SqlParameter("@LogicalStatus", SqlDbType.Int,4),
					new SqlParameter("@CreatorID", SqlDbType.NVarChar,50),
					new SqlParameter("@CreatedDate", SqlDbType.DateTime),
					new SqlParameter("@LastModifierID", SqlDbType.NVarChar,50),
					new SqlParameter("@LastModifiedDate", SqlDbType.DateTime),
					new SqlParameter("@Reserved1", SqlDbType.NVarChar,100),
					new SqlParameter("@Reserved2", SqlDbType.NVarChar,100),
					new SqlParameter("@Reserved3", SqlDbType.NVarChar,100),
					new SqlParameter("@EmployeeID", SqlDbType.Int,4)};
			parameters[0].Value = model.EmployeeNo;
			parameters[1].Value = model.Name;
			parameters[2].Value = model.Sex;
			parameters[3].Value = model.Phone;
			parameters[4].Value = model.JobType;
			parameters[5].Value = model.EmployeeAddr;
			parameters[6].Value = model.EmployeeResume;
			parameters[7].Value = model.StoreID;
            parameters[8].Value = model.StoreName;
			parameters[9].Value = model.LogicalStatus;
			parameters[10].Value = model.CreatorID;
			parameters[11].Value = model.CreatedDate;
			parameters[12].Value = model.LastModifierID;
			parameters[13].Value = model.LastModifiedDate;
			parameters[14].Value = model.Reserved1;
			parameters[15].Value = model.Reserved2;
			parameters[16].Value = model.Reserved3;
			parameters[17].Value = model.EmployeeID;

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
		public bool Delete(int EmployeeID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Employee ");
			strSql.Append(" where EmployeeID=@EmployeeID");
			SqlParameter[] parameters = {
					new SqlParameter("@EmployeeID", SqlDbType.Int,4)
			};
			parameters[0].Value = EmployeeID;

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
		public bool DeleteList(string EmployeeIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Employee ");
			strSql.Append(" where EmployeeID in ("+EmployeeIDlist + ")  ");
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
		public WisdCar.Model.PO.EmployeePO GetModel(int EmployeeID)
		{
			
			StringBuilder strSql=new StringBuilder();
            strSql.Append("select  top 1 EmployeeID,EmployeeNo,Name,Sex,Phone,JobType,EmployeeAddr,EmployeeResume,StoreID,StoreName,LogicalStatus,CreatorID,CreatedDate,LastModifierID,LastModifiedDate,Reserved1,Reserved2,Reserved3 from Employee ");
			strSql.Append(" where EmployeeID=@EmployeeID");
			SqlParameter[] parameters = {
					new SqlParameter("@EmployeeID", SqlDbType.Int,4)
			};
			parameters[0].Value = EmployeeID;

			WisdCar.Model.PO.EmployeePO model=new WisdCar.Model.PO.EmployeePO();
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
		public WisdCar.Model.PO.EmployeePO DataRowToModel(DataRow row)
		{
			WisdCar.Model.PO.EmployeePO model=new WisdCar.Model.PO.EmployeePO();
			if (row != null)
			{
				if(row["EmployeeID"]!=null && row["EmployeeID"].ToString()!="")
				{
					model.EmployeeID=int.Parse(row["EmployeeID"].ToString());
				}
				if(row["EmployeeNo"]!=null && row["EmployeeNo"].ToString()!="")
				{
					model.EmployeeNo=row["EmployeeNo"].ToString();
				}
				if(row["Name"]!=null)
				{
					model.Name=row["Name"].ToString();
				}
				if(row["Sex"]!=null)
				{
					model.Sex=row["Sex"].ToString();
				}
				if(row["Phone"]!=null)
				{
					model.Phone=row["Phone"].ToString();
				}
				if(row["JobType"]!=null)
				{
					model.JobType=row["JobType"].ToString();
				}
				if(row["EmployeeAddr"]!=null)
				{
					model.EmployeeAddr=row["EmployeeAddr"].ToString();
				}
				if(row["EmployeeResume"]!=null)
				{
					model.EmployeeResume=row["EmployeeResume"].ToString();
				}
				if(row["StoreID"]!=null && row["StoreID"].ToString()!="")
				{
					model.StoreID=int.Parse(row["StoreID"].ToString());
				}
                if (row["StoreName"] != null)
                {
                    model.StoreName = row["StoreName"].ToString();
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
            strSql.Append("select EmployeeID,EmployeeNo,Name,Sex,Phone,JobType,EmployeeAddr,EmployeeResume,StoreID,StoreName,LogicalStatus,CreatorID,CreatedDate,LastModifierID,LastModifiedDate,Reserved1,Reserved2,Reserved3 ");
			strSql.Append(" FROM Employee ");
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
            strSql.Append(" EmployeeID,EmployeeNo,Name,Sex,Phone,JobType,EmployeeAddr,EmployeeResume,StoreID,StoreName,LogicalStatus,CreatorID,CreatedDate,LastModifierID,LastModifiedDate,Reserved1,Reserved2,Reserved3 ");
			strSql.Append(" FROM Employee ");
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
			strSql.Append("select count(1) FROM Employee ");
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
				strSql.Append("order by T.EmployeeID desc");
			}
			strSql.Append(")AS Row, T.*  from Employee T ");
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
			parameters[0].Value = "Employee";
			parameters[1].Value = "EmployeeID";
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
        internal int ChangePassword(string id, string password)
        {
            string sql = "update employee set Reserved1=@pwd where EmployeeNo = @empno";
            SqlParameter[] sp = {
                new SqlParameter("@pwd",password),
                new SqlParameter("@empno",id)    
            };
            return DbHelperSQL.ExecuteSql(sql, sp);
        }

        internal Model.PO.EmployeePO GetModelByEmployeeNo(string emoployeeNo)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 EmployeeID,EmployeeNo,Name,Sex,Phone,JobType,EmployeeAddr,EmployeeResume,StoreID,StoreName,LogicalStatus,CreatorID,CreatedDate,LastModifierID,LastModifiedDate,Reserved1,Reserved2,Reserved3 from Employee ");
            strSql.Append(" where EmployeeNo=@emoployeeNo");
            SqlParameter[] parameters = {
					new SqlParameter("@emoployeeNo", SqlDbType.NVarChar)
			};
            parameters[0].Value = emoployeeNo;

            WisdCar.Model.PO.EmployeePO model = new WisdCar.Model.PO.EmployeePO();
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

