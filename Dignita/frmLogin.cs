using Dignita.Gestion_de_Proyectos.vistScrum;
using Dignita.Ventas.vistVentas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dignita
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btn_iniciarSesion_Click(object sender, EventArgs e)
        {
            string dni = txt_usuario.Text;

            bool esScrumMaster = false;
            bool esAsesorVentas = false;

            string connectionString = "Data Source=LAPTOP-BH5K91S6\\SQLEXPRESS; Initial Catalog=DB_DIGNITA; Integrated Security = True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("VerificarScrumMaster", connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.Add("@dni", SqlDbType.VarChar, 8).Value = dni;

                    SqlParameter outputParam = new SqlParameter("@esScrumMaster", SqlDbType.Bit);
                    outputParam.Direction = ParameterDirection.Output;
                    command.Parameters.Add(outputParam);

                    command.ExecuteNonQuery();


                    esScrumMaster = (bool)command.Parameters["@esScrumMaster"].Value;
                }


                using (SqlCommand command = new SqlCommand("VerificarAsesorVentas", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("@dni", SqlDbType.VarChar, 8).Value = dni;

                    SqlParameter outputParam = new SqlParameter("@esAsesorVentas", SqlDbType.Bit);
                    outputParam.Direction = ParameterDirection.Output;
                    command.Parameters.Add(outputParam);

                    command.ExecuteNonQuery();

                    esAsesorVentas = (bool)command.Parameters["@esAsesorVentas"].Value;
                }
            }

            if (esScrumMaster)
            {

                PrincipalScrum scrum = new PrincipalScrum();
                scrum.Show();
            }
            else if (esAsesorVentas)
            {
                PrincipalVentas ventas = new PrincipalVentas();
                ventas.Show();
            }
            else
            {
                MessageBox.Show("DNI no válido o no tiene acceso.");
            }
        }

        //Tipografias
        private PrivateFontCollection PoppinsBlack = new PrivateFontCollection();
        private PrivateFontCollection PoppinsRegular = new PrivateFontCollection();


        // Color
        private Color naranja = Color.FromArgb(255, 95, 44);

        private void frm_login_Load(object sender, EventArgs e)
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
    }
}
