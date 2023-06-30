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
using CapaLogica;

namespace Dignita.Gestion_de_Proyectos.vistScrum
{
    public partial class RealizaRevisionTarea : Form
    {
        int id_tarea;
        public RealizaRevisionTarea(int id_tarea)
        {
            InitializeComponent();
            this.id_tarea = id_tarea;
        }

        private void RealizaRevisionTarea_Paint(object sender, PaintEventArgs e)
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

            btnConfirmar.FlatStyle = FlatStyle.Flat;
            btnConfirmar.FlatAppearance.BorderColor = naranja;
            btnConfirmar.FlatAppearance.BorderSize = 1;

            label3.ForeColor = naranja;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            int estado_tarea = cbxEstadoTar.SelectedIndex;
            logTarea.Instancia.modificarEstado(id_tarea, estado_tarea);

         }
    }
}
