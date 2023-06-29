using CapaEntidad;
using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dignita.Ventas.vistVentas
{
    public partial class MantenedorProyecto : Form
    {
        entContrato ec = null; 
        string action = "";
        public MantenedorProyecto(entContrato ep, string nombreEmpresa)
        {
            InitializeComponent();
            ec = ep;
            lblNombreEmpresa.Text = nombreEmpresa;
            lblCostoProyecto.Text = ep.costo.ToString();
            lblFechaFinalizacion.Text = ep.fecha_fin.ToString();

            listarProyecto();
            enableInputs(false);
            ListarTipoProyecto();
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            action = "agregar";
            enableInputs(true);
            limpiar();
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            action = "modificar";
            if (dgvProyecto.CurrentCell.RowIndex != -1)
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
            if (dgvProyecto.CurrentCell.RowIndex != -1)
            {
                logProyecto.Instancia.inhabilitarProyecto(new entProyecto
                {
                    id_proy = Int32.Parse(dgvProyecto.Rows[dgvProyecto.CurrentCell.RowIndex].Cells[0].Value.ToString())
                });
                listarProyecto();
            }
            else
            {
                MessageBox.Show("Seleccione una fila");
            }
        }
        //ACEPTAR Y CANCELAR
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiar();
            enableInputs(false);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (!validar())
            {
                MessageBox.Show("Los campos no debería estar vacíos");
                return;
            }
            entProyecto ep = new entProyecto();
            ep.tipo_proy = Convert.ToInt32(cbxRubro.SelectedValue);
            ep.nombre_proy = txtNombreProy.Text;
            ep.descripcion = txtDescripcion.Text;
            if (action == "agregar")
            {
                logProyecto.Instancia.agregarProyecto(ep);
            }
            else if (action == "modificar")
            {
                ep.id_proy = Int32.Parse(dgvProyecto.Rows[dgvProyecto.CurrentCell.RowIndex].Cells[0].Value.ToString());
                logProyecto.Instancia.editarProyecto(ep);
            }
            listarProyecto();
            enableInputs(false);
            limpiar();
        }
        private void dgvProyecto_SelectionChanged(object sender, EventArgs e)
        {
            txtDescripcion.Text = dgvProyecto.Rows[dgvProyecto.CurrentCell.RowIndex].Cells[3].Value.ToString();
            txtNombreProy.Text = dgvProyecto.Rows[dgvProyecto.CurrentCell.RowIndex].Cells[2].Value.ToString();
            cbxRubro.SelectedItem = dgvProyecto.Rows[dgvProyecto.CurrentCell.RowIndex].Cells[1].Value.ToString();
        }

        private void btnGenerarContrato_Click(object sender, EventArgs e)
        {
            if (dgvProyecto.CurrentCell.RowIndex != -1)
            {
                entProyecto ep = new entProyecto();
                ep.id_proy = Int32.Parse(dgvProyecto.Rows[dgvProyecto.CurrentCell.RowIndex].Cells[0].Value.ToString());
                logProyecto.Instancia.editarProyecto(ep);
                ec.id_proyecto = ep.id_proy;
                logContrato.Instancia.agregarContrato(ec);
                logProyecto.Instancia.contratarProyecto(ep);
                listarProyecto();
                MessageBox.Show("Contrato generado");
               

            }
            else
            {
                MessageBox.Show("Seleccione una fila");
            }
        }

        //AUXILIARES
        private void enableInputs(bool estado)
        {
            gbxProy.Enabled = estado;
            btnAgregar.Enabled = !estado;
            btnModificar.Enabled = !estado;
            btnDeshabilitar.Enabled = !estado;
        }
        private void limpiar()
        {
            txtNombreProy.Text = "";
            cbxRubro.Text = "";
            txtDescripcion.Text = "";
        }
        private bool validar()
        {
            return cbxRubro.Text != "" && txtNombreProy.Text != "" && txtDescripcion.Text != "";
        }
        private void ListarTipoProyecto()
        {
            cbxRubro.DataSource = logTipoProyecto.Instancia.listarTipoProyecto();
            cbxRubro.DisplayMember = "nombre";
            cbxRubro.ValueMember = "id_tipo_proy";
        }
        public void listarProyecto()
        {
            dgvProyecto.DataSource = logProyecto.Instancia.listarProyectos();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {

        }
    }
}
