using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RegistroAlumnasInframor.Views;

namespace RegistroAlumnasInframor.Controllers
{
    class MenuController
    {
        MenuView vista;
        public MenuController(MenuView view)
        {
            vista = view;
            vista.btn_Usuarios.Click += new EventHandler(Usuarios);
            vista.btn_Alumnas.Click += new EventHandler(Alumnas);
            vista.btn_Salir.Click += new EventHandler(Salir);
        }
        private void Usuarios(object sender, EventArgs e)
        {
            UsuarioView usuarios = new UsuarioView();
            usuarios.ShowDialog();
        }
        private void Alumnas(object sender, EventArgs e)
        {
            NuevaAlumnaView Alumna = new NuevaAlumnaView();
            Alumna.ShowDialog();
        }
        private void Salir(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
