using Dignita.formsDesarrollador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dignita
{
    public partial class Desarrollador : Form
    {
        public Desarrollador()
        {
            InitializeComponent();
            button1.Enabled = false;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AgregarTareas nuevo = new AgregarTareas();
            nuevo.ShowDialog();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Proyecto nuevo = new Proyecto();
            nuevo.ShowDialog(); 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Mejoras nuevo = new Mejoras();
            nuevo.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Historial nuevo = new Historial();
            nuevo.ShowDialog();
        }
    }
}
