using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Zeta.WisdCar.Online.Models
{
    public class ReturnedData
    {
        //是否成功
        public bool Success { get; set; }

        //消息
        public string Message { get; set; }

        //错误信息
        public string Error { get; set; }

        //返回值
        public object Data { get; set; }
    }
}