using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zeta.WisdCar.Infrastructure
{
    public class Constants
    {
        //Datatables Request Params
        public const string SORT_IDX = "order[0][column]";
        public const string SORT_NAME = "columns[{0}][data]";
        public const string SORT_ORDER = "order[0][dir]";
        public const string PAGE_START = "start";
        public const string PAGE_LENGTH = "length";
        public const string REQ_DRAW = "draw";

    }
}
