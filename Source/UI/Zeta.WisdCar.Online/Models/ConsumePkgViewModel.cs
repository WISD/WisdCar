using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Zeta.WisdCar.Online.Models
{
    public class ConsumePkgViewModel
    {
        public string PkgId { get; set; }
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public int ItemConNum { get; set; }
    }
}