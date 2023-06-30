using CapaEntidad;
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
using System.Drawing.Drawing2D;

namespace Dignita.Ventas.vistVentas
{
    public partial class MantenedorEmpresa : Form
    {
        string accion = "";
        public MantenedorEmpresa()
        {
            InitializeComponent();
            listarEmpresa();
            enableInputs(false);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            txtRUC.Enabled = true;
            accion = "agregar";
            enableInputs(true);
            limpiar();
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            accion = "modificar";
            txtRUC.Enabled = false;
            if (dgvEmpresa.CurrentCell.RowIndex!=-1)
            {
                enableInputs(true);
            }
            else
            {
                MessageBox.Show("Seleccione una fila");
            }
            obtenerDatos();
        }
        private void btnDeshabilitar_Click_1(object sender, EventArgs e)
        {
            if (dgvEmpresa.CurrentCell.RowIndex != -1)
            {
                entEmpresa empresa = new entEmpresa();
                empresa.RUC = dgvEmpresa.Rows[dgvEmpresa.CurrentCell.RowIndex].Cells[0].Value.ToString();
                logEmpresa.Instancia.InhabilitarEmpresa(empresa);
                listarEmpresa();
            }
            else
            {
                MessageBox.Show("Seleccione una fila");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!validar())
            {
                MessageBox.Show("Los campos no deben estar vacíos");
                return;
            }
            if (accion == "agregar")
            {
                entEmpresa empresa = new entEmpresa();
                empresa.RUC = txtRUC.Text;
                empresa.razon_social = txtRazonSocial.Text;
                empresa.direccion = txtDireccion.Text;
                empresa.telefono = txtTelefono.Text;
                empresa.correo = txtCorreo.Text;
                empresa.rubro = txtRubro.Text;
                logEmpresa.Instancia.AgregarEmpresa(empresa);
                listarEmpresa();
            }
            else if (accion == "modificar")
            {
                entEmpresa empresa = new entEmpresa();
                empresa.RUC = txtRUC.Text;
                empresa.razon_social = txtRazonSocial.Text;
                empresa.direccion = txtDireccion.Text;
                empresa.telefono = txtTelefono.Text;
                empresa.correo = txtCorreo.Text;
                empresa.rubro = txtRubro.Text;
                logEmpresa.Instancia.ModificarEmpresa(empresa);
                listarEmpresa();
            }
            limpiar();
            enableInputs(false);
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiar();
            enableInputs(false);
        }
        

        //AUXILIAR 
        private void limpiar()
        {
            txtRUC.Text = "";
            txtRazonSocial.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            txtCorreo.Text = "";
            txtRubro.Text = "";
        }
        private bool validar()
        {
            return txtRUC.Text!="" && txtRazonSocial.Text!="" && txtDireccion.Text!="" && txtTelefono.Text!="" && txtCorreo.Text!="" && txtRubro.Text!="";
        }
        private void listarEmpresa()
        {
              dgvEmpresa.DataSource = CapaLogica.logEmpresa.Instancia.Empresas();
        }
        private void enableInputs(bool habilitar)
        {
            gbxEmp.Enabled= habilitar;
            btnAgregar.Enabled = !habilitar;
            btnModificar.Enabled = !habilitar;
            btnDeshabilitar.Enabled = !habilitar;
        }
        private void dgvEmpresa_SelectionChanged(object sender, EventArgs e)
        {
            obtenerDatos();
        }
        private void obtenerDatos()
        {
            txtCorreo.Text = dgvEmpresa.CurrentRow.Cells[5].Value.ToString();
            txtDireccion.Text = dgvEmpresa.CurrentRow.Cells[3].Value.ToString();
            txtRazonSocial.Text = dgvEmpresa.CurrentRow.Cells[1].Value.ToString();
            txtRUC.Text = dgvEmpresa.CurrentRow.Cells[0].Value.ToString();
            txtRubro.Text = dgvEmpresa.CurrentRow.Cells[2].Value.ToString();
            txtTelefono.Text = dgvEmpresa.CurrentRow.Cells[4].Value.ToString();
        }

        private void MantenedorEmpresa_Paint(object sender, PaintEventArgs e)
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
            btnCancelar.FlatAppearance.BorderColor= naranja;
            btnCancelar.ForeColor = naranja;
            label11.ForeColor = naranja;
        }
    }
}
