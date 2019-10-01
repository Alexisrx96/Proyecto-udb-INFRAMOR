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
    class ModificarAlumnaController
    {
        //Se crea una instancia de la vista
        ModificarAlumnaView vista;
        //Se almacena el NomUsuario que se desea modificar
        string alumnaSeleccionada;
        //Se crea una instancia del modelo
        AlumnaDao alumnaDao = new AlumnaDao();
        //Se piden como parámetros una instancia de la vista y el nomUsuario del usuario a modificar
        public ModificarAlumnaController(ModificarAlumnaView view, string alumna)
        {
            //Brinda acceso a los a controladores del formullario
            vista = view;
            alumnaSeleccionada = alumna;
            //Se le asigna la función LlenarCampos al evento Load del formulario
            vista.Load += new EventHandler(LlenarCampos);
            //Se le asigna la función GuardarCambios al evento Click del botón btn_modificar
            vista.btn_modificar.Click += new EventHandler(GuardarCambios);
            vista.btn_calcelar.Click += new EventHandler(Cancelar);
            vista.btn_borrar.Click +=new EventHandler(EliminarAlumna);
            vista.txt_idAlumna.KeyPress += new KeyPressEventHandler(IdAlumnaKeyPress);
            vista.txt_nie.KeyPress += new KeyPressEventHandler(NieKeyPress);
            vista.txt_nombres.KeyPress += new KeyPressEventHandler(NombresKeyPress);
            vista.txt_apelidos.KeyPress += new KeyPressEventHandler(ApellidosKeyPress);
            vista.txt_anioIngreso.KeyPress += new KeyPressEventHandler(AnioIngresoKeyPress);
            vista.txt_anioEgreso.KeyPress += new KeyPressEventHandler(AnioEgresoKeyPress);
            vista.txt_nombrePadre.KeyPress += new KeyPressEventHandler(NombrePadreKeyPress);
            vista.txt_nombreMadre.KeyPress += new KeyPressEventHandler(NombreMadreKeyPress);
        }
        private void LlenarCampos(object sender, EventArgs e)
        {
            LugaresNacimientoDao departamentos = new LugaresNacimientoDao();
            vista.cmb_LugarNacimiento.DataSource = departamentos.ListaDepartamentos();
            vista.cmb_LugarNacimiento.DisplayMember = "NombreDepartamento";
            vista.cmb_LugarNacimiento.ValueMember = "IdLugarNacimiento";

            //Se le asigna valores de la base de datos a los controladores
            DataTable alumna = alumnaDao.VerAlumnaSeleccionada(alumnaSeleccionada);
            vista.txt_idAlumna.Text = alumna.Rows[0][0].ToString();
            vista.txt_nie.Text = alumna.Rows[0][3].ToString();
            vista.txt_nombres.Text = alumna.Rows[0][1].ToString();
            vista.txt_apelidos.Text = alumna.Rows[0][2].ToString();
            vista.txt_anioIngreso.Text = alumna.Rows[0][4].ToString();
            vista.txt_anioEgreso.Text = alumna.Rows[0][5].ToString();
            vista.dtp_nacimiento.Value= (DateTime)alumna.Rows[0][6];
            vista.cmb_LugarNacimiento.SelectedValue = alumna.Rows[0][7];
            vista.txt_nombrePadre.Text = alumna.Rows[0][8].ToString();
            vista.txt_nombreMadre.Text = alumna.Rows[0][9].ToString();
        }
        private void EliminarAlumna(object sender, EventArgs e)
        {
            if (MessageBox.Show("Se eliminará la alumna: " + alumnaSeleccionada + "\n¿Desea continuar?",
                                     "Eliminar Alumna",
                                     MessageBoxButtons.YesNo,
                                     MessageBoxIcon.Information) == DialogResult.Yes)
            {
                try
                {
                    alumnaDao.EliminarAlumna(alumnaSeleccionada);
                    MessageBox.Show("Se elimió la alumna con éxito");
                    UsuarioView usuario = new UsuarioView();
                    vista.Hide();
                    usuario.ShowDialog();
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
            if (CamposVacios())
            {
                if (MessageBox.Show("Se guardarán los cambios en la alumna: " + alumnaSeleccionada + "\n¿Desea continuar?",
                                       "Guardar cambios",
                                       MessageBoxButtons.YesNo,
                                       MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    try
                    {
                        AlumnaDao nuevaAlumna = new AlumnaDao();
                        //Crea un registro en la base de datos mediante AlumnaDao
                        nuevaAlumna.EditarAlumna(vista.txt_idAlumna.Text,
                                    vista.txt_nombres.Text,
                                    vista.txt_apelidos.Text,
                                    int.Parse(vista.txt_nie.Text),
                                    int.Parse(vista.txt_anioIngreso.Text),
                                    int.Parse(vista.txt_anioEgreso.Text),
                                    vista.dtp_nacimiento.Value,
                                    (int)vista.cmb_LugarNacimiento.SelectedValue,
                                    vista.txt_nombrePadre.Text,
                                    vista.txt_nombreMadre.Text,
                                    alumnaSeleccionada);
                        MessageBox.Show("Los datos de la alumna fueron atualizados");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No se realizó con exito...\n" + ex,
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
            }
        }
        private bool CamposVacios()
        {
            bool validado = true;
            if (string.IsNullOrWhiteSpace(vista.txt_idAlumna.Text))
            {
                validado = false;
                vista.errorProvider1.SetError(vista.txt_idAlumna, "El campo no puede estar vacío");
            }
            else
            {
                vista.errorProvider1.SetError(vista.txt_idAlumna, "");
            }
            if (string.IsNullOrWhiteSpace(vista.txt_nie.Text))
            {
                validado = false;
                vista.errorProvider1.SetError(vista.txt_nie, "El campo no puede estar vacío");
            }
            else
            {
                vista.errorProvider1.SetError(vista.txt_nie, "");
            }
            if (string.IsNullOrWhiteSpace(vista.txt_nombres.Text))
            {
                validado = false;
                vista.errorProvider1.SetError(vista.txt_nombres, "El campo no puede estar vacío");
            }
            else
            {
                vista.errorProvider1.SetError(vista.txt_nombres, "");
            }
            if (string.IsNullOrWhiteSpace(vista.txt_apelidos.Text))
            {
                validado = false;
                vista.errorProvider1.SetError(vista.txt_apelidos, "El campo no puede estar vacío");
            }
            else
            {
                vista.errorProvider1.SetError(vista.txt_apelidos, "");
            }
            if (string.IsNullOrWhiteSpace(vista.txt_anioIngreso.Text))
            {
                validado = false;
                vista.errorProvider1.SetError(vista.txt_anioIngreso, "El campo no puede estar vacío");
            }
            else
            {
                vista.errorProvider1.SetError(vista.txt_anioIngreso, "");
            }
            if (string.IsNullOrWhiteSpace(vista.txt_anioEgreso.Text))
            {
                validado = false;
                vista.errorProvider1.SetError(vista.txt_anioEgreso, "El campo no puede estar vacío");
            }
            else if (int.Parse(vista.txt_anioEgreso.Text) < int.Parse(vista.txt_anioIngreso.Text))
            {
                validado = false;
                vista.errorProvider1.SetError(vista.txt_anioEgreso, "El año de egreso no puede ser menor que el de ingreso");
            }
            else
            {
                vista.errorProvider1.SetError(vista.txt_anioEgreso, "");
            }
            if (vista.dtp_nacimiento.Value >= DateTime.Now)
            {
                validado = false;
                vista.errorProvider1.SetError(vista.dtp_nacimiento, "La fecha debe ser menor a la actual");
            }
            else
            {
                vista.errorProvider1.SetError(vista.dtp_nacimiento, "");
            }
            if (string.IsNullOrWhiteSpace(vista.txt_nombrePadre.Text))
            {
                validado = false;
                vista.errorProvider1.SetError(vista.txt_nombrePadre, "El campo no puede estar vacío");
            }
            else
            {
                vista.errorProvider1.SetError(vista.txt_nombrePadre, "");
            }
            if (string.IsNullOrWhiteSpace(vista.txt_nombreMadre.Text))
            {
                validado = false;
                vista.errorProvider1.SetError(vista.txt_nombreMadre, "El campo no puede estar vacío");
            }
            else
            {
                vista.errorProvider1.SetError(vista.txt_nombreMadre, "");
            }
            return validado;
        }
        private void Cancelar(object sender, EventArgs e)
        {
            AlumnaView alumna = new AlumnaView();
            vista.Hide();
            alumna.ShowDialog();
            vista.Close();
        }
        protected void IdAlumnaKeyPress(object sender, KeyPressEventArgs e)
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
                vista.errorProvider1.SetError(vista.txt_idAlumna, "");
            }
            else
            {
                vista.errorProvider1.SetError(vista.txt_idAlumna, "Solo se admiten números y letras");
            }
        }
        private void NieKeyPress(object sender, KeyPressEventArgs e)
        {
            bool validado;
            //condicion para solo números
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
                validado = true;
            }
            else
            {
                e.Handled = true;
                validado = false;
            }
            if (validado)
            {
                vista.errorProvider1.SetError(vista.txt_nie, "");
            }
            else
            {
                vista.errorProvider1.SetError(vista.txt_nie, "Solo se admiten números");
            }
        }
        private void NombresKeyPress(object sender, KeyPressEventArgs e)
        {
            bool validado;
            //condicion para solo números
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
                validado = true;
            }
            //para backspace
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
                vista.errorProvider1.SetError(vista.txt_nombres, "");
            }
            else
            {
                vista.errorProvider1.SetError(vista.txt_nombres, "Solo se admiten números y letras");
            }
        }
        private void ApellidosKeyPress(object sender, KeyPressEventArgs e)
        {
            bool validado;
            //condicion para solo números
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
                validado = true;
            }
            //para backspace
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
                vista.errorProvider1.SetError(vista.txt_apelidos, "");
            }
            else
            {
                vista.errorProvider1.SetError(vista.txt_apelidos, "Solo se admiten números y letras");
            }
        }
        private void AnioIngresoKeyPress(object sender, KeyPressEventArgs e)
        {
            bool validado;
            //condicion para solo números
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
                validado = true;
            }
            else
            {
                e.Handled = true;
                validado = false;
            }
            if (validado)
            {
                vista.errorProvider1.SetError(vista.txt_anioIngreso, "");
            }
            else
            {
                vista.errorProvider1.SetError(vista.txt_anioIngreso, "Solo se admiten números");
            }
        }
        private void AnioEgresoKeyPress(object sender, KeyPressEventArgs e)
        {
            bool validado;
            //condicion para solo números
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
                validado = true;
            }
            else
            {
                e.Handled = true;
                validado = false;
            }
            if (validado)
            {
                vista.errorProvider1.SetError(vista.txt_anioEgreso, "");
            }
            else
            {
                vista.errorProvider1.SetError(vista.txt_anioEgreso, "Solo se admiten números");
            }
        }
        private void NombrePadreKeyPress(object sender, KeyPressEventArgs e)
        {
            bool validado;
            //condicion para solo números
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
                validado = true;
            }
            //para backspace
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
                vista.errorProvider1.SetError(vista.txt_nombrePadre, "");
            }
            else
            {
                vista.errorProvider1.SetError(vista.txt_nombrePadre, "Solo se admiten letras");
            }
        }
        private void NombreMadreKeyPress(object sender, KeyPressEventArgs e)
        {
            bool validado;
            //condicion para solo números
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
                validado = true;
            }
            //para backspace
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
                vista.errorProvider1.SetError(vista.txt_nombreMadre, "");
            }
            else
            {
                vista.errorProvider1.SetError(vista.txt_nombreMadre, "Solo se admiten letras");
            }
        }

    }
}
