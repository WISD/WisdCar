using System;
namespace Zeta.WisdCar.Model.PO
{
	/// <summary>
	/// RechargeLog:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class RechargeLogPO
	{
        public RechargeLogPO()
		{}
		#region Model
		private int _rechargelogid;
		private string _rechargeserialno;
		private int _clubcardid;
		private int _clubcardno;
		private int _custid;
		private string _custname;
		private DateTime _rechargedate;
		private string _salesman;
		private string _rechargestore;
		private string _originalstore;
		private decimal _actualrechargeamount;
		private int _rechargetype;
		private int _paytype;
		private int _clubcardpackageid;
		private decimal _platformrechargeamount;
		private decimal _discountrate;
		private string _discountinfo;
		private int _logicalstatus=1;
		private string _creatorid;
		private DateTime _createddate;
		private string _lastmodifierid;
		private DateTime _lastmodifieddate;
		private string _reserved1;
		private string _reserved2;
		private string _reserved3;
		/// <summary>
		/// 充值记录ID
		/// </summary>
		public int RechargeLogID
		{
			set{ _rechargelogid=value;}
			get{return _rechargelogid;}
		}
		/// <summary>
		/// 充值流水号
		/// </summary>
		public string RechargeSerialNo
		{
			set{ _rechargeserialno=value;}
			get{return _rechargeserialno;}
		}
		/// <summary>
		/// 会员卡ID
		/// </summary>
		public int ClubCardID
		{
			set{ _clubcardid=value;}
			get{return _clubcardid;}
		}
		/// <summary>
		/// 会员卡编号
		/// </summary>
		public int ClubCardNo
		{
			set{ _clubcardno=value;}
			get{return _clubcardno;}
		}
		/// <summary>
		/// 客户ID
		/// </summary>
		public int CustID
		{
			set{ _custid=value;}
			get{return _custid;}
		}
		/// <summary>
		/// 客户名称
		/// </summary>
		public string CustName
		{
			set{ _custname=value;}
			get{return _custname;}
		}
		/// <summary>
		/// 充值日期
		/// </summary>
		public DateTime RechargeDate
		{
			set{ _rechargedate=value;}
			get{return _rechargedate;}
		}
		/// <summary>
		/// 销售人员
		/// </summary>
		public string SalesMan
		{
			set{ _salesman=value;}
			get{return _salesman;}
		}
		/// <summary>
		/// 充值门店
		/// </summary>
		public string RechargeStore
		{
			set{ _rechargestore=value;}
			get{return _rechargestore;}
		}
		/// <summary>
		/// 开户门店
		/// </summary>
		public string OriginalStore
		{
			set{ _originalstore=value;}
			get{return _originalstore;}
		}
		/// <summary>
		/// 实收充值金额
		/// </summary>
		public decimal ActualRechargeAmount
		{
			set{ _actualrechargeamount=value;}
			get{return _actualrechargeamount;}
		}
		/// <summary>
		/// 充值类型
		/// </summary>
		public int RechargeType
		{
			set{ _rechargetype=value;}
			get{return _rechargetype;}
		}
		/// <summary>
		/// 支付类型
		/// </summary>
		public int PayType
		{
			set{ _paytype=value;}
			get{return _paytype;}
		}
		/// <summary>
		/// 会员卡套餐ID
		/// </summary>
		public int ClubCardPackageID
		{
			set{ _clubcardpackageid=value;}
			get{return _clubcardpackageid;}
		}
		/// <summary>
		/// 平台入账金额
		/// </summary>
		public decimal PlatformRechargeAmount
		{
			set{ _platformrechargeamount=value;}
			get{return _platformrechargeamount;}
		}
		/// <summary>
		/// 折扣率
		/// </summary>
		public decimal DiscountRate
		{
			set{ _discountrate=value;}
			get{return _discountrate;}
		}
		/// <summary>
		/// 折扣信息
		/// </summary>
		public string DiscountInfo
		{
			set{ _discountinfo=value;}
			get{return _discountinfo;}
		}
		/// <summary>
		/// 逻辑状态
		/// </summary>
		public int LogicalStatus
		{
			set{ _logicalstatus=value;}
			get{return _logicalstatus;}
		}
		/// <summary>
		/// 创建人ID
		/// </summary>
		public string CreatorID
		{
			set{ _creatorid=value;}
			get{return _creatorid;}
		}
		/// <summary>
		/// 创建时间
		/// </summary>
		public DateTime CreatedDate
		{
			set{ _createddate=value;}
			get{return _createddate;}
		}
		/// <summary>
		/// 最近修改人ID
		/// </summary>
		public string LastModifierID
		{
			set{ _lastmodifierid=value;}
			get{return _lastmodifierid;}
		}
		/// <summary>
		/// 最近修改时间
		/// </summary>
		public DateTime LastModifiedDate
		{
			set{ _lastmodifieddate=value;}
			get{return _lastmodifieddate;}
		}
		/// <summary>
		/// 保留字段1
		/// </summary>
		public string Reserved1
		{
			set{ _reserved1=value;}
			get{return _reserved1;}
		}
		/// <summary>
		/// 保留字段2
		/// </summary>
		public string Reserved2
		{
			set{ _reserved2=value;}
			get{return _reserved2;}
		}
		/// <summary>
		/// 保留字段3
		/// </summary>
		public string Reserved3
		{
			set{ _reserved3=value;}
			get{return _reserved3;}
		}
		#endregion Model

	}
}

