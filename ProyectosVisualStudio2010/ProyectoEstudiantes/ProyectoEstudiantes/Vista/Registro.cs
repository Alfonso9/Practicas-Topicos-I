using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ProyectoEstudiantes.Vista;

namespace ProyectoEstudiantes
{
    public partial class FRegistro : Form
    {
        private ProyEstudiantes.Controlador.DriverOperations DO = new ProyEstudiantes.Controlador.DriverOperations();
        public FRegistro()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bMostrar_Click(object sender, EventArgs e)
        {
            Form fSelector = new MostrarSelector();
            fSelector.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tGeneral.SelectedIndex.Equals(0))
            {
                DO.CreateEstudent(tNombreEstudiante.Text,
                                  tAPaternoEstudiante.Text,
                                  tAMaternoEstudiante.Text,
                                  tMatriculaEstudiante.Text,
                                  tPromGeneralEstudiante.Text,
                                  tEdadEstudiante.Text);
                tNombreEstudiante.Text =
                tAPaternoEstudiante.Text =
                tAMaternoEstudiante.Text =
                tMatriculaEstudiante.Text =
                tPromGeneralEstudiante.Text =
                tEdadEstudiante.Text = "";
            }
            else
                if (tGeneral.SelectedIndex.Equals(1))
                {
                    DO.CreateProfesor(tNombreProfesor.Text,
                                        tAPaternoProfesor.Text,
                                        tAMaternoProfesor.Text,
                                        tMatriculaProfesor.Text,
                                        tNumPersonalProfesor.Text,
                                        tAntiguedadProfesor.Text,
                                        tEdadProfesor.Text);
                    tNombreProfesor.Text =
                    tAPaternoProfesor.Text =
                    tAMaternoProfesor.Text =
                    tMatriculaProfesor.Text =
                    tNumPersonalProfesor.Text =
                    tAntiguedadProfesor.Text = 
                    tEdadProfesor.Text = "";
                }
            //DO.GuardarDriverOperations();            
        }
    }
}
