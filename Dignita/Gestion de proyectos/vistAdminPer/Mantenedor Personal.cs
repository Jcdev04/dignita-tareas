﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dignita.Gestion_de_proyectos.vistAdminPer
{
    public partial class Mantenedor_Personal : Form
    {
        public Mantenedor_Personal()
        {
            InitializeComponent();
        }

        private void btnPersonal_Click(object sender, EventArgs e)
        {
            Personal obj = new Personal();
            obj.Show();
        }

        private void btnCargoEmpresa_Click(object sender, EventArgs e)
        {
            CargosEmpresa obj = new CargosEmpresa();
            obj.Show();
        }
    }
}
