using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroAlumnasInframor.Models.Dto
{
    class Grados
    {
        private int _IdGrado;
        private string _Nombre;

        public int IdGrado { get => _IdGrado; set => _IdGrado = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
    }
}
