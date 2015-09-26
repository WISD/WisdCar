using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zeta.WisdCar.Model.PO;

namespace Zeta.WisdCar.Repository
{
    public interface IKVLookupData
    {
        /// <summary>
        /// ��ȡ����KVLookup�б�
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        DataSet GetKVByCategoryID(int id);

        /// <summary>
        /// ����ID��ȡKVLookup
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        KVLookupPO GetKVByID(int id);

        /// <summary>
        /// ����KVLookup
        /// </summary>
        /// <param name="KV"></param>
        void AddKV(KVLookupPO kv);

        /// <summary>
        /// �޸�KVLookup
        /// </summary>
        /// <param name="kv"></param>
        void EditKV(KVLookupPO kv);

        /// <summary>
        /// ɾ��KVLookup
        /// </summary>
        /// <param name="id"></param>
        void DelKV(int id);
    }
}
