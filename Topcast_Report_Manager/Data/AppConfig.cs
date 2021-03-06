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
        public bool AppconfigOk { get; set; }
        public bool LogVarConfigOk { get; set; }
        public bool AlarmConfigOk  { get; set; }
        public bool EventsConfigOk { get; set; }


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
                //Load AppConfig.xml
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

                //Read Connection config
                SqlConnConfig.GetConnectionConfig(xml);

                //TableConfig Nodes Params
                SqlTableConfig.GetTableConfig(xml);

                //Set Appconfig as ok if no excepiton
                AppconfigOk = true;

            }
            catch (Exception ex)
            {
                throw new Exception($"AppConfig.GetAppConfigXML: {ex.Message}");
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
                    logVar.UserUnit = element.Element("UserUnit").Value;
                    logVar.VarText_IT = element.Element("VarText_IT").Value;
                    logVar.VarText_EN = element.Element("VarText_EN").Value;
                    logVar.VarText_FR = element.Element("VarText_FR").Value;
                    logVar.VarText_DE = element.Element("VarText_DE").Value;
                    logVar.VarText_ES = element.Element("VarText_ES").Value;

                    LogVarConfig.LogVar.Add(logVar);
                }

                LogVarConfigOk = true;

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

                AlarmConfigOk = true;

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

                EventsConfigOk = true;

            }
            catch (Exception ex)
            {
                throw new Exception("AppConfig.GetEventsConfigXML - xml Load Failed", ex.InnerException);
            }
        }

    }
}
