using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zeta.WisdCar.Model.PO;

namespace Zeta.WisdCar.Repository
{
    public interface ICarData
    {
        /// <summary>
        /// 根据客户ID获取该客户所有的汽车信息
        /// </summary>
        /// <param name="custID"></param>
        /// <returns></returns>
        DataSet GetCarsByCustID(int custID);

        /// <summary>
        /// 新增汽车
        /// </summary>
        /// <param name="car"></param>
        void AddCar(CarPO car);

        /// <summary>
        /// 修改汽车
        /// </summary>
        /// <param name="car"></param>
        void EditCar(CarPO car);

        /// <summary>
        /// 删除汽车
        /// </summary>
        /// <param name="id"></param>
        void DelCar(int id);
    }
}
