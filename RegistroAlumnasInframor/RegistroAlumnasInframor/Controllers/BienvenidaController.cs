using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RegistroAlumnasInframor.Views;
using System.Windows.Forms;

namespace RegistroAlumnasInframor.Controllers
{
    class BienvenidaController
    {
        BienvenidaView vista;
        public BienvenidaController(BienvenidaView view)
        {
            vista = view;
            vista.Shown += new EventHandler(Inicio);
            vista.timer1.Tick += new EventHandler(Cerrar);
        }
        private void Inicio (object sender, EventArgs e)
        {
            vista.timer1.Interval = 3000;
            vista.timer1.Start();
        }
        private void Cerrar(object sender,EventArgs e)
        {
            vista.timer1.Tick -= Cerrar;
            IniciarSesionView iniciarSesion = new IniciarSesionView();
            vista.Hide();
            iniciarSesion.ShowDialog();
            vista.Close();
        }
    }
}
