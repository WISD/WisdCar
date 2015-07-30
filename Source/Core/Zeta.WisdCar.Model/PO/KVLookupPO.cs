using System;
namespace Zeta.WisdCar.Model.PO
{
	/// <summary>
	/// KVLookup:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class KVLookupPO
	{
        public KVLookupPO()
		{}
		#region Model
		private int _lookupid;
		private string _lookupkey;
		private string _lookupvalue;
		private string _categoryno;
		private int _logicalstatus=1;
		private string _creatorid;
		private DateTime _createddate;
		private string _lastmodifierid;
		private DateTime _lastmodifieddate;
		private string _reserved1;
		private string _reserved2;
		private string _reserved3;
		/// <summary>
		/// 基础数据明细表
		/// </summary>
		public int LookupID
		{
			set{ _lookupid=value;}
			get{return _lookupid;}
		}
		/// <summary>
		/// 基础数据Key
		/// </summary>
		public string LookupKey
		{
			set{ _lookupkey=value;}
			get{return _lookupkey;}
		}
		/// <summary>
		/// 基础数据Value
		/// </summary>
		public string LookupValue
		{
			set{ _lookupvalue=value;}
			get{return _lookupvalue;}
		}
		/// <summary>
		/// 数据种类编号
		/// </summary>
		public string CategoryNo
		{
			set{ _categoryno=value;}
			get{return _categoryno;}
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

