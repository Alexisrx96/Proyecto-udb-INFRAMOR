﻿using System;
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
    public partial class MenuView : Form
    {
        public MenuView()
        {
            InitializeComponent();
            MenuController ctrl = new MenuController(this);
            
        }

    }
}
