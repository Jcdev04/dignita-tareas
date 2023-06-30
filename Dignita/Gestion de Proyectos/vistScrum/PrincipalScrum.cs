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
using System.Drawing.Drawing2D;

namespace Dignita.Gestion_de_Proyectos.vistScrum
{
    public partial class PrincipalScrum : Form
    {
        string dni = "";
        public PrincipalScrum(string dni)
        {
            InitializeComponent();
            this.dni = dni;
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

        private void btnRegistrarTarea_Click(object sender, EventArgs e)
        {
            if (dgvProyectos.CurrentCell.RowIndex != -1)
            {
                int id_proy = int.Parse(dgvProyectos.Rows[dgvProyectos.CurrentCell.RowIndex].Cells[0].Value.ToString());
                RealizaTarea mr = new RealizaTarea(id_proy);
                mr.ShowDialog();
            }
            else
            {

            }
        }

        private void PrincipalScrum_Paint(object sender, PaintEventArgs e)
        {
            // Create a path that consists of a single circle.
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, ClientRectangle.Width, ClientRectangle.Height);

            // Use the path to construct a brush.
            PathGradientBrush brush = new PathGradientBrush(path);

            // Set the color at the center of the path to blue.
            brush.CenterColor = Color.FromArgb(103, 59, 46);

            // Set the color along the entire boundary 
            // of the path to aqua.
            Color[] colors = { Color.FromArgb(25, 25, 25) };
            brush.SurroundColors = colors;

            // Set the center point of the gradient.
            brush.CenterPoint = new PointF(ClientRectangle.Width / 2f, ClientRectangle.Height / 2f);

            // Set the focus scales of the gradient.
            brush.FocusScales = new PointF(0.10f, 0.10f);
            // Create a solid brush.
            Brush solidBrush = new SolidBrush(Color.FromArgb(25, 25, 25));
            e.Graphics.FillRectangle(solidBrush, ClientRectangle);
            // Fill the form with the gradient.
            e.Graphics.FillRectangle(brush, ClientRectangle);

            // Bordes a botones
            Color naranja = Color.FromArgb(255, 95, 44);

            btnRegistrarTarea.FlatStyle = FlatStyle.Flat;
            btnRegistrarTarea.FlatAppearance.BorderColor = naranja;
            btnRegistrarTarea.FlatAppearance.BorderSize = 1;

            label2.ForeColor = naranja;
        }
    }
}
