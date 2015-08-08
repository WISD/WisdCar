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
        /// 根据消费项目ID获取消费项目
        /// </summary>
        /// <returns></returns>
        ConsumeItemVO GetConsumeItemByID(int consumeItemID);

        /// <summary>
        /// 新增消费项目
        /// </summary>
        /// <param name="item"></param>
        void AddConsumeItem(ConsumeItemVO consumeItem);

        /// <summary>
        /// 修改消费项目
        /// </summary>
        /// <param name="item"></param>
        void EditConsumeItem(ConsumeItemVO consumeItem);

        /// <summary>
        /// 删除消费项目
        /// </summary>
        /// <param name="id"></param>
        void DelConsumeItem(int id);
    }
}
