using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zeta.WisdCar.Model.PO;

namespace Zeta.WisdCar.Repository
{
    interface IClubCardData
    {
        /// <summary>
        /// 获取所有的会员卡类型数据
        /// </summary>
        /// <returns></returns>
        DataSet GetAllCard();

        /// <summary>
        /// 根据会员卡类型ID获取会员卡类型数据
        /// </summary>
        /// <returns></returns>
        ClubCardPO GetCardByID(int cardid);

        /// <summary>
        /// 新增会员卡类型
        /// </summary>
        /// <param name="cardType"></param>
        void AddCard(ClubCardPO card);

        /// <summary>
        /// 修改会员卡类型
        /// </summary>
        /// <param name="cardType"></param>
        void EditCard(ClubCardPO card);

        /// <summary>
        /// 删除会员卡类型
        /// </summary>
        /// <param name="id"></param>
        void DelCard(int id);
    }
}
