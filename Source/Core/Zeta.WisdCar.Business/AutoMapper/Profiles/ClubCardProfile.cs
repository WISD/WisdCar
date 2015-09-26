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
    public class ClubCardProfile : Profile
    {
        protected override void Configure()
        {
            //DB record to PO
            CreateMap<IDataReader, ClubCardPO>();
            CreateMap<IDataReader, ClubCardPackagePO>();
            CreateMap<IDataReader, ClubCardPackageDetailPO>();
            
            
            //PO to VO
            CreateMap<ClubCardPO, ClubCardVO>().IgnoreUnmappedProperties();
            CreateMap<ClubCardPackagePO, ClubCardPkgVO>().IgnoreUnmappedProperties();
            CreateMap<ClubCardPackageDetailPO, ClubCardPkgDetailVO>().IgnoreUnmappedProperties();

            //VO to PO
            CreateMap<ClubCardVO, ClubCardPO>();
            CreateMap<ClubCardPkgVO, ClubCardPackagePO>();
            CreateMap<ClubCardPkgDetailVO, ClubCardPackageDetailPO>();
        }
    }
}
