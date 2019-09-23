using RegistroAlumnasInframor.Models.Dao;
using RegistroAlumnasInframor.Models.Dto;
using RegistroAlumnasInframor.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroAlumnasInframor.Controllers
{
    class NuevaAlumnaController
    {
        NuevaAlumnaView vista;
        public NuevaAlumnaController(NuevaAlumnaView view)
        {
            vista = view;
            vista.Load += new EventHandler(ListarLugarNacimiento);
        }
        private void ListarLugarNacimiento(object sender, EventArgs e)
        {
            LugaresNacimientoDao departamentos = new LugaresNacimientoDao();
            vista.cmb_LugarNacimiento.DataSource = departamentos.ListaDepartamentos();
            vista.cmb_LugarNacimiento.DisplayMember = "NombreDepartamento";
            vista.cmb_LugarNacimiento.ValueMember = "IdLugarNacimiento";
        }
        public void Mostrar()
        {
            vista.ShowDialog();
        }
    }
}
