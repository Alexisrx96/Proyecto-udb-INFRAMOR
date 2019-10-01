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
    public partial class ModificarAlumnaView : Form
    {
        public ModificarAlumnaView(string usuario)
        {
            InitializeComponent();
            ModificarAlumnaController ctrl = new ModificarAlumnaController(this, usuario);
        }
    }
}
