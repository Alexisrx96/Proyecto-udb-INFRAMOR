using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RegistroAlumnasInframor.Models.Dao;
using RegistroAlumnasInframor.Models.Dto;
using RegistroAlumnasInframor.Views;

namespace RegistroAlumnasInframor.Controllers
{
    class IniciarSesionController
    {
        private IniciarSesionView vista;
        public IniciarSesionController(IniciarSesionView view)
        {
            vista = view;
            vista.btn_Aceptar.Click += new EventHandler(Login);
            vista.txt_NomUsuario.KeyPress += new KeyPressEventHandler(UsuarioKeyPress);
        }
        private bool CamposVacios2()
        {
            bool validado=true;
            foreach (Control item in vista.Controls)
            {
                if(item is TextBox&&string.IsNullOrWhiteSpace(item.Text))
                {
                    validado = false;
                    vista.errorProvider1.SetError(item, "El campo no puede estar vacío");
                }
            }
            return validado;
        }
        private bool CamposVacios()
        {
            bool validado = true;
            if (string.IsNullOrWhiteSpace(vista.txt_NomUsuario.Text))
            {
                validado = false;
                vista.errorProvider1.SetError(vista.txt_NomUsuario, "El campo no puede estar vacío");
            }
            if (string.IsNullOrWhiteSpace(vista.txt_Contrasenia.Text))
            {
                validado = false;
                vista.errorProvider1.SetError(vista.txt_Contrasenia, "El campo no puede estar vacío");
            }
            return validado;
        }
        private void Login(object sender, EventArgs e)
        {
            if (CamposVacios())
            {
                UsuarioDao usuario = new UsuarioDao();
                if (usuario.ValidarInicio(vista.txt_NomUsuario.Text, vista.txt_Contrasenia.Text))
                {
                    vista.Hide();
                    MenuView menu = new MenuView();
                    menu.ShowDialog();
                    vista.Close();
                }
                else
                {
                    MessageBox.Show("Usuario o Contraseña incorrecta");
                }
            }
        }
        protected void UsuarioKeyPress(object sender, KeyPressEventArgs e)
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
                vista.errorProvider1.SetError(vista.txt_NomUsuario, "");
            }
            else
            {
                vista.errorProvider1.SetError(vista.txt_NomUsuario, "Solo se admiten números y letras");
            }
        }
    }
}
