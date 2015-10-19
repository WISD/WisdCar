using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zeta.WisdCar.Infrastructure
{
    /// <summary>
    /// 协议
    /// </summary>
    public enum Proto
    {
        Tcp = 0,
        Http = 1
    }
    /// <summary>
    /// excel版本
    /// </summary>
    public enum ExcelEdition
    {
        Excel97,
        Excel2000,
        Excel2003,
        Excel2007
    }
    public enum ClubCardStatus
    {
        OpenCard = 0,    //开卡
        ReportLoss = 1,    //挂失
        Froze = 2,    //冻结
        LogOff = 3,    //注销
        Expire = 4    //过期
    }

    public enum CardSPackageStatus
    { 
        Available = 0,   //套餐可用
        Unavailable = 1    //套餐不可用
    }

    public enum PayType
    {
        Cash = 0,       //现金
        Card = 1,       //银行卡
        WeiXinPay = 2,  //微信支付
        Alipay = 3      //支付宝
    }

    public enum RechargeType
    {
        ClubCash = 0,       //会员现金充值
        ClubPackage = 1    //会员套餐充值
    }

    public enum ConsumeType
    {
        ClubCash = 0,       //会员现金消费
        ClubPackage = 1,    //会员套餐消费
        NoCard   = 2        //非会员消费
    }
    public enum DDLlist
    {
        CardType = 0,//会员卡类型
        PkgItem = 1,//套餐消费项目
        Pkg=3,
    }
}
