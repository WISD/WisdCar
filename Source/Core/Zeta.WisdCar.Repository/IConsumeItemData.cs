using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zeta.WisdCar.Model.PO;

namespace Zeta.WisdCar.Repository
{
    public interface IConsumeItemData
    {
        /// <summary>
        /// 获取所有消费项目
        /// </summary>
        /// <returns></returns>
        List<ConsumeItemPO> GetAllConsumeItem();

        /// <summary>
        /// 新增消费项目
        /// </summary>
        /// <param name="item"></param>
        void AddConsumeItem(ConsumeItemPO item);

        /// <summary>
        /// 修改消费项目
        /// </summary>
        /// <param name="item"></param>
        void EditConsumeItem(ConsumeItemPO item);

        /// <summary>
        /// 删除消费项目
        /// </summary>
        /// <param name="id"></param>
        void DelConsumeItem(int id);
    }
}
