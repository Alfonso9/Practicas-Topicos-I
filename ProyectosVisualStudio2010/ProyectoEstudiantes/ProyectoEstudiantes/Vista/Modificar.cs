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
    public partial class Modificar : Form
    {
        private ProyEstudiantes.Controlador.DriverOperations DO = new ProyEstudiantes.Controlador.DriverOperations();
        ProyEstudiantes.Modelo.Estudiante et = new ProyEstudiantes.Modelo.Estudiante();
        ProyEstudiantes.Modelo.Profesor pf = new ProyEstudiantes.Modelo.Profesor();
        string sID, sT;        

        public Modificar(string sID_Persona, string sTable)
        {
            sID = sID_Persona;
            sT = sTable;
            InitializeComponent();
            if (sT.Equals("Estudiante"))
            {
                et = DO.ObtenerObjetoEstudiante(sID_Persona);
                tNombreEstudiante.Text = et.Nombre;
                tAPaternoEstudiante.Text = et.APaterno;
                tAMaternoEstudiante.Text = et.AMaterno;
                tMatriculaEstudiante.Text = et.Matricula;
                tPromGeneralEstudiante.Text = et.PromedioGeneral;
                tEdadEstudiante.Text = et.Edad;
            }
            else
                if (sT.Equals("Profesor"))
                {
                    pf = DO.ObtenerObjetoProfesor(sID_Persona);
                    tNombreProfesor.Text = pf.Nombre;
                    tAPaternoProfesor.Text = pf.APaterno;
                    tAMaternoProfesor.Text = pf.AMaterno;
                    tMatriculaProfesor.Text = pf.Matricula;
                    tNumPersonalProfesor.Text = pf.NumeroPersonal;
                    tAntiguedadProfesor.Text = pf.Antiguedad;
                    tEdadProfesor.Text = pf.Edad;
                }

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (sT.Equals("Estudiante"))
            {
                DO.UpdateEstudiante(sID,
                                    tNombreEstudiante.Text,
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
                if (sT.Equals("Profesor"))
                {
                    DO.UpdateProfesor(sID,
                                      tNombreProfesor.Text,
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
                    tAntiguedadProfesor.Text = "";
                }            
            Close();            
        }        
    }
}
