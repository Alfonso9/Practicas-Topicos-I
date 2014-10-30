using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Reflection.Controlador;

namespace Reflection
{
    public class Estudiante
    {
        private String nombre;
        private String apaterno;
        private String amaterno;
        private String carrera;
        private String promedio;

        public void SaveStudent(string n, string ap, string am, string m, string pg, string e)
        {
            DriverOperations Do = new DriverOperations();
            Do.CreateEstudent(n, ap, am, m, pg, e);
        }

        public String Carrera
        {
            get { return carrera; }
            set { carrera = value; }
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
