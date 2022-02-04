using System;
using System.Linq;
using System.Data;
using System.IO;

namespace Topcast_Report_Manager.Workers
{
    public static class ExportManagement
    {
        public static void ExportDataTableToCSV(DataTable dataTable, string filePath, string separator)
        {
            StreamWriter sw = new StreamWriter(filePath, false);

            for (int i = 0; i < dataTable.Columns.Count; i++)
            {
                sw.Write(dataTable.Columns[i]);
                if (i < dataTable.Columns.Count - 1)
                {
                    sw.Write(separator);
                }
            }
            sw.Write(sw.NewLine);

            foreach (DataRow dr in dataTable.Rows)
            {
                for (int i = 0; i < dataTable.Columns.Count; i++)
                {
                    if (!Convert.IsDBNull(dr[i]))
                    {
                        string value = dr[i].ToString();
                        if (value.Contains(','))
                        {
                            value = String.Format("\"{0}\"", value);
                            sw.Write(value);
                        }
                        else
                        {
                            sw.Write(dr[i].ToString());
                        }
                    }
                    if (i < dataTable.Columns.Count - 1)
                    {
                        sw.Write(separator);
                    }
                }
                sw.Write(sw.NewLine);
            }
            sw.Close();
        }
    }
}
