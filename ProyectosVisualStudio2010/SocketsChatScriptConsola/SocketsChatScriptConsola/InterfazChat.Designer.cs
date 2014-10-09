namespace SocketsChatScriptConsola
{
    partial class InterfazChat
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
            this.btnIniciar = new System.Windows.Forms.Button();
            this.tIP = new System.Windows.Forms.TextBox();
            this.tPuerto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDetener = new System.Windows.Forms.Button();
            this.tChat = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP";
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(143, 95);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(75, 23);
            this.btnIniciar.TabIndex = 1;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click_1);
            // 
            // tIP
            // 
            this.tIP.Location = new System.Drawing.Point(47, 50);
            this.tIP.Name = "tIP";
            this.tIP.Size = new System.Drawing.Size(171, 20);
            this.tIP.TabIndex = 2;
            // 
            // tPuerto
            // 
            this.tPuerto.Location = new System.Drawing.Point(47, 97);
            this.tPuerto.Name = "tPuerto";
            this.tPuerto.Size = new System.Drawing.Size(45, 20);
            this.tPuerto.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Puerto";
            // 
            // btnDetener
            // 
            this.btnDetener.Location = new System.Drawing.Point(245, 95);
            this.btnDetener.Name = "btnDetener";
            this.btnDetener.Size = new System.Drawing.Size(75, 23);
            this.btnDetener.TabIndex = 5;
            this.btnDetener.Text = "Detener";
            this.btnDetener.UseVisualStyleBackColor = true;
            this.btnDetener.Click += new System.EventHandler(this.btnDetener_Click_1);
            // 
            // tChat
            // 
            this.tChat.Location = new System.Drawing.Point(47, 124);
            this.tChat.Name = "tChat";
            this.tChat.Size = new System.Drawing.Size(273, 134);
            this.tChat.TabIndex = 6;
            this.tChat.Text = "";
            // 
            // InterfazChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 270);
            this.Controls.Add(this.tChat);
            this.Controls.Add(this.btnDetener);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tPuerto);
            this.Controls.Add(this.tIP);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.label1);
            this.Name = "InterfazChat";
            this.Text = "Servidor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.TextBox tIP;
        private System.Windows.Forms.TextBox tPuerto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDetener;
        private System.Windows.Forms.RichTextBox tChat;
    }
}

