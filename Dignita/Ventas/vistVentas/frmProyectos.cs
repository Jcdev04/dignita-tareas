using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dignita.Ventas.vistVentas
{
    public partial class frmProyectos : Form
    {
        public frmProyectos()
        {
            InitializeComponent();
        }

        private void btnAsignación_Click(object sender, EventArgs e)
        {
           //pasar asignación de proyectos

        }
        public void listarProyectos()
        {
            dgvProyectos.DataSource = logProyecto.Instancia.listarProyectos();
        }

    }
}
