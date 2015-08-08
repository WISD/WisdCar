using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using System.Data;

namespace Zeta.WisdCar.Business.AutoMapper
{
    /// <summary>  
    /// 实体映射帮助类  
    /// </summary>  

    public static class AutoMapperHelper
    {
        #region 配置映射规则  
        /// <summary>  
        /// 确保映射配置只注册一次  
        /// </summary>  
        static AutoMapperHelper()  
        {  
        //    Configure();  
        }  
        /// <summary>  
        /// 注册 Mapper 转换规则约定  
        /// </summary>  
        //static void Configure()  
        //{
            //Mapper.CreateMap<IDataReader, ClubCardTypePO>();//只需要约定基础类型，不要要写成List<xxxxModel>这种形式  
            //Mapper.CreateMap<IDataReader, ConsumeItemPO>();
        //}  
 
        #endregion  
 
 
        #region 实体映射扩展方法  
        /// <summary>  
        /// 将 IDataReader 转为实体对象  
        /// </summary>  
        /// <typeparam name="T"></typeparam>  
        /// <param name="dr"></param>  
        /// <returns></returns>  
        public static T GetEntity<T>(this IDataReader dr)  
        {  
            return Mapper.Map<T>(dr);  
        }  
        /// <summary>  
        /// 将 DataSet 转为实体对象  
        /// </summary>  
        /// <typeparam name="T"></typeparam>  
        /// <param name="ds"></param>  
        /// <returns></returns>  
        public static T GetEntity<T>(this DataSet ds)  
        {  
            if (ds == null || ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0)  
                return default(T);  
            var dr = ds.Tables[0].CreateDataReader();  
            return Mapper.Map<T>(dr);  
        }  
        /// <summary>  
        /// 将 DataTable 转为实体对象  
        /// </summary>  
        /// <typeparam name="T"></typeparam>  
        /// <param name="dt"></param>  
        /// <returns></returns>  
        public static T GetEntity<T>(this DataTable dt)  
        {  
            if (dt == null || dt.Rows.Count == 0)  
                return default(T);  
            var dr = dt.CreateDataReader();  
            return Mapper.Map<T>(dr);  
        }  
 
        #endregion   

    }
}
