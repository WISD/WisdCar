﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zeta.WisdCar.Model.VO
{
    public class PackageVO
    {
        private string _rowid;
        private string _operation;
        private string _totalpricedesc;
        private string _detailopt;
        private int _packageid;
        private string _packagename;
        private decimal _totalprice;
        private int _logicalstatus = 1;
        private string _creatorid;
        private DateTime _createddate;
        private string _lastmodifierid;
        private DateTime _lastmodifieddate;
        private string _reserved1;
        private string _reserved2;
        private string _reserved3;

        /// <summary>
        /// Datatables Row ID
        /// </summary>
        public string DT_RowId
        {
            set { _rowid = value; }
            get { return _rowid; }
        }
        /// <summary>
        /// 操作
        /// </summary>
        public string Operation
        {
            set { _operation = value; }
            get { return _operation; }
        }
        /// <summary>
        /// 套餐总价
        /// Desc
        /// </summary>
        public string TotalPriceDesc
        {
            set { _totalpricedesc = value; }
            get { return _totalpricedesc; }
        }
        public string DetailOpt
        {
            set { _detailopt = value; }
            get { return _detailopt; }
        }
        /// <summary>
        /// 消费套餐表ID
        /// </summary>
        public int PackageID
        {
            set { _packageid = value; }
            get { return _packageid; }
        }
        /// <summary>
        /// 套餐名称
        /// </summary>
        public string PackageName
        {
            set { _packagename = value; }
            get { return _packagename; }
        }
        /// <summary>
        /// 套餐总价
        /// </summary>
        public decimal TotalPrice
        {
            set { _totalprice = value; }
            get { return _totalprice; }
        }
        /// <summary>
        /// 逻辑状态
        /// </summary>
        public int LogicalStatus
        {
            set { _logicalstatus = value; }
            get { return _logicalstatus; }
        }
        /// <summary>
        /// 创建人ID
        /// </summary>
        public string CreatorID
        {
            set { _creatorid = value; }
            get { return _creatorid; }
        }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreatedDate
        {
            set { _createddate = value; }
            get { return _createddate; }
        }
        /// <summary>
        /// 最近修改人ID
        /// </summary>
        public string LastModifierID
        {
            set { _lastmodifierid = value; }
            get { return _lastmodifierid; }
        }
        /// <summary>
        /// 最近修改时间
        /// </summary>
        public DateTime LastModifiedDate
        {
            set { _lastmodifieddate = value; }
            get { return _lastmodifieddate; }
        }
        /// <summary>
        /// 保留字段1
        /// </summary>
        public string Reserved1
        {
            set { _reserved1 = value; }
            get { return _reserved1; }
        }
        /// <summary>
        /// 保留字段2
        /// </summary>
        public string Reserved2
        {
            set { _reserved2 = value; }
            get { return _reserved2; }
        }
        /// <summary>
        /// 保留字段3
        /// </summary>
        public string Reserved3
        {
            set { _reserved3 = value; }
            get { return _reserved3; }
        }

    }
}
