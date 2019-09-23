using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroAlumnasInframor.Models.Dto
{
    class TiposNotas
    {
        private int _IdNotas;
        private string _Nombre;

        public int IdNotas { get => _IdNotas; set => _IdNotas = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
    }
}
