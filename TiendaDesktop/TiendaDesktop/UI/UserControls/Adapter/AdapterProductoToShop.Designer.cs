namespace TiendaDesktop.UI.UserControls.Adapter
{
    partial class AdapterProductoToShop
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
            this.ptImg = new System.Windows.Forms.PictureBox();
            this.lbName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ptImg)).BeginInit();
            this.SuspendLayout();
            // 
            // ptImg
            // 
            this.ptImg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ptImg.Location = new System.Drawing.Point(7, 7);
            this.ptImg.Name = "ptImg";
            this.ptImg.Size = new System.Drawing.Size(56, 62);
            this.ptImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptImg.TabIndex = 0;
            this.ptImg.TabStop = false;
            // 
            // lbName
            // 
            this.lbName.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(7, 69);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(56, 25);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "label1";
            this.lbName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AdapterProductoToShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ptImg);
            this.Controls.Add(this.lbName);
            this.Name = "AdapterProductoToShop";
            this.Padding = new System.Windows.Forms.Padding(7);
            this.Size = new System.Drawing.Size(70, 101);
            ((System.ComponentModel.ISupportInitialize)(this.ptImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ptImg;
        private System.Windows.Forms.Label lbName;
    }
}
