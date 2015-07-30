using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace Zeta.WisdCar.Infrastructure.Helper
{
    public class XmlHelper
    {
        /// <summary>
        /// GetAttributeStringValue
        /// </summary>
        /// <param name="elem"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        public static string GetAttributeStringValue(XElement elem, string name)
        {
            XAttribute attr;

            if (elem == null)
            {
                throw new ArgumentNullException("elem");
            }
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException("name");
            }
            attr = elem.Attributes(name).FirstOrDefault();
            return (attr != null ? attr.Value : string.Empty);
        }


        /// <summary>
        /// GetAttributeIntValue
        /// </summary>
        /// <param name="elem"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        public static int GetAttributeIntValue(XElement elem, string name)
        {
            XAttribute attr;
            int result;

            if (elem == null)
            {
                throw new ArgumentNullException("elem");
            }
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException("name");
            }
            attr = elem.Attributes(name).FirstOrDefault();
            if (attr == null || !int.TryParse(attr.Value, out result))
            {
                result = 0;
            }
            return result;
        }


        /// <summary>
        /// GetAttributeDateTimeValue
        /// </summary>
        /// <param name="elem"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        public static DateTime GetAttributeDateTimeValue(XElement elem, string name)
        {
            XAttribute attr;
            DateTime result;

            if (elem == null)
            {
                throw new ArgumentNullException("elem");
            }
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException("name");
            }
            attr = elem.Attributes(name).FirstOrDefault();
            if (attr == null || !DateTime.TryParse(attr.Value, out result))
            {
                result = DateTime.Parse("1970/1/1");
            }
            return result;
        }
    }
}
