using System.Collections.Generic;

namespace Topcast_Report_Manager.Data
{
    public class LogVarConfig
    {
        public List<LogVar> LogVar { get; set; }

        public LogVarConfig()
        {
            LogVar = new List<LogVar>();
        }
    }
}
