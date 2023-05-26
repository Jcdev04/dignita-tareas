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
    public partial class AgregarTareas : Form
    {
        public AgregarTareas()
        {
            InitializeComponent();
            Desarrollador desarrollador = new Desarrollador();
            desarrollador.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Desarrollador nuevo = new Desarrollador();
            nuevo.ShowDialog();
            Desarrollador desarrollador = new Desarrollador();
            desarrollador.Close();
        }
    }
}
