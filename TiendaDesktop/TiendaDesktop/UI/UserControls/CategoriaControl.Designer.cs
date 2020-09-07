namespace TiendaDesktop.UI.UserControls
{
    partial class CategoriaControl
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
            this.lbName = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbMaster = new System.Windows.Forms.Label();
            this.pnCategoriaUp = new System.Windows.Forms.Panel();
            this.pnBody = new System.Windows.Forms.Panel();
            this.pnButton = new System.Windows.Forms.Panel();
            this.btnMenu = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1.SuspendLayout();
            this.pnCategoriaUp.SuspendLayout();
            this.pnBody.SuspendLayout();
            this.pnButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // lbName
            // 
            this.lbName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbName.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(0, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(138, 19);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "label1";
            this.lbName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editarToolStripMenuItem,
            this.borrasToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(107, 48);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.editarToolStripMenuItem.Text = "Editar";
            // 
            // borrasToolStripMenuItem
            // 
            this.borrasToolStripMenuItem.Name = "borrasToolStripMenuItem";
            this.borrasToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.borrasToolStripMenuItem.Text = "Borrar";
            // 
            // lbMaster
            // 
            this.lbMaster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbMaster.Location = new System.Drawing.Point(0, 0);
            this.lbMaster.Name = "lbMaster";
            this.lbMaster.Size = new System.Drawing.Size(157, 13);
            this.lbMaster.TabIndex = 2;
            this.lbMaster.Text = "label1";
            // 
            // pnCategoriaUp
            // 
            this.pnCategoriaUp.Controls.Add(this.lbMaster);
            this.pnCategoriaUp.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnCategoriaUp.Font = new System.Drawing.Font("Gin and Soda Personal Use", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnCategoriaUp.Location = new System.Drawing.Point(4, 4);
            this.pnCategoriaUp.Name = "pnCategoriaUp";
            this.pnCategoriaUp.Size = new System.Drawing.Size(157, 13);
            this.pnCategoriaUp.TabIndex = 3;
            this.pnCategoriaUp.Visible = false;
            // 
            // pnBody
            // 
            this.pnBody.Controls.Add(this.lbName);
            this.pnBody.Controls.Add(this.pnButton);
            this.pnBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnBody.Location = new System.Drawing.Point(4, 17);
            this.pnBody.Name = "pnBody";
            this.pnBody.Size = new System.Drawing.Size(157, 19);
            this.pnBody.TabIndex = 4;
            // 
            // pnButton
            // 
            this.pnButton.Controls.Add(this.btnMenu);
            this.pnButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnButton.Location = new System.Drawing.Point(138, 0);
            this.pnButton.Name = "pnButton";
            this.pnButton.Padding = new System.Windows.Forms.Padding(5);
            this.pnButton.Size = new System.Drawing.Size(19, 19);
            this.pnButton.TabIndex = 3;
            this.pnButton.Visible = false;
            // 
            // btnMenu
            // 
            this.btnMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMenu.Image = global::TiendaDesktop.Properties.Resources.menu;
            this.btnMenu.Location = new System.Drawing.Point(5, 5);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(9, 9);
            this.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMenu.TabIndex = 4;
            this.btnMenu.TabStop = false;
            // 
            // ControlCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.pnBody);
            this.Controls.Add(this.pnCategoriaUp);
            this.Name = "ControlCategoria";
            this.Padding = new System.Windows.Forms.Padding(4);
            this.Size = new System.Drawing.Size(165, 40);
            this.Load += new System.EventHandler(this.ControlCategoria_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.pnCategoriaUp.ResumeLayout(false);
            this.pnBody.ResumeLayout(false);
            this.pnButton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrasToolStripMenuItem;
        private System.Windows.Forms.Label lbMaster;
        private System.Windows.Forms.Panel pnCategoriaUp;
        private System.Windows.Forms.Panel pnBody;
        private System.Windows.Forms.Panel pnButton;
        private System.Windows.Forms.PictureBox btnMenu;
    }
}
