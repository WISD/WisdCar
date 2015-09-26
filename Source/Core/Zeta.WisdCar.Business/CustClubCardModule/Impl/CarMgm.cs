using AutoMapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zeta.WisdCar.Model.PO;
using Zeta.WisdCar.Model.VO;
using Zeta.WisdCar.Repository.Impl;
using Zeta.WisdCar.Business.AutoMapper;

namespace Zeta.WisdCar.Business.CustClubCardModule.Impl
{
    public class CarMgm : ICarMgm
    {
        public List<CarVO> GetCarsByCustID(int custID)
        {
            CarData carData = new CarData();

            List<CarVO> carVOList = new List<CarVO>();

            DataSet ds = carData.GetCarsByCustID(custID);
            List<CarPO> carPOList = ds.GetEntity<List<CarPO>>();

            carPOList.ForEach(i =>
            {
                carVOList.Add(Mapper.Map<CarPO, CarVO>(i));
            });

            return carVOList;
        }

        public void AddCar(Model.VO.CarVO car)
        {
            CarData carData = new CarData();
            carData.AddCar(Mapper.Map<CarVO, CarPO>(car));
        }

        public void EditCar(Model.VO.CarVO car)
        {
            CarData carData = new CarData();
            carData.EditCar(Mapper.Map<CarVO, CarPO>(car));
        }

        public void DelCar(int id)
        {
            CarData carData = new CarData();
            carData.DelCar(id);
        }
    }
}
