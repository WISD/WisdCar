using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zeta.WisdCar.Business.CustClubCardModule
{
    public class ClubCardMgm : IClubCardMgm
    {
        List<Model.VO.ClubCardVO> IClubCardMgm.GetClubCards(Model.Entity.ClubCardQueryEntity entity)
        {
            throw new NotImplementedException();
        }

        Model.VO.ClubCardVO IClubCardMgm.GetClubCardByID(int id)
        {
            throw new NotImplementedException();
        }
    }
}
