
namespace Topcast_Report_Manager.Forms
{
    partial class Topcast_Report_Manager_Show_Alarms_Events
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
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridViewEvents = new System.Windows.Forms.DataGridView();
            this.panelSelectID = new System.Windows.Forms.Panel();
            this.labelSelectID = new System.Windows.Forms.Label();
            this.comboBoxIDList = new System.Windows.Forms.ComboBox();
            this.buttonShow = new System.Windows.Forms.Button();
            this.dataGridViewAlarms = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEvents)).BeginInit();
            this.panelSelectID.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlarms)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 1;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Controls.Add(this.dataGridViewEvents, 0, 3);
            this.tableLayoutPanel.Controls.Add(this.panelSelectID, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.buttonShow, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.dataGridViewAlarms, 0, 2);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 4;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.44445F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.44445F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(800, 596);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // dataGridViewEvents
            // 
            this.dataGridViewEvents.AllowUserToAddRows = false;
            this.dataGridViewEvents.AllowUserToDeleteRows = false;
            this.dataGridViewEvents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEvents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewEvents.Location = new System.Drawing.Point(3, 364);
            this.dataGridViewEvents.Name = "dataGridViewEvents";
            this.dataGridViewEvents.Size = new System.Drawing.Size(794, 229);
            this.dataGridViewEvents.TabIndex = 8;
            // 
            // panelSelectID
            // 
            this.panelSelectID.Controls.Add(this.labelSelectID);
            this.panelSelectID.Controls.Add(this.comboBoxIDList);
            this.panelSelectID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSelectID.Location = new System.Drawing.Point(3, 3);
            this.panelSelectID.Name = "panelSelectID";
            this.panelSelectID.Size = new System.Drawing.Size(794, 64);
            this.panelSelectID.TabIndex = 5;
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
            // buttonShow
            // 
            this.buttonShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShow.ForeColor = System.Drawing.Color.Gray;
            this.buttonShow.Image = global::Topcast_Report_Manager.Properties.Resources._036_notifications_bell_button;
            this.buttonShow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonShow.Location = new System.Drawing.Point(3, 73);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonShow.Size = new System.Drawing.Size(794, 52);
            this.buttonShow.TabIndex = 6;
            this.buttonShow.Text = "BTN_SHOW_ALARMS_EVENTS";
            this.buttonShow.UseVisualStyleBackColor = true;
            this.buttonShow.Click += new System.EventHandler(this.buttonShow_Click);
            // 
            // dataGridViewAlarms
            // 
            this.dataGridViewAlarms.AllowUserToAddRows = false;
            this.dataGridViewAlarms.AllowUserToDeleteRows = false;
            this.dataGridViewAlarms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAlarms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAlarms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewAlarms.Location = new System.Drawing.Point(3, 131);
            this.dataGridViewAlarms.Name = "dataGridViewAlarms";
            this.dataGridViewAlarms.Size = new System.Drawing.Size(794, 227);
            this.dataGridViewAlarms.TabIndex = 7;
            // 
            // Topcast_Report_Manager_Show_Alarms_Events
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 596);
            this.Controls.Add(this.tableLayoutPanel);
            this.Name = "Topcast_Report_Manager_Show_Alarms_Events";
            this.Text = "Topcast_Report_Manager_Show_Alarms_Events";
            this.Load += new System.EventHandler(this.Topcast_Report_Manager_Show_Alarms_Events_Load);
            this.tableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEvents)).EndInit();
            this.panelSelectID.ResumeLayout(false);
            this.panelSelectID.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlarms)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Panel panelSelectID;
        private System.Windows.Forms.Label labelSelectID;
        private System.Windows.Forms.ComboBox comboBoxIDList;
        private System.Windows.Forms.Button buttonShow;
        private System.Windows.Forms.DataGridView dataGridViewAlarms;
        private System.Windows.Forms.DataGridView dataGridViewEvents;
    }
}