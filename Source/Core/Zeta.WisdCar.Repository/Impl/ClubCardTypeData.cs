using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zeta.WisdCar.Model.PO;
using Zeta.WisdCar.Repository.CRUD;

namespace Zeta.WisdCar.Repository.Impl
{
    public class ClubCardTypeData  : IClubCardTypeData
    {
        private ClubCardType _daoCardType = new ClubCardType();
        public DataSet GetAllCardType()
        {
            return _daoCardType.GetList("");
        }

        public void AddCardType(ClubCardTypePO cardTypePO)
        {
            _daoCardType.Add(cardTypePO);
        }

        public void EditCardType(ClubCardTypePO cardTypePO)
        {
            _daoCardType.Update(cardTypePO);
        }

        public void DelCardType(int id)
        {
            _daoCardType.Delete(id);
        }


        public ClubCardTypePO GetCardTypeByID(int cardTypeID)
        {
            return _daoCardType.GetModel(cardTypeID);
        }
    }
}
