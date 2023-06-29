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
    public partial class RealizaAsignacion : Form
    {
        int id_proy;
        public RealizaAsignacion(int id_proy)
        {
            InitializeComponent();
            this.id_proy = id_proy;
            listarEquipos();
        }

        public void listarEquipos()
        {
            dgvEquipo.DataSource = logEquipo.Instancia.Equipos();
        }

         
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
            if (dgvEquipo.CurrentCell.RowIndex != -1)
            {
                entEquipo equipo = new entEquipo();
                equipo.id_equipo = Convert.ToInt32(dgvEquipo.Rows[dgvEquipo.CurrentCell.RowIndex].Cells[0].Value.ToString());
                equipo.id_proy = id_proy;
                logEquipo.Instancia.AgregarEquipo(equipo);
                listarEquipos();
                Close();
            }
            else
            {
                MessageBox.Show("Seleccione una fila");
            }
            
        }
    }
}
