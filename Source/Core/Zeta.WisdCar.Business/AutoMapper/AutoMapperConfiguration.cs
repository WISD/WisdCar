using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;

namespace Zeta.WisdCar.Business.AutoMapper
{
    public class AutoMapperConfiguration
    {
        public static void Configure()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.AddProfile<Profiles.CustomerProfile>();
                cfg.AddProfile<Profiles.ClubCardTypeProfile>();
                cfg.AddProfile<Profiles.ConsumeItemProfile>();
            });
            Mapper.AssertConfigurationIsValid();
        }
    }
}