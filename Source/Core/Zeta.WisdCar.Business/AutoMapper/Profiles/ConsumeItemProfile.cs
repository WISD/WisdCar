﻿using AutoMapper;
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
            //DB record to PO
            CreateMap<IDataReader, ConsumeItemPO>();
            //PO to VO
            CreateMap<ConsumeItemPO, ConsumeItemVO>().IgnoreUnmappedProperties();
            //VO to PO
            CreateMap<ConsumeItemVO, ConsumeItemPO>();

        }
    }
}