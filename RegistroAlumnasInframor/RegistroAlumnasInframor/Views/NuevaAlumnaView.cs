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
    public partial class NuevaAlumnaView : Form
    {
        public NuevaAlumnaView()
        {
            InitializeComponent();
            NuevaAlumnaController ctrl = new NuevaAlumnaController(this);
        }
    }
}
