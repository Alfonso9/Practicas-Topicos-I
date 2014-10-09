using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Collections;
using System.Threading;
using System.Net;

namespace SocketsChatScriptConsola
{
    public partial class InterfazChat : Form
    {
        bool bandera = false;
        
        private TcpListener servidor;
 
        private static Hashtable clientesConectados;
 
        private String mensajeChat;
 
        private String mensajeCliente;
 
        
        public InterfazChat()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click_1(object sender, EventArgs e)
        {
            try
            {
                btnIniciar.Enabled = false;
                btnDetener.Enabled = true;
                //Crear e iniciar un hilo con la funcion Tarea
                Thread tarea = new Thread(Tarea);
                tarea.Start();

            }
            catch (Exception ex)
            {
                mensajeChat = ex.ToString();
                Mensaje();
            }

        }

        private void Tarea()
        {
            //Se crea una nueva tabla
            clientesConectados = new Hashtable();
            //Se crea e inicia un objeto TcpListener el cual escuchara en el puerto e IP especificadas
            servidor = new TcpListener(IPAddress.Parse(tIP.Text), int.Parse(tPuerto.Text));
            //tIP.Text = (Dns.Resolve(Dns.GetHostName())).AddressList[0].ToString();
            //tPuerto.Text = "11000";
            //servidor = new TcpListener(new IPEndPoint((Dns.Resolve(Dns.GetHostName())).AddressList[0], int.Parse(tPuerto.Text)));
            servidor.Start();

            mensajeChat = "Servidor Iniciado...";
            MensajeB();

            try
            {         
                
                while (true)
                {
                    //Acepta las conexiones de clientes..
                    TcpClient cliente = servidor.AcceptTcpClient();
                    //Se crea un buffer para almacenar mensajes del cliente.
                    Byte[] bytesCliente = new byte[256];
                    //Obtienen el flujo del cliente..
                    NetworkStream streamCliente = cliente.GetStream();
                    //Lee el flujo del cliente y lo almacena en buffer.
                    streamCliente.Read(bytesCliente, 0, bytesCliente.Length);
                    
                    //Convierte el buffer a un String
                    mensajeCliente = Encoding.ASCII.GetString(bytesCliente, 0, bytesCliente.Length);
                    //Obtiene la cadena de mensaje del cliente
                    mensajeCliente = mensajeCliente.Substring(0, mensajeCliente.IndexOf("$"));                    
                    //Si aun no estaba agregado a la tabla el cliente, se agrega.
                    if (!clientesConectados.ContainsKey(mensajeCliente))
                    {
                        //Se agrega el cliente y su mensaje a la tabla.
                        clientesConectados.Add(mensajeCliente, cliente);
                        mensajeChat = string.Format("{0} se ha unido al servidor", mensajeCliente);
                        Mensaje();
                    }
                    DifundirATodos(mensajeCliente, mensajeCliente, false);
                    Chat chat = new Chat(cliente, mensajeCliente);
                }
            }
            catch (Exception e)
            {
                e.ToString();
            }
            finally
            {
                //Console.WriteLine("Error...");
                //servidor.Stop();
            }
        }

        private void btnDetener_Click_1(object sender, EventArgs e)
        {
            if (servidor != null && servidor.Server.Connected)
            {
                btnIniciar.Enabled = true;
                btnDetener.Enabled = false;
                bandera = true;
                servidor.Stop();
                Application.Exit();                
            }
            //servidor.Stop();
            Application.Exit();                
        }

        public static void DifundirATodos(string mensaje, string nombre, bool band)
        {
            try
            {
                foreach (DictionaryEntry Item in clientesConectados)
                {
                    //
                    byte[] bytes = null;
                    //Se obtiene un cliente de la tabla y se castea a TcpClient.
                    TcpClient cliente = (TcpClient)Item.Value;
                    //Se obtiene su mensaje
                    NetworkStream streamCliente = cliente.GetStream();
                    
                    //Para saber si es nuevo cliente o ya estaba en la tabla.
                    if (band == true)
                    {
                        mensaje = new System.Web.Script.Serialization.JavaScriptSerializer().Deserialize <String>(mensaje);
                        bytes = Encoding.ASCII.GetBytes(nombre + " dice: " + mensaje);
                    }
                    else
                        bytes = Encoding.ASCII.GetBytes(nombre + " se ha conectado");

                    //Se escribe el flujo de datos a cliente
                    streamCliente.Write(bytes, 0, bytes.Length);
                    streamCliente.Flush();

                }
            }
            catch { }

        }

        public void Mensaje()
        {
            if (this.InvokeRequired)
                this.Invoke(new MethodInvoker(Mensaje));
            else
                tChat.Text = tChat.Text + Environment.NewLine + "->" + mensajeCliente;
        }

        public void MensajeB()
        {
            if (this.InvokeRequired)
                this.Invoke(new MethodInvoker(Mensaje));
            else
                tChat.Text = tChat.Text + Environment.NewLine + "->" + mensajeChat;
        } 
    }
}