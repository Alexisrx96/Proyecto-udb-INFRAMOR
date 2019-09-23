using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroAlumnasInframor.Models.Dto
{
    class Alumna
    {
        //ATRIBUTOS
        private string _IdAlumna;
        private string _Nombre;
        private string _Apellido;
        private int _NIE;
        private int _AnioIngreso;
        private int _AnioEgreso;
        private DateTime _FechaNacimiento;
        private string _IdDepartamnto;
        private string _NombrePadre;
        private string _NombreMadre;
        //PROPIEDADES GETTERS AND SETTTERS
        public string IdAlumna { get => _IdAlumna; set => _IdAlumna = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Apellido { get => _Apellido; set => _Apellido = value; }
        public int NIE { get => _NIE; set => _NIE = value; }
        public int AnioIngreso { get => _AnioIngreso; set => _AnioIngreso = value; }
        public int AnioEgreso { get => _AnioEgreso; set => _AnioEgreso = value; }
        public DateTime FechaNacimiento { get => _FechaNacimiento; set => _FechaNacimiento = value; }
        public string IdDepartamnto { get => _IdDepartamnto; set => _IdDepartamnto = value; }
        public string NombrePadre { get => _NombrePadre; set => _NombrePadre = value; }
        public string NombreMadre { get => _NombreMadre; set => _NombreMadre = value; }
    }
}
