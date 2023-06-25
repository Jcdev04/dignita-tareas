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
    public partial class PrincipalVentas : Form
    {
        public PrincipalVentas()
        {
            InitializeComponent();
        }

        private void btnRealizarContrato_Click(object sender, EventArgs e)
        {
            RealizaContrato contrato = new RealizaContrato();
            contrato.Show();
        }
    }
}
