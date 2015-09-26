using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zeta.WisdCar.Model.VO;

namespace Zeta.WisdCar.Business.CustClubCardModule
{
    public interface ICarMgm
    {
        /// <summary>
        /// 根据客户ID获取该客户所有的汽车信息
        /// </summary>
        /// <param name="custID"></param>
        /// <returns></returns>
        List<CarVO> GetCarsByCustID(int custID);

        /// <summary>
        /// 新增汽车
        /// </summary>
        /// <param name="car"></param>
        void AddCar(CarVO car);

        /// <summary>
        /// 修改汽车
        /// </summary>
        /// <param name="car"></param>
        void EditCar(CarVO car);

        /// <summary>
        /// 删除汽车
        /// </summary>
        /// <param name="id"></param>
        void DelCar(int id);
    }
}
