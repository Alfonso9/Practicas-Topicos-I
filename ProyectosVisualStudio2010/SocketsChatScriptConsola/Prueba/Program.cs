using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;


namespace Prueba
{
    class Program
    {
        static void Main(string[] args)
        {
            Process process = new Process();
            //Habilita la redirección
            process.StartInfo.UseShellExecute = false;
            //No se cree una ventana
            process.StartInfo.CreateNoWindow = true;
            //Redirije la salida estandar 
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardInput = true;
            //Oculta la ventana
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            //Configura comando a ajecutar
            process.StartInfo.FileName = "cmd";
            //Configura argumento del programa
            //process.StartInfo.Arguments = "/C" + comando;
            //Directorio que se usara como BASE para la ejecución
            //process.StartInfo.WorkingDirectory = @"C:\";                
            //Ejecuta el comando                    
            process.Start();
            //Envia flujo a la consola
            process.StandardInput.WriteLine(@"d:");
            //Guarda la salida del comando
            String strOutput = String.Empty;
            //Guarda el resultado del proceso en la variable
            strOutput = process.StandardOutput.ReadToEnd();
            // imprimimos el resultado
            System.Console.WriteLine(strOutput);
            //

        }
    }
}
