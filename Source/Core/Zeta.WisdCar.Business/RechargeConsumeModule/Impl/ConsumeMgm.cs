using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zeta.WisdCar.Business.RechargeConsumeModule
{
    public class ConsumeMgm : IConsumeMgm
    {
        public string ConsumeCash(List<Model.VO.ConsumeVO> list)
        {
            throw new NotImplementedException();
        }

        public string ConsumePkg(List<Model.VO.ConsumeVO> list)
        {
            throw new NotImplementedException();
        }

        public string ConsumeForNoCard(List<Model.VO.ConsumeVO> list)
        {
            throw new NotImplementedException();
        }

        public List<Model.VO.ConsumeVO> GetConsumeInfoByBatchNo(string batchNo)
        {
            throw new NotImplementedException();
        }

        public List<Model.VO.ConsumeQueryVO> GetConsumeLog(Model.Entity.ConsumeLogQueryEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
