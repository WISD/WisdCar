using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zeta.WisdCar.Repository.CRUD;

namespace Zeta.WisdCar.Repository.Impl
{
    public class RechargeLogData : IRechargeLogData
    {
        private RechargeLog _daoRechargeLog = new RechargeLog();
        public void AddRechargeLog(Model.PO.RechargeLogPO entity)
        {
            _daoRechargeLog.Add(entity);
        }


        public System.Data.DataSet GetRechargeLogs(Model.Entity.RechargeLogQueryEntity entity)
        {
            StringBuilder strSql1 = new StringBuilder();

            if (!string.IsNullOrEmpty(entity.MobileNo.Trim()))
            {
                strSql1.AppendFormat(" MobileNo like '%{0}%' ", entity.MobileNo);
            }

            if (!string.IsNullOrEmpty(entity.CustName.Trim()))
            {
                if (strSql1.Length > 0)
                    strSql1.AppendFormat(" And ");
                strSql1.AppendFormat(" CustName like '%{0}%' ", entity.CustName);
            }

            if (!string.IsNullOrEmpty(entity.ICNo.Trim()))
            {
                if (strSql1.Length > 0)
                    strSql1.AppendFormat(" And ");
                strSql1.AppendFormat(" ICNo like '%{0}%' ", entity.ICNo);
            }

            if (!string.IsNullOrEmpty(entity.ClubCardNO.Trim()))
            {
                if (strSql1.Length > 0)
                    strSql1.AppendFormat(" And ");
                strSql1.AppendFormat(" ClubCardNO like '%{0}%' ", entity.ClubCardNO);
            }

            if (!string.IsNullOrEmpty(entity.StoreID.Trim()))
            {
                if (strSql1.Length > 0)
                    strSql1.AppendFormat(" And ");
                strSql1.AppendFormat(" StoreID = {0} ", entity.StoreID);
            }

            if ((!string.IsNullOrEmpty(entity.StartDate.ToString())) && (!string.IsNullOrEmpty(entity.EndDate.ToString())))
            {
                if (strSql1.Length > 0)
                    strSql1.AppendFormat(" And ");
                strSql1.AppendFormat(" CreatedDate between {0} and {1} ", entity.StartDate,entity.EndDate);
            }

            string strWhere = strSql1.ToString();

            return _daoRechargeLog.GetList(strWhere);
        }
    }
}
