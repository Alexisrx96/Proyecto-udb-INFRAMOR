using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroAlumnasInframor.Models.Dao
{
    class LugaresNacimientoDao:DbContext
    {
        public DataTable ListaDepartamentos()
        {
            DataTable departamentos = new DataTable();
            cmd.Connection = this.AbrirConexion();
            cmd.CommandText = "SP_ListarDepartamentos";
            cmd.CommandType = CommandType.StoredProcedure;
            leerFilas = cmd.ExecuteReader();
            departamentos.Load(leerFilas);
            leerFilas.Close();
            this.CerrarConexion();
            return departamentos;
        }
    }
}
