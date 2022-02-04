using System;
using System.Data;
using System.Resources;
using System.Reflection;
using System.Globalization;
using System.Windows.Forms;
using System.Collections.Generic;
using Topcast_Report_Manager.Workers;

namespace Topcast_Report_Manager.Forms
{
    public partial class Topcast_Report_Manager_Show_Alarms_Events : Form
    {
        public Topcast_Report_Manager_Main MainForm { get; set; }

        public Topcast_Report_Manager_Show_Alarms_Events(Topcast_Report_Manager_Main mainForm)
        {
            InitializeComponent();

            MainForm = mainForm;
            MainForm.changeLenguage += buttonChangeLenguage_Click;
        }

        private void Topcast_Report_Manager_Show_Alarms_Events_Load(object sender, EventArgs e)
        {
            List<string> selectedIDs = new List<string>();
            selectedIDs = Topcast_Report_Manager_Main.SelectedData.SelectedIDs;

            //Fill ID Combobox
            comboBoxIDList.Items.AddRange(selectedIDs.ToArray());
            comboBoxIDList.Text = comboBoxIDList.Items[0].ToString();

            //Set If no Events 
            if (Topcast_Report_Manager_Main.AppConfig.GenConfig.IsEventLog != "True")
            {
                dataGridViewEvents.Dispose();
                tableLayoutPanel.RowCount = tableLayoutPanel.RowCount - 1;
            }

            //Set Current Lenguage
            ChangeLenguage();
        }

        private async void buttonShow_Click(object sender, EventArgs e)
        {
            List<string> selectedIDs = new List<string>();
            selectedIDs = Topcast_Report_Manager_Main.SelectedData.SelectedIDs;

            foreach (string selectedID in selectedIDs)
            {
                DateTime begin = DateTime.Now;
                DateTime end = DateTime.Now;
                (string, DateTime, DateTime) idBeginEnd;
                string qryBegin;
                string qryEnd;
                DataTable dataTableBegin = new DataTable();
                DataTable dataTableEnd = new DataTable();

                qryBegin = SqlQryBuilder.BuildIdBegindate(Topcast_Report_Manager_Main.AppConfig, selectedID);
                qryEnd = SqlQryBuilder.BuildIdEnddate(Topcast_Report_Manager_Main.AppConfig, selectedID);

                try
                {
                    dataTableBegin = await SqlManagement.SqlExecuteQueryAsync(Topcast_Report_Manager_Main.AppConfig.SqlConnConfig.SqlConnectionString, qryBegin);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                try
                {
                    dataTableEnd = await SqlManagement.SqlExecuteQueryAsync(Topcast_Report_Manager_Main.AppConfig.SqlConnConfig.SqlConnectionString, qryEnd);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                try
                {
                    begin = DataTableManagement.GetRowColValue<DateTime>(dataTableBegin, 0, 0);
                    end = DataTableManagement.GetRowColValue<DateTime>(dataTableEnd, 0, 0);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                idBeginEnd = (selectedID, begin, end);

                Topcast_Report_Manager_Main.SelectedData.IDsBeginEnd.Add(idBeginEnd);
            }

            string alarmQry = SqlQryBuilder.BuildAlarmsQry(Topcast_Report_Manager_Main.AppConfig, Topcast_Report_Manager_Main.SelectedData, comboBoxIDList.Text);
            DataTable alarmTable = new DataTable();

            try
            {
                alarmTable = await SqlManagement.SqlExecuteQueryAsync(Topcast_Report_Manager_Main.AppConfig.SqlConnConfig.SqlConnectionString, alarmQry);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            dataGridViewAlarms.DataSource = DataTableManagement.GetDataTableAlarmsXref(Topcast_Report_Manager_Main.AppConfig, alarmTable);
            dataGridViewAlarms.Update();

            if (Topcast_Report_Manager_Main.AppConfig.GenConfig.IsEventLog == "True")
            {
                string eventQry = SqlQryBuilder.BuildEventsQry(Topcast_Report_Manager_Main.AppConfig, Topcast_Report_Manager_Main.SelectedData, comboBoxIDList.Text);
                DataTable eventTable = new DataTable();

                try
                {
                    eventTable = await SqlManagement.SqlExecuteQueryAsync(Topcast_Report_Manager_Main.AppConfig.SqlConnConfig.SqlConnectionString, eventQry);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                dataGridViewEvents.DataSource = DataTableManagement.GetDataTableEventsXref(Topcast_Report_Manager_Main.AppConfig, eventTable);
                dataGridViewEvents.Update();

            }
        }

        public void buttonChangeLenguage_Click(object sender, EventArgs e)
        {
            ChangeLenguage();
        }

        public void ChangeLenguage()
        {
            ResourceManager resourceManager = new ResourceManager($"Topcast_Report_Manager.Properties.Resource", Assembly.GetExecutingAssembly());
            CultureInfo ci = new CultureInfo(Topcast_Report_Manager_Main.AppConfig.GenConfig.DefLenguage);

            labelSelectID.Text = resourceManager.GetString("LBL_SELECT_ID", ci);
            buttonShow.Text = resourceManager.GetString("BTN_SHOW_ALARMS_EVENTS", ci);
        }
    }
}
