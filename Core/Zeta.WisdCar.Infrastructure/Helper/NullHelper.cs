using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace Zeta.WisdCar.Infrastructure.Helper
{
    public class NullHelper
    {
        /// <summary>
        /// 判断是否是Null
        /// 如果是Null，返回True
        /// 反之，返回False
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static bool IsNull(object obj)
        {
            if (object.Equals(obj, null) || object.Equals(obj, DBNull.Value))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        /// <summary>
        /// 如果为Null，返回默认值
        /// </summary>
        /// <typeparam name="T">默认值类型，只支持基础数据类型</typeparam>
        /// <param name="obj"></param>
        /// <param name="t">默认值</param>
        /// <returns></returns>
        public static T Convert<T>(object obj, T t)
        {
            if (IsNull(obj))
            {
                return t;
            }
            else
            {
                return (T)System.Convert.ChangeType(obj.ToString().Trim(), typeof(T));
            }
        }

    }
}
