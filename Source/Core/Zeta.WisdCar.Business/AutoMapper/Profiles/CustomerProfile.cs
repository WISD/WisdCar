using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Zeta.WisdCar.Model.PO;
using Zeta.WisdCar.Model.VO;
using System.Data;

namespace Zeta.WisdCar.Business.AutoMapper.Profiles
{
    public class CustomerProfile:Profile
    {
        protected override void Configure()
        {
            //DB record to PO
            CreateMap<IDataReader, CustomerPO>();
            //PO to VO
            CreateMap<CustomerPO, CustomerVO>().IgnoreUnmappedProperties();
            //VO to PO
            CreateMap<CustomerVO, CustomerPO>();
        }
    }
}