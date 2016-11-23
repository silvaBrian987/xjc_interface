using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace xjc_interface
{
    public partial class frmLog : Form
    {
        public frmLog()
        {
            InitializeComponent();
        }

        // This delegate enables asynchronous calls for setting
        // the text property on a TextBox control.
        delegate void AppendLogTextCallback(string text);

        // This method demonstrates a pattern for making thread-safe
        // calls on a Windows Forms control. 
        //
        // If the calling thread is different from the thread that
        // created the TextBox control, this method creates a
        // SetTextCallback and calls itself asynchronously using the
        // Invoke method.
        //
        // If the calling thread is the same as the thread that created
        // the TextBox control, the Text property is set directly. 

        public void AppendLogText(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.txtLog.InvokeRequired)
            {
                AppendLogTextCallback d = new AppendLogTextCallback(AppendLogText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                //this.txtLog.Text += text + "\n";
                this.txtLog.AppendText(text);
                this.txtLog.AppendText(Environment.NewLine);
            }
        }
    }
}
