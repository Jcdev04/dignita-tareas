namespace Dignita.Gestion_de_Proyectos.vistScrum
{
    partial class PrincipalScrum
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
            this.dgvProyectos = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnVerVersiones = new System.Windows.Forms.Button();
            this.btnVerRequerimientos = new System.Windows.Forms.Button();
            this.btnRegistrarTarea = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProyectos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProyectos
            // 
            this.dgvProyectos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProyectos.Location = new System.Drawing.Point(18, 84);
            this.dgvProyectos.Name = "dgvProyectos";
            this.dgvProyectos.RowHeadersWidth = 51;
            this.dgvProyectos.RowTemplate.Height = 24;
            this.dgvProyectos.Size = new System.Drawing.Size(701, 320);
            this.dgvProyectos.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoEllipsis = true;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(13, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Lista de Proyectos";
            // 
            // btnVerVersiones
            // 
            this.btnVerVersiones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerVersiones.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerVersiones.Location = new System.Drawing.Point(742, 86);
            this.btnVerVersiones.Name = "btnVerVersiones";
            this.btnVerVersiones.Size = new System.Drawing.Size(237, 33);
            this.btnVerVersiones.TabIndex = 29;
            this.btnVerVersiones.Text = "Ver versiones";
            this.btnVerVersiones.UseVisualStyleBackColor = true;
            this.btnVerVersiones.Click += new System.EventHandler(this.btnVerVersiones_Click);
            // 
            // btnVerRequerimientos
            // 
            this.btnVerRequerimientos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerRequerimientos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerRequerimientos.Location = new System.Drawing.Point(742, 134);
            this.btnVerRequerimientos.Name = "btnVerRequerimientos";
            this.btnVerRequerimientos.Size = new System.Drawing.Size(237, 33);
            this.btnVerRequerimientos.TabIndex = 30;
            this.btnVerRequerimientos.Text = "Ver Requerimientos";
            this.btnVerRequerimientos.UseVisualStyleBackColor = true;
            this.btnVerRequerimientos.Click += new System.EventHandler(this.btnVerRequerimientos_Click);
            // 
            // btnRegistrarTarea
            // 
            this.btnRegistrarTarea.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRegistrarTarea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarTarea.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarTarea.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRegistrarTarea.Location = new System.Drawing.Point(770, 362);
            this.btnRegistrarTarea.Name = "btnRegistrarTarea";
            this.btnRegistrarTarea.Size = new System.Drawing.Size(188, 42);
            this.btnRegistrarTarea.TabIndex = 30;
            this.btnRegistrarTarea.Text = "Registrar tareas";
            this.btnRegistrarTarea.UseVisualStyleBackColor = false;
            this.btnRegistrarTarea.Click += new System.EventHandler(this.btnRegistrarTarea_Click);
            // 
            // PrincipalScrum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 440);
            this.Controls.Add(this.btnRegistrarTarea);
            this.Controls.Add(this.btnVerRequerimientos);
            this.Controls.Add(this.btnVerVersiones);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvProyectos);
            this.Name = "PrincipalScrum";
            this.Text = "Principal";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProyectos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvProyectos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnVerVersiones;
        private System.Windows.Forms.Button btnVerRequerimientos;
        private System.Windows.Forms.Button btnRegistrarTarea;
    }
}