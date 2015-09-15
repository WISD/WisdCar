using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zeta.WisdCar.Model.Entity;
using Zeta.WisdCar.Model.VO;

namespace Zeta.WisdCar.Business.RechargeConsumeModule
{
    public interface IRechargeMgm
    {
        /// <summary>
        /// 现金充值
        /// 检验会员卡状态，必须是开卡状态
        /// 插入充值记录，更新会员卡余额（事务）
        /// 操作人员，充值门店从登陆信息里取
        /// RechargeVO必传字段：
        /// 充值流水号
        /// 会员卡号
        /// 充值金额
        /// 入账金额
        /// 支付类型
        /// </summary>
        /// <param name="entity"></param>
        void RechargeCash(RechargeVO entity);

        /// <summary>
        /// 套餐充值
        /// 检验会员卡状态，必须是开卡状态
        /// 插入会员卡套餐表，插入套餐明细表，插入充值记录（事务）
        /// 操作人员，充值门店从登陆信息里取
        /// RechargeVO必传字段：
        /// 套餐表ID
        /// 充值流水号
        /// 会员卡号
        /// 套餐总价
        /// 实收金额
        /// 支付类型
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>返回会员卡套餐ID</returns>
        int RechargePkg(RechargeVO entity);

        /// <summary>
        /// 查询充值记录
        /// 现金充值记录
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        List<CashRechargeQueryVO> GetRechargeCashLog(RechargeLogQueryEntity entity);

        /// <summary>
        /// 查询充值记录
        /// 套餐充值记录
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        List<PkgRechargeQueryVO> GetRechargePkgLog(RechargeLogQueryEntity entity);
    }
}
