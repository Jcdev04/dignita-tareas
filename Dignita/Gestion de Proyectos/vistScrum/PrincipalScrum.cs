using CapaEntidad;
using CapaLogica;
using Dignita.Ventas.vistVentas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dignita.Gestion_de_Proyectos.vistScrum
{
    public partial class PrincipalScrum : Form
    {
        string dni = "12345678";
        public PrincipalScrum()
        {
            InitializeComponent();
            listarProyecto();
        }

        public void listarProyecto()
        {
            dgvProyectos.DataSource = logProyecto.Instancia.listarProyectoScrum(dni);
        }

        private void btnVerVersiones_Click(object sender, EventArgs e)
        {
            if (dgvProyectos.CurrentCell.RowIndex == -1)
            {
                MessageBox.Show("Selecciona una fila");
                return;
            }
            entProyecto proyecto = new entProyecto();
            proyecto.id_proy = int.Parse(dgvProyectos.Rows[dgvProyectos.CurrentCell.RowIndex].Cells[0].Value.ToString());
            proyecto.tipo_proy = int.Parse(dgvProyectos.Rows[dgvProyectos.CurrentCell.RowIndex].Cells[1].Value.ToString());
            proyecto.nombre_proy = dgvProyectos.Rows[dgvProyectos.CurrentCell.RowIndex].Cells[2].Value.ToString();
            proyecto.descripcion = dgvProyectos.Rows[dgvProyectos.CurrentCell.RowIndex].Cells[3].Value.ToString();
            proyecto.estado = Boolean.Parse(dgvProyectos.Rows[dgvProyectos.CurrentCell.RowIndex].Cells[4].Value.ToString());
            proyecto.asignado = Boolean.Parse(dgvProyectos.Rows[dgvProyectos.CurrentCell.RowIndex].Cells[5].Value.ToString());
            proyecto.inhabilitado = Boolean.Parse(dgvProyectos.Rows[dgvProyectos.CurrentCell.RowIndex].Cells[6].Value.ToString());
            proyecto.contratado = Boolean.Parse(dgvProyectos.Rows[dgvProyectos.CurrentCell.RowIndex].Cells[7].Value.ToString());
            MantenedorVersiones mv = new MantenedorVersiones(proyecto);
            mv.ShowDialog();
        }

        private void btnVerRequerimientos_Click(object sender, EventArgs e)
        {
            if (dgvProyectos.CurrentCell.RowIndex == -1)
            {
                MessageBox.Show("Selecciona una fila");
                return;
            }
            entProyecto proyecto = new entProyecto();
            proyecto.id_proy = int.Parse(dgvProyectos.Rows[dgvProyectos.CurrentCell.RowIndex].Cells[0].Value.ToString());
            proyecto.tipo_proy = int.Parse(dgvProyectos.Rows[dgvProyectos.CurrentCell.RowIndex].Cells[1].Value.ToString());
            proyecto.nombre_proy = dgvProyectos.Rows[dgvProyectos.CurrentCell.RowIndex].Cells[2].Value.ToString();
            proyecto.descripcion = dgvProyectos.Rows[dgvProyectos.CurrentCell.RowIndex].Cells[3].Value.ToString();
            proyecto.estado = Boolean.Parse(dgvProyectos.Rows[dgvProyectos.CurrentCell.RowIndex].Cells[4].Value.ToString());
            proyecto.asignado = Boolean.Parse(dgvProyectos.Rows[dgvProyectos.CurrentCell.RowIndex].Cells[5].Value.ToString());
            proyecto.inhabilitado = Boolean.Parse(dgvProyectos.Rows[dgvProyectos.CurrentCell.RowIndex].Cells[6].Value.ToString());
            proyecto.contratado = Boolean.Parse(dgvProyectos.Rows[dgvProyectos.CurrentCell.RowIndex].Cells[7].Value.ToString());
            MantenedorRequerimiento mr = new MantenedorRequerimiento(proyecto);
            mr.ShowDialog();
        }
    }
}
