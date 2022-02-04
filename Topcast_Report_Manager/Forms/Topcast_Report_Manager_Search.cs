using System;
using System.Data;
using System.Resources;
using System.Reflection;
using System.Globalization;
using System.Collections.Generic;
using System.Windows.Forms;
using Topcast_Report_Manager.Workers;
using System.Diagnostics;

namespace Topcast_Report_Manager.Forms
{
    public partial class Topcast_Report_Manager_Search : Form
    {
        public Topcast_Report_Manager_Main MainForm { get; set; }

        public Topcast_Report_Manager_Search(Topcast_Report_Manager_Main mainForm)
        {
            InitializeComponent();

            MainForm = mainForm;
            MainForm.changeLenguage += buttonChangeLenguage_Click;
        }

        private void Topcast_Report_Manager_Search_Load(object sender, EventArgs e)
        {
            datePickerFrom.Value = DateTime.Today;
            timePickerFrom.Value = DateTime.Now;
            datePickerTo.Value = DateTime.Today;
            timePickerTo.Value = DateTime.Now;

            checkBoxSearchDate.Checked = false;
            checkBoxSearchID.Checked = true;

            Topcast_Report_Manager_Main.SearchParam.SearchByDate = checkBoxSearchDate.Checked;
            Topcast_Report_Manager_Main.SearchParam.SearchByID = checkBoxSearchID.Checked;

            datePickerFrom.Enabled = false;
            datePickerTo.Enabled = false;
            timePickerFrom.Enabled = false;
            timePickerTo.Enabled = false;
            labelSearchFrom.Enabled = false;
            labelSearchTo.Enabled = false;

            textBoxBatchID.Enabled = true;
            labelSerachID.Enabled = true;

            //Set Current Lenguage
            ChangeLenguage();
        }

        private void checkBoxSearchDate_Click(object sender, EventArgs e)
        {
            checkBoxSearchID.Checked = false;

            Topcast_Report_Manager_Main.SearchParam.SearchByDate = checkBoxSearchDate.Checked;
            Topcast_Report_Manager_Main.SearchParam.SearchByID = checkBoxSearchID.Checked;

            datePickerFrom.Enabled = true;
            datePickerTo.Enabled = true;
            timePickerFrom.Enabled = true;
            timePickerTo.Enabled = true;
            labelSearchFrom.Enabled = true;
            labelSearchTo.Enabled = true;

            textBoxBatchID.Enabled = false;
            labelSerachID.Enabled = false;
        }

        private void checkBoxSearchID_Click(object sender, EventArgs e)
        {
            checkBoxSearchDate.Checked = false;

            Topcast_Report_Manager_Main.SearchParam.SearchByDate = checkBoxSearchDate.Checked;
            Topcast_Report_Manager_Main.SearchParam.SearchByID = checkBoxSearchID.Checked;

            datePickerFrom.Enabled = false;
            datePickerTo.Enabled = false;
            timePickerFrom.Enabled = false;
            timePickerTo.Enabled = false;
            labelSearchFrom.Enabled = false;
            labelSearchTo.Enabled = false;

            textBoxBatchID.Enabled = true;
            labelSerachID.Enabled = true;
        }

        private void datePickerFrom_ValueChanged(object sender, EventArgs e)
        {
            Topcast_Report_Manager_Main.SearchParam.SearchDateFrom = datePickerFrom.Value;
        }

        private void timePickerFrom_ValueChanged(object sender, EventArgs e)
        {
            Topcast_Report_Manager_Main.SearchParam.SearchDateFrom = timePickerFrom.Value;
        }

        private void datePickerTo_ValueChanged(object sender, EventArgs e)
        {
            Topcast_Report_Manager_Main.SearchParam.SearchDateTo = datePickerTo.Value;
        }

        private void timePickerTo_ValueChanged(object sender, EventArgs e)
        {
            Topcast_Report_Manager_Main.SearchParam.SearchDateTo = timePickerTo.Value;
        }

        private void textBoxBatchID_Click(object sender, EventArgs e)
        {
            if (Topcast_Report_Manager_Main.AppConfig.GenConfig.IsVirtualKeyBoard == "True")
            {
                try
                {
                    Process.Start(@"C:\Windows\WinSxS\amd64_microsoft-windows-osk_31bf3856ad364e35_10.0.19041.1_none_60ade0eff94c37fc\osk.exe");
                }
                catch (Exception ex)
                {
                    try
                    {
                        Process.Start(@"C:\Windows\System32\osk.exe");
                    }
                    catch (Exception ex2)
                    {
                        try
                        {
                            Process.Start(@"C:\Program Files(x86)\Common Files\Siemens\PTTouchInput");
                        }
                        catch (Exception ex3)
                        {
                            MessageBox.Show("Impossible to open On Screen Keyboard", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                }
            }
        }

        private void textBoxBatchID_TextChanged(object sender, EventArgs e)
        {
            Topcast_Report_Manager_Main.SearchParam.SearchID = textBoxBatchID.Text;
        }

        private async void buttonSearch_Click(object sender, EventArgs e)
        {
            string qry = SqlQryBuilder.BuildSearchQry(Topcast_Report_Manager_Main.SearchParam, Topcast_Report_Manager_Main.AppConfig);
            DataTable dataTable = new DataTable();

            try
            {
                dataTable = await SqlManagement.SqlExecuteQueryAsync(Topcast_Report_Manager_Main.AppConfig.SqlConnConfig.SqlConnectionString, qry);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            dataGridViewSearchResult.DataSource = dataTable;
            dataGridViewSearchResult.Update();

        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            List<string> selectedIDs = new List<string>();

            if (dataGridViewSearchResult.SelectedRows.Count > 0)
            {
                //Show Selected IDs
                dataGridViewSelected.DataSource = DataGridViewManagement.GetSelectedDatagridRows(dataGridViewSearchResult);
                dataGridViewSelected.Update();

                //Get List of Selected IDs
                selectedIDs = DataGridViewManagement.GetListFromDatagridSelectedRowCol(dataGridViewSearchResult, 0);
                Topcast_Report_Manager_Main.SelectedData.SelectedIDs = selectedIDs;
            }
            else
            {
                MessageBox.Show("No ID Selected", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

            checkBoxSearchDate.Text = resourceManager.GetString("LBL_SEARCH_BY_DATE", ci);
            checkBoxSearchID.Text = resourceManager.GetString("LBL_SEARCH_BY_ID", ci);
            labelSearchFrom.Text = resourceManager.GetString("LBL_SEARCH_FROM", ci);
            labelSearchTo.Text = resourceManager.GetString("LBL_SEARCH_TO", ci);
            labelSerachID.Text = resourceManager.GetString("LBL_SEARCH_ID", ci);
            buttonSearch.Text = resourceManager.GetString("BTN_SEARCH", ci);
            buttonSelect.Text = resourceManager.GetString("BTN_SELECT", ci);
        }
    }
}
