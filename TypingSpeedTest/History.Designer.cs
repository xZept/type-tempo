namespace TypingSpeedTest
{
    partial class frmHistory
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
            this.lblHistory = new System.Windows.Forms.Label();
            this.lstHistory = new System.Windows.Forms.ListView();
            this.DATE = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.WPM = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ACCURACY = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lblHistory
            // 
            this.lblHistory.AutoSize = true;
            this.lblHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.70909F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHistory.Location = new System.Drawing.Point(99, 24);
            this.lblHistory.Name = "lblHistory";
            this.lblHistory.Size = new System.Drawing.Size(127, 29);
            this.lblHistory.TabIndex = 0;
            this.lblHistory.Text = "HISTORY";
            // 
            // lstHistory
            // 
            this.lstHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(142)))), ((int)(((byte)(127)))));
            this.lstHistory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.DATE,
            this.WPM,
            this.ACCURACY});
            this.lstHistory.HideSelection = false;
            this.lstHistory.Location = new System.Drawing.Point(25, 77);
            this.lstHistory.Name = "lstHistory";
            this.lstHistory.Size = new System.Drawing.Size(269, 349);
            this.lstHistory.TabIndex = 1;
            this.lstHistory.UseCompatibleStateImageBehavior = false;
            this.lstHistory.View = System.Windows.Forms.View.List;
            // 
            // frmHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(318, 450);
            this.Controls.Add(this.lstHistory);
            this.Controls.Add(this.lblHistory);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.Name = "frmHistory";
            this.Text = "TT - TypeTempo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHistory;
        private System.Windows.Forms.ListView lstHistory;
        private System.Windows.Forms.ColumnHeader DATE;
        private System.Windows.Forms.ColumnHeader WPM;
        private System.Windows.Forms.ColumnHeader ACCURACY;
    }
}