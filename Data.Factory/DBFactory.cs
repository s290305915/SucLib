using System;
using System.Collections.Generic;
using System.Configuration;
using System.Reflection;
using System.Text;
using SucLib.Data.IDal;
using SucLib.Common;

namespace SucLib.Data.Factory
{
    public class DBFactory
    {
        public static IDBHelp Create()
        {
            string typeName = "";
            string text = "SucLib";
            //string a = ConfigurationSettings.AppSettings["DBType"];
            string a = "SqlServer"; //ConfigUtil.ConfigHelper.GetConfigString("DBType");
            if (a == "Access")
            {
                typeName = text + ".Data.Dal.AccHelp";
            }
            else if (a == "SqlServer" || string.IsNullOrEmpty(a))
            {
                typeName = text + ".Data.Dal.SQLHelp";
            }
            else if (a == "MySql")
            { }
            else if (a == "DB2")
            { }
            else if (a == "Oracle")
            { }
            else if (a == "SqlLite")
            { }
            return (IDBHelp)Assembly.Load(text).CreateInstance(typeName);
        }
    }
}
