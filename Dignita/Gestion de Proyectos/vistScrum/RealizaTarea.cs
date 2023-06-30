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
    }
}
