using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RegistroAlumnasInframor.Models.Dao;
using RegistroAlumnasInframor.Models.Dto;
using RegistroAlumnasInframor.Views;

namespace RegistroAlumnasInframor.Controllers
{
    class IniciarSesionController
    {
        private IniciarSesionView vista;
        public IniciarSesionController(IniciarSesionView view)
        {
            vista = view;

        }
        private void Login(object sender, EventArgs e)
        {
            UsuarioDao usuario = new UsuarioDao();
            if (usuario.ValidarInicio(vista.txt_NomUsuario.Text,vista.txt_Contrasenia.Text))
            {
                vista.Close();
            }
        }
    }
}
