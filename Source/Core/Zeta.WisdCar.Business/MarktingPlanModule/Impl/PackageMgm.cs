using AutoMapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zeta.WisdCar.Model.PO;
using Zeta.WisdCar.Model.VO;
using Zeta.WisdCar.Repository.Impl;
using Zeta.WisdCar.Business.AutoMapper;

namespace Zeta.WisdCar.Business.MarktingPlanModule
{
    public class PackageMgm : IPackageMgm
    {
        public List<Model.VO.PackageVO> GetAllPackages()
        {
            PackageData packageData = new PackageData();
            List<PackageVO> packageVOList = new List<PackageVO>();

            DataSet ds = packageData.GetAllPackages();

            List<PackagePO> packagePOList = ds.GetEntity<List<PackagePO>>();
            if(packagePOList!=null&&packagePOList.Count>0)
            {
                packagePOList.ForEach(i =>
                {
                    packageVOList.Add(Mapper.Map<PackagePO, PackageVO>(i));
                });
            }
            

            return packageVOList;
        }

        public Model.VO.PackageVO GetPackageByID(int id)
        {
            PackageData packageData = new PackageData();
            PackageVO packageVO = new PackageVO();
            PackagePO packagePO = packageData.GetPackageByID(id);
            packageVO = Mapper.Map<PackagePO, PackageVO>(packagePO);

            return packageVO;
        }

        public int AddPackage(Model.VO.PackageVO package)
        {
            PackageData packageData = new PackageData();
            return packageData.AddPackage(Mapper.Map<PackageVO, PackagePO>(package));  
        }

        public bool IsPackageExist(string packageName)
        {
            PackageData packageData = new PackageData();

            StringBuilder strSql = new StringBuilder();
            string strWhere = "";
            if (!string.IsNullOrEmpty(packageName.Trim()))
            {
                strSql.AppendFormat(" PackageName = '{0}' ", packageName);
            }

            strWhere = strSql.ToString();
            int cnt = packageData.GetRecordCount(strWhere);

            if (cnt > 0)
                return true;
            else
                return false;
        }

        public void EditPackage(Model.VO.PackageVO package)
        {
            PackageData packageData = new PackageData();
            packageData.EditPackage(Mapper.Map<PackageVO, PackagePO>(package));
        }

        public void DelPackage(int id)
        {
            PackageData packageData = new PackageData();
            packageData.DelPackage(id);
        }
    }
}
