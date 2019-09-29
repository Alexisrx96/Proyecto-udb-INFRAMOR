using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroAlumnasInframor.Models.Dao
{
    class LugaresNacimientoDao:DbContext
    {
        public DataTable ListaDepartamentos()
        {
            command = new SqlCommand();
            DataTable departamentos = new DataTable();
            command.Connection = this.AbrirConexion();
            command.CommandText = "SP_ListarDepartamentos";
            command.CommandType = CommandType.StoredProcedure;
            leerFilas = command.ExecuteReader();
            departamentos.Load(leerFilas);
            leerFilas.Close();
            this.CerrarConexion();
            return departamentos;
        }
    }
}
