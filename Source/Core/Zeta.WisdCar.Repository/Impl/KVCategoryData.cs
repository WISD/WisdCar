using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zeta.WisdCar.Repository.CRUD;

namespace Zeta.WisdCar.Repository.Impl
{
    public class KVCategoryData : IKVCategoryData
    {
        private KVCategory _daoKVCategory = new KVCategory();

        public System.Data.DataSet GetAllCategorys()
        {
            return _daoKVCategory.GetList("");
        }

        public Model.PO.KVCategoryPO GetCategoryByID(int categoryID)
        {
            return _daoKVCategory.GetModel(categoryID);
        }

        public void AddCategory(Model.PO.KVCategoryPO category)
        {
            _daoKVCategory.Add(category);
        }

        public void EditCategory(Model.PO.KVCategoryPO category)
        {
            _daoKVCategory.Update(category);
        }

        public void DelCategory(int id)
        {
            _daoKVCategory.Delete(id);
        }
    }
}
