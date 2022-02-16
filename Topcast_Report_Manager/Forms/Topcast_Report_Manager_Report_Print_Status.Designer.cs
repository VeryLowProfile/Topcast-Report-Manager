namespace Topcast_Report_Manager.Forms
{
    partial class Topcast_Report_Manager_Report_Print_Status
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Topcast_Report_Manager_Report_Print_Status));
            this.tableLayoutPanelPrintStatus = new System.Windows.Forms.TableLayoutPanel();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.tableLayoutPanelPrintStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelPrintStatus
            // 
            this.tableLayoutPanelPrintStatus.ColumnCount = 1;
            this.tableLayoutPanelPrintStatus.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelPrintStatus.Controls.Add(this.richTextBox, 0, 0);
            this.tableLayoutPanelPrintStatus.Controls.Add(this.progressBar, 0, 1);
            this.tableLayoutPanelPrintStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelPrintStatus.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelPrintStatus.Name = "tableLayoutPanelPrintStatus";
            this.tableLayoutPanelPrintStatus.RowCount = 2;
            this.tableLayoutPanelPrintStatus.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelPrintStatus.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelPrintStatus.Size = new System.Drawing.Size(464, 201);
            this.tableLayoutPanelPrintStatus.TabIndex = 0;
            // 
            // richTextBox
            // 
            this.richTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox.Location = new System.Drawing.Point(3, 3);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(458, 165);
            this.richTextBox.TabIndex = 0;
            this.richTextBox.Text = "";
            // 
            // progressBar
            // 
            this.progressBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBar.Location = new System.Drawing.Point(3, 174);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(458, 24);
            this.progressBar.TabIndex = 1;
            // 
            // Topcast_Report_Manager_Report_Print_Status
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 201);
            this.Controls.Add(this.tableLayoutPanelPrintStatus);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Topcast_Report_Manager_Report_Print_Status";
            this.Text = "Report Print Status";
            this.tableLayoutPanelPrintStatus.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelPrintStatus;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.ProgressBar progressBar;
    }
}