using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zeta.WisdCar.Repository.CRUD;

namespace Zeta.WisdCar.Repository.Impl
{
    public class PackageData : IPackageData
    {
        private Package _daoPackage = new Package();
        public System.Data.DataSet GetAllPackages()
        {
            return _daoPackage.GetList("");
        }

        public Model.PO.PackagePO GetPackageByID(int id)
        {
            return _daoPackage.GetModel(id);
        }

        public void AddPackage(Model.PO.PackagePO package)
        {
            _daoPackage.Add(package);
        }

        public int GetRecordCount(string strWhere)
        {
            return _daoPackage.GetRecordCount(strWhere);
        }

        public void EditPackage(Model.PO.PackagePO package)
        {
            _daoPackage.Update(package);
        }

        public void DelPackage(int id)
        {
            _daoPackage.Delete(id);
        }
    }
}
