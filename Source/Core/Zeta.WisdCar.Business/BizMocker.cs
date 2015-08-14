using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Zeta.WisdCar.Business.MarktingPlanModule;
using Zeta.WisdCar.Business.SysMgmModule;
using Zeta.WisdCar.Infrastructure.Log;
using Zeta.WisdCar.Model.VO;

namespace Zeta.WisdCar.Business
{
    public class BizMocker : IPermissionMgm, IClubCardTypeMgm
    {
        public static void MockLog4Net()
        {
            new Task(() =>
            {
                while (true)
                {
                    LogHandler.Error("我错了。。。");
                    Thread.Sleep(1000);
                }
            }).Start();
        }
        
        /// <summary>
        /// 获取当前登录的用户帐号
        /// </summary>
        /// <returns></returns>
        public string GetCurUserName()
        {
            return "zltian";
        }

        public List<ClubCardTypeVO> GetAllCardType()
        {
            List<ClubCardTypeVO> result = new List<ClubCardTypeVO>();

            #region Mock
            ClubCardTypeVO item1 = new ClubCardTypeVO()
            {
                ClubCardTypeID = 1,
                CardTypeName = "白金卡",
                PackageDiscount = 0.70M,
                PayDiscount = 0.70M
            };

            ClubCardTypeVO item2 = new ClubCardTypeVO()
            {
                ClubCardTypeID = 2,
                CardTypeName = "黄金卡",
                PackageDiscount = 0.65M,
                PayDiscount = 0.66M
            };

            ClubCardTypeVO item3 = new ClubCardTypeVO()
            {
                ClubCardTypeID = 3,
                CardTypeName = "钻石卡",
                PackageDiscount = 0.81M,
                PayDiscount = 0.56M
            };

            ClubCardTypeVO item4 = new ClubCardTypeVO()
            {
                ClubCardTypeID = 4,
                CardTypeName = "青铜卡",
                PackageDiscount = 0.45M,
                PayDiscount = 0.65M
            };

            ClubCardTypeVO item5 = new ClubCardTypeVO()
            {
                ClubCardTypeID = 5,
                CardTypeName = "白银卡",
                PackageDiscount = 0.78M,
                PayDiscount = 0.26M
            };

            ClubCardTypeVO item6 = new ClubCardTypeVO()
            {
                ClubCardTypeID = 6,
                CardTypeName = "自由行卡",
                PackageDiscount = 0.89M,
                PayDiscount = 0.76M
            };

            ClubCardTypeVO item7 = new ClubCardTypeVO()
            {
                ClubCardTypeID = 7,
                CardTypeName = "折扣卡",
                PackageDiscount = 0.23M,
                PayDiscount = 0.43M
            };

            ClubCardTypeVO item8 = new ClubCardTypeVO()
            {
                ClubCardTypeID = 8,
                CardTypeName = "优惠卡",
                PackageDiscount = 0.89M,
                PayDiscount = 0.45M
            };

            ClubCardTypeVO item9 = new ClubCardTypeVO()
            {
                ClubCardTypeID = 9,
                CardTypeName = "普通卡",
                PackageDiscount = 0.42M,
                PayDiscount = 0.84M
            };

            ClubCardTypeVO item10 = new ClubCardTypeVO()
            {
                ClubCardTypeID = 10,
                CardTypeName = "大众卡",
                PackageDiscount = 0.23M,
                PayDiscount = 0.46M
            };

            ClubCardTypeVO item11 = new ClubCardTypeVO()
            {
                ClubCardTypeID = 11,
                CardTypeName = "尊贵卡",
                PackageDiscount = 0.47M,
                PayDiscount = 0.47M
            };

            ClubCardTypeVO item12 = new ClubCardTypeVO()
            {
                ClubCardTypeID = 12,
                CardTypeName = "贵宾卡",
                PackageDiscount = 0.37M,
                PayDiscount = 0.37M
            };

            result.Add(item1);
            result.Add(item2);
            result.Add(item3);
            result.Add(item4);
            result.Add(item5);
            result.Add(item6);
            result.Add(item7);
            result.Add(item8);
            result.Add(item9);
            result.Add(item10);
            result.Add(item11);
            result.Add(item12);
            #endregion

            return result;
        }

        public Model.VO.ClubCardTypeVO GetCardTypeByID(int cardTypeID)
        {
            throw new NotImplementedException();
        }

        public void AddCardType(Model.VO.ClubCardTypeVO cardType)
        {
            throw new NotImplementedException();
        }

        public void EditCardType(Model.VO.ClubCardTypeVO cardType)
        {
            throw new NotImplementedException();
        }

        public void DelCardType(int id)
        {
            throw new NotImplementedException();
        }
    }
}
