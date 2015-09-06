using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zeta.WisdCar.Model.Entity;
using Zeta.WisdCar.Model.PO;

namespace Zeta.WisdCar.Repository
{
    public interface IClubCardData
    {
        /// <summary>
        /// 根据查询条件获取会员卡信息
        /// 服务端分页
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        DataSet GetClubCards(ClubCardQueryEntity entity);

        /// <summary>
        /// 获取指定会员卡信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        ClubCardPO GetClubCardByID(int id);

        /// <summary>
        /// 根据前端输入关键词（手机号码或会员卡号）查询会员卡信息
        /// 模糊查询
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        DataSet GetClubCards(string key);

        /// <summary>
        /// 获取指定会员卡的余额
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        //Decimal GetBalanceByClubCardID(int id);

        /// <summary>
        /// 开卡
        /// </summary>
        /// <param name="clubCard"></param>
        void AddClubCard(ClubCardPO clubCard);

        /// <summary>
        /// 获取所有会员卡可用套餐列表
        /// </summary>
        /// <returns></returns>
        DataSet GetAvailablePkgs(int clubCardID);

        /// <summary>
        /// 获取所有会员卡已完结套餐列表
        /// </summary>
        /// <returns></returns>
        DataSet GetUnavailablePkgs(int clubCardID);

        /// <summary>
        /// 根据会员卡套餐ID获取套餐消费项目列表
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        DataSet GetDetailByClubCardPkgID(int id);

        /// <summary>
        /// 根据ID会员卡套餐消费项目
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        ClubCardPackageDetailPO GetClubCardPkgDetailByID(int id);

        /// <summary>
        /// 根据会员卡套餐ID获取套餐信息和消费项目列表
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        ClubCardPackagePO GetClubCardPkgByID(int id);

        /// <summary>
        /// 修改会员卡信息
        /// </summary>
        /// <param name="clubCard"></param>
        void UpdateClubCard(ClubCardPO clubCard);
    }
}
