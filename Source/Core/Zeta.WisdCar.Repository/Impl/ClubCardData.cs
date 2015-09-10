using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zeta.WisdCar.Repository.CRUD;

namespace Zeta.WisdCar.Repository.Impl
{
    public class ClubCardData:IClubCardData
    {
        private ClubCard _daoCard = new ClubCard();
        public System.Data.DataSet GetAllCard()
        {
            return _daoCard.GetList("");
        }

        public Model.PO.ClubCardPO GetCardByID(int cardid)
        {
            return _daoCard.GetModel(cardid);
        }

        public void AddCard(Model.PO.ClubCardPO card)
        {
            _daoCard.Add(card);
        }

        public void EditCard(Model.PO.ClubCardPO card)
        {
            _daoCard.Update(card);
        }

        public void DelCard(int id)
        {
            _daoCard.Delete(id);
            
        }
    }
}
