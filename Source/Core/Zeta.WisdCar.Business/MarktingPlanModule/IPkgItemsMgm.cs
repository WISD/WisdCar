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
        List<PkgItemsVO> GetItemsByPkgID(int pkgID);
    }
}
