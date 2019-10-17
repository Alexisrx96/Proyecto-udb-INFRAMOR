using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RegistroAlumnasInframor.Views;

namespace RegistroAlumnasInframor.Controllers
{
    class CreditosController
    {
        CreditosView vista;
        public CreditosController(CreditosView view)
        {
            vista = view;
            vista.pxclose.Click += new EventHandler(CerrarVentana);
            vista.pxventanas.Click += new EventHandler(Ventana);
            vista.pxminimizar.Click += new EventHandler(Minimizar);
            vista.btn_regresar.Click += new EventHandler(Regresar);
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
        private void CerrarVentana(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Minimizar(object sender, EventArgs e)
        {
            vista.WindowState = FormWindowState.Minimized;
        }
        private void Regresar(object sender, EventArgs e)
        {
            MenuView menu = new MenuView();
            vista.Hide();
            menu.ShowDialog();
            vista.Close();
        }
    }
}
