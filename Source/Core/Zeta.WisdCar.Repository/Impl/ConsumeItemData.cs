using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zeta.WisdCar.Infrastructure.Helper;
using Zeta.WisdCar.Model.PO;
using Zeta.WisdCar.Repository.CRUD;

namespace Zeta.WisdCar.Repository.Impl
{
    public class ConsumeItemData : IConsumeItemData
    {
        private ConsumeItem dao_ConsumeItem = new ConsumeItem();
        public List<Model.PO.ConsumeItemPO> GetAllConsumeItem()
        {
            DataSet ds = dao_ConsumeItem.GetList("");
            List<ConsumeItemPO> consumeItemPOList = ds.GetEntity<List<ConsumeItemPO>>();
            return consumeItemPOList;
        }

        public void AddConsumeItem(Model.PO.ConsumeItemPO consumeItemPO)
        {
            dao_ConsumeItem.Add(consumeItemPO);
        }

        public void EditConsumeItem(Model.PO.ConsumeItemPO consumeItemPO)
        {
            dao_ConsumeItem.Update(consumeItemPO);
        }

        public void DelConsumeItem(int id)
        {
            dao_ConsumeItem.Delete(id);
        }
    }
}
