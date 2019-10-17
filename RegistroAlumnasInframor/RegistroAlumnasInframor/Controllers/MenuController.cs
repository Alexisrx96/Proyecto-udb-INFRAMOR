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
            vista.btn_Creditos.Click += new EventHandler(Creditos);
            vista.btn_Salir.Click += new EventHandler(CerrarSesion);
            vista.pxminimizar.Click += new System.EventHandler(Minimizar);
            vista.pxventanas.Click += new System.EventHandler(Ventana);
            vista.pxclose.Click += new System.EventHandler(Cerrar);
        }
        #region PanelMenu
        private void Usuarios(object sender, EventArgs e)
        {
            OpenChildForm(new UsuarioView());
        }
        private void Alumnas(object sender, EventArgs e)
        {
            OpenChildForm(new AlumnaView());
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
        #endregion
        #region PanelVista
        private Form activeForm = null;
        private void OpenChildForm(UsuarioView childForm)
        {
            childForm.btn_CrearUsuario.Click += new EventHandler(NuevoUsuario);
            if (activeForm!=null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            vista.panelVista.Controls.Add(childForm);
            vista.panelVista.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                if (CrearUsuarioView.SelfClosing)
                {
                    activeForm.Close();
                    activeForm = null;
                    OpenChildForm(new UsuarioView());
                    CrearUsuarioView.SelfClosing = false;
                }
                else
                {
                    activeForm.Close();
                }
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            vista.panelVista.Controls.Add(childForm);
            vista.panelVista.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        #endregion
        #region EventosHijos
        private void NuevoUsuario(object sender, EventArgs e)
        {
            OpenChildForm(new CrearUsuarioView());
        }
        #endregion
        #region PanelTitulo
        private void Minimizar(object sender, EventArgs e)
        {
            vista.WindowState = FormWindowState.Minimized;
        }
        private void Ventana(object sender, EventArgs e)
        {
            if (vista.WindowState == FormWindowState.Normal)
            {
                vista.WindowState = FormWindowState.Maximized;
            }
            else
            {
                vista.WindowState = FormWindowState.Normal;
            }
        }
        private void Cerrar(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion
    }
}
