using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zeta.WisdCar.Model.Entity;
using Zeta.WisdCar.Model.VO;

namespace Zeta.WisdCar.Business.CustClubCardModule
{
    public interface IClubCardMgm
    {
        /// <summary>
        /// 根据查询条件获取会员卡信息
        /// 服务端分页
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        List<ClubCardVO> GetClubCards(ClubCardQueryEntity entity);

        /// <summary>
        /// 获取指定会员卡信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        ClubCardVO GetClubCardByID(int id);


    }
}
