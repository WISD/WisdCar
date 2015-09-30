using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zeta.WisdCar.Business.SysMgmModule;
using Zeta.WisdCar.Infrastructure;

namespace Zeta.WisdCar.Business.Handler
{
    public class SerialNoGenerator
    {

        /// <summary>
        /// 充值流水号(生成规则：1（充值） +  门店ID  +  yymmddHHmmss)
        /// </summary>
        /// <returns></returns>
        public static string GenRechargeSerialNo(int storeid)
        {
            StringBuilder strTemp = new StringBuilder();
            string strSerialNo = "";
            strTemp.AppendFormat("{0}{1}{2}", 1, storeid, DateTime.Now.ToString("yymmddHHmmss"));
            strSerialNo = strTemp.ToString();
            return strSerialNo;
        }

        /// <summary>
        /// 消费批次编号(生成规则：2（消费） +  门店ID  +  yymmddHHmmss)
        /// </summary>
        /// <returns></returns>
        public static string GenConsumeBatchNo()
        {
            StringBuilder strTemp = new StringBuilder();
            string strBatchNo = "";
            strTemp.AppendFormat("{0}{1}{2}", 2,PermissionMgm.GetCurUser1(), DateTime.Now.ToString("yymmddHHmmss"));
            strBatchNo = strTemp.ToString();
            return strBatchNo;
        }


        /// <summary>
        /// 会员卡号（生成规则：公司的唯一标识 + 年月日6位 + 手机号码后四位，公司唯一标识定义在AppSettings里）
        /// </summary>
        /// <returns></returns>
        public static string GenClubCardNo()
        {
            StringBuilder strTemp = new StringBuilder();
            string strClubCardNo = "";
            string strMobileNo = "";
            strMobileNo = PermissionMgm.GetCurUser1().MobileNO;
            strTemp.AppendFormat("{0}{1}{2}", AppSettings.CorpUniqueNo, DateTime.Now.ToString("yymmdd"), strMobileNo.Substring(strMobileNo.Length - 4, 4));
            strClubCardNo = strTemp.ToString();
            return strClubCardNo;
        }

        /// <summary>
        /// 会员卡套餐ID（生成规则：yymmddHHmmss）
        /// </summary>
        /// <returns></returns>
        public static string GenClubCardPkgID()
        {
            return DateTime.Now.ToString("yymmddHHmmss");
        }

    }
}
