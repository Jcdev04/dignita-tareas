using CapaEntidad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dignita.Ventas.vistVentas
{
    public partial class RealizaContrato : Form
    {
        entContrato contrato = null;
        public RealizaContrato()
        {
            InitializeComponent();
            listarEmpresa();
            // Create a new DateTimePicker control and initialize it
            this.dtpDuracion.MinDate = DateTime.Today;
        }


        //Auxiliar
        private void listarEmpresa()
        {
            dgvEmpresa.DataSource = CapaLogica.logEmpresa.Instancia.Empresas();
        }

        private void enableInputs(bool estado)
        {
            gbxContrato.Enabled = estado;
            btnAceptar.Enabled = !estado;
            btnActualiza.Enabled = !estado;
            btnSiguiente.Enabled = !estado;
        }

        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            MantenedorEmpresa me = new MantenedorEmpresa();
            me.ShowDialog();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                MessageBox.Show("Los campos no deben estar vacíos");
                return;
            }
            try
            {
                float precio = float.Parse(txtCosto.Text);
                contrato = new entContrato();
                btnSiguiente.Enabled = true;
                contrato.costo = precio;
                contrato.fecha_inicio = DateTime.Now;
                contrato.fecha_fin = dtpDuracion.Value;
                MessageBox.Show($"El costo de contrato será {precio} iniciará {contrato.fecha_inicio} y finalizará {contrato.fecha_fin}. Por favor, continué para hacer efectivo el contrato");
            }catch(Exception ex)
            {
                MessageBox.Show("El costo debe ser un número");
                return;
            }
        }
        private bool validar()
        {
            return txtCosto.Text == "";
        }
        private void limpiar()
        {
            dtpDuracion.Value = DateTime.Today;
            txtCosto.Text = "";
        }

        private void btnSiguiente_Click_1(object sender, EventArgs e)
        {
            if (dgvEmpresa.CurrentCell.RowIndex == -1)
            {
                MessageBox.Show("Selecciones una fila");
                return;
            }
            if (contrato == null)
            { 
                MessageBox.Show("Debe registrar el contrato previo");
                return;
            }

            contrato.ruc_emp = dgvEmpresa.Rows[dgvEmpresa.CurrentCell.RowIndex].Cells[0].Value.ToString();
            string nombreEmpresa = dgvEmpresa.Rows[dgvEmpresa.CurrentCell.RowIndex].Cells[1].Value.ToString();
            MantenedorProyecto mp = new MantenedorProyecto(contrato, nombreEmpresa);
            mp.ShowDialog();
        }

        private void dgvEmpresa_SelectionChanged(object sender, EventArgs e)
        {
            lblNombreEmpresa.Text = dgvEmpresa.Rows[dgvEmpresa.CurrentCell.RowIndex].Cells[1].Value.ToString();
        }

        private void btnActualiza_Click(object sender, EventArgs e)
        {
            listarEmpresa();
        }
    }
}
