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
        public List<Alumna> VerRegistros(string condicion)
        {
            command = new SqlCommand();
            command.Connection = this.AbrirConexion();
            command.CommandText = "ProcedimientoAlmacenado";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@condicion",condicion);

            conexion.Open();

            leerFilas = command.ExecuteReader();
            List<Alumna> listaAlumnas = new List<Alumna>();
            while (leerFilas.Read())
            {
                listaAlumnas.Add
                    (new Alumna{
                    IdAlumna = leerFilas.GetString(0),
                    Nombre = leerFilas.GetString(1),
                    Apellido = leerFilas.GetString(2),
                    NIE = leerFilas.GetInt32(3),
                    AnioIngreso = leerFilas.GetInt32(4),
                    AnioEgreso = leerFilas.GetInt32(5),
                    FechaNacimiento = leerFilas.GetDateTime(6),
                    IdDepartamnto = leerFilas.GetString(7),
                    NombrePadre = leerFilas.GetString(8),
                    NombreMadre = leerFilas.GetString(9)
                    });
            }
            leerFilas.Close();
            conexion.Close();
            return listaAlumnas;
        }
        public void Insert() { }
        public void Edit() { }
        public void Delete() { }
    }
}
