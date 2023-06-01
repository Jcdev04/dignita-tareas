namespace Dignita.Gestion_de_proyectos.vistDesarrollador
{
    partial class Realizar_Tareas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Realizar_Tareas));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnTareas = new System.Windows.Forms.ToolStripButton();
            this.btnRequerimientos = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnTareas,
            this.btnRequerimientos});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(930, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnTareas
            // 
            this.btnTareas.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnTareas.Image = ((System.Drawing.Image)(resources.GetObject("btnTareas.Image")));
            this.btnTareas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnTareas.Name = "btnTareas";
            this.btnTareas.Size = new System.Drawing.Size(43, 22);
            this.btnTareas.Text = "Tareas";
            // 
            // btnRequerimientos
            // 
            this.btnRequerimientos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnRequerimientos.Image = ((System.Drawing.Image)(resources.GetObject("btnRequerimientos.Image")));
            this.btnRequerimientos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRequerimientos.Name = "btnRequerimientos";
            this.btnRequerimientos.Size = new System.Drawing.Size(94, 22);
            this.btnRequerimientos.Text = "Requerimientos";
            // 
            // Realizar_Tareas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 597);
            this.Controls.Add(this.toolStrip1);
            this.IsMdiContainer = true;
            this.Name = "Realizar_Tareas";
            this.Text = "Realizar_Tareas";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnTareas;
        private System.Windows.Forms.ToolStripButton btnRequerimientos;
    }
}