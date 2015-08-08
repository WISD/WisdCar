using AutoMapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using Zeta.WisdCar.Model.PO;
using Zeta.WisdCar.Model.VO;

namespace Zeta.WisdCar.Business.AutoMapper.Profiles
{
    public class ClubCardTypeProfile : Profile
    {
        protected override void Configure()
        {
            //for DB record to PO
            CreateMap<IDataReader, ClubCardTypePO>();

            //PO to VO
            CreateMap<ClubCardTypePO, ClubCardTypeVO>();

            //VO to PO
            CreateMap<ClubCardTypeVO, ClubCardTypePO>();
        }
    }
}