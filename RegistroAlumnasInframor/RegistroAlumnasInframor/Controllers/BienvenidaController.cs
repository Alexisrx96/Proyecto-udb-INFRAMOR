using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RegistroAlumnasInframor.Views;
using System.Windows.Forms;
using RegistroAlumnasInframor.Models.Dao;
using System.Drawing;

namespace RegistroAlumnasInframor.Controllers
{
    class BienvenidaController
    {
        BienvenidaView vista;
        PictureBox[] pict; //declaramos una matriz
        int count = 0;
        private int tab = 0;
        public BienvenidaController(BienvenidaView view)
        {
            vista = view;
            vista.timerCerrar.Tick += new EventHandler(Cerrar);
            vista.timerCarga.Tick += new System.EventHandler(BarraDeCarga);
            vista.timerTab.Tick += new System.EventHandler(CambiarTab);
            vista.Load += new System.EventHandler(Inicio);
        }
        private void Inicio (object sender, EventArgs e)
        {
            vista.timerCerrar.Interval = 5000;
            vista.timerCerrar.Start();
            vista.timerCarga.Start();
            pict = new PictureBox[5] { vista.P1, vista.P2, vista.P3, vista.P4, vista.P5 };
        }
        private void BarraDeCarga(object sender, EventArgs e)
        {
            if (count < 5)
            {
                pict[count].BackColor = Color.DarkGreen;
                count++;
                vista.lbl_carga.Text = "CARGANDO AL " + (count * 20) + " %";
            }
            else
            {
                vista.timerCarga.Enabled = false;
            }
        }
        private void CambiarTab(object sender, EventArgs e)
        {
            tab++;
            vista.tabControl1.SelectTab(tab);
            vista.timerTab.Stop();
        }
        private void Cerrar(object sender,EventArgs e)
        {
            vista.timerCerrar.Stop();
            UsuarioDao usuario = new UsuarioDao();
            if (usuario.HayUsuarios())
            {
                IniciarSesionView iniciarSesion = new IniciarSesionView();
                vista.Hide();
                iniciarSesion.ShowDialog();
                vista.Close();
            }
            else
            {
                CrearUsuarioView crearUsuario = new CrearUsuarioView();
                vista.Hide();
                crearUsuario.ShowDialog();
                vista.Close();
            }
        }
    }
}
