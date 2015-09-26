using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zeta.WisdCar.Model.Entity;
using Zeta.WisdCar.Model.PO;

namespace Zeta.WisdCar.Repository
{
    public interface IRechargeLogData
    {
        /// <summary>
        /// Add to 充值记录表
        /// </summary>
        /// <param name="entity"></param>
        void AddRechargeLog(RechargeLogPO entity);


        /// <summary>
        /// 获取制定条件获取充值记录
        /// </summary>
        /// <returns></returns>
        DataSet GetRechargeLogs(RechargeLogQueryEntity entity);
    }
}
