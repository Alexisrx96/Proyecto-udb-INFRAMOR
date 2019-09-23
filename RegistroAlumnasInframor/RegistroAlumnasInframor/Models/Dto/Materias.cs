using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroAlumnasInframor.Models.Dto
{
    class Materias
    {
        private int _IdMateria;
        private string _NombreMateria;
        private int _AreaBasica;

        public int IdMateria { get => _IdMateria; set => _IdMateria = value; }
        public string NombreMateria { get => _NombreMateria; set => _NombreMateria = value; }
        public int AreaBasica { get => _AreaBasica; set => _AreaBasica = value; }
    }
}
