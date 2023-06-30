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

namespace Dignita.Gestion_de_Proyectos.vistScrum
{
    public partial class MantenedorRequerimiento : Form
    {
        string accion = "";
        entProyecto proy = null;
        public MantenedorRequerimiento(entProyecto p)
        {
            InitializeComponent();
            this.proy = p;
            listarRequerimientos();
            gbxRequerimientos.Enabled = false;
        }
        private void listarRequerimientos()
        {
            dgvRequerimientos.DataSource = logRequerimiento.Instancia.listarRequerimientos(proy.id_proy);
        }



        public void enableInputs(bool estado)
        {
            gbxRequerimientos.Enabled = estado;
            btnAgregar.Enabled = !estado;
            btnModificar.Enabled = !estado;
            btnDeshabilitar.Enabled = !estado;
        }

        public void limpiar()
        {
            txtNombreReq.Text = "";
            txtDescripcionReq.Text = "";
        }

        public bool validar()
        {
            return txtDescripcionReq.Text != "" && txtNombreReq.Text != "";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            accion = "insertar";
            enableInputs(true);
            limpiar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            accion = "modificar";
            if (dgvRequerimientos.CurrentCell.RowIndex != -1)
            {
                enableInputs(true);
            }
            else
            {
                MessageBox.Show("Seleccione una fila");
            }
        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            if (dgvRequerimientos.CurrentCell.RowIndex != -1)
            {
                logRequerimiento.Instancia.inhabilitarRequerimiento(proy.id_proy);
                listarRequerimientos();
            }
            else
            {
                MessageBox.Show("Seleccione una fila");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiar();
            enableInputs(false);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (!validar())
            {
                MessageBox.Show("Los campos no deberían estar vacíos");
                return;
            }
            entRequerimiento req = new entRequerimiento();
            req.id_proy = proy.id_proy;
            req.nombre_req = txtNombreReq.Text;
            req.descripcion = txtDescripcionReq.Text;
            req.inhabilitado = false;
            if (accion == "insertar")
            {
                logRequerimiento.Instancia.insertarRequerimiento(req);
            }
            else if (accion == "modificar")
            {
                req.id_req = Int32.Parse(dgvRequerimientos.Rows[dgvRequerimientos.CurrentCell.RowIndex].Cells[0].Value.ToString());
                logRequerimiento.Instancia.editarRequerimiento(req);
            }
            listarRequerimientos();
            enableInputs(false);
            limpiar();
        }

        private void dgvRequerimientos_SelectionChanged(object sender, EventArgs e)
        {
            txtDescripcionReq.Text = dgvRequerimientos.Rows[dgvRequerimientos.CurrentCell.RowIndex].Cells[3].Value.ToString();
            txtNombreReq.Text = dgvRequerimientos.Rows[dgvRequerimientos.CurrentCell.RowIndex].Cells[2].Value.ToString();

        }

        private void btnVerTareas_Click(object sender, EventArgs e)
        {
            if (dgvRequerimientos.CurrentCell.RowIndex != -1)
            {
                int id_req = Int32.Parse(dgvRequerimientos.Rows[dgvRequerimientos.CurrentCell.RowIndex].Cells[0].Value.ToString());
                MantenedorTarea tarea = new MantenedorTarea(id_req);
                tarea.Show();
            }
            else
            {
                MessageBox.Show("Seleccione una fila");
            }
           
        }

        private void MantenedorRequerimiento_Paint(object sender, PaintEventArgs e)
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

            label2.ForeColor = naranja;
        }
    }
}
