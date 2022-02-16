namespace Topcast_Report_Manager.Controls
{
    partial class cursorValue
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

        #region Codice generato da Progettazione componenti

        /// <summary> 
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare 
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxCursorValue = new System.Windows.Forms.TextBox();
            this.labelSeriesName = new System.Windows.Forms.Label();
            this.buttonHide = new System.Windows.Forms.Button();
            this.labelUnit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxCursorValue
            // 
            this.textBoxCursorValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxCursorValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxCursorValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCursorValue.ForeColor = System.Drawing.Color.Gray;
            this.textBoxCursorValue.Location = new System.Drawing.Point(3, 17);
            this.textBoxCursorValue.Name = "textBoxCursorValue";
            this.textBoxCursorValue.ReadOnly = true;
            this.textBoxCursorValue.Size = new System.Drawing.Size(123, 20);
            this.textBoxCursorValue.TabIndex = 6;
            // 
            // labelSeriesName
            // 
            this.labelSeriesName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelSeriesName.AutoSize = true;
            this.labelSeriesName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSeriesName.ForeColor = System.Drawing.Color.Gray;
            this.labelSeriesName.Location = new System.Drawing.Point(3, 3);
            this.labelSeriesName.Name = "labelSeriesName";
            this.labelSeriesName.Size = new System.Drawing.Size(108, 13);
            this.labelSeriesName.TabIndex = 7;
            this.labelSeriesName.Text = "LBL_SERIES_NAME";
            // 
            // buttonHide
            // 
            this.buttonHide.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHide.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHide.ForeColor = System.Drawing.Color.Gray;
            this.buttonHide.Location = new System.Drawing.Point(191, 17);
            this.buttonHide.Name = "buttonHide";
            this.buttonHide.Size = new System.Drawing.Size(31, 20);
            this.buttonHide.TabIndex = 8;
            this.buttonHide.Text = "X";
            this.buttonHide.UseVisualStyleBackColor = true;
            this.buttonHide.Click += new System.EventHandler(this.buttonHide_Click);
            // 
            // labelUnit
            // 
            this.labelUnit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelUnit.AutoSize = true;
            this.labelUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelUnit.ForeColor = System.Drawing.Color.Gray;
            this.labelUnit.Location = new System.Drawing.Point(130, 21);
            this.labelUnit.Name = "labelUnit";
            this.labelUnit.Size = new System.Drawing.Size(58, 13);
            this.labelUnit.TabIndex = 9;
            this.labelUnit.Text = "LBL_UNIT";
            // 
            // cursorValue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelUnit);
            this.Controls.Add(this.buttonHide);
            this.Controls.Add(this.labelSeriesName);
            this.Controls.Add(this.textBoxCursorValue);
            this.Name = "cursorValue";
            this.Size = new System.Drawing.Size(225, 40);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxCursorValue;
        private System.Windows.Forms.Label labelSeriesName;
        private System.Windows.Forms.Button buttonHide;
        private System.Windows.Forms.Label labelUnit;
    }
}
