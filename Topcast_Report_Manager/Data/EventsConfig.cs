using System.Collections.Generic;

namespace Topcast_Report_Manager.Data
{
    public class EventsConfig
    {
        public List<LogEvent> Events { get; set; }

        public EventsConfig()
        {
            Events = new List<LogEvent>();
        }
    }
}
