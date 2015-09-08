using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zeta.WisdCar.Business.Handler
{
    public class SerialNoGenerator
    {

        /// <summary>
        /// 充值流水号(生成规则：1（充值） +  门店ID  +  yymmddHHmmss)
        /// </summary>
        /// <returns></returns>
        public string GenRechargeSerialNo()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 消费批次编号(生成规则：2（消费） +  门店ID  +  yymmddHHmmss)
        /// </summary>
        /// <returns></returns>
        public string GenConsumeBatchNo()
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// 会员卡号（生成规则：公司的唯一标识 + 年月日6位 + 手机号码后四位，公司唯一标识定义在AppSettings里）
        /// </summary>
        /// <returns></returns>
        public string GenClubCardNo()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 会员卡套餐ID（生成规则：yymmddHHmmss）
        /// </summary>
        /// <returns></returns>
        public string GenClubCardPkgID()
        {
            throw new NotImplementedException();
        }

    }
}
