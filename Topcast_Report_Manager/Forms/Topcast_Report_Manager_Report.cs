using System;
using System.IO;
using System.Data;
using System.Resources;
using System.Reflection;
using System.Globalization;
using System.Collections.Generic;
using System.Windows.Forms;
using Topcast_Report_Manager.Workers;

namespace Topcast_Report_Manager.Forms
{
    public partial class Topcast_Report_Manager_Report : Form
    {
        public Topcast_Report_Manager_Main MainForm { get; set; }
        public List<string> ShowID { get; set; }
        public List<string> HideID { get; set; }
        public List<(string colName, string selectedText)> ShowPivot { get; set; }
        public List<(string colName, string selectedText)> HidePivot { get; set; }

        public Topcast_Report_Manager_Report(Topcast_Report_Manager_Main mainForm)
        {
            InitializeComponent();

            MainForm = mainForm;
            MainForm.changeLenguage += buttonChangeLenguage_Click;

            ShowID = new List<string>();
            HideID = new List<string>();
            ShowPivot = new List<(string colName, string selectedText)>();
            HidePivot = new List<(string colName, string selectedText)>();
        }

        private void Topcast_Report_Manager_Report_Load(object sender, EventArgs e)
        {
            //Fill ShowID List
            ShowID.AddRange(Topcast_Report_Manager_Main.SelectedData.SelectedIDs.ToArray());

            //Set Current Lenguage
            ChangeLenguage();

            //Fill ListBoxes 
            Fillpivot();
            FillList();
            FillIdList();

            SetButtonsVisibility();
            SetIdButtonVisibility();
        }

        private void buttonIDShow_Click(object sender, EventArgs e)
        {
            int firtsSelectedIndex = 0;

            if (listBoxIDHide.SelectedItems != null)
            {
                firtsSelectedIndex = listBoxIDHide.SelectedIndices[0];

                foreach (string item in listBoxIDHide.SelectedItems)
                {
                    MoveIdHideToShow(item);
                }
            }
            else
            {
                MessageBox.Show("No Item Selected", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            FillIdList();
            SetListSelection(listBoxIDHide, firtsSelectedIndex);

            SetIdButtonVisibility();

        }

        private void buttonIDHide_Click(object sender, EventArgs e)
        {
            int firtsSelectedIndex = 0;

            if (listBoxIDShow.SelectedItems != null)
            {
                firtsSelectedIndex = listBoxIDShow.SelectedIndices[0];

                foreach (string item in listBoxIDShow.SelectedItems)
                {
                    MoveIdShowToHide(item);
                }
            }
            else
            {
                MessageBox.Show("No Item Selected", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            FillIdList();
            SetListSelection(listBoxIDShow, firtsSelectedIndex);

            SetIdButtonVisibility();
        }

        private void buttonVarShow_Click(object sender, EventArgs e)
        {
            int firtsSelectedIndex = 0;

            if (listBoxVarHide.SelectedIndices != null)
            {
                firtsSelectedIndex = listBoxVarHide.SelectedIndices[0];

                foreach (int index in listBoxVarHide.SelectedIndices)
                {
                    SetHideToShow(index);
                }

            }
            else
            {
                MessageBox.Show("No Item Selected", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            Fillpivot();
            FillList();
            SetListSelection(listBoxVarHide, firtsSelectedIndex);

            SetButtonsVisibility();
        }

        private void buttonVarHide_Click(object sender, EventArgs e)
        {
            int firtsSelectedIndex = 0;

            if (listBoxVarShow.SelectedIndices != null)
            {
                firtsSelectedIndex = listBoxVarShow.SelectedIndices[0];

                foreach (int index in listBoxVarShow.SelectedIndices)
                {
                    SetShowToHide(index);
                }
            }
            else
            {
                MessageBox.Show("No Item Selected", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            Fillpivot();
            FillList();
            SetListSelection(listBoxVarShow, firtsSelectedIndex);

            SetButtonsVisibility();
        }

        private void buttonVarShowAll_Click(object sender, EventArgs e)
        {
            SetAllToShow();
            SetButtonsVisibility();
        }

        private void buttonVarHideAll_Click(object sender, EventArgs e)
        {
            SetAllToHide();
            SetButtonsVisibility();
        }

        private async void buttonPrint_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.SelectedPath = Topcast_Report_Manager_Main.AppConfig.GenConfig.DefReportPath;
            DialogResult result = folderBrowserDialog.ShowDialog();
            
            if (result == DialogResult.OK)
            {
                foreach (string id in ShowID)
                {   
                    string folderPath = folderBrowserDialog.SelectedPath + @"\" + id;
                    string logVarfilePath = folderPath + @"\" + Topcast_Report_Manager_Main.AppConfig.GenConfig.DefReportFileName.Replace("@SUB@", $"LOGVAR_{id}");

                    if (!Directory.Exists(folderPath))
                    {
                        Directory.CreateDirectory(folderPath);
                    }

                    string logVarQry = SqlQryBuilder.BuildReportLogVarQry(ShowPivot, Topcast_Report_Manager_Main.AppConfig, id);
                    DataTable logVarTable = new DataTable();

                    try
                    {
                        logVarTable = await SqlManagement.SqlExecuteQueryAsync(Topcast_Report_Manager_Main.AppConfig.SqlConnConfig.SqlConnectionString, logVarQry);
                        ExportManagement.ExportDataTableToCSV(logVarTable, logVarfilePath, Topcast_Report_Manager_Main.AppConfig.GenConfig.CsvSeparator);
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message + " LogVar", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                    if (Topcast_Report_Manager_Main.AppConfig.GenConfig.IsAlarmLog == "True")
                    {
                        string alarmsfilePath = folderPath + @"\" + Topcast_Report_Manager_Main.AppConfig.GenConfig.DefReportFileName.Replace("@SUB@", $"ALARMS_{id}");
                        string alarmQry = SqlQryBuilder.BuildAlarmsQry(Topcast_Report_Manager_Main.AppConfig, Topcast_Report_Manager_Main.SelectedData, id);
                        DataTable alarmTable = new DataTable();

                        try
                        {
                            alarmTable = await SqlManagement.SqlExecuteQueryAsync(Topcast_Report_Manager_Main.AppConfig.SqlConnConfig.SqlConnectionString, alarmQry);
                            ExportManagement.ExportDataTableToCSV(DataTableManagement.GetDataTableAlarmsXref(Topcast_Report_Manager_Main.AppConfig, alarmTable), alarmsfilePath, Topcast_Report_Manager_Main.AppConfig.GenConfig.CsvSeparator);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message + " LogAlarms", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }   
                    }

                    if (Topcast_Report_Manager_Main.AppConfig.GenConfig.IsEventLog == "True")
                    {
                        string eventsfilePath = folderPath + @"\" + Topcast_Report_Manager_Main.AppConfig.GenConfig.DefReportFileName.Replace("@SUB@", $"EVENTS_{id}");
                        string eventQry = SqlQryBuilder.BuildEventsQry(Topcast_Report_Manager_Main.AppConfig, Topcast_Report_Manager_Main.SelectedData, id);
                        DataTable eventTable = new DataTable();

                        try
                        {
                            eventTable = await SqlManagement.SqlExecuteQueryAsync(Topcast_Report_Manager_Main.AppConfig.SqlConnConfig.SqlConnectionString, eventQry);
                            ExportManagement.ExportDataTableToCSV(DataTableManagement.GetDataTableEventsXref(Topcast_Report_Manager_Main.AppConfig, eventTable), eventsfilePath, Topcast_Report_Manager_Main.AppConfig.GenConfig.CsvSeparator);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message + " LogEvents", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }                       
                    }
                }
            }
        }

        public void buttonChangeLenguage_Click(object sender, EventArgs e)
        {
            ChangeLenguage();
            Fillpivot();
            FillList();
            FillIdList();

            SetButtonsVisibility();
            SetIdButtonVisibility();
        }

        private void Fillpivot()
        {
            ShowPivot.Clear();
            HidePivot.Clear();

            foreach (var logVar in Topcast_Report_Manager_Main.AppConfig.LogVarConfig.LogVar)
            {
                if (logVar.ColName != "BatchID" && logVar.ColName != "DateTime")
                {
                    if (logVar.DefReport == "True")
                    {
                        (string colName, string selectedText) pivot;
                        pivot.colName = logVar.ColName;
                        pivot.selectedText = logVar.SelectedText;
                        ShowPivot.Add(pivot);
                    }
                    else if (logVar.DefReport == "False")
                    {
                        (string colName, string selectedText) pivot;
                        pivot.colName = logVar.ColName;
                        pivot.selectedText = logVar.SelectedText;
                        HidePivot.Add(pivot);
                    }
                }
            }
        }

        private void FillList()
        {
            listBoxVarShow.Items.Clear();
            listBoxVarHide.Items.Clear();

            foreach (var pivot in ShowPivot)
            {
                foreach (var logVar in Topcast_Report_Manager_Main.AppConfig.LogVarConfig.LogVar)
                {
                    if (pivot.colName == logVar.ColName)
                    {
                        listBoxVarShow.Items.Add(pivot.selectedText);
                    }
                }
            }

            foreach (var pivot in HidePivot)
            {
                foreach (var logVar in Topcast_Report_Manager_Main.AppConfig.LogVarConfig.LogVar)
                {
                    if (pivot.colName == logVar.ColName)
                    {
                        listBoxVarHide.Items.Add(pivot.selectedText);
                    }
                }
            }
        }

        private void SetListSelection(ListBox list, int selectedIndex)
        {
            if (selectedIndex < 0)
            {
                selectedIndex = 0;
            }

            list.SelectedIndex = selectedIndex - 1;
        }

        private void SetShowToHide(int selectedIndex)
        {
            foreach (var logVar in Topcast_Report_Manager_Main.AppConfig.LogVarConfig.LogVar)
            {
                if (logVar.ColName == ShowPivot[selectedIndex].colName)
                {
                    logVar.DefReport = "False";
                }
            }
        }

        private void SetHideToShow(int selectedIndex)
        {
            foreach (var logVar in Topcast_Report_Manager_Main.AppConfig.LogVarConfig.LogVar)
            {
                if (logVar.ColName == HidePivot[selectedIndex].colName)
                {
                    logVar.DefReport = "True";
                }
            }
        }

        private void SetAllToHide()
        {
            foreach (var logVar in Topcast_Report_Manager_Main.AppConfig.LogVarConfig.LogVar)
            {
                logVar.DefReport = "False";
            }

            Fillpivot();
            FillList();

        }

        private void SetAllToShow()
        {
            foreach (var logVar in Topcast_Report_Manager_Main.AppConfig.LogVarConfig.LogVar)
            {
                logVar.DefReport = "True";
            }

            Fillpivot();
            FillList();

        }

        private void SetButtonsVisibility()
        {
            if (ShowPivot.Count <= 0)
            {
                buttonVarHide.Visible = false;
                buttonVarHideAll.Visible = false;
                buttonPrint.Visible = false;
            }
            else
            {
                buttonVarHide.Visible = true;
                buttonVarHideAll.Visible = true;
                buttonPrint.Visible = true;
            }
            if (HidePivot.Count <= 0)
            {
                buttonVarShow.Visible = false;
                buttonVarShowAll.Visible = false;
            }
            else
            {
                buttonVarShow.Visible = true;
                buttonVarShowAll.Visible = true;
            }
        }

        private void FillIdList()
        {
            listBoxIDShow.Items.Clear();
            listBoxIDHide.Items.Clear();

            foreach (var id in ShowID)
            {
                listBoxIDShow.Items.Add(id);
            }

            foreach (var id in HideID)
            {
                listBoxIDHide.Items.Add(id);
            }
        }

        private void MoveIdShowToHide(string item)
        {
            ShowID.Remove(item);
            HideID.Add(item);          
        }

        private void MoveIdHideToShow(string item)
        {
            HideID.Remove(item);
            ShowID.Add(item);
        }

        private void SetIdButtonVisibility()
        {
            if (HideID.Count <= 0)
            {
                buttonIDShow.Visible = false;
            }
            else
            {
                buttonIDShow.Visible = true;
            }
            if (ShowID.Count <= 0)
            {
                buttonIDHide.Visible = false;
            }
            else
            {
                buttonIDHide.Visible = true;
            }
        }

        public void ChangeLenguage()
        {
            ResourceManager resourceManager = new ResourceManager($"Topcast_Report_Manager.Properties.Resource", Assembly.GetExecutingAssembly());
            CultureInfo ci = new CultureInfo(Topcast_Report_Manager_Main.AppConfig.GenConfig.DefLenguage);

            buttonIDShow.Text = resourceManager.GetString("BTN_SHOW", ci);
            buttonIDHide.Text = resourceManager.GetString("BTN_HIDE", ci);
            buttonVarShow.Text = resourceManager.GetString("BTN_SHOW", ci);
            buttonVarShowAll.Text = resourceManager.GetString("BTN_SHOW_ALL", ci);
            buttonVarHideAll.Text = resourceManager.GetString("BTN_HIDE_ALL", ci);
            buttonVarHide.Text = resourceManager.GetString("BTN_HIDE", ci);
            buttonPrint.Text = resourceManager.GetString("BTN_GENERATE_REPORTS", ci);
        }
    }
}


