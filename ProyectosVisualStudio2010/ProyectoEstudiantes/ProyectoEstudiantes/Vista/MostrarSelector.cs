using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProyectoEstudiantes.Vista
{
    public partial class MostrarSelector : Form
    {
        private ProyEstudiantes.Controlador.DriverOperations DO = new ProyEstudiantes.Controlador.DriverOperations();
        public MostrarSelector()
        {
            InitializeComponent();
            DO.CargarDataGridView(dTodo);
        }

        private void MostrarSelector_Load(object sender, EventArgs e)
        {            
            // TODO: esta línea de código carga datos en la tabla 'exampleTablePersona.Persona' Puede moverla o quitarla según sea necesario.
            //this.personaTableAdapter.Fill(this.exampleTablePersona.Persona);

        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Modificar_Click(object sender, EventArgs e)
        {
            if (cMatricula.SelectedItem != null && cSelector.SelectedItem != null)
            {
                Form fModificar = new Modificar(cMatricula.SelectedItem.ToString(), cSelector.SelectedItem.ToString());
                Close();
                fModificar.Show();
            }
            else { MessageBox.Show("No ha seleccionado en algun ComboBox"); }
        }

        private void cSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cSelector.SelectedIndex.Equals(0))
                cMatricula.DataSource = DO.ObtenerEstudiante("Alumno", "ID_Persona");
            if (cSelector.SelectedIndex.Equals(1))
                cMatricula.DataSource = DO.ObtenerEstudiante("Profesor", "ID_Persona");
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            if (cMatricula.SelectedItem != null && cSelector.SelectedItem != null)
            {
                DO.Eliminar(cSelector.SelectedItem.ToString(), cMatricula.SelectedItem.ToString());
                Close();                
            }
            else { MessageBox.Show("No ha seleccionado en algun ComboBox"); }
        }

        private void Reload()
        {
            DO.CargarDataGridView(dTodo);
        }
    }
}
