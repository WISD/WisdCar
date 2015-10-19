using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zeta.WisdCar.Model.VO;
using Zeta.WisdCar.Model.Entity;
using Zeta.WisdCar.Repository.Impl;
using System.Data;
using Zeta.WisdCar.Model.PO;
using AutoMapper;
using Zeta.WisdCar.Business.AutoMapper;
using Zeta.WisdCar.Infrastructure.Helper;
using System.IO;
using System.Data.SqlClient;
using Zeta.WisdCar.Infrastructure.DBUtility;
using Zeta.WisdCar.Infrastructure.Log;

namespace Zeta.WisdCar.Business.CustClubCardModule
{
    public class CustomerMgm : ICustomerMgm
    {
        public List<CustomerVO> GetCustomers(CustomerQueryEntity filter)
        {
            CustomerData customerData = new CustomerData();
            List<CustomerVO> customerVOList = new List<CustomerVO>();

            DataSet ds = customerData.GetCustomers(filter);
            List<CustomerPO> customerPOList = ds.GetEntity<List<CustomerPO>>();
            if(customerPOList==null)
            {
                customerPOList = new List<CustomerPO>();
            }
            customerPOList.ForEach(i =>
            {
                customerVOList.Add(Mapper.Map<CustomerPO, CustomerVO>(i));
            });

            return customerVOList;
        }

        public void AddCustomer(Model.VO.CustomerVO cust)
        {
            CustomerData customerData = new CustomerData();
            customerData.AddCustomer(Mapper.Map<CustomerVO, CustomerPO>(cust));
        }

        public void EditCustomer(Model.VO.CustomerVO cust)
        {
            CustomerData customerData = new CustomerData();
            customerData.EditCustomer(Mapper.Map<CustomerVO, CustomerPO>(cust));
        }
        public bool EditCustomer(Model.VO.CustomerVO cust, Model.VO.CarVO car)
        {
            CustomerData customerData = new CustomerData();
            return customerData.EditCustomer(Mapper.Map<CustomerVO, CustomerPO>(cust), Mapper.Map<CarVO, CarPO>(car));
        }
        public void DelCustomer(int id)
        {
            CustomerData customerData = new CustomerData();
            customerData.DelCustomer(id);
        }

        public Model.VO.CustomerVO GetCustomerByID(int custID)
        {
            CustomerData customerData = new CustomerData();
            CustomerVO customerVO = new CustomerVO();
            CustomerPO customerPO = customerData.GetCustomerByID(custID);
            customerVO = Mapper.Map<CustomerPO, CustomerVO>(customerPO);

            return customerVO;
        }



        public List<CustomerVO> GetCustomers(string key)
        {
            CustomerData customerData = new CustomerData();
            List<CustomerVO> customerVOList = new List<CustomerVO>();

            DataSet ds = customerData.GetCustomers(key);
            List<CustomerPO> customerPOList = ds.GetEntity<List<CustomerPO>>();

            customerPOList.ForEach(i =>
            {
                customerVOList.Add(Mapper.Map<CustomerPO, CustomerVO>(i));
            });

            return customerVOList;
        }

        public bool CheckPhoneNo(string phoneNo)
        {
            CustomerData customerData = new CustomerData();

            StringBuilder strSql = new StringBuilder();
            string strWhere = "";
            if (!string.IsNullOrEmpty(phoneNo.Trim()))
            {
                strSql.AppendFormat(" MobileNO = '{0}' ", phoneNo);
            }

            strWhere = strSql.ToString();
            int cnt = customerData.GetRecordCount(strWhere);

            if (cnt > 0)
                return true;
            else
                return false;
        }
        public int AddAllCustomer(CustomerVO cust, CarVO car)
        {
            CustomerData customerData = new CustomerData();
            var result = customerData.AddAllCustomer(Mapper.Map<CustomerVO, CustomerPO>(cust), Mapper.Map<CarVO, CarPO>(car));
            if (result <= 0)
            {
                throw new Exception("添加出现错误");
            }
            return result;
        }



        public CustomerVO GetCustomerByMobileNo(string mno)
        {
            CustomerData custdata = new CustomerData();
            CustomerPO result = custdata.GetCustomerByMobileNo(mno);
            if (result != null)
            {
                return Mapper.Map<CustomerPO, CustomerVO>(result);
            }
            else
            {
                return new CustomerVO();
            }

        }
        public CustomerVO GetCustomerByCarNo(string carno)
        {
            CustomerData custdata = new CustomerData();
            CustomerPO result = custdata.GetCustomerByCarNo(carno);
            if (result != null)
            {
                return Mapper.Map<CustomerPO, CustomerVO>(result);
            }
            else
            {
                return new CustomerVO();
            }
        }
        public void ImprotDataTosql(Stream file,string creid)
        {
            ExcelHelper excHlp = new ExcelHelper();

            var dtexcel = excHlp.GetDataFromExcel(file);

            DataSet ds = new DataSet();
            SetColumn(ds);
            if(dtexcel.Rows.Count>0)
            {
                foreach (DataRow item in dtexcel.Rows)
                {
                   SetValue(ds, item,creid); 
                }
            }
            InsertData(ds);
            
        }
        private void InsertData(DataSet ds)
        {
            //conn.Open();
            //SqlTransaction tx = conn.BeginTransaction();
           using (SqlConnection conn = new SqlConnection(PubConstant.ConnectionString))
           {
               conn.Open();
               SqlTransaction tx = conn.BeginTransaction();
               try
               {
                   using (SqlBulkCopy sbc = new SqlBulkCopy(conn, SqlBulkCopyOptions.TableLock,tx))
                   {
                       sbc.DestinationTableName = ds.Tables[0].TableName;
                       for (int i = 0; i < ds.Tables[0].Columns.Count; i++)
                       {
                           sbc.ColumnMappings.Add(ds.Tables[0].Columns[i].ColumnName, ds.Tables[0].Columns[i].ColumnName);
                       }
                       
                       sbc.WriteToServer(ds.Tables[0]);
                   }
                   using (SqlBulkCopy sbcCar = new SqlBulkCopy(conn, SqlBulkCopyOptions.TableLock,tx))
                   {
                       sbcCar.DestinationTableName = ds.Tables[1].TableName;
                       for (int j = 0; j < ds.Tables[1].Columns.Count; j++)
                       {
                           sbcCar.ColumnMappings.Add(ds.Tables[1].Columns[j].ColumnName, ds.Tables[1].Columns[j].ColumnName);
                       }
                       sbcCar.WriteToServer(ds.Tables[1]);
                   }
                   StringBuilder sbsql = new StringBuilder();
                   for (int k = 0; k < ds.Tables[0].Rows.Count;k++ )
                   {
                       sbsql.AppendFormat("update car set customerid=(select customerid from customer where Reserved1='{0}') where Reserved1='{1}'; ", ds.Tables[0].Rows[k]["Reserved1"].ToString(), ds.Tables[0].Rows[k]["Reserved1"].ToString());
                   }
                   using(SqlCommand comm = new SqlCommand(sbsql.ToString(),conn,tx))
                   {
                       comm.ExecuteNonQuery();
                   }
                   tx.Commit();
                   conn.Close();
                   LogHandler.Info(string.Format("导入客户{0}行",ds.Tables[0].Rows.Count));
               }
               catch (Exception ex)
               {
                   conn.Close();
                   LogHandler.Error(ex.ToString());
                   throw ex;
               }
               
           }  
        }
        private void SetValue(DataSet ds,DataRow item,string creid)
        {
            string guid = Guid.NewGuid().ToString();
            DataRow cusrow = ds.Tables[0].NewRow();
            DataRow carrow = ds.Tables[1].NewRow();
            cusrow["Name"] = item[0].ToString();
            cusrow["MobileNO"] = item[1] == null ? null : item[1].ToString();
            cusrow["Sex"] = item[2] == null ? null : item[2].ToString();
            if (item[13] == null || string.IsNullOrEmpty(item[3].ToString()))
            {
                cusrow["Birthday"] = DBNull.Value;
            }
            else
            {
                cusrow["Birthday"] = Convert.ToDateTime(item[3].ToString());
            }
            //cusrow["Birthday"] = item[3] == null ? null : Convert.ToDateTime(item[3]).ToString("yyyy/mm/dd");
            cusrow["ICNo"] = item[4] == null ? null : item[4].ToString();
            cusrow["Weixin"] = null;
            cusrow["Company"] = null;
            cusrow["CardFlag"] = 0;
            cusrow["LogicalStatus"] = 1;
            cusrow["CreatorID"] = creid;
            cusrow["CreatedDate"] = DateTime.Now;
            cusrow["LastModifierID"] = creid;
            cusrow["LastModifiedDate"] = DateTime.Now;
            cusrow["Reserved1"] = guid;
            cusrow["Reserved2"] = null;
            cusrow["Reserved3"] = null;

            carrow["CarNo"] = item[5].ToString();
            carrow["Brand"] = item[6] == null ? null : item[6].ToString();
            carrow["CarModel"] = item[7] == null ? null : item[7].ToString();
            carrow["Capacity"] = item[8] == null ? null : item[8].ToString();
            carrow["Color"] = item[9] == null ? null : item[9].ToString();
            carrow["FrameNo"] = item[10] == null ? null : item[10].ToString();
            carrow["EngineNo"] = item[11] == null ? null : item[11].ToString();
            carrow["MaintainKM"] = item[12] == null ? null : item[12].ToString();
            //carrow["InsureDate"] = item[13] == null || string.IsNullOrEmpty(item[13].ToString()) ? DBNull.Value : (DateTime?)Convert.ToDateTime(item[13].ToString());
            if (item[13] == null || string.IsNullOrEmpty(item[13].ToString()))
            {
                carrow["InsureDate"] = DBNull.Value;
            }
            else
            {
                carrow["InsureDate"] = Convert.ToDateTime(item[13].ToString());
            }
            if (item[14] == null || string.IsNullOrEmpty(item[14].ToString()))
            {
                carrow["ASDate"] = DBNull.Value;
            }
            else
            {
                carrow["ASDate"] = Convert.ToDateTime(item[14].ToString());
            }
            //carrow["ASDate"] = item[14] == null || string.IsNullOrEmpty(item[14].ToString()) ? null : (DateTime?)Convert.ToDateTime(item[14].ToString());
            carrow["CustomerID"] = 0;
            carrow["LogicalStatus"] = 1;
            carrow["CreatorID"] = creid;
            carrow["CreatedDate"] = DateTime.Now;
            carrow["LastModifierID"] = creid;
            carrow["LastModifiedDate"] = DateTime.Now;
            carrow["Reserved1"] = guid;
            carrow["Reserved2"] = null;
            carrow["Reserved3"] = null;
            ds.Tables[0].Rows.Add(cusrow);
            ds.Tables[1].Rows.Add(carrow);

        }
        private void SetColumn(DataSet ds)
        {
            DataTable cusdt = new DataTable("customer");
            DataTable cardt = new DataTable("car");
            cusdt.Columns.AddRange(new DataColumn[]{
                new DataColumn("CustomerID",Type.GetType("System.Int32")),
                new DataColumn("Name",Type.GetType("System.String")),
                new DataColumn("MobileNO",Type.GetType("System.String")),
                new DataColumn("Sex",Type.GetType("System.String")),
                new DataColumn("Birthday",Type.GetType("System.String")),
                new DataColumn("ICNo",Type.GetType("System.String")),
                new DataColumn("Weixin",Type.GetType("System.String")),
                new DataColumn("Company",Type.GetType("System.String")),
                new DataColumn("CardFlag",Type.GetType("System.Int32")),
                new DataColumn("LogicalStatus",Type.GetType("System.Int32")),
                new DataColumn("CreatorID",Type.GetType("System.String")),
                new DataColumn("CreatedDate",Type.GetType("System.DateTime")),
                new DataColumn("LastModifierID",Type.GetType("System.String")),
                new DataColumn("LastModifiedDate",Type.GetType("System.DateTime")),
                new DataColumn("Reserved1",Type.GetType("System.String")),
                new DataColumn("Reserved2",Type.GetType("System.String")),
                new DataColumn("Reserved3",Type.GetType("System.String"))
            });
            cardt.Columns.AddRange(new DataColumn[]{
                new DataColumn("CarID",Type.GetType("System.Int32")),
                new DataColumn("CarNo",Type.GetType("System.String")),
                new DataColumn("Brand",Type.GetType("System.String")),
                new DataColumn("CarModel",Type.GetType("System.String")),
                new DataColumn("Capacity",Type.GetType("System.String")),
                new DataColumn("Color",Type.GetType("System.String")),
                new DataColumn("FrameNo",Type.GetType("System.String")),
                new DataColumn("EngineNo",Type.GetType("System.String")),
                new DataColumn("MaintainKM",Type.GetType("System.String")),
                new DataColumn("InsureDate",Type.GetType("System.DateTime")),
                new DataColumn("ASDate",Type.GetType("System.DateTime")),
                new DataColumn("CustomerID",Type.GetType("System.Int32")),
                new DataColumn("LogicalStatus",Type.GetType("System.Int32")),
                new DataColumn("CreatorID",Type.GetType("System.String")),
                new DataColumn("CreatedDate",Type.GetType("System.DateTime")),
                new DataColumn("LastModifierID",Type.GetType("System.String")),
                new DataColumn("LastModifiedDate",Type.GetType("System.DateTime")),
                new DataColumn("Reserved1",Type.GetType("System.String")),
                new DataColumn("Reserved2",Type.GetType("System.String")),
                new DataColumn("Reserved3",Type.GetType("System.String"))
            });
            ds.Tables.AddRange(new DataTable[] { cusdt, cardt });

        }


        public int GetRecordCount(CustomerQueryEntity filter)
        {
            CustomerData custdata = new CustomerData();
            return custdata.GetRecordCount(filter);
        }
    }
}
