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
    public class ConsumeItemProfile : Profile
    {
        protected override void Configure()
        {
            //for DB record to PO
            CreateMap<DataSet, ConsumeItemPO>();
            //PO to VO
            CreateMap<ConsumeItemPO, ConsumeItemVO>();

            //VO to PO
            CreateMap<ConsumeItemVO, ConsumeItemPO>();

        }
    }
}