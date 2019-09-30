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
            vista.btn_cerrarSesion.Click += new EventHandler(CerrarSesion);
            vista.btn_Creditos.Click += new EventHandler(Creditos);
            vista.btnMin.Click += new System.EventHandler(Minimizar);
            vista.btnMax.Click += new System.EventHandler(Maximizar);
            vista.btnCerrar.Click += new System.EventHandler(Cerrar);
        }
        private void Usuarios(object sender, EventArgs e)
        {
            UsuarioView usuarios = new UsuarioView();
            vista.Hide();
            usuarios.ShowDialog();
            vista.Close();
        }
        private void Alumnas(object sender, EventArgs e)
        {
            NuevaAlumnaView Alumna = new NuevaAlumnaView();
            vista.Hide();
            Alumna.ShowDialog();
            vista.Close();
        }
        private void CerrarSesion(object sender, EventArgs e)
        {
            IniciarSesionView iniciarSesion = new IniciarSesionView();
            vista.Hide();
            iniciarSesion.ShowDialog();
            vista.Close();
        }
        private void Creditos(object sender, EventArgs e)
        {
            CreditosView creditos = new CreditosView();
            vista.Hide();
            creditos.ShowDialog();
            vista.Close();
        }
        private void Minimizar(object sender, EventArgs e)
        {
            vista.WindowState = FormWindowState.Minimized;
        }
        private void Maximizar(object sender, EventArgs e)
        {
            vista.WindowState = FormWindowState.Maximized;
            vista.btnMax.Visible = false;
        }
        private void Cerrar(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
