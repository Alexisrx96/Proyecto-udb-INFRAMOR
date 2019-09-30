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
        //Se crea una instancia de la vista
        ModificarUsuarioView vista;
        //Se almacena el NomUsuario que se desea modificar
        string usuarioSeleccionado;
        //Se crea una instancia del modelo
        UsuarioDao usuarioDao = new UsuarioDao();
        //Se piden como parámetros una instancia de la vista y el nomUsuario del usuario a modificar
        public ModificarUsuarioController(ModificarUsuarioView view, string usuario)
        {
            //Brinda acceso a los a controladores del formullario
            vista = view;
            usuarioSeleccionado = usuario;
            //Se le asigna la función LlenarCampos al evento Load del formulario
            vista.Load += new EventHandler(LlenarCampos);
            //Se le asigna la función GuardarCambios al evento Click del botón btn_modificar
            vista.btn_modificar.Click += new EventHandler(GuardarCambios);
            vista.btn_calcelar.Click += new EventHandler(Cancelar);
            vista.btn_borrar.Click +=new EventHandler(EliminarUsuario);
        }
        private void LlenarCampos(object sender, EventArgs e)
        {
            //Se le asigna valores de la base de datos a los controladores
            DataTable usuario = usuarioDao.VerUsuarioSeleccionado(usuarioSeleccionado);
            vista.txt_nombre.Text =usuario.Rows[0][0].ToString();
            vista.txt_apellido.Text = usuario.Rows[0][1].ToString();
            vista.txt_nomUsuario.Text = usuario.Rows[0][2].ToString();
            //Si el valor de la columna es 1 se convierte a verdadero y si es 0 se cnvierte a falso
            vista.check_activo.Checked = (bool)usuario.Rows[0][3];
        }
        private void EliminarUsuario(object sender, EventArgs e)
        {
            if (MessageBox.Show("Se eliminará el usuario: " + usuarioSeleccionado + "\n¿Desea continuar?",
                                     "Crear usuario",
                                     MessageBoxButtons.YesNo,
                                     MessageBoxIcon.Information) == DialogResult.Yes)
            {
                try
                {
                    usuarioDao.EliminarUsuario(usuarioSeleccionado);
                    vista.Close();
                    MessageBox.Show("Se elimió el usuario con éxito");
                    vista.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se realizó con exito " + ex);
                }
            }
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
            if (CamposVacios())
            {
                if (MessageBox.Show("Se modificará el usuario: " + usuarioSeleccionado + "\n¿Desea continuar?",
                                    "Crear usuario",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    try
                    {
                        usuarioDao.EditarUsuario(vista.txt_nombre.Text,
                        vista.txt_apellido.Text,
                        vista.txt_nomUsuario.Text,
                        estado,
                        usuarioSeleccionado);
                        vista.Close();
                        MessageBox.Show("Se Modificó el usuario con éxito");
                        vista.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No se realizó con exito " + ex);
                    }
                }
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error");
            }
        }
        private bool CamposVacios()
        {
            bool validado = true;
            //Muestra el error si el campo está vacío
            if (string.IsNullOrWhiteSpace(vista.txt_nombre.Text))
            {
                validado = false;
                vista.errorProvider1.SetError(vista.txt_nombre, "El campo no puede estar vacío");
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
            if (validado)
            {
                vista.errorProvider1.Clear();
            }
            return validado;
        }
        private void Cancelar(object sender, EventArgs e)
        {
            vista.Close();
        }
        private void UsuarioInsert(object sender, EventArgs e)
        {
            if (CamposVacios())
            {
                if (MessageBox.Show("Se modificará el usuario: " + vista.txt_nomUsuario.Text + "\n¿Desea continuar?",
                                    "Crear usuario",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    try
                    {
                        UsuarioDao db = new UsuarioDao();

                        MessageBox.Show("Se creó el usuario con éxito");
                        vista.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No se realizó con exito " + ex);
                    }
                }
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error");
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
            if (validado)
            {
                vista.errorProvider1.SetError(vista.txt_nombre, "");
            }
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
            if (validado)
            {
                vista.errorProvider1.SetError(vista.txt_apellido, "");
            }
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
