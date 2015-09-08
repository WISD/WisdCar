using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zeta.WisdCar.Model.PO;

namespace Zeta.WisdCar.Repository
{
    public interface IClubCardPackageData
    {
        /// <summary>
        /// 根据会员卡ID获取套餐列表
        /// </summary>
        /// <param name="custID"></param>
        /// <returns></returns>
        DataSet GetPkgsByClubCardID(int clubCardID);

        /// <summary>
        /// 根据会员卡套餐ID获取该套餐信息
        /// </summary>
        /// <param name="custID"></param>
        /// <returns></returns>
        ClubCardPackagePO GetClubCardPkgByID(int clubCardPkgID);

        /// <summary>
        /// 根据会员卡套餐ID获取该套餐明细信息
        /// </summary>
        /// <param name="custID"></param>
        /// <returns></returns>
        DataSet GetClubCardPkgDetailsByID(int clubCardPkgID);

        /// <summary>
        /// 新增会员套餐
        /// </summary>
        /// <param name="car"></param>
        void AddClubCardPkg(ClubCardPackagePO clubCardpkg);

        /// <summary>
        /// 新增会员套餐明细
        /// </summary>
        /// <param name="car"></param>
        void AddClubCardPkgDetail(ClubCardPackageDetailPO clubCardpkgDetail);

        /// <summary>
        /// 新增会员套餐明细List
        /// </summary>
        /// <param name="car"></param>
        void AddClubCardPkgDetailList(List<ClubCardPackageDetailPO> clubCardpkgDetailList);

        /// <summary>
        /// 修改会员套餐
        /// </summary>
        /// <param name="car"></param>
        void EditClubCardPkg(ClubCardPackagePO clubCardpkg);

        /// <summary>
        /// 修改会员套餐明细
        /// </summary>
        /// <param name="car"></param>
        void EditClubCardPkgDetail(ClubCardPackageDetailPO clubCardpkgDetail);

        /// <summary>
        /// 修改会员套餐明细List
        /// </summary>
        /// <param name="car"></param>
        void EditClubCardPkgDetailList(List<ClubCardPackageDetailPO> clubCardpkgDetailList);

        /// <summary>
        /// 删除会员套餐
        /// </summary>
        /// <param name="id"></param>
        void DelClubCardPkg(int id);

        /// <summary>
        /// 根据会员卡套餐ID删除会员套餐明细
        /// </summary>
        /// <param name="clubCardPkgID"></param>
        void DelClubCardPkgDetail(int clubCardPkgID);
    }
}
