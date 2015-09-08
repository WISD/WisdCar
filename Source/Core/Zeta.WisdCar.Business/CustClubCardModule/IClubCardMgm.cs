using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zeta.WisdCar.Model.Entity;
using Zeta.WisdCar.Model.VO;

namespace Zeta.WisdCar.Business.CustClubCardModule
{
    public interface IClubCardMgm
    {
        /// <summary>
        /// 根据查询条件获取会员卡信息
        /// 服务端分页
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        List<ClubCardVO> GetClubCards(ClubCardQueryEntity entity);

        /// <summary>
        /// 获取指定会员卡信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        ClubCardVO GetClubCardByID(int id);

        /// <summary>
        /// 根据前端输入关键词（手机号码或会员卡号）查询会员卡信息
        /// 模糊查询
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        List<ClubCardVO> GetClubCards(string key);

        /// <summary>
        /// 获取指定会员卡的余额
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Decimal GetBalanceByClubCardID(int id);

        /// <summary>
        /// 获取指定会员卡的卡状态
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        int GetCardStatusByClubCardID(int id);

        /// <summary>
        /// 开卡
        /// </summary>
        /// <param name="clubCard"></param>
        void AddClubCard(ClubCardVO clubCard);

        /// <summary>
        /// 获取所有会员卡可用套餐列表
        /// </summary>
        /// <returns></returns>
        List<ClubCardPkgVO> GetAvailablePkgs(int clubCardID);

        /// <summary>
        /// 获取所有会员卡已完结套餐列表
        /// </summary>
        /// <returns></returns>
        List<ClubCardPkgVO> GetUnavailablePkgs(int clubCardID);

        /// <summary>
        /// 根据会员卡套餐ID获取套餐消费项目列表
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        List<ClubCardPkgDetailVO> GetDetailByClubCardPkgID(int id);

        /// <summary>
        /// 根据ID会员卡套餐消费项目
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        ClubCardPkgDetailVO GetClubCardPkgDetailByID(int id);

        /// <summary>
        /// 根据会员卡套餐ID获取套餐信息和消费项目列表
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        ClubCardPkgVO GetClubCardPkgByID(int id);

        /// <summary>
        /// 验证用户密码是否正确
        /// 逻辑：pwd经过MD5加密后，与数据库保存的pwd比对
        /// 如果一致，验证通过
        /// 如果不一致，验证不通过
        /// </summary>
        /// <param name="clubCardID"></param>
        /// <param name="pwd"></param>
        /// <returns></returns>
        bool CheckPwd(int clubCardID, string pwd);

        /// <summary>
        /// 修改密码
        /// 逻辑：newPwd经过MD5加密后，更新对应字段
        /// </summary>
        /// <param name="clubCardID"></param>
        /// <param name="newPwd"></param>
        void UpdatePwd(int clubCardID, string newPwd);

        /// <summary>
        /// 修改会员卡状态
        /// OpenCard = 0,    //开卡
        /// ReportLoss = 1,    //挂失
        /// Froze = 2,    //冻结
        /// LogOff = 3,    //注销
        /// Expire = 4    //过期
        /// </summary>
        /// <param name="clubCardID"></param>
        /// <param name="status"></param>
        void UpdateClubCardStatus(int clubCardID, int status);

        /// <summary>
        /// 修改会员卡卡号，用于补办会员卡
        /// 存储老的会员卡号信息到会员卡历史纪录表
        /// </summary>
        /// <param name="clubCardID"></param>
        /// <param name="newClubCardNo"></param>
        void UpdateClubCardNo(int clubCardID, string newClubCardNo);


    }
}
