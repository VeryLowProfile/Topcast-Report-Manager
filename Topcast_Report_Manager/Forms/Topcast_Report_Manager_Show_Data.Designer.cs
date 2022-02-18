
namespace Topcast_Report_Manager.Forms
{
    partial class Topcast_Report_Manager_Show_Data
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
            this.dataGridViewShowData = new System.Windows.Forms.DataGridView();
            this.comboBoxIDList = new System.Windows.Forms.ComboBox();
            this.buttonHide = new System.Windows.Forms.Button();
            this.buttonShow = new System.Windows.Forms.Button();
            this.listBoxShow = new System.Windows.Forms.ListBox();
            this.listBoxHide = new System.Windows.Forms.ListBox();
            this.buttonShowData = new System.Windows.Forms.Button();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelVar = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelButtons = new System.Windows.Forms.TableLayoutPanel();
            this.buttonShowAll = new System.Windows.Forms.Button();
            this.buttonHideAll = new System.Windows.Forms.Button();
            this.panelSelectID = new System.Windows.Forms.Panel();
            this.labelSelectID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShowData)).BeginInit();
            this.tableLayoutPanel.SuspendLayout();
            this.tableLayoutPanelVar.SuspendLayout();
            this.tableLayoutPanelButtons.SuspendLayout();
            this.panelSelectID.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewShowData
            // 
            this.dataGridViewShowData.AllowUserToAddRows = false;
            this.dataGridViewShowData.AllowUserToDeleteRows = false;
            this.dataGridViewShowData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewShowData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewShowData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewShowData.Location = new System.Drawing.Point(3, 332);
            this.dataGridViewShowData.MultiSelect = false;
            this.dataGridViewShowData.Name = "dataGridViewShowData";
            this.dataGridViewShowData.ReadOnly = true;
            this.dataGridViewShowData.Size = new System.Drawing.Size(794, 261);
            this.dataGridViewShowData.TabIndex = 0;
            // 
            // comboBoxIDList
            // 
            this.comboBoxIDList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.comboBoxIDList.ForeColor = System.Drawing.Color.Gray;
            this.comboBoxIDList.FormattingEnabled = true;
            this.comboBoxIDList.Location = new System.Drawing.Point(9, 20);
            this.comboBoxIDList.Name = "comboBoxIDList";
            this.comboBoxIDList.Size = new System.Drawing.Size(303, 32);
            this.comboBoxIDList.TabIndex = 0;
            // 
            // buttonHide
            // 
            this.buttonHide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonHide.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHide.ForeColor = System.Drawing.Color.Gray;
            this.buttonHide.Image = global::Topcast_Report_Manager.Properties.Resources._005_left_chevron;
            this.buttonHide.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonHide.Location = new System.Drawing.Point(3, 147);
            this.buttonHide.Name = "buttonHide";
            this.buttonHide.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.buttonHide.Size = new System.Drawing.Size(252, 44);
            this.buttonHide.TabIndex = 1;
            this.buttonHide.Text = "BTN_HIDE";
            this.buttonHide.UseVisualStyleBackColor = true;
            this.buttonHide.Click += new System.EventHandler(this.buttonHide_Click);
            // 
            // buttonShow
            // 
            this.buttonShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShow.ForeColor = System.Drawing.Color.Gray;
            this.buttonShow.Image = global::Topcast_Report_Manager.Properties.Resources._004_right_chevron;
            this.buttonShow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonShow.Location = new System.Drawing.Point(3, 3);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonShow.Size = new System.Drawing.Size(252, 42);
            this.buttonShow.TabIndex = 0;
            this.buttonShow.Text = "BTN_SHOW";
            this.buttonShow.UseVisualStyleBackColor = true;
            this.buttonShow.Click += new System.EventHandler(this.buttonShow_Click);
            // 
            // listBoxShow
            // 
            this.listBoxShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxShow.ForeColor = System.Drawing.Color.Gray;
            this.listBoxShow.FormattingEnabled = true;
            this.listBoxShow.ItemHeight = 24;
            this.listBoxShow.Location = new System.Drawing.Point(531, 3);
            this.listBoxShow.Name = "listBoxShow";
            this.listBoxShow.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxShow.Size = new System.Drawing.Size(260, 194);
            this.listBoxShow.TabIndex = 0;
            // 
            // listBoxHide
            // 
            this.listBoxHide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxHide.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxHide.ForeColor = System.Drawing.Color.Gray;
            this.listBoxHide.FormattingEnabled = true;
            this.listBoxHide.ItemHeight = 24;
            this.listBoxHide.Location = new System.Drawing.Point(3, 3);
            this.listBoxHide.Name = "listBoxHide";
            this.listBoxHide.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxHide.Size = new System.Drawing.Size(258, 194);
            this.listBoxHide.TabIndex = 0;
            // 
            // buttonShowData
            // 
            this.buttonShowData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonShowData.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShowData.ForeColor = System.Drawing.Color.Gray;
            this.buttonShowData.Image = global::Topcast_Report_Manager.Properties.Resources._027_server;
            this.buttonShowData.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonShowData.Location = new System.Drawing.Point(3, 279);
            this.buttonShowData.Name = "buttonShowData";
            this.buttonShowData.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonShowData.Size = new System.Drawing.Size(794, 47);
            this.buttonShowData.TabIndex = 2;
            this.buttonShowData.Text = "BTN_SHOW_DATA";
            this.buttonShowData.UseVisualStyleBackColor = true;
            this.buttonShowData.Click += new System.EventHandler(this.buttonShowData_Click);
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 1;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Controls.Add(this.buttonShowData, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.dataGridViewShowData, 0, 3);
            this.tableLayoutPanel.Controls.Add(this.tableLayoutPanelVar, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.panelSelectID, 0, 0);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 4;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 39.33689F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0871F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.57601F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(800, 596);
            this.tableLayoutPanel.TabIndex = 5;
            // 
            // tableLayoutPanelVar
            // 
            this.tableLayoutPanelVar.ColumnCount = 3;
            this.tableLayoutPanelVar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.22222F));
            this.tableLayoutPanelVar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.22222F));
            this.tableLayoutPanelVar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.22222F));
            this.tableLayoutPanelVar.Controls.Add(this.listBoxHide, 0, 0);
            this.tableLayoutPanelVar.Controls.Add(this.listBoxShow, 2, 0);
            this.tableLayoutPanelVar.Controls.Add(this.tableLayoutPanelButtons, 1, 0);
            this.tableLayoutPanelVar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelVar.Location = new System.Drawing.Point(3, 73);
            this.tableLayoutPanelVar.Name = "tableLayoutPanelVar";
            this.tableLayoutPanelVar.RowCount = 1;
            this.tableLayoutPanelVar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelVar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanelVar.Size = new System.Drawing.Size(794, 200);
            this.tableLayoutPanelVar.TabIndex = 3;
            // 
            // tableLayoutPanelButtons
            // 
            this.tableLayoutPanelButtons.ColumnCount = 1;
            this.tableLayoutPanelButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelButtons.Controls.Add(this.buttonHide, 0, 3);
            this.tableLayoutPanelButtons.Controls.Add(this.buttonShow, 0, 0);
            this.tableLayoutPanelButtons.Controls.Add(this.buttonShowAll, 0, 1);
            this.tableLayoutPanelButtons.Controls.Add(this.buttonHideAll, 0, 2);
            this.tableLayoutPanelButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelButtons.Location = new System.Drawing.Point(267, 3);
            this.tableLayoutPanelButtons.Name = "tableLayoutPanelButtons";
            this.tableLayoutPanelButtons.RowCount = 4;
            this.tableLayoutPanelButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelButtons.Size = new System.Drawing.Size(258, 194);
            this.tableLayoutPanelButtons.TabIndex = 2;
            // 
            // buttonShowAll
            // 
            this.buttonShowAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonShowAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShowAll.ForeColor = System.Drawing.Color.Gray;
            this.buttonShowAll.Image = global::Topcast_Report_Manager.Properties.Resources._004_right_chevron;
            this.buttonShowAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonShowAll.Location = new System.Drawing.Point(3, 51);
            this.buttonShowAll.Name = "buttonShowAll";
            this.buttonShowAll.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonShowAll.Size = new System.Drawing.Size(252, 42);
            this.buttonShowAll.TabIndex = 2;
            this.buttonShowAll.Text = "BTN_SHOW_ALL";
            this.buttonShowAll.UseVisualStyleBackColor = true;
            this.buttonShowAll.Click += new System.EventHandler(this.buttonShowAll_Click);
            // 
            // buttonHideAll
            // 
            this.buttonHideAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonHideAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHideAll.ForeColor = System.Drawing.Color.Gray;
            this.buttonHideAll.Image = global::Topcast_Report_Manager.Properties.Resources._005_left_chevron;
            this.buttonHideAll.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonHideAll.Location = new System.Drawing.Point(3, 99);
            this.buttonHideAll.Name = "buttonHideAll";
            this.buttonHideAll.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.buttonHideAll.Size = new System.Drawing.Size(252, 42);
            this.buttonHideAll.TabIndex = 3;
            this.buttonHideAll.Text = "BTN_HIDE_ALL";
            this.buttonHideAll.UseVisualStyleBackColor = true;
            this.buttonHideAll.Click += new System.EventHandler(this.buttonHideAll_Click);
            // 
            // panelSelectID
            // 
            this.panelSelectID.Controls.Add(this.labelSelectID);
            this.panelSelectID.Controls.Add(this.comboBoxIDList);
            this.panelSelectID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSelectID.Location = new System.Drawing.Point(3, 3);
            this.panelSelectID.Name = "panelSelectID";
            this.panelSelectID.Size = new System.Drawing.Size(794, 64);
            this.panelSelectID.TabIndex = 4;
            // 
            // labelSelectID
            // 
            this.labelSelectID.AutoSize = true;
            this.labelSelectID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelectID.ForeColor = System.Drawing.Color.Gray;
            this.labelSelectID.Location = new System.Drawing.Point(9, 4);
            this.labelSelectID.Name = "labelSelectID";
            this.labelSelectID.Size = new System.Drawing.Size(109, 16);
            this.labelSelectID.TabIndex = 1;
            this.labelSelectID.Text = "LBL_SELECT_ID";
            // 
            // Topcast_Report_Manager_Show_Data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 596);
            this.Controls.Add(this.tableLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Topcast_Report_Manager_Show_Data";
            this.Text = "Topcast_Report_Manager_Show_Data";
            this.Load += new System.EventHandler(this.Topcast_Report_Manager_Show_Data_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShowData)).EndInit();
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanelVar.ResumeLayout(false);
            this.tableLayoutPanelButtons.ResumeLayout(false);
            this.panelSelectID.ResumeLayout(false);
            this.panelSelectID.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewShowData;
        private System.Windows.Forms.ComboBox comboBoxIDList;
        private System.Windows.Forms.Button buttonHide;
        private System.Windows.Forms.Button buttonShow;
        private System.Windows.Forms.ListBox listBoxHide;
        private System.Windows.Forms.Button buttonShowData;
        private System.Windows.Forms.ListBox listBoxShow;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelVar;
        private System.Windows.Forms.Button buttonShowAll;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelButtons;
        private System.Windows.Forms.Button buttonHideAll;
        private System.Windows.Forms.Panel panelSelectID;
        private System.Windows.Forms.Label labelSelectID;
    }
}