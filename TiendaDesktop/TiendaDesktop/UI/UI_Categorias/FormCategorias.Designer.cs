namespace TiendaDesktop.UI
{
    partial class FormCategorias
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnCategorias1 = new TiendaDesktop.UI.Paneles.RvCategorias();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buscador1 = new TiendaDesktop.UI.Componentes.Buscador();
            this.panel4 = new System.Windows.Forms.Panel();
            this.categoriaFicha1 = new TiendaDesktop.UI.Fichas.AddCategoria();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(805, 787);
            this.panel1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pnCategorias1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 43);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(805, 744);
            this.panel3.TabIndex = 2;
            // 
            // pnCategorias1
            // 
            this.pnCategorias1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnCategorias1.Location = new System.Drawing.Point(0, 0);
            this.pnCategorias1.Name = "pnCategorias1";
            this.pnCategorias1.Padding = new System.Windows.Forms.Padding(5);
            this.pnCategorias1.Size = new System.Drawing.Size(805, 744);
            this.pnCategorias1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buscador1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(805, 43);
            this.panel2.TabIndex = 1;
            // 
            // buscador1
            // 
            this.buscador1.BackColor = System.Drawing.Color.White;
            this.buscador1.Location = new System.Drawing.Point(11, 12);
            this.buscador1.Margin = new System.Windows.Forms.Padding(2);
            this.buscador1.Name = "buscador1";
            this.buscador1.Size = new System.Drawing.Size(141, 20);
            this.buscador1.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.categoriaFicha1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(805, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(317, 787);
            this.panel4.TabIndex = 1;
            // 
            // categoriaFicha1
            // 
            this.categoriaFicha1.Dock = System.Windows.Forms.DockStyle.Top;
            this.categoriaFicha1.Location = new System.Drawing.Point(0, 0);
            this.categoriaFicha1.Name = "categoriaFicha1";
            this.categoriaFicha1.Size = new System.Drawing.Size(317, 322);
            this.categoriaFicha1.TabIndex = 0;
            // 
            // FormCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 787);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCategorias";
            this.Text = "FormCategorias";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Componentes.Buscador buscador1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private Fichas.AddCategoria categoriaFicha1;
        private Paneles.RvCategorias pnCategorias1;
    }
}