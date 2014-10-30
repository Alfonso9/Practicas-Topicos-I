using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Reflection.Controlador
{
    class ValidationRegex
    {
        //Patron expresion regular
        private string patternNombre = "^[a-zA-ZñÑ\\s]{0,10}$";
        private string patternMatricula = "^(S|s)[0-9]{8}$";        
        private string patternPg = "^[0-9]{1}\\.[0-9]{0,2}$";
        private string patternEdad = "^[0-9]{0,2}$";
        private string patternNumeroPersonal = "^[0-9]{10}$";


        public ValidationRegex() { }

        public bool validaMatricula(string sMatricula)
        {
            return Regex.IsMatch(sMatricula, patternMatricula);
        }

        public bool validaNombre(string sNombre)
        {            
            return Regex.IsMatch(sNombre, patternNombre);           
        }

        public bool validaPromGeneral(string sPg)
        {
            return Regex.IsMatch(sPg, patternPg);
        }

        public bool validaEdad(string sE)
        {
            return Regex.IsMatch(sE, patternEdad);
        }

        public bool validaNumero(string sNp)
        {
            return Regex.IsMatch(sNp, patternNumeroPersonal);
        }

        public bool validaAntiguedad(string sA)
        {
            return Regex.IsMatch(sA, patternEdad);
        }
  
    }
}
