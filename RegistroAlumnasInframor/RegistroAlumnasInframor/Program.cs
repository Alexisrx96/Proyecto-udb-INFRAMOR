using RegistroAlumnasInframor.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using RegistroAlumnasInframor.Models.Dao;

namespace RegistroAlumnasInframor
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            UsuarioDao usuario = new UsuarioDao();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(true);
            //Comprueba si hay usuarios creados para mostrar la primera pantalla
            if (usuario.HayUsuarios())
            {
                Application.Run(new BienvenidaView());
            }
            else
            {
                Application.Run(new CrearUsuarioView());
            }
        }
    }
}
