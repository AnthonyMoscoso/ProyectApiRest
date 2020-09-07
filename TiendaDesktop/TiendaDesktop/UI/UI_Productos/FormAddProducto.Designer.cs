namespace TiendaDesktop.UI
{
    partial class FormAddProducto
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
            this.cbxCategorias = new System.Windows.Forms.ComboBox();
            this.pnBody = new System.Windows.Forms.Panel();
            this.pnDatas = new System.Windows.Forms.Panel();
            this.pnContenedor = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableDatas = new System.Windows.Forms.TableLayoutPanel();
            this.pnSave = new System.Windows.Forms.Panel();
            this.pnInventario = new TiendaDesktop.UI.Componentes.pnData();
            this.pnVenta = new TiendaDesktop.UI.Componentes.pnData();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnCategorias = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pnCompra = new TiendaDesktop.UI.Componentes.pnData();
            this.pnDescuento = new TiendaDesktop.UI.Componentes.pnData();
            this.pnName = new TiendaDesktop.UI.Componentes.pnData();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnImageControl = new System.Windows.Forms.Panel();
            this.imageFile1 = new TiendaDesktop.UI.Componentes.ImageFile();
            this.pnBody.SuspendLayout();
            this.pnDatas.SuspendLayout();
            this.pnContenedor.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableDatas.SuspendLayout();
            this.pnSave.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
            this.panel3.SuspendLayout();
            this.pnCategorias.SuspendLayout();
            this.pnImageControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbxCategorias
            // 
            this.cbxCategorias.FormattingEnabled = true;
            this.cbxCategorias.Location = new System.Drawing.Point(27, 43);
            this.cbxCategorias.Name = "cbxCategorias";
            this.cbxCategorias.Size = new System.Drawing.Size(265, 21);
            this.cbxCategorias.TabIndex = 4;
            // 
            // pnBody
            // 
            this.pnBody.BackColor = System.Drawing.Color.White;
            this.pnBody.Controls.Add(this.pnDatas);
            this.pnBody.Controls.Add(this.pnImageControl);
            this.pnBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnBody.Location = new System.Drawing.Point(0, 49);
            this.pnBody.Name = "pnBody";
            this.pnBody.Size = new System.Drawing.Size(1121, 661);
            this.pnBody.TabIndex = 11;
            // 
            // pnDatas
            // 
            this.pnDatas.Controls.Add(this.pnContenedor);
            this.pnDatas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnDatas.Location = new System.Drawing.Point(296, 0);
            this.pnDatas.Name = "pnDatas";
            this.pnDatas.Size = new System.Drawing.Size(825, 661);
            this.pnDatas.TabIndex = 11;
            // 
            // pnContenedor
            // 
            this.pnContenedor.Controls.Add(this.panel1);
            this.pnContenedor.Controls.Add(this.panel2);
            this.pnContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnContenedor.Location = new System.Drawing.Point(0, 0);
            this.pnContenedor.Name = "pnContenedor";
            this.pnContenedor.Padding = new System.Windows.Forms.Padding(20);
            this.pnContenedor.Size = new System.Drawing.Size(825, 661);
            this.pnContenedor.TabIndex = 10;
            this.pnContenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.panel7_Paint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableDatas);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(20, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(785, 364);
            this.panel1.TabIndex = 8;
            // 
            // tableDatas
            // 
            this.tableDatas.ColumnCount = 2;
            this.tableDatas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableDatas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableDatas.Controls.Add(this.pnSave, 1, 0);
            this.tableDatas.Controls.Add(this.panel3, 0, 0);
            this.tableDatas.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableDatas.Location = new System.Drawing.Point(0, 0);
            this.tableDatas.Name = "tableDatas";
            this.tableDatas.RowCount = 1;
            this.tableDatas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableDatas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 364F));
            this.tableDatas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 364F));
            this.tableDatas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 364F));
            this.tableDatas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 364F));
            this.tableDatas.Size = new System.Drawing.Size(767, 364);
            this.tableDatas.TabIndex = 7;
            // 
            // pnSave
            // 
            this.pnSave.Controls.Add(this.pnInventario);
            this.pnSave.Controls.Add(this.pnVenta);
            this.pnSave.Controls.Add(this.panel4);
            this.pnSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnSave.Location = new System.Drawing.Point(386, 3);
            this.pnSave.Name = "pnSave";
            this.pnSave.Size = new System.Drawing.Size(378, 358);
            this.pnSave.TabIndex = 7;
            // 
            // pnInventario
            // 
            this.pnInventario.ColorTitule = System.Drawing.Color.Empty;
            this.pnInventario.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnInventario.FontLabel = null;
            this.pnInventario.Imagen = null;
            this.pnInventario.IsPassword = false;
            this.pnInventario.Location = new System.Drawing.Point(0, 181);
            this.pnInventario.Margin = new System.Windows.Forms.Padding(2);
            this.pnInventario.Multiline = false;
            this.pnInventario.Name = "pnInventario";
            this.pnInventario.Size = new System.Drawing.Size(378, 66);
            this.pnInventario.TabIndex = 12;
            this.pnInventario.Texto = "";
            this.pnInventario.TextoHint = null;
            this.pnInventario.Tipo_De_Texto = TiendaDesktop.UI.Componentes.pnData.TipeText.ONLY_NUMBERS;
            this.pnInventario.Titule = "Inventario";
            // 
            // pnVenta
            // 
            this.pnVenta.ColorTitule = System.Drawing.Color.Empty;
            this.pnVenta.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnVenta.FontLabel = null;
            this.pnVenta.Imagen = null;
            this.pnVenta.IsPassword = false;
            this.pnVenta.Location = new System.Drawing.Point(0, 103);
            this.pnVenta.Margin = new System.Windows.Forms.Padding(2);
            this.pnVenta.Multiline = false;
            this.pnVenta.Name = "pnVenta";
            this.pnVenta.Size = new System.Drawing.Size(378, 78);
            this.pnVenta.TabIndex = 9;
            this.pnVenta.Texto = "";
            this.pnVenta.TextoHint = null;
            this.pnVenta.Tipo_De_Texto = TiendaDesktop.UI.Componentes.pnData.TipeText.ONLY_NUMBERS;
            this.pnVenta.Titule = "Precio Venta";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnSave);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(378, 103);
            this.panel4.TabIndex = 14;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnSave.Image = global::TiendaDesktop.Properties.Resources.save__1_;
            this.btnSave.Location = new System.Drawing.Point(349, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(26, 56);
            this.btnSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSave.TabIndex = 13;
            this.btnSave.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pnCategorias);
            this.panel3.Controls.Add(this.pnCompra);
            this.panel3.Controls.Add(this.pnDescuento);
            this.panel3.Controls.Add(this.pnName);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(377, 358);
            this.panel3.TabIndex = 8;
            // 
            // pnCategorias
            // 
            this.pnCategorias.Controls.Add(this.label2);
            this.pnCategorias.Controls.Add(this.cbxCategorias);
            this.pnCategorias.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnCategorias.Location = new System.Drawing.Point(0, 233);
            this.pnCategorias.Name = "pnCategorias";
            this.pnCategorias.Padding = new System.Windows.Forms.Padding(10);
            this.pnCategorias.Size = new System.Drawing.Size(377, 95);
            this.pnCategorias.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Categoria";
            // 
            // pnCompra
            // 
            this.pnCompra.ColorTitule = System.Drawing.Color.Empty;
            this.pnCompra.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnCompra.FontLabel = null;
            this.pnCompra.Imagen = null;
            this.pnCompra.IsPassword = false;
            this.pnCompra.Location = new System.Drawing.Point(0, 156);
            this.pnCompra.Margin = new System.Windows.Forms.Padding(2);
            this.pnCompra.Multiline = false;
            this.pnCompra.Name = "pnCompra";
            this.pnCompra.Padding = new System.Windows.Forms.Padding(10);
            this.pnCompra.Size = new System.Drawing.Size(377, 77);
            this.pnCompra.TabIndex = 8;
            this.pnCompra.Texto = "";
            this.pnCompra.TextoHint = null;
            this.pnCompra.Tipo_De_Texto = TiendaDesktop.UI.Componentes.pnData.TipeText.ONLY_NUMBERS;
            this.pnCompra.Titule = "Precio Compra";
            // 
            // pnDescuento
            // 
            this.pnDescuento.ColorTitule = System.Drawing.Color.Empty;
            this.pnDescuento.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnDescuento.FontLabel = null;
            this.pnDescuento.Imagen = null;
            this.pnDescuento.IsPassword = false;
            this.pnDescuento.Location = new System.Drawing.Point(0, 78);
            this.pnDescuento.Margin = new System.Windows.Forms.Padding(2);
            this.pnDescuento.Multiline = false;
            this.pnDescuento.Name = "pnDescuento";
            this.pnDescuento.Padding = new System.Windows.Forms.Padding(10);
            this.pnDescuento.Size = new System.Drawing.Size(377, 78);
            this.pnDescuento.TabIndex = 0;
            this.pnDescuento.Texto = "";
            this.pnDescuento.TextoHint = null;
            this.pnDescuento.Tipo_De_Texto = TiendaDesktop.UI.Componentes.pnData.TipeText.All;
            this.pnDescuento.Titule = "Descuento";
            this.pnDescuento.Visible = false;
            // 
            // pnName
            // 
            this.pnName.ColorTitule = System.Drawing.Color.Empty;
            this.pnName.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnName.FontLabel = null;
            this.pnName.Imagen = null;
            this.pnName.IsPassword = false;
            this.pnName.Location = new System.Drawing.Point(0, 0);
            this.pnName.Margin = new System.Windows.Forms.Padding(2);
            this.pnName.Multiline = false;
            this.pnName.Name = "pnName";
            this.pnName.Padding = new System.Windows.Forms.Padding(10);
            this.pnName.Size = new System.Drawing.Size(377, 78);
            this.pnName.TabIndex = 7;
            this.pnName.Texto = "";
            this.pnName.TextoHint = null;
            this.pnName.Tipo_De_Texto = TiendaDesktop.UI.Componentes.pnData.TipeText.All;
            this.pnName.Titule = "Nombre";
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(20, 384);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(785, 257);
            this.panel2.TabIndex = 0;
            // 
            // pnImageControl
            // 
            this.pnImageControl.Controls.Add(this.imageFile1);
            this.pnImageControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnImageControl.Location = new System.Drawing.Point(0, 0);
            this.pnImageControl.Name = "pnImageControl";
            this.pnImageControl.Size = new System.Drawing.Size(296, 661);
            this.pnImageControl.TabIndex = 10;
            // 
            // imageFile1
            // 
            this.imageFile1.Location = new System.Drawing.Point(11, 20);
            this.imageFile1.Name = "imageFile1";
            this.imageFile1.Size = new System.Drawing.Size(265, 346);
            this.imageFile1.TabIndex = 0;
            // 
            // FormAddProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 710);
            this.Controls.Add(this.pnBody);
            this.Name = "FormAddProducto";
            this.Text = "FormProducto";
            this.Controls.SetChildIndex(this.pnBody, 0);
            this.pnBody.ResumeLayout(false);
            this.pnDatas.ResumeLayout(false);
            this.pnContenedor.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tableDatas.ResumeLayout(false);
            this.pnSave.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
            this.panel3.ResumeLayout(false);
            this.pnCategorias.ResumeLayout(false);
            this.pnCategorias.PerformLayout();
            this.pnImageControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cbxCategorias;
        private System.Windows.Forms.Panel pnBody;
        private System.Windows.Forms.Panel pnDatas;
        private System.Windows.Forms.Panel pnContenedor;
        private System.Windows.Forms.TableLayoutPanel tableDatas;
        private System.Windows.Forms.Panel pnCategorias;
        private System.Windows.Forms.Panel pnImageControl;
        private Componentes.pnData pnName;
        private Componentes.pnData pnCompra;
        private Componentes.pnData pnVenta;
        private System.Windows.Forms.Label label2;
        private Componentes.pnData pnDescuento;
        private System.Windows.Forms.Panel pnSave;
        private System.Windows.Forms.PictureBox btnSave;
        private Componentes.pnData pnInventario;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private Componentes.ImageFile imageFile1;
    }
}