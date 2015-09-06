using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zeta.WisdCar.Model.VO;

namespace Zeta.WisdCar.Business.MarktingPlanModule
{
    public interface IPackageMgm
    {
        /// <summary>
        /// 获取所有套餐
        /// </summary>
        /// <returns></returns>
        List<PackageVO> GetAllPackages();

        /// <summary>
        /// 根据ID获取指定套餐
        /// </summary>
        /// <returns></returns>
        PackageVO GetPackageByID(int id);

        /// <summary>
        /// 新增套餐
        /// </summary>
        /// <param name="package"></param>
        void AddPackage(PackageVO package);

        /// <summary>
        /// 检查是否存在相同的套餐名称
        /// true: 存在相同的套餐名称
        /// false: 不存在相同的套餐名称
        /// </summary>
        /// <param name="packageName"></param>
        /// <returns></returns>
        bool IsPackageExist(string packageName);

        /// <summary>
        /// 修改套餐
        /// </summary>
        /// <param name="package"></param>
        void EditPackage(PackageVO package);

        /// <summary>
        /// 删除套餐
        /// </summary>
        /// <param name="id"></param>
        void DelPackage(int id);
    }
}
