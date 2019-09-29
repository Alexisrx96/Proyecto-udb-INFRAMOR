using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroAlumnasInframor.Models.Dto
{
    class Usuario
    {
        //Atributos
        private string _IdUsuarios;
        private string _Nombre;
        private string _Apellido;
        private string _Contrasenia;
        private string _NombUsuario;
        private int _Rol;
        private int _Estado;
        //Propiedades GETTERS AND SETTERS
        public string IdUsuarios { get => _IdUsuarios; set => _IdUsuarios = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Apellido { get => _Apellido; set => _Apellido = value; }
        public string NombUsuario { get => _NombUsuario; set => _NombUsuario = value; }
        public string Contrasenia { get => _Contrasenia; set => _Contrasenia = value; }
        public int Rol { get => _Rol; set => _Rol = value; }
        public int Estado { get => _Estado; set => _Estado = value; }
    }
}
