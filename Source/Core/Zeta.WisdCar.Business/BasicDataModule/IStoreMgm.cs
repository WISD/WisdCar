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
        List<StoreVO> GetAllStores();
    }
}
