using System;
using System.Xml.Linq;

namespace Topcast_Report_Manager.Data
{
    public class SqlConnConfig
    {
        public string SqlType { get; set; }
        public string SqlServerIP { get; set; }
        public string SqlServerName { get; set; }
        public string SqlDbName { get; set; }
        public string SqlUserID { get; set; }
        public string SqlUserPWD { get; set; }
        public string SqlConnectionString { get; set; }
        public string SqlDateTimeFormat { get; set;  }

        public void GetConnectionConfig(XDocument xml)
        {
            var sqlConnConfigElements = xml.Root.Element("SqlConnConfig").Descendants();

            try
            {
                foreach (var element in sqlConnConfigElements)
                {
                    if (element.Name == "SqlType")
                    {
                        SqlType = element.Value;
                    }
                    if (element.Name == "SqlServerIP")
                    {
                        SqlServerIP = element.Value;
                    }
                    if (element.Name == "SqlServerName")
                    {
                        SqlServerName = element.Value;
                    }
                    if (element.Name == "SqlDbName")
                    {
                        SqlDbName = element.Value;
                    }
                    if (element.Name == "SqlUserID")
                    {
                        SqlUserID = element.Value;
                    }
                    if (element.Name == "SqlUserPWD")
                    {
                        SqlUserPWD = element.Value;
                    }
                    if (element.Name == "SqlDateTimeFormat")
                    {
                        SqlDateTimeFormat = element.Value;
                    }
                }

                //Build Connection string
                BuildConnectionString();

            } 
            catch (Exception ex) 
            {
                throw new Exception($"SqlConnConfig.GetConnectionConfig - Error on getting connection config from xml file: {ex.Message}");
            }
        }

        public void BuildConnectionString()
        {
            if (SqlType != "")
            {
                if (SqlType == "SQL")
                {
                    SqlConnectionString = $"Server = {SqlServerIP}\\{SqlServerName}; Database = {SqlDbName}; UID = {SqlUserID}; PWD = {SqlUserPWD}";
                }
                else if (SqlType == "MySQL")
                {
                    SqlConnectionString = $"Server = {SqlServerIP}; Database = {SqlDbName}; User ID = {SqlUserID}; Password = {SqlUserPWD}";
                }
                else
                {
                    throw new Exception("SqlConnConfig.BuildConnectionString - SqlType not supported");
                }
            }
            else
            {
                throw new Exception("SqlConnConfig.BuildConnectionString - SqlType not defined");
            }
        }
    }
}
