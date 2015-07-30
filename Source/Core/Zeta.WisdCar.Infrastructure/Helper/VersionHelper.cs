using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zeta.WisdCar.Infrastructure.Helper
{
    public class VersionHelper
    {
        /// <summary>
        /// 从版本列表中获取版本号最小的版本
        /// </summary>
        /// <param name="versionList"></param>
        /// <returns></returns>
        public static string GetMinVersion(List<string> versionList)
        {
            string result = "";

            List<Version> list = new List<Version>();
            foreach (var v in versionList)
            { 
                Version ver = new Version();
                if (Version.TryParse(v, out ver))
                {
                    list.Add(ver);
                }
            }
            if (list.Count > 0)
            {
                var min = list[0];
                foreach (var v in list)
                {
                    if (v < min)
                    {
                        min = v;
                    }
                }
                result = min.ToString();
            }

            return result;
        }


        /// <summary>
        /// 从版本列表中获取版本号最大的版本
        /// </summary>
        /// <param name="versionList"></param>
        /// <returns></returns>
        public static string GetMaxVersion(List<string> versionList)
        {
            string result = "";

            List<Version> list = new List<Version>();
            foreach (var v in versionList)
            {
                Version ver = new Version();
                if (Version.TryParse(v, out ver))
                {
                    list.Add(ver);
                }
            }
            if (list.Count > 0)
            {
                var max = list[0];
                foreach (var v in list)
                {
                    if (v > max)
                    {
                        max = v;
                    }
                }
                result = max.ToString();
            }

            return result;
        }


        /// <summary>
        /// 判断输入值是否是版本号
        /// </summary>
        /// <param name="version"></param>
        /// <returns></returns>
        public static bool IsVersion(string version)
        {
            bool result = false;

            Version ver = new Version();
            if (Version.TryParse(version, out ver))
            {
                result = true;
            }

            return result;
        }
    }
}
