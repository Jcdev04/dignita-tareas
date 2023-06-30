namespace Dignita.Ventas.vistVentas
{
    partial class PrincipalVentas
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
            this.btnRegistarContrato = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAsignacion = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRegistarContrato
            // 
            this.btnRegistarContrato.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRegistarContrato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistarContrato.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistarContrato.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRegistarContrato.Location = new System.Drawing.Point(55, 130);
            this.btnRegistarContrato.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegistarContrato.Name = "btnRegistarContrato";
            this.btnRegistarContrato.Size = new System.Drawing.Size(197, 46);
            this.btnRegistarContrato.TabIndex = 56;
            this.btnRegistarContrato.Text = "Registrar contrato";
            this.btnRegistarContrato.UseVisualStyleBackColor = false;
            this.btnRegistarContrato.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnAsignacion);
            this.groupBox2.Controls.Add(this.btnRegistarContrato);
            this.groupBox2.Location = new System.Drawing.Point(266, 68);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(295, 391);
            this.groupBox2.TabIndex = 60;
            this.groupBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(60, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 29);
            this.label2.TabIndex = 59;
            this.label2.Text = "REGISTRAR";
            // 
            // btnAsignacion
            // 
            this.btnAsignacion.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAsignacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsignacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsignacion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAsignacion.Location = new System.Drawing.Point(55, 182);
            this.btnAsignacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAsignacion.Name = "btnAsignacion";
            this.btnAsignacion.Size = new System.Drawing.Size(197, 59);
            this.btnAsignacion.TabIndex = 56;
            this.btnAsignacion.Text = "Asignación de equipo";
            this.btnAsignacion.UseVisualStyleBackColor = false;
            this.btnAsignacion.Click += new System.EventHandler(this.btnAsignacion_Click);
            // 
            // PrincipalVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 518);
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PrincipalVentas";
            this.Text = "Principal";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.PrincipalVentas_Paint);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnRegistarContrato;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAsignacion;
    }
}