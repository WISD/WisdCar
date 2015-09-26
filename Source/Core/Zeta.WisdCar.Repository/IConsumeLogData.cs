using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zeta.WisdCar.Model.Entity;
using Zeta.WisdCar.Model.PO;
using Zeta.WisdCar.Model.VO;

namespace Zeta.WisdCar.Repository
{
    public interface IConsumeLogData
    {
        /// <summary>
        /// Add to ���Ѽ�¼��
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        void AddConsumeLog(ConsumeLogPO entity);

        /// <summary>
        /// �������κŲ�ѯ������Ϣ
        /// </summary>
        /// <param name="batchNo"></param>
        /// <returns></returns>
        DataSet GetConsumeInfoByBatchNo(string batchNo);

        /// <summary>
        /// ��ѯ���Ѽ�¼
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        DataSet GetConsumeLogs(ConsumeLogQueryEntity entity);
    }
}