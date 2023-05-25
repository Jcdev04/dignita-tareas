using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;
using System.Drawing;

namespace Dignita
{
    public partial class frm_login : Form
    {
        // Tipografias
        private PrivateFontCollection PoppinsBlack = new PrivateFontCollection();
        private PrivateFontCollection PoppinsRegular = new PrivateFontCollection();
        

        // Color
        private Color naranja = Color.FromArgb(255, 95, 44);

        public frm_login()
        {
            InitializeComponent();
        }

        private void frm_login_Load(object sender, EventArgs e)
        {
            // Importar las tipografias
            PoppinsRegular.AddFontFile("C:/Poppins-Regular.ttf");
            PoppinsBlack.AddFontFile("C:/Poppins-Black.ttf");

            // Asignar las tipografias
            AplicarTipografiaAControles(this);
            label1.Font = new Font(PoppinsBlack.Families[0], label1.Font.Size);

            // Asignar el color
            label1.ForeColor = naranja;
            btn_iniciarSesion.BackColor = naranja;

            
        }

        private void AplicarTipografiaAControles(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c is Label || c is Button || c is TextBox || c is ComboBox || c is ListBox || c is RadioButton || c is CheckBox)
                {
                    c.Font = new Font(PoppinsRegular.Families[0], c.Font.Size);
                }
                else if (c.HasChildren)
                {
                    AplicarTipografiaAControles(c);
                }
            }
        }






        private void btn_iniciarSesion_Click(object sender, EventArgs e)
        {

        }
    }
}
