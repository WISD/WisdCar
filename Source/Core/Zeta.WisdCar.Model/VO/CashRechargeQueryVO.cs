using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zeta.WisdCar.Model.VO
{
    public class CashRechargeQueryVO
    {
        public CashRechargeQueryVO()
        { }


        #region Model
        private int _rechargelogid;
        private int _paytype;
        private string _salesman;
        private string _serialno;
        private int _clubcardid;
        private int _clubcardno;
        private int _custid;
        private string _custname;
        private DateTime _rechargedate;
        private string _rechargestore;
        private string _originalstore;
        private decimal _actualrechargeamount;
        private string _actualrechargeamountdesc;
        private int _rechargetype;
        private decimal _platformrechargeamount;
        private string _platformrechargeamountdesc;
        private decimal _discountrate;
        private string _discountratedesc;
        private string _discountinfo;

        /// <summary>
        /// 充值记录ID
        /// </summary>
        public int RechargeLogID
        {
            set { _rechargelogid = value; }
            get { return _rechargelogid; }
        }

        /// <summary>
        /// 支付类型
        /// </summary>
        public int PayType
        {
            get { return _paytype; }
            set { _paytype = value; }
        }

        /// <summary>
        /// 销售人员
        /// </summary>
        public string SalesMan
        {
            get { return _salesman; }
            set { _salesman = value; }
        }

        /// <summary>
        /// 充值流水号
        /// </summary>
        public string SerialNo
        {
            get { return _serialno; }
            set { _serialno = value; }
        }

        /// <summary>
        /// 会员卡ID
        /// </summary>
        public int ClubCardID
        {
            set { _clubcardid = value; }
            get { return _clubcardid; }
        }
        /// <summary>
        /// 会员卡编号
        /// </summary>
        public int ClubCardNo
        {
            set { _clubcardno = value; }
            get { return _clubcardno; }
        }
        /// <summary>
        /// 客户ID
        /// </summary>
        public int CustID
        {
            set { _custid = value; }
            get { return _custid; }
        }
        /// <summary>
        /// 客户名称
        /// </summary>
        public string CustName
        {
            set { _custname = value; }
            get { return _custname; }
        }
        /// <summary>
        /// 充值日期
        /// </summary>
        public DateTime RechargeDate
        {
            set { _rechargedate = value; }
            get { return _rechargedate; }
        }
        /// <summary>
        /// 充值门店
        /// </summary>
        public string RechargeStore
        {
            set { _rechargestore = value; }
            get { return _rechargestore; }
        }
        /// <summary>
        /// 开户门店
        /// </summary>
        public string OriginalStore
        {
            set { _originalstore = value; }
            get { return _originalstore; }
        }
        /// <summary>
        /// 实收充值金额
        /// </summary>
        public decimal ActualRechargeAmount
        {
            set { _actualrechargeamount = value; }
            get { return _actualrechargeamount; }
        }

        /// <summary>
        /// 实收充值金额Desc
        /// </summary>
        public string ActualRechargeAmountDesc
        {
            set { _actualrechargeamountdesc = value; }
            get { return _actualrechargeamountdesc; }
        }
        /// <summary>
        /// 充值类型
        /// </summary>
        public int RechargeType
        {
            set { _rechargetype = value; }
            get { return _rechargetype; }
        }

        /// <summary>
        /// 平台入账金额
        /// </summary>
        public decimal PlatformRechargeAmount
        {
            set { _platformrechargeamount = value; }
            get { return _platformrechargeamount; }
        }

        /// <summary>
        /// 平台入账金额Desc
        /// </summary>
        public string PlatformRechargeAmountDesc
        {
            set { _platformrechargeamountdesc = value; }
            get { return _platformrechargeamountdesc; }
        }

        /// <summary>
        /// 折扣率
        /// </summary>
        public decimal DiscountRate
        {
            set { _discountrate = value; }
            get { return _discountrate; }
        }

        /// <summary>
        /// 折扣率Desc
        /// </summary>
        public string DiscountRateDesc
        {
            set { _discountratedesc = value; }
            get { return _discountratedesc; }
        }

        /// <summary>
        /// 折扣信息
        /// </summary>
        public string DiscountInfo
        {
            set { _discountinfo = value; }
            get { return _discountinfo; }
        }
        #endregion Model


        #region Ext
        
        #endregion
    }
}
