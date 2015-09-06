using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zeta.WisdCar.Model.PO;

namespace Zeta.WisdCar.Repository
{
    public interface IRechargeLogData
    {
        /// <summary>
        /// Add to 充值记录表
        /// </summary>
        /// <param name="package"></param>
        void AddRechargeLog(RechargeLogPO entity);
    }
}
