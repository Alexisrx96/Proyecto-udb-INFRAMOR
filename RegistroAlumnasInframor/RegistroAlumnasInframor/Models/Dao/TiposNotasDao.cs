using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroAlumnasInframor.Models.Dao
{
    class TiposNotasDao:DbContext
    {
        public DataTable ListaTiposNotas()
        {
            DataTable TiposNotnas = new DataTable();
            cmd.Connection = this.AbrirConexion();
            cmd.CommandText = "SP_ListarTiposNotas";
            cmd.CommandType = CommandType.StoredProcedure;
            leerFilas = cmd.ExecuteReader();
            TiposNotnas.Load(leerFilas);
            leerFilas.Close();
            this.CerrarConexion();
            return TiposNotnas;
        }
    }
}
