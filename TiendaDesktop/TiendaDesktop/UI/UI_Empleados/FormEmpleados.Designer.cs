namespace TiendaDesktop.UI
{
    partial class FormEmpleados
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
            this.rvContainer = new TiendaDesktop.UI.Paneles.RvEmpleados();
            this.pnTop.SuspendLayout();
            this.pnContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnContainer
            // 
            this.pnContainer.Controls.Add(this.rvContainer);
            // 
            // rvContainer
            // 
            this.rvContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rvContainer.Location = new System.Drawing.Point(0, 0);
            this.rvContainer.Name = "rvContainer";
            this.rvContainer.Padding = new System.Windows.Forms.Padding(10);
            this.rvContainer.Size = new System.Drawing.Size(1256, 722);
            this.rvContainer.TabIndex = 0;
            // 
            // FormEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1256, 813);
            this.Name = "FormEmpleados";
            this.pnTop.ResumeLayout(false);
            this.pnContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Paneles.RvEmpleados rvContainer;
    }
}