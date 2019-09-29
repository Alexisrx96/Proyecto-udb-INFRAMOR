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
            if (usuario.HayUsuarios())
            {
                Application.Run(new UsuarioView());
            }
            else
            {
                Application.Run(new CrearUsuarioView());
            }
        }
    }
}
