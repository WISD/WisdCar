using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zeta.WisdCar.Model.VO
{
    public class ClubCardVO
    {
        public ClubCardVO()
        { }

        #region Model
        private string _rowid;
        private string _operation;
        private string _mobileno;
        private string _cardstatusdesc;
        private string _icno;
        private string _birthday;

        private int _clubcardid;
        private string _clubcardtypename;
        private string _custname;
        private string _clubcardpwd;
        private string _opencardstore;
        private string _salesman;
        private DateTime _salestime;
        private decimal _balance;
        private int _customerid;
        private int _clubcardtypeid;
        private DateTime _expiredate;
        private int _cardstatus;
        private string _clubcardno;
        private int _logicalstatus = 1;
        private string _creatorid;
        private DateTime _createddate;
        private string _lastmodifierid;
        private DateTime _lastmodifieddate;
        private string _reserved1;
        private string _reserved2;
        private string _reserved3;

        /// <summary>
        /// Datatables Row ID
        /// </summary>
        public string DT_RowId
        {
            set { _rowid = value; }
            get { return _rowid; }
        }
        /// <summary>
        /// 操作
        /// </summary>
        public string Operation
        {
            set { _operation = value; }
            get { return _operation; }
        }
        /// <summary>
        /// 手机号码
        /// </summary>
        public string MobileNo
        {
            set { _mobileno = value; }
            get { return _mobileno; }
        }
        /// <summary>
        /// 会员卡类型
        /// </summary>
        public string CardStatusDesc
        {
            set { _cardstatusdesc = value; }
            get { return _cardstatusdesc; }
        }
        /// <summary>
        /// 身份证号
        /// </summary>
        public string ICNo
        {
            set { _icno = value; }
            get { return _icno; }
        }
        /// <summary>
        /// 生日
        /// </summary>
        public string Birthday
        {
            set { _birthday = value; }
            get { return _birthday; }
        }

        /// <summary>
        /// 会员卡表ID
        /// </summary>
        public int ClubCardID
        {
            set { _clubcardid = value; }
            get { return _clubcardid; }
        }
        /// <summary>
        /// 会员卡类型名
        /// </summary>
        public string ClubCardTypeName
        {
            set { _clubcardtypename = value; }
            get { return _clubcardtypename; }
        }
        /// <summary>
        /// 客户姓名
        /// </summary>
        public string CustName
        {
            set { _custname = value; }
            get { return _custname; }
        }
        /// <summary>
        /// 会员卡密码
        /// </summary>
        public string ClubCardPwd
        {
            set { _clubcardpwd = value; }
            get { return _clubcardpwd; }
        }
        /// <summary>
        /// 开卡门店
        /// </summary>
        public string OpenCardStore
        {
            set { _opencardstore = value; }
            get { return _opencardstore; }
        }
        /// <summary>
        /// 销售人员
        /// </summary>
        public string SalesMan
        {
            set { _salesman = value; }
            get { return _salesman; }
        }
        /// <summary>
        /// 售卡时间
        /// </summary>
        public DateTime SalesTime
        {
            set { _salestime = value; }
            get { return _salestime; }
        }
        /// <summary>
        /// 余额
        /// </summary>
        public decimal Balance
        {
            set { _balance = value; }
            get { return _balance; }
        }
        /// <summary>
        /// 客户ID
        /// </summary>
        public int CustomerID
        {
            set { _customerid = value; }
            get { return _customerid; }
        }
        /// <summary>
        /// 会员卡类型表ID
        /// </summary>
        public int ClubCardTypeID
        {
            set { _clubcardtypeid = value; }
            get { return _clubcardtypeid; }
        }
        /// <summary>
        /// 会员卡截至日期
        /// </summary>
        public DateTime ExpireDate
        {
            set { _expiredate = value; }
            get { return _expiredate; }
        }
        /// <summary>
        /// 会员卡状态
        /// </summary>
        public int CardStatus
        {
            set { _cardstatus = value; }
            get { return _cardstatus; }
        }
        /// <summary>
        /// 会员卡号
        /// </summary>
        public string ClubCardNo
        {
            set { _clubcardno = value; }
            get { return _clubcardno; }
        }
        /// <summary>
        /// 逻辑状态
        /// </summary>
        public int LogicalStatus
        {
            set { _logicalstatus = value; }
            get { return _logicalstatus; }
        }
        /// <summary>
        /// 创建人ID
        /// </summary>
        public string CreatorID
        {
            set { _creatorid = value; }
            get { return _creatorid; }
        }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreatedDate
        {
            set { _createddate = value; }
            get { return _createddate; }
        }
        /// <summary>
        /// 最近修改人ID
        /// </summary>
        public string LastModifierID
        {
            set { _lastmodifierid = value; }
            get { return _lastmodifierid; }
        }
        /// <summary>
        /// 最近修改时间
        /// </summary>
        public DateTime LastModifiedDate
        {
            set { _lastmodifieddate = value; }
            get { return _lastmodifieddate; }
        }
        /// <summary>
        /// 保留字段1
        /// </summary>
        public string Reserved1
        {
            set { _reserved1 = value; }
            get { return _reserved1; }
        }
        /// <summary>
        /// 保留字段2
        /// </summary>
        public string Reserved2
        {
            set { _reserved2 = value; }
            get { return _reserved2; }
        }
        /// <summary>
        /// 保留字段3
        /// </summary>
        public string Reserved3
        {
            set { _reserved3 = value; }
            get { return _reserved3; }
        }
        #endregion Model
    }
}
