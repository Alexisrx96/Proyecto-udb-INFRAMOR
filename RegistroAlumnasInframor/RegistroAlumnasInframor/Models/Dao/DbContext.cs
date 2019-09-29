using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroAlumnasInframor.Models.Dao
{
    public class DbContext
    {
        protected SqlConnection conexion;
        protected SqlDataReader leerFilas;
        protected SqlCommand command;

        public DbContext()
        {
            string server = "localhost";
            string dataBase = "InstitutoBD";
            conexion = new SqlConnection("Server=" + server + ";DataBase="+ dataBase + ";Integrated Security=True");
        }
        protected SqlConnection AbrirConexion()
        {
            if (conexion.State == ConnectionState.Closed)
            {
                conexion.Open();
            }
            return conexion;
        }
        protected SqlConnection CerrarConexion()
        {
            if (conexion.State == ConnectionState.Open)
            {
                conexion.Close();
            }
            return conexion;
        }
    }
}
