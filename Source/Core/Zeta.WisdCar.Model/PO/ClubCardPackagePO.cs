using System;
namespace Zeta.WisdCar.Model.PO
{
	/// <summary>
	/// ClubCardPackage:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class ClubCardPackagePO
	{
        public ClubCardPackagePO()
		{}
		#region Model
		private int _clubcardpackageid;
		private string _packagename;
		private decimal _originalamount;
		private decimal _actualamount;
		private decimal _discountrate;
		private string _discountinfo;
		private int _packagestatus;
		private string _salesman;
		private DateTime _salestime;
		private string _salestore;
		private int _packageid;
		private int _logicalstatus=1;
		private string _creatorid;
		private DateTime _createddate;
		private string _lastmodifierid;
		private DateTime _lastmodifieddate;
		private string _reserved1;
		private string _reserved2;
		private string _reserved3;
		/// <summary>
		/// 会员卡套餐ID
		/// </summary>
		public int ClubCardPackageID
		{
			set{ _clubcardpackageid=value;}
			get{return _clubcardpackageid;}
		}
		/// <summary>
		/// 套餐名称
		/// </summary>
		public string PackageName
		{
			set{ _packagename=value;}
			get{return _packagename;}
		}
		/// <summary>
		/// 应收金额
		/// </summary>
		public decimal OriginalAmount
		{
			set{ _originalamount=value;}
			get{return _originalamount;}
		}
		/// <summary>
		/// 实收金额
		/// </summary>
		public decimal ActualAmount
		{
			set{ _actualamount=value;}
			get{return _actualamount;}
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
		/// 套餐状态
		/// </summary>
		public int PackageStatus
		{
			set{ _packagestatus=value;}
			get{return _packagestatus;}
		}
		/// <summary>
		/// 销售人员
		/// </summary>
		public string Salesman
		{
			set{ _salesman=value;}
			get{return _salesman;}
		}
		/// <summary>
		/// 销售时间
		/// </summary>
		public DateTime SalesTime
		{
			set{ _salestime=value;}
			get{return _salestime;}
		}
		/// <summary>
		/// 销售门店
		/// </summary>
		public string SaleStore
		{
			set{ _salestore=value;}
			get{return _salestore;}
		}
		/// <summary>
		/// 消费套餐表ID
		/// </summary>
		public int PackageID
		{
			set{ _packageid=value;}
			get{return _packageid;}
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

