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
            this.SuspendLayout();
            // 
            // textBoxCursorValue
            // 
            this.textBoxCursorValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxCursorValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCursorValue.ForeColor = System.Drawing.Color.Gray;
            this.textBoxCursorValue.Location = new System.Drawing.Point(6, 17);
            this.textBoxCursorValue.Name = "textBoxCursorValue";
            this.textBoxCursorValue.ReadOnly = true;
            this.textBoxCursorValue.Size = new System.Drawing.Size(149, 20);
            this.textBoxCursorValue.TabIndex = 6;
            // 
            // labelSeriesName
            // 
            this.labelSeriesName.AutoSize = true;
            this.labelSeriesName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSeriesName.ForeColor = System.Drawing.Color.Gray;
            this.labelSeriesName.Location = new System.Drawing.Point(6, 3);
            this.labelSeriesName.Name = "labelSeriesName";
            this.labelSeriesName.Size = new System.Drawing.Size(108, 13);
            this.labelSeriesName.TabIndex = 7;
            this.labelSeriesName.Text = "LBL_SERIES_NAME";
            // 
            // cursorValue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelSeriesName);
            this.Controls.Add(this.textBoxCursorValue);
            this.Name = "cursorValue";
            this.Size = new System.Drawing.Size(200, 40);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxCursorValue;
        private System.Windows.Forms.Label labelSeriesName;
    }
}
