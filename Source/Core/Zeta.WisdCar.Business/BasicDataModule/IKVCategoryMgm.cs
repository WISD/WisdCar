using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zeta.WisdCar.Model.VO;

namespace Zeta.WisdCar.Business.BasicDataModule
{
    public interface IKVCategoryMgm
    {
        /// <summary>
        /// 获取所有类别列表
        /// </summary>
        /// <returns></returns>
        List<KVCategoryVO> GetAllCategorys();

        /// <summary>
        /// 根据ID获取类别
        /// </summary>
        /// <param name="categoryID"></param>
        /// <returns></returns>
        KVCategoryVO GetCategoryByID(int categoryID);

        /// <summary>
        /// 新增类别
        /// </summary>
        /// <param name="category"></param>
        void AddCategory(KVCategoryVO category);

        /// <summary>
        /// 修改类别
        /// </summary>
        /// <param name="category"></param>
        void EditCategory(KVCategoryVO category);

        /// <summary>
        /// 删除类别
        /// </summary>
        /// <param name="id"></param>
        void DelCategory(int id);
    }
}
