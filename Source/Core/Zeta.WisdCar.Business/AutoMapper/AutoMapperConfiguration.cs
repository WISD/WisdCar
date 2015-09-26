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
                cfg.AddProfile<Profiles.CarProfile>();
                cfg.AddProfile<Profiles.ClubCardProfile>();
                cfg.AddProfile<Profiles.ClubCardTypeProfile>();
                cfg.AddProfile<Profiles.ConsumeItemProfile>();


                cfg.AddProfile<Profiles.ConsumeProfile>();
                cfg.AddProfile<Profiles.CustomerProfile>();
                cfg.AddProfile<Profiles.EmployeeProfile>();
                cfg.AddProfile<Profiles.KVCategoryProfile>();
                cfg.AddProfile<Profiles.KVLookupProfile>();
                cfg.AddProfile<Profiles.PackageProfile>();
                cfg.AddProfile<Profiles.PkgItemProfile>();
                cfg.AddProfile<Profiles.RechargeProfile>();
                cfg.AddProfile<Profiles.StoreProfile>();            });
            //Mapper.AssertConfigurationIsValid();
        }
    }
}