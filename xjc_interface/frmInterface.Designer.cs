namespace xjc_interface
{
    partial class frmInterface
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkBoxListParameters = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtXJCPath = new System.Windows.Forms.TextBox();
            this.txtXMLPath = new System.Windows.Forms.TextBox();
            this.btnProcess = new System.Windows.Forms.Button();
            this.btnXJCPathPicker = new System.Windows.Forms.Button();
            this.btnXMLPathPicker = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkBoxListParameters);
            this.groupBox1.Location = new System.Drawing.Point(16, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(264, 280);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parameters";
            // 
            // chkBoxListParameters
            // 
            this.chkBoxListParameters.FormattingEnabled = true;
            this.chkBoxListParameters.Location = new System.Drawing.Point(16, 24);
            this.chkBoxListParameters.Name = "chkBoxListParameters";
            this.chkBoxListParameters.Size = new System.Drawing.Size(232, 244);
            this.chkBoxListParameters.TabIndex = 0;
            this.chkBoxListParameters.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.chkBoxListParameters_ItemCheck);
            this.chkBoxListParameters.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "XJC Path";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "XML Path";
            // 
            // txtXJCPath
            // 
            this.txtXJCPath.Location = new System.Drawing.Point(80, 16);
            this.txtXJCPath.Name = "txtXJCPath";
            this.txtXJCPath.Size = new System.Drawing.Size(344, 20);
            this.txtXJCPath.TabIndex = 3;
            // 
            // txtXMLPath
            // 
            this.txtXMLPath.Location = new System.Drawing.Point(80, 56);
            this.txtXMLPath.Name = "txtXMLPath";
            this.txtXMLPath.Size = new System.Drawing.Size(344, 20);
            this.txtXMLPath.TabIndex = 4;
            // 
            // btnProcess
            // 
            this.btnProcess.Location = new System.Drawing.Point(288, 96);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(168, 23);
            this.btnProcess.TabIndex = 5;
            this.btnProcess.Text = "Process";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // btnXJCPathPicker
            // 
            this.btnXJCPathPicker.Location = new System.Drawing.Point(432, 16);
            this.btnXJCPathPicker.Name = "btnXJCPathPicker";
            this.btnXJCPathPicker.Size = new System.Drawing.Size(24, 16);
            this.btnXJCPathPicker.TabIndex = 6;
            this.btnXJCPathPicker.UseVisualStyleBackColor = true;
            this.btnXJCPathPicker.Click += new System.EventHandler(this.btnXJCPathPicker_Click);
            // 
            // btnXMLPathPicker
            // 
            this.btnXMLPathPicker.Location = new System.Drawing.Point(432, 56);
            this.btnXMLPathPicker.Name = "btnXMLPathPicker";
            this.btnXMLPathPicker.Size = new System.Drawing.Size(24, 16);
            this.btnXMLPathPicker.TabIndex = 7;
            this.btnXMLPathPicker.UseVisualStyleBackColor = true;
            this.btnXMLPathPicker.Click += new System.EventHandler(this.btnXMLPathPicker_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // frmInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 378);
            this.Controls.Add(this.btnXMLPathPicker);
            this.Controls.Add(this.btnXJCPathPicker);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.txtXMLPath);
            this.Controls.Add(this.txtXJCPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmInterface";
            this.Text = "XJC Interface";
            this.Load += new System.EventHandler(this.frmInterface_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckedListBox chkBoxListParameters;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtXJCPath;
        private System.Windows.Forms.TextBox txtXMLPath;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.Button btnXJCPathPicker;
        private System.Windows.Forms.Button btnXMLPathPicker;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}