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
    public partial class RealizaAsignacionTarea_cs : Form
    {
        int id_tarea;
        int id_proy;
        public RealizaAsignacionTarea_cs(int id_tarea, int id_proy)
        {
            InitializeComponent();
            this.id_tarea = id_tarea;
            this.id_proy = id_proy;
            comboListar(); 
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {

        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }
        private void comboListar()
        {
            List<entTrabajador> trabajadores = logAsignarTarea.Instancia.listarTrabajadoresDisponibles(id_proy);
            cbxDesarrollador.DataSource = trabajadores;
            cbxDesarrollador.DisplayMember = "apellido";
            cbxDesarrollador.ValueMember = "dni";

        }
    }
}
