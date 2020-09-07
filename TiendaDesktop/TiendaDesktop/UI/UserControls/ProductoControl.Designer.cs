namespace TiendaDesktop.UI.UserControls
{
    partial class ProductoControl
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.imgProducto = new System.Windows.Forms.PictureBox();
            this.lbName = new System.Windows.Forms.Label();
            this.pnBody = new System.Windows.Forms.Panel();
            this.pnImage = new System.Windows.Forms.Panel();
            this.pnDown = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pnName = new System.Windows.Forms.Panel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desactivarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.imgProducto)).BeginInit();
            this.pnBody.SuspendLayout();
            this.pnImage.SuspendLayout();
            this.pnDown.SuspendLayout();
            this.panel4.SuspendLayout();
            this.pnName.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imgProducto
            // 
            this.imgProducto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imgProducto.Location = new System.Drawing.Point(10, 10);
            this.imgProducto.Name = "imgProducto";
            this.imgProducto.Size = new System.Drawing.Size(170, 208);
            this.imgProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgProducto.TabIndex = 0;
            this.imgProducto.TabStop = false;
            // 
            // lbName
            // 
            this.lbName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbName.Location = new System.Drawing.Point(0, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(170, 36);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "label1";
            this.lbName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnBody
            // 
            this.pnBody.Controls.Add(this.pnImage);
            this.pnBody.Controls.Add(this.pnDown);
            this.pnBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnBody.Location = new System.Drawing.Point(0, 0);
            this.pnBody.Name = "pnBody";
            this.pnBody.Padding = new System.Windows.Forms.Padding(5);
            this.pnBody.Size = new System.Drawing.Size(200, 294);
            this.pnBody.TabIndex = 2;
            // 
            // pnImage
            // 
            this.pnImage.Controls.Add(this.imgProducto);
            this.pnImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnImage.Location = new System.Drawing.Point(5, 5);
            this.pnImage.Name = "pnImage";
            this.pnImage.Padding = new System.Windows.Forms.Padding(10);
            this.pnImage.Size = new System.Drawing.Size(190, 228);
            this.pnImage.TabIndex = 2;
            // 
            // pnDown
            // 
            this.pnDown.Controls.Add(this.panel4);
            this.pnDown.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnDown.Location = new System.Drawing.Point(5, 233);
            this.pnDown.Name = "pnDown";
            this.pnDown.Size = new System.Drawing.Size(190, 56);
            this.pnDown.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.pnName);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(10);
            this.panel4.Size = new System.Drawing.Size(190, 56);
            this.panel4.TabIndex = 2;
            // 
            // pnName
            // 
            this.pnName.Controls.Add(this.lbName);
            this.pnName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnName.Location = new System.Drawing.Point(10, 10);
            this.pnName.Name = "pnName";
            this.pnName.Size = new System.Drawing.Size(170, 36);
            this.pnName.TabIndex = 2;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editarToolStripMenuItem,
            this.visualizarToolStripMenuItem,
            this.desactivarToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(129, 70);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.editarToolStripMenuItem.Text = "Editar";
            // 
            // visualizarToolStripMenuItem
            // 
            this.visualizarToolStripMenuItem.Name = "visualizarToolStripMenuItem";
            this.visualizarToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.visualizarToolStripMenuItem.Text = "Visualizar";
            // 
            // desactivarToolStripMenuItem
            // 
            this.desactivarToolStripMenuItem.Name = "desactivarToolStripMenuItem";
            this.desactivarToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.desactivarToolStripMenuItem.Text = "Desactivar";
            // 
            // ProductoControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnBody);
            this.Name = "ProductoControl";
            this.Size = new System.Drawing.Size(200, 294);
            ((System.ComponentModel.ISupportInitialize)(this.imgProducto)).EndInit();
            this.pnBody.ResumeLayout(false);
            this.pnImage.ResumeLayout(false);
            this.pnDown.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.pnName.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imgProducto;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Panel pnBody;
        private System.Windows.Forms.Panel pnImage;
        private System.Windows.Forms.Panel pnDown;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel pnName;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualizarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem desactivarToolStripMenuItem;
    }
}
