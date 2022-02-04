using System;
using System.Text;
using System.Collections.Generic;
using Topcast_Report_Manager.Data;

namespace Topcast_Report_Manager.Workers
{
    public static class SqlQryBuilder
    {
        public static string BuildSearchQry(SearchParam searchParam, AppConfig appConfig)
        {

            string qry = "";
            string tableName = "";
            string IDColName = "";
            string IDVarName = "";
            string datetimeColName = "";
            string datetimeVarName = "";

            foreach (var table in appConfig.SqlTableConfig.SqlTables)
            {
                if (table.TableType == "VarLogTable")
                {
                    tableName = table.TableName;
                }
            }

            foreach (var logVar in appConfig.LogVarConfig.LogVar)
            {
                if (logVar.ColName == "BatchID")
                {
                    IDColName = logVar.ColName;
                    IDVarName = logVar.SelectedText;
                }
            }

            foreach (var logVar in appConfig.LogVarConfig.LogVar)
            {
                if (logVar.ColName == "DateTime")
                {
                    datetimeColName = logVar.ColName;
                    datetimeVarName = logVar.SelectedText;
                }
            }

            if (searchParam.SearchByID)
            {
                qry = $"SELECT {IDColName} AS '{IDVarName}', MIN({datetimeColName}) AS {datetimeVarName} FROM {tableName} WHERE {IDColName} LIKE '%{searchParam.SearchID}%' GROUP BY {IDColName}";
            }

            if (searchParam.SearchByDate)
            {
                qry = $"SELECT DISTINCT {IDColName} AS '{IDVarName}', MIN({datetimeColName}) AS {datetimeVarName} FROM {tableName} WHERE {datetimeColName} > '{searchParam.SearchDateFrom}' AND {datetimeColName} < '{searchParam.SearchDateTo}' GROUP BY {IDColName}";
            }

            return qry;
        }

        public static string BuildIdBegindate(AppConfig appConfig, string selectedID)
        {
            string qry = "";
            string tableName = "";
            string IDColName = "";
            string IDVarName = "";
            string datetimeColName = "";
            string datetimeVarName = "";

            foreach (var table in appConfig.SqlTableConfig.SqlTables)
            {
                if (table.TableType == "VarLogTable")
                {
                    tableName = table.TableName;
                }
            }

            foreach (var logVar in appConfig.LogVarConfig.LogVar)
            {
                if (logVar.ColName == "BatchID")
                {
                    IDColName = logVar.ColName;
                    IDVarName = logVar.SelectedText;
                }
            }

            foreach (var logVar in appConfig.LogVarConfig.LogVar)
            {
                if (logVar.ColName == "DateTime")
                {
                    datetimeColName = logVar.ColName;
                    datetimeVarName = logVar.SelectedText;
                }
            }

            qry = $"SELECT min({datetimeColName}) FROM {tableName} WHERE {IDColName} = '{selectedID}'";

            return qry;
        }

        public static string BuildIdEnddate(AppConfig appConfig, string selectedID)
        {
            string qry = "";
            string tableName = "";
            string IDColName = "";
            string IDVarName = "";
            string datetimeColName = "";
            string datetimeVarName = "";

            foreach (var table in appConfig.SqlTableConfig.SqlTables)
            {
                if (table.TableType == "VarLogTable")
                {
                    tableName = table.TableName;
                }
            }

            foreach (var logVar in appConfig.LogVarConfig.LogVar)
            {
                if (logVar.ColName == "BatchID")
                {
                    IDColName = logVar.ColName;
                    IDVarName = logVar.SelectedText;
                }
            }

            foreach (var logVar in appConfig.LogVarConfig.LogVar)
            {
                if (logVar.ColName == "DateTime")
                {
                    datetimeColName = logVar.ColName;
                    datetimeVarName = logVar.SelectedText;
                }
            }

            qry = $"SELECT max({datetimeColName}) FROM {tableName} WHERE {IDColName} = '{selectedID}'";

            return qry;
        }

        public static string BuildShowDataQry(List<(string colName, string selectedText)> showPivot, AppConfig appConfig,  string selectedID)
        {
            string tableName = "";
            string IDColName = "";
            string IDVarName = "";
            string datetimeColName = "";
            string datetimeVarName = "";
            StringBuilder stringBuilder = new StringBuilder();

            foreach (var table in appConfig.SqlTableConfig.SqlTables)
            {
                if (table.TableType == "VarLogTable")
                {
                    tableName = table.TableName;
                }
            }

            foreach (var logVar in appConfig.LogVarConfig.LogVar)
            {
                if (logVar.ColName == "BatchID")
                {
                    IDColName = logVar.ColName;
                    IDVarName = logVar.SelectedText;
                }
            }

            foreach (var logVar in appConfig.LogVarConfig.LogVar)
            {
                if (logVar.ColName == "DateTime")
                {
                    datetimeColName = logVar.ColName;
                    datetimeVarName = logVar.SelectedText;
                }
            }

            stringBuilder.Append("SELECT ");

            foreach (var pivot in showPivot)
            {
                stringBuilder.Append($" {pivot.colName} AS '{pivot.selectedText}',");
            }

            stringBuilder.Append($" CAST ({datetimeColName} AS datetime)  AS {datetimeVarName} ");
            stringBuilder.Append($" FROM {tableName} ");
            stringBuilder.Append($" WHERE  {IDColName} = '{selectedID}'");
            stringBuilder.Append($" ORDER BY {datetimeColName}");

            return stringBuilder.ToString();
        }

        public static string BuildPlotQry(List<(string colName, string selectedText, string plotColor)> showPivot, AppConfig appConfig, string selectedID)
        {
            string tableName = "";
            string IDColName = "";
            string IDVarName = "";
            string datetimeColName = "";
            string datetimeVarName = "";
            StringBuilder stringBuilder = new StringBuilder();

            foreach (var table in appConfig.SqlTableConfig.SqlTables)
            {
                if (table.TableType == "VarLogTable")
                {
                    tableName = table.TableName;
                }
            }

            foreach (var logVar in appConfig.LogVarConfig.LogVar)
            {
                if (logVar.ColName == "BatchID")
                {
                    IDColName = logVar.ColName;
                    IDVarName = logVar.SelectedText;
                }
            }

            foreach (var logVar in appConfig.LogVarConfig.LogVar)
            {
                if (logVar.ColName == "DateTime")
                {
                    datetimeColName = logVar.ColName;
                    datetimeVarName = logVar.SelectedText;
                }
            }
            stringBuilder.Append("SELECT ");

            foreach (var pivot in showPivot)
            {
                stringBuilder.Append($" {pivot.colName} AS '{pivot.selectedText}',");
            }

            //stringBuilder.Append($"{datetimeColName} AS {datetimeVarName} ");
            stringBuilder.Append($" CAST ({datetimeColName} AS datetime)  AS {datetimeVarName} ");
            stringBuilder.Append($" FROM {tableName} ");
            stringBuilder.Append($" WHERE  {IDColName} = '{selectedID}'");
            stringBuilder.Append($" ORDER BY {datetimeColName}");

            return stringBuilder.ToString();

        }

        public static string BuildReportLogVarQry(List<(string colName, string selectedText)> showPivot, AppConfig appConfig, string selectedID)
        {
            string tableName = "";
            string IDColName = "";
            string IDVarName = "";
            string datetimeColName = "";
            string datetimeVarName = "";
            StringBuilder stringBuilder = new StringBuilder();

            foreach (var table in appConfig.SqlTableConfig.SqlTables)
            {
                if (table.TableType == "VarLogTable")
                {
                    tableName = table.TableName;
                }
            }

            foreach (var logVar in appConfig.LogVarConfig.LogVar)
            {
                if (logVar.ColName == "BatchID")
                {
                    IDColName = logVar.ColName;
                    IDVarName = logVar.SelectedText;
                }
            }

            foreach (var logVar in appConfig.LogVarConfig.LogVar)
            {
                if (logVar.ColName == "DateTime")
                {
                    datetimeColName = logVar.ColName;
                    datetimeVarName = logVar.SelectedText;
                }
            }

            stringBuilder.Append("SELECT ");

            foreach (var pivot in showPivot)
            {
                stringBuilder.Append($" {pivot.colName} AS '{pivot.selectedText}',");
            }

            stringBuilder.Append($"{datetimeColName} AS {datetimeVarName} ");
            stringBuilder.Append($" FROM {tableName} ");
            stringBuilder.Append($" WHERE  {IDColName} = '{selectedID}'");
            stringBuilder.Append($" ORDER BY {datetimeColName}");

            return stringBuilder.ToString();
        }

        public static string BuildAlarmsQry(AppConfig appConfig, SelectedData selectedData, string selectedID)
        {
            string qry;
            string tableName = "";
            DateTime begin = DateTime.Now;
            DateTime end = DateTime.Now;

            foreach (var table in appConfig.SqlTableConfig.SqlTables)
            {
                if (table.TableType == "AlarmsLogTable")
                {
                    tableName = table.TableName;
                }
            }

            foreach (var id in selectedData.IDsBeginEnd)
            {
                if (id.batchID == selectedID)
                {
                    begin = id.begin;
                    end = id.end;
                }
            }

            qry = $"SELECT * FROM {tableName} where DateTime > '{begin.ToString(appConfig.SqlConnConfig.SqlDateTimeFormat)}' and DateTime < '{end.ToString(appConfig.SqlConnConfig.SqlDateTimeFormat)}'";

            return qry;

        }

        public static string BuildEventsQry(AppConfig appConfig, SelectedData selectedData, string selectedID)
        {
            string qry;
            string tableName = "";
            DateTime begin = DateTime.Now;
            DateTime end = DateTime.Now;

            foreach (var table in appConfig.SqlTableConfig.SqlTables)
            {
                if (table.TableType == "EventsLogTable")
                {
                    tableName = table.TableName;
                }
            }

            foreach (var id in selectedData.IDsBeginEnd)
            {
                if (id.batchID == selectedID)
                {
                    begin = id.begin;
                    end = id.end;
                }
            }

            qry = $"SELECT * FROM {tableName} where DateTime > '{begin.ToString(appConfig.SqlConnConfig.SqlDateTimeFormat)}' and DateTime < '{end.ToString(appConfig.SqlConnConfig.SqlDateTimeFormat)}'";

            return qry;

        }
    }
}
