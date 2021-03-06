using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using System.Resources;
using System.Reflection;
using System.Globalization;
using System.Data;
using Topcast_Report_Manager.Workers;
using Topcast_Report_Manager.Data;

namespace Topcast_Report_Manager.Forms
{
    public partial class Topcast_Report_Manager_Main : Form
    {

        private Form activeForm;
        public static AppConfig AppConfig { get; set; }
        public static SearchParam SearchParam { get; set; }
        public static SelectedData SelectedData { get; set; }

        public static SqlManagement SqlManagement { get; set; }

        public event EventHandler changeLenguage;

        public Topcast_Report_Manager_Main()
        {
            InitializeComponent();

            AppConfig = new AppConfig();
            SearchParam = new SearchParam();
            SelectedData = new SelectedData();
        }

        private void Topcast_Report_Manager_Main_Load(object sender, EventArgs e)
        {
            //Check if AppConfig.xml exist
            if (File.Exists("AppConfig.xml"))
            {
                try
                {
                    //Read AppConfig.xml
                    AppConfig.GetAppConfigXML(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) + @"\AppConfig.xml");

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Topcast_Report_Manager_Main_Load: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("AppConfig.xml file not found", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            //Check if main Apponfig is loaded ok and proceed with other parameters
            if (AppConfig.AppconfigOk)
            {
                //Check if LogVarConfig.xml Exist
                if (File.Exists("LogVarConfig.xml"))
                {
                    try
                    {
                        //Read LogVarConfig.xml
                        AppConfig.GetLogVarConfig(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) + @"\LogVarConfig.xml");

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Topcast_Report_Manager_Main_Load: {ex.Message}");
                    }
                }
                else
                {
                    MessageBox.Show("LogVarConfig.xml file not found", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                //Cehck if need to load AlarmsConfig.xml
                if (AppConfig.GenConfig.IsAlarmLog == "True")
                {
                    //Check if AlarmsConfig.xml Exist
                    if (File.Exists("AlarmsConfig.xml"))
                    {
                        try
                        {
                            //Read AlarmsConfig.xml
                            AppConfig.GetAlarmsConfigXML(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) + @"\AlarmsConfig.xml");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Topcast_Report_Manager_Main_Load: {ex.Message}");
                        }
                    }
                    else
                    {
                        MessageBox.Show("AlarmsConfig.xml file not found", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }

                //Cehck if need to load EventsConfig.xml
                if (AppConfig.GenConfig.IsEventLog == "True")
                {
                    //Check if EventsConfig.xml Exist
                    if (File.Exists("EventsConfig.xml"))
                    {
                        try
                        {
                            //Read AlarmsConfig.xml
                            AppConfig.GetEventsConfigXML(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) + @"\EventsConfig.xml");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Topcast_Report_Manager_Main_Load: {ex.Message}");
                        }
                    }
                    else
                    {
                        MessageBox.Show("EventsConfig.xml file not found", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }

                //Apply App configuration
                //*******************************************************************************************************************

                //Change screen size
                try
                {
                    if (AppConfig.GenConfig.FullScreen == "True")
                    {
                        WindowState = FormWindowState.Maximized;
                    }
                    else
                    {
                        Size = new Size(int.Parse(AppConfig.GenConfig.MainFormWidth), int.Parse(AppConfig.GenConfig.MainFormHeight));
                        panelChildform.Size = new Size(int.Parse(AppConfig.GenConfig.ChildFormWidth), int.Parse(AppConfig.GenConfig.ChildFormHeight));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Topcast_Report_Manager_Main_Load - Change screen size: {ex.Message}");
                }

                //Set visibility of alarm/Events button
                if (AppConfig.GenConfig.IsAlarmLog == "True" || AppConfig.GenConfig.IsEventLog == "True")
                {
                    buttonOpenShowAlarmsEvents.Visible = true;
                }
                else
                {
                    buttonOpenShowAlarmsEvents.Visible = false;
                }

                //Show Connection String
                labelConnectionString.Text = $"Connection String: {AppConfig.SqlConnConfig.SqlConnectionString}";

                //Set Current Lenguage
                ChangeLenguage();
                SelectActualVarLenguage();

                //Open Search Form as default
                FormVisualizationManagement.CloseForm(activeForm);
                activeForm = FormVisualizationManagement.OpenFormInPanel(new Topcast_Report_Manager_Search(this), panelChildform);


                //Create SqlManagement Instance
                //*******************************************************************************************************************
                SqlManagement = new SqlManagement(AppConfig.SqlConnConfig);

                //Test Sql connection
                //*******************************************************************************************************************
                labelConnectionCheck.Text = SqlManagement.SqlTestConnection();

                //Get Db Usage
                //*******************************************************************************************************************
                labelDbUsage.Text = SqlManagement.SqlGetDbUsage();

            }
        }
                    
             

        //            //Connection Test
        //            if (AppConfig.SqlConnConfig.SqlConnectionString != "")
        //            {
        //                try
        //                {
        //                    SqlManagement.SqlTestConnection(AppConfig.SqlConnConfig.SqlConnectionString);
        //                    DataTable dt = new DataTable();
        //                    dt = SqlManagement.SqlGetDbUsage(AppConfig.SqlConnConfig.SqlConnectionString);
        //                    labelConnectionCheck.Text = $"CONNECTION OK \n" +
        //                                                $"{dt.Columns[0].ColumnName} {dt.Rows[0][0]}\n" +
        //                                                $"{dt.Columns[1].ColumnName} {dt.Rows[0][1]}\n" +
        //                                                $"{dt.Columns[2].ColumnName} {dt.Rows[0][2]}";
        //                }
        //                catch (Exception ex)
        //                {                           
        //                    throw new Exception("Topcast_Report_Manager_Main_Load - Sql test connection fail " + ex.Message);                           
        //                }
        //            }          


        private void buttonOpenSearch_Click(object sender, EventArgs e)
        {
            FormVisualizationManagement.CloseForm(activeForm);
            activeForm = FormVisualizationManagement.OpenFormInPanel(new Topcast_Report_Manager_Search(this), panelChildform);
        }

        private void buttonOpenShowData_Click(object sender, EventArgs e)
        {
            if (SelectedData.SelectedIDs.Count > 0)
            {
                FormVisualizationManagement.CloseForm(activeForm);
                activeForm = FormVisualizationManagement.OpenFormInPanel(new Topcast_Report_Manager_Show_Data(this), panelChildform);
            }
            else
            {
                MessageBox.Show("No ID Selected", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void buttonOpenShowTrend_Click(object sender, EventArgs e)
        {
            if (SelectedData.SelectedIDs.Count > 0)
            {   
                FormVisualizationManagement.CloseForm(activeForm);
                activeForm = FormVisualizationManagement.OpenFormInPanel(new Topcast_Report_Manager_Show_Trend(this), panelChildform);
            }
            else
            {
                MessageBox.Show("No ID Selected", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void buttonOpenShowAlarmsEvents_Click(object sender, EventArgs e)
        {
            if (SelectedData.SelectedIDs.Count > 0)
            {
                FormVisualizationManagement.CloseForm(activeForm);
                activeForm = FormVisualizationManagement.OpenFormInPanel(new Topcast_Report_Manager_Show_Alarms_Events(this), panelChildform);
            }
            else
            {
                MessageBox.Show("No ID Selected", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void buttonOpenReport_Click(object sender, EventArgs e)
        {
            if (SelectedData.SelectedIDs.Count > 0)
            {
                FormVisualizationManagement.CloseForm(activeForm);
                activeForm = FormVisualizationManagement.OpenFormInPanel(new Topcast_Report_Manager_Report(this), panelChildform);
            }
            else
            {
                MessageBox.Show("No ID Selected", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void SelectActualVarLenguage()
        {
            foreach (var logVar in AppConfig.LogVarConfig.LogVar)
            {
                if (AppConfig.GenConfig.DefLenguage == "IT")
                {
                    logVar.SelectedText = logVar.VarText_IT;
                }
                if (AppConfig.GenConfig.DefLenguage == "EN")
                {
                    logVar.SelectedText = logVar.VarText_EN;
                }
                if (AppConfig.GenConfig.DefLenguage == "FR")
                {
                    logVar.SelectedText = logVar.VarText_FR;
                }
                if (AppConfig.GenConfig.DefLenguage == "DE")
                {
                    logVar.SelectedText = logVar.VarText_DE;
                }
                if (AppConfig.GenConfig.DefLenguage == "ES")
                {
                    logVar.SelectedText = logVar.VarText_ES;
                }
            }

            foreach (var alarm in AppConfig.AlarmConfig.Alarms)
            {
                if (AppConfig.GenConfig.DefLenguage == "IT")
                {
                    alarm.SelectedText = alarm.AlarmText_IT;
                }
                if (AppConfig.GenConfig.DefLenguage == "EN")
                {
                    alarm.SelectedText = alarm.AlarmText_EN;
                }
                if (AppConfig.GenConfig.DefLenguage == "FR")
                {
                    alarm.SelectedText = alarm.AlarmText_FR;
                }
                if (AppConfig.GenConfig.DefLenguage == "DE")
                {
                    alarm.SelectedText = alarm.AlarmText_DE;
                }
                if (AppConfig.GenConfig.DefLenguage == "ES")
                {
                    alarm.SelectedText = alarm.AlarmText_ES;
                }
            }

            foreach (var logEvent in AppConfig.EventsConfig.Events)
            {
                if (AppConfig.GenConfig.DefLenguage == "IT")
                {
                    logEvent.SelectedText = logEvent.EventText_IT;
                }
                if (AppConfig.GenConfig.DefLenguage == "EN")
                {
                    logEvent.SelectedText = logEvent.EventText_EN;
                }
                if (AppConfig.GenConfig.DefLenguage == "FR")
                {
                    logEvent.SelectedText = logEvent.EventText_FR;
                }
                if (AppConfig.GenConfig.DefLenguage == "DE")
                {
                    logEvent.SelectedText = logEvent.EventText_DE;
                }
                if (AppConfig.GenConfig.DefLenguage == "ES")
                {
                    logEvent.SelectedText = logEvent.EventText_ES;
                }
            }
        }

        private void button_IT_Click(object sender, EventArgs e)
        {
            AppConfig.GenConfig.DefLenguage = "IT";
            SelectActualVarLenguage();
            ChangeLenguage();
            OnChangeLenguage();
        }

        private void button_EN_Click(object sender, EventArgs e)
        {
            AppConfig.GenConfig.DefLenguage = "EN";
            SelectActualVarLenguage();
            ChangeLenguage();
            OnChangeLenguage();
        }

        private void button_FR_Click(object sender, EventArgs e)
        {
            AppConfig.GenConfig.DefLenguage = "FR";
            SelectActualVarLenguage();
            ChangeLenguage();
            OnChangeLenguage();
        }

        private void button_DE_Click(object sender, EventArgs e)
        {
            AppConfig.GenConfig.DefLenguage = "DE";
            SelectActualVarLenguage();
            ChangeLenguage();
            OnChangeLenguage();
        }

        private void button_ES_Click(object sender, EventArgs e)
        {
            AppConfig.GenConfig.DefLenguage = "ES";
            SelectActualVarLenguage();
            ChangeLenguage();
            OnChangeLenguage();
        }

        public void ChangeLenguage()
        {
            ResourceManager resourceManager = new ResourceManager($"Topcast_Report_Manager.Properties.Resource", Assembly.GetExecutingAssembly());
            CultureInfo ci = new CultureInfo(AppConfig.GenConfig.DefLenguage);

            buttonOpenSearch.Text = resourceManager.GetString("BTN_SEARCH", ci);
            buttonOpenShowData.Text = resourceManager.GetString("BTN_DATA", ci);
            buttonOpenShowTrend.Text = resourceManager.GetString("BTN_TRENDS", ci);
            buttonOpenShowAlarmsEvents.Text = resourceManager.GetString("BTN_ALARMS_EVENTS", ci);
            buttonOpenReport.Text = resourceManager.GetString("BTN_REPORTS", ci);
        }

        private void OnChangeLenguage()
        {
            if (changeLenguage != null)
            {
                changeLenguage(this, EventArgs.Empty);
            }
        }
    }
}
