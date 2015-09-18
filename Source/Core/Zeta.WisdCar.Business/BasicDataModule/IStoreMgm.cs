using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zeta.WisdCar.Model.VO;

namespace Zeta.WisdCar.Business.BasicDataModule
{
    public interface IStoreMgm
    {
        /// <summary>
        /// 获取所有门店列表
        /// </summary>
        /// <returns></returns>
        List<StoreVO> GetAllStores();

        /// <summary>
        /// 根据门店ID获取门店
        /// </summary>
        /// <param name="storeID"></param>
        /// <returns></returns>
        StoreVO GetStoreByID(int storeID);
        StoreVO GetModel(int id);//临时方法后面优化
        /// <summary>
        /// 新增门店
        /// </summary>
        /// <param name="store"></param>
        void AddStore(StoreVO store);

        /// <summary>
        /// 修改门店
        /// </summary>
        /// <param name="store"></param>
        void EditStore(StoreVO store);

        /// <summary>
        /// 删除门店
        /// </summary>
        /// <param name="id"></param>
        void DelStore(int id);
    }
}
