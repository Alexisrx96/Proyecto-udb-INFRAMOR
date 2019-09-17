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
    class UsuarioDao:DbContext
    {
        SqlDataReader leerFilas;
        SqlCommand cmd = new SqlCommand();
        public List<Usuario> VerRegistros(string condicion)
        {
            cmd.Connection = conexion;
            cmd.CommandText = "PC_BuscarUsuario";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@condicion", condicion);

            conexion.Open();

            leerFilas = cmd.ExecuteReader();
            List<Usuario> listaUsuarios = new List<Usuario>();
            while (leerFilas.Read())
            {
                listaUsuarios.Add
                    (new Usuario
                    {
                        Id = leerFilas.GetInt32(0),
                        Nombre = leerFilas.GetString(1),
                        Apellido = leerFilas.GetString(2),
                        Contrasenia = leerFilas.GetString(3),
                        Rol = leerFilas.GetString(4),
                        Estado = leerFilas.GetString(5)
                    });
            }
            leerFilas.Close();
            conexion.Close();
            return listaUsuarios;
        }
        public void Insert(int pId, string pNombre, string pApellido,string pNomUsuario, string pContrasenia, string pRol, string pEstado)
        {
            cmd.Connection = conexion;
            cmd.CommandText = "PC_InsertarUsuario";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id", pId);
            cmd.Parameters.AddWithValue("@Nombre", pNombre);
            cmd.Parameters.AddWithValue("@Apellido", pApellido);
            cmd.Parameters.AddWithValue("@NomUsuario", pNomUsuario);
            cmd.Parameters.AddWithValue("@Contraseña ", pContrasenia);
            cmd.Parameters.AddWithValue("@Rol", pRol);
            cmd.Parameters.AddWithValue("@Estado", pEstado);
            conexion.Open();
            cmd.ExecuteNonQuery();
            conexion.Close();
        }
        public void Edit() { }
        public void Delete() { }
    }
}