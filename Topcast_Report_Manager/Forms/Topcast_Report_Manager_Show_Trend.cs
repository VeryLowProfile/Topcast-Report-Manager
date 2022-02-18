using System;
using System.Data;
using System.Resources;
using System.Reflection;
using System.Globalization;
using System.Threading.Tasks;
using System.Drawing;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Topcast_Report_Manager.Workers;
using Topcast_Report_Manager.Controls;

namespace Topcast_Report_Manager.Forms
{
    public partial class Topcast_Report_Manager_Show_Trend : Form
    {
        public Topcast_Report_Manager_Main MainForm { get; set; }
        public List<(string colName, string selectedText, string plotColor, string userUnit)> ShowPivot { get; set; }
        public List<(string colName, string selectedText, string plotColor, string userUnit)> HidePivot { get; set; }

        ChartArea chartArea;
        Chart chart;
        ToolTip tooltip;

        Timer livePotTimer;

        public Topcast_Report_Manager_Show_Trend(Topcast_Report_Manager_Main mainForm)
        {
            InitializeComponent();

            MainForm = mainForm;

            ShowPivot = new List<(string colName, string selectedText, string plotColor, string userUnit)>();
            HidePivot = new List<(string colName, string selectedText, string plotColor, string userUnit)>();

            chartArea = new ChartArea();
            chart = new Chart();
            tooltip = new ToolTip();

            livePotTimer = new Timer();
        }


        private void Topcast_Report_Manager_Show_Trend_Load(object sender, EventArgs e)
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

            //Init Chart
            chartArea.CursorX.IsUserEnabled = true;
            chartArea.CursorX.IsUserSelectionEnabled = true;
            chartArea.CursorX.IntervalType = DateTimeIntervalType.Seconds;
            chartArea.CursorX.LineColor = Color.Gray;
            chartArea.CursorX.LineWidth = 2;
            chartArea.CursorX.LineDashStyle = ChartDashStyle.Dash;

            chartArea.CursorY.IsUserEnabled = true;
            chartArea.CursorY.IsUserSelectionEnabled = true;
            chartArea.CursorY.LineColor = Color.Gray;
            chartArea.CursorY.LineWidth = 2;
            chartArea.CursorY.LineDashStyle = ChartDashStyle.Dash;

            chartArea.BackColor = panelPlot.BackColor;

            chartArea.AxisX.IntervalType = DateTimeIntervalType.Auto;
            chartArea.AxisX.ScaleView.Zoomable = true;
            chartArea.AxisX.ScrollBar.Enabled = true;
            chartArea.AxisX.ScrollBar.IsPositionedInside = false;
            chartArea.AxisX.ScrollBar.Size = 20;
            chartArea.AxisX.ScrollBar.ButtonStyle = ScrollBarButtonStyles.All;
            chartArea.AxisX.ScrollBar.LineColor = Color.LightGray;
            chartArea.AxisX.ScrollBar.BackColor = Color.LightGray;
            chartArea.AxisX.ScrollBar.ButtonColor = Color.Gray;
            chartArea.AxisX.MajorGrid.LineColor = Color.LightGray;
            chartArea.AxisX.LineColor = Color.LightGray;
            chartArea.AxisX.InterlacedColor = Color.LightGray;
            chartArea.AxisX.TitleForeColor = Color.LightGray;

            chartArea.AxisY.ScaleView.Zoomable = true;
            chartArea.AxisY.ScrollBar.Enabled = true;
            chartArea.AxisY.ScrollBar.IsPositionedInside = false;
            chartArea.AxisY.ScrollBar.Size = 20;
            chartArea.AxisY.ScrollBar.ButtonStyle = ScrollBarButtonStyles.All;
            chartArea.AxisY.ScrollBar.LineColor = Color.LightGray;
            chartArea.AxisY.ScrollBar.BackColor = Color.LightGray;
            chartArea.AxisY.ScrollBar.ButtonColor = Color.Gray;
            chartArea.AxisY.MajorGrid.LineColor = Color.LightGray;
            chartArea.AxisY.LineColor = Color.LightGray;
            chartArea.AxisY.InterlacedColor = Color.LightGray;
            chartArea.AxisY.TitleForeColor = Color.LightGray;

            chart.BackColor = panelPlot.BackColor;
            chart.Dock = DockStyle.Fill;
            chart.ChartAreas.Add(chartArea);
            chart.MouseMove += Chart_MouseMove;

            //Add Chart to Panel
            panelPlot.Controls.Add(chart);

            //Init Timer
            livePotTimer.Interval = 2000;

            //Trend Control button
            buttonPlay.Enabled = false;
            buttonPause.Enabled = false;
            buttonZoomIn.Enabled = false;
            buttonZoomOut.Enabled = false;
            buttonTakePicture.Enabled = false;
            buttonEnlarge.Enabled = false;
            buttonShrink.Enabled = false;

            //Events Subscription
            MainForm.changeLenguage += buttonChangeLenguage_Click;
            livePotTimer.Tick += LivePotTimer_Tick;
            chart.MouseDown += Chart_MouseDown;

        }

        private void Chart_MouseMove(object sender, MouseEventArgs e)
        {
            tooltip.Hide(chart);

            var pos = e.Location;

            var results = chart.HitTest(pos.X, pos.Y, false, ChartElementType.DataPoint);

            if (results != null)
            {
                if (results[0].ChartElementType == ChartElementType.DataPoint)
                {
                    var prop = results[0].Object as DataPoint;

                    if (prop != null)
                    {
                        tooltip.Show("VALUE = " + prop.YValues[0], this.chart, pos.X, pos.Y - 15);
                    }
                }
            }
        }

        private void Chart_MouseDown(object sender, MouseEventArgs e)
        {
            foreach (cursorValue cursorValue in panelCursorValue.Controls)
            {
                cursorValue.updateCursorValue(calculateSeriesIndex(chartArea, cursorValue.Series, e.Location));
            }
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            int firtsSelectedIndex = 0;

            if (listBoxHide.SelectedIndices.Count != 0)
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

            if (listBoxShow.SelectedIndices.Count != 0)
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

        private void buttonShowTrends_Click(object sender, EventArgs e)
        {
            plotChart();
            livePotTimer.Stop();
            buttonPlay.Enabled = true;
            buttonPause.Enabled = false;
            buttonZoomIn.Enabled = true;
            buttonZoomOut.Enabled = true;
            buttonTakePicture.Enabled = true;
            buttonEnlarge.Enabled = true;
            buttonShrink.Enabled = false;
        }

        public void buttonChangeLenguage_Click(object sender, EventArgs e)
        {
            ChangeLenguage();
            Fillpivot();
            FillList();
            SetButtonsVisibility();
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            if (!livePotTimer.Enabled)
            {
                livePotTimer.Start();
                buttonPlay.Enabled = false;
                buttonPause.Enabled = true;
            }
        }

        private void buttonPause_Click(object sender, EventArgs e)
        {
            if (livePotTimer.Enabled)
            {
                livePotTimer.Stop();
                buttonPause.Enabled = false;
                buttonPlay.Enabled = true;
            }
        }

        private void LivePotTimer_Tick(object sender, EventArgs e)
        {
            plotChart();
        }

        private void buttonZoomIn_Click(object sender, EventArgs e)
        {
            double startX = chartArea.AxisX.PositionToValue(0);
            double endX = chartArea.AxisX.PositionToValue(100);
            chartArea.AxisX.ScaleView.Zoom((startX * 1.05), (endX * 0.95));
        }

        private void buttonZoomOut_Click(object sender, EventArgs e)
        {
            chartArea.AxisX.ScaleView.ZoomReset();
            chartArea.AxisY.ScaleView.ZoomReset();
        }

        private void buttonTakePicture_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.SelectedPath = Topcast_Report_Manager_Main.AppConfig.GenConfig.DefReportPath;
            DialogResult result = folderBrowserDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                string folderPath = folderBrowserDialog.SelectedPath + @"\" + "TrendImage_" + comboBoxIDList.Text + ".png";
                chart.SaveImage(folderPath, ChartImageFormat.Png);
            }
        }

        private void buttonEnlarge_Click(object sender, EventArgs e)
        {
            tableLayoutPanel.RowStyles[0].Height = 0;
            tableLayoutPanel.RowStyles[1].Height = 0;
            tableLayoutPanel.RowStyles[2].Height = 0;
            buttonEnlarge.Enabled = false;
            buttonShrink.Enabled = true;
        }

        private void buttonShrink_Click(object sender, EventArgs e)
        {
            tableLayoutPanel.RowStyles[0].Height = 70;
            tableLayoutPanel.RowStyles[1].Height = 40;
            tableLayoutPanel.RowStyles[2].Height = 10;
            buttonEnlarge.Enabled = true;
            buttonShrink.Enabled = false;
        }

        private void Topcast_Report_Manager_Show_Trend_FormClosing(object sender, FormClosingEventArgs e)
        {
            livePotTimer.Stop();
        }

        private void Fillpivot()
        {
            ShowPivot.Clear();
            HidePivot.Clear();

            foreach (var logVar in Topcast_Report_Manager_Main.AppConfig.LogVarConfig.LogVar)
            {
                if (logVar.ColName != "BatchID" && logVar.ColName != "DateTime" && !logVar.ColName.Contains("String") && logVar.PlotColor != "None")
                {
                    if (logVar.DefPlot == "True")
                    {
                        (string colName, string selectedText, string plotColor, string userUnit) pivot;
                        pivot.colName = logVar.ColName;
                        pivot.selectedText = logVar.SelectedText;
                        pivot.plotColor = logVar.PlotColor;
                        pivot.userUnit = logVar.UserUnit;
                        ShowPivot.Add(pivot);
                    }
                    else if (logVar.DefPlot == "False")
                    {
                        (string colName, string selectedText, string plotColor, string userUnit) pivot;
                        pivot.colName = logVar.ColName;
                        pivot.selectedText = logVar.SelectedText;
                        pivot.plotColor = logVar.PlotColor;
                        pivot.userUnit = logVar.UserUnit;
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
                foreach (var logVar in Topcast_Report_Manager_Main.AppConfig.LogVarConfig.LogVar)
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

        private void SetShowToHide(int selectedIndex)
        {
            foreach (var logVar in Topcast_Report_Manager_Main.AppConfig.LogVarConfig.LogVar)
            {
                if (logVar.ColName == ShowPivot[selectedIndex].colName)
                {
                    logVar.DefPlot = "False";
                }
            }
        }

        private void SetHideToShow(int selectedIndex)
        {
            foreach (var logVar in Topcast_Report_Manager_Main.AppConfig.LogVarConfig.LogVar)
            {
                if (logVar.ColName == HidePivot[selectedIndex].colName)
                {
                    logVar.DefPlot = "True";
                }
            }
        }

        private void SetAllToHide()
        {
            foreach (var logVar in Topcast_Report_Manager_Main.AppConfig.LogVarConfig.LogVar)
            {
                logVar.DefPlot = "False";
            }

            Fillpivot();
            FillList();

        }

        private void SetAllToShow()
        {
            foreach (var logVar in Topcast_Report_Manager_Main.AppConfig.LogVarConfig.LogVar)
            {
                logVar.DefPlot = "True";
            }

            Fillpivot();
            FillList();

        }

        private void SetButtonsVisibility()
        {
            if (ShowPivot.Count <= 0)
            {
                buttonHide.Visible = false;
                buttonHideAll.Visible = false;
                buttonShowTrends.Visible = false;
            }
            else
            {
                buttonHide.Visible = true;
                buttonHideAll.Visible = true;
                buttonShowTrends.Visible = true;
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

        //public async void plotChart()
        //{
        //    string qry = SqlQryBuilder.BuildPlotQry(ShowPivot, Topcast_Report_Manager_Main.AppConfig, comboBoxIDList.Text);
        //    DataTable dataTable = new DataTable();

        //    try
        //    {
        //        dataTable = await SqlManagement.SqlExecuteQueryAsync(Topcast_Report_Manager_Main.AppConfig.SqlConnConfig.SqlConnectionString, qry);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        //    }

        //    chart.Series.Clear();
        //    panelCursorValue.Controls.Clear();

        //    foreach (var pivot in ShowPivot)
        //    {
        //        Series series = new Series();
        //        series.Name = pivot.selectedText;
        //        series.Color = Color.FromName(pivot.plotColor);
        //        series.ChartType = SeriesChartType.FastLine;
        //        series.XValueType = ChartValueType.Time;

        //        series.BorderWidth = 2;

        //        foreach (DataRow row in dataTable.Rows)
        //        {
        //            series.Points.AddXY(row["DateTime"], row[pivot.selectedText]);
        //        }

        //        chart.Series.Add(series);

        //        //Add cursor value control with injected series as parameter
        //        cursorValue cursorValue = new cursorValue(series, pivot.userUnit);
        //        cursorValue.Dock = DockStyle.Top;
        //        panelCursorValue.Controls.Add(cursorValue);

        //    }
        //}

        public async void plotChart()
        {

            //Create string and datatable
            string qry = SqlQryBuilder.BuildPlotQry(ShowPivot, Topcast_Report_Manager_Main.AppConfig, comboBoxIDList.Text);
            DataTable dataTable = new DataTable();

            //Get Chart data To DataTable
            try
            {
                dataTable = await SqlManagement.SqlExecuteQueryAsync(Topcast_Report_Manager_Main.AppConfig.SqlConnConfig.SqlConnectionString, qry);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            //Clean old Chart
            chart.Series.Clear();
            panelCursorValue.Controls.Clear();

            //Create and start Task to add series to the Chart Data
            Task addSeries = new Task(() => addNewSeriesToChart(dataTable));
            addSeries.Start();

            //wait data task end
            await Task.WhenAll(addSeries);

            chart.Show();

        }

        public void addNewSeriesToChart(DataTable dataTable)
        {
            foreach (var pivot in ShowPivot)
            {
                Series series = new Series();
                series.Name = pivot.selectedText;
                series.Color = Color.FromName(pivot.plotColor);
                series.ChartType = SeriesChartType.FastLine;
                series.XValueType = ChartValueType.Time;

                series.BorderWidth = 2;

                foreach (DataRow row in dataTable.Rows)
                {
                    series.Points.AddXY(row["DateTime"], row[pivot.selectedText]);
                }

                //Add Series To Chart
                chart.Invoke((Action)(() => addSeriesToChart(series)));

                //Add cursor value control with injected series as parameter
                panelCursorValue.Invoke((Action)(() => addCursorValueToPanel(series, pivot.userUnit)));
            }
        }

        private void addSeriesToChart(Series series)
        {
            chart.Series.Add(series);
        }

        private void addCursorValueToPanel(Series series, string userUnit)
        {
            cursorValue cursorValue = new cursorValue(series, userUnit);
            cursorValue.Dock = DockStyle.Top;
            panelCursorValue.Controls.Add(cursorValue);
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
            buttonShowTrends.Text = resourceManager.GetString("BTN_SHOW_TRENDS", ci);
        }

        private int calculateSeriesIndex(ChartArea chartArea, Series series, Point point)
        {
            double index = 0;

            var xAxis = chartArea.AxisX;
            double xRight = xAxis.ValueToPixelPosition(xAxis.Maximum) - 1;
            double xLeft = xAxis.ValueToPixelPosition(xAxis.Minimum);

            if (point.X >= xLeft && point.X <= xRight)
            {
                index = ((double)(series.Points.Count / (xRight - xLeft)) * (point.X - xLeft));
            }

            return (int)index;
        }

    }
}
