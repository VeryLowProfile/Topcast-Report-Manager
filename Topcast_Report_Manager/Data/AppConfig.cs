using System;
using System.Xml.Linq;

namespace Topcast_Report_Manager.Data
{
    public class AppConfig
    {
        public GenConfig GenConfig { get; set; }
        public SqlConnConfig SqlConnConfig { get; set; }
        public SqlTableConfig SqlTableConfig { get; set; }
        public LogVarConfig LogVarConfig { get; set; }
        public AlarmsConfig AlarmConfig { get; set; }
        public EventsConfig EventsConfig { get; set; }

        public AppConfig()
        {
            GenConfig = new GenConfig();
            SqlConnConfig = new SqlConnConfig();
            SqlTableConfig = new SqlTableConfig();
            LogVarConfig = new LogVarConfig();
            AlarmConfig = new AlarmsConfig();
            EventsConfig = new EventsConfig();
        }

        public void GetAppConfigXML(string path)
        {

            //Load xml Config document
            try
            {
                XDocument xml = XDocument.Load(path);
                var GenConfigElements = xml.Root.Element("GenConfig").Descendants();
                foreach (var element in GenConfigElements)
                {
                    if (element.Name == "MainFormWidth")
                    {
                        GenConfig.MainFormWidth = element.Value;
                    }
                    if (element.Name == "MainFormHeight")
                    {
                        GenConfig.MainFormHeight = element.Value;
                    }
                    if (element.Name == "ChildFormWidth")
                    {
                        GenConfig.ChildFormWidth = element.Value;
                    }
                    if (element.Name == "ChildFormHeight")
                    {
                        GenConfig.ChildFormHeight = element.Value;
                    }
                    if (element.Name == "FullScreen")
                    {
                        GenConfig.FullScreen = element.Value;
                    }
                    if (element.Name == "DefLenguage")
                    {
                        GenConfig.DefLenguage = element.Value;
                    }
                    if (element.Name == "DefReportPath")
                    {
                        GenConfig.DefReportPath = element.Value;
                    }
                    if (element.Name == "DefReportFileName")
                    {
                        GenConfig.DefReportFileName = element.Value;
                    }
                    if (element.Name == "CsvSeparator")
                    {
                        GenConfig.CsvSeparator = element.Value;
                    }
                    if (element.Name == "IsAlarmLog")
                    {
                        GenConfig.IsAlarmLog = element.Value;
                    }
                    if (element.Name == "IsEventLog")
                    {
                        GenConfig.IsEventLog = element.Value;
                    }
                    if (element.Name == "IsVirtualKeyBoard")
                    {
                        GenConfig.IsVirtualKeyBoard = element.Value;
                    }
                }

                //ConnConfig Nodes Params
                var sqlConnConfigElements = xml.Root.Element("SqlConnConfig").Descendants();
                foreach (var element in sqlConnConfigElements)
                {
                    if (element.Name == "SqlServerIP")
                    {
                        SqlConnConfig.SqlServerIP = element.Value;
                    }
                    if (element.Name == "SqlServerName")
                    {
                        SqlConnConfig.SqlServerName = element.Value;
                    }
                    if (element.Name == "SqlDbName")
                    {
                        SqlConnConfig.SqlDbName = element.Value;
                    }
                    if (element.Name == "SqlUserID")
                    {
                        SqlConnConfig.SqlUserID = element.Value;
                    }
                    if (element.Name == "SqlUserPWD")
                    {
                        SqlConnConfig.SqlUserPWD = element.Value;
                    }
                    if (element.Name == "SqlDateTimeFormat")
                    {
                        SqlConnConfig.SqlDateTimeFormat = element.Value;
                    }
                }

                //Build Connection String
                SqlConnConfig.SqlConnectionString = $"Server = {SqlConnConfig.SqlServerIP}\\{SqlConnConfig.SqlServerName}; Database = {SqlConnConfig.SqlDbName}; UID = {SqlConnConfig.SqlUserID}; PWD = {SqlConnConfig.SqlUserPWD}";

                //TableConfig Nodes Params
                var sqlTableConfigElements = xml.Root.Element("SqlTableConfig").Descendants();
                foreach (var element in sqlTableConfigElements)
                {
                    SqlTable sqlTable = new SqlTable();
                    sqlTable.TableType = element.Name.ToString();
                    sqlTable.TableName = element.Value.ToString();

                    SqlTableConfig.SqlTables.Add(sqlTable);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("AppConfig.GetAppConfigXML - xml Load Failed", ex.InnerException);
            }
        }

        public void GetLogVarConfig(string path)
        {
            try
            {
                XDocument xml = XDocument.Load(path);
                var config = xml.Root.Elements("Var");
                foreach (var element in config)
                {                                                                                                                
                    LogVar logVar = new LogVar();
                    logVar.ColName = element.Element("ColName").Value;
                    logVar.VarType = element.Element("VarType").Value;
                    logVar.DefShow = element.Element("DefShow").Value;
                    logVar.DefPlot = element.Element("DefPlot").Value;
                    logVar.DefReport = element.Element("DefReport").Value;
                    logVar.PlotColor = element.Element("PlotColor").Value;
                    logVar.VarText_IT = element.Element("VarText_IT").Value;
                    logVar.VarText_EN = element.Element("VarText_EN").Value;
                    logVar.VarText_FR = element.Element("VarText_FR").Value;
                    logVar.VarText_DE = element.Element("VarText_DE").Value;
                    logVar.VarText_ES = element.Element("VarText_ES").Value;

                    LogVarConfig.LogVar.Add(logVar);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("AppConfig.GetAlarmConfigXML - xml Load Failed", ex.InnerException);
            }
        }

        public void GetAlarmsConfigXML(string path)
        {
            try
            {
                XDocument xml = XDocument.Load(path);
                var config = xml.Root.Elements("Alarm");
                foreach (var element in config)
                {
                    LogAlarm logAlarm = new LogAlarm();
                    logAlarm.AlarmTag = element.Element("AlarmTag").Value;
                    logAlarm.AlarmText_IT = element.Element("AlarmText_IT").Value;
                    logAlarm.AlarmText_EN = element.Element("AlarmText_EN").Value;
                    logAlarm.AlarmText_FR = element.Element("AlarmText_FR").Value;
                    logAlarm.AlarmText_DE = element.Element("AlarmText_DE").Value;
                    logAlarm.AlarmText_ES = element.Element("AlarmText_FR").Value;

                    AlarmConfig.Alarms.Add(logAlarm);
                }
            }
            catch(Exception ex)
            {
                throw new Exception("AppConfig.GetAlarmConfigXML - xml Load Failed", ex.InnerException);
            }
        }

        public void GetEventsConfigXML(string path)
        {
            try
            {
                XDocument xml = XDocument.Load(path);
                var config = xml.Root.Elements("Event");
                foreach (var element in config)
                {
                    LogEvent logEvent = new LogEvent();

                    logEvent.EventTag = element.Element("EventTag").Value;
                    logEvent.EventText_IT = element.Element("EventText_IT").Value;
                    logEvent.EventText_EN = element.Element("EventText_EN").Value;
                    logEvent.EventText_FR = element.Element("EventText_FR").Value;
                    logEvent.EventText_DE = element.Element("EventText_DE").Value;
                    logEvent.EventText_ES = element.Element("EventText_ES").Value;

                    EventsConfig.Events.Add(logEvent);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("AppConfig.GetEventsConfigXML - xml Load Failed", ex.InnerException);
            }
        }
    }
}
