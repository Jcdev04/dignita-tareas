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
    public partial class MantenedorTarea : Form
    {
        string accion = "";
        int id_req;
        public MantenedorTarea(int id_req)
        {
            InitializeComponent();
            this.id_req = id_req;
            listarTareas(id_req);
            ListarEtapaTarea();
            enableInputs(false);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            accion = "insertar";
            enableInputs(true);
            listarTareas(id_req); 
            limpiar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            accion = "modificar";
            if (dtgvTareas.CurrentCell.RowIndex != -1)
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
            if (dtgvTareas.CurrentCell.RowIndex != -1)
            {
                entTarea ta = new entTarea();
                ta.id_tarea = Int32.Parse(dtgvTareas.Rows[dtgvTareas.CurrentCell.RowIndex].Cells[0].Value.ToString());
                logTarea.Instancia.inhabilitarTarea(ta);
                listarTareas(id_req);
                limpiar();
            }
            else
            {
                MessageBox.Show("Seleccione una fila");
            }
        }

        //Auxiliar
        public void enableInputs(bool estado)
        {
            gbxTarea.Enabled = estado;
            btnAgregar.Enabled = !estado;
            btnModificar.Enabled = !estado;
            btnDeshabilitar.Enabled = !estado;
        }
        
        public void limpiar()
        {
            txtNombreTarea.Text = "";
            txtDescripcionTarea.Text = "";
        }

        public bool validar()
        {
            return txtDescripcionTarea.Text != "" && txtNombreTarea.Text != "";
        }

        private void listarTareas(int id_req)
        {
            dtgvTareas.DataSource = logTarea.Instancia.ListarTareas(id_req);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (!validar())
            {
                MessageBox.Show("Los campos no deberían estar vacíos");
                return;
            }
            entTarea ta = new entTarea();
            ta.id_req = id_req;
            ta.id_etapa = Convert.ToInt32(cbxEtapa.SelectedValue);
            ta.nombre_t = txtNombreTarea.Text;
            ta.descripcion = txtDescripcionTarea.Text;
            if (accion == "insertar")
            {
                logTarea.Instancia.insertaTarea(ta);
            }
            else if (accion == "modificar")
            {
                ta.id_tarea = Int32.Parse(dtgvTareas.Rows[dtgvTareas.CurrentCell.RowIndex].Cells[0].Value.ToString());
                logTarea.Instancia.editarTarea(ta);
            }
            listarTareas(id_req);
            enableInputs(false);
            limpiar();
        }

        private void dtgvTareas_SelectionChanged(object sender, EventArgs e)
        {
            txtNombreTarea.Text = dtgvTareas.Rows[dtgvTareas.CurrentCell.RowIndex].Cells[3].Value.ToString();
            txtDescripcionTarea.Text = dtgvTareas.Rows[dtgvTareas.CurrentCell.RowIndex].Cells[4].Value.ToString();
        }

        private void ListarEtapaTarea()
        {
            cbxEtapa.DataSource = logEtapaTarea.Instancia.ListarEtapaTarea();
            cbxEtapa.DisplayMember = "nombre";
            cbxEtapa.ValueMember = "id_etapa";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiar();
            enableInputs(false);
        }
    }
}
