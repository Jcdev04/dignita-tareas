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
    public partial class MantenedorVersiones : Form
    {
        entProyecto p = null;
        public MantenedorVersiones(entProyecto proy)
        {
            InitializeComponent();
            this.p = proy;
            listarVersiones();
            gbxVersiones.Enabled = false;
        }

       public void listarVersiones()
        {
            dgvVersiones.DataSource = logVersion.Instancia.listarVersion(p.id_proy);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            enableInputs(true);
            limpiar();
        }

        private void enableInputs(bool estado)
        {
            btnAgregar.Enabled = !estado;
            gbxVersiones.Enabled = estado;
        }

        private void limpiar()
        {
            txtDescripcion.Text = "";
            txtNombre.Text = "";
        }

        private bool validar()
        {
            return txtNombre.Text != "" && txtDescripcion.Text != "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!validar())
            {
                MessageBox.Show("Los campos no deberían estar vacíos");
                return;
            }
            entVersion v = new entVersion();
            v.id_proy = p.id_proy;
            v.nombre_version = txtNombre.Text;
            v.descripcion = txtDescripcion.Text;
            MessageBox.Show(v.id_proy + "");
            logVersion.Instancia.insertarVersion(v);
            enableInputs(false);
            limpiar();
            listarVersiones();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            limpiar();
            enableInputs(false);
        }

        private void MantenedorVersiones_Paint(object sender, PaintEventArgs e)
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

            button2.FlatStyle = FlatStyle.Flat;
            button2.FlatAppearance.BorderColor = naranja;
            button2.FlatAppearance.BorderSize = 1;

            button1.FlatAppearance.BorderColor = naranja;
            button1.ForeColor = naranja;

            label2.ForeColor = naranja;
        }
    }
}
