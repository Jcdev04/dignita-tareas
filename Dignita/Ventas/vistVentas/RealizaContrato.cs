using CapaEntidad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Dignita.Ventas.vistVentas
{
    public partial class RealizaContrato : Form
    {
        entContrato contrato = null;
        public RealizaContrato()
        {
            InitializeComponent();
            listarEmpresa();
            // Create a new DateTimePicker control and initialize it
            this.dtpDuracion.MinDate = DateTime.Today;
        }


        //Auxiliar
        private void listarEmpresa()
        {
            dgvEmpresa.DataSource = CapaLogica.logEmpresa.Instancia.Empresas();
        }

        private void enableInputs(bool estado)
        {
            gbxContrato.Enabled = estado;
            btnAceptar.Enabled = !estado;
            btnActualiza.Enabled = !estado;
            btnSiguiente.Enabled = !estado;
        }

        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            MantenedorEmpresa me = new MantenedorEmpresa();
            me.ShowDialog();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                MessageBox.Show("Los campos no deben estar vacíos");
                return;
            }
            try
            {
                float precio = float.Parse(txtCosto.Text);
                contrato = new entContrato();
                btnSiguiente.Enabled = true;
                contrato.costo = precio;
                contrato.fecha_inicio = DateTime.Now;
                contrato.fecha_fin = dtpDuracion.Value;
                MessageBox.Show($"El costo de contrato será {precio} iniciará {contrato.fecha_inicio} y finalizará {contrato.fecha_fin}. Por favor, continué para hacer efectivo el contrato");
            }catch(Exception ex)
            {
                MessageBox.Show("El costo debe ser un número");
                return;
            }
        }
        private bool validar()
        {
            return txtCosto.Text == "";
        }
        private void limpiar()
        {
            dtpDuracion.Value = DateTime.Today;
            txtCosto.Text = "";
        }

        private void btnSiguiente_Click_1(object sender, EventArgs e)
        {
            if (dgvEmpresa.CurrentCell.RowIndex == -1)
            {
                MessageBox.Show("Selecciona una fila");
                return;
            }
            if (contrato == null)
            { 
                MessageBox.Show("Debe registrar el contrato previo");
                return;
            }

            contrato.ruc_emp = dgvEmpresa.Rows[dgvEmpresa.CurrentCell.RowIndex].Cells[0].Value.ToString();
            string nombreEmpresa = dgvEmpresa.Rows[dgvEmpresa.CurrentCell.RowIndex].Cells[1].Value.ToString();
            MantenedorProyecto mp = new MantenedorProyecto(contrato, nombreEmpresa, contrato.ruc_emp);
            mp.ShowDialog();
        }

        private void dgvEmpresa_SelectionChanged(object sender, EventArgs e)
        {
            lblNombreEmpresa.Text = dgvEmpresa.Rows[dgvEmpresa.CurrentCell.RowIndex].Cells[1].Value.ToString();
        }

        private void btnActualiza_Click(object sender, EventArgs e)
        {
            listarEmpresa();
        }

        private void RealizaContrato_Paint(object sender, PaintEventArgs e)
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

            label5.ForeColor = naranja;
        }
    }
}
