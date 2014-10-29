using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Estudiante
{
    public class Estudiante
    {
        private String nombre;
        private String apaterno;
        private String amaterno;
        private String carrera;

        public String Carrera
        {
            get { return carrera; }
            set { carrera = value; }
        }

        public String Nombre
        {
            get 
            { 
                return nombre; 
            }
            set 
            { 
                nombre = value; 
            }
        }

        public String Apaterno
        {
            get
            {
                return apaterno;
            }
            set
            {
                apaterno = value;
            }
        }

        public String Amaterno
        {
            get
            {
                return amaterno;
            }
            set
            {
                amaterno = value;
            }
        }
    }
}
