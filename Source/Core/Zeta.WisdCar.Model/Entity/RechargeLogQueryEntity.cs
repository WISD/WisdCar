using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zeta.WisdCar.Model.Entity
{
    public class RechargeLogQueryEntity
    {
        public string MobileNo { get; set; }
        public string CustName { get; set; }
        public string Creator { get; set; }
        public string ClubCardNO { get; set; }
        public string StoreID { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }

    }
}
