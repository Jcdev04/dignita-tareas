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
            obj.ShowDialog();
        }

        private void btnRequerimientos_Click(object sender, EventArgs e)
        {
            Requerimientos obj = new Requerimientos();
            obj.ShowDialog();
        }
    }
}
