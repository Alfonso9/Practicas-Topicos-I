using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ReflectionStudent.Controlador;

namespace Estudiante
{
    public class Estudiante
    {
        private String nombre;
        private String apaterno;
        private String amaterno;
        private String matricula;
        private String promedio;
        private String edad;


        public void SaveStudent(string n, string ap, string am, string m, string pg, string e)
        {
            DriverOperations Do = new DriverOperations();
            Do.CreateEstudent(n, ap, am, m, pg, e);
        }

        public String Edad
        {
            get { return edad; }
            set { edad = value; }
        }

        public String Promedio
        {
            get { return promedio; }
            set { promedio = value; }
        }

        public Estudiante() { }

        public String Matricula
        {
            get { return matricula; }
            set { matricula = value; }
        }

        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public String Apaterno
        {
            get { return apaterno; }
            set { apaterno = value; }
        }

        public String Amaterno
        {
            get { return amaterno; }
            set { amaterno = value; }
        }
    }
}
