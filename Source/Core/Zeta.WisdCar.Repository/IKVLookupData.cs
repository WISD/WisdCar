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
        /// 获取所有KVLookup列表
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        DataSet GetKVByCategoryID(int id);

        /// <summary>
        /// 根据ID获取KVLookup
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        KVLookupPO GetKVByID(int id);

        /// <summary>
        /// 新增KVLookup
        /// </summary>
        /// <param name="KV"></param>
        void AddKV(KVLookupPO kv);

        /// <summary>
        /// 修改KVLookup
        /// </summary>
        /// <param name="kv"></param>
        void EditKV(KVLookupPO kv);

        /// <summary>
        /// 删除KVLookup
        /// </summary>
        /// <param name="id"></param>
        void DelKV(int id);
    }
}
