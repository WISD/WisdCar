using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Zeta.WisdCar.Online.Models
{
    public class DatatablesResult<T>
    {
        public int draw { get; set; }
        public int recordsTotal { get; set; }
        public int recordsFiltered { get; set; }
        public List<T> data { get; set; }
        public string error { get; set; }
    }
}