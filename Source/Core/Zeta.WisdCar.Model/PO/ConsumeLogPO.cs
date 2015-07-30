using System;
namespace Zeta.WisdCar.Model.PO
{
	/// <summary>
	/// ConsumeLog:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class ConsumeLogPO
	{
        public ConsumeLogPO()
		{}
		#region Model
		private int _consumelogid;
		private int _clubcardid;
		private int _clubcardno;
		private int _custid;
		private string _custname;
		private DateTime _consumedate;
		private string _consumestore;
		private string _originalstore;
		private int _consumetype;
		private int _clubcardpackageid;
		private int _packagedetailid;
		private string _itemname;
		private int _consumecount;
		private decimal _originalprice;
		private int _itemid;
		private int _logicalstatus=1;
		private string _creatorid;
		private DateTime _createddate;
		private string _lastmodifierid;
		private DateTime _lastmodifieddate;
		private string _reserved1;
		private string _reserved2;
		private string _reserved3;
		/// <summary>
		/// 消费项目ID
		/// </summary>
		public int ConsumeLogID
		{
			set{ _consumelogid=value;}
			get{return _consumelogid;}
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
		/// 消费日期
		/// </summary>
		public DateTime ConsumeDate
		{
			set{ _consumedate=value;}
			get{return _consumedate;}
		}
		/// <summary>
		/// 消费门店
		/// </summary>
		public string ConsumeStore
		{
			set{ _consumestore=value;}
			get{return _consumestore;}
		}
		/// <summary>
		/// 开卡门店
		/// </summary>
		public string OriginalStore
		{
			set{ _originalstore=value;}
			get{return _originalstore;}
		}
		/// <summary>
		/// 消费类型
		/// </summary>
		public int ConsumeType
		{
			set{ _consumetype=value;}
			get{return _consumetype;}
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
		/// 套餐余量明细ID
		/// </summary>
		public int PackageDetailID
		{
			set{ _packagedetailid=value;}
			get{return _packagedetailid;}
		}
		/// <summary>
		/// 消费项目
		/// </summary>
		public string ItemName
		{
			set{ _itemname=value;}
			get{return _itemname;}
		}
		/// <summary>
		/// 消费次数
		/// </summary>
		public int ConsumeCount
		{
			set{ _consumecount=value;}
			get{return _consumecount;}
		}
		/// <summary>
		/// 消费单价
		/// </summary>
		public decimal OriginalPrice
		{
			set{ _originalprice=value;}
			get{return _originalprice;}
		}
		/// <summary>
		/// 消费项目ID
		/// </summary>
		public int ItemID
		{
			set{ _itemid=value;}
			get{return _itemid;}
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

