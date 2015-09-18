using System;
namespace Zeta.WisdCar.Model.PO
{
	/// <summary>
	/// Car:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class CarPO
	{
        public CarPO()
		{}
		#region Model
		private int _carid;
		private string _carno;
		private string _brand;
		private string _carmodel;
		private string _capacity;
		private string _color;
		private string _frameno;
		private string _engineno;
		private string _maintainkm;
        private DateTime? _insuredate;
        private DateTime? _asdate;
		private int _customerid;
		private int _logicalstatus=1;
		private string _creatorid;
		private DateTime _createddate;
		private string _lastmodifierid;
		private DateTime _lastmodifieddate;
		private string _reserved1;
		private string _reserved2;
		private string _reserved3;
		/// <summary>
		/// 汽车ID
		/// </summary>
		public int CarID
		{
			set{ _carid=value;}
			get{return _carid;}
		}
		/// <summary>
		/// 车牌号
		/// </summary>
		public string CarNo
		{
			set{ _carno=value;}
			get{return _carno;}
		}
		/// <summary>
		/// 品牌
		/// </summary>
		public string Brand
		{
			set{ _brand=value;}
			get{return _brand;}
		}
		/// <summary>
		/// 车型
		/// </summary>
		public string CarModel
		{
			set{ _carmodel=value;}
			get{return _carmodel;}
		}
		/// <summary>
		/// 汽车排量
		/// </summary>
		public string Capacity
		{
			set{ _capacity=value;}
			get{return _capacity;}
		}
		/// <summary>
		/// 汽车颜色
		/// </summary>
		public string Color
		{
			set{ _color=value;}
			get{return _color;}
		}
		/// <summary>
		/// 车架号
		/// </summary>
		public string FrameNo
		{
			set{ _frameno=value;}
			get{return _frameno;}
		}
		/// <summary>
		/// 发动机号
		/// </summary>
		public string EngineNo
		{
			set{ _engineno=value;}
			get{return _engineno;}
		}
		/// <summary>
		/// 最近保养公里数
		/// </summary>
		public string MaintainKM
		{
			set{ _maintainkm=value;}
			get{return _maintainkm;}
		}
		/// <summary>
		/// 保险时间
		/// </summary>
		public DateTime? InsureDate
		{
			set{ _insuredate=value;}
			get{return _insuredate;}
		}
		/// <summary>
		/// 年检时间
		/// </summary>
		public DateTime? ASDate
		{
			set{ _asdate=value;}
			get{return _asdate;}
		}
		/// <summary>
		/// 客户ID
		/// </summary>
		public int CustomerID
		{
			set{ _customerid=value;}
			get{return _customerid;}
		}
		/// <summary>
		/// 汽车状态
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

