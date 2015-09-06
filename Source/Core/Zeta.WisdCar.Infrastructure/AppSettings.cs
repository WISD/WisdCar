using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Zeta.WisdCar.Infrastructure.Helper;

namespace Zeta.WisdCar.Infrastructure
{
    public class AppSettings
    {
        // Metrics url地址
        public static readonly string DashboardUrl = GetDashboardUrl();


        public static readonly string CorpUniqueNo = GetCorpUniqueNo();

        #region Private Method
        /// <summary>
        /// 获取 Metrics url
        /// </summary>
        /// <returns></returns>
        private static string GetDashboardUrl()
        {
            string result = "http://localhost:1234/";

            try
            {
                result = AppSettingsHelper.GetValueFromAppSetting("DashboardUrl", result);
            }
            catch
            { }

            return result;
        }


        /// <summary>
        /// 获取 公司唯一标识
        /// </summary>
        /// <returns></returns>
        private static string GetCorpUniqueNo()
        {
            string result = "88";

            try
            {
                result = AppSettingsHelper.GetValueFromAppSetting("CorpUniqueNo", result);
            }
            catch
            { }

            return result;
        }
        #endregion

    }
}
