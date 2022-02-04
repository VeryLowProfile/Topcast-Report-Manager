using System.Data;
using System.Collections.Generic;
using Topcast_Report_Manager.Data;

namespace Topcast_Report_Manager.Workers
{
    static public class DataTableManagement
    {
        public static T GetRowColValue<T>(DataTable dataTable, int row, int col)
        {
            object value;

            value = dataTable.Rows[row][col];

            return (T) value;
        }

        public static DataTable GetDataTableAlarmsXref(AppConfig appConfig, DataTable dataTable)
        {
            DataTable alarmTable = new DataTable();
            DataColumn text = new DataColumn("Text");

            alarmTable.Columns.Add(dataTable.Columns["InOut"].ColumnName, dataTable.Columns["InOut"].DataType);
            alarmTable.Columns.Add(dataTable.Columns["Alarm"].ColumnName, dataTable.Columns["Alarm"].DataType);
            alarmTable.Columns.Add(text);
            alarmTable.Columns.Add(dataTable.Columns["DateTime"].ColumnName, dataTable.Columns["DateTime"].DataType);


            int rownumb = dataTable.Rows.Count;

            for (int i = 0; i < rownumb; i++)
            {
                DataRow newRow = alarmTable.NewRow();
                alarmTable.Rows.Add(newRow);
                alarmTable.Rows[i]["InOut"] = dataTable.Rows[i]["InOut"];
                alarmTable.Rows[i]["Alarm"] = dataTable.Rows[i]["Alarm"];
                alarmTable.Rows[i]["DateTime"] = dataTable.Rows[i]["DateTime"];
                foreach (var alarm in appConfig.AlarmConfig.Alarms)
                {
                    if (dataTable.Rows[i]["Alarm"].ToString() == alarm.AlarmTag)
                    {
                        alarmTable.Rows[i]["Text"] = alarm.SelectedText;
                    }
                }
            }
            return alarmTable;
        }

        public static DataTable GetDataTableEventsXref(AppConfig appConfig, DataTable dataTable)
        {
            DataTable alarmTable = new DataTable();
            DataColumn text = new DataColumn("Text");

            alarmTable.Columns.Add(dataTable.Columns["Event"].ColumnName, dataTable.Columns["Event"].DataType);
            alarmTable.Columns.Add(text);
            alarmTable.Columns.Add(dataTable.Columns["DateTime"].ColumnName, dataTable.Columns["DateTime"].DataType);


            int rownumb = dataTable.Rows.Count;

            for (int i = 0; i < rownumb; i++)
            {
                DataRow newRow = alarmTable.NewRow();
                alarmTable.Rows.Add(newRow);
                alarmTable.Rows[i]["Event"] = dataTable.Rows[i]["Event"];
                alarmTable.Rows[i]["DateTime"] = dataTable.Rows[i]["DateTime"];
                foreach (var logEvent in appConfig.EventsConfig.Events)
                {
                    if (dataTable.Rows[i]["Event"].ToString() == logEvent.EventTag)
                    {
                        alarmTable.Rows[i]["Text"] = logEvent.SelectedText;
                    }
                }
            }
            return alarmTable;
        }
    }
}
