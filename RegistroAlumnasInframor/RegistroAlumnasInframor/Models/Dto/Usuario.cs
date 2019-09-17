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
        private int _Id;
        private string _Nombre;
        private string _Apellido;
        private string _Contrasenia;
        private string _Rol;
        private string _Estado;
        //Propiedades GETTERS AND SETTERS
        public int Id { get => _Id; set => _Id = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Apellido { get => _Apellido; set => _Apellido = value; }
        public string Contrasenia { get => _Contrasenia; set => _Contrasenia = value; }
        public string Rol { get => _Rol; set => _Rol = value; }
        public string Estado { get => _Estado; set => _Estado = value; }
    }
}
