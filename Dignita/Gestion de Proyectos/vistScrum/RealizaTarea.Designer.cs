namespace Dignita.Gestion_de_Proyectos.vistScrum
{
    partial class RealizaTarea
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
            this.dtgvTareas = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.btnQuitarFiltro = new System.Windows.Forms.Button();
            this.btnRevision = new System.Windows.Forms.Button();
            this.btnDesarrolladores = new System.Windows.Forms.Button();
            this.dtpDuracion = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRegistrarTarea = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTareas)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvTareas
            // 
            this.dtgvTareas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvTareas.Location = new System.Drawing.Point(31, 103);
            this.dtgvTareas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgvTareas.Name = "dtgvTareas";
            this.dtgvTareas.RowHeadersWidth = 51;
            this.dtgvTareas.RowTemplate.Height = 24;
            this.dtgvTareas.Size = new System.Drawing.Size(621, 294);
            this.dtgvTareas.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoEllipsis = true;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 27);
            this.label2.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoEllipsis = true;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(27, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 25);
            this.label3.TabIndex = 37;
            this.label3.Text = "Registro de Tareas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(27, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 20);
            this.label4.TabIndex = 51;
            this.label4.Text = "Lista de tareas";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(325, 62);
            this.btnFiltrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(187, 36);
            this.btnFiltrar.TabIndex = 52;
            this.btnFiltrar.Text = "Filtrar Tareas registradas";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            // 
            // btnQuitarFiltro
            // 
            this.btnQuitarFiltro.Location = new System.Drawing.Point(517, 62);
            this.btnQuitarFiltro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnQuitarFiltro.Name = "btnQuitarFiltro";
            this.btnQuitarFiltro.Size = new System.Drawing.Size(133, 36);
            this.btnQuitarFiltro.TabIndex = 52;
            this.btnQuitarFiltro.Text = "Quitar filtro";
            this.btnQuitarFiltro.UseVisualStyleBackColor = true;
            // 
            // btnRevision
            // 
            this.btnRevision.BackColor = System.Drawing.Color.Transparent;
            this.btnRevision.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRevision.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRevision.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRevision.ForeColor = System.Drawing.Color.White;
            this.btnRevision.Location = new System.Drawing.Point(667, 103);
            this.btnRevision.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRevision.Name = "btnRevision";
            this.btnRevision.Size = new System.Drawing.Size(188, 33);
            this.btnRevision.TabIndex = 53;
            this.btnRevision.Text = "Revisión";
            this.btnRevision.UseVisualStyleBackColor = false;
            this.btnRevision.Click += new System.EventHandler(this.btnRevision_Click);
            // 
            // btnDesarrolladores
            // 
            this.btnDesarrolladores.BackColor = System.Drawing.Color.Transparent;
            this.btnDesarrolladores.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDesarrolladores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesarrolladores.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesarrolladores.ForeColor = System.Drawing.Color.White;
            this.btnDesarrolladores.Location = new System.Drawing.Point(667, 151);
            this.btnDesarrolladores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDesarrolladores.Name = "btnDesarrolladores";
            this.btnDesarrolladores.Size = new System.Drawing.Size(188, 33);
            this.btnDesarrolladores.TabIndex = 55;
            this.btnDesarrolladores.Text = "Asignar";
            this.btnDesarrolladores.UseVisualStyleBackColor = false;
            this.btnDesarrolladores.Click += new System.EventHandler(this.btnDesarrolladores_Click);
            // 
            // dtpDuracion
            // 
            this.dtpDuracion.Location = new System.Drawing.Point(31, 447);
            this.dtpDuracion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpDuracion.Name = "dtpDuracion";
            this.dtpDuracion.Size = new System.Drawing.Size(260, 22);
            this.dtpDuracion.TabIndex = 57;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(27, 418);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 20);
            this.label1.TabIndex = 51;
            this.label1.Text = "Fecha de finalización de la tarea";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnRegistrarTarea
            // 
            this.btnRegistrarTarea.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnRegistrarTarea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarTarea.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarTarea.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarTarea.Location = new System.Drawing.Point(339, 430);
            this.btnRegistrarTarea.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegistrarTarea.Name = "btnRegistrarTarea";
            this.btnRegistrarTarea.Size = new System.Drawing.Size(173, 39);
            this.btnRegistrarTarea.TabIndex = 58;
            this.btnRegistrarTarea.Text = "Registrar tarea";
            this.btnRegistrarTarea.UseVisualStyleBackColor = false;
            this.btnRegistrarTarea.Click += new System.EventHandler(this.btnRegistrarTarea_Click_1);
            // 
            // RealizaTarea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 519);
            this.Controls.Add(this.btnRegistrarTarea);
            this.Controls.Add(this.dtpDuracion);
            this.Controls.Add(this.btnDesarrolladores);
            this.Controls.Add(this.btnRevision);
            this.Controls.Add(this.btnQuitarFiltro);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtgvTareas);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "RealizaTarea";
            this.Text = " ";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.RealizaTarea_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTareas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvTareas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Button btnQuitarFiltro;
        private System.Windows.Forms.Button btnRevision;
        private System.Windows.Forms.Button btnDesarrolladores;
        private System.Windows.Forms.DateTimePicker dtpDuracion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRegistrarTarea;
    }
}