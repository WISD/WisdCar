using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zeta.WisdCar.Model.PO;

namespace Zeta.WisdCar.Repository
{
    public interface IPackageData
    {
        /// <summary>
        /// 获取所有套餐
        /// </summary>
        /// <returns></returns>
        DataSet GetAllPackages();

        /// <summary>
        /// 根据ID获取指定套餐
        /// </summary>
        /// <returns></returns>
        PackagePO GetPackageByID(int id);

        /// <summary>
        /// 新增套餐
        /// </summary>
        /// <param name="package"></param>
        int AddPackage(PackagePO package);

        /// <summary>
        /// 根据条件查询套餐记录数
        /// </summary>
        /// <param name="strWhere"></param>
        /// <returns>int</returns>
        int GetRecordCount(string strWhere);

        /// <summary>
        /// 修改套餐
        /// </summary>
        /// <param name="package"></param>
        void EditPackage(PackagePO package);

        /// <summary>
        /// 删除套餐
        /// </summary>
        /// <param name="id"></param>
        void DelPackage(int id);
    }
}
