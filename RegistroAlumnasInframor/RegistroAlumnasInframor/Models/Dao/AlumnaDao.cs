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
            command.CommandText = "SP_BuscarAlumnas";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@condicion", condicion);
            leerFilas = command.ExecuteReader();
            alumnas.Load(leerFilas);
            leerFilas.Close();
            this.CerrarConexion();
            return alumnas;
        }
        public DataTable VerAlumnaSeleccionada(string condicion)
        {
            command = new SqlCommand();
            command.Connection = this.AbrirConexion();
            command.CommandText = "SP_BuscarAlumna";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@condicion", condicion);
            leerFilas = command.ExecuteReader();
            alumnas.Load(leerFilas);
            leerFilas.Close();
            this.CerrarConexion();
            return alumnas;
        }
        public void InsertarAlumna(string pIdAlumna, string pNombre, string pApellido,
                           int pNie, int pAnioIngreso, int pAnioEgreso,
                           DateTime pFechaNacimiento, int pIdLugarNacimiento,
                           string pNombrePadre, string pNombreMadre)
        {
            command = new SqlCommand();
            command.Connection = conexion;
            command.CommandText = "SP_InsertarAlumna";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@IdAlumna", pIdAlumna);
            command.Parameters.AddWithValue("@NombreAlumna", pNombre);
            command.Parameters.AddWithValue("@ApellidoAlumna", pApellido);
            command.Parameters.AddWithValue("@Nie", pNie);
            command.Parameters.AddWithValue("@AnioIngreso", pAnioIngreso);
            command.Parameters.AddWithValue("@AnioEgreso", pAnioEgreso);
            command.Parameters.AddWithValue("@FechaNacimiento", pFechaNacimiento);
            command.Parameters.AddWithValue("@IdLugarNacimiento", pIdLugarNacimiento);
            command.Parameters.AddWithValue("@NombrePadre", pNombrePadre);
            command.Parameters.AddWithValue("@NombreMadre", pNombreMadre);
            conexion.Open();
            command.ExecuteNonQuery();
            conexion.Close();
        }
        public void EditarAlumna(string pIdAlumna, string pNombre, string pApellido,
                           int pNie, int pAnioIngreso, int pAnioEgreso,
                           DateTime pFechaNacimiento, int pIdLugarNacimiento,
                           string pNombrePadre, string pNombreMadre, string pCondicion)
        {
            command = new SqlCommand();
            command.Connection = conexion;
            command.CommandText = "SP_EditarAlumna";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@IdAlumna", pIdAlumna);
            command.Parameters.AddWithValue("@NombreAlumna", pNombre);
            command.Parameters.AddWithValue("@ApellidoAlumna", pApellido);
            command.Parameters.AddWithValue("@Nie", pNie);
            command.Parameters.AddWithValue("@AnioIngreso", pAnioIngreso);
            command.Parameters.AddWithValue("@AnioEgreso", pAnioEgreso);
            command.Parameters.AddWithValue("@FechaNacimiento", pFechaNacimiento);
            command.Parameters.AddWithValue("@IdLugarNacimiento", pIdLugarNacimiento);
            command.Parameters.AddWithValue("@NombrePadre", pNombrePadre);
            command.Parameters.AddWithValue("@NombreMadre", pNombreMadre);
            command.Parameters.AddWithValue("@Condicion", pCondicion);
            conexion.Open();
            command.ExecuteNonQuery();
            conexion.Close();
        }
        public void Delete() { }
    }
}
