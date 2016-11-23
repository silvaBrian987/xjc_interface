namespace xjc_interface
{
    partial class frmLog
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
            this.gBoxLog = new System.Windows.Forms.GroupBox();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.gBoxLog.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBoxLog
            // 
            this.gBoxLog.Controls.Add(this.txtLog);
            this.gBoxLog.Location = new System.Drawing.Point(16, 16);
            this.gBoxLog.Name = "gBoxLog";
            this.gBoxLog.Size = new System.Drawing.Size(664, 328);
            this.gBoxLog.TabIndex = 0;
            this.gBoxLog.TabStop = false;
            // 
            // txtLog
            // 
            this.txtLog.AccessibleName = "txtLog";
            this.txtLog.Location = new System.Drawing.Point(16, 24);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.Size = new System.Drawing.Size(632, 288);
            this.txtLog.TabIndex = 0;
            // 
            // frmLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 353);
            this.Controls.Add(this.gBoxLog);
            this.Name = "frmLog";
            this.Text = "frmLog";
            this.gBoxLog.ResumeLayout(false);
            this.gBoxLog.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gBoxLog;
        public System.Windows.Forms.TextBox txtLog;
    }
}