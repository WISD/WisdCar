using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Zeta.WisdCar.Online.Models
{
    public class CustomerAndCar
    {

        private string _rowid;

        public string Rowid
        {
            get { return _rowid; }
            set { _rowid = value; }
        }
        private string _operation;

        public string Operation
        {
            get { return _operation; }
            set { _operation = value; }
        }
        private int _carid;

        public int Carid
        {
            get { return _carid; }
            set { _carid = value; }
        }
        private string _carno;

        public string Carno
        {
            get { return _carno; }
            set { _carno = value; }
        }
        private string _brand;

        public string Brand
        {
            get { return _brand; }
            set { _brand = value; }
        }
        private string _carmodel;

        public string Carmodel
        {
            get { return _carmodel; }
            set { _carmodel = value; }
        }
        private string _capacity;

        public string Capacity
        {
            get { return _capacity; }
            set { _capacity = value; }
        }
        private string _color;

        public string Color
        {
            get { return _color; }
            set { _color = value; }
        }
        private string _frameno;

        public string Frameno
        {
            get { return _frameno; }
            set { _frameno = value; }
        }
        private string _engineno;

        public string Engineno
        {
            get { return _engineno; }
            set { _engineno = value; }
        }
        private string _maintainkm;

        public string Maintainkm
        {
            get { return _maintainkm; }
            set { _maintainkm = value; }
        }
        private DateTime _insuredate;

        public DateTime Insuredate
        {
            get { return _insuredate; }
            set { _insuredate = value; }
        }
        private DateTime _asdate;

        public DateTime Asdate
        {
            get { return _asdate; }
            set { _asdate = value; }
        }
        private int _customerid;

        public int Customerid
        {
            get { return _customerid; }
            set { _customerid = value; }
        }

        private string _cardflagdesc;

        public string Cardflagdesc
        {
            get { return _cardflagdesc; }
            set { _cardflagdesc = value; }
        }
        private string _clubcarddesc;

        public string Clubcarddesc
        {
            get { return _clubcarddesc; }
            set { _clubcarddesc = value; }
        }
        private string _cardesc;

        public string Cardesc
        {
            get { return _cardesc; }
            set { _cardesc = value; }
        }

        //private int _customerid;
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        private string _mobileno;

        public string MobileNo
        {
            get { return _mobileno; }
            set { _mobileno = value; }
        }
        private string _sex;

        public string Sex
        {
            get { return _sex; }
            set { _sex = value; }
        }
        private string _birthday;

        public string Birthday
        {
            get { return _birthday; }
            set { _birthday = value; }
        }
        private string _icno;

        public string ICNo
        {
            get { return _icno; }
            set { _icno = value; }
        }
        private string _weixin;

        public string Weixin
        {
            get { return _weixin; }
            set { _weixin = value; }
        }
        private string _company;

        public string Company
        {
            get { return _company; }
            set { _company = value; }
        }
        private int _cardflag;

        public int Cardflag
        {
            get { return _cardflag; }
            set { _cardflag = value; }
        }

        ///// <summary>
        ///// 汽车ID
        ///// </summary>
        //public int CarID
        //{
        //    set { _carid = value; }
        //    get { return _carid; }
        //}
        ///// <summary>
        ///// 车牌号
        ///// </summary>
        //public string CarNo
        //{
        //    set { _carno = value; }
        //    get { return _carno; }
        //}
        ///// <summary>
        ///// 品牌
        ///// </summary>
        //public string Brand
        //{
        //    set { _brand = value; }
        //    get { return _brand; }
        //}
        ///// <summary>
        ///// 车型
        ///// </summary>
        //public string CarModel
        //{
        //    set { _carmodel = value; }
        //    get { return _carmodel; }
        //}
        ///// <summary>
        ///// 汽车排量
        ///// </summary>
        //public string Capacity
        //{
        //    set { _capacity = value; }
        //    get { return _capacity; }
        //}
        ///// <summary>
        ///// 汽车颜色
        ///// </summary>
        //public string Color
        //{
        //    set { _color = value; }
        //    get { return _color; }
        //}
        ///// <summary>
        ///// 车架号
        ///// </summary>
        //public string FrameNo
        //{
        //    set { _frameno = value; }
        //    get { return _frameno; }
        //}
        ///// <summary>
        ///// 发动机号
        ///// </summary>
        //public string EngineNo
        //{
        //    set { _engineno = value; }
        //    get { return _engineno; }
        //}
        ///// <summary>
        ///// 最近保养公里数
        ///// </summary>
        //public string MaintainKM
        //{
        //    set { _maintainkm = value; }
        //    get { return _maintainkm; }
        //}
        ///// <summary>
        ///// 保险时间
        ///// </summary>
        //public DateTime InsureDate
        //{
        //    set { _insuredate = value; }
        //    get { return _insuredate; }
        //}
        ///// <summary>
        ///// 年检时间
        ///// </summary>
        //public DateTime ASDate
        //{
        //    set { _asdate = value; }
        //    get { return _asdate; }
        //}
        ///// <summary>
        ///// 客户ID
        ///// </summary>
        //public int CustomerID
        //{
        //    set { _customerid = value; }
        //    get { return _customerid; }
        //}
        ///// <summary>
        ///// 汽车状态
        ///// </summary>
        ////public int LogicalStatus
        ////{
        ////    set { _logicalstatus = value; }
        ////    get { return _logicalstatus; }
        ////}
        /////// <summary>
        /////// 创建人ID
        /////// </summary>
        ////public string CreatorID
        ////{
        ////    set { _creatorid = value; }
        ////    get { return _creatorid; }
        ////}
        /////// <summary>
        /////// 创建时间
        /////// </summary>
        ////public DateTime CreatedDate
        ////{
        ////    set { _createddate = value; }
        ////    get { return _createddate; }
        ////}
        /////// <summary>
        /////// 最近修改人ID
        /////// </summary>
        ////public string LastModifierID
        ////{
        ////    set { _lastmodifierid = value; }
        ////    get { return _lastmodifierid; }
        ////}
        /////// <summary>
        /////// 最近修改时间
        /////// </summary>
        ////public DateTime LastModifiedDate
        ////{
        ////    set { _lastmodifieddate = value; }
        ////    get { return _lastmodifieddate; }
        ////}
    
        //public string CardFlagDesc
        //{
        //    set { _cardflagdesc = value; }
        //    get { return _cardflagdesc; }
        //}
        ///// <summary>
        ///// 显示会员卡信息
        ///// </summary>
        //public string ClubCardDesc
        //{
        //    set { _clubcarddesc = value; }
        //    get { return _clubcarddesc; }
        //}
        //public string CarDesc
        //{
        //    set { _cardesc = value; }
        //    get { return _cardesc; }
        //}
        ///// <summary>
        ///// 客户ID
        ///// </summary>
        ////public int CustomerID
        ////{
        ////    set { _customerid = value; }
        ////    get { return _customerid; }
        ////}
        ///// <summary>
        ///// 客户姓名
        ///// </summary>
        //public string Name
        //{
        //    set { _name = value; }
        //    get { return _name; }
        //}
        ///// <summary>
        ///// 手机号码
        ///// </summary>
        //public string MobileNO
        //{
        //    set { _mobileno = value; }
        //    get { return _mobileno; }
        //}
        ///// <summary>
        ///// 性别
        ///// </summary>
        //public string Sex
        //{
        //    set { _sex = value; }
        //    get { return _sex; }
        //}
        ///// <summary>
        ///// 生日
        ///// </summary>
        //public string Birthday
        //{
        //    set { _birthday = value; }
        //    get { return _birthday; }
        //}
        ///// <summary>
        ///// 身份证号
        ///// </summary>
        //public string ICNo
        //{
        //    set { _icno = value; }
        //    get { return _icno; }
        //}
        ///// <summary>
        ///// 微信
        ///// </summary>
        //public string Weixin
        //{
        //    set { _weixin = value; }
        //    get { return _weixin; }
        //}
        ///// <summary>
        ///// 单位
        ///// </summary>
        //public string Company
        //{
        //    set { _company = value; }
        //    get { return _company; }
        //}
        ///// <summary>
        ///// 开卡标志
        ///// 0：未开卡
        ///// 1：已开卡
        ///// </summary>
        //public int CardFlag
        //{
        //    set { _cardflag = value; }
        //    get { return _cardflag; }
        //}
      
    }
}