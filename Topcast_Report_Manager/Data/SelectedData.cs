using System;
using System.Collections.Generic;

namespace Topcast_Report_Manager.Data
{
    public class SelectedData
    {
        public List<string> SelectedIDs { get; set; }
        public List<(string batchID, DateTime begin, DateTime end)> IDsBeginEnd { get; set; }

        public SelectedData()
        {
            SelectedIDs = new List<string>();
            IDsBeginEnd = new List<(string batchID, DateTime begin, DateTime end)>();
        }
    }
}
