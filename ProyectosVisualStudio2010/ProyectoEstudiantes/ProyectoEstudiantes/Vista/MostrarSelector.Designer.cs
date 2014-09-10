namespace ProyectoEstudiantes.Vista
{
    partial class MostrarSelector
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cSelector = new System.Windows.Forms.ComboBox();
            this.dTodo = new System.Windows.Forms.DataGridView();
            this.iDPersonaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aPaternoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aMaternoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.exampleTablePersona = new ProyectoEstudiantes.ExampleTablePersona();
            this.label1 = new System.Windows.Forms.Label();
            this.personaTableAdapter = new ProyectoEstudiantes.ExampleTablePersonaTableAdapters.PersonaTableAdapter();
            this.Cerrar = new System.Windows.Forms.Button();
            this.Modificar = new System.Windows.Forms.Button();
            this.Eliminar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cMatricula = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dTodo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exampleTablePersona)).BeginInit();
            this.SuspendLayout();
            // 
            // cSelector
            // 
            this.cSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cSelector.FormattingEnabled = true;
            this.cSelector.Items.AddRange(new object[] {
            "Estudiante",
            "Profesor"});
            this.cSelector.Location = new System.Drawing.Point(132, 195);
            this.cSelector.Name = "cSelector";
            this.cSelector.Size = new System.Drawing.Size(121, 21);
            this.cSelector.TabIndex = 0;
            this.cSelector.SelectedIndexChanged += new System.EventHandler(this.cSelector_SelectedIndexChanged);
            // 
            // dTodo
            // 
            this.dTodo.AutoGenerateColumns = false;
            this.dTodo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dTodo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDPersonaDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.aPaternoDataGridViewTextBoxColumn,
            this.aMaternoDataGridViewTextBoxColumn,
            this.edadDataGridViewTextBoxColumn});
            this.dTodo.DataSource = this.personaBindingSource;
            this.dTodo.Location = new System.Drawing.Point(22, 22);
            this.dTodo.Name = "dTodo";
            this.dTodo.Size = new System.Drawing.Size(544, 167);
            this.dTodo.TabIndex = 1;
            // 
            // iDPersonaDataGridViewTextBoxColumn
            // 
            this.iDPersonaDataGridViewTextBoxColumn.DataPropertyName = "ID_Persona";
            this.iDPersonaDataGridViewTextBoxColumn.HeaderText = "ID_Persona";
            this.iDPersonaDataGridViewTextBoxColumn.Name = "iDPersonaDataGridViewTextBoxColumn";
            this.iDPersonaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // aPaternoDataGridViewTextBoxColumn
            // 
            this.aPaternoDataGridViewTextBoxColumn.DataPropertyName = "APaterno";
            this.aPaternoDataGridViewTextBoxColumn.HeaderText = "APaterno";
            this.aPaternoDataGridViewTextBoxColumn.Name = "aPaternoDataGridViewTextBoxColumn";
            // 
            // aMaternoDataGridViewTextBoxColumn
            // 
            this.aMaternoDataGridViewTextBoxColumn.DataPropertyName = "AMaterno";
            this.aMaternoDataGridViewTextBoxColumn.HeaderText = "AMaterno";
            this.aMaternoDataGridViewTextBoxColumn.Name = "aMaternoDataGridViewTextBoxColumn";
            // 
            // edadDataGridViewTextBoxColumn
            // 
            this.edadDataGridViewTextBoxColumn.DataPropertyName = "Edad";
            this.edadDataGridViewTextBoxColumn.HeaderText = "Edad";
            this.edadDataGridViewTextBoxColumn.Name = "edadDataGridViewTextBoxColumn";
            // 
            // personaBindingSource
            // 
            this.personaBindingSource.DataMember = "Persona";
            this.personaBindingSource.DataSource = this.exampleTablePersona;
            // 
            // exampleTablePersona
            // 
            this.exampleTablePersona.DataSetName = "ExampleTablePersona";
            this.exampleTablePersona.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Elegir:";
            // 
            // personaTableAdapter
            // 
            this.personaTableAdapter.ClearBeforeFill = true;
            // 
            // Cerrar
            // 
            this.Cerrar.Location = new System.Drawing.Point(137, 229);
            this.Cerrar.Name = "Cerrar";
            this.Cerrar.Size = new System.Drawing.Size(75, 23);
            this.Cerrar.TabIndex = 3;
            this.Cerrar.Text = "Cerrar";
            this.Cerrar.UseVisualStyleBackColor = true;
            this.Cerrar.Click += new System.EventHandler(this.Cerrar_Click);
            // 
            // Modificar
            // 
            this.Modificar.Location = new System.Drawing.Point(249, 229);
            this.Modificar.Name = "Modificar";
            this.Modificar.Size = new System.Drawing.Size(75, 23);
            this.Modificar.TabIndex = 4;
            this.Modificar.Text = "Modificar";
            this.Modificar.UseVisualStyleBackColor = true;
            this.Modificar.Click += new System.EventHandler(this.Modificar_Click);
            // 
            // Eliminar
            // 
            this.Eliminar.Location = new System.Drawing.Point(361, 229);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(75, 23);
            this.Eliminar.TabIndex = 5;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.UseVisualStyleBackColor = true;
            this.Eliminar.Click += new System.EventHandler(this.Eliminar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(336, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Matricula:";
            // 
            // cMatricula
            // 
            this.cMatricula.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cMatricula.FormattingEnabled = true;
            this.cMatricula.Location = new System.Drawing.Point(391, 195);
            this.cMatricula.Name = "cMatricula";
            this.cMatricula.Size = new System.Drawing.Size(121, 21);
            this.cMatricula.TabIndex = 6;
            // 
            // MostrarSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 258);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cMatricula);
            this.Controls.Add(this.Eliminar);
            this.Controls.Add(this.Modificar);
            this.Controls.Add(this.Cerrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dTodo);
            this.Controls.Add(this.cSelector);
            this.Name = "MostrarSelector";
            this.Text = "MostrarSelector";
            this.Load += new System.EventHandler(this.MostrarSelector_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dTodo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exampleTablePersona)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cSelector;
        private System.Windows.Forms.DataGridView dTodo;
        private System.Windows.Forms.Label label1;
        private ExampleTablePersona exampleTablePersona;
        private System.Windows.Forms.BindingSource personaBindingSource;
        private ExampleTablePersonaTableAdapters.PersonaTableAdapter personaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPersonaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aPaternoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aMaternoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn edadDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button Cerrar;
        private System.Windows.Forms.Button Modificar;
        private System.Windows.Forms.Button Eliminar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cMatricula;
    }
}