using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zeta.WisdCar.Model.Entity
{
    public class CustomerQueryEntity
    {
        public CustomerQueryEntity()
        { }

        private int _start;
        private int _length;
        private string _sortname;
        private string _sortorder;
        private string _name;
        private string _mobileno;
        private string _icno;
        private int _cardflag;

        /// <summary>
        /// Datatables 分页start
        /// </summary>
        public int Start
        {
            set { _start = value; }
            get { return _start; }
        }
        /// <summary>
        /// Datatables 分页length
        /// </summary>
        public int Length
        {
            set { _length = value; }
            get { return _length; }
        }
        /// <summary>
        /// Datatables 排序column name
        /// </summary>
        public string SortName
        {
            set { _sortname = value; }
            get { return _sortname; }
        }
        /// <summary>
        /// Datatables 排序asc desc
        /// </summary>
        public string SortOrder
        {
            set { _sortorder = value; }
            get { return _sortorder; }
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
        /// 身份证号
        /// </summary>
        public string ICNo
        {
            set { _icno = value; }
            get { return _icno; }
        }
        /// <summary>
        /// 开卡标志
        /// </summary>
        public int CardFlag
        {
            set { _cardflag = value; }
            get { return _cardflag; }
        }
    }
}
