using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zeta.WisdCar.Model.VO
{
    public class ConsumeQueryVO
    {
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
        private string _clubcardpackagename;
        private int _packagedetailid;
        private int _itemid;
        private string _itemname;
        private int _consumecount;
        private decimal _originalprice;
        private string _originalpricedesc;


        /// <summary>
        /// 消费项目ID
        /// </summary>
        public int ConsumeLogID
        {
            set { _consumelogid = value; }
            get { return _consumelogid; }
        }
        /// <summary>
        /// 会员卡ID
        /// </summary>
        public int ClubCardID
        {
            set { _clubcardid = value; }
            get { return _clubcardid; }
        }
        /// <summary>
        /// 会员卡编号
        /// </summary>
        public int ClubCardNo
        {
            set { _clubcardno = value; }
            get { return _clubcardno; }
        }
        /// <summary>
        /// 客户ID
        /// </summary>
        public int CustID
        {
            set { _custid = value; }
            get { return _custid; }
        }
        /// <summary>
        /// 客户名称
        /// </summary>
        public string CustName
        {
            set { _custname = value; }
            get { return _custname; }
        }
        /// <summary>
        /// 消费日期
        /// </summary>
        public DateTime ConsumeDate
        {
            set { _consumedate = value; }
            get { return _consumedate; }
        }
        /// <summary>
        /// 消费门店
        /// </summary>
        public string ConsumeStore
        {
            set { _consumestore = value; }
            get { return _consumestore; }
        }
        /// <summary>
        /// 开卡门店
        /// </summary>
        public string OriginalStore
        {
            set { _originalstore = value; }
            get { return _originalstore; }
        }
        /// <summary>
        /// 消费类型
        /// </summary>
        public int ConsumeType
        {
            set { _consumetype = value; }
            get { return _consumetype; }
        }
        /// <summary>
        /// 会员卡套餐ID
        /// </summary>
        public int ClubCardPackageID
        {
            set { _clubcardpackageid = value; }
            get { return _clubcardpackageid; }
        }

        /// <summary>
        /// 会员卡套餐Name
        /// </summary>
        public string ClubCardPackageName
        {
            set { _clubcardpackagename = value; }
            get { return _clubcardpackagename; }
        }
        
        /// <summary>
        /// 套餐余量明细ID
        /// </summary>
        public int PackageDetailID
        {
            set { _packagedetailid = value; }
            get { return _packagedetailid; }
        }
        /// <summary>
        /// 消费项目
        /// </summary>
        public string ItemName
        {
            set { _itemname = value; }
            get { return _itemname; }
        }
        /// <summary>
        /// 消费次数
        /// </summary>
        public int ConsumeCount
        {
            set { _consumecount = value; }
            get { return _consumecount; }
        }
        /// <summary>
        /// 消费单价
        /// </summary>
        public decimal OriginalPrice
        {
            set { _originalprice = value; }
            get { return _originalprice; }
        }

        /// <summary>
        /// 消费单价Desc
        /// </summary>
        public string OriginalPriceDesc
        {
            set { _originalpricedesc = value; }
            get { return _originalpricedesc; }
        }

        /// <summary>
        /// 消费项目ID
        /// </summary>
        public int ItemID
        {
            set { _itemid = value; }
            get { return _itemid; }
        }
        #endregion Model

    }
}
