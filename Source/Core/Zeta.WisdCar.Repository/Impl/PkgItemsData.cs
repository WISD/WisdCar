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
            StringBuilder strSql = new StringBuilder();
            string strWhere = "";
            strSql.AppendFormat(" PackageID = %{0}% ", pkgID);

            strWhere = strSql.ToString();
            return _daoPkgItem.GetList(strWhere);
        }

        public void DelPkgItem(int id)
        {
            _daoPkgItem.Delete(id);
        }

        public void AddPkgItem(Model.PO.PackageItemMappingPO pkgItem)
        {
            _daoPkgItem.Add(pkgItem);
        }

        public void AddPkgItems(List<Model.PO.PackageItemMappingPO> list)
        {
            foreach (var item in list)
	        {
                AddPkgItem(item);
	        }
        }

        public void EditPkgItem(Model.PO.PackageItemMappingPO pkgItem)
        {
            _daoPkgItem.Update(pkgItem);
        }
    }
}
