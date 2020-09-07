namespace TiendaDesktop.UI.Componentes
{
    partial class ImageFile
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
            this.panel10 = new System.Windows.Forms.Panel();
            this.pnImage = new System.Windows.Forms.Panel();
            this.btnCancelImage = new System.Windows.Forms.Button();
            this.txtRutaImage = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel10.SuspendLayout();
            this.pnImage.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.pnImage);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(0, 0);
            this.panel10.Name = "panel10";
            this.panel10.Padding = new System.Windows.Forms.Padding(15);
            this.panel10.Size = new System.Drawing.Size(254, 271);
            this.panel10.TabIndex = 4;
            // 
            // pnImage
            // 
            this.pnImage.BackgroundImage = global::TiendaDesktop.Properties.Resources.NOT_IMAGE;
            this.pnImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnImage.Controls.Add(this.btnCancelImage);
            this.pnImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnImage.Location = new System.Drawing.Point(15, 15);
            this.pnImage.Name = "pnImage";
            this.pnImage.Padding = new System.Windows.Forms.Padding(4);
            this.pnImage.Size = new System.Drawing.Size(224, 241);
            this.pnImage.TabIndex = 0;
            // 
            // btnCancelImage
            // 
            this.btnCancelImage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCancelImage.Enabled = false;
            this.btnCancelImage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnCancelImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelImage.Location = new System.Drawing.Point(195, 3);
            this.btnCancelImage.Name = "btnCancelImage";
            this.btnCancelImage.Size = new System.Drawing.Size(25, 23);
            this.btnCancelImage.TabIndex = 0;
            this.btnCancelImage.Text = "X";
            this.btnCancelImage.UseVisualStyleBackColor = true;
            this.btnCancelImage.Visible = false;
            // 
            // txtRutaImage
            // 
            this.txtRutaImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRutaImage.Location = new System.Drawing.Point(15, 15);
            this.txtRutaImage.Name = "txtRutaImage";
            this.txtRutaImage.Size = new System.Drawing.Size(224, 20);
            this.txtRutaImage.TabIndex = 3;
            this.txtRutaImage.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel10);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(254, 336);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtRutaImage);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 271);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(15);
            this.panel2.Size = new System.Drawing.Size(254, 65);
            this.panel2.TabIndex = 5;
            // 
            // ImageFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "ImageFile";
            this.Size = new System.Drawing.Size(254, 336);
            this.panel10.ResumeLayout(false);
            this.pnImage.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel pnImage;
        private System.Windows.Forms.Button btnCancelImage;
        private System.Windows.Forms.TextBox txtRutaImage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}
