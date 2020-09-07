namespace TiendaDesktop.UI.Fichas
{
    partial class FormCompra
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
            this.pnLeft = new System.Windows.Forms.Panel();
            this.pnCarrito = new System.Windows.Forms.Panel();
            this.rvLineaCompra1 = new TiendaDesktop.UI.Views.RvLineaCompra();
            this.pnDownCarrito = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lbFinal = new System.Windows.Forms.Label();
            this.lbDescuento = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.pnRight = new System.Windows.Forms.Panel();
            this.pnContainerDatos = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.rbAcumular = new System.Windows.Forms.RadioButton();
            this.rbUsar = new System.Windows.Forms.RadioButton();
            this.lbDescuentoPersona = new System.Windows.Forms.Label();
            this.pnDescuento = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.PictureBox();
            this.pnEmail = new TiendaDesktop.UI.Componentes.pnData();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pnBtnCompra = new System.Windows.Forms.Panel();
            this.btnCompra = new System.Windows.Forms.Button();
            this.pnCheckMetodosPago = new System.Windows.Forms.Panel();
            this.pnMetodosPago = new System.Windows.Forms.Panel();
            this.tbMetodoPago = new System.Windows.Forms.TableLayoutPanel();
            this.rbTarjeta = new System.Windows.Forms.RadioButton();
            this.rbEfectivo = new System.Windows.Forms.RadioButton();
            this.panel11 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnBody.SuspendLayout();
            this.pnLeft.SuspendLayout();
            this.pnCarrito.SuspendLayout();
            this.pnDownCarrito.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.pnRight.SuspendLayout();
            this.pnContainerDatos.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnDescuento.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnBtnCompra.SuspendLayout();
            this.pnCheckMetodosPago.SuspendLayout();
            this.pnMetodosPago.SuspendLayout();
            this.tbMetodoPago.SuspendLayout();
            this.panel11.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnBody
            // 
            this.pnBody.Controls.Add(this.pnLeft);
            this.pnBody.Controls.Add(this.pnRight);
            this.pnBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnBody.Location = new System.Drawing.Point(0, 49);
            this.pnBody.Name = "pnBody";
            this.pnBody.Size = new System.Drawing.Size(1198, 783);
            this.pnBody.TabIndex = 1;
            // 
            // pnLeft
            // 
            this.pnLeft.Controls.Add(this.pnCarrito);
            this.pnLeft.Controls.Add(this.pnDownCarrito);
            this.pnLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnLeft.Location = new System.Drawing.Point(0, 0);
            this.pnLeft.Name = "pnLeft";
            this.pnLeft.Size = new System.Drawing.Size(740, 783);
            this.pnLeft.TabIndex = 0;
            // 
            // pnCarrito
            // 
            this.pnCarrito.Controls.Add(this.rvLineaCompra1);
            this.pnCarrito.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnCarrito.Location = new System.Drawing.Point(0, 0);
            this.pnCarrito.Name = "pnCarrito";
            this.pnCarrito.Size = new System.Drawing.Size(740, 701);
            this.pnCarrito.TabIndex = 0;
            // 
            // rvLineaCompra1
            // 
            this.rvLineaCompra1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rvLineaCompra1.Location = new System.Drawing.Point(0, 0);
            this.rvLineaCompra1.Name = "rvLineaCompra1";
            this.rvLineaCompra1.Padding = new System.Windows.Forms.Padding(10);
            this.rvLineaCompra1.Size = new System.Drawing.Size(740, 701);
            this.rvLineaCompra1.TabIndex = 0;
            // 
            // pnDownCarrito
            // 
            this.pnDownCarrito.Controls.Add(this.tableLayoutPanel2);
            this.pnDownCarrito.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnDownCarrito.Location = new System.Drawing.Point(0, 701);
            this.pnDownCarrito.Name = "pnDownCarrito";
            this.pnDownCarrito.Padding = new System.Windows.Forms.Padding(10);
            this.pnDownCarrito.Size = new System.Drawing.Size(740, 82);
            this.pnDownCarrito.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.lbFinal, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.lbDescuento, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lbTotal, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(541, 10);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(189, 62);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // lbFinal
            // 
            this.lbFinal.AutoSize = true;
            this.lbFinal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbFinal.Location = new System.Drawing.Point(3, 40);
            this.lbFinal.Name = "lbFinal";
            this.lbFinal.Size = new System.Drawing.Size(183, 22);
            this.lbFinal.TabIndex = 1;
            this.lbFinal.Text = "0€";
            this.lbFinal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbDescuento
            // 
            this.lbDescuento.AutoSize = true;
            this.lbDescuento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbDescuento.Location = new System.Drawing.Point(3, 20);
            this.lbDescuento.Name = "lbDescuento";
            this.lbDescuento.Size = new System.Drawing.Size(183, 20);
            this.lbDescuento.TabIndex = 2;
            this.lbDescuento.Text = "0€";
            this.lbDescuento.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbTotal
            // 
            this.lbTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbTotal.Location = new System.Drawing.Point(3, 0);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(183, 20);
            this.lbTotal.TabIndex = 0;
            this.lbTotal.Text = "0€";
            this.lbTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnRight
            // 
            this.pnRight.Controls.Add(this.pnContainerDatos);
            this.pnRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnRight.Location = new System.Drawing.Point(740, 0);
            this.pnRight.Name = "pnRight";
            this.pnRight.Padding = new System.Windows.Forms.Padding(10);
            this.pnRight.Size = new System.Drawing.Size(458, 783);
            this.pnRight.TabIndex = 1;
            // 
            // pnContainerDatos
            // 
            this.pnContainerDatos.Controls.Add(this.panel3);
            this.pnContainerDatos.Controls.Add(this.pnDescuento);
            this.pnContainerDatos.Controls.Add(this.pnBtnCompra);
            this.pnContainerDatos.Controls.Add(this.pnCheckMetodosPago);
            this.pnContainerDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnContainerDatos.Location = new System.Drawing.Point(10, 10);
            this.pnContainerDatos.Name = "pnContainerDatos";
            this.pnContainerDatos.Size = new System.Drawing.Size(438, 763);
            this.pnContainerDatos.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tableLayoutPanel1);
            this.panel3.Controls.Add(this.lbDescuentoPersona);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 225);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(438, 85);
            this.panel3.TabIndex = 5;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.rbAcumular, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.rbUsar, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(188, 13);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(235, 26);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // rbAcumular
            // 
            this.rbAcumular.AutoSize = true;
            this.rbAcumular.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbAcumular.Location = new System.Drawing.Point(120, 3);
            this.rbAcumular.Name = "rbAcumular";
            this.rbAcumular.Size = new System.Drawing.Size(112, 20);
            this.rbAcumular.TabIndex = 2;
            this.rbAcumular.Text = "radioButton3";
            this.rbAcumular.UseVisualStyleBackColor = true;
            // 
            // rbUsar
            // 
            this.rbUsar.AutoSize = true;
            this.rbUsar.Checked = true;
            this.rbUsar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbUsar.Location = new System.Drawing.Point(3, 3);
            this.rbUsar.Name = "rbUsar";
            this.rbUsar.Size = new System.Drawing.Size(111, 20);
            this.rbUsar.TabIndex = 0;
            this.rbUsar.TabStop = true;
            this.rbUsar.Text = "radioButton1";
            this.rbUsar.UseVisualStyleBackColor = true;
            // 
            // lbDescuentoPersona
            // 
            this.lbDescuentoPersona.AutoSize = true;
            this.lbDescuentoPersona.Location = new System.Drawing.Point(25, 20);
            this.lbDescuentoPersona.Name = "lbDescuentoPersona";
            this.lbDescuentoPersona.Size = new System.Drawing.Size(35, 13);
            this.lbDescuentoPersona.TabIndex = 2;
            this.lbDescuentoPersona.Text = "label3";
            // 
            // pnDescuento
            // 
            this.pnDescuento.Controls.Add(this.panel2);
            this.pnDescuento.Controls.Add(this.panel1);
            this.pnDescuento.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnDescuento.Location = new System.Drawing.Point(0, 97);
            this.pnDescuento.Name = "pnDescuento";
            this.pnDescuento.Size = new System.Drawing.Size(438, 128);
            this.pnDescuento.TabIndex = 0;
            this.pnDescuento.Paint += new System.Windows.Forms.PaintEventHandler(this.panel8_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Controls.Add(this.pnEmail);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(438, 85);
            this.panel2.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Image = global::TiendaDesktop.Properties.Resources.alert;
            this.btnSearch.Location = new System.Drawing.Point(346, 39);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(22, 22);
            this.btnSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSearch.TabIndex = 3;
            this.btnSearch.TabStop = false;
            // 
            // pnEmail
            // 
            this.pnEmail.ColorTitule = System.Drawing.Color.Empty;
            this.pnEmail.FontLabel = null;
            this.pnEmail.Imagen = null;
            this.pnEmail.IsPassword = false;
            this.pnEmail.Location = new System.Drawing.Point(19, 14);
            this.pnEmail.Margin = new System.Windows.Forms.Padding(2);
            this.pnEmail.Multiline = false;
            this.pnEmail.Name = "pnEmail";
            this.pnEmail.Size = new System.Drawing.Size(283, 66);
            this.pnEmail.TabIndex = 2;
            this.pnEmail.Texto = "";
            this.pnEmail.TextoHint = null;
            this.pnEmail.Tipo_De_Texto = TiendaDesktop.UI.Componentes.pnData.TipeText.All;
            this.pnEmail.Titule = null;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(438, 43);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "label2";
            // 
            // pnBtnCompra
            // 
            this.pnBtnCompra.Controls.Add(this.btnCompra);
            this.pnBtnCompra.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnBtnCompra.Location = new System.Drawing.Point(0, 699);
            this.pnBtnCompra.Name = "pnBtnCompra";
            this.pnBtnCompra.Padding = new System.Windows.Forms.Padding(15);
            this.pnBtnCompra.Size = new System.Drawing.Size(438, 64);
            this.pnBtnCompra.TabIndex = 1;
            // 
            // btnCompra
            // 
            this.btnCompra.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCompra.Location = new System.Drawing.Point(309, 15);
            this.btnCompra.Name = "btnCompra";
            this.btnCompra.Size = new System.Drawing.Size(114, 34);
            this.btnCompra.TabIndex = 0;
            this.btnCompra.Text = "button1";
            this.btnCompra.UseVisualStyleBackColor = true;
            // 
            // pnCheckMetodosPago
            // 
            this.pnCheckMetodosPago.Controls.Add(this.pnMetodosPago);
            this.pnCheckMetodosPago.Controls.Add(this.panel11);
            this.pnCheckMetodosPago.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnCheckMetodosPago.Location = new System.Drawing.Point(0, 0);
            this.pnCheckMetodosPago.Name = "pnCheckMetodosPago";
            this.pnCheckMetodosPago.Size = new System.Drawing.Size(438, 97);
            this.pnCheckMetodosPago.TabIndex = 0;
            // 
            // pnMetodosPago
            // 
            this.pnMetodosPago.Controls.Add(this.tbMetodoPago);
            this.pnMetodosPago.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMetodosPago.Location = new System.Drawing.Point(0, 33);
            this.pnMetodosPago.Name = "pnMetodosPago";
            this.pnMetodosPago.Padding = new System.Windows.Forms.Padding(40, 15, 40, 15);
            this.pnMetodosPago.Size = new System.Drawing.Size(438, 64);
            this.pnMetodosPago.TabIndex = 5;
            // 
            // tbMetodoPago
            // 
            this.tbMetodoPago.ColumnCount = 2;
            this.tbMetodoPago.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbMetodoPago.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbMetodoPago.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbMetodoPago.Controls.Add(this.rbTarjeta, 1, 0);
            this.tbMetodoPago.Controls.Add(this.rbEfectivo, 0, 0);
            this.tbMetodoPago.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbMetodoPago.Location = new System.Drawing.Point(40, 15);
            this.tbMetodoPago.Name = "tbMetodoPago";
            this.tbMetodoPago.RowCount = 1;
            this.tbMetodoPago.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbMetodoPago.Size = new System.Drawing.Size(358, 34);
            this.tbMetodoPago.TabIndex = 3;
            // 
            // rbTarjeta
            // 
            this.rbTarjeta.AutoSize = true;
            this.rbTarjeta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbTarjeta.Location = new System.Drawing.Point(182, 3);
            this.rbTarjeta.Name = "rbTarjeta";
            this.rbTarjeta.Size = new System.Drawing.Size(173, 28);
            this.rbTarjeta.TabIndex = 2;
            this.rbTarjeta.Text = "radioButton3";
            this.rbTarjeta.UseVisualStyleBackColor = true;
            // 
            // rbEfectivo
            // 
            this.rbEfectivo.AutoSize = true;
            this.rbEfectivo.Checked = true;
            this.rbEfectivo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbEfectivo.Location = new System.Drawing.Point(3, 3);
            this.rbEfectivo.Name = "rbEfectivo";
            this.rbEfectivo.Size = new System.Drawing.Size(173, 28);
            this.rbEfectivo.TabIndex = 0;
            this.rbEfectivo.TabStop = true;
            this.rbEfectivo.Text = "radioButton1";
            this.rbEfectivo.UseVisualStyleBackColor = true;
            // 
            // panel11
            // 
            this.panel11.AutoSize = true;
            this.panel11.Controls.Add(this.label1);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel11.Location = new System.Drawing.Point(0, 0);
            this.panel11.Name = "panel11";
            this.panel11.Padding = new System.Windows.Forms.Padding(10);
            this.panel11.Size = new System.Drawing.Size(438, 33);
            this.panel11.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Formas de Pago";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FormCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 832);
            this.Controls.Add(this.pnBody);
            this.Name = "FormCompra";
            this.Controls.SetChildIndex(this.pnBody, 0);
            this.pnBody.ResumeLayout(false);
            this.pnLeft.ResumeLayout(false);
            this.pnCarrito.ResumeLayout(false);
            this.pnDownCarrito.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.pnRight.ResumeLayout(false);
            this.pnContainerDatos.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.pnDescuento.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnBtnCompra.ResumeLayout(false);
            this.pnCheckMetodosPago.ResumeLayout(false);
            this.pnCheckMetodosPago.PerformLayout();
            this.pnMetodosPago.ResumeLayout(false);
            this.tbMetodoPago.ResumeLayout(false);
            this.tbMetodoPago.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnBody;
        private System.Windows.Forms.Panel pnLeft;
        private System.Windows.Forms.Panel pnRight;
        private System.Windows.Forms.Panel pnCarrito;
        private System.Windows.Forms.Panel pnContainerDatos;
        private System.Windows.Forms.Panel pnDownCarrito;
        private System.Windows.Forms.Panel pnDescuento;
        private System.Windows.Forms.Panel pnBtnCompra;
        private System.Windows.Forms.Panel pnCheckMetodosPago;
        private Views.RvLineaCompra rvLineaCompra1;
        private System.Windows.Forms.Panel pnMetodosPago;
        private System.Windows.Forms.TableLayoutPanel tbMetodoPago;
        private System.Windows.Forms.RadioButton rbEfectivo;
        private System.Windows.Forms.RadioButton rbTarjeta;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Button btnCompra;
        private System.Windows.Forms.Label lbDescuentoPersona;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lbFinal;
        private System.Windows.Forms.Label lbDescuento;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RadioButton rbAcumular;
        private System.Windows.Forms.RadioButton rbUsar;
        private System.Windows.Forms.PictureBox btnSearch;
        private Componentes.pnData pnEmail;
    }
}
