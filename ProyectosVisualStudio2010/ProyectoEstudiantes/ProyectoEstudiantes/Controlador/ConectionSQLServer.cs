using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace ProyEstudiantes.Controlador
{
    class ConectionSQLServer
    {
        private string sqlString;
        private SqlConnection Conn = new SqlConnection("server=.\\SQLExpress;" +
                                               "database = Example;" +
                                                   "integrated security = SSPI;");
        private SqlDataReader QueryReader = null;
        private SqlCommand CommandEstudiante = null;
        private SqlCommand CommandPersona = null;
        private SqlCommand CommandProfesor = null;
        private SqlCommand CommandQueryReader = null;


        public ConectionSQLServer(){
            try 
            { 
                Conn.Open();                
            }
            catch(Exception e){Console.WriteLine(e.ToString());}
        }

        public void CreateStringQuerySavePersona(string N, string AP, string AM, string E)
        {
            sqlString = String.Format("INSERT INTO [Example].[dbo].[Persona] ([Nombre], [APaterno], [AMaterno], [Edad])" +
                                      "VALUES  ('{0}','{1}','{2}','{3}')",
                                      N, AP, AM, E);
            CommandPersona = new SqlCommand( sqlString, Conn);
            CommandPersona.ExecuteNonQuery();
            CommandPersona = null;
        }

        public void CreateStringQuerySaveEstudiante(string M, string PG)
        {
            sqlString = "SELECT MAX (ID_Persona) ID_Persona FROM [Example].[dbo].[Persona]";
            CreateQueryReader(sqlString);
            QueryReader.Read();                        
            sqlString = String.Format("INSERT INTO [Example].[dbo].[Alumno] ([Matricula], [PromedioGeneral], [ID_Persona])" +
                                      "VALUES  ('{0}','{1}','{2}')",
                                      M, PG, QueryReader["ID_Persona"].ToString());
            QueryReader.Close();
            CommandEstudiante = new SqlCommand(sqlString, Conn);
            CommandEstudiante.ExecuteNonQuery();
            QueryReader = null;
            CommandEstudiante = null;
            MessageBox.Show("Datos guardados correctamente");
        }

        public void CreateStringQuerySaveProfesor(string M, string NP, string A)
        {
            sqlString = "SELECT MAX (ID_Persona) ID_Persona FROM [Example].[dbo].[Persona]";
            CreateQueryReader(sqlString);
            QueryReader.Read();
            sqlString = String.Format("INSERT INTO [Example].[dbo].[Profesor] ([Matricula],[NumeroPersonal],[Antiguedad],[ID_Persona])" +
                                      "VALUES  ('{0}','{1}','{2}','{3}')",
                                      M, NP, A, QueryReader["ID_Persona"].ToString());
            QueryReader.Close();
            CommandProfesor = new SqlCommand(sqlString, Conn);
            CommandProfesor.ExecuteNonQuery();
            QueryReader = null;
            CommandProfesor = null;
            MessageBox.Show("Datos guardados correctamente");
        }

        public void CreateQueryReader(string Q)
        {
            try
            {
                //MessageBox.Show(Q);
                CommandQueryReader = new SqlCommand(Q, Conn);
                QueryReader = CommandQueryReader.ExecuteReader();                              
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        public void CreateQueryDelete(string sTabla, string sID_Persona)
        {
            if (sTabla.Equals("Estudiante")) { sTabla = "Alumno"; }
            sqlString = String.Format("DELETE [Example].[dbo].[{0}] WHERE (ID_Persona =  {1} )", sTabla, sID_Persona);                                      
            CommandPersona = new SqlCommand(sqlString, Conn);
            CommandPersona.ExecuteNonQuery();
            CommandPersona = null;

            sqlString = String.Format("DELETE [Example].[dbo].[Persona] WHERE (ID_Persona =  {0} )", sID_Persona);
            CommandPersona = new SqlCommand(sqlString, Conn);
            CommandPersona.ExecuteNonQuery();
            CommandPersona = null;
        }

        public ProyEstudiantes.Modelo.Estudiante CreateQuerySelectEstudiante(string sFiltro)
        {
            ProyEstudiantes.Modelo.Estudiante et = new Modelo.Estudiante();
            sqlString = string.Format("SELECT * FROM [Example].[dbo].[{1}] WHERE (ID_Persona = {0})", sFiltro, "Persona");
            CreateQueryReader(sqlString);
            if (QueryReader.Read())
            {
                et.Nombre = QueryReader[1].ToString();
                et.APaterno = QueryReader[2].ToString();
                et.AMaterno = QueryReader[3].ToString();
                et.Edad = QueryReader[4].ToString();
            }
            QueryReader.Close();

            sqlString = string.Format("SELECT * FROM [Example].[dbo].[{1}] WHERE (ID_Persona = {0})", sFiltro, "Alumno");
            CreateQueryReader(sqlString);
            if (QueryReader.Read())
            {
                et.Matricula = QueryReader[0].ToString();
                et.PromedioGeneral = QueryReader[1].ToString();
            }
            QueryReader.Close();

            return et;
        }

        public ProyEstudiantes.Modelo.Profesor CreateQuerySelectProfesor(string sFiltro)
        {
            ProyEstudiantes.Modelo.Profesor pf = new Modelo.Profesor();
            sqlString = string.Format("SELECT * FROM [Example].[dbo].[{1}] WHERE (ID_Persona = {0})", sFiltro, "Persona");
            CreateQueryReader(sqlString);
            if (QueryReader.Read())
            {
                pf.Nombre = QueryReader[1].ToString();
                pf.APaterno = QueryReader[2].ToString();
                pf.AMaterno = QueryReader[3].ToString();
                pf.Edad = QueryReader[4].ToString();
            }
            QueryReader.Close();

            sqlString = string.Format("SELECT * FROM [Example].[dbo].[{1}] WHERE (ID_Persona = {0})", sFiltro, "Profesor");
            CreateQueryReader(sqlString);
            if (QueryReader.Read())
            {
                pf.Matricula = QueryReader[0].ToString();
                pf.NumeroPersonal = QueryReader[1].ToString();
                pf.Antiguedad = QueryReader[2].ToString();
            }
            QueryReader.Close();

            return pf;
        }

        public List<string> CreateQuerySelectList(string sTabla, string sFiltro)
        {
            List<string> lString = new List<string>();
            sqlString = string.Format("SELECT {0} FROM [Example].[dbo].[{1}]", sFiltro, sTabla);
            CreateQueryReader(sqlString);
            if (QueryReader.Read())
            {
                lString.Add(QueryReader[0].ToString());
                while (QueryReader.Read())
                {
                    //MessageBox.Show(QueryReader[0].ToString());
                    lString.Add(QueryReader[0].ToString());
                }
            }
            QueryReader.Close();

            return lString;
        }        

        public void CreateQueryUpdateEstudiante(string sID_Persona, string N, string AP, string AM, string M, string Pg, string E) 
        {            
                sqlString = String.Format("UPDATE [Example].[dbo].[Persona] SET Nombre = '{0}', APaterno = '{1}', AMaterno = '{2}', Edad = {3} where (ID_Persona = {4})",
                                          N, AP, AM, E, sID_Persona);
                CommandEstudiante = new SqlCommand(sqlString, Conn);
                CommandEstudiante.ExecuteNonQuery();
                CommandEstudiante = null;

                sqlString = String.Format("UPDATE [Example].[dbo].[Alumno] SET Matricula = '{0}', PromedioGeneral = '{1}' where (ID_Persona = {2})",
                                         M, Pg, sID_Persona);
                CommandEstudiante = new SqlCommand(sqlString, Conn);
                CommandEstudiante.ExecuteNonQuery();
                CommandEstudiante = null;
                MessageBox.Show("Datos actualizados correctamente");
        }

        public void CreateQueryUpdateProfesor(string sID_Persona, string N, string AP, string AM, string M, string Np, string A, string E)
        {
            sqlString = String.Format("UPDATE [Example].[dbo].[Persona] SET Nombre = '{0}', APaterno = '{1}', AMaterno = '{2}', Edad = {3} where (ID_Persona = {4})",
                                      N, AP, AM, E, sID_Persona);
            CommandProfesor = new SqlCommand(sqlString, Conn);
            CommandProfesor.ExecuteNonQuery();
            CommandProfesor = null;

            sqlString = String.Format("UPDATE [Example].[dbo].[Profesor] SET Matricula = '{0}', NumeroPersonal = '{1}', Antiguedad = '{2}' where (ID_Persona = {3})",
                                     M, Np, A, E, sID_Persona);
            CommandProfesor = new SqlCommand(sqlString, Conn);
            CommandProfesor.ExecuteNonQuery();
            CommandProfesor = null;
            MessageBox.Show("Datos actualizados correctamente");
        }

        public void CreateQuerySelect(string sTabla, string sFiltro, DataGridView Dv)
        {            
            sqlString = string.Format("SELECT {0} FROM [Example].[dbo].[{1}]", sFiltro, sTabla);
            CommandQueryReader = new SqlCommand(sqlString, Conn);
            SqlDataAdapter Adap = new SqlDataAdapter(CommandQueryReader);
            DataTable Dt = new DataTable();
            Adap.Fill(Dt);
            Dv.DataSource = Dt;        
        }        
    }
}
