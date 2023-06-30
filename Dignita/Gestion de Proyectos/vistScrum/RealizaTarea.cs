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
    public partial class RealizaTarea : Form
    {

        int id_proy;
        public RealizaTarea(int id_proy)
        {
            InitializeComponent();
            this.id_proy = id_proy;
            listarTareas();
        }

        public void listarTareas()
        {
            dtgvTareas.DataSource =  logTarea.Instancia.listarTareasProy(id_proy);
        }

        private void btnRegistrarTarea_Click_1(object sender, EventArgs e)
        {
            if (dtgvTareas.CurrentCell.RowIndex != -1) {

                entRegistroTarea rt = new entRegistroTarea();
                int id_tarea= Int32.Parse(dtgvTareas.Rows[dtgvTareas.CurrentCell.RowIndex].Cells[0].Value.ToString());
                rt.id_tarea = id_tarea;
                rt.fecha_inicio = DateTime.Now;
                rt.fecha_fin = dtpDuracion.Value;
                logRegistroTarea.Instancia.RegistrarTarea(rt);
                logTarea.Instancia.modificaRegistrarTarea(rt.id_tarea);
                listarTareas();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila");
            }
        }

        private void btnDesarrolladores_Click(object sender, EventArgs e)
        {
            if (dtgvTareas.CurrentCell.RowIndex != -1)
            {
                int id_tarea = Int32.Parse(dtgvTareas.Rows[dtgvTareas.CurrentCell.RowIndex].Cells[0].Value.ToString());
                RealizaAsignacionTarea_cs ra = new RealizaAsignacionTarea_cs(id_tarea, id_proy);
                ra.ShowDialog();
            }
            else
            {
                MessageBox.Show("Selecciona una fila");
            }
         }

        private void RealizaTarea_Paint(object sender, PaintEventArgs e)
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

            label3.ForeColor = naranja;
        }

        private void btnRevision_Click(object sender, EventArgs e)
        {
            if (dtgvTareas.CurrentCell.RowIndex != -1)
            {

                entRegistroTarea rt = new entRegistroTarea();
                int id_tarea = Int32.Parse(dtgvTareas.Rows[dtgvTareas.CurrentCell.RowIndex].Cells[0].Value.ToString());
                
                logTarea.Instancia.modificaRegistrarTarea(id_tarea);
                listarTareas();
                RealizaRevisionTarea revtar = new RealizaRevisionTarea(id_tarea);
                revtar.ShowDialog();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila");
            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            listarTareasRegistrada();
        }

        public void listarTareasRegistrada()
        {
            dtgvTareas.DataSource = logTarea.Instancia.listarTareasProyRegistradas(id_proy);
        }

        private void btnQuitarFiltro_Click(object sender, EventArgs e)
        {
            listarTareas();
        }
    }
}
