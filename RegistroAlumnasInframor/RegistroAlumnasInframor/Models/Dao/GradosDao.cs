using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroAlumnasInframor.Models.Dao
{
    class GradosDao:DbContext
    {
        public DataTable ListaGrados()
        {
            command = new SqlCommand();
            DataTable grados = new DataTable();
            command.Connection = this.AbrirConexion();
            command.CommandText = "SP_ListarGrados";
            command.CommandType = CommandType.StoredProcedure;
            leerFilas = command.ExecuteReader();
            grados.Load(leerFilas);
            leerFilas.Close();
            this.CerrarConexion();
            return grados;
        }
    }
}
