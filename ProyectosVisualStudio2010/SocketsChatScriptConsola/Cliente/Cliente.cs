using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Threading;

namespace Cliente
{
    public partial class FCliente : Form
    {
        string mensajeChat;
        
        NetworkStream streamServidor;
        
        TcpClient cliente;

        public FCliente()
        {
            InitializeComponent();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            try
            {
                //Colocar nombre del cliente a ventana
                this.Text = string.Format("Cliente: {0}", tUsuario.Text);

                mensajeChat = "Conectando al servidor...";
                Mensaje();

                cliente = new TcpClient(tIPServidor.Text, int.Parse(tPuerto.Text));

                //Se crea un canal de comunicacion
                streamServidor = cliente.GetStream();

                Byte[] datos = System.Text.Encoding.ASCII.GetBytes(tUsuario.Text + "$");
                Console.WriteLine(datos.ToString());
                streamServidor.Write(datos, 0, datos.Length);
                streamServidor.Flush();

                Thread ctThread = new Thread(Chat);
                ctThread.Start();

                btnConectar.Enabled = false;

                btnEnviar.Enabled = true;
            }
            catch (Exception ex)
            {
                tChat.Text = ex.ToString();

                if (MessageBox.Show("¿Conectar de nuevo?") == System.Windows.Forms.DialogResult.Yes)
                    btnConectar_Click(null, null);
                else
                    this.Close();
            }
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            try
            {

                streamServidor = cliente.GetStream();

                Byte[] datos = Encoding.ASCII.GetBytes(tMensaje.Text + "$" + tUsuario.Text);

                streamServidor.Write(datos, 0, datos.Length);
                streamServidor.Flush();
            }
            catch (Exception ex)
            {
                tChat.Text = ex.ToString();
            }
        }

        private void Mensaje()
        {
            if (this.InvokeRequired)
                this.Invoke(new MethodInvoker(Mensaje));
            else
                tChat.Text = tChat.Text + Environment.NewLine + " -> " + mensajeChat;
        }

        private void Chat()
        {
            while (true)
            {
                streamServidor = cliente.GetStream();

                byte[] bytes = new byte[256];

                streamServidor.Read(bytes, 0, bytes.Length);

                mensajeChat = Encoding.ASCII.GetString(bytes);                
                Mensaje();
            }
        }
    }
}
