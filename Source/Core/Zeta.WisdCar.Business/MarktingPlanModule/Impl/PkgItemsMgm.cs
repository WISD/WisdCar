using AutoMapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zeta.WisdCar.Model.PO;
using Zeta.WisdCar.Model.VO;
using Zeta.WisdCar.Repository.Impl;
using Zeta.WisdCar.Business.AutoMapper;

namespace Zeta.WisdCar.Business.MarktingPlanModule
{
    public class PkgItemsMgm : IPkgItemsMgm
    {
        public List<Model.VO.PkgItemVO> GetItemsByPkgID(int pkgID)
        {
            PkgItemsData pkgItemsData = new PkgItemsData();
            List<PkgItemVO> pkgItemVOList = new List<PkgItemVO>();

            DataSet ds = pkgItemsData.GetItemsByPkgID(pkgID);

            List<PackageItemMappingPO> pkgItemMappingPOList = ds.GetEntity<List<PackageItemMappingPO>>();
            if(pkgItemMappingPOList!=null)
            pkgItemMappingPOList.ForEach(i =>
            {
                pkgItemVOList.Add(Mapper.Map<PackageItemMappingPO, PkgItemVO>(i));
            });

            return pkgItemVOList;
        }

        public void DelPkgItem(int id)
        {
            PkgItemsData pkgItemsData = new PkgItemsData();
            pkgItemsData.DelPkgItem(id);
        }

        public void AddPkgItem(Model.VO.PkgItemVO pkgItem)
        {
            PkgItemsData pkgItemsData = new PkgItemsData();
            pkgItemsData.AddPkgItem(Mapper.Map<PkgItemVO, PackageItemMappingPO>(pkgItem));
        }

        public void AddPkgItems(List<Model.VO.PkgItemVO> list)
        {
            PkgItemsData pkgItemsData = new PkgItemsData();
            pkgItemsData.AddPkgItems(Mapper.Map<List<PkgItemVO>, List<PackageItemMappingPO>>(list));
        }

        public void EditPkgItem(Model.VO.PkgItemVO pkgItem)
        {
            PkgItemsData pkgItemsData = new PkgItemsData();
            pkgItemsData.EditPkgItem(Mapper.Map<PkgItemVO, PackageItemMappingPO>(pkgItem));
        }
    }
}
