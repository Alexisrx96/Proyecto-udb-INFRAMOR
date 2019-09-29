using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RegistroAlumnasInframor.Views;
using RegistroAlumnasInframor.Models.Dao;
using System.Windows.Forms;

namespace RegistroAlumnasInframor.Controllers
{
    class ModificarUsuarioController
    {
        ModificarUsuarioView vista;
        string usuarioSeleccionado;
        UsuarioDao usuarioDao = new UsuarioDao();

        public ModificarUsuarioController(ModificarUsuarioView view, string usuario)
        {
            vista = view;
            usuarioSeleccionado = usuario;
            vista.Load += LlenarCampos;
            vista.btn_modificar.Click += GuardarCambios;

        }
        private void LlenarCampos(object sender, EventArgs e)
        {
            DataTable usuario = usuarioDao.VerUsuarios(usuarioSeleccionado);
            vista.txt_nombre.Text =usuario.Rows[0][0].ToString();
            vista.txt_apellido.Text = usuario.Rows[0][1].ToString();
            vista.txt_nomUsuario.Text = usuario.Rows[0][2].ToString();
            vista.check_activo.Checked = (bool)usuario.Rows[0][3];
        }
        private void GuardarCambios(object sender, EventArgs e)
        {
            int estado;
            if (vista.check_activo.Checked)
            {
                estado = 1;
            }
            else
            {
                estado = 0;
            }
            usuarioDao.EditarUsuario(vista.txt_nombre.Text,
            vista.txt_apellido.Text,
            vista.txt_nomUsuario.Text,
            estado,
            usuarioSeleccionado);
            vista.Close();
        }

    }
}
