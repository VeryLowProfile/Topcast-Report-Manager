using System;
using System.IO;
using System.Data;
using System.Drawing;
using System.Resources;
using System.Threading.Tasks;
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
        public Topcast_Report_Manager_Report_Print_Status PrintStatusForm { get; set; }
        public List<string> ShowID { get; set; }
        public List<string> HideID { get; set; }
        public List<(string colName, string selectedText)> ShowPivot { get; set; }
        public List<(string colName, string selectedText)> HidePivot { get; set; }
        
        private string folderPath = "";
        private RichTextBox richTextBox;
        private ProgressBar progressBar;

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

            if (listBoxIDHide.SelectedItems.Count != 0)
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

            if (listBoxIDShow.SelectedItems.Count != 0)
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

            if (listBoxVarHide.SelectedIndices.Count != 0)
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

            if (listBoxVarShow.SelectedIndices.Count != 0)
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

        public void buttonChangeLenguage_Click(object sender, EventArgs e)
        {
            ChangeLenguage();
            Fillpivot();
            FillList();
            FillIdList();

            SetButtonsVisibility();
            SetIdButtonVisibility();
        }

        private async void buttonPrint_Click(object sender, EventArgs e)
        {

            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.SelectedPath = Topcast_Report_Manager_Main.AppConfig.GenConfig.DefReportPath;
            DialogResult result = folderBrowserDialog.ShowDialog();

            if (result == DialogResult.OK)
            {

                //Get Main Folder path
                folderPath = folderBrowserDialog.SelectedPath;

                //Create handle to print status Form
                PrintStatusForm = new Topcast_Report_Manager_Report_Print_Status();
                richTextBox = (RichTextBox)PrintStatusForm.Controls[0].Controls[0];
                progressBar = (ProgressBar)PrintStatusForm.Controls[0].Controls[1];
                PrintStatusForm.StartPosition = FormStartPosition.CenterScreen;
                PrintStatusForm.FormBorderStyle = FormBorderStyle.None;
                PrintStatusForm.Show(this);

                //Calculate progress bar
                calculateProgressBar();

                //Print Main Folder Path
                richTextBox.Invoke((Action)(() => updateRichTextBox($"Report folder path is {folderPath}", Color.Black)));

                //Create task list 
                List<Task> printTaskList = new List<Task>();
                printTaskList.Add(Task.Run(() => createReportFolders()));
                printTaskList.Add(Task.Run(() => logVarReport()));
                if (Topcast_Report_Manager_Main.AppConfig.GenConfig.IsAlarmLog == "True")
                {
                    printTaskList.Add(Task.Run(() => alarmReport()));
                }
                if (Topcast_Report_Manager_Main.AppConfig.GenConfig.IsAlarmLog == "True")
                {
                    printTaskList.Add(Task.Run(() => eventReport()));
                }

                //Wait all task to complete
                await Task.WhenAll(printTaskList);

                //Close Print Status window
                richTextBox.Invoke((Action)(() => updateRichTextBox($"ALL DONE!", Color.Black)));
                PrintStatusForm.FormBorderStyle = FormBorderStyle.Sizable;
            }
        }

        public void createReportFolders()
        {
            foreach (string id in ShowID)
            {

                if (!Directory.Exists(folderPath + @"\" + id))
                {
                    Directory.CreateDirectory(folderPath + @"\" + id);

                    //update progress bar
                    progressBar.Invoke((Action)(() => incrementProgressBar()));

                    //update status form rich text box
                    richTextBox.Invoke((Action)(() => updateRichTextBox($"{id} Folder created", Color.Black)));

                } else {

                    //update status form rich text box
                    richTextBox.Invoke((Action)(() => updateRichTextBox($"{id} Folder already exist", Color.Black)));
                }
            }
        }

        public void logVarReport()
        {
            foreach (string id in ShowID)
            {
                string logVarfilePath = folderPath + @"\" + id + @"\" + Topcast_Report_Manager_Main.AppConfig.GenConfig.DefReportFileName.Replace("@SUB@", $"LOGVAR_{id}");
                string logVarQry = SqlQryBuilder.BuildReportLogVarQry(ShowPivot, Topcast_Report_Manager_Main.AppConfig, id);
                DataTable logVarTable = new DataTable();

                try
                {
                    logVarTable = Topcast_Report_Manager_Main.SqlManagement.SqlExecuteQuery(logVarQry);
                    ExportManagement.ExportDataTableToCSV(logVarTable, logVarfilePath, Topcast_Report_Manager_Main.AppConfig.GenConfig.CsvSeparator);

                    //update progress bar
                    progressBar.Invoke((Action)(() => incrementProgressBar()));

                    //update status form rich text box
                    richTextBox.Invoke((Action)(() => updateRichTextBox($"{id} LogVar report created", Color.Black)));

                }
                catch (Exception ex)
                {

                    //update status form rich text box
                    richTextBox.Invoke((Action)(() => updateRichTextBox($"{id} LogVar report exception {ex.Message}", Color.Black)));
                
                }
            }
        }

        public void alarmReport()
        {
            foreach (string id in ShowID)
            {
                string alarmsfilePath = folderPath + @"\" + id + @"\" + Topcast_Report_Manager_Main.AppConfig.GenConfig.DefReportFileName.Replace("@SUB@", $"ALARMS_{id}");
                string alarmQry = SqlQryBuilder.BuildAlarmsQry(Topcast_Report_Manager_Main.AppConfig, Topcast_Report_Manager_Main.SelectedData, id);
                DataTable alarmTable = new DataTable();

                try
                {
                    alarmTable = Topcast_Report_Manager_Main.SqlManagement.SqlExecuteQuery(alarmQry);
                    ExportManagement.ExportDataTableToCSV(DataTableManagement.GetDataTableAlarmsXref(Topcast_Report_Manager_Main.AppConfig, alarmTable), alarmsfilePath, Topcast_Report_Manager_Main.AppConfig.GenConfig.CsvSeparator);

                    //update progress bar
                    progressBar.Invoke((Action)(() => incrementProgressBar()));

                    //update status form rich text box
                    richTextBox.Invoke((Action)(() => updateRichTextBox($"{id} Alarm report created", Color.Black)));
                }
                catch (Exception ex)
                {

                    //update status form rich text box
                    richTextBox.Invoke((Action)(() => updateRichTextBox($"{id} Alarm report exception {ex.Message}", Color.Black)));

                }
            }
        }

        public void eventReport()
        {
            foreach (string id in ShowID)
            {
                string eventsfilePath = folderPath + @"\" + id + @"\" + Topcast_Report_Manager_Main.AppConfig.GenConfig.DefReportFileName.Replace("@SUB@", $"EVENTS_{id}");
                string eventQry = SqlQryBuilder.BuildEventsQry(Topcast_Report_Manager_Main.AppConfig, Topcast_Report_Manager_Main.SelectedData, id);
                DataTable eventTable = new DataTable();

                try
                {
                    eventTable = Topcast_Report_Manager_Main.SqlManagement.SqlExecuteQuery(eventQry);
                    ExportManagement.ExportDataTableToCSV(DataTableManagement.GetDataTableEventsXref(Topcast_Report_Manager_Main.AppConfig, eventTable), eventsfilePath, Topcast_Report_Manager_Main.AppConfig.GenConfig.CsvSeparator);

                    //update progress bar
                    progressBar.Invoke((Action)(() => incrementProgressBar()));

                    //update status form rich text box
                    richTextBox.Invoke((Action)(() => updateRichTextBox($"{id} Event report created", Color.Black)));

                }
                catch (Exception ex)
                {

                    //update status form rich text box
                    richTextBox.Invoke((Action)(() => updateRichTextBox($"{id} Event report exception {ex.Message}", Color.Black)));

                }
            }
        }

        public void calculateProgressBar()
        {
            progressBar.Minimum = 0;
            progressBar.Maximum = 0;

            //Add number of folder to be created
            progressBar.Maximum += ShowID.Count;

            //Add number of var log to be printed
            progressBar.Maximum += ShowID.Count;

            //Add number of alarm log to print
            if (Topcast_Report_Manager_Main.AppConfig.GenConfig.IsAlarmLog == "True")
            {
                progressBar.Maximum += ShowID.Count;
            }

            //Add number of event log to print
            if (Topcast_Report_Manager_Main.AppConfig.GenConfig.IsAlarmLog == "True")
            {
                progressBar.Maximum += ShowID.Count;
            }
        }

        private void incrementProgressBar()
        {
            progressBar.Increment(1);
        }

        private void updateRichTextBox(string text, Color color)
        {
            richTextBox.AppendText(text + "\n");
            richTextBox.ScrollToCaret();
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


