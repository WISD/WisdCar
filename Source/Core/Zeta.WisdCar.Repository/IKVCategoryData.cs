using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zeta.WisdCar.Model.PO;

namespace Zeta.WisdCar.Repository
{
    public interface IKVCategoryData
    {
        /// <summary>
        /// 获取所有类别列表
        /// </summary>
        /// <returns></returns>
        DataSet GetAllCategorys();

        /// <summary>
        /// 根据ID获取类别
        /// </summary>
        /// <param name="categoryID"></param>
        /// <returns></returns>
        KVCategoryPO GetCategoryByID(int categoryID);

        /// <summary>
        /// 新增类别
        /// </summary>
        /// <param name="category"></param>
        void AddCategory(KVCategoryPO category);

        /// <summary>
        /// 修改类别
        /// </summary>
        /// <param name="category"></param>
        void EditCategory(KVCategoryPO category);

        /// <summary>
        /// 删除类别
        /// </summary>
        /// <param name="id"></param>
        void DelCategory(int id);
    }
}
