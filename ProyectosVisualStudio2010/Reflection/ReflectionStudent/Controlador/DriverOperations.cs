using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace ReflectionStudent.Controlador
{
    class DriverOperations
    {
        //Tratamiento de informacion de estudiante
        private ReflectionStudent.Modelo.Estudiante et = new Modelo.Estudiante();
        private ReflectionStudent.Modelo.EstudianteRepositorio IRE = new Modelo.EstudianteRepositorio();
        //Tratamiento de informacion de profesor
        private ReflectionStudent.Modelo.Profesor pf = new Modelo.Profesor();
        private ReflectionStudent.Modelo.ProfesorRepositorio IRP = new Modelo.ProfesorRepositorio();
        //Objeto conector SQL
        private ConectionSQLServer conSQL = new ConectionSQLServer();
        //Expresiones
        private ValidationRegex vR = new ValidationRegex();

        public DriverOperations() { }

        public void CreateEstudent(string e, string pg, string m, string n, string ap, string am)
        {
          //  MessageBox.Show(vR.validaMatricula(m).ToString());
            if (n != "" && ap != "" && am != "" && m != "" && pg != "" && e != "")
            {
                if (vR.validaNombre(n) && vR.validaNombre(ap) && vR.validaNombre(am))
                {
                    et.Nombre = n;
                    et.APaterno = ap;
                    et.AMaterno = am;
                    if (vR.validaMatricula(m))
                    {
                        et.Matricula = m;
                        if (vR.validaPromGeneral(pg))
                        {
                            et.PromedioGeneral = pg;
                            if (vR.validaEdad(e))
                                et.Edad = e;
                            else { MessageBox.Show("Edad invalido."); return; }
                        }
                        else { MessageBox.Show("Promedio invalido."); return; }
                    }
                    else { MessageBox.Show("Matricula invalida."); return; }
                }
                else { MessageBox.Show("Nombre contiene caracteres no validos."); return; }

                conSQL.CreateStringQuerySavePersona(et.Nombre,
                                               et.APaterno,
                                               et.AMaterno,
                                               et.Edad);
                conSQL.CreateStringQuerySaveEstudiante(et.Matricula,
                                                   et.PromedioGeneral);
            }
            else { MessageBox.Show("Todos los campos son obligatorios."); return; }            
        }

        public void UpdateEstudiante(string ID_Persona, string n, string ap, string am, string m, string pg, string e) 
        {
            if (n != "" && ap != "" && am != "" && m != "" && pg != "" && e != "")
            {
                if (vR.validaNombre(n) && vR.validaNombre(ap) && vR.validaNombre(am))
                {
                    et.Nombre = n;
                    et.APaterno = ap;
                    et.AMaterno = am;
                    if (vR.validaMatricula(m))
                    {
                        et.Matricula = m;
                        if (vR.validaPromGeneral(pg))
                        {
                            et.PromedioGeneral = pg;
                            if (vR.validaEdad(e))
                                et.Edad = e;
                            else { MessageBox.Show("Edad invalido."); }
                        }
                        else { MessageBox.Show("Promedio invalido."); }
                    }
                    else { MessageBox.Show("Matricula invalida."); }
                }
                else { MessageBox.Show("Nombre contiene caracteres no validos."); }

                conSQL.CreateQueryUpdateEstudiante(ID_Persona, n, ap, am, m, pg, e);
            }
            else { MessageBox.Show("Todos los campos son obligatorios."); }                        

        }

        public void CreateProfesor(string n, string ap, string am, string m, string np, string a, string e)
        {
            if (n != "" && ap != "" && am != "" && m != "" && np != "" && a != "" && e != "")
            {
                if (vR.validaNombre(n) && vR.validaNombre(ap) && vR.validaNombre(am))
                {
                    pf.Nombre = n;
                    pf.APaterno = ap;
                    pf.AMaterno = am;
                    if (vR.validaMatricula(m))
                    {
                        pf.Matricula = m;
                        if (vR.validaNumero(np))
                        {
                            pf.NumeroPersonal = np;
                            if (vR.validaAntiguedad(a))
                            {
                                pf.Antiguedad = a;
                                if (vR.validaEdad(e))
                                    pf.Edad = e;
                                else { MessageBox.Show("Edad invalido."); }
                            }
                            else { MessageBox.Show("Antiguedad invalido."); }
                        }
                        else { MessageBox.Show("Numero personal invalido."); }
                    }
                    else { MessageBox.Show("Matricula invalida."); }
                }
                else { MessageBox.Show("Nombre contiene caracteres no validos."); }
                
                conSQL.CreateStringQuerySavePersona(pf.Nombre,
                                                pf.APaterno,
                                                pf.AMaterno,
                                                pf.Edad);
                conSQL.CreateStringQuerySaveProfesor(pf.Matricula,
                                                 pf.NumeroPersonal,
                                                 pf.Antiguedad);            
            }
            else { MessageBox.Show("Todos los campos son obligatorios."); }            
        }

        public void UpdateProfesor(string ID_Persona, string n, string ap, string am, string m, string np, string a, string e)
        {
            if (n != "" && ap != "" && am != "" && m != "" && np != "" && a != "" && e != "")
            {
                if (vR.validaNombre(n) && vR.validaNombre(ap) && vR.validaNombre(am))
                {
                    pf.Nombre = n;
                    pf.APaterno = ap;
                    pf.AMaterno = am;
                    if (vR.validaMatricula(m))
                    {
                        pf.Matricula = m;
                        if (vR.validaNumero(np))
                        {
                            pf.NumeroPersonal = np;
                            if (vR.validaAntiguedad(a))
                            {
                                pf.Antiguedad = a;
                                if (vR.validaEdad(e))
                                    pf.Edad = e;
                                else { MessageBox.Show("Edad invalido."); }
                            }
                            else { MessageBox.Show("Antiguedad invalido."); }
                        }
                        else { MessageBox.Show("Numero personal invalido."); }
                    }
                    else { MessageBox.Show("Matricula invalida."); }
                }
                else { MessageBox.Show("Nombre contiene caracteres no validos."); }
                            
            }
            else { MessageBox.Show("Todos los campos son obligatorios."); }            
        }
        /*public void MostrarDatosEnTabla(DataGridView dTablaDatos)
        {
            List<Modelo.Estudiante> lEst = new List<Modelo.Estudiante>();
            lEst = IRE.GetAll();

            foreach (Modelo.Estudiante Estudiante in lEst)
            {
                DataGridViewRow row = (DataGridViewRow)dTablaDatos.Rows[0].Clone();
                row.Cells[0].Value = Estudiante.Nombre;
                row.Cells[1].Value = Estudiante.APaterno;
                row.Cells[2].Value = Estudiante.AMaterno;
                row.Cells[3].Value = Estudiante.PromedioGeneral;
                row.Cells[4].Value = Estudiante.Matricula;

                dTablaDatos.Rows.Add(row);
            }
        }*/

        public void Eliminar(string sTable, string sID_Persona)
        {
            conSQL.CreateQueryDelete(sTable, sID_Persona);
        }

        public List<string> ObtenerEstudiante( string sTabla, string sID_Persona) 
        {
            return conSQL.CreateQuerySelectList(sTabla, sID_Persona);
        }

        public ReflectionStudent.Modelo.Estudiante ObtenerObjetoEstudiante(string sFiltro)
        {
           return conSQL.CreateQuerySelectEstudiante(sFiltro);
        }

        public ReflectionStudent.Modelo.Profesor ObtenerObjetoProfesor(string sFiltro)
        {
            return conSQL.CreateQuerySelectProfesor(sFiltro);
        }

        public void CargarDataGridView(DataGridView Dv) 
        {
            conSQL.CreateQuerySelect("Persona", "*", Dv);
        }
    }
}
