namespace TiendaDesktop.UI
{
    partial class FormCaja
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
            this.pnContainer = new System.Windows.Forms.Panel();
            this.pnBody = new System.Windows.Forms.Panel();
            this.pnCaja = new System.Windows.Forms.Panel();
            this.pnBodyCaja = new System.Windows.Forms.Panel();
            this.rvLineaCompra = new TiendaDesktop.UI.Views.RvLineaCompra();
            this.pnDownCaja = new System.Windows.Forms.Panel();
            this.lbTotal = new System.Windows.Forms.Label();
            this.pnRigthButton = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCompra = new System.Windows.Forms.Button();
            this.pnDonw = new System.Windows.Forms.Panel();
            this.pnDownRigth = new System.Windows.Forms.Panel();
            this.pnProductToShop = new System.Windows.Forms.Panel();
            this.pnReciclerViewProducto = new System.Windows.Forms.Panel();
            this.ReciclerViewProducto = new TiendaDesktop.UI.Views.RvProductToShop();
            this.pnSearchProductos = new System.Windows.Forms.Panel();
            this.SearchProducto = new TiendaDesktop.UI.Componentes.Buscador();
            this.pnDownLeft = new System.Windows.Forms.Panel();
            this.pnCategorias = new System.Windows.Forms.Panel();
            this.rvCategorias = new TiendaDesktop.UI.Paneles.RvCategorias();
            this.pnCategoriaSeleccionada = new System.Windows.Forms.Panel();
            this.pnSeleccionada = new System.Windows.Forms.Panel();
            this.lbCategoriaSeleccionada = new System.Windows.Forms.Label();
            this.btnCancelCategoria = new System.Windows.Forms.Button();
            this.pnContainer.SuspendLayout();
            this.pnBody.SuspendLayout();
            this.pnCaja.SuspendLayout();
            this.pnBodyCaja.SuspendLayout();
            this.pnDownCaja.SuspendLayout();
            this.pnRigthButton.SuspendLayout();
            this.pnDonw.SuspendLayout();
            this.pnDownRigth.SuspendLayout();
            this.pnProductToShop.SuspendLayout();
            this.pnReciclerViewProducto.SuspendLayout();
            this.pnSearchProductos.SuspendLayout();
            this.pnDownLeft.SuspendLayout();
            this.pnCategorias.SuspendLayout();
            this.pnCategoriaSeleccionada.SuspendLayout();
            this.pnSeleccionada.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnContainer
            // 
            this.pnContainer.Controls.Add(this.pnBody);
            this.pnContainer.Controls.Add(this.pnDonw);
            this.pnContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnContainer.Location = new System.Drawing.Point(0, 0);
            this.pnContainer.Name = "pnContainer";
            this.pnContainer.Size = new System.Drawing.Size(1333, 877);
            this.pnContainer.TabIndex = 1;
            // 
            // pnBody
            // 
            this.pnBody.Controls.Add(this.pnCaja);
            this.pnBody.Controls.Add(this.pnRigthButton);
            this.pnBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnBody.Location = new System.Drawing.Point(0, 0);
            this.pnBody.Name = "pnBody";
            this.pnBody.Size = new System.Drawing.Size(1333, 503);
            this.pnBody.TabIndex = 3;
            // 
            // pnCaja
            // 
            this.pnCaja.Controls.Add(this.pnBodyCaja);
            this.pnCaja.Controls.Add(this.pnDownCaja);
            this.pnCaja.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnCaja.Location = new System.Drawing.Point(0, 0);
            this.pnCaja.Name = "pnCaja";
            this.pnCaja.Size = new System.Drawing.Size(1116, 503);
            this.pnCaja.TabIndex = 2;
            // 
            // pnBodyCaja
            // 
            this.pnBodyCaja.Controls.Add(this.rvLineaCompra);
            this.pnBodyCaja.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnBodyCaja.Location = new System.Drawing.Point(0, 0);
            this.pnBodyCaja.Name = "pnBodyCaja";
            this.pnBodyCaja.Size = new System.Drawing.Size(1116, 464);
            this.pnBodyCaja.TabIndex = 1;
            // 
            // rvLineaCompra
            // 
            this.rvLineaCompra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rvLineaCompra.Location = new System.Drawing.Point(0, 0);
            this.rvLineaCompra.Name = "rvLineaCompra";
            this.rvLineaCompra.Padding = new System.Windows.Forms.Padding(40);
            this.rvLineaCompra.Size = new System.Drawing.Size(1116, 464);
            this.rvLineaCompra.TabIndex = 0;
            // 
            // pnDownCaja
            // 
            this.pnDownCaja.Controls.Add(this.lbTotal);
            this.pnDownCaja.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnDownCaja.Location = new System.Drawing.Point(0, 464);
            this.pnDownCaja.Name = "pnDownCaja";
            this.pnDownCaja.Padding = new System.Windows.Forms.Padding(8);
            this.pnDownCaja.Size = new System.Drawing.Size(1116, 39);
            this.pnDownCaja.TabIndex = 0;
            // 
            // lbTotal
            // 
            this.lbTotal.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbTotal.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.Location = new System.Drawing.Point(979, 8);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(129, 23);
            this.lbTotal.TabIndex = 0;
            this.lbTotal.Text = "Total : 0€";
            this.lbTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnRigthButton
            // 
            this.pnRigthButton.Controls.Add(this.btnClear);
            this.pnRigthButton.Controls.Add(this.btnCompra);
            this.pnRigthButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnRigthButton.Location = new System.Drawing.Point(1116, 0);
            this.pnRigthButton.Name = "pnRigthButton";
            this.pnRigthButton.Size = new System.Drawing.Size(217, 503);
            this.pnRigthButton.TabIndex = 1;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(27, 63);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(168, 44);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "button2";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnCompra
            // 
            this.btnCompra.Location = new System.Drawing.Point(27, 12);
            this.btnCompra.Name = "btnCompra";
            this.btnCompra.Size = new System.Drawing.Size(168, 45);
            this.btnCompra.TabIndex = 0;
            this.btnCompra.Text = "button1";
            this.btnCompra.UseVisualStyleBackColor = true;
            // 
            // pnDonw
            // 
            this.pnDonw.Controls.Add(this.pnDownRigth);
            this.pnDonw.Controls.Add(this.pnDownLeft);
            this.pnDonw.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnDonw.Location = new System.Drawing.Point(0, 503);
            this.pnDonw.Name = "pnDonw";
            this.pnDonw.Size = new System.Drawing.Size(1333, 374);
            this.pnDonw.TabIndex = 0;
            // 
            // pnDownRigth
            // 
            this.pnDownRigth.Controls.Add(this.pnProductToShop);
            this.pnDownRigth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnDownRigth.Location = new System.Drawing.Point(348, 0);
            this.pnDownRigth.Name = "pnDownRigth";
            this.pnDownRigth.Size = new System.Drawing.Size(985, 374);
            this.pnDownRigth.TabIndex = 1;
            // 
            // pnProductToShop
            // 
            this.pnProductToShop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnProductToShop.Controls.Add(this.pnReciclerViewProducto);
            this.pnProductToShop.Controls.Add(this.pnSearchProductos);
            this.pnProductToShop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnProductToShop.Location = new System.Drawing.Point(0, 0);
            this.pnProductToShop.Name = "pnProductToShop";
            this.pnProductToShop.Size = new System.Drawing.Size(985, 374);
            this.pnProductToShop.TabIndex = 0;
            // 
            // pnReciclerViewProducto
            // 
            this.pnReciclerViewProducto.Controls.Add(this.ReciclerViewProducto);
            this.pnReciclerViewProducto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnReciclerViewProducto.Location = new System.Drawing.Point(0, 44);
            this.pnReciclerViewProducto.Name = "pnReciclerViewProducto";
            this.pnReciclerViewProducto.Size = new System.Drawing.Size(983, 328);
            this.pnReciclerViewProducto.TabIndex = 1;
            // 
            // ReciclerViewProducto
            // 
            this.ReciclerViewProducto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReciclerViewProducto.Location = new System.Drawing.Point(0, 0);
            this.ReciclerViewProducto.Name = "ReciclerViewProducto";
            this.ReciclerViewProducto.Padding = new System.Windows.Forms.Padding(10);
            this.ReciclerViewProducto.Size = new System.Drawing.Size(983, 328);
            this.ReciclerViewProducto.TabIndex = 0;
            // 
            // pnSearchProductos
            // 
            this.pnSearchProductos.Controls.Add(this.SearchProducto);
            this.pnSearchProductos.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnSearchProductos.Location = new System.Drawing.Point(0, 0);
            this.pnSearchProductos.Name = "pnSearchProductos";
            this.pnSearchProductos.Size = new System.Drawing.Size(983, 44);
            this.pnSearchProductos.TabIndex = 0;
            // 
            // SearchProducto
            // 
            this.SearchProducto.BackColor = System.Drawing.Color.White;
            this.SearchProducto.Location = new System.Drawing.Point(14, 12);
            this.SearchProducto.Margin = new System.Windows.Forms.Padding(2);
            this.SearchProducto.Name = "SearchProducto";
            this.SearchProducto.Size = new System.Drawing.Size(147, 22);
            this.SearchProducto.TabIndex = 0;
            // 
            // pnDownLeft
            // 
            this.pnDownLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnDownLeft.Controls.Add(this.pnCategorias);
            this.pnDownLeft.Controls.Add(this.pnCategoriaSeleccionada);
            this.pnDownLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnDownLeft.Location = new System.Drawing.Point(0, 0);
            this.pnDownLeft.Name = "pnDownLeft";
            this.pnDownLeft.Size = new System.Drawing.Size(348, 374);
            this.pnDownLeft.TabIndex = 0;
            // 
            // pnCategorias
            // 
            this.pnCategorias.Controls.Add(this.rvCategorias);
            this.pnCategorias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnCategorias.Location = new System.Drawing.Point(0, 44);
            this.pnCategorias.Name = "pnCategorias";
            this.pnCategorias.Size = new System.Drawing.Size(346, 328);
            this.pnCategorias.TabIndex = 1;
            // 
            // rvCategorias
            // 
            this.rvCategorias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rvCategorias.Location = new System.Drawing.Point(0, 0);
            this.rvCategorias.Name = "rvCategorias";
            this.rvCategorias.Padding = new System.Windows.Forms.Padding(5);
            this.rvCategorias.Size = new System.Drawing.Size(346, 328);
            this.rvCategorias.TabIndex = 0;
            // 
            // pnCategoriaSeleccionada
            // 
            this.pnCategoriaSeleccionada.Controls.Add(this.pnSeleccionada);
            this.pnCategoriaSeleccionada.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnCategoriaSeleccionada.Location = new System.Drawing.Point(0, 0);
            this.pnCategoriaSeleccionada.Name = "pnCategoriaSeleccionada";
            this.pnCategoriaSeleccionada.Padding = new System.Windows.Forms.Padding(7);
            this.pnCategoriaSeleccionada.Size = new System.Drawing.Size(346, 44);
            this.pnCategoriaSeleccionada.TabIndex = 0;
            // 
            // pnSeleccionada
            // 
            this.pnSeleccionada.Controls.Add(this.lbCategoriaSeleccionada);
            this.pnSeleccionada.Controls.Add(this.btnCancelCategoria);
            this.pnSeleccionada.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnSeleccionada.Location = new System.Drawing.Point(7, 7);
            this.pnSeleccionada.Name = "pnSeleccionada";
            this.pnSeleccionada.Padding = new System.Windows.Forms.Padding(3);
            this.pnSeleccionada.Size = new System.Drawing.Size(155, 30);
            this.pnSeleccionada.TabIndex = 1;
            this.pnSeleccionada.Visible = false;
            // 
            // lbCategoriaSeleccionada
            // 
            this.lbCategoriaSeleccionada.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbCategoriaSeleccionada.Location = new System.Drawing.Point(3, 3);
            this.lbCategoriaSeleccionada.Name = "lbCategoriaSeleccionada";
            this.lbCategoriaSeleccionada.Size = new System.Drawing.Size(126, 24);
            this.lbCategoriaSeleccionada.TabIndex = 0;
            this.lbCategoriaSeleccionada.Text = "etiqueta";
            this.lbCategoriaSeleccionada.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnCancelCategoria
            // 
            this.btnCancelCategoria.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCancelCategoria.Enabled = false;
            this.btnCancelCategoria.Location = new System.Drawing.Point(129, 3);
            this.btnCancelCategoria.Name = "btnCancelCategoria";
            this.btnCancelCategoria.Size = new System.Drawing.Size(23, 24);
            this.btnCancelCategoria.TabIndex = 1;
            this.btnCancelCategoria.Text = "button3";
            this.btnCancelCategoria.UseVisualStyleBackColor = true;
            // 
            // FormCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 877);
            this.Controls.Add(this.pnContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCaja";
            this.Text = "FormCaja";
            this.pnContainer.ResumeLayout(false);
            this.pnBody.ResumeLayout(false);
            this.pnCaja.ResumeLayout(false);
            this.pnBodyCaja.ResumeLayout(false);
            this.pnDownCaja.ResumeLayout(false);
            this.pnRigthButton.ResumeLayout(false);
            this.pnDonw.ResumeLayout(false);
            this.pnDownRigth.ResumeLayout(false);
            this.pnProductToShop.ResumeLayout(false);
            this.pnReciclerViewProducto.ResumeLayout(false);
            this.pnSearchProductos.ResumeLayout(false);
            this.pnDownLeft.ResumeLayout(false);
            this.pnCategorias.ResumeLayout(false);
            this.pnCategoriaSeleccionada.ResumeLayout(false);
            this.pnSeleccionada.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnContainer;
        private System.Windows.Forms.Panel pnBody;
        private System.Windows.Forms.Panel pnCaja;
        private System.Windows.Forms.Panel pnRigthButton;
        private System.Windows.Forms.Panel pnDonw;
        private System.Windows.Forms.Panel pnDownRigth;
        private System.Windows.Forms.Panel pnProductToShop;
        private System.Windows.Forms.Panel pnReciclerViewProducto;
        private System.Windows.Forms.Panel pnSearchProductos;
        private System.Windows.Forms.Panel pnDownLeft;
        private System.Windows.Forms.Panel pnCategorias;
        private System.Windows.Forms.Panel pnCategoriaSeleccionada;
        private System.Windows.Forms.Panel pnBodyCaja;
        private System.Windows.Forms.Panel pnDownCaja;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCompra;
        private Componentes.Buscador SearchProducto;
        private Paneles.RvCategorias rvCategorias;
        private Views.RvLineaCompra rvLineaCompra;
        private Views.RvProductToShop ReciclerViewProducto;
        private System.Windows.Forms.Panel pnSeleccionada;
        private System.Windows.Forms.Label lbCategoriaSeleccionada;
        private System.Windows.Forms.Button btnCancelCategoria;
    }
}