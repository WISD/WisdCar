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
    }
}
