using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Zeta.WisdCar.Online.Models
{
    public class ComsumeItemViewModel
    {
        public int Itemid { get; set; }
        public string ItemName { get; set; }
        public int ItemConNum { get; set; }
        public decimal ItemTotalPrice { get; set; }
    }
}