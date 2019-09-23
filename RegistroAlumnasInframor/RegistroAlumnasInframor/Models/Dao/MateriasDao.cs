using RegistroAlumnasInframor.Models.Dto;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroAlumnasInframor.Models.Dao
{
    class MateriasDao:DbContext
    {
        public DataTable ListaMaterias()
        {
            DataTable materias = new DataTable();
            cmd.Connection = this.AbrirConexion();
            cmd.CommandText = "SP_ListarMaterias";
            cmd.CommandType = CommandType.StoredProcedure;
            leerFilas = cmd.ExecuteReader();
            materias.Load(leerFilas);
            leerFilas.Close();
            this.CerrarConexion();
            return materias;
        }
    }
}
