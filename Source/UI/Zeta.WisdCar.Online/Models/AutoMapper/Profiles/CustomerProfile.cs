using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Zeta.WisdCar.Model.PO;
using Zeta.WisdCar.Model.VO;

namespace Zeta.WisdCar.Online.Models.AutoMapper.Profiles
{
    public class CustomerProfile:Profile
    {
        protected override void Configure()
        {
            CreateMap<CustomerPO, CustomerVO>();
        }
    }
}