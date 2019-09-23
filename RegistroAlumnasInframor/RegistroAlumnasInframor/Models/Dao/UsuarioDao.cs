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
        public List<Usuario> VerRegistros(string condicion)
        {
            cmd.Connection = this.AbrirConexion();
            cmd.CommandText = "SP_BuscarUsuario";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@condicion", condicion);
            leerFilas = cmd.ExecuteReader();
            List<Usuario> listaUsuarios = new List<Usuario>();
            while (leerFilas.Read())
            {
                listaUsuarios.Add
                    (new Usuario
                    {
                        IdUsuarios = leerFilas.GetString(0),
                        Nombre = leerFilas.GetString(1),
                        Apellido = leerFilas.GetString(2),
                        NombUsuario = leerFilas.GetString(3),
                        Contrasenia = leerFilas.GetString(4),
                        Rol = leerFilas.GetString(5),
                        Estado = leerFilas.GetString(6)
                    }) ;
            }
            leerFilas.Close();
            this.CerrarConexion();
            return listaUsuarios;
        }
        public bool ValidarInicio(string pNomUsuarios, string pContrasenia)
        {
            cmd.Connection = conexion;
            cmd.CommandText = "SP_ComprobarUsuario";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@NomUsuario", pNomUsuarios);
            cmd.Parameters.AddWithValue("@Contrasenia", pContrasenia);
            leerFilas = cmd.ExecuteReader();
            if (leerFilas.HasRows)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Insert(string pIdUsuario, string pNombre, string pApellido,string pNombUsuario, string pContrasenia, string pRol, string pEstado)
        {
            cmd.Connection = conexion;
            cmd.CommandText = "SP_InsertarUsuario";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdUsuarios", pIdUsuario);
            cmd.Parameters.AddWithValue("@NombresUsuarios", pNombre);
            cmd.Parameters.AddWithValue("@ApellidosUsuarios", pApellido);
            cmd.Parameters.AddWithValue("@NomUsuarios", pNombUsuario);
            cmd.Parameters.AddWithValue("@Contrasenias", pContrasenia);
            cmd.Parameters.AddWithValue("@Roles", pRol);
            cmd.Parameters.AddWithValue("@Estados", pEstado);
            conexion.Open();
            cmd.ExecuteNonQuery();
            conexion.Close();
        }
        public void Edit() { }
        public void Delete() { }
    }
}