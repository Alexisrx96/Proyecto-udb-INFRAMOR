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
    }
}
