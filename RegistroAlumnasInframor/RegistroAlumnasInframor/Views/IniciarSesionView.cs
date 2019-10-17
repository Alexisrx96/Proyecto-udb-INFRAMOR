using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RegistroAlumnasInframor.Controllers;

namespace RegistroAlumnasInframor.Views
{
    public partial class IniciarSesionView : Form
    {
        public IniciarSesionView()
        {
            InitializeComponent();
            IniciarSesionController ctrl = new IniciarSesionController(this);
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
                
        }
        private void Txt_NomUsuario_Leave(object sender, EventArgs e)
        {
            if (txt_NomUsuario.Text == "") { 


            txt_NomUsuario.Text = "USUARIO";
                txt_NomUsuario.ForeColor = Color.AliceBlue;
            }
        }

        private void Txt_NomUsuario_Enter(object sender, EventArgs e)
        {
            if (txt_NomUsuario.Text == "USUARIO")
            {

                txt_NomUsuario.Text = "";
                txt_NomUsuario.ForeColor = Color.DarkBlue;
            }
        }

        private void Txt_Contrasenia_Enter(object sender, EventArgs e)
        {
            if (txt_Contrasenia.Text == "CONTRASEÑA")
            {

                txt_Contrasenia.Text = "";
                txt_Contrasenia.ForeColor = Color.DarkBlue;
                txt_Contrasenia.UseSystemPasswordChar = true;
            }

        }

        private void Txt_Contrasenia_Leave(object sender, EventArgs e)
        {
            if (txt_Contrasenia.Text == "")
            {


                txt_Contrasenia.Text = "CONTRASEÑA";
                txt_Contrasenia.ForeColor = Color.AliceBlue;
                txt_Contrasenia.UseSystemPasswordChar = false;
            }
        }
    }
}
