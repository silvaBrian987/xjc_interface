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
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void btnXjcPath_Click(object sender, EventArgs e)
        {
            filePicker_xjcPath.ShowDialog();
            txtXjcPath.Text = filePicker_xjcPath.FileName;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddArg_Click(object sender, EventArgs e)
        {
            dialogInputForm dialog = new dialogInputForm();

            if (dialog.ShowDialog(this) == DialogResult.OK)
            {
                String arg = dialog.txtArgKey.Text.Trim() + " " + dialog.txtArgValue.Text.Trim();
                lBoxArg.Items.Add(arg);
            }
        }

        private void txtExecute_Click(object sender, EventArgs e)
        {
            String cmd = txtXjcPath.Text;

            if (cmd.Equals(""))
            {
                MessageBox.Show("No path, no program.");
                btnXjcPath.Focus();
                return;
            }

            foreach (var listBoxItem in lBoxArg.Items)
            {
                cmd += " " + listBoxItem.ToString();
            }

            //MessageBox.Show(cmd);
            
            MessageBox.Show(this.ExecuteCommand(cmd));

            //System.Diagnostics.Process.Start("cmd", "/c " + cmd);
        }

        private string ExecuteCommand(string _Command)
        {
            //Indicamos que deseamos inicializar el proceso cmd.exe junto a un comando de arranque. 
            //(/C, le indicamos al proceso cmd que deseamos que cuando termine la tarea asignada se cierre el proceso).
            //Para mas informacion consulte la ayuda de la consola con cmd.exe /? 
            System.Diagnostics.ProcessStartInfo procStartInfo = new System.Diagnostics.ProcessStartInfo("cmd", "/c " + _Command);
            // Indicamos que la salida del proceso se redireccione en un Stream
            //procStartInfo.RedirectStandardInput = true;
            procStartInfo.RedirectStandardOutput = true;
            procStartInfo.RedirectStandardError = true;
            procStartInfo.UseShellExecute = false;
            //Indica que el proceso no despliegue una pantalla negra (El proceso se ejecuta en background)
            procStartInfo.CreateNoWindow = true;
            //Inicializa el proceso
            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.StartInfo = procStartInfo;
            proc.Start();

            //proc.StandardInput.WriteLine("echo Oscar");
            //proc.StandardInput.Flush();
            //proc.StandardInput.Close();
            //proc.WaitForExit();
            
            //Consigue la salida de la Consola(Stream) y devuelve una cadena de texto
            //return proc.StandardOutput.ReadToEnd();
            string result = "";
            while (!proc.StandardOutput.EndOfStream)
            {
                result += proc.StandardOutput.ReadLine();
            }

            while (!proc.StandardError.EndOfStream)
            {
                result += proc.StandardError.ReadLine();
            }

            return result;
        }
    }
}
