using System.Collections.Generic;

namespace Topcast_Report_Manager.Data
{
    public class AlarmsConfig
    {
        public List<LogAlarm> Alarms { get; set; } 

        public AlarmsConfig()
        {
            Alarms = new List<LogAlarm>();
        }
    }
}
