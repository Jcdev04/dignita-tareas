using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dignita.Gestion_de_proyectos.vistAsesor
{
    public partial class Ventas : Form
    {
        // Tipografias
        private PrivateFontCollection PoppinsBlack = new PrivateFontCollection();
        private PrivateFontCollection PoppinsRegular = new PrivateFontCollection();


        // Color
        private Color naranja = Color.FromArgb(255, 95, 44);

        public Ventas()
        {
            InitializeComponent();
        }

        private void Ventas_Load(object sender, EventArgs e)
        {
            // Importar las tipografias
            string tipografia = "Poppins-Regular.ttf";
            string rutaProyecto = System.AppDomain.CurrentDomain.BaseDirectory;
            string rutaCompleta = Path.Combine(rutaProyecto, tipografia);
            PoppinsRegular.AddFontFile(rutaCompleta);

            string tipografia2 = "Poppins-Black.ttf";
            string rutaProyecto2 = System.AppDomain.CurrentDomain.BaseDirectory;
            string rutaCompleta2 = Path.Combine(rutaProyecto2, tipografia2);
            PoppinsBlack.AddFontFile(rutaCompleta2);

            // Asignar las tipografias
            AplicarTipografiaAControles(this);

            // Asignar el color
            btn_nuevo.BackColor = naranja;
        }

        private void AplicarTipografiaAControles(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c is Label || c is Button || c is TextBox || c is ComboBox || c is ListBox || c is RadioButton || c is CheckBox || c is NumericUpDown)
                {
                    c.Font = new Font(PoppinsRegular.Families[0], c.Font.Size);
                }
                else if (c.HasChildren)
                {
                    AplicarTipografiaAControles(c);
                }
            }
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            limpiar();
            lbl_1.Visible = true;
            lbl_2.Visible = true;
            lbl_3.Visible = true;
            lbl_4.Visible = true;
            lbl_5.Visible = true;
            lbl_6.Visible = true;
            lbl_7.Visible = true;
            lbl_8.Visible = true;
            txt_nombreProyecto.Visible = true;
            txt_comentario.Visible = true;
            cmb_empresa.Visible = true;
            cmb_estado.Visible = true;
            cmb_rubro.Visible = true;
            cmb_scrumMaster.Visible = true;
            nud_duracion.Visible = true;
            nud_precio.Visible = true;
            btn_aceptar.Visible = true;
        }

        private void limpiar()
        {
            lbl_1.Text = string.Empty;
            lbl_2.Text = string.Empty;
            lbl_3.Text = string.Empty;
            lbl_4.Text = string.Empty;
            lbl_5.Text = string.Empty;
            lbl_6.Text = string.Empty;
            lbl_7.Text = string.Empty;
            lbl_8.Text = string.Empty;
            txt_nombreProyecto.Text = string.Empty;
            txt_comentario.Text = string.Empty;
            cmb_empresa.SelectedIndex = -1; cmb_empresa.Text = string.Empty;
            cmb_estado.SelectedIndex = -1; cmb_estado.Text = string.Empty;
            cmb_rubro.SelectedIndex = -1; cmb_rubro.Text = string.Empty;
            cmb_scrumMaster.SelectedIndex = -1; cmb_scrumMaster.Text = string.Empty;
            nud_duracion.Value = nud_duracion.Minimum;
            nud_precio.Value = nud_precio.Minimum;
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            lbl_2.Visible = false;
            lbl_3.Visible = false;
            lbl_4.Visible = false;
            lbl_5.Visible = false;
            lbl_6.Visible = false;
            lbl_7.Visible = false;
            lbl_8.Visible = false;
            txt_nombreProyecto.Visible = false;
            txt_comentario.Visible = false;
            cmb_empresa.Visible = false;
            cmb_estado.Visible = false;
            cmb_rubro.Visible = false;
            cmb_scrumMaster.Visible = false;
            nud_duracion.Visible = false;
            nud_precio.Visible = false;
            btn_aceptar.Visible = false;
        }
    }
}
