using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zeta.WisdCar.Model.VO;

namespace Zeta.WisdCar.Business.MarktingPlanModule
{
    public interface IConsumeItemMgm
    {
        /// <summary>
        /// 获取所有消费项目
        /// </summary>
        /// <returns></returns>
        List<ConsumeItemVO> GetAllConsumeItem();

        /// <summary>
        /// 新增消费项目
        /// </summary>
        /// <param name="item"></param>
        void AddConsumeItem(ConsumeItemVO item);

        /// <summary>
        /// 修改消费项目
        /// </summary>
        /// <param name="item"></param>
        void EditConsumeItem(ConsumeItemVO item);

        /// <summary>
        /// 删除消费项目
        /// </summary>
        /// <param name="id"></param>
        void DelConsumeItem(int id);
    }
}
