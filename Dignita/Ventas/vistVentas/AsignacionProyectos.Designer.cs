namespace Dignita.Ventas.vistVentas
{
    partial class AsignacionProyectos
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
            this.btnAsignación = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProyectos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProyectos
            // 
            this.dgvProyectos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProyectos.Location = new System.Drawing.Point(9, 26);
            this.dgvProyectos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvProyectos.Name = "dgvProyectos";
            this.dgvProyectos.RowHeadersWidth = 51;
            this.dgvProyectos.RowTemplate.Height = 24;
            this.dgvProyectos.Size = new System.Drawing.Size(541, 361);
            this.dgvProyectos.TabIndex = 0;
            this.dgvProyectos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProyectos_CellContentClick);
            // 
            // btnAsignación
            // 
            this.btnAsignación.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAsignación.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAsignación.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAsignación.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsignación.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsignación.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAsignación.Location = new System.Drawing.Point(592, 33);
            this.btnAsignación.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAsignación.Name = "btnAsignación";
            this.btnAsignación.Size = new System.Drawing.Size(150, 54);
            this.btnAsignación.TabIndex = 57;
            this.btnAsignación.Text = "Asignación de equipo";
            this.btnAsignación.UseVisualStyleBackColor = false;
            this.btnAsignación.Click += new System.EventHandler(this.btnAsignación_Click);
            // 
            // AsignacionProyectos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 453);
            this.Controls.Add(this.btnAsignación);
            this.Controls.Add(this.dgvProyectos);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AsignacionProyectos";
            this.Text = "frmProyectos";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.AsignacionProyectos_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProyectos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProyectos;
        private System.Windows.Forms.Button btnAsignación;
    }
}