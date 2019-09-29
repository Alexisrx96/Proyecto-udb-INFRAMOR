using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RegistroAlumnasInframor.Models.Dao;
using RegistroAlumnasInframor.Models.Dto;
using RegistroAlumnasInframor.Views;
using System.Windows.Forms;

namespace RegistroAlumnasInframor.Controllers
{
    class UsuarioController
    {
        UsuarioView vista;
        //Constructor
        public UsuarioController(UsuarioView view)
        {
            vista = view;
            //Inicializar eventos
            vista.Load += new EventHandler(UsuarioList);
            vista.btn_buscar.Click += new EventHandler(CrearUsuario);
            vista.txt_buscar.TextChanged += new EventHandler(UsuarioList);
            vista.dgv_tablaUsuarios.DoubleClick += new EventHandler(EditarUsuario);
        }
        private void UsuarioList(object sender, EventArgs e)
        {
            UsuarioDao db = new UsuarioDao();
            vista.dgv_tablaUsuarios.DataSource =
                db.VerUsuarios(vista.txt_buscar.Text);
        }
        private void CrearUsuario(object sender, EventArgs e)
        {
            CrearUsuarioController crear = new CrearUsuarioController(new CrearUsuarioView());
            crear.Mostrar();

        }
        private void EditarUsuario(object sender, EventArgs e)
        {
            DataGridViewRow selected = vista.dgv_tablaUsuarios.SelectedRows[0];
            int indice = vista.dgv_tablaUsuarios.Rows.IndexOf(selected);
            UsuarioDao usuario = new UsuarioDao();
            string usuarioSeleccionado = usuario.UsuarioSeleccionado(indice,vista.txt_buscar.Text);
            ModificarUsuarioView modificarUsuario = new ModificarUsuarioView(usuarioSeleccionado);
            modificarUsuario.ShowDialog();

        }
        public void Mostrar()
        {
            vista.ShowDialog();
        }
    }
}
