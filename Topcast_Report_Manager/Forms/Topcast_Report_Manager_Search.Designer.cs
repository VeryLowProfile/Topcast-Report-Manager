
namespace Topcast_Report_Manager.Forms
{
    partial class Topcast_Report_Manager_Search
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonSearch = new System.Windows.Forms.Button();
            this.dataGridViewSearchResult = new System.Windows.Forms.DataGridView();
            this.dataGridViewSelected = new System.Windows.Forms.DataGridView();
            this.datePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.timePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.textBoxBatchID = new System.Windows.Forms.TextBox();
            this.timePickerTo = new System.Windows.Forms.DateTimePicker();
            this.datePickerTo = new System.Windows.Forms.DateTimePicker();
            this.buttonSelect = new System.Windows.Forms.Button();
            this.checkBoxSearchDate = new System.Windows.Forms.CheckBox();
            this.checkBoxSearchID = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelSerachID = new System.Windows.Forms.Label();
            this.labelSearchTo = new System.Windows.Forms.Label();
            this.labelSearchFrom = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearchResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSelected)).BeginInit();
            this.tableLayoutPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSearch
            // 
            this.buttonSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.ForeColor = System.Drawing.Color.Gray;
            this.buttonSearch.Image = global::Topcast_Report_Manager.Properties.Resources._001_search;
            this.buttonSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSearch.Location = new System.Drawing.Point(3, 153);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonSearch.Size = new System.Drawing.Size(794, 35);
            this.buttonSearch.TabIndex = 0;
            this.buttonSearch.Text = "BTN_SEARCH";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // dataGridViewSearchResult
            // 
            this.dataGridViewSearchResult.AllowUserToAddRows = false;
            this.dataGridViewSearchResult.AllowUserToDeleteRows = false;
            this.dataGridViewSearchResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSearchResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSearchResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSearchResult.Location = new System.Drawing.Point(3, 194);
            this.dataGridViewSearchResult.Name = "dataGridViewSearchResult";
            this.dataGridViewSearchResult.ReadOnly = true;
            this.dataGridViewSearchResult.Size = new System.Drawing.Size(794, 202);
            this.dataGridViewSearchResult.TabIndex = 1;
            // 
            // dataGridViewSelected
            // 
            this.dataGridViewSelected.AllowUserToAddRows = false;
            this.dataGridViewSelected.AllowUserToDeleteRows = false;
            this.dataGridViewSelected.AllowUserToResizeColumns = false;
            this.dataGridViewSelected.AllowUserToResizeRows = false;
            this.dataGridViewSelected.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSelected.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSelected.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSelected.Location = new System.Drawing.Point(3, 443);
            this.dataGridViewSelected.Name = "dataGridViewSelected";
            this.dataGridViewSelected.ReadOnly = true;
            this.dataGridViewSelected.Size = new System.Drawing.Size(794, 150);
            this.dataGridViewSelected.TabIndex = 2;
            // 
            // datePickerFrom
            // 
            this.datePickerFrom.CalendarForeColor = System.Drawing.Color.Gray;
            this.datePickerFrom.CalendarTitleBackColor = System.Drawing.Color.Gray;
            this.datePickerFrom.CalendarTitleForeColor = System.Drawing.Color.Gray;
            this.datePickerFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePickerFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePickerFrom.Location = new System.Drawing.Point(4, 51);
            this.datePickerFrom.MaxDate = new System.DateTime(2030, 1, 1, 0, 0, 0, 0);
            this.datePickerFrom.MinDate = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            this.datePickerFrom.Name = "datePickerFrom";
            this.datePickerFrom.Size = new System.Drawing.Size(200, 29);
            this.datePickerFrom.TabIndex = 3;
            this.datePickerFrom.ValueChanged += new System.EventHandler(this.datePickerFrom_ValueChanged);
            // 
            // timePickerFrom
            // 
            this.timePickerFrom.CalendarForeColor = System.Drawing.Color.Gray;
            this.timePickerFrom.CalendarTitleBackColor = System.Drawing.Color.Gray;
            this.timePickerFrom.CalendarTitleForeColor = System.Drawing.Color.Gray;
            this.timePickerFrom.CustomFormat = "";
            this.timePickerFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timePickerFrom.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timePickerFrom.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.timePickerFrom.Location = new System.Drawing.Point(213, 51);
            this.timePickerFrom.MaxDate = new System.DateTime(2030, 1, 1, 0, 0, 0, 0);
            this.timePickerFrom.MinDate = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            this.timePickerFrom.Name = "timePickerFrom";
            this.timePickerFrom.ShowUpDown = true;
            this.timePickerFrom.Size = new System.Drawing.Size(200, 29);
            this.timePickerFrom.TabIndex = 4;
            this.timePickerFrom.ValueChanged += new System.EventHandler(this.timePickerFrom_ValueChanged);
            // 
            // textBoxBatchID
            // 
            this.textBoxBatchID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBatchID.ForeColor = System.Drawing.Color.Gray;
            this.textBoxBatchID.Location = new System.Drawing.Point(523, 51);
            this.textBoxBatchID.Name = "textBoxBatchID";
            this.textBoxBatchID.Size = new System.Drawing.Size(204, 29);
            this.textBoxBatchID.TabIndex = 5;
            this.textBoxBatchID.Click += new System.EventHandler(this.textBoxBatchID_Click);
            this.textBoxBatchID.TextChanged += new System.EventHandler(this.textBoxBatchID_TextChanged);
            // 
            // timePickerTo
            // 
            this.timePickerTo.CalendarForeColor = System.Drawing.Color.Gray;
            this.timePickerTo.CalendarTitleBackColor = System.Drawing.Color.Gray;
            this.timePickerTo.CalendarTitleForeColor = System.Drawing.Color.Gray;
            this.timePickerTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timePickerTo.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timePickerTo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.timePickerTo.Location = new System.Drawing.Point(213, 105);
            this.timePickerTo.MaxDate = new System.DateTime(2030, 1, 1, 0, 0, 0, 0);
            this.timePickerTo.MinDate = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            this.timePickerTo.Name = "timePickerTo";
            this.timePickerTo.ShowUpDown = true;
            this.timePickerTo.Size = new System.Drawing.Size(200, 29);
            this.timePickerTo.TabIndex = 7;
            this.timePickerTo.ValueChanged += new System.EventHandler(this.timePickerTo_ValueChanged);
            // 
            // datePickerTo
            // 
            this.datePickerTo.CalendarForeColor = System.Drawing.Color.Gray;
            this.datePickerTo.CalendarTitleBackColor = System.Drawing.Color.Gray;
            this.datePickerTo.CalendarTitleForeColor = System.Drawing.Color.Gray;
            this.datePickerTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePickerTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePickerTo.Location = new System.Drawing.Point(4, 105);
            this.datePickerTo.MaxDate = new System.DateTime(2030, 1, 1, 0, 0, 0, 0);
            this.datePickerTo.MinDate = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            this.datePickerTo.Name = "datePickerTo";
            this.datePickerTo.Size = new System.Drawing.Size(200, 29);
            this.datePickerTo.TabIndex = 6;
            this.datePickerTo.ValueChanged += new System.EventHandler(this.datePickerTo_ValueChanged);
            // 
            // buttonSelect
            // 
            this.buttonSelect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSelect.ForeColor = System.Drawing.Color.Gray;
            this.buttonSelect.Location = new System.Drawing.Point(3, 402);
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.Size = new System.Drawing.Size(794, 35);
            this.buttonSelect.TabIndex = 8;
            this.buttonSelect.Text = "BTN_SELECT";
            this.buttonSelect.UseVisualStyleBackColor = true;
            this.buttonSelect.Click += new System.EventHandler(this.buttonSelect_Click);
            // 
            // checkBoxSearchDate
            // 
            this.checkBoxSearchDate.AutoSize = true;
            this.checkBoxSearchDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxSearchDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxSearchDate.ForeColor = System.Drawing.Color.Gray;
            this.checkBoxSearchDate.Location = new System.Drawing.Point(4, 7);
            this.checkBoxSearchDate.Name = "checkBoxSearchDate";
            this.checkBoxSearchDate.Size = new System.Drawing.Size(178, 20);
            this.checkBoxSearchDate.TabIndex = 9;
            this.checkBoxSearchDate.Text = "LBL_SEARCH_BY_DATE";
            this.checkBoxSearchDate.UseVisualStyleBackColor = true;
            this.checkBoxSearchDate.Click += new System.EventHandler(this.checkBoxSearchDate_Click);
            // 
            // checkBoxSearchID
            // 
            this.checkBoxSearchID.AutoSize = true;
            this.checkBoxSearchID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxSearchID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxSearchID.ForeColor = System.Drawing.Color.Gray;
            this.checkBoxSearchID.Location = new System.Drawing.Point(523, 7);
            this.checkBoxSearchID.Name = "checkBoxSearchID";
            this.checkBoxSearchID.Size = new System.Drawing.Size(154, 20);
            this.checkBoxSearchID.TabIndex = 10;
            this.checkBoxSearchID.Text = "LBL_SEARCH_BY_ID";
            this.checkBoxSearchID.UseVisualStyleBackColor = true;
            this.checkBoxSearchID.Click += new System.EventHandler(this.checkBoxSearchID_Click);
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 1;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Controls.Add(this.dataGridViewSelected, 0, 4);
            this.tableLayoutPanel.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.buttonSelect, 0, 3);
            this.tableLayoutPanel.Controls.Add(this.buttonSearch, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.dataGridViewSearchResult, 0, 2);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 5;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.345794F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.72897F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.345794F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.57944F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(800, 596);
            this.tableLayoutPanel.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelSerachID);
            this.panel2.Controls.Add(this.textBoxBatchID);
            this.panel2.Controls.Add(this.labelSearchTo);
            this.panel2.Controls.Add(this.checkBoxSearchID);
            this.panel2.Controls.Add(this.labelSearchFrom);
            this.panel2.Controls.Add(this.datePickerFrom);
            this.panel2.Controls.Add(this.timePickerFrom);
            this.panel2.Controls.Add(this.datePickerTo);
            this.panel2.Controls.Add(this.timePickerTo);
            this.panel2.Controls.Add(this.checkBoxSearchDate);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(794, 144);
            this.panel2.TabIndex = 0;
            // 
            // labelSerachID
            // 
            this.labelSerachID.AutoSize = true;
            this.labelSerachID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSerachID.ForeColor = System.Drawing.Color.Gray;
            this.labelSerachID.Location = new System.Drawing.Point(523, 35);
            this.labelSerachID.Name = "labelSerachID";
            this.labelSerachID.Size = new System.Drawing.Size(113, 16);
            this.labelSerachID.TabIndex = 11;
            this.labelSerachID.Text = "LBL_SEARCH_ID";
            // 
            // labelSearchTo
            // 
            this.labelSearchTo.AutoSize = true;
            this.labelSearchTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearchTo.ForeColor = System.Drawing.Color.Gray;
            this.labelSearchTo.Location = new System.Drawing.Point(4, 89);
            this.labelSearchTo.Name = "labelSearchTo";
            this.labelSearchTo.Size = new System.Drawing.Size(119, 16);
            this.labelSearchTo.TabIndex = 5;
            this.labelSearchTo.Text = "LBL_SEARCH_TO";
            // 
            // labelSearchFrom
            // 
            this.labelSearchFrom.AutoSize = true;
            this.labelSearchFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearchFrom.ForeColor = System.Drawing.Color.Gray;
            this.labelSearchFrom.Location = new System.Drawing.Point(4, 35);
            this.labelSearchFrom.Name = "labelSearchFrom";
            this.labelSearchFrom.Size = new System.Drawing.Size(139, 16);
            this.labelSearchFrom.TabIndex = 0;
            this.labelSearchFrom.Text = "LBL_SEARCH_FROM";
            // 
            // Topcast_Report_Manager_Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 596);
            this.Controls.Add(this.tableLayoutPanel);
            this.Name = "Topcast_Report_Manager_Search";
            this.Text = "Search";
            this.Load += new System.EventHandler(this.Topcast_Report_Manager_Search_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearchResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSelected)).EndInit();
            this.tableLayoutPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.DataGridView dataGridViewSearchResult;
        private System.Windows.Forms.DataGridView dataGridViewSelected;
        private System.Windows.Forms.DateTimePicker datePickerFrom;
        private System.Windows.Forms.DateTimePicker timePickerFrom;
        private System.Windows.Forms.TextBox textBoxBatchID;
        private System.Windows.Forms.DateTimePicker timePickerTo;
        private System.Windows.Forms.DateTimePicker datePickerTo;
        private System.Windows.Forms.Button buttonSelect;
        private System.Windows.Forms.CheckBox checkBoxSearchDate;
        private System.Windows.Forms.CheckBox checkBoxSearchID;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelSearchTo;
        private System.Windows.Forms.Label labelSearchFrom;
        private System.Windows.Forms.Label labelSerachID;
    }
}