namespace TiendaDesktop.UI
{
    partial class FormProducto
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
            this.rvProducts1 = new TiendaDesktop.UI.Paneles.RvProducts();
            this.rvCategorias1 = new TiendaDesktop.UI.Paneles.RvCategorias();
            this.pnTop.SuspendLayout();
            this.pnContainer.SuspendLayout();
            this.pnBody.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(1133, 10);
            // 
            // pnTop
            // 
            this.pnTop.Size = new System.Drawing.Size(1250, 51);
            // 
            // paginator
            // 
            this.paginator.Location = new System.Drawing.Point(0, 660);
            this.paginator.Size = new System.Drawing.Size(1250, 40);
            // 
            // pnContainer
            // 
            this.pnContainer.Controls.Add(this.rvProducts1);
            this.pnContainer.Controls.Add(this.rvCategorias1);
            this.pnContainer.Size = new System.Drawing.Size(1250, 660);
            // 
            // pnBody
            // 
            this.pnBody.Size = new System.Drawing.Size(1250, 700);
            // 
            // rvProducts1
            // 
            this.rvProducts1.AutoScroll = true;
            this.rvProducts1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rvProducts1.Location = new System.Drawing.Point(0, 0);
            this.rvProducts1.Name = "rvProducts1";
            this.rvProducts1.Padding = new System.Windows.Forms.Padding(10);
            this.rvProducts1.Size = new System.Drawing.Size(1034, 660);
            this.rvProducts1.TabIndex = 0;
            // 
            // rvCategorias1
            // 
            this.rvCategorias1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rvCategorias1.Dock = System.Windows.Forms.DockStyle.Right;
            this.rvCategorias1.Location = new System.Drawing.Point(1034, 0);
            this.rvCategorias1.Name = "rvCategorias1";
            this.rvCategorias1.Padding = new System.Windows.Forms.Padding(5);
            this.rvCategorias1.Size = new System.Drawing.Size(216, 660);
            this.rvCategorias1.TabIndex = 1;
            // 
            // FormProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 751);
            this.Name = "FormProducto";
            this.Text = "FormInventario";
            this.pnTop.ResumeLayout(false);
            this.pnContainer.ResumeLayout(false);
            this.pnBody.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Paneles.RvProducts rvProducts1;
        private Paneles.RvCategorias rvCategorias1;
    }
}