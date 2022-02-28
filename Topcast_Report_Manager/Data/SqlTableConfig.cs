using System;
using System.Xml.Linq;
using System.Collections.Generic;

namespace Topcast_Report_Manager.Data
{
    public class SqlTableConfig
    {
        public List<SqlTable> SqlTables { get; set; }

        public SqlTableConfig()
        {
            SqlTables = new List<SqlTable>();
        }

        public void GetTableConfig(XDocument xml)
        {
            var sqlTableConfigElements = xml.Root.Element("SqlTableConfig").Descendants();
            try
            {
                foreach (var element in sqlTableConfigElements)
                {
                    SqlTable sqlTable = new SqlTable();
                    sqlTable.TableType = element.Name.ToString();
                    sqlTable.TableName = element.Value.ToString();

                    SqlTables.Add(sqlTable);
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"SqlTableConfig.GetTableConfig - Error on getting table config from xml file: {ex.Message}");
            }
        }
    }
}
