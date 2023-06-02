using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dignita.Gestion_de_proyectos.vistDesarrollador
{
    public partial class Realizar_Tareas : Form
    {
        public Realizar_Tareas()
        {
            InitializeComponent();
        }

        private void btnTareas_Click(object sender, EventArgs e)
        {
            Tareas obj = new Tareas();
            obj.Show();
        }

        private void btnRequerimientos_Click(object sender, EventArgs e)
        {
            Requerimientos obj = new Requerimientos();
            obj.Show();
        }

        private void btnProyecto_Click(object sender, EventArgs e)
        {
            Proyecto obj = new Proyecto();    
            obj.Show();
        }

        private void btnMejoras_Click(object sender, EventArgs e)
        {
            Mejoras obj = new Mejoras();
            obj.Show();
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            Historial historial = new Historial();
            historial.Show();
        }
    }
}
