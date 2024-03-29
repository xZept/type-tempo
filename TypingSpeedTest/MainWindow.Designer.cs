namespace TypingSpeedTest
{
    partial class frmMainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainWindow));
            this.txtUserInput = new System.Windows.Forms.TextBox();
            this.btnRetry = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtUserInput
            // 
            this.txtUserInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(142)))), ((int)(((byte)(127)))));
            this.txtUserInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUserInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.29091F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.txtUserInput.Location = new System.Drawing.Point(29, 28);
            this.txtUserInput.Multiline = true;
            this.txtUserInput.Name = "txtUserInput";
            this.txtUserInput.Size = new System.Drawing.Size(740, 322);
            this.txtUserInput.TabIndex = 0;
            this.txtUserInput.Text = resources.GetString("txtUserInput.Text");
            this.txtUserInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnRetry
            // 
            this.btnRetry.BackColor = System.Drawing.Color.Transparent;
            this.btnRetry.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRetry.BackgroundImage")));
            this.btnRetry.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRetry.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRetry.Location = new System.Drawing.Point(368, 371);
            this.btnRetry.Name = "btnRetry";
            this.btnRetry.Size = new System.Drawing.Size(62, 67);
            this.btnRetry.TabIndex = 2;
            this.btnRetry.UseVisualStyleBackColor = false;
            // 
            // frmMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRetry);
            this.Controls.Add(this.txtUserInput);
            this.Name = "frmMainWindow";
            this.Text = "TT - TypeTempo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUserInput;
        private System.Windows.Forms.Button btnRetry;
    }
}