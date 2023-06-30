using CapaEntidad;
using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using SelectPdf;

namespace Dignita.Ventas.vistVentas
{
    public partial class MantenedorProyecto : Form
    {
        entContrato ec = null;
        entEmpresa ee = new entEmpresa();
        string action = "";
        public MantenedorProyecto(entContrato ec, string nombreEmpresa, string ruc_emp)
        {
            InitializeComponent();
            this.ec = ec;
            ee.razon_social = nombreEmpresa;
            ee.RUC = ruc_emp;

            lblNombreEmpresa.Text = nombreEmpresa;
            lblCostoProyecto.Text = ec.costo.ToString();
            lblFechaFinalizacion.Text = ec.fecha_fin.ToString();

            listarProyecto();
            enableInputs(false);
            ListarTipoProyecto();
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            action = "agregar";
            enableInputs(true);
            limpiar();
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            action = "modificar";
            if (dgvProyecto.CurrentCell.RowIndex != -1)
            {
                enableInputs(true);
            }
            else
            {
                MessageBox.Show("Seleccione una fila");
            }
        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            if (dgvProyecto.CurrentCell.RowIndex != -1)
            {
                logProyecto.Instancia.inhabilitarProyecto(new entProyecto
                {
                    id_proy = Int32.Parse(dgvProyecto.Rows[dgvProyecto.CurrentCell.RowIndex].Cells[0].Value.ToString())
                });
                listarProyecto();
            }
            else
            {
                MessageBox.Show("Seleccione una fila");
            }
        }
        //ACEPTAR Y CANCELAR
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiar();
            enableInputs(false);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (!validar())
            {
                MessageBox.Show("Los campos no deberían estar vacíos");
                return;
            }
            entProyecto ep = new entProyecto();
            ep.tipo_proy = Convert.ToInt32(cbxRubro.SelectedValue);
            ep.nombre_proy = txtNombreProy.Text;
            ep.descripcion = txtDescripcion.Text;
            if (action == "agregar")
            {
                logProyecto.Instancia.agregarProyecto(ep);
            }
            else if (action == "modificar")
            {
                ep.id_proy = Int32.Parse(dgvProyecto.Rows[dgvProyecto.CurrentCell.RowIndex].Cells[0].Value.ToString());
                logProyecto.Instancia.editarProyecto(ep);
            }
            listarProyecto();
            enableInputs(false);
            limpiar();
        }
        private void dgvProyecto_SelectionChanged(object sender, EventArgs e)
        {
            txtDescripcion.Text = dgvProyecto.Rows[dgvProyecto.CurrentCell.RowIndex].Cells[3].Value.ToString();
            txtNombreProy.Text = dgvProyecto.Rows[dgvProyecto.CurrentCell.RowIndex].Cells[2].Value.ToString();
            cbxRubro.SelectedItem = dgvProyecto.Rows[dgvProyecto.CurrentCell.RowIndex].Cells[1].Value.ToString();
        }

        private void btnGenerarContrato_Click(object sender, EventArgs e)
        {
            if (dgvProyecto.CurrentCell.RowIndex != -1)
            {
                entProyecto ep = new entProyecto();
                ep.id_proy = Int32.Parse(dgvProyecto.Rows[dgvProyecto.CurrentCell.RowIndex].Cells[0].Value.ToString());
                ec.id_proyecto = ep.id_proy;
                
                logContrato.Instancia.agregarContrato(ec);
                logProyecto.Instancia.contratarProyecto(ep);
                listarProyecto();
                MessageBox.Show("Contrato generado");
                
                generarPdf();
            }   
            else
            {
                MessageBox.Show("Seleccione una fila");
            }
        }

        //AUXILIARES
        private void enableInputs(bool estado)
        {
            gbxProy.Enabled = estado;
            btnAgregar.Enabled = !estado;
            btnModificar.Enabled = !estado;
            btnDeshabilitar.Enabled = !estado;
        }
        private void limpiar()
        {
            txtNombreProy.Text = "";
            cbxRubro.Text = "";
            txtDescripcion.Text = "";
        }
        private bool validar()
        {
            return cbxRubro.Text != "" && txtNombreProy.Text != "" && txtDescripcion.Text != "";
        }
        private void ListarTipoProyecto()
        {
            cbxRubro.DataSource = logTipoProyecto.Instancia.listarTipoProyecto();
            cbxRubro.DisplayMember = "nombre";
            cbxRubro.ValueMember = "id_tipo_proy";
        }
        public void listarProyecto()
        {
            dgvProyecto.DataSource = logProyecto.Instancia.listarProyectos();
        }


        public void generarPdf()
        {
            // Obtener los datos del formulario
            string empresa = ee.razon_social;
            string ruc = ee.RUC;
            string nombre = txtNombreProy.Text;
            string fecha = ec.fecha_inicio.ToString();
            float costo = ec.costo;

            int id_contrato = logContrato.Instancia.SeleccionarUltimoContrato();

            // Generar el contenido del archivo PDF como una página HTML

            // Clases
            string flex = "display: flex;";
            string between = "justify-content: space-between;";
            string centerX = "justify-content: center;";
            string centerY = "align-items: center;";
            string column = "flex-direction: column;";
            string width150 = "width: 150px;";
            string width400 = "width: 400px;";
            string width500 = "width: 500px;";
            string width750 = "width: 750px;";
            string width100 = "width: 100%;";

            string red = "color: red;";
            string border = "border: 2px solid red;";
            string radius = "border-radius: 10px;";
            string padding = "padding: 20px 10px;";
            string margin = "margin-bottom: 45px;";
            string padding2 = "padding-left: 20px;";

            string html = "<html>" +
                $"<body style='font-family: sans-serif; font-size: 16px; {padding}'> " +
                    $"<picture style='{flex}{width150}{padding2}{margin}'>" +
                        $"<img style='{width100}' src='https://i.imgur.com/8XJJhlT.png' alt='logo Dignita'>" +
                    $"</picture>" +

                    $"<div style='{flex}{centerX}{centerY}{width750}{column}'>" +


                        $"<div style='{red}{flex}{column}{centerX}{centerY}{width400}{border}{radius}{padding}{margin}'>" +
                            $"<p>RUC: 90147963258</p>" +
                            $"<h1>Factura Electrónica</h1>" +
                            $"<p>N° {id_contrato}</p>" +
                        $"</div>" +

                        $"<div style='{flex}{centerX}{column}{width500}'>" +
                            $"<div style='{flex}{between}{centerY}'>" +
                                $"<h3>Empresa contratada: </h3>" +
                                $"<p>{empresa}</p>" +
                            $"</div>" +
                            $"<div style='{flex}{between}{centerY}'>" +
                                $"<h3>RUC de la empresa: </h3>" +
                                $"<p>{ruc}</p>" +
                            $"</div>" +
                            $"<div style='{flex}{between}{centerY}'>" +
                                $"<h3>Nombre del proyecto: </h3>" +
                                $"<p>{nombre}</p>" +
                            $"</div>" +
                            $"<div style='{flex}{between}{centerY}'>" +
                                $"<h3>Fecha de emisión: </h3>" +
                                $"<p>{fecha}</p>" +
                            $"</div>" +
                            $"<div style='{flex}{between}{centerY}'>" +
                                $"<h3>Total a pagar: </h3>" +
                                $"<p>S/. {costo}</p>" +
                            $"</div>" +
                        $"</div>" +
                    $"</div>" +
                $"</body>" +
            $"</html>";


            // Convertir la página HTML a PDF
            HtmlToPdf converter = new HtmlToPdf();
            converter.Options.WebPageWidth = 500;
            converter.Options.WebPageHeight = 500;
            PdfDocument doc = converter.ConvertHtmlString(html);


            // Mostrar el cuadro de diálogo para seleccionar la ubicación y el nombre del archivo PDF
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf";
            saveFileDialog.FileName = "comprobante_pago.pdf";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Guardar el archivo PDF en la ubicación seleccionada por el usuario
                doc.Save(saveFileDialog.FileName);
                doc.Close();
            }
        }

        private void MantenedorProyecto_Paint(object sender, PaintEventArgs e)
        {
            // Create a path that consists of a single circle.
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, ClientRectangle.Width, ClientRectangle.Height);

            // Use the path to construct a brush.
            PathGradientBrush brush = new PathGradientBrush(path);

            // Set the color at the center of the path to blue.
            brush.CenterColor = Color.FromArgb(103, 59, 46);

            // Set the color along the entire boundary 
            // of the path to aqua.
            Color[] colors = { Color.FromArgb(25, 25, 25) };
            brush.SurroundColors = colors;

            // Set the center point of the gradient.
            brush.CenterPoint = new PointF(ClientRectangle.Width / 2f, ClientRectangle.Height / 2f);

            // Set the focus scales of the gradient.
            brush.FocusScales = new PointF(0.10f, 0.10f);
            // Create a solid brush.
            Brush solidBrush = new SolidBrush(Color.FromArgb(25, 25, 25));
            e.Graphics.FillRectangle(solidBrush, ClientRectangle);
            // Fill the form with the gradient.
            e.Graphics.FillRectangle(brush, ClientRectangle);


            // Bordes a botones
            Color naranja = Color.FromArgb(255, 95, 44);
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.FlatAppearance.BorderColor = naranja;
            btnAceptar.FlatAppearance.BorderSize = 1;
            btnCancelar.FlatAppearance.BorderColor = naranja;
            btnCancelar.ForeColor = naranja;
            btnGenerarContrato.FlatStyle = FlatStyle.Flat;
            btnGenerarContrato.FlatAppearance.BorderColor = naranja;
            btnGenerarContrato.FlatAppearance.BorderSize = 1;
            label11.ForeColor = naranja;
        }
    }
}
