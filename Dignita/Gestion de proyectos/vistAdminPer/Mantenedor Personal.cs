using System;
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
            Form MantenedorPer = new Personal();
            MantenedorPer.Show();
        }

        private void btnRequerimientos_Click(object sender, EventArgs e)
        {
            Form MantenedorPer = new CargoEmpresa();
            MantenedorPer.Show();
        }
    }
}
