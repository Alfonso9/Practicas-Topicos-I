using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Reflection.Modelo
{
    /// <summary>
    /// Modelo Estudiante
    /// </summary>
    public class Estudiante : Persona
    {
        public String Matricula { get; set; }
        public String PromedioGeneral { get; set; }

    }
}
