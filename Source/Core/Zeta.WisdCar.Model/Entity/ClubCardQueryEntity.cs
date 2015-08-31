using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zeta.WisdCar.Model.Entity
{
    public class ClubCardQueryEntity
    {
        public ClubCardQueryEntity()
        { }

        public int Start { get; set; }
        public int Length { get; set; }
        public string SortName { get; set; }
        public string SortOrder { get; set; }

        public string ClubCardNo { get; set; }
        public int ClubCardTypeID { get; set; }
        public string Name { get; set; }
        public string MobileNo { get; set; }
        public int ClubCardType { get; set; }
        public int StoreID { get; set; }
    }
}
