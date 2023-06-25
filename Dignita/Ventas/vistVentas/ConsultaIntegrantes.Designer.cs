namespace Dignita.Ventas.vistVentas
{
    partial class ConsultaIntegrantes
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
            this.label2 = new System.Windows.Forms.Label();
            this.dtgvIntegrantes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvIntegrantes)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoEllipsis = true;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "Lista de Integrantes";
            // 
            // dtgvIntegrantes
            // 
            this.dtgvIntegrantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvIntegrantes.Location = new System.Drawing.Point(49, 58);
            this.dtgvIntegrantes.Name = "dtgvIntegrantes";
            this.dtgvIntegrantes.RowHeadersWidth = 51;
            this.dtgvIntegrantes.RowTemplate.Height = 24;
            this.dtgvIntegrantes.Size = new System.Drawing.Size(416, 435);
            this.dtgvIntegrantes.TabIndex = 3;
            // 
            // ConsultaIntegrantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 505);
            this.Controls.Add(this.dtgvIntegrantes);
            this.Controls.Add(this.label2);
            this.Name = "ConsultaIntegrantes";
            this.Text = "ConsultaIntegrantes";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvIntegrantes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtgvIntegrantes;
    }
}