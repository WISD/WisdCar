using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Zeta.WisdCar.Online.Models
{
    public class CustomerAndCard
    {
        public int CustID { get; set; }
        public string CustName { get; set; }
        public string ICNo { get; set; }
        public string MobileNo { get; set; }
        public string Birthday { get; set; }
        public int CardID { get; set; }
        public string CardNo { get; set; }
        public int CardType { get; set; }
        public int CardStatu { get; set; }
        public string SaleMan { get; set; }
        public DateTime SaleTime { get; set; }
        public string OpenCardStore{get;set;}
        public DateTime ExpireDate { get; set; }
        public string CardTypeName { get; set; }
        public string CardStatuName { get; set; }
    }
}