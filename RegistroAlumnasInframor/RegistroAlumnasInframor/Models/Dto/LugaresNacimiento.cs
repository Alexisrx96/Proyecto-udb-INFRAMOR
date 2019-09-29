using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroAlumnasInframor.Models.Dto
{
    class LugaresNacimiento
    {
        private int _IdLugaresNacimiento;
        private string _Nombre;

        public int IdLugaresNacimiento { get => _IdLugaresNacimiento; set => _IdLugaresNacimiento = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
    }
}
