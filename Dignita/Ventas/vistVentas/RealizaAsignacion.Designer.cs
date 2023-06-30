namespace Dignita.Ventas.vistVentas
{
    partial class RealizaAsignacion
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
            this.dgvEquipo = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEquipo
            // 
            this.dgvEquipo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEquipo.Location = new System.Drawing.Point(31, 66);
            this.dgvEquipo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvEquipo.Name = "dgvEquipo";
            this.dgvEquipo.RowHeadersWidth = 51;
            this.dgvEquipo.RowTemplate.Height = 24;
            this.dgvEquipo.Size = new System.Drawing.Size(515, 230);
            this.dgvEquipo.TabIndex = 4;
            this.dgvEquipo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEquipo_CellContentClick);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(591, 66);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(188, 33);
            this.btnAgregar.TabIndex = 59;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(27, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 25);
            this.label1.TabIndex = 62;
            this.label1.Text = "Asignacion de equipo";
            // 
            // RealizaAsignacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 430);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvEquipo);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "RealizaAsignacion";
            this.Text = " ";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.RealizaAsignacion_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvEquipo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label1;
    }
}