using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zeta.WisdCar.Model.VO;

namespace Zeta.WisdCar.Business.MarktingPlanModule
{
    public interface IClubCardTypeMgm
    {
        /// <summary>
        /// 获取所有的会员卡类型数据
        /// </summary>
        /// <returns></returns>
        List<ClubCardTypeVO> GetAllCardType();

        /// <summary>
        /// 新增会员卡类型
        /// </summary>
        /// <param name="cardType"></param>
        void AddCardType(ClubCardTypeVO cardType);

        /// <summary>
        /// 修改会员卡类型
        /// </summary>
        /// <param name="cardType"></param>
        void EditCardType(ClubCardTypeVO cardType);

        /// <summary>
        /// 删除会员卡类型
        /// </summary>
        /// <param name="id"></param>
        void DelCardType(int id);

    }
}
