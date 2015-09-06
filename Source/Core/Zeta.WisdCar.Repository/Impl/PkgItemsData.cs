using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zeta.WisdCar.Repository.CRUD;

namespace Zeta.WisdCar.Repository.Impl
{
    public class PkgItemsData : IPkgItemsData
    {
        private PackageItemMapping _daoPkgItem = new PackageItemMapping();
        public System.Data.DataSet GetItemsByPkgID(int pkgID)
        {
            //待实现
            return _daoPkgItem.GetList("");
        }

        public void DelPkgItem(int id)
        {
            throw new NotImplementedException();
        }

        public void AddPkgItem(Model.PO.PackageItemMappingPO pkgItem)
        {
            throw new NotImplementedException();
        }

        public void AddPkgItems(List<Model.PO.PackageItemMappingPO> list)
        {
            throw new NotImplementedException();
        }

        public void EditPkgItem(Model.PO.PackageItemMappingPO pkgItem)
        {
            throw new NotImplementedException();
        }
    }
}
