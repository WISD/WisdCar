using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zeta.WisdCar.Repository.CRUD;

namespace Zeta.WisdCar.Repository.Impl
{
    public class ConsumeLogData : IConsumeLogData
    {
        private ConsumeLog _daoConsumeLog = new ConsumeLog();
        public void AddConsumeLog(Model.PO.ConsumeLogPO entity)
        {
            _daoConsumeLog.Add(entity);
        }

        public System.Data.DataSet GetConsumeInfoByBatchNo(string batchNo)
        {
            StringBuilder strSql = new StringBuilder();
            string strWhere = "";

            strSql.AppendFormat(" ConsumeBatchNo = '{0}' ", batchNo);

            strWhere = strSql.ToString();
            return _daoConsumeLog.GetList(strWhere);
        }

        public System.Data.DataSet GetConsumeLogs(Model.Entity.ConsumeLogQueryEntity entity)
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
                strSql1.AppendFormat(" CreatedDate between {0} and {1} ", entity.StartDate, entity.EndDate);
            }

            string strWhere = strSql1.ToString();

            return _daoConsumeLog.GetList(strWhere);
        }
    }
}
