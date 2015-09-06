using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zeta.WisdCar.Model.VO;

namespace Zeta.WisdCar.Business.RechargeConsumeModule
{
    public interface IConsumeMgm
    {
        /// <summary>
        /// 现金消费
        /// 会员卡状态必须为开卡状态
        /// 扣除会员卡金额，添加消费记录（事务）
        /// ConsumeVO必传字段：
        /// 消费项目ID
        /// 消费次数
        /// 会员卡号
        /// 消费批次号
        /// 注：根据消费项目ID到消费项目表中找到对应记录后，将相关数据写入消费记录
        /// </summary>
        /// <param name="list"></param>
        /// <param name="totalPrice"></param>
        /// <returns>消费批次号</returns>
        string ConsumeCash(List<ConsumeVO> list);

        /// <summary>
        /// 套餐消费
        /// 会员卡状态必须为开卡状态
        /// 扣除会员卡套餐项目剩余次数，添加消费记录（事务）
        /// ConsumeVO必传字段：
        /// 套餐余量明细ID
        /// 消费次数
        /// 会员卡号
        /// 消费批次号
        /// </summary>
        /// <param name="list"></param>
        /// <param name="totalPrice"></param>
        /// <returns>消费批次号</returns>
        string ConsumePkg(List<ConsumeVO> list);

        /// <summary>
        /// 非会员消费
        /// 添加消费记录
        /// ConsumeVO必传字段：
        /// 客户ID
        /// 消费项目ID
        /// 消费次数
        /// 消费批次号
        /// 注：根据消费项目ID到消费项目表中找到对应记录后，将相关数据写入消费记录
        /// </summary>
        /// <param name="list"></param>
        /// <param name="totalPrice"></param>
        /// <returns>消费批次号</returns>
        string ConsumeForNoCard(List<ConsumeVO> list);

        /// <summary>
        /// 根据批次号查询消费信息
        /// </summary>
        /// <param name="batchNo"></param>
        /// <returns></returns>
        List<ConsumeVO> GetConsumeInfoByBatchNo(string batchNo);


    }
}
