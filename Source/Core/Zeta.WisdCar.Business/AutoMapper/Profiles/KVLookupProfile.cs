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
    public class KVLookupProfile : Profile
    {
        protected override void Configure()
        {
            //DB record to PO
            CreateMap<IDataReader, KVLookupPO>();

            //PO to VO
            CreateMap<KVLookupPO, KVLookupVO>().IgnoreUnmappedProperties();

            //VO to PO
            CreateMap<KVLookupVO, KVLookupPO>();
        }
    }
}
