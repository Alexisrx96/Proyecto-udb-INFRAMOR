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
            command = new SqlCommand();
            DataTable materias = new DataTable();
            command.Connection = this.AbrirConexion();
            command.CommandText = "SP_ListarMaterias";
            command.CommandType = CommandType.StoredProcedure;
            leerFilas = command.ExecuteReader();
            materias.Load(leerFilas);
            leerFilas.Close();
            this.CerrarConexion();
            return materias;
        }
    }
}
