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
            //El evento cuando recive la atencion(al ser activado ya sea dando clic sobre el formulario o por cerrar un Diálogo)
            vista.Activated += new EventHandler(UsuarioList);
            vista.txt_buscar.KeyPress += new KeyPressEventHandler(BuscarKeyPress);
        }
        private void Cancelar(object sender, EventArgs e)
        {
            vista.Close();
        }

        private void UsuarioList(object sender, EventArgs e)
        {
            UsuarioDao db = new UsuarioDao();
            vista.dgv_tablaUsuarios.DataSource =
                db.VerUsuarios(vista.txt_buscar.Text);
        }
        private void CrearUsuario(object sender, EventArgs e)
        {
            CrearUsuarioView crear = new CrearUsuarioView();
            crear.ShowDialog();

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
        protected void BuscarKeyPress(object sender, KeyPressEventArgs e)
        {
            bool validado;
            //condicion para solo números
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
                validado = true;
            }//para backspace
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
                validado = true;
            }//para que admita tecla de espacio
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
                validado = true;
            }
            else if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
                validado = true;
            }
            //si no cumple nada de lo anterior que no lo deje pasar
            else
            {
                e.Handled = true;
                validado = false;
            }
            if (validado)
            {
                vista.errorProvider1.SetError(vista.txt_buscar, "");
            }
            else
            {
                vista.errorProvider1.SetError(vista.txt_buscar, "Solo se admiten números y letras");
            }
        }
    }
}
