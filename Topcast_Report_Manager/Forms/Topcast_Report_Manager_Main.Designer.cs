
namespace Topcast_Report_Manager.Forms
{
    partial class Topcast_Report_Manager_Main
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Topcast_Report_Manager_Main));
            this.panelNavigation = new System.Windows.Forms.Panel();
            this.panelButtonNavigation = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelConnectionString = new System.Windows.Forms.Label();
            this.buttonOpenSearch = new System.Windows.Forms.Button();
            this.labelConnectionCheck = new System.Windows.Forms.Label();
            this.buttonOpenShowData = new System.Windows.Forms.Button();
            this.buttonOpenShowTrend = new System.Windows.Forms.Button();
            this.buttonOpenShowAlarmsEvents = new System.Windows.Forms.Button();
            this.buttonOpenReport = new System.Windows.Forms.Button();
            this.panel_Flags = new System.Windows.Forms.Panel();
            this.tableLayoutPanelFlags = new System.Windows.Forms.TableLayoutPanel();
            this.button_ES = new System.Windows.Forms.Button();
            this.button_DE = new System.Windows.Forms.Button();
            this.button_EN = new System.Windows.Forms.Button();
            this.button_IT = new System.Windows.Forms.Button();
            this.button_FR = new System.Windows.Forms.Button();
            this.panelChildform = new System.Windows.Forms.Panel();
            this.panelNavigation.SuspendLayout();
            this.panelButtonNavigation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_Flags.SuspendLayout();
            this.tableLayoutPanelFlags.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelNavigation
            // 
            this.panelNavigation.Controls.Add(this.panelButtonNavigation);
            this.panelNavigation.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelNavigation.Location = new System.Drawing.Point(0, 0);
            this.panelNavigation.Name = "panelNavigation";
            this.panelNavigation.Size = new System.Drawing.Size(273, 729);
            this.panelNavigation.TabIndex = 0;
            // 
            // panelButtonNavigation
            // 
            this.panelButtonNavigation.ColumnCount = 1;
            this.panelButtonNavigation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelButtonNavigation.Controls.Add(this.pictureBox1, 0, 0);
            this.panelButtonNavigation.Controls.Add(this.labelConnectionString, 0, 1);
            this.panelButtonNavigation.Controls.Add(this.buttonOpenSearch, 0, 3);
            this.panelButtonNavigation.Controls.Add(this.labelConnectionCheck, 0, 2);
            this.panelButtonNavigation.Controls.Add(this.buttonOpenShowData, 0, 4);
            this.panelButtonNavigation.Controls.Add(this.buttonOpenShowTrend, 0, 5);
            this.panelButtonNavigation.Controls.Add(this.buttonOpenShowAlarmsEvents, 0, 6);
            this.panelButtonNavigation.Controls.Add(this.buttonOpenReport, 0, 7);
            this.panelButtonNavigation.Controls.Add(this.panel_Flags, 0, 8);
            this.panelButtonNavigation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelButtonNavigation.Location = new System.Drawing.Point(0, 0);
            this.panelButtonNavigation.Name = "panelButtonNavigation";
            this.panelButtonNavigation.RowCount = 9;
            this.panelButtonNavigation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelButtonNavigation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.panelButtonNavigation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.panelButtonNavigation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.panelButtonNavigation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.panelButtonNavigation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.panelButtonNavigation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.panelButtonNavigation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.panelButtonNavigation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.panelButtonNavigation.Size = new System.Drawing.Size(273, 729);
            this.panelButtonNavigation.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Topcast_Report_Manager.Properties.Resources.TopcastLogo;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(267, 53);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // labelConnectionString
            // 
            this.labelConnectionString.AutoSize = true;
            this.labelConnectionString.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelConnectionString.ForeColor = System.Drawing.Color.Gray;
            this.labelConnectionString.Location = new System.Drawing.Point(3, 59);
            this.labelConnectionString.Name = "labelConnectionString";
            this.labelConnectionString.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.labelConnectionString.Size = new System.Drawing.Size(267, 50);
            this.labelConnectionString.TabIndex = 2;
            this.labelConnectionString.Text = "Connection String";
            // 
            // buttonOpenSearch
            // 
            this.buttonOpenSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonOpenSearch.FlatAppearance.BorderSize = 0;
            this.buttonOpenSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOpenSearch.ForeColor = System.Drawing.Color.Gray;
            this.buttonOpenSearch.Image = global::Topcast_Report_Manager.Properties.Resources._001_search;
            this.buttonOpenSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonOpenSearch.Location = new System.Drawing.Point(3, 182);
            this.buttonOpenSearch.Name = "buttonOpenSearch";
            this.buttonOpenSearch.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonOpenSearch.Size = new System.Drawing.Size(267, 94);
            this.buttonOpenSearch.TabIndex = 1;
            this.buttonOpenSearch.Text = "BTN_SEARCH";
            this.buttonOpenSearch.UseVisualStyleBackColor = true;
            this.buttonOpenSearch.Click += new System.EventHandler(this.buttonOpenSearch_Click);
            // 
            // labelConnectionCheck
            // 
            this.labelConnectionCheck.AutoSize = true;
            this.labelConnectionCheck.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelConnectionCheck.ForeColor = System.Drawing.Color.Gray;
            this.labelConnectionCheck.Location = new System.Drawing.Point(3, 109);
            this.labelConnectionCheck.Name = "labelConnectionCheck";
            this.labelConnectionCheck.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.labelConnectionCheck.Size = new System.Drawing.Size(267, 70);
            this.labelConnectionCheck.TabIndex = 3;
            this.labelConnectionCheck.Text = "Connection Check";
            this.labelConnectionCheck.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonOpenShowData
            // 
            this.buttonOpenShowData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonOpenShowData.FlatAppearance.BorderSize = 0;
            this.buttonOpenShowData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOpenShowData.ForeColor = System.Drawing.Color.Gray;
            this.buttonOpenShowData.Image = global::Topcast_Report_Manager.Properties.Resources._024_analytics;
            this.buttonOpenShowData.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonOpenShowData.Location = new System.Drawing.Point(3, 282);
            this.buttonOpenShowData.Name = "buttonOpenShowData";
            this.buttonOpenShowData.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonOpenShowData.Size = new System.Drawing.Size(267, 94);
            this.buttonOpenShowData.TabIndex = 4;
            this.buttonOpenShowData.Text = "BTN_DATA";
            this.buttonOpenShowData.UseVisualStyleBackColor = true;
            this.buttonOpenShowData.Click += new System.EventHandler(this.buttonOpenShowData_Click);
            // 
            // buttonOpenShowTrend
            // 
            this.buttonOpenShowTrend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonOpenShowTrend.FlatAppearance.BorderSize = 0;
            this.buttonOpenShowTrend.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOpenShowTrend.ForeColor = System.Drawing.Color.Gray;
            this.buttonOpenShowTrend.Image = global::Topcast_Report_Manager.Properties.Resources._022_timeline;
            this.buttonOpenShowTrend.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonOpenShowTrend.Location = new System.Drawing.Point(3, 382);
            this.buttonOpenShowTrend.Name = "buttonOpenShowTrend";
            this.buttonOpenShowTrend.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonOpenShowTrend.Size = new System.Drawing.Size(267, 94);
            this.buttonOpenShowTrend.TabIndex = 5;
            this.buttonOpenShowTrend.Text = "BTN_TRENDS";
            this.buttonOpenShowTrend.UseVisualStyleBackColor = true;
            this.buttonOpenShowTrend.Click += new System.EventHandler(this.buttonOpenShowTrend_Click);
            // 
            // buttonOpenShowAlarmsEvents
            // 
            this.buttonOpenShowAlarmsEvents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonOpenShowAlarmsEvents.FlatAppearance.BorderSize = 0;
            this.buttonOpenShowAlarmsEvents.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOpenShowAlarmsEvents.ForeColor = System.Drawing.Color.Gray;
            this.buttonOpenShowAlarmsEvents.Image = global::Topcast_Report_Manager.Properties.Resources._036_notifications_bell_button;
            this.buttonOpenShowAlarmsEvents.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonOpenShowAlarmsEvents.Location = new System.Drawing.Point(3, 482);
            this.buttonOpenShowAlarmsEvents.Name = "buttonOpenShowAlarmsEvents";
            this.buttonOpenShowAlarmsEvents.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonOpenShowAlarmsEvents.Size = new System.Drawing.Size(267, 94);
            this.buttonOpenShowAlarmsEvents.TabIndex = 7;
            this.buttonOpenShowAlarmsEvents.Text = "BTN_ALARMS_EVENTS";
            this.buttonOpenShowAlarmsEvents.UseVisualStyleBackColor = true;
            this.buttonOpenShowAlarmsEvents.Click += new System.EventHandler(this.buttonOpenShowAlarmsEvents_Click);
            // 
            // buttonOpenReport
            // 
            this.buttonOpenReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonOpenReport.FlatAppearance.BorderSize = 0;
            this.buttonOpenReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOpenReport.ForeColor = System.Drawing.Color.DimGray;
            this.buttonOpenReport.Image = global::Topcast_Report_Manager.Properties.Resources._031_printer;
            this.buttonOpenReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonOpenReport.Location = new System.Drawing.Point(3, 582);
            this.buttonOpenReport.Name = "buttonOpenReport";
            this.buttonOpenReport.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonOpenReport.Size = new System.Drawing.Size(267, 94);
            this.buttonOpenReport.TabIndex = 6;
            this.buttonOpenReport.Text = "BTN_REPORTS";
            this.buttonOpenReport.UseVisualStyleBackColor = true;
            this.buttonOpenReport.Click += new System.EventHandler(this.buttonOpenReport_Click);
            // 
            // panel_Flags
            // 
            this.panel_Flags.Controls.Add(this.tableLayoutPanelFlags);
            this.panel_Flags.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Flags.Location = new System.Drawing.Point(3, 682);
            this.panel_Flags.Name = "panel_Flags";
            this.panel_Flags.Size = new System.Drawing.Size(267, 44);
            this.panel_Flags.TabIndex = 8;
            // 
            // tableLayoutPanelFlags
            // 
            this.tableLayoutPanelFlags.ColumnCount = 5;
            this.tableLayoutPanelFlags.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelFlags.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelFlags.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelFlags.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelFlags.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelFlags.Controls.Add(this.button_ES, 4, 0);
            this.tableLayoutPanelFlags.Controls.Add(this.button_DE, 3, 0);
            this.tableLayoutPanelFlags.Controls.Add(this.button_EN, 1, 0);
            this.tableLayoutPanelFlags.Controls.Add(this.button_IT, 0, 0);
            this.tableLayoutPanelFlags.Controls.Add(this.button_FR, 2, 0);
            this.tableLayoutPanelFlags.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelFlags.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelFlags.Name = "tableLayoutPanelFlags";
            this.tableLayoutPanelFlags.RowCount = 1;
            this.tableLayoutPanelFlags.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelFlags.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanelFlags.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanelFlags.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanelFlags.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanelFlags.Size = new System.Drawing.Size(267, 44);
            this.tableLayoutPanelFlags.TabIndex = 0;
            // 
            // button_ES
            // 
            this.button_ES.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_ES.Image = global::Topcast_Report_Manager.Properties.Resources.spain;
            this.button_ES.Location = new System.Drawing.Point(215, 3);
            this.button_ES.Name = "button_ES";
            this.button_ES.Size = new System.Drawing.Size(49, 38);
            this.button_ES.TabIndex = 4;
            this.button_ES.UseVisualStyleBackColor = true;
            this.button_ES.Click += new System.EventHandler(this.button_ES_Click);
            // 
            // button_DE
            // 
            this.button_DE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_DE.Image = global::Topcast_Report_Manager.Properties.Resources.germany;
            this.button_DE.Location = new System.Drawing.Point(162, 3);
            this.button_DE.Name = "button_DE";
            this.button_DE.Size = new System.Drawing.Size(47, 38);
            this.button_DE.TabIndex = 3;
            this.button_DE.UseVisualStyleBackColor = true;
            this.button_DE.Click += new System.EventHandler(this.button_DE_Click);
            // 
            // button_EN
            // 
            this.button_EN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_EN.Image = global::Topcast_Report_Manager.Properties.Resources.united_kingdom;
            this.button_EN.Location = new System.Drawing.Point(56, 3);
            this.button_EN.Name = "button_EN";
            this.button_EN.Size = new System.Drawing.Size(47, 38);
            this.button_EN.TabIndex = 1;
            this.button_EN.UseVisualStyleBackColor = true;
            this.button_EN.Click += new System.EventHandler(this.button_EN_Click);
            // 
            // button_IT
            // 
            this.button_IT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_IT.Image = global::Topcast_Report_Manager.Properties.Resources.italy;
            this.button_IT.Location = new System.Drawing.Point(3, 3);
            this.button_IT.Name = "button_IT";
            this.button_IT.Size = new System.Drawing.Size(47, 38);
            this.button_IT.TabIndex = 0;
            this.button_IT.UseVisualStyleBackColor = true;
            this.button_IT.Click += new System.EventHandler(this.button_IT_Click);
            // 
            // button_FR
            // 
            this.button_FR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_FR.Image = global::Topcast_Report_Manager.Properties.Resources.france;
            this.button_FR.Location = new System.Drawing.Point(109, 3);
            this.button_FR.Name = "button_FR";
            this.button_FR.Size = new System.Drawing.Size(47, 38);
            this.button_FR.TabIndex = 2;
            this.button_FR.UseVisualStyleBackColor = true;
            this.button_FR.Click += new System.EventHandler(this.button_FR_Click);
            // 
            // panelChildform
            // 
            this.panelChildform.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildform.Location = new System.Drawing.Point(273, 0);
            this.panelChildform.Name = "panelChildform";
            this.panelChildform.Size = new System.Drawing.Size(735, 729);
            this.panelChildform.TabIndex = 1;
            // 
            // Topcast_Report_Manager_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.panelChildform);
            this.Controls.Add(this.panelNavigation);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Topcast_Report_Manager_Main";
            this.Text = "Topcast Report Manager";
            this.Load += new System.EventHandler(this.Topcast_Report_Manager_Main_Load);
            this.panelNavigation.ResumeLayout(false);
            this.panelButtonNavigation.ResumeLayout(false);
            this.panelButtonNavigation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_Flags.ResumeLayout(false);
            this.tableLayoutPanelFlags.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelNavigation;
        private System.Windows.Forms.Panel panelChildform;
        private System.Windows.Forms.TableLayoutPanel panelButtonNavigation;
        private System.Windows.Forms.Button buttonOpenSearch;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelConnectionString;
        private System.Windows.Forms.Label labelConnectionCheck;
        private System.Windows.Forms.Button buttonOpenShowData;
        private System.Windows.Forms.Button buttonOpenShowTrend;
        private System.Windows.Forms.Button buttonOpenReport;
        private System.Windows.Forms.Button buttonOpenShowAlarmsEvents;
        private System.Windows.Forms.Panel panel_Flags;
        private System.Windows.Forms.Button button_EN;
        private System.Windows.Forms.Button button_IT;
        private System.Windows.Forms.Button button_ES;
        private System.Windows.Forms.Button button_DE;
        private System.Windows.Forms.Button button_FR;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelFlags;
    }
}

