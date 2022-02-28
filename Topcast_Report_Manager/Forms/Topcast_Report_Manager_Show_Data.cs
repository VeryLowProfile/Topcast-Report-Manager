using System;
using System.Data;
using System.Resources;
using System.Reflection;
using System.Globalization;
using System.Collections.Generic;
using System.Windows.Forms;
using Topcast_Report_Manager.Workers;

namespace Topcast_Report_Manager.Forms
{
    public partial class Topcast_Report_Manager_Show_Data : Form
    {
        public Topcast_Report_Manager_Main MainForm { get; set; }
        public List<(string colName, string selectedText)> ShowPivot { get; set; }
        public List<(string colName, string selectedText)> HidePivot { get; set; }

        public Topcast_Report_Manager_Show_Data(Topcast_Report_Manager_Main mainForm)
        {
            InitializeComponent();

            MainForm = mainForm;
            MainForm.changeLenguage += buttonChangeLenguage_Click;

            ShowPivot = new List<(string colName, string selectedText)>();
            HidePivot = new List<(string colName, string selectedText)>();
        }

        private void Topcast_Report_Manager_Show_Data_Load(object sender, EventArgs e)
        {
            //Fill ID Combobox
            comboBoxIDList.Items.AddRange(Topcast_Report_Manager_Main.SelectedData.SelectedIDs.ToArray());
            comboBoxIDList.Text = comboBoxIDList.Items[0].ToString();

            //Set Current Lenguage
            ChangeLenguage();

            //Fill ListBoxes 
            Fillpivot();
            FillList();
            SetButtonsVisibility();
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            int firtsSelectedIndex = 0;

            if (listBoxHide.SelectedIndices != null)
            {
                firtsSelectedIndex = listBoxHide.SelectedIndices[0];

                foreach (int index in listBoxHide.SelectedIndices)
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
            SetListSelection(listBoxHide, firtsSelectedIndex);

            SetButtonsVisibility();

        }

        private void buttonHide_Click(object sender, EventArgs e)
        {
            int firtsSelectedIndex = 0;

            if (listBoxShow.SelectedIndices != null)
            {
                firtsSelectedIndex = listBoxShow.SelectedIndices[0];

                foreach (int index in listBoxShow.SelectedIndices)
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
            SetListSelection(listBoxShow, firtsSelectedIndex);

            SetButtonsVisibility();
        }

        private void buttonShowAll_Click(object sender, EventArgs e)
        {
            SetAllToShow();
            SetButtonsVisibility();
        }

        private void buttonHideAll_Click(object sender, EventArgs e)
        {
            SetAllToHide();
            SetButtonsVisibility();
        }

        private async void buttonShowData_Click(object sender, EventArgs e)
        {
            string qry = SqlQryBuilder.BuildShowDataQry(ShowPivot, Topcast_Report_Manager_Main.AppConfig, comboBoxIDList.Text);
            DataTable dataTable = new DataTable();

            try
            {
                dataTable = await Topcast_Report_Manager_Main.SqlManagement.SqlExecuteQueryAsync(qry);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            dataGridViewShowData.DataSource = null;
            dataGridViewShowData.DataSource = dataTable;
            dataGridViewShowData.Update();

        }

        public void buttonChangeLenguage_Click(object sender, EventArgs e)
        {
            ChangeLenguage();
            Fillpivot();
            FillList();
            SetButtonsVisibility();
        }

        private void Fillpivot()
        {

            HidePivot.Clear();
            ShowPivot.Clear();

            foreach (var logVar in Topcast_Report_Manager_Main.AppConfig.LogVarConfig.LogVar)
            {
                if (logVar.ColName != "BatchID" && logVar.ColName != "DateTime")
                {
                    if (logVar.DefShow == "True")
                    {
                        (string colName, string selectedText) pivot;
                        pivot.colName = logVar.ColName;
                        pivot.selectedText = logVar.SelectedText;
                        ShowPivot.Add(pivot);
                    }
                    else if (logVar.DefShow == "False")
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
            listBoxShow.Items.Clear();
            listBoxHide.Items.Clear();

            foreach (var pivot in ShowPivot)
            {
                foreach(var logVar in Topcast_Report_Manager_Main.AppConfig.LogVarConfig.LogVar)
                {
                    if (pivot.colName == logVar.ColName)
                    {
                        listBoxShow.Items.Add(pivot.selectedText);
                    }
                }
            }

            foreach (var pivot in HidePivot)
            {
                foreach (var logVar in Topcast_Report_Manager_Main.AppConfig.LogVarConfig.LogVar)
                {
                    if (pivot.colName == logVar.ColName)
                    {
                        listBoxHide.Items.Add(pivot.selectedText);
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

        private void SetButtonsVisibility()
        {
            if (ShowPivot.Count <= 0)
            {
                buttonHide.Visible = false;
                buttonHideAll.Visible = false;
                buttonShowData.Visible = false;
            }
            else
            {
                buttonHide.Visible = true;
                buttonHideAll.Visible = true;
                buttonShowData.Visible = true;
            }
            if (HidePivot.Count <= 0)
            {
                buttonShow.Visible = false;
                buttonShowAll.Visible = false;
            }
            else
            {
                buttonShow.Visible = true;
                buttonShowAll.Visible = true;
            }
        }

        private void SetShowToHide(int selectedIndex)
        {
            foreach(var logVar in Topcast_Report_Manager_Main.AppConfig.LogVarConfig.LogVar)
            {
                if (logVar.ColName == ShowPivot[selectedIndex].colName)
                {
                    logVar.DefShow = "False";
                }
            }
        }

        private void SetHideToShow(int selectedIndex)
        {
            foreach (var logVar in Topcast_Report_Manager_Main.AppConfig.LogVarConfig.LogVar)
            {
                if (logVar.ColName == HidePivot[selectedIndex].colName)
                {
                    logVar.DefShow = "True";
                }
            }
        }

        private void SetAllToHide()
        {
            foreach (var logVar in Topcast_Report_Manager_Main.AppConfig.LogVarConfig.LogVar)
            {
                logVar.DefShow = "False";
            }

            Fillpivot();
            FillList();

        }

        private void SetAllToShow()
        {
            foreach (var logVar in Topcast_Report_Manager_Main.AppConfig.LogVarConfig.LogVar)
            {
                logVar.DefShow = "True";
            }

            Fillpivot();
            FillList();

        }

        public void ChangeLenguage()
        {
            ResourceManager resourceManager = new ResourceManager($"Topcast_Report_Manager.Properties.Resource", Assembly.GetExecutingAssembly());
            CultureInfo ci = new CultureInfo(Topcast_Report_Manager_Main.AppConfig.GenConfig.DefLenguage);

            labelSelectID.Text = resourceManager.GetString("LBL_SELECT_ID", ci);
            buttonShow.Text = resourceManager.GetString("BTN_SHOW", ci);
            buttonShowAll.Text = resourceManager.GetString("BTN_SHOW_ALL", ci);
            buttonHideAll.Text = resourceManager.GetString("BTN_HIDE_ALL", ci);
            buttonHide.Text = resourceManager.GetString("BTN_HIDE", ci);
            buttonShowData.Text = resourceManager.GetString("BTN_SHOW_DATA", ci);
        }
    }
}
