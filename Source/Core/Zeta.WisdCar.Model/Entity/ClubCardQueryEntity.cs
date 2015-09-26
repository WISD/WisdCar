using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zeta.WisdCar.Model.Entity
{
    public class ClubCardQueryEntity
    {
        public ClubCardQueryEntity()
        { }

        public int Start { get; set; }
        public int Length { get; set; }
        /// <summary>
        /// 排序列
        /// </summary>
        public string SortName { get; set; }
        /// <summary>
        /// 排序方式
        /// </summary>
        public string SortOrder { get; set; }
        /// <summary>
        /// 会员卡号
        /// </summary>
        public string ClubCardNo { get; set; }
        /// <summary>
        /// 会员卡类型id
        /// </summary>
        public int ClubCardTypeID { get; set; }
        /// <summary>
        /// 客户姓名
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 客户手机号码
        /// </summary>
        public string MobileNo { get; set; }
        /// <summary>
        /// 会员卡类型名称
        /// </summary>
        public string ClubCardTypeName { get; set; }
        /// <summary>
        /// 商户名
        /// </summary>
        public string StoreName { get; set; }
        /// <summary>
        /// 会员卡状态
        /// </summary>
        public int CardStatus { get; set; }
    }
}
