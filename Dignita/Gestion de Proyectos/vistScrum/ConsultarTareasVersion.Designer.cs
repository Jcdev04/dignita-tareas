namespace Dignita.Gestion_de_Proyectos.vistScrum
{
    partial class ConsultarTareasVersion
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
            this.dtgvTareasVersion = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTareasVersion)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvTareasVersion
            // 
            this.dtgvTareasVersion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvTareasVersion.Location = new System.Drawing.Point(37, 119);
            this.dtgvTareasVersion.Name = "dtgvTareasVersion";
            this.dtgvTareasVersion.RowHeadersWidth = 51;
            this.dtgvTareasVersion.RowTemplate.Height = 24;
            this.dtgvTareasVersion.Size = new System.Drawing.Size(717, 302);
            this.dtgvTareasVersion.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoEllipsis = true;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(31, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 31);
            this.label2.TabIndex = 8;
            this.label2.Text = "Lista de Tareas";
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(33, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(556, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Estas son todas las tareas realizadas que pertenece a la versión que escogió";
            // 
            // ConsultarTareasVersion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgvTareasVersion);
            this.Controls.Add(this.label2);
            this.Name = "ConsultarTareasVersion";
            this.Text = "ConsultarTareasVersion";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTareasVersion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dtgvTareasVersion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}