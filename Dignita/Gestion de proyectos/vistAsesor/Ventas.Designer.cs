namespace Dignita.Gestion_de_proyectos.vistAsesor
{
    partial class Ventas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ventas));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_nuevo = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.lbl_1 = new System.Windows.Forms.Label();
            this.txt_nombreProyecto = new System.Windows.Forms.TextBox();
            this.lbl_5 = new System.Windows.Forms.Label();
            this.lbl_7 = new System.Windows.Forms.Label();
            this.nud_duracion = new System.Windows.Forms.NumericUpDown();
            this.nud_precio = new System.Windows.Forms.NumericUpDown();
            this.lbl_2 = new System.Windows.Forms.Label();
            this.cmb_empresa = new System.Windows.Forms.ComboBox();
            this.cmb_rubro = new System.Windows.Forms.ComboBox();
            this.lbl_3 = new System.Windows.Forms.Label();
            this.cmb_estado = new System.Windows.Forms.ComboBox();
            this.lbl_4 = new System.Windows.Forms.Label();
            this.lbl_6 = new System.Windows.Forms.Label();
            this.txt_comentario = new System.Windows.Forms.TextBox();
            this.lbl_8 = new System.Windows.Forms.Label();
            this.cmb_scrumMaster = new System.Windows.Forms.ComboBox();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lkbPerfil = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_rubro = new System.Windows.Forms.Button();
            this.btn_empresa = new System.Windows.Forms.Button();
            this.btn_proyecto = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_duracion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_precio)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 91);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(784, 230);
            this.dataGridView1.TabIndex = 0;
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nuevo.Location = new System.Drawing.Point(834, 104);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(151, 47);
            this.btn_nuevo.TabIndex = 1;
            this.btn_nuevo.Text = "Nuevo";
            this.btn_nuevo.UseVisualStyleBackColor = true;
            this.btn_nuevo.Click += new System.EventHandler(this.btn_nuevo_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.BackColor = System.Drawing.Color.Red;
            this.btn_eliminar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminar.Location = new System.Drawing.Point(834, 172);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(151, 47);
            this.btn_eliminar.TabIndex = 2;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = false;
            // 
            // lbl_1
            // 
            this.lbl_1.AutoSize = true;
            this.lbl_1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_1.Location = new System.Drawing.Point(18, 350);
            this.lbl_1.Name = "lbl_1";
            this.lbl_1.Size = new System.Drawing.Size(178, 18);
            this.lbl_1.TabIndex = 3;
            this.lbl_1.Text = "Nombre del proyecto";
            this.lbl_1.Visible = false;
            // 
            // txt_nombreProyecto
            // 
            this.txt_nombreProyecto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_nombreProyecto.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombreProyecto.Location = new System.Drawing.Point(21, 383);
            this.txt_nombreProyecto.Multiline = true;
            this.txt_nombreProyecto.Name = "txt_nombreProyecto";
            this.txt_nombreProyecto.Size = new System.Drawing.Size(285, 36);
            this.txt_nombreProyecto.TabIndex = 4;
            // 
            // lbl_5
            // 
            this.lbl_5.AutoSize = true;
            this.lbl_5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_5.Location = new System.Drawing.Point(354, 350);
            this.lbl_5.Name = "lbl_5";
            this.lbl_5.Size = new System.Drawing.Size(178, 18);
            this.lbl_5.TabIndex = 5;
            this.lbl_5.Text = "Duración (en meses)";
            // 
            // lbl_7
            // 
            this.lbl_7.AutoSize = true;
            this.lbl_7.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_7.Location = new System.Drawing.Point(697, 350);
            this.lbl_7.Name = "lbl_7";
            this.lbl_7.Size = new System.Drawing.Size(120, 18);
            this.lbl_7.TabIndex = 7;
            this.lbl_7.Text = "Precio (soles)";
            // 
            // nud_duracion
            // 
            this.nud_duracion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nud_duracion.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_duracion.Location = new System.Drawing.Point(357, 383);
            this.nud_duracion.Name = "nud_duracion";
            this.nud_duracion.Size = new System.Drawing.Size(285, 27);
            this.nud_duracion.TabIndex = 9;
            // 
            // nud_precio
            // 
            this.nud_precio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nud_precio.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_precio.Location = new System.Drawing.Point(700, 383);
            this.nud_precio.Name = "nud_precio";
            this.nud_precio.Size = new System.Drawing.Size(285, 27);
            this.nud_precio.TabIndex = 10;
            // 
            // lbl_2
            // 
            this.lbl_2.AutoSize = true;
            this.lbl_2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_2.Location = new System.Drawing.Point(18, 442);
            this.lbl_2.Name = "lbl_2";
            this.lbl_2.Size = new System.Drawing.Size(78, 18);
            this.lbl_2.TabIndex = 11;
            this.lbl_2.Text = "Empresa";
            // 
            // cmb_empresa
            // 
            this.cmb_empresa.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_empresa.FormattingEnabled = true;
            this.cmb_empresa.Location = new System.Drawing.Point(21, 475);
            this.cmb_empresa.Name = "cmb_empresa";
            this.cmb_empresa.Size = new System.Drawing.Size(285, 26);
            this.cmb_empresa.TabIndex = 12;
            // 
            // cmb_rubro
            // 
            this.cmb_rubro.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_rubro.FormattingEnabled = true;
            this.cmb_rubro.Location = new System.Drawing.Point(21, 564);
            this.cmb_rubro.Name = "cmb_rubro";
            this.cmb_rubro.Size = new System.Drawing.Size(285, 26);
            this.cmb_rubro.TabIndex = 14;
            // 
            // lbl_3
            // 
            this.lbl_3.AutoSize = true;
            this.lbl_3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_3.Location = new System.Drawing.Point(18, 531);
            this.lbl_3.Name = "lbl_3";
            this.lbl_3.Size = new System.Drawing.Size(55, 18);
            this.lbl_3.TabIndex = 13;
            this.lbl_3.Text = "Rubro";
            // 
            // cmb_estado
            // 
            this.cmb_estado.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_estado.FormattingEnabled = true;
            this.cmb_estado.Location = new System.Drawing.Point(21, 653);
            this.cmb_estado.Name = "cmb_estado";
            this.cmb_estado.Size = new System.Drawing.Size(285, 26);
            this.cmb_estado.TabIndex = 16;
            // 
            // lbl_4
            // 
            this.lbl_4.AutoSize = true;
            this.lbl_4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_4.Location = new System.Drawing.Point(18, 620);
            this.lbl_4.Name = "lbl_4";
            this.lbl_4.Size = new System.Drawing.Size(64, 18);
            this.lbl_4.TabIndex = 15;
            this.lbl_4.Text = "Estado";
            // 
            // lbl_6
            // 
            this.lbl_6.AutoSize = true;
            this.lbl_6.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_6.Location = new System.Drawing.Point(354, 442);
            this.lbl_6.Name = "lbl_6";
            this.lbl_6.Size = new System.Drawing.Size(102, 18);
            this.lbl_6.TabIndex = 17;
            this.lbl_6.Text = "Comentario";
            // 
            // txt_comentario
            // 
            this.txt_comentario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_comentario.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_comentario.Location = new System.Drawing.Point(357, 476);
            this.txt_comentario.Multiline = true;
            this.txt_comentario.Name = "txt_comentario";
            this.txt_comentario.Size = new System.Drawing.Size(285, 203);
            this.txt_comentario.TabIndex = 18;
            // 
            // lbl_8
            // 
            this.lbl_8.AutoSize = true;
            this.lbl_8.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_8.Location = new System.Drawing.Point(697, 442);
            this.lbl_8.Name = "lbl_8";
            this.lbl_8.Size = new System.Drawing.Size(187, 18);
            this.lbl_8.TabIndex = 20;
            this.lbl_8.Text = "Nombre Scrum Master";
            // 
            // cmb_scrumMaster
            // 
            this.cmb_scrumMaster.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_scrumMaster.FormattingEnabled = true;
            this.cmb_scrumMaster.Location = new System.Drawing.Point(700, 476);
            this.cmb_scrumMaster.Name = "cmb_scrumMaster";
            this.cmb_scrumMaster.Size = new System.Drawing.Size(285, 26);
            this.cmb_scrumMaster.TabIndex = 21;
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.BackColor = System.Drawing.Color.Black;
            this.btn_aceptar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_aceptar.ForeColor = System.Drawing.Color.White;
            this.btn_aceptar.Location = new System.Drawing.Point(700, 531);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(285, 47);
            this.btn_aceptar.TabIndex = 22;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = false;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.btn_salir);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.lkbPerfil);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btn_rubro);
            this.panel1.Controls.Add(this.btn_empresa);
            this.panel1.Controls.Add(this.btn_proyecto);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1014, 66);
            this.panel1.TabIndex = 23;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(931, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(805, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 26);
            this.label8.TabIndex = 7;
            this.label8.Text = "Pereda Saldaña,\r\n                Aaron";
            // 
            // lkbPerfil
            // 
            this.lkbPerfil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lkbPerfil.AutoSize = true;
            this.lkbPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lkbPerfil.Location = new System.Drawing.Point(856, 40);
            this.lkbPerfil.Name = "lkbPerfil";
            this.lkbPerfil.Size = new System.Drawing.Size(59, 13);
            this.lkbPerfil.TabIndex = 6;
            this.lkbPerfil.TabStop = true;
            this.lkbPerfil.Text = "Ver Perfil";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(24, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btn_rubro
            // 
            this.btn_rubro.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_rubro.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rubro.Location = new System.Drawing.Point(430, 5);
            this.btn_rubro.Name = "btn_rubro";
            this.btn_rubro.Size = new System.Drawing.Size(100, 58);
            this.btn_rubro.TabIndex = 4;
            this.btn_rubro.Text = "Rubro";
            this.btn_rubro.UseVisualStyleBackColor = true;
            // 
            // btn_empresa
            // 
            this.btn_empresa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_empresa.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_empresa.Location = new System.Drawing.Point(321, 5);
            this.btn_empresa.Name = "btn_empresa";
            this.btn_empresa.Size = new System.Drawing.Size(100, 58);
            this.btn_empresa.TabIndex = 4;
            this.btn_empresa.Text = "Empresa";
            this.btn_empresa.UseVisualStyleBackColor = true;
            // 
            // btn_proyecto
            // 
            this.btn_proyecto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_proyecto.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_proyecto.Location = new System.Drawing.Point(213, 5);
            this.btn_proyecto.Name = "btn_proyecto";
            this.btn_proyecto.Size = new System.Drawing.Size(100, 58);
            this.btn_proyecto.TabIndex = 4;
            this.btn_proyecto.Text = "Proyecto";
            this.btn_proyecto.UseVisualStyleBackColor = true;
            // 
            // btn_salir
            // 
            this.btn_salir.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_salir.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salir.Location = new System.Drawing.Point(540, 5);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(100, 58);
            this.btn_salir.TabIndex = 9;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            // 
            // Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 741);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.cmb_scrumMaster);
            this.Controls.Add(this.lbl_8);
            this.Controls.Add(this.txt_comentario);
            this.Controls.Add(this.lbl_6);
            this.Controls.Add(this.cmb_estado);
            this.Controls.Add(this.lbl_4);
            this.Controls.Add(this.cmb_rubro);
            this.Controls.Add(this.lbl_3);
            this.Controls.Add(this.cmb_empresa);
            this.Controls.Add(this.lbl_2);
            this.Controls.Add(this.nud_precio);
            this.Controls.Add(this.nud_duracion);
            this.Controls.Add(this.lbl_7);
            this.Controls.Add(this.lbl_5);
            this.Controls.Add(this.txt_nombreProyecto);
            this.Controls.Add(this.lbl_1);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_nuevo);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Ventas";
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.Ventas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_duracion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_precio)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_nuevo;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Label lbl_1;
        private System.Windows.Forms.TextBox txt_nombreProyecto;
        private System.Windows.Forms.Label lbl_5;
        private System.Windows.Forms.Label lbl_7;
        private System.Windows.Forms.NumericUpDown nud_duracion;
        private System.Windows.Forms.NumericUpDown nud_precio;
        private System.Windows.Forms.Label lbl_2;
        private System.Windows.Forms.ComboBox cmb_empresa;
        private System.Windows.Forms.ComboBox cmb_rubro;
        private System.Windows.Forms.Label lbl_3;
        private System.Windows.Forms.ComboBox cmb_estado;
        private System.Windows.Forms.Label lbl_4;
        private System.Windows.Forms.Label lbl_6;
        private System.Windows.Forms.TextBox txt_comentario;
        private System.Windows.Forms.Label lbl_8;
        private System.Windows.Forms.ComboBox cmb_scrumMaster;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.LinkLabel lkbPerfil;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_rubro;
        private System.Windows.Forms.Button btn_empresa;
        private System.Windows.Forms.Button btn_proyecto;
    }
}