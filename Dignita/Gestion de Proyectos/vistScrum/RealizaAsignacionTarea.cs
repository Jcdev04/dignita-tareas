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
    public partial class RealizaAsignacionTarea_cs : Form
    {
        int id_tarea;
        int id_proy;
        public RealizaAsignacionTarea_cs(int id_tarea, int id_proy)
        {
            InitializeComponent();
            this.id_tarea = id_tarea;
            this.id_proy = id_proy;
            comboListar(); 
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {

        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {



        }




        private void comboListar()
        {
            List<entTrabajador> trabajadores = logAsignarTarea.Instancia.listarTrabajadoresDisponibles(id_proy);
            cbxDesarrollador.DataSource = trabajadores;
            cbxDesarrollador.DisplayMember = "nombre";
            cbxDesarrollador.ValueMember = "dni";

        }

        private void RealizaAsignacionTarea_cs_Paint(object sender, PaintEventArgs e)
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

            label1.ForeColor = naranja;
        }
    }
}
