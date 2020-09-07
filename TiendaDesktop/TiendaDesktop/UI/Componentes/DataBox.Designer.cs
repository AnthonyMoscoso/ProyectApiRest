namespace TiendaDesktop.UI.Componentes
{
    partial class DataBox
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
            this.lbTitutle = new System.Windows.Forms.Label();
            this.txtData = new System.Windows.Forms.TextBox();
            this.pnData = new System.Windows.Forms.Panel();
            this.ImgPass = new System.Windows.Forms.PictureBox();
            this.pnData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgPass)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitutle
            // 
            this.lbTitutle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbTitutle.Font = new System.Drawing.Font("Sunset Boulevard", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitutle.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbTitutle.Location = new System.Drawing.Point(2, 2);
            this.lbTitutle.Name = "lbTitutle";
            this.lbTitutle.Size = new System.Drawing.Size(252, 34);
            this.lbTitutle.TabIndex = 0;
            this.lbTitutle.Text = "label1";
            this.lbTitutle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtData
            // 
            this.txtData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtData.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtData.Location = new System.Drawing.Point(0, 0);
            this.txtData.Margin = new System.Windows.Forms.Padding(0);
            this.txtData.MaxLength = 30;
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(225, 22);
            this.txtData.TabIndex = 1;
            // 
            // pnData
            // 
            this.pnData.Controls.Add(this.txtData);
            this.pnData.Controls.Add(this.ImgPass);
            this.pnData.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnData.Location = new System.Drawing.Point(2, 36);
            this.pnData.Name = "pnData";
            this.pnData.Size = new System.Drawing.Size(252, 23);
            this.pnData.TabIndex = 2;
            this.pnData.Visible = false;
            // 
            // ImgPass
            // 
            this.ImgPass.Dock = System.Windows.Forms.DockStyle.Right;
            this.ImgPass.Image = global::TiendaDesktop.Properties.Resources.eye_check;
            this.ImgPass.Location = new System.Drawing.Point(225, 0);
            this.ImgPass.Name = "ImgPass";
            this.ImgPass.Size = new System.Drawing.Size(27, 23);
            this.ImgPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImgPass.TabIndex = 3;
            this.ImgPass.TabStop = false;
            this.ImgPass.Visible = false;
            // 
            // DataBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnData);
            this.Controls.Add(this.lbTitutle);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximumSize = new System.Drawing.Size(256, 45);
            this.Name = "DataBox";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.Size = new System.Drawing.Size(256, 34);
            this.pnData.ResumeLayout(false);
            this.pnData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgPass)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbTitutle;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.Panel pnData;
        private System.Windows.Forms.PictureBox ImgPass;
    }
}
