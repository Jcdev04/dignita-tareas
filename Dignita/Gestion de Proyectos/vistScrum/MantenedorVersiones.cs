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

namespace Dignita.Ventas.vistVentas
{
    public partial class MantenedorVersiones : Form
    {
        entProyecto p = null;
        public MantenedorVersiones(entProyecto proy)
        {
            InitializeComponent();
            this.p = proy;
            listarVersiones();
            gbxVersiones.Enabled = false;
        }

       public void listarVersiones()
        {
            dgvVersiones.DataSource = logVersion.Instancia.listarVersion(p.id_proy);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            enableInputs(true);
            limpiar();
        }

        private void enableInputs(bool estado)
        {
            btnAgregar.Enabled = !estado;
            gbxVersiones.Enabled = estado;
        }

        private void limpiar()
        {
            txtDescripcion.Text = "";
            txtNombre.Text = "";
        }

        private bool validar()
        {
            return txtNombre.Text != "" && txtDescripcion.Text != "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!validar())
            {
                MessageBox.Show("Los campos no deberían estar vacíos");
                return;
            }
            entVersion v = new entVersion();
            v.id_proy = p.id_proy;
            v.nombre_version = txtNombre.Text;
            v.descripcion = txtDescripcion.Text;
            MessageBox.Show(v.id_proy + "");
            logVersion.Instancia.insertarVersion(v);
            enableInputs(false);
            limpiar();
            listarVersiones();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            limpiar();
            enableInputs(false);
        }
    }
}
