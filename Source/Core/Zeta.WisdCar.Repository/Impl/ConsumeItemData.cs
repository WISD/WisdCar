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
        private ConsumeItem _daoConsumeItem = new ConsumeItem();
        public DataSet GetAllConsumeItem()
        {
             return _daoConsumeItem.GetList("");
        }

        public void AddConsumeItem(Model.PO.ConsumeItemPO consumeItemPO)
        {
            _daoConsumeItem.Add(consumeItemPO);
        }

        public void EditConsumeItem(Model.PO.ConsumeItemPO consumeItemPO)
        {
            _daoConsumeItem.Update(consumeItemPO);
        }

        public void DelConsumeItem(int id)
        {
            _daoConsumeItem.Delete(id);
        }


        public ConsumeItemPO GetConsumeItemByID(int consumeItemID)
        {
            throw new NotImplementedException();
        }
    }
}
