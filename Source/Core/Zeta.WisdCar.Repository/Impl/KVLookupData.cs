using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zeta.WisdCar.Repository.CRUD;

namespace Zeta.WisdCar.Repository.Impl
{
    public class KVLookupData : IKVLookupData
    {
        private KVLookup _daoKVLookup = new KVLookup();

        public System.Data.DataSet GetKVByCategoryID(int id)
        {
            StringBuilder strSql = new StringBuilder();
            string strWhere = "";

            strSql.AppendFormat(" CategoryID = {0} ", id);

            strWhere = strSql.ToString();
            return _daoKVLookup.GetList(strWhere);
        }

        public Model.PO.KVLookupPO GetKVByID(int id)
        {
            return _daoKVLookup.GetModel(id);
        }

        public void AddKV(Model.PO.KVLookupPO kv)
        {
            _daoKVLookup.Add(kv);
        }

        public void EditKV(Model.PO.KVLookupPO kv)
        {
            _daoKVLookup.Update(kv);
        }

        public void DelKV(int id)
        {
            _daoKVLookup.Delete(id);
        }
    }
}
