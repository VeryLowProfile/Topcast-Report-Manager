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
    }
}
