using AutoMapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zeta.WisdCar.Model.PO;
using Zeta.WisdCar.Model.VO;

namespace Zeta.WisdCar.Business.AutoMapper.Profiles
{
    class ClubCardProfile:Profile
    {
     
        protected override void Configure()
        {
            //DB record to PO
            CreateMap<IDataReader, ClubCardPO>();

            //PO to VO
            CreateMap<ClubCardPO, ClubCardVO>();

            //VO to PO
            CreateMap<ClubCardVO, ClubCardPO>();
        }
    }
}
