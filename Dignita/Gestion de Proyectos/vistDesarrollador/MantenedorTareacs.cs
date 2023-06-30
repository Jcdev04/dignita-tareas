using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogica;
using CapaEntidad;

using System.Drawing.Drawing2D;

namespace Dignita.Gestion_de_Proyectos.vistDesarrollador
{
    public partial class MantenedorTareacs : Form
    {
        string DNI = "";

        public MantenedorTareacs(string dni)
        {
            InitializeComponent();
            habilitarInputs(false);
            llenarDatosCmbEstadoTarea();
            DNI = dni;
            listarTareas(dni);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            habilitarInputs(true);
        }

        private void btnDetalles_Click(object sender, EventArgs e)
        {
            
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                entTarea t = new entTarea();
                t.id_tarea = int.Parse(dgvTareas.CurrentRow.Cells[0].Value.ToString());
                t.estado_tarea = int.Parse(cmbEstado.SelectedValue.ToString());

                logTareaEstado.Instancia.modificaEstadoTarea(t);
                habilitarInputs(false);
                txtDetallesTarea.Text = "";
                cmbEstado.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }

            habilitarInputs(false);
            listarTareas(DNI);
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            habilitarInputs(false);
        }


        private void habilitarInputs(bool habilitar)
        {
            gbxInputs.Enabled = habilitar;
            btnModificar.Enabled = !habilitar;
        }

        // Lenar combo ciudad
        public void llenarDatosCmbEstadoTarea()
        {
            cmbEstado.DataSource = logTareaEstado.Instancia.ListarEstadoTarea();
            cmbEstado.DisplayMember = "nombre";
            cmbEstado.ValueMember = "id_estado";
        }


        // DGV
        private void dgvTareas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvTareas.Rows[e.RowIndex];// 
            cmbEstado.SelectedIndex = int.Parse(filaActual.Cells[5].Value.ToString());
        }

        // Listar
        public void listarTareas(string DNI)
        {
            dgvTareas.DataSource = logTarea.Instancia.listarTareasDesarrollador(DNI);
        }

        private void MantenedorTareacs_Paint(object sender, PaintEventArgs e)
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

            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.FlatAppearance.BorderColor = naranja;
            btnAceptar.FlatAppearance.BorderSize = 1;

            btnCancelar.FlatAppearance.BorderColor = naranja;
            btnCancelar.ForeColor = naranja;
        }
    }
}
