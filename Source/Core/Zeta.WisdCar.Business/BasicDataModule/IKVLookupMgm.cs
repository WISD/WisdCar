using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zeta.WisdCar.Model.VO;

namespace Zeta.WisdCar.Business.BasicDataModule
{
    public interface IKVLookupMgm
    {
        /// <summary>
        /// 获取所有KVLookup列表
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        List<KVLookupVO> GetKVByCategoryID(int id);

        /// <summary>
        /// 根据ID获取KVLookup
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        KVLookupVO GetKVByID(int id);

        /// <summary>
        /// 新增KVLookup
        /// </summary>
        /// <param name="KV"></param>
        void AddKV(KVLookupVO kv);

        /// <summary>
        /// 修改KVLookup
        /// </summary>
        /// <param name="kv"></param>
        void EditKV(KVLookupVO kv);

        /// <summary>
        /// 删除KVLookup
        /// </summary>
        /// <param name="id"></param>
        void DelKV(int id);
    }
}
