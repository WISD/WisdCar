using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zeta.WisdCar.Model.VO
{
    public class CustomerVO
    {
        public CustomerVO()
        { }

        private string _rowid;
        private string _operation;
        private string _cardflagdesc;
        private string _clubcarddesc;
        private string _cardesc;

        private int _customerid;
        private string _name;
        private string _mobileno;
        private string _sex;
        private string _birthday;
        private string _icno;
        private string _weixin;
        private string _company;
        private int _cardflag;
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
        /// 显示是否开卡
        /// </summary>
        public string CardFlagDesc
        {
            set { _cardflagdesc = value; }
            get { return _cardflagdesc; }
        }
        /// <summary>
        /// 显示会员卡信息
        /// </summary>
        public string ClubCardDesc
        {
            set { _clubcarddesc = value; }
            get { return _clubcarddesc; }
        }
        public string CarDesc
        {
            set { _cardesc = value; }
            get { return _cardesc; }
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
        /// 客户姓名
        /// </summary>
        public string Name
        {
            set { _name = value; }
            get { return _name; }
        }
        /// <summary>
        /// 手机号码
        /// </summary>
        public string MobileNO
        {
            set { _mobileno = value; }
            get { return _mobileno; }
        }
        /// <summary>
        /// 性别
        /// </summary>
        public string Sex
        {
            set { _sex = value; }
            get { return _sex; }
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
        /// 身份证号
        /// </summary>
        public string ICNo
        {
            set { _icno = value; }
            get { return _icno; }
        }
        /// <summary>
        /// 微信
        /// </summary>
        public string Weixin
        {
            set { _weixin = value; }
            get { return _weixin; }
        }
        /// <summary>
        /// 单位
        /// </summary>
        public string Company
        {
            set { _company = value; }
            get { return _company; }
        }
        /// <summary>
        /// 开卡标志
        /// 0：未开卡
        /// 1：已开卡
        /// </summary>
        public int CardFlag
        {
            set { _cardflag = value; }
            get { return _cardflag; }
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
