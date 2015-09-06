using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zeta.WisdCar.Model.VO;

namespace Zeta.WisdCar.Business.MarktingPlanModule
{
    public interface IPkgItemsMgm
    {
        /// <summary>
        /// 根据套餐编号获取所有对应的消费项目
        /// </summary>
        /// <param name="pkgID"></param>
        /// <returns></returns>
        List<PkgItemVO> GetItemsByPkgID(int pkgID);

        /// <summary>
        /// 删除指定套餐消费项目
        /// </summary>
        /// <param name="id"></param>
        void DelPkgItem(int id);

        /// <summary>
        /// 新增套餐消费项目
        /// </summary>
        /// <param name="pkgItem"></param>
        void AddPkgItem(PkgItemVO pkgItem);

        /// <summary>
        /// 批量新增套餐消费项目
        /// </summary>
        /// <param name="?"></param>
        void AddPkgItems(List<PkgItemVO> list);

        /// <summary>
        /// 修改套餐消费项目
        /// </summary>
        /// <param name="pkgItem"></param>
        void EditPkgItem(PkgItemVO pkgItem);
    }
}
