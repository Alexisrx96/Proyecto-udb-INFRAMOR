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
        protected SqlCommand cmd;
        public DbContext()
        {
            conexion = new SqlConnection("Server=MSI ;DataBase=InstitutoBD ;Integrated Security=True ");
            cmd = new SqlCommand();
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
