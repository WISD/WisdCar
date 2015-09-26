using AutoMapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zeta.WisdCar.Model.Entity;
using Zeta.WisdCar.Model.PO;
using Zeta.WisdCar.Model.VO;

namespace Zeta.WisdCar.Business.AutoMapper.Profiles
{
    public class RechargeProfile:Profile
    {
        protected override void Configure()
        {
            //DB record to PO
            CreateMap<IDataReader, RechargeLogPO>();
            //PO to VO
            CreateMap<RechargeLogPO, RechargeVO>().IgnoreUnmappedProperties();
            CreateMap<RechargeLogPO, RechargeLogQueryEntity>().IgnoreUnmappedProperties();
            //VO to PO
            CreateMap<RechargeVO, RechargeLogPO>();
        }
    }
}
