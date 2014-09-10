namespace ProyectoEstudiantes
{
    partial class FRegistro
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
            this.tGeneral = new System.Windows.Forms.TabControl();
            this.tEstudiante = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.tEdadEstudiante = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tNombreEstudiante = new System.Windows.Forms.TextBox();
            this.tAPaternoEstudiante = new System.Windows.Forms.TextBox();
            this.tAMaternoEstudiante = new System.Windows.Forms.TextBox();
            this.tMatriculaEstudiante = new System.Windows.Forms.TextBox();
            this.tPromGeneralEstudiante = new System.Windows.Forms.TextBox();
            this.tProfesor = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.tAntiguedadProfesor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tNombreProfesor = new System.Windows.Forms.TextBox();
            this.tAPaternoProfesor = new System.Windows.Forms.TextBox();
            this.tAMaternoProfesor = new System.Windows.Forms.TextBox();
            this.tMatriculaProfesor = new System.Windows.Forms.TextBox();
            this.tNumPersonalProfesor = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.bMostrar = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.tEdadProfesor = new System.Windows.Forms.TextBox();
            this.tGeneral.SuspendLayout();
            this.tEstudiante.SuspendLayout();
            this.tProfesor.SuspendLayout();
            this.SuspendLayout();
            // 
            // tGeneral
            // 
            this.tGeneral.Controls.Add(this.tEstudiante);
            this.tGeneral.Controls.Add(this.tProfesor);
            this.tGeneral.Location = new System.Drawing.Point(25, 17);
            this.tGeneral.Name = "tGeneral";
            this.tGeneral.SelectedIndex = 0;
            this.tGeneral.Size = new System.Drawing.Size(309, 216);
            this.tGeneral.TabIndex = 0;
            // 
            // tEstudiante
            // 
            this.tEstudiante.Controls.Add(this.label11);
            this.tEstudiante.Controls.Add(this.tEdadEstudiante);
            this.tEstudiante.Controls.Add(this.label6);
            this.tEstudiante.Controls.Add(this.label7);
            this.tEstudiante.Controls.Add(this.label8);
            this.tEstudiante.Controls.Add(this.label9);
            this.tEstudiante.Controls.Add(this.label10);
            this.tEstudiante.Controls.Add(this.tNombreEstudiante);
            this.tEstudiante.Controls.Add(this.tAPaternoEstudiante);
            this.tEstudiante.Controls.Add(this.tAMaternoEstudiante);
            this.tEstudiante.Controls.Add(this.tMatriculaEstudiante);
            this.tEstudiante.Controls.Add(this.tPromGeneralEstudiante);
            this.tEstudiante.Location = new System.Drawing.Point(4, 22);
            this.tEstudiante.Name = "tEstudiante";
            this.tEstudiante.Padding = new System.Windows.Forms.Padding(3);
            this.tEstudiante.Size = new System.Drawing.Size(301, 190);
            this.tEstudiante.TabIndex = 0;
            this.tEstudiante.Text = "Estudiante";
            this.tEstudiante.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(53, 146);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "Edad:";
            // 
            // tEdadEstudiante
            // 
            this.tEdadEstudiante.Location = new System.Drawing.Point(147, 143);
            this.tEdadEstudiante.Name = "tEdadEstudiante";
            this.tEdadEstudiante.Size = new System.Drawing.Size(100, 20);
            this.tEdadEstudiante.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Nombre:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(53, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Apellido Paterno:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(53, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Apellido Materno:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(53, 96);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Matricula:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(53, 119);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Promedio General:";
            // 
            // tNombreEstudiante
            // 
            this.tNombreEstudiante.Location = new System.Drawing.Point(147, 15);
            this.tNombreEstudiante.Name = "tNombreEstudiante";
            this.tNombreEstudiante.Size = new System.Drawing.Size(100, 20);
            this.tNombreEstudiante.TabIndex = 21;
            // 
            // tAPaternoEstudiante
            // 
            this.tAPaternoEstudiante.Location = new System.Drawing.Point(147, 41);
            this.tAPaternoEstudiante.Name = "tAPaternoEstudiante";
            this.tAPaternoEstudiante.Size = new System.Drawing.Size(100, 20);
            this.tAPaternoEstudiante.TabIndex = 22;
            // 
            // tAMaternoEstudiante
            // 
            this.tAMaternoEstudiante.Location = new System.Drawing.Point(147, 67);
            this.tAMaternoEstudiante.Name = "tAMaternoEstudiante";
            this.tAMaternoEstudiante.Size = new System.Drawing.Size(100, 20);
            this.tAMaternoEstudiante.TabIndex = 23;
            // 
            // tMatriculaEstudiante
            // 
            this.tMatriculaEstudiante.Location = new System.Drawing.Point(147, 90);
            this.tMatriculaEstudiante.Name = "tMatriculaEstudiante";
            this.tMatriculaEstudiante.Size = new System.Drawing.Size(100, 20);
            this.tMatriculaEstudiante.TabIndex = 24;
            // 
            // tPromGeneralEstudiante
            // 
            this.tPromGeneralEstudiante.Location = new System.Drawing.Point(147, 116);
            this.tPromGeneralEstudiante.Name = "tPromGeneralEstudiante";
            this.tPromGeneralEstudiante.Size = new System.Drawing.Size(100, 20);
            this.tPromGeneralEstudiante.TabIndex = 25;
            // 
            // tProfesor
            // 
            this.tProfesor.Controls.Add(this.label13);
            this.tProfesor.Controls.Add(this.tEdadProfesor);
            this.tProfesor.Controls.Add(this.label12);
            this.tProfesor.Controls.Add(this.tAntiguedadProfesor);
            this.tProfesor.Controls.Add(this.label1);
            this.tProfesor.Controls.Add(this.label2);
            this.tProfesor.Controls.Add(this.label3);
            this.tProfesor.Controls.Add(this.label4);
            this.tProfesor.Controls.Add(this.label5);
            this.tProfesor.Controls.Add(this.tNombreProfesor);
            this.tProfesor.Controls.Add(this.tAPaternoProfesor);
            this.tProfesor.Controls.Add(this.tAMaternoProfesor);
            this.tProfesor.Controls.Add(this.tMatriculaProfesor);
            this.tProfesor.Controls.Add(this.tNumPersonalProfesor);
            this.tProfesor.Location = new System.Drawing.Point(4, 22);
            this.tProfesor.Name = "tProfesor";
            this.tProfesor.Padding = new System.Windows.Forms.Padding(3);
            this.tProfesor.Size = new System.Drawing.Size(301, 190);
            this.tProfesor.TabIndex = 1;
            this.tProfesor.Text = "Profesor";
            this.tProfesor.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(58, 138);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 13);
            this.label12.TabIndex = 16;
            this.label12.Text = "Antiguedad:";
            // 
            // tAntiguedadProfesor
            // 
            this.tAntiguedadProfesor.Location = new System.Drawing.Point(152, 135);
            this.tAntiguedadProfesor.Name = "tAntiguedadProfesor";
            this.tAntiguedadProfesor.Size = new System.Drawing.Size(100, 20);
            this.tAntiguedadProfesor.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Apellido Paterno:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Apellido Materno:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Matricula:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Numero Personal:";
            // 
            // tNombreProfesor
            // 
            this.tNombreProfesor.Location = new System.Drawing.Point(152, 7);
            this.tNombreProfesor.Name = "tNombreProfesor";
            this.tNombreProfesor.Size = new System.Drawing.Size(100, 20);
            this.tNombreProfesor.TabIndex = 11;
            // 
            // tAPaternoProfesor
            // 
            this.tAPaternoProfesor.Location = new System.Drawing.Point(152, 33);
            this.tAPaternoProfesor.Name = "tAPaternoProfesor";
            this.tAPaternoProfesor.Size = new System.Drawing.Size(100, 20);
            this.tAPaternoProfesor.TabIndex = 12;
            // 
            // tAMaternoProfesor
            // 
            this.tAMaternoProfesor.Location = new System.Drawing.Point(152, 59);
            this.tAMaternoProfesor.Name = "tAMaternoProfesor";
            this.tAMaternoProfesor.Size = new System.Drawing.Size(100, 20);
            this.tAMaternoProfesor.TabIndex = 13;
            // 
            // tMatriculaProfesor
            // 
            this.tMatriculaProfesor.Location = new System.Drawing.Point(152, 82);
            this.tMatriculaProfesor.Name = "tMatriculaProfesor";
            this.tMatriculaProfesor.Size = new System.Drawing.Size(100, 20);
            this.tMatriculaProfesor.TabIndex = 14;
            // 
            // tNumPersonalProfesor
            // 
            this.tNumPersonalProfesor.Location = new System.Drawing.Point(152, 108);
            this.tNumPersonalProfesor.Name = "tNumPersonalProfesor";
            this.tNumPersonalProfesor.Size = new System.Drawing.Size(100, 20);
            this.tNumPersonalProfesor.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(59, 239);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Cerrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(142, 239);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Guardar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // bMostrar
            // 
            this.bMostrar.Location = new System.Drawing.Point(225, 239);
            this.bMostrar.Name = "bMostrar";
            this.bMostrar.Size = new System.Drawing.Size(75, 23);
            this.bMostrar.TabIndex = 3;
            this.bMostrar.Text = "Mostrar";
            this.bMostrar.UseVisualStyleBackColor = true;
            this.bMostrar.Click += new System.EventHandler(this.bMostrar_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(57, 167);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 13);
            this.label13.TabIndex = 28;
            this.label13.Text = "Edad:";
            // 
            // tEdadProfesor
            // 
            this.tEdadProfesor.Location = new System.Drawing.Point(151, 164);
            this.tEdadProfesor.Name = "tEdadProfesor";
            this.tEdadProfesor.Size = new System.Drawing.Size(100, 20);
            this.tEdadProfesor.TabIndex = 29;
            // 
            // FRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 280);
            this.Controls.Add(this.bMostrar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tGeneral);
            this.Name = "FRegistro";
            this.Text = "Registro";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tGeneral.ResumeLayout(false);
            this.tEstudiante.ResumeLayout(false);
            this.tEstudiante.PerformLayout();
            this.tProfesor.ResumeLayout(false);
            this.tProfesor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tGeneral;
        private System.Windows.Forms.TabPage tEstudiante;
        private System.Windows.Forms.TabPage tProfesor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tNombreProfesor;
        private System.Windows.Forms.TextBox tAPaternoProfesor;
        private System.Windows.Forms.TextBox tAMaternoProfesor;
        private System.Windows.Forms.TextBox tMatriculaProfesor;
        private System.Windows.Forms.TextBox tNumPersonalProfesor;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button bMostrar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tNombreEstudiante;
        private System.Windows.Forms.TextBox tAPaternoEstudiante;
        private System.Windows.Forms.TextBox tAMaternoEstudiante;
        private System.Windows.Forms.TextBox tMatriculaEstudiante;
        private System.Windows.Forms.TextBox tPromGeneralEstudiante;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tEdadEstudiante;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tAntiguedadProfesor;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tEdadProfesor;
    }
}

