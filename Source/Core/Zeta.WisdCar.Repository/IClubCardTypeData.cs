using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zeta.WisdCar.Model.PO;

namespace Zeta.WisdCar.Repository
{
    public interface IClubCardTypeData
    {
        /// <summary>
        /// 获取所有的会员卡类型数据
        /// </summary>
        /// <returns></returns>
        DataSet GetAllCardType();

        /// <summary>
        /// 根据会员卡类型ID获取会员卡类型数据
        /// </summary>
        /// <returns></returns>
        ClubCardTypePO GetCardTypeByID(int cardTypeID);

        /// <summary>
        /// 新增会员卡类型
        /// </summary>
        /// <param name="cardType"></param>
        void AddCardType(ClubCardTypePO cardType);

        /// <summary>
        /// 修改会员卡类型
        /// </summary>
        /// <param name="cardType"></param>
        bool EditCardType(ClubCardTypePO cardType);

        /// <summary>
        /// 删除会员卡类型
        /// </summary>
        /// <param name="id"></param>
        void DelCardType(int id);
    }
}
