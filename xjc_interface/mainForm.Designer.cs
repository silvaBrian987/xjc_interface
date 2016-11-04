namespace xjc_interface
{
    partial class mainForm
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
            this.filePicker_xjcPath = new System.Windows.Forms.OpenFileDialog();
            this.btnXjcPath = new System.Windows.Forms.Button();
            this.txtXjcPath = new System.Windows.Forms.TextBox();
            this.lblXjcPath = new System.Windows.Forms.Label();
            this.gBoxArguments = new System.Windows.Forms.GroupBox();
            this.btnAddArg = new System.Windows.Forms.Button();
            this.lBoxArg = new System.Windows.Forms.ListBox();
            this.txtExecute = new System.Windows.Forms.Button();
            this.gBoxArguments.SuspendLayout();
            this.SuspendLayout();
            // 
            // filePicker_xjcPath
            // 
            this.filePicker_xjcPath.FileName = "xjc.bat";
            this.filePicker_xjcPath.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // btnXjcPath
            // 
            this.btnXjcPath.Location = new System.Drawing.Point(467, 7);
            this.btnXjcPath.Name = "btnXjcPath";
            this.btnXjcPath.Size = new System.Drawing.Size(26, 19);
            this.btnXjcPath.TabIndex = 0;
            this.btnXjcPath.UseVisualStyleBackColor = true;
            this.btnXjcPath.Click += new System.EventHandler(this.btnXjcPath_Click);
            // 
            // txtXjcPath
            // 
            this.txtXjcPath.Enabled = false;
            this.txtXjcPath.Location = new System.Drawing.Point(69, 6);
            this.txtXjcPath.Name = "txtXjcPath";
            this.txtXjcPath.Size = new System.Drawing.Size(392, 20);
            this.txtXjcPath.TabIndex = 1;
            this.txtXjcPath.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblXjcPath
            // 
            this.lblXjcPath.AutoSize = true;
            this.lblXjcPath.Location = new System.Drawing.Point(12, 9);
            this.lblXjcPath.Name = "lblXjcPath";
            this.lblXjcPath.Size = new System.Drawing.Size(51, 13);
            this.lblXjcPath.TabIndex = 2;
            this.lblXjcPath.Text = "XJC Path";
            // 
            // gBoxArguments
            // 
            this.gBoxArguments.Controls.Add(this.txtExecute);
            this.gBoxArguments.Controls.Add(this.btnAddArg);
            this.gBoxArguments.Controls.Add(this.lBoxArg);
            this.gBoxArguments.Location = new System.Drawing.Point(15, 32);
            this.gBoxArguments.Name = "gBoxArguments";
            this.gBoxArguments.Size = new System.Drawing.Size(477, 253);
            this.gBoxArguments.TabIndex = 3;
            this.gBoxArguments.TabStop = false;
            this.gBoxArguments.Text = "Arguments";
            // 
            // btnAddArg
            // 
            this.btnAddArg.Location = new System.Drawing.Point(427, 19);
            this.btnAddArg.Name = "btnAddArg";
            this.btnAddArg.Size = new System.Drawing.Size(44, 22);
            this.btnAddArg.TabIndex = 1;
            this.btnAddArg.Text = "Add";
            this.btnAddArg.UseVisualStyleBackColor = true;
            this.btnAddArg.Click += new System.EventHandler(this.btnAddArg_Click);
            // 
            // lBoxArg
            // 
            this.lBoxArg.FormattingEnabled = true;
            this.lBoxArg.Location = new System.Drawing.Point(6, 19);
            this.lBoxArg.Name = "lBoxArg";
            this.lBoxArg.Size = new System.Drawing.Size(415, 225);
            this.lBoxArg.TabIndex = 0;
            // 
            // txtExecute
            // 
            this.txtExecute.Location = new System.Drawing.Point(427, 222);
            this.txtExecute.Name = "txtExecute";
            this.txtExecute.Size = new System.Drawing.Size(44, 22);
            this.txtExecute.TabIndex = 2;
            this.txtExecute.Text = "Exec";
            this.txtExecute.UseVisualStyleBackColor = true;
            this.txtExecute.Click += new System.EventHandler(this.txtExecute_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 297);
            this.Controls.Add(this.gBoxArguments);
            this.Controls.Add(this.lblXjcPath);
            this.Controls.Add(this.txtXjcPath);
            this.Controls.Add(this.btnXjcPath);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gBoxArguments.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog filePicker_xjcPath;
        private System.Windows.Forms.Button btnXjcPath;
        private System.Windows.Forms.TextBox txtXjcPath;
        private System.Windows.Forms.Label lblXjcPath;
        private System.Windows.Forms.GroupBox gBoxArguments;
        private System.Windows.Forms.Button btnAddArg;
        private System.Windows.Forms.ListBox lBoxArg;
        private System.Windows.Forms.Button txtExecute;
    }
}

