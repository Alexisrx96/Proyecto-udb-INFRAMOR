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
    class AlumnaDao:DbContext
    {
        DataTable alumnas = new DataTable();
        public DataTable VerAlumnas(string condicion)
        {
            command = new SqlCommand();
            command.Connection = this.AbrirConexion();
            command.CommandText = "SP_BuscarAlumnos";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@condicion", condicion);
            leerFilas = command.ExecuteReader();
            alumnas.Load(leerFilas);
            leerFilas.Close();
            this.CerrarConexion();
            return alumnas;
        }
        public void Insert() { }
        public void Edit() { }
        public void Delete() { }
    }
}
