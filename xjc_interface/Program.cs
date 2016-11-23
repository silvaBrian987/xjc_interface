using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace xjc_interface
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmInterface());
        }
    }

    public class Utils
    {
        public static string ExecuteCommand(string _Command)
        {
            return ExecuteCommand(_Command, false);
        }

        public static string ExecuteCommand(string _Command, bool showWindow)
        {
            return ExecuteCommand(_Command, showWindow, null, null);
        }

        public static string ExecuteCommand(string _Command, bool showWindow, DataReceivedEventHandler outputHandler, DataReceivedEventHandler errorHandler)
        {
            //Indicamos que deseamos inicializar el proceso cmd.exe junto a un comando de arranque. 
            //(/C, le indicamos al proceso cmd que deseamos que cuando termine la tarea asignada se cierre el proceso).
            //Para mas informacion consulte la ayuda de la consola con cmd.exe /? 
            System.Diagnostics.ProcessStartInfo procStartInfo = new System.Diagnostics.ProcessStartInfo("cmd", "/c " + _Command);
            // Indicamos que la salida del proceso se redireccione en un Stream
            procStartInfo.RedirectStandardOutput = true;
            procStartInfo.RedirectStandardError = true;
            procStartInfo.UseShellExecute = false;
            //Indica que el proceso no despliegue una pantalla negra (El proceso se ejecuta en background)
            procStartInfo.CreateNoWindow = !showWindow;
            //Inicializa el proceso
            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.StartInfo = procStartInfo;

            if(outputHandler != null) proc.OutputDataReceived += outputHandler;
            if(errorHandler != null) proc.ErrorDataReceived += errorHandler;

            proc.Start();
            proc.BeginOutputReadLine();

            string result = "";
            //while (!proc.StandardOutput.EndOfStream)
            //{
            //    result += "\n" + proc.StandardOutput.ReadLine();
            //}

            //while (!proc.StandardError.EndOfStream)
            //{
            //    result += "\n" + proc.StandardError.ReadLine();
            //}

            return result;
        }
    }
}
