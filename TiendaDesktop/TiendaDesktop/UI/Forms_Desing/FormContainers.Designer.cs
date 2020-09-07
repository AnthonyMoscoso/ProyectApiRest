namespace TiendaDesktop.UI.Forms_Desing
{
    partial class FormContainers
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
            this.pnTop = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.Searcher = new TiendaDesktop.UI.Componentes.Buscador();
            this.pnBody = new System.Windows.Forms.Panel();
            this.pnContainer = new System.Windows.Forms.Panel();
            this.paginator = new TiendaDesktop.UI.Componentes.pnPaginate();
            this.pnTop.SuspendLayout();
            this.pnBody.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnTop
            // 
            this.pnTop.Controls.Add(this.btnAdd);
            this.pnTop.Controls.Add(this.Searcher);
            this.pnTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTop.Location = new System.Drawing.Point(0, 0);
            this.pnTop.Name = "pnTop";
            this.pnTop.Padding = new System.Windows.Forms.Padding(10);
            this.pnTop.Size = new System.Drawing.Size(1256, 51);
            this.pnTop.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAdd.Location = new System.Drawing.Point(1139, 10);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(107, 31);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "button1";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // Searcher
            // 
            this.Searcher.BackColor = System.Drawing.Color.White;
            this.Searcher.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Searcher.Location = new System.Drawing.Point(23, 12);
            this.Searcher.Margin = new System.Windows.Forms.Padding(2);
            this.Searcher.Name = "Searcher";
            this.Searcher.Size = new System.Drawing.Size(140, 21);
            this.Searcher.TabIndex = 0;
            // 
            // pnBody
            // 
            this.pnBody.Controls.Add(this.pnContainer);
            this.pnBody.Controls.Add(this.paginator);
            this.pnBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnBody.Location = new System.Drawing.Point(0, 51);
            this.pnBody.Name = "pnBody";
            this.pnBody.Size = new System.Drawing.Size(1256, 762);
            this.pnBody.TabIndex = 1;
            // 
            // pnContainer
            // 
            this.pnContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnContainer.Location = new System.Drawing.Point(0, 0);
            this.pnContainer.Name = "pnContainer";
            this.pnContainer.Size = new System.Drawing.Size(1256, 722);
            this.pnContainer.TabIndex = 2;
            // 
            // paginator
            // 
            this.paginator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.paginator.Location = new System.Drawing.Point(0, 722);
            this.paginator.Maxpag = 1;
            this.paginator.Name = "paginator";
            this.paginator.Size = new System.Drawing.Size(1256, 40);
            this.paginator.TabIndex = 1;
            // 
            // FormContainers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1256, 813);
            this.Controls.Add(this.pnBody);
            this.Controls.Add(this.pnTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormContainers";
            this.Text = "FormEmpleados";
            this.pnTop.ResumeLayout(false);
            this.pnBody.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Button btnAdd;
        public System.Windows.Forms.Panel pnTop;
        public Componentes.Buscador Searcher;
        public Componentes.pnPaginate paginator;
        public System.Windows.Forms.Panel pnContainer;
        public System.Windows.Forms.Panel pnBody;
    }
}