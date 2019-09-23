using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RegistroAlumnasInframor.Models.Dao;
using RegistroAlumnasInframor.Models.Dto;
using RegistroAlumnasInframor.Views;

namespace RegistroAlumnasInframor.Controllers
{
    class UsuarioController
    {
        UsuarioView vista;
        //Constructorr
        public UsuarioController(UsuarioView view)
        {
            vista = view;
            //Inicializar eventos
            vista.Load += new EventHandler(UsuarioList);
            vista.btn_buscar.Click += new EventHandler(CrearUsuario);
            vista.txt_buscar.TextChanged += new EventHandler(UsuarioList);
        }
        private void UsuarioList(object sender, EventArgs e)
        {
            UsuarioDao db = new UsuarioDao();
            vista.dgv_tablaUsuarios.DataSource =
                db.VerRegistros(vista.txt_buscar.Text);
        }
        private void CrearUsuario(object sender, EventArgs e)
        {
            CrearUsuarioController crear = new CrearUsuarioController(new CrearUsuarioView());
            crear.Mostrar();
            
        }
        public void Mostrar()
        {
            vista.ShowDialog();
        }
    }
}
