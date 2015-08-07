using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zeta.WisdCar.Model.VO
{
    public class ClubCardTypeVO
    {
        public ClubCardTypeVO()
        { }

        private string _operation;
        private int _clubcardtypeid;
        private string _cardtypename;
        private decimal _packagediscount;
        private decimal _paydiscount;
        private int _logicalstatus = 1;
        private string _creatorid;
        private DateTime _createddate;
        private string _lastmodifierid;
        private DateTime _lastmodifieddate;
        private string _reserved1;
        private string _reserved2;
        private string _reserved3;

        /// <summary>
        /// 操作
        /// </summary>
        public string Operation
        {
            set { _operation = value; }
            get { return _operation; }
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
        /// 会员卡类型名称
        /// </summary>
        public string CardTypeName
        {
            set { _cardtypename = value; }
            get { return _cardtypename; }
        }
        /// <summary>
        /// 套餐折扣
        /// </summary>
        public decimal PackageDiscount
        {
            set { _packagediscount = value; }
            get { return _packagediscount; }
        }
        /// <summary>
        /// 充值折扣
        /// </summary>
        public decimal PayDiscount
        {
            set { _paydiscount = value; }
            get { return _paydiscount; }
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

    }
}
