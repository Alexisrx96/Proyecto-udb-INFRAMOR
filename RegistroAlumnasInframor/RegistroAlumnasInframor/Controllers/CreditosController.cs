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
            vista.btnCerrarCred.Click += new EventHandler(Cerrar);
            vista.btnMaxCred.Click += new EventHandler(Maximizar);
            vista.btnMinCred.Click += new EventHandler(Minimizar);
            vista.btn_regresar.Click += new EventHandler(Regresar);
        }
        private void Maximizar(object sender, EventArgs e)
        {
            vista.WindowState = FormWindowState.Maximized;
            vista.btnMaxCred.Visible = false;
        }
        private void Cerrar(object sender, EventArgs e)
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
