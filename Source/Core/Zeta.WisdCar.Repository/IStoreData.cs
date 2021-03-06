﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zeta.WisdCar.Model.PO;

namespace Zeta.WisdCar.Repository
{
    interface IStoreData
    {
        /// <summary>
        /// 获取所有门店列表
        /// </summary>
        /// <returns></returns>
        DataSet GetAllStores();

        /// <summary>
        /// 根据门店ID获取门店
        /// </summary>
        /// <param name="storeID"></param>
        /// <returns></returns>
        StorePO GetStoreByID(int storeID);

        /// <summary>
        /// 新增门店
        /// </summary>
        /// <param name="store"></param>
        void AddStore(StorePO store);

        /// <summary>
        /// 修改门店
        /// </summary>
        /// <param name="store"></param>
        void EditStore(StorePO store);

        /// <summary>
        /// 删除门店
        /// </summary>
        /// <param name="id"></param>
        void DelStore(int id);
    }
}
