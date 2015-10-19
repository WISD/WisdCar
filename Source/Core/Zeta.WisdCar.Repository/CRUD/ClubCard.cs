using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Zeta.WisdCar.Infrastructure.DBUtility;
namespace Zeta.WisdCar.Repository.CRUD
{
	/// <summary>
	/// 数据访问类:ClubCard
	/// </summary>
	internal partial class ClubCard
	{
		public ClubCard()
		{}
        #region  BasicMethod

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperSQL.GetMaxID("ClubCardID", "ClubCard");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int ClubCardID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from ClubCard");
            strSql.Append(" where ClubCardID=@ClubCardID");
            SqlParameter[] parameters = {
					new SqlParameter("@ClubCardID", SqlDbType.Int,4)
			};
            parameters[0].Value = ClubCardID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(WisdCar.Model.PO.ClubCardPO model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into ClubCard(");
            strSql.Append("ClubCardTypeName,CustName,ClubCardPwd,OpenCardStore,SalesMan,SalesTime,Balance,CustomerID,ClubCardTypeID,ExpireDate,CardStatus,ClubCardNo,LogicalStatus,CreatorID,CreatedDate,LastModifierID,LastModifiedDate,Reserved1,Reserved2,Reserved3)");
            strSql.Append(" values (");
            strSql.Append("@ClubCardTypeName,@CustName,@ClubCardPwd,@OpenCardStore,@SalesMan,@SalesTime,@Balance,@CustomerID,@ClubCardTypeID,@ExpireDate,@CardStatus,@ClubCardNo,@LogicalStatus,@CreatorID,@CreatedDate,@LastModifierID,@LastModifiedDate,@Reserved1,@Reserved2,@Reserved3)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@ClubCardTypeName", SqlDbType.NVarChar,50),
					new SqlParameter("@CustName", SqlDbType.NVarChar,50),
					new SqlParameter("@ClubCardPwd", SqlDbType.NVarChar,50),
					new SqlParameter("@OpenCardStore", SqlDbType.NVarChar,50),
					new SqlParameter("@SalesMan", SqlDbType.NVarChar,50),
					new SqlParameter("@SalesTime", SqlDbType.DateTime),
					new SqlParameter("@Balance", SqlDbType.Decimal,5),
					new SqlParameter("@CustomerID", SqlDbType.Int,4),
					new SqlParameter("@ClubCardTypeID", SqlDbType.Int,4),
					new SqlParameter("@ExpireDate", SqlDbType.DateTime),
					new SqlParameter("@CardStatus", SqlDbType.Int,4),
					new SqlParameter("@ClubCardNo", SqlDbType.NVarChar,50),
					new SqlParameter("@LogicalStatus", SqlDbType.Int,4),
					new SqlParameter("@CreatorID", SqlDbType.NVarChar,50),
					new SqlParameter("@CreatedDate", SqlDbType.DateTime),
					new SqlParameter("@LastModifierID", SqlDbType.NVarChar,50),
					new SqlParameter("@LastModifiedDate", SqlDbType.DateTime),
					new SqlParameter("@Reserved1", SqlDbType.NVarChar,100),
					new SqlParameter("@Reserved2", SqlDbType.NVarChar,100),
					new SqlParameter("@Reserved3", SqlDbType.NVarChar,100)};
            parameters[0].Value = model.ClubCardTypeName;
            parameters[1].Value = model.CustName;
            parameters[2].Value = model.ClubCardPwd;
            parameters[3].Value = model.OpenCardStore;
            parameters[4].Value = model.SalesMan;
            parameters[5].Value = model.SalesTime;
            parameters[6].Value = model.Balance;
            parameters[7].Value = model.CustomerID;
            parameters[8].Value = model.ClubCardTypeID;
            parameters[9].Value = model.ExpireDate;
            parameters[10].Value = model.CardStatus;
            parameters[11].Value = model.ClubCardNo;
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
        public bool Update(WisdCar.Model.PO.ClubCardPO model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update ClubCard set ");
            strSql.Append("ClubCardTypeName=@ClubCardTypeName,");
            strSql.Append("CustName=@CustName,");
            strSql.Append("ClubCardPwd=@ClubCardPwd,");
            strSql.Append("OpenCardStore=@OpenCardStore,");
            strSql.Append("SalesMan=@SalesMan,");
            strSql.Append("SalesTime=@SalesTime,");
            strSql.Append("Balance=@Balance,");
            strSql.Append("CustomerID=@CustomerID,");
            strSql.Append("ClubCardTypeID=@ClubCardTypeID,");
            strSql.Append("ExpireDate=@ExpireDate,");
            strSql.Append("CardStatus=@CardStatus,");
            strSql.Append("ClubCardNo=@ClubCardNo,");
            strSql.Append("LogicalStatus=@LogicalStatus,");
            strSql.Append("CreatorID=@CreatorID,");
            strSql.Append("CreatedDate=@CreatedDate,");
            strSql.Append("LastModifierID=@LastModifierID,");
            strSql.Append("LastModifiedDate=@LastModifiedDate,");
            strSql.Append("Reserved1=@Reserved1,");
            strSql.Append("Reserved2=@Reserved2,");
            strSql.Append("Reserved3=@Reserved3");
            strSql.Append(" where ClubCardID=@ClubCardID");
            SqlParameter[] parameters = {
					new SqlParameter("@ClubCardTypeName", SqlDbType.NVarChar,50),
					new SqlParameter("@CustName", SqlDbType.NVarChar,50),
					new SqlParameter("@ClubCardPwd", SqlDbType.NVarChar,50),
					new SqlParameter("@OpenCardStore", SqlDbType.NVarChar,50),
					new SqlParameter("@SalesMan", SqlDbType.NVarChar,50),
					new SqlParameter("@SalesTime", SqlDbType.DateTime),
					new SqlParameter("@Balance", SqlDbType.Decimal,5),
					new SqlParameter("@CustomerID", SqlDbType.Int,4),
					new SqlParameter("@ClubCardTypeID", SqlDbType.Int,4),
					new SqlParameter("@ExpireDate", SqlDbType.DateTime),
					new SqlParameter("@CardStatus", SqlDbType.Int,4),
					new SqlParameter("@ClubCardNo", SqlDbType.NVarChar,50),
					new SqlParameter("@LogicalStatus", SqlDbType.Int,4),
					new SqlParameter("@CreatorID", SqlDbType.NVarChar,50),
					new SqlParameter("@CreatedDate", SqlDbType.DateTime),
					new SqlParameter("@LastModifierID", SqlDbType.NVarChar,50),
					new SqlParameter("@LastModifiedDate", SqlDbType.DateTime),
					new SqlParameter("@Reserved1", SqlDbType.NVarChar,100),
					new SqlParameter("@Reserved2", SqlDbType.NVarChar,100),
					new SqlParameter("@Reserved3", SqlDbType.NVarChar,100),
					new SqlParameter("@ClubCardID", SqlDbType.Int,4)};
            parameters[0].Value = model.ClubCardTypeName;
            parameters[1].Value = model.CustName;
            parameters[2].Value = model.ClubCardPwd;
            parameters[3].Value = model.OpenCardStore;
            parameters[4].Value = model.SalesMan;
            parameters[5].Value = model.SalesTime;
            parameters[6].Value = model.Balance;
            parameters[7].Value = model.CustomerID;
            parameters[8].Value = model.ClubCardTypeID;
            parameters[9].Value = model.ExpireDate;
            parameters[10].Value = model.CardStatus;
            parameters[11].Value = model.ClubCardNo;
            parameters[12].Value = model.LogicalStatus;
            parameters[13].Value = model.CreatorID;
            parameters[14].Value = model.CreatedDate;
            parameters[15].Value = model.LastModifierID;
            parameters[16].Value = model.LastModifiedDate;
            parameters[17].Value = model.Reserved1;
            parameters[18].Value = model.Reserved2;
            parameters[19].Value = model.Reserved3;
            parameters[20].Value = model.ClubCardID;

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
        /// 更新一条数据(部分列)
        /// </summary>
        public bool UpdateModel(WisdCar.Model.PO.ClubCardPO model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update ClubCard set ");
            strSql.Append("ClubCardTypeName=@ClubCardTypeName,");
            strSql.Append("OpenCardStore=@OpenCardStore,");
            strSql.Append("SalesMan=@SalesMan,");
            strSql.Append("ClubCardTypeID=@ClubCardTypeID,");
            strSql.Append("CardStatus=@CardStatus,");
            strSql.Append("ClubCardNo=@ClubCardNo,");
            strSql.Append("LastModifierID=@LastModifierID,");
            strSql.Append("Reserved1=@Reserved1,");
            strSql.Append("LastModifiedDate=@LastModifiedDate");
            strSql.Append(" where ClubCardID=@ClubCardID");
            
            SqlParameter[] parameters = {
					new SqlParameter("@ClubCardTypeName", SqlDbType.NVarChar,50),
					new SqlParameter("@OpenCardStore", SqlDbType.NVarChar,50),
					new SqlParameter("@SalesMan", SqlDbType.NVarChar,50),
					new SqlParameter("@ClubCardTypeID", SqlDbType.Int,4),
					new SqlParameter("@CardStatus", SqlDbType.Int,4),
					new SqlParameter("@ClubCardNo", SqlDbType.NVarChar,50),
					new SqlParameter("@LastModifierID", SqlDbType.NVarChar,50),
                    new SqlParameter("@Reserved1", SqlDbType.NVarChar,100),
					new SqlParameter("@LastModifiedDate", SqlDbType.DateTime),
					new SqlParameter("@ClubCardID", SqlDbType.Int,4)
                    
                                        };
            parameters[0].Value = model.ClubCardTypeName;
            parameters[1].Value = model.OpenCardStore;
            parameters[2].Value = model.SalesMan;
            parameters[3].Value = model.ClubCardTypeID;
            parameters[4].Value = model.CardStatus;
            parameters[5].Value = model.ClubCardNo;
            parameters[6].Value = model.LastModifierID;
            parameters[7].Value = model.Reserved1;
            parameters[8].Value = model.LastModifiedDate;
            parameters[9].Value = model.ClubCardID;
            

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
        public bool Delete(int ClubCardID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from ClubCard ");
            strSql.Append(" where ClubCardID=@ClubCardID");
            SqlParameter[] parameters = {
					new SqlParameter("@ClubCardID", SqlDbType.Int,4)
			};
            parameters[0].Value = ClubCardID;

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
        public bool DeleteList(string ClubCardIDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from ClubCard ");
            strSql.Append(" where ClubCardID in (" + ClubCardIDlist + ")  ");
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
        public WisdCar.Model.PO.ClubCardPO GetModel(int ClubCardID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ClubCardID,ClubCardTypeName,CustName,ClubCardPwd,OpenCardStore,SalesMan,SalesTime,Balance,CustomerID,ClubCardTypeID,ExpireDate,CardStatus,ClubCardNo,LogicalStatus,CreatorID,CreatedDate,LastModifierID,LastModifiedDate,Reserved1,Reserved2,Reserved3 from ClubCard ");
            strSql.Append(" where ClubCardID=@ClubCardID");
            SqlParameter[] parameters = {
					new SqlParameter("@ClubCardID", SqlDbType.Int,4)
			};
            parameters[0].Value = ClubCardID;

            WisdCar.Model.PO.ClubCardPO model = new WisdCar.Model.PO.ClubCardPO();
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
        public WisdCar.Model.PO.ClubCardPO GetModel(int ClubCardID, int type)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ClubCardID,ClubCardTypeName,CustName,ClubCardPwd,OpenCardStore,SalesMan,SalesTime,Balance,CustomerID,ClubCardTypeID,ExpireDate,CardStatus,ClubCardNo,LogicalStatus,CreatorID,CreatedDate,LastModifierID,LastModifiedDate,Reserved1,Reserved2,Reserved3 from ClubCard ");
            if (type == 0)
            {
                strSql.Append(" where ClubCardID=@ClubCardID");
            }
            else
            {
                //因为客户可能有多张会员卡所以排序取第一张
                strSql.Append(" where CustomerID=@ClubCardID order by CreatedDate desc");
            }

            SqlParameter[] parameters = {
					new SqlParameter("@ClubCardID", SqlDbType.Int,4)
			};
            parameters[0].Value = ClubCardID;

            WisdCar.Model.PO.ClubCardPO model = new WisdCar.Model.PO.ClubCardPO();
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
        public WisdCar.Model.PO.ClubCardPO GetCardByCardNo(string cardNo)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ClubCardID,ClubCardTypeName,CustName,ClubCardPwd,OpenCardStore,SalesMan,SalesTime,Balance,CustomerID,ClubCardTypeID,ExpireDate,CardStatus,ClubCardNo,LogicalStatus,CreatorID,CreatedDate,LastModifierID,LastModifiedDate,Reserved1,Reserved2,Reserved3 from ClubCard ");
           
            strSql.Append(" where clubcardno=@clubcardno");
          

            SqlParameter[] parameters = {
					new SqlParameter("@clubcardno", SqlDbType.NVarChar)
			};
            parameters[0].Value = cardNo;

            WisdCar.Model.PO.ClubCardPO model = new WisdCar.Model.PO.ClubCardPO();
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
        public WisdCar.Model.PO.ClubCardPO DataRowToModel(DataRow row)
        {
            WisdCar.Model.PO.ClubCardPO model = new WisdCar.Model.PO.ClubCardPO();
            if (row != null)
            {
                if (row["ClubCardID"] != null && row["ClubCardID"].ToString() != "")
                {
                    model.ClubCardID = int.Parse(row["ClubCardID"].ToString());
                }
                if (row["ClubCardTypeName"] != null)
                {
                    model.ClubCardTypeName = row["ClubCardTypeName"].ToString();
                }
                if (row["CustName"] != null)
                {
                    model.CustName = row["CustName"].ToString();
                }
                if (row["ClubCardPwd"] != null)
                {
                    model.ClubCardPwd = row["ClubCardPwd"].ToString();
                }
                if (row["OpenCardStore"] != null)
                {
                    model.OpenCardStore = row["OpenCardStore"].ToString();
                }
                if (row["SalesMan"] != null)
                {
                    model.SalesMan = row["SalesMan"].ToString();
                }
                if (row["SalesTime"] != null && row["SalesTime"].ToString() != "")
                {
                    model.SalesTime = DateTime.Parse(row["SalesTime"].ToString());
                }
                if (row["Balance"] != null && row["Balance"].ToString() != "")
                {
                    model.Balance = decimal.Parse(row["Balance"].ToString());
                }
                if (row["CustomerID"] != null && row["CustomerID"].ToString() != "")
                {
                    model.CustomerID = int.Parse(row["CustomerID"].ToString());
                }
                if (row["ClubCardTypeID"] != null && row["ClubCardTypeID"].ToString() != "")
                {
                    model.ClubCardTypeID = int.Parse(row["ClubCardTypeID"].ToString());
                }
                if (row["ExpireDate"] != null && row["ExpireDate"].ToString() != "")
                {
                    model.ExpireDate = DateTime.Parse(row["ExpireDate"].ToString());
                }
                if (row["CardStatus"] != null && row["CardStatus"].ToString() != "")
                {
                    model.CardStatus = int.Parse(row["CardStatus"].ToString());
                }
                if (row["ClubCardNo"] != null)
                {
                    model.ClubCardNo = row["ClubCardNo"].ToString();
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
            strSql.Append("select ClubCardID,ClubCardTypeName,CustName,ClubCardPwd,OpenCardStore,SalesMan,SalesTime,Balance,CustomerID,ClubCardTypeID,ExpireDate,CardStatus,ClubCardNo,LogicalStatus,CreatorID,CreatedDate,LastModifierID,LastModifiedDate,Reserved1,Reserved2,Reserved3 ");
            strSql.Append(" FROM ClubCard ");
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
            strSql.Append(" ClubCardID,ClubCardTypeName,CustName,ClubCardPwd,OpenCardStore,SalesMan,SalesTime,Balance,CustomerID,ClubCardTypeID,ExpireDate,CardStatus,ClubCardNo,LogicalStatus,CreatorID,CreatedDate,LastModifierID,LastModifiedDate,Reserved1,Reserved2,Reserved3 ");
            strSql.Append(" FROM ClubCard ");
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
            strSql.Append("select count(1) FROM ClubCard ");
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
                strSql.Append("order by T.ClubCardID desc");
            }
            strSql.Append(")AS Row, T.*,c.mobileno as MobileNo  from ClubCard T join customer c on t.customerid = c.customerid ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" where "+ strWhere);
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
            parameters[0].Value = "ClubCard";
            parameters[1].Value = "ClubCardID";
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
        internal void UpdatePwd(int clubCardID, string p)
        {
            string sql = "update clubcard set ClubCardPwd=@pwd where ClubCardID=@cardid";
            SqlParameter[] sp = { 
                                new SqlParameter("@pwd",p),
                                new SqlParameter("@cardid",clubCardID)
                                };
            DbHelperSQL.ExecuteSql(sql, sp);
        }

        internal void UpdateClubCardStatus(int clubCardID, int status)
        {
            string sql = "update clubcard set CardStatus=@status where ClubCardID=@cardid";
            SqlParameter[] sp = { 
                                new SqlParameter("@status",status),
                                new SqlParameter("@cardid",clubCardID)
                                };
            DbHelperSQL.ExecuteSql(sql, sp);
        }

        internal void UpdateClubCardNo(int clubCardID, string newClubCardNo)
        {
            string sql = "update clubcard set ClubCardNo=@cardno,cardstatus=0 where ClubCardID=@cardid";
            SqlParameter[] sp = { 
                                new SqlParameter("@cardno",newClubCardNo),
                                new SqlParameter("@cardid",clubCardID)
                                };
            DbHelperSQL.ExecuteSql(sql, sp);
        }
	}
}

