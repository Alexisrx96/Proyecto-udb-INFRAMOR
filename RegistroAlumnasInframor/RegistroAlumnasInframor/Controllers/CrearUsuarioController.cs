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
            vista.btn_cancelar.Click += new EventHandler(Cancelar);
            vista.txt_nombre.KeyPress += new KeyPressEventHandler(NombreKeyPress);
            vista.txt_apellido.KeyPress += new KeyPressEventHandler(ApellidoKeyPress);
            vista.txt_nomUsuario.KeyPress += new KeyPressEventHandler(NomUsuarioKeyPress);
        }
        private bool CamposVacios()
        {
            bool validado=true;
            if (string.IsNullOrWhiteSpace(vista.txt_nombre.Text))
            {
                validado = false;
                vista.errorProvider1.SetError(vista.txt_nombre,"El campo no puede estar vacío");
            }
            if (string.IsNullOrWhiteSpace(vista.txt_apellido.Text))
            {
                validado = false;
                vista.errorProvider1.SetError(vista.txt_apellido, "El campo no puede estar vacío");
            }
            if (string.IsNullOrWhiteSpace(vista.txt_nomUsuario.Text))
            {
                validado = false;
                vista.errorProvider1.SetError(vista.txt_nomUsuario, "El campo no puede estar vacío");
            }
            if (string.IsNullOrWhiteSpace(vista.txt_contrasenia.Text))
            {
                validado = false;
                vista.errorProvider1.SetError(vista.txt_contrasenia, "El campo no puede estar vacío");
            }
            if (string.IsNullOrWhiteSpace(vista.txt_confirmar.Text))
            {
                validado = false;
                vista.errorProvider1.SetError(vista.txt_confirmar, "El campo no puede estar vacío");
            }
            else if (vista.txt_confirmar.Text!=vista.txt_contrasenia.Text)
            {
                validado = false;
                vista.errorProvider1.SetError(vista.txt_confirmar, "La contraseña no coincide");
            }
            return validado;
        }
        private void Cancelar(object sender, EventArgs e)
        {
            vista.Close();
        }
        private void UsuarioInsert(object sender, EventArgs e)
        {
            bool hayUsuarios;
            if (CamposVacios())
            {
                //Si el usuario elige la opción "Yes", crea un registro en la base de datos
                if (MessageBox.Show("Se creará el usuario: "+vista.txt_nomUsuario.Text+"\n¿Desea continuar?",
                                    "Crear usuario",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    try
                    {
                        UsuarioDao nuevoUsuario = new UsuarioDao();
                        //Verifica si es la primera vez que se ejecuta el programa con una base de datos vacía
                        hayUsuarios = nuevoUsuario.HayUsuarios();
                        //Crea un registro en la base de datos mediante UsuarioDao
                        nuevoUsuario.Insert(vista.txt_nombre.Text,
                                    vista.txt_apellido.Text,
                                    vista.txt_nomUsuario.Text,
                                    vista.txt_contrasenia.Text,
                                    1);
                        //Si hay registros, simplemente cierra la ventana
                        MessageBox.Show("Se creó el usuario con éxito");
                        if (hayUsuarios)
                        {
                            vista.Close();
                        }
                        //Si la base de datos está vacía antes de crear al primer usuario envía al menú de bienvenida
                        else
                        {
                            BienvenidaView bienvenida = new BienvenidaView();
                            vista.Hide();
                            bienvenida.ShowDialog();
                            vista.Close();
                        }
                    }
                    //
                    catch (Exception ex)
                    {
                        MessageBox.Show("No se realizó con exito...\n" + ex,
                            "Error",
                            MessageBoxButtons.OK, 
                            MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error, compruebe los datos ingresados",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }

        }
        protected void NombreKeyPress(object sender, KeyPressEventArgs e)
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
            //si no cumple nada de lo anterior que no lo deje pasar
            else
            {
                e.Handled = true;
                validado = false;
            }
            //Si validado es verdadero, no muestra error
            if (validado)
            {
                vista.errorProvider1.SetError(vista.txt_nombre, "");
            }
            //Si validado es falso, muestra el mensaje de error
            else
            {
                vista.errorProvider1.SetError(vista.txt_nombre, "Solo se admiten letras");
            }
        }
        protected void ApellidoKeyPress(object sender, KeyPressEventArgs e)
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
            //si no cumple nada de lo anterior que no lo deje pasar
            else
            {
                e.Handled = true;
                validado = false;
            }
            //Si validado es verdadero, no muesta el error 
            if (validado)
            {
                vista.errorProvider1.SetError(vista.txt_apellido, "");
            }
            //Si validado es falso, se muestra el error
            else
            {
                vista.errorProvider1.SetError(vista.txt_apellido, "Solo se admiten letras");
            }
        }
        protected void NomUsuarioKeyPress(object sender, KeyPressEventArgs e)
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
            //Para admitir dígitos
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
                vista.errorProvider1.SetError(vista.txt_nomUsuario, "");
            }
            else
            {
                vista.errorProvider1.SetError(vista.txt_nomUsuario, "Solo se admiten números y letras");
            }
        }
    }
}
