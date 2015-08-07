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
    public class ClubCardTypeData  : IClubCardTypeData
    {
        private ClubCardType dao_CardType = new ClubCardType();
        public List<ClubCardTypePO> GetAllCardType()
        {
            DataSet ds = dao_CardType.GetList("");
            List<ClubCardTypePO> cardTypePOList = ds.GetEntity<List<ClubCardTypePO>>();
            //var cardTypeVOList = AutoMapper.Mapper.Map<List<ClubCardTypePO>, List<ClubCardTypeVO>>(cardTypePO);
            return cardTypePOList;
        }

        public void AddCardType(ClubCardTypePO cardTypePO)
        {
            dao_CardType.Add(cardTypePO);
        }

        public void EditCardType(ClubCardTypePO cardTypePO)
        {
            dao_CardType.Update(cardTypePO);
        }

        public void DelCardType(int id)
        {
            dao_CardType.Delete(id);
        }
    }
}
