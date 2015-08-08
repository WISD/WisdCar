using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zeta.WisdCar.Model.PO;
using Zeta.WisdCar.Model.VO;
using Zeta.WisdCar.Repository.Impl;

namespace Zeta.WisdCar.Business.CustClubCardModule.Impl
{
    public class CarMgm : ICarMgm
    {
        public Model.VO.CarVO GetCarsByCustID(int custID)
        {
            CarData carData = new CarData();
            CarVO carVO = new CarVO();
            CarPO carPO = carData.GetCarsByCustID(custID);
            carVO = Mapper.Map<CarPO, CarVO>(carPO);

            return carVO;
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
