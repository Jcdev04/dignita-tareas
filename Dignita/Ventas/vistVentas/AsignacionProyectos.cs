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
    public partial class AsignacionProyectos : Form
    {
        public AsignacionProyectos()
        {
            InitializeComponent();
            listarProyectosContratados();
        }

        public void btnAsignación_Click(object sender, EventArgs e)
        {
            int indice = dgvProyectos.CurrentCell.RowIndex;
            if (indice != -1)
            {
                int id_proy = Convert.ToInt32(dgvProyectos.Rows[indice].Cells[0].Value.ToString());

                RealizaAsignacion asignacion = new RealizaAsignacion(id_proy);
                asignacion.Show();
            }
            else
            {
                MessageBox.Show("Seleccione una fila");
            }

        }
        public void listarProyectosContratados()
        {
            dgvProyectos.DataSource = logProyecto.Instancia.listarProyectosContratados();
        }

        private void dgvProyectos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
