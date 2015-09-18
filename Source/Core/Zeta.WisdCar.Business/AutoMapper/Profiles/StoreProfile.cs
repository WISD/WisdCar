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
    public class StoreProfile:Profile
    {
        protected override void Configure()
        {
            //DB record to PO
            CreateMap<IDataReader, StorePO>();
            //PO to VO
            CreateMap<StorePO, StoreVO>().IgnoreUnmappedProperties();
            //VO to PO
            CreateMap<StoreVO, StorePO>();
        }

       
    }
}
