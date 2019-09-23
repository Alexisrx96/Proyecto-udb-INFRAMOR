using RegistroAlumnasInframor.Models.Dao;
using RegistroAlumnasInframor.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistroAlumnasInframor.Controllers
{
    class CrearUsuarioController
    {
        CrearUsuarioView vista;
        //Constructor
        public CrearUsuarioController(CrearUsuarioView view)
        {
            vista = view;
            //Inicializar eventos
            vista.btn_crear.Click += new EventHandler(UsuarioInsert);
        }
        private void UsuarioInsert(object sender, EventArgs e)
        {
            try
            {
                UsuarioDao db = new UsuarioDao();
                db.Insert(vista.txt_IdUsuarios.Text,
                            vista.txt_nombre.Text,
                            vista.txt_apellido.Text,
                            vista.txt_nomUsuario.Text,
                            vista.txt_contrasenia.Text,
                            vista.txt_rol.Text,
                            "Activo") ;
                MessageBox.Show("Se realizó con éxito");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se realizó con exito " + ex);
            }
        }
        public void Mostrar()
        {
            vista.ShowDialog();
        }
    }
}
