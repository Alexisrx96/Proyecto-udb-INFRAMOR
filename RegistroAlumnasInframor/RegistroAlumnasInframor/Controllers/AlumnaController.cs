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
    class AlumnaController
    {
        AlumnaView vista;
        //Constructor
        public AlumnaController(AlumnaView view)
        {
            vista = view;
            //Inicializar eventos
            vista.Load += new EventHandler(AlumnaList);
            vista.btn_NuevaAlumna.Click += new EventHandler(NuevaAlumna);
            vista.txt_buscar.TextChanged += new EventHandler(AlumnaList);
            vista.dgv_tablaAlumnas.DoubleClick += new EventHandler(EditarUsuario);
            vista.txt_buscar.KeyPress += new KeyPressEventHandler(BuscarKeyPress);
            vista.btn_regresar.Click += new EventHandler(Regresar);
        }
        private void Regresar(object sender, EventArgs e)
        {
            MenuView menu = new MenuView();
            vista.Hide();
            menu.ShowDialog();
            vista.Close();
        }
        private void AlumnaList(object sender, EventArgs e)
        {
            AlumnaDao db = new AlumnaDao();
            vista.dgv_tablaAlumnas.DataSource =
                db.VerAlumnas(vista.txt_buscar.Text);
        }
        private void NuevaAlumna(object sender, EventArgs e)
        {
            NuevaAlumnaView crear = new NuevaAlumnaView();
            vista.Hide();
            crear.ShowDialog();
            vista.Close();
        }
        private void EditarUsuario(object sender, EventArgs e)
        {
            DataGridViewRow selected = vista.dgv_tablaAlumnas.SelectedRows[0];
            int indice = vista.dgv_tablaAlumnas.Rows.IndexOf(selected);
            AlumnaDao alumna = new AlumnaDao();
            string usuarioSeleccionado = alumna.AlumnaSeleccionada(indice,vista.txt_buscar.Text);
            ModificarAlumnaView modificarUsuario = new ModificarAlumnaView(usuarioSeleccionado);
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
