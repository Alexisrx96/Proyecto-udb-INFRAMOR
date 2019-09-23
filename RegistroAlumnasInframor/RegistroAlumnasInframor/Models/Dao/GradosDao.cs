using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroAlumnasInframor.Models.Dao
{
    class GradosDao:DbContext
    {
        public DataTable ListaGrados()
        {
            DataTable grados = new DataTable();
            cmd.Connection = this.AbrirConexion();
            cmd.CommandText = "SP_ListarGrados";
            cmd.CommandType = CommandType.StoredProcedure;
            leerFilas = cmd.ExecuteReader();
            grados.Load(leerFilas);
            leerFilas.Close();
            this.CerrarConexion();
            return grados;
        }
    }
}
