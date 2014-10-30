using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReflectionStudent
{
    public class Persona
    {
        public int Id { get; set; }
        public String Nombre { get; set; }
        public String APaterno { get; set; }
        public String AMaterno { get; set; }

        private string edad;
        public string Edad
        {
            get
            {
                return edad;
            }

            set
            {
                edad = value;
            }
        }
    }
}
