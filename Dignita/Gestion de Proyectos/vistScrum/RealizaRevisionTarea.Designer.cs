namespace Dignita.Gestion_de_Proyectos.vistScrum
{
    partial class RealizaRevisionTarea
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
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.cbxEstadoTar = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtgvDesarrolladoresTarea = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDesarrolladoresTarea)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.Location = new System.Drawing.Point(208, 390);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(158, 33);
            this.btnConfirmar.TabIndex = 20;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            // 
            // cbxEstadoTar
            // 
            this.cbxEstadoTar.FormattingEnabled = true;
            this.cbxEstadoTar.Location = new System.Drawing.Point(39, 92);
            this.cbxEstadoTar.Name = "cbxEstadoTar";
            this.cbxEstadoTar.Size = new System.Drawing.Size(167, 24);
            this.cbxEstadoTar.TabIndex = 21;
            this.cbxEstadoTar.Text = "           --Selecciona--";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "Estado de la Tarea*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(355, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "Comentario*";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(359, 83);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(243, 98);
            this.textBox1.TabIndex = 24;
            this.textBox1.Text = "Escriba Aqui...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 20);
            this.label3.TabIndex = 25;
            this.label3.Text = "Desarrolladores de la Tarea";
            // 
            // dtgvDesarrolladoresTarea
            // 
            this.dtgvDesarrolladoresTarea.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDesarrolladoresTarea.Location = new System.Drawing.Point(32, 186);
            this.dtgvDesarrolladoresTarea.Name = "dtgvDesarrolladoresTarea";
            this.dtgvDesarrolladoresTarea.RowHeadersWidth = 51;
            this.dtgvDesarrolladoresTarea.RowTemplate.Height = 24;
            this.dtgvDesarrolladoresTarea.Size = new System.Drawing.Size(275, 150);
            this.dtgvDesarrolladoresTarea.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoEllipsis = true;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 27);
            this.label4.TabIndex = 27;
            this.label4.Text = "Revision Tarea";
            // 
            // RealizaRevisionTarea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtgvDesarrolladoresTarea);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxEstadoTar);
            this.Controls.Add(this.btnConfirmar);
            this.Name = "RealizaRevisionTarea";
            this.Text = "RealizaRevisionTarea";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDesarrolladoresTarea)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.ComboBox cbxEstadoTar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dtgvDesarrolladoresTarea;
        private System.Windows.Forms.Label label4;
    }
}