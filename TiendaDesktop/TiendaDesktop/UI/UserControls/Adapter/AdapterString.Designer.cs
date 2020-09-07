namespace TiendaDesktop.UI.UserControls.Adapter
{
    partial class AdapterString
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
            this.pnBody = new System.Windows.Forms.Panel();
            this.lbName = new System.Windows.Forms.Label();
            this.pnImage = new System.Windows.Forms.Panel();
            this.ptImage = new System.Windows.Forms.PictureBox();
            this.pnBody.SuspendLayout();
            this.pnImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pnBody
            // 
            this.pnBody.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnBody.Controls.Add(this.lbName);
            this.pnBody.Controls.Add(this.pnImage);
            this.pnBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnBody.Location = new System.Drawing.Point(8, 8);
            this.pnBody.Name = "pnBody";
            this.pnBody.Size = new System.Drawing.Size(163, 40);
            this.pnBody.TabIndex = 0;
            // 
            // lbName
            // 
            this.lbName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbName.Location = new System.Drawing.Point(40, 0);
            this.lbName.Name = "lbName";
            this.lbName.Padding = new System.Windows.Forms.Padding(5);
            this.lbName.Size = new System.Drawing.Size(121, 38);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "label1";
            this.lbName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnImage
            // 
            this.pnImage.Controls.Add(this.ptImage);
            this.pnImage.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnImage.Location = new System.Drawing.Point(0, 0);
            this.pnImage.Name = "pnImage";
            this.pnImage.Padding = new System.Windows.Forms.Padding(4);
            this.pnImage.Size = new System.Drawing.Size(40, 38);
            this.pnImage.TabIndex = 0;
            // 
            // ptImage
            // 
            this.ptImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ptImage.Location = new System.Drawing.Point(4, 4);
            this.ptImage.Name = "ptImage";
            this.ptImage.Padding = new System.Windows.Forms.Padding(2);
            this.ptImage.Size = new System.Drawing.Size(32, 30);
            this.ptImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptImage.TabIndex = 1;
            this.ptImage.TabStop = false;
            // 
            // AdapterString
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnBody);
            this.Name = "AdapterString";
            this.Padding = new System.Windows.Forms.Padding(8);
            this.Size = new System.Drawing.Size(179, 56);
            this.pnBody.ResumeLayout(false);
            this.pnImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnBody;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Panel pnImage;
        private System.Windows.Forms.PictureBox ptImage;
    }
}
