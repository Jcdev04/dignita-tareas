using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dignita.Gestion_de_proyectos.vistScrum
{
    public partial class MantenedorRequerimiento : Form
    {
        public MantenedorRequerimiento()
        {
            InitializeComponent();
            Placeholder.AddPlaceholderToComboBoxes(this);
            Placeholder.AddPlaceholderToTextBoxes(this);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
