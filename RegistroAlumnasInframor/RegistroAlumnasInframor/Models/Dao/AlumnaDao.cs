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
        SqlDataReader leerFilas;
        SqlCommand cmd = new SqlCommand();
        public List<Alumna> VerRegistros(string condicion)
        {
            cmd.Connection = conexion;
            cmd.CommandText = "ProcedimientoAlmacenado";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@condicion",condicion);

            conexion.Open();

            leerFilas = cmd.ExecuteReader();
            List<Alumna> listaAlumnas = new List<Alumna>();
            while (leerFilas.Read())
            {
                listaAlumnas.Add
                    (new Alumna{
                    IdAlumna = leerFilas.GetString(0),
                    Nombre = leerFilas.GetString(1),
                    Apellido = leerFilas.GetString(2),
                    NIE = leerFilas.GetInt32(3),
                    AnioIngreso = leerFilas.GetDateTime(4),
                    AnioEgreso = leerFilas.GetDateTime(5),
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
