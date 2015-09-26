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
    public class PkgItemProfile : Profile
    {
        protected override void Configure()
        {
            //DB record to PO
            CreateMap<IDataReader, PackageItemMappingPO>();

            //PO to VO
            CreateMap<PackageItemMappingPO, PkgItemVO>().IgnoreUnmappedProperties();

            //VO to PO
            CreateMap<PkgItemVO, PackageItemMappingPO>();
        }
    }
}
