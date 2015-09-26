using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Zeta.WisdCar.Model.PO;

namespace Zeta.WisdCar.Online.Models
{
    public class EmployeeViewModel
    {
        string username;
        string userpassword;
        int userid;
        int storeid;
        string storename;
        string name;
        public string Name
        {
            set { name = value; }
            get { return name; }
        }

        public string UserName
        {
            get { return username; }
            set { username = value; }
        }

        public string UserPassword 
        {
            get { return userpassword; }
            set { userpassword = value; }
        }
        public int UserId
        {
            get { return userid; }
            set { userid = value; }
        }
        public int StoreId
        {
            get { return storeid; }
            set { storeid = value; }
        }
        public string StroeName
        {
            get { return storename; }
            set { storename = value; }
        }
    }
}