
namespace Topcast_Report_Manager.Forms
{
    partial class Topcast_Report_Manager_Show_Trend
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
            this.comboBoxIDList = new System.Windows.Forms.ComboBox();
            this.panelSelectID = new System.Windows.Forms.Panel();
            this.labelSelectID = new System.Windows.Forms.Label();
            this.panelPlot = new System.Windows.Forms.Panel();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.buttonShowTrends = new System.Windows.Forms.Button();
            this.tableLayoutPanelVar = new System.Windows.Forms.TableLayoutPanel();
            this.listBoxHide = new System.Windows.Forms.ListBox();
            this.listBoxShow = new System.Windows.Forms.ListBox();
            this.tableLayoutPanelButtons = new System.Windows.Forms.TableLayoutPanel();
            this.buttonHide = new System.Windows.Forms.Button();
            this.buttonShow = new System.Windows.Forms.Button();
            this.buttonShowAll = new System.Windows.Forms.Button();
            this.buttonHideAll = new System.Windows.Forms.Button();
            this.tableLayoutPanelPlot = new System.Windows.Forms.TableLayoutPanel();
            this.panelTrendControls = new System.Windows.Forms.Panel();
            this.buttonShrink = new System.Windows.Forms.Button();
            this.buttonEnlarge = new System.Windows.Forms.Button();
            this.buttonTakePicture = new System.Windows.Forms.Button();
            this.buttonZoomOut = new System.Windows.Forms.Button();
            this.buttonZoomIn = new System.Windows.Forms.Button();
            this.buttonPause = new System.Windows.Forms.Button();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.panelCursorValue = new System.Windows.Forms.Panel();
            this.panelSelectID.SuspendLayout();
            this.tableLayoutPanel.SuspendLayout();
            this.tableLayoutPanelVar.SuspendLayout();
            this.tableLayoutPanelButtons.SuspendLayout();
            this.tableLayoutPanelPlot.SuspendLayout();
            this.panelTrendControls.SuspendLayout();
            this.SuspendLayout();
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
            // panelSelectID
            // 
            this.panelSelectID.Controls.Add(this.labelSelectID);
            this.panelSelectID.Controls.Add(this.comboBoxIDList);
            this.panelSelectID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSelectID.Location = new System.Drawing.Point(3, 3);
            this.panelSelectID.Name = "panelSelectID";
            this.panelSelectID.Size = new System.Drawing.Size(1037, 64);
            this.panelSelectID.TabIndex = 2;
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
            // panelPlot
            // 
            this.panelPlot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPlot.Location = new System.Drawing.Point(231, 3);
            this.panelPlot.Name = "panelPlot";
            this.panelPlot.Size = new System.Drawing.Size(733, 380);
            this.panelPlot.TabIndex = 4;
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 1;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Controls.Add(this.panelSelectID, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.buttonShowTrends, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.tableLayoutPanelVar, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.tableLayoutPanelPlot, 0, 3);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 4;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 39.341F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.08403F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.57497F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(1043, 842);
            this.tableLayoutPanel.TabIndex = 6;
            // 
            // buttonShowTrends
            // 
            this.buttonShowTrends.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonShowTrends.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShowTrends.ForeColor = System.Drawing.Color.Gray;
            this.buttonShowTrends.Image = global::Topcast_Report_Manager.Properties.Resources._022_timeline;
            this.buttonShowTrends.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonShowTrends.Location = new System.Drawing.Point(3, 376);
            this.buttonShowTrends.Name = "buttonShowTrends";
            this.buttonShowTrends.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonShowTrends.Size = new System.Drawing.Size(1037, 71);
            this.buttonShowTrends.TabIndex = 1;
            this.buttonShowTrends.Text = "BTN_SHOW_TRENDS";
            this.buttonShowTrends.UseVisualStyleBackColor = true;
            this.buttonShowTrends.Click += new System.EventHandler(this.buttonShowTrends_Click);
            // 
            // tableLayoutPanelVar
            // 
            this.tableLayoutPanelVar.ColumnCount = 3;
            this.tableLayoutPanelVar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelVar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelVar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelVar.Controls.Add(this.listBoxHide, 0, 0);
            this.tableLayoutPanelVar.Controls.Add(this.listBoxShow, 2, 0);
            this.tableLayoutPanelVar.Controls.Add(this.tableLayoutPanelButtons, 1, 0);
            this.tableLayoutPanelVar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelVar.Location = new System.Drawing.Point(3, 73);
            this.tableLayoutPanelVar.Name = "tableLayoutPanelVar";
            this.tableLayoutPanelVar.RowCount = 1;
            this.tableLayoutPanelVar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelVar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 297F));
            this.tableLayoutPanelVar.Size = new System.Drawing.Size(1037, 297);
            this.tableLayoutPanelVar.TabIndex = 5;
            // 
            // listBoxHide
            // 
            this.listBoxHide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxHide.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.listBoxHide.ForeColor = System.Drawing.Color.Gray;
            this.listBoxHide.FormattingEnabled = true;
            this.listBoxHide.ItemHeight = 24;
            this.listBoxHide.Location = new System.Drawing.Point(3, 3);
            this.listBoxHide.Name = "listBoxHide";
            this.listBoxHide.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxHide.Size = new System.Drawing.Size(339, 291);
            this.listBoxHide.TabIndex = 1;
            // 
            // listBoxShow
            // 
            this.listBoxShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.listBoxShow.ForeColor = System.Drawing.Color.Gray;
            this.listBoxShow.FormattingEnabled = true;
            this.listBoxShow.ItemHeight = 24;
            this.listBoxShow.Location = new System.Drawing.Point(693, 3);
            this.listBoxShow.Name = "listBoxShow";
            this.listBoxShow.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxShow.Size = new System.Drawing.Size(341, 291);
            this.listBoxShow.TabIndex = 2;
            // 
            // tableLayoutPanelButtons
            // 
            this.tableLayoutPanelButtons.ColumnCount = 1;
            this.tableLayoutPanelButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelButtons.Controls.Add(this.buttonHide, 0, 3);
            this.tableLayoutPanelButtons.Controls.Add(this.buttonShow, 0, 0);
            this.tableLayoutPanelButtons.Controls.Add(this.buttonShowAll, 0, 1);
            this.tableLayoutPanelButtons.Controls.Add(this.buttonHideAll, 0, 2);
            this.tableLayoutPanelButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelButtons.Location = new System.Drawing.Point(348, 3);
            this.tableLayoutPanelButtons.Name = "tableLayoutPanelButtons";
            this.tableLayoutPanelButtons.RowCount = 4;
            this.tableLayoutPanelButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelButtons.Size = new System.Drawing.Size(339, 291);
            this.tableLayoutPanelButtons.TabIndex = 3;
            // 
            // buttonHide
            // 
            this.buttonHide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonHide.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHide.ForeColor = System.Drawing.Color.Gray;
            this.buttonHide.Image = global::Topcast_Report_Manager.Properties.Resources._005_left_chevron;
            this.buttonHide.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonHide.Location = new System.Drawing.Point(3, 219);
            this.buttonHide.Name = "buttonHide";
            this.buttonHide.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.buttonHide.Size = new System.Drawing.Size(333, 69);
            this.buttonHide.TabIndex = 5;
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
            this.buttonShow.Size = new System.Drawing.Size(333, 66);
            this.buttonShow.TabIndex = 1;
            this.buttonShow.Text = "BTN_SHOW";
            this.buttonShow.UseVisualStyleBackColor = true;
            this.buttonShow.Click += new System.EventHandler(this.buttonShow_Click);
            // 
            // buttonShowAll
            // 
            this.buttonShowAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonShowAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShowAll.ForeColor = System.Drawing.Color.Gray;
            this.buttonShowAll.Image = global::Topcast_Report_Manager.Properties.Resources._004_right_chevron;
            this.buttonShowAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonShowAll.Location = new System.Drawing.Point(3, 75);
            this.buttonShowAll.Name = "buttonShowAll";
            this.buttonShowAll.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonShowAll.Size = new System.Drawing.Size(333, 66);
            this.buttonShowAll.TabIndex = 3;
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
            this.buttonHideAll.Location = new System.Drawing.Point(3, 147);
            this.buttonHideAll.Name = "buttonHideAll";
            this.buttonHideAll.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.buttonHideAll.Size = new System.Drawing.Size(333, 66);
            this.buttonHideAll.TabIndex = 4;
            this.buttonHideAll.Text = "BTN_HIDE_ALL";
            this.buttonHideAll.UseVisualStyleBackColor = true;
            this.buttonHideAll.Click += new System.EventHandler(this.buttonHideAll_Click);
            // 
            // tableLayoutPanelPlot
            // 
            this.tableLayoutPanelPlot.ColumnCount = 3;
            this.tableLayoutPanelPlot.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 228F));
            this.tableLayoutPanelPlot.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelPlot.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanelPlot.Controls.Add(this.panelPlot, 1, 0);
            this.tableLayoutPanelPlot.Controls.Add(this.panelTrendControls, 2, 0);
            this.tableLayoutPanelPlot.Controls.Add(this.panelCursorValue, 0, 0);
            this.tableLayoutPanelPlot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelPlot.Location = new System.Drawing.Point(3, 453);
            this.tableLayoutPanelPlot.Name = "tableLayoutPanelPlot";
            this.tableLayoutPanelPlot.RowCount = 1;
            this.tableLayoutPanelPlot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelPlot.Size = new System.Drawing.Size(1037, 386);
            this.tableLayoutPanelPlot.TabIndex = 7;
            // 
            // panelTrendControls
            // 
            this.panelTrendControls.Controls.Add(this.buttonShrink);
            this.panelTrendControls.Controls.Add(this.buttonEnlarge);
            this.panelTrendControls.Controls.Add(this.buttonTakePicture);
            this.panelTrendControls.Controls.Add(this.buttonZoomOut);
            this.panelTrendControls.Controls.Add(this.buttonZoomIn);
            this.panelTrendControls.Controls.Add(this.buttonPause);
            this.panelTrendControls.Controls.Add(this.buttonPlay);
            this.panelTrendControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTrendControls.Location = new System.Drawing.Point(970, 3);
            this.panelTrendControls.Name = "panelTrendControls";
            this.panelTrendControls.Size = new System.Drawing.Size(64, 380);
            this.panelTrendControls.TabIndex = 5;
            // 
            // buttonShrink
            // 
            this.buttonShrink.AutoSize = true;
            this.buttonShrink.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonShrink.ForeColor = System.Drawing.Color.Gray;
            this.buttonShrink.Image = global::Topcast_Report_Manager.Properties.Resources._013_minimize;
            this.buttonShrink.Location = new System.Drawing.Point(0, 300);
            this.buttonShrink.Name = "buttonShrink";
            this.buttonShrink.Size = new System.Drawing.Size(64, 50);
            this.buttonShrink.TabIndex = 12;
            this.buttonShrink.UseVisualStyleBackColor = true;
            this.buttonShrink.Click += new System.EventHandler(this.buttonShrink_Click);
            // 
            // buttonEnlarge
            // 
            this.buttonEnlarge.AutoSize = true;
            this.buttonEnlarge.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonEnlarge.ForeColor = System.Drawing.Color.Gray;
            this.buttonEnlarge.Image = global::Topcast_Report_Manager.Properties.Resources._006_fullscreen;
            this.buttonEnlarge.Location = new System.Drawing.Point(0, 250);
            this.buttonEnlarge.Name = "buttonEnlarge";
            this.buttonEnlarge.Size = new System.Drawing.Size(64, 50);
            this.buttonEnlarge.TabIndex = 11;
            this.buttonEnlarge.UseVisualStyleBackColor = true;
            this.buttonEnlarge.Click += new System.EventHandler(this.buttonEnlarge_Click);
            // 
            // buttonTakePicture
            // 
            this.buttonTakePicture.AutoSize = true;
            this.buttonTakePicture.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonTakePicture.ForeColor = System.Drawing.Color.Gray;
            this.buttonTakePicture.Image = global::Topcast_Report_Manager.Properties.Resources._030_camera;
            this.buttonTakePicture.Location = new System.Drawing.Point(0, 200);
            this.buttonTakePicture.Name = "buttonTakePicture";
            this.buttonTakePicture.Size = new System.Drawing.Size(64, 50);
            this.buttonTakePicture.TabIndex = 10;
            this.buttonTakePicture.UseVisualStyleBackColor = true;
            this.buttonTakePicture.Click += new System.EventHandler(this.buttonTakePicture_Click);
            // 
            // buttonZoomOut
            // 
            this.buttonZoomOut.AutoSize = true;
            this.buttonZoomOut.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonZoomOut.ForeColor = System.Drawing.Color.Gray;
            this.buttonZoomOut.Image = global::Topcast_Report_Manager.Properties.Resources._026_zoom_out;
            this.buttonZoomOut.Location = new System.Drawing.Point(0, 150);
            this.buttonZoomOut.Name = "buttonZoomOut";
            this.buttonZoomOut.Size = new System.Drawing.Size(64, 50);
            this.buttonZoomOut.TabIndex = 9;
            this.buttonZoomOut.UseVisualStyleBackColor = true;
            this.buttonZoomOut.Click += new System.EventHandler(this.buttonZoomOut_Click);
            // 
            // buttonZoomIn
            // 
            this.buttonZoomIn.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonZoomIn.ForeColor = System.Drawing.Color.Gray;
            this.buttonZoomIn.Image = global::Topcast_Report_Manager.Properties.Resources._025_zoom_in;
            this.buttonZoomIn.Location = new System.Drawing.Point(0, 100);
            this.buttonZoomIn.Name = "buttonZoomIn";
            this.buttonZoomIn.Size = new System.Drawing.Size(64, 50);
            this.buttonZoomIn.TabIndex = 8;
            this.buttonZoomIn.UseVisualStyleBackColor = true;
            this.buttonZoomIn.Click += new System.EventHandler(this.buttonZoomIn_Click);
            // 
            // buttonPause
            // 
            this.buttonPause.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonPause.ForeColor = System.Drawing.Color.Gray;
            this.buttonPause.Image = global::Topcast_Report_Manager.Properties.Resources._029_pause;
            this.buttonPause.Location = new System.Drawing.Point(0, 50);
            this.buttonPause.Name = "buttonPause";
            this.buttonPause.Size = new System.Drawing.Size(64, 50);
            this.buttonPause.TabIndex = 7;
            this.buttonPause.UseVisualStyleBackColor = true;
            this.buttonPause.Click += new System.EventHandler(this.buttonPause_Click);
            // 
            // buttonPlay
            // 
            this.buttonPlay.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonPlay.ForeColor = System.Drawing.Color.Gray;
            this.buttonPlay.Image = global::Topcast_Report_Manager.Properties.Resources._028_play_arrow;
            this.buttonPlay.Location = new System.Drawing.Point(0, 0);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(64, 50);
            this.buttonPlay.TabIndex = 6;
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // panelCursorValue
            // 
            this.panelCursorValue.AutoScroll = true;
            this.panelCursorValue.BackColor = System.Drawing.Color.Gainsboro;
            this.panelCursorValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCursorValue.Location = new System.Drawing.Point(3, 3);
            this.panelCursorValue.Name = "panelCursorValue";
            this.panelCursorValue.Size = new System.Drawing.Size(222, 380);
            this.panelCursorValue.TabIndex = 6;
            // 
            // Topcast_Report_Manager_Show_Trend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 842);
            this.Controls.Add(this.tableLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Topcast_Report_Manager_Show_Trend";
            this.Text = "Topcast_Report_Manager_Show_Trend";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Topcast_Report_Manager_Show_Trend_FormClosing);
            this.Load += new System.EventHandler(this.Topcast_Report_Manager_Show_Trend_Load);
            this.panelSelectID.ResumeLayout(false);
            this.panelSelectID.PerformLayout();
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanelVar.ResumeLayout(false);
            this.tableLayoutPanelButtons.ResumeLayout(false);
            this.tableLayoutPanelPlot.ResumeLayout(false);
            this.panelTrendControls.ResumeLayout(false);
            this.panelTrendControls.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxIDList;
        private System.Windows.Forms.Panel panelSelectID;
        private System.Windows.Forms.Button buttonShowTrends;
        private System.Windows.Forms.Panel panelPlot;
        private System.Windows.Forms.Label labelSelectID;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelVar;
        private System.Windows.Forms.ListBox listBoxHide;
        private System.Windows.Forms.ListBox listBoxShow;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelButtons;
        private System.Windows.Forms.Button buttonShow;
        private System.Windows.Forms.Button buttonShowAll;
        private System.Windows.Forms.Button buttonHideAll;
        private System.Windows.Forms.Button buttonHide;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelPlot;
        private System.Windows.Forms.Panel panelTrendControls;
        private System.Windows.Forms.Button buttonPause;
        private System.Windows.Forms.Button buttonZoomIn;
        private System.Windows.Forms.Button buttonZoomOut;
        private System.Windows.Forms.Button buttonTakePicture;
        private System.Windows.Forms.Panel panelCursorValue;
        private System.Windows.Forms.Button buttonEnlarge;
        private System.Windows.Forms.Button buttonShrink;
    }
}