using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogica;
using CapaEntidad;

namespace Dignita.Gestion_de_Proyectos.vistDesarrollador
{
    public partial class MantenedorTareacs : Form
    {
        string DNI = "";

        public MantenedorTareacs(string dni)
        {
            InitializeComponent();
            habilitarInputs(false);
            llenarDatosCmbEstadoTarea();
            DNI = dni;
            listarTareas(dni);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            habilitarInputs(true);
        }

        private void btnDetalles_Click(object sender, EventArgs e)
        {
            
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                entTarea t = new entTarea();
                t.estado_tarea = int.Parse(cmbEstado.SelectedValue.ToString());

                logTareaEstado.Instancia.modificaEstadoTarea(t);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }

            habilitarInputs(false);
            listarTareas(DNI);
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            habilitarInputs(false);
        }


        private void habilitarInputs(bool habilitar)
        {
            /*gbxInputs.enabled = habilitar
             
             */

            btnModificar.Enabled = !habilitar;
        }

        // Lenar combo ciudad
        public void llenarDatosCmbEstadoTarea()
        {
            cmbEstado.DataSource = logTareaEstado.Instancia.ListarEstadoTarea();
            cmbEstado.DisplayMember = "nombre";
            cmbEstado.ValueMember = "id_estado";
        }


        // DGV
        private void dgvTareas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvTareas.Rows[e.RowIndex];// 
            cmbEstado.SelectedIndex = int.Parse(filaActual.Cells[5].Value.ToString());
        }

        // Listar
        public void listarTareas(string DNI)
        {
            dgvTareas.DataSource = logTarea.Instancia.listarTareasDesarrollador(DNI);
        }

    }
}
