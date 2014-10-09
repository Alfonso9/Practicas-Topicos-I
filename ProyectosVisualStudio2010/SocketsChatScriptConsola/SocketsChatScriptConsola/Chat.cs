using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.Threading;

namespace SocketsChatScriptConsola
{
    class Chat
    {
        //Almacena nombre del cliente y su dirección IP
        TcpClient clienteChat; 
        string nombreUsuario;
        Comandos cComando = new Comandos();

        //Constructor inicializa el hilo con la funcion doChat
        public Chat(TcpClient cliente, string nombreUsuario)
        {
            this.clienteChat = cliente;
            this.nombreUsuario = nombreUsuario;
            Thread ctThread = new Thread(doChat);
            ctThread.Start();
        }

        //
        private void doChat()
        {
            //Se crea un buffer...
            byte[] bytesFrom = new byte[256];
            string mensajeCliente = null;

            //Se crea para que el hilo no acabe su ejecución...
            while (true)
            {
                try
                {
                    //Obtiene el flujo del cliente conectado
                    NetworkStream networkStream = clienteChat.GetStream();
                    //Lee el flujo y lo almacena en el buffer
                    networkStream.Read(bytesFrom, 0, bytesFrom.Length);
                    //Transforma el flujo de bis del buffer a un String
                    mensajeCliente = System.Text.Encoding.ASCII.GetString(bytesFrom);
                    //Obtiene de la cadena "mensajeCliente" la cadena a enviar...
                    mensajeCliente = mensajeCliente.Substring(0, mensajeCliente.IndexOf("$"));

                    //cComando.ejecutarComando(mensajeCliente);

                    //Envia el mensaje a los demas usuarios...
                    //InterfazChat.DifundirATodos(mensajeCliente, nombreUsuario, true);
                    InterfazChat.DifundirATodos(cComando.ejecutarComando(mensajeCliente), nombreUsuario, true);
                }
                catch (Exception)
                {
                    //Manejo de Excepcion
                }
            }
        }

    }
}
