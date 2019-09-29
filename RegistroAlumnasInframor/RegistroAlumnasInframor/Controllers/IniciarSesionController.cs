using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            vista.btn_Aceptar.Click += new EventHandler(Login);
        }
        private void Login(object sender, EventArgs e)
        {
            UsuarioDao usuario = new UsuarioDao();
            if (usuario.ValidarInicio(vista.txt_NomUsuario.Text,vista.txt_Contrasenia.Text))
            {
                vista.Hide();
                MenuView menu = new MenuView();
                menu.ShowDialog();
                vista.Close();
            }
            else
            {
                MessageBox.Show("Usuario o Contraseña incorrecta");
            }
        }
    }
}
