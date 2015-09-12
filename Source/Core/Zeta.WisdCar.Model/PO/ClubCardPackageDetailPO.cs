using System;
namespace Zeta.WisdCar.Model.PO
{
	/// <summary>
	/// ClubCardPackageDetail:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class ClubCardPackageDetailPO
	{
        public ClubCardPackageDetailPO()
		{}
		#region Model
		private int _packagedetailid;
		private int _itemid;
		private string _itemname;
		private decimal _unitprice;
		private int _originalcount;
		private int _remaincount;
        private string _clubcardpackageid;
		private int _logicalstatus=1;
		private string _creatorid;
		private DateTime _createddate;
		private string _lastmodifierid;
		private DateTime _lastmodifieddate;
		private string _reserved1;
		private string _reserved2;
		private string _reserved3;
		/// <summary>
		/// 套餐余量明细ID
		/// </summary>
		public int PackageDetailID
		{
			set{ _packagedetailid=value;}
			get{return _packagedetailid;}
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
		/// 项目名称
		/// </summary>
		public string ItemName
		{
			set{ _itemname=value;}
			get{return _itemname;}
		}
		/// <summary>
		/// 单价
		/// </summary>
		public decimal UnitPrice
		{
			set{ _unitprice=value;}
			get{return _unitprice;}
		}
		/// <summary>
		/// 原始次数
		/// </summary>
		public int OriginalCount
		{
			set{ _originalcount=value;}
			get{return _originalcount;}
		}
		/// <summary>
		/// 剩余次数
		/// </summary>
		public int RemainCount
		{
			set{ _remaincount=value;}
			get{return _remaincount;}
		}
		/// <summary>
		/// 会员卡套餐ID
		/// </summary>
		public string ClubCardPackageID
		{
			set{ _clubcardpackageid=value;}
			get{return _clubcardpackageid;}
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

