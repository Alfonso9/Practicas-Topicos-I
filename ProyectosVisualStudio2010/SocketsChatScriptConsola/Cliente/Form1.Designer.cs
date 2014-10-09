namespace Cliente
{
    partial class FCliente
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tIPServidor = new System.Windows.Forms.TextBox();
            this.tPuerto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tUsuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnConectar = new System.Windows.Forms.Button();
            this.tChat = new System.Windows.Forms.RichTextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.tMensaje = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP Servidor";
            // 
            // tIPServidor
            // 
            this.tIPServidor.Location = new System.Drawing.Point(50, 43);
            this.tIPServidor.Name = "tIPServidor";
            this.tIPServidor.Size = new System.Drawing.Size(175, 20);
            this.tIPServidor.TabIndex = 1;
            // 
            // tPuerto
            // 
            this.tPuerto.Location = new System.Drawing.Point(270, 43);
            this.tPuerto.Name = "tPuerto";
            this.tPuerto.Size = new System.Drawing.Size(56, 20);
            this.tPuerto.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(267, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Puerto";
            // 
            // tUsuario
            // 
            this.tUsuario.Location = new System.Drawing.Point(380, 43);
            this.tUsuario.Name = "tUsuario";
            this.tUsuario.Size = new System.Drawing.Size(85, 20);
            this.tUsuario.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(377, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Usuario";
            // 
            // btnConectar
            // 
            this.btnConectar.Location = new System.Drawing.Point(506, 23);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(75, 59);
            this.btnConectar.TabIndex = 6;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // tChat
            // 
            this.tChat.Location = new System.Drawing.Point(50, 88);
            this.tChat.Name = "tChat";
            this.tChat.Size = new System.Drawing.Size(531, 157);
            this.tChat.TabIndex = 7;
            this.tChat.Text = "";
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(529, 264);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(52, 21);
            this.btnEnviar.TabIndex = 8;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // tMensaje
            // 
            this.tMensaje.Location = new System.Drawing.Point(50, 265);
            this.tMensaje.Name = "tMensaje";
            this.tMensaje.Size = new System.Drawing.Size(453, 20);
            this.tMensaje.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Mensaje";
            // 
            // FCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 293);
            this.Controls.Add(this.tMensaje);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.tChat);
            this.Controls.Add(this.btnConectar);
            this.Controls.Add(this.tUsuario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tPuerto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tIPServidor);
            this.Controls.Add(this.label1);
            this.Name = "FCliente";
            this.Text = "Cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tIPServidor;
        private System.Windows.Forms.TextBox tPuerto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tUsuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.RichTextBox tChat;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.TextBox tMensaje;
        private System.Windows.Forms.Label label4;
    }
}

