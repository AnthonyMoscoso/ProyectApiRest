namespace TiendaDesktop.UI.Forms_Desing
{
    partial class Ficha_Categoria
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
            this.lbCategoria = new System.Windows.Forms.Label();
            this.pnTop = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.pnButtons = new System.Windows.Forms.Panel();
            this.btnAccion = new System.Windows.Forms.Button();
            this.pnDatas = new System.Windows.Forms.Panel();
            this.table = new System.Windows.Forms.TableLayoutPanel();
            this.pnSelectCategoria = new System.Windows.Forms.Panel();
            this.cbxCategorias = new System.Windows.Forms.ComboBox();
            this.lbCategoriaPrincipal = new System.Windows.Forms.Label();
            this.pnDataName = new TiendaDesktop.UI.Componentes.pnData();
            this.pnBody = new System.Windows.Forms.Panel();
            this.pnTop.SuspendLayout();
            this.pnButtons.SuspendLayout();
            this.pnDatas.SuspendLayout();
            this.table.SuspendLayout();
            this.pnSelectCategoria.SuspendLayout();
            this.pnBody.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbCategoria
            // 
            this.lbCategoria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbCategoria.Font = new System.Drawing.Font("Franchise", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCategoria.Location = new System.Drawing.Point(0, 0);
            this.lbCategoria.Name = "lbCategoria";
            this.lbCategoria.Size = new System.Drawing.Size(322, 62);
            this.lbCategoria.TabIndex = 1;
            this.lbCategoria.Text = "Categorias";
            this.lbCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnTop
            // 
            this.pnTop.Controls.Add(this.button1);
            this.pnTop.Controls.Add(this.lbCategoria);
            this.pnTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTop.Location = new System.Drawing.Point(0, 0);
            this.pnTop.Name = "pnTop";
            this.pnTop.Size = new System.Drawing.Size(322, 62);
            this.pnTop.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(199, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(8, 8);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pnButtons
            // 
            this.pnButtons.Controls.Add(this.btnAccion);
            this.pnButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnButtons.Location = new System.Drawing.Point(0, 207);
            this.pnButtons.Name = "pnButtons";
            this.pnButtons.Padding = new System.Windows.Forms.Padding(10);
            this.pnButtons.Size = new System.Drawing.Size(322, 55);
            this.pnButtons.TabIndex = 6;
            // 
            // btnAccion
            // 
            this.btnAccion.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAccion.Location = new System.Drawing.Point(202, 10);
            this.btnAccion.Name = "btnAccion";
            this.btnAccion.Size = new System.Drawing.Size(110, 35);
            this.btnAccion.TabIndex = 3;
            this.btnAccion.Text = "button2";
            this.btnAccion.UseVisualStyleBackColor = true;
            // 
            // pnDatas
            // 
            this.pnDatas.Controls.Add(this.table);
            this.pnDatas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnDatas.Location = new System.Drawing.Point(0, 0);
            this.pnDatas.Name = "pnDatas";
            this.pnDatas.Padding = new System.Windows.Forms.Padding(15);
            this.pnDatas.Size = new System.Drawing.Size(322, 207);
            this.pnDatas.TabIndex = 7;
            // 
            // table
            // 
            this.table.ColumnCount = 1;
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.table.Controls.Add(this.pnSelectCategoria, 0, 1);
            this.table.Controls.Add(this.pnDataName, 0, 0);
            this.table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.table.Location = new System.Drawing.Point(15, 15);
            this.table.Name = "table";
            this.table.Padding = new System.Windows.Forms.Padding(10);
            this.table.RowCount = 2;
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.0495F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.9505F));
            this.table.Size = new System.Drawing.Size(292, 177);
            this.table.TabIndex = 2;
            // 
            // pnSelectCategoria
            // 
            this.pnSelectCategoria.Controls.Add(this.cbxCategorias);
            this.pnSelectCategoria.Controls.Add(this.lbCategoriaPrincipal);
            this.pnSelectCategoria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnSelectCategoria.Location = new System.Drawing.Point(13, 83);
            this.pnSelectCategoria.Name = "pnSelectCategoria";
            this.pnSelectCategoria.Padding = new System.Windows.Forms.Padding(10);
            this.pnSelectCategoria.Size = new System.Drawing.Size(266, 81);
            this.pnSelectCategoria.TabIndex = 1;
            // 
            // cbxCategorias
            // 
            this.cbxCategorias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxCategorias.FormattingEnabled = true;
            this.cbxCategorias.Location = new System.Drawing.Point(10, 51);
            this.cbxCategorias.Margin = new System.Windows.Forms.Padding(9);
            this.cbxCategorias.Name = "cbxCategorias";
            this.cbxCategorias.Size = new System.Drawing.Size(246, 21);
            this.cbxCategorias.TabIndex = 1;
            // 
            // lbCategoriaPrincipal
            // 
            this.lbCategoriaPrincipal.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbCategoriaPrincipal.Font = new System.Drawing.Font("Gin and Soda Personal Use", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCategoriaPrincipal.Location = new System.Drawing.Point(10, 10);
            this.lbCategoriaPrincipal.Margin = new System.Windows.Forms.Padding(9);
            this.lbCategoriaPrincipal.Name = "lbCategoriaPrincipal";
            this.lbCategoriaPrincipal.Size = new System.Drawing.Size(246, 41);
            this.lbCategoriaPrincipal.TabIndex = 0;
            this.lbCategoriaPrincipal.Text = "Categoria principal";
            // 
            // pnDataName
            // 
            this.pnDataName.ColorTitule = System.Drawing.Color.Empty;
            this.pnDataName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnDataName.FontLabel = null;
            this.pnDataName.Imagen = null;
            this.pnDataName.IsPassword = false;
            this.pnDataName.Location = new System.Drawing.Point(12, 12);
            this.pnDataName.Margin = new System.Windows.Forms.Padding(2);
            this.pnDataName.Multiline = false;
            this.pnDataName.Name = "pnDataName";
            this.pnDataName.Size = new System.Drawing.Size(268, 66);
            this.pnDataName.TabIndex = 2;
            this.pnDataName.Texto = "";
            this.pnDataName.TextoHint = null;
            this.pnDataName.Tipo_De_Texto = TiendaDesktop.UI.Componentes.pnData.TipeText.All;
            this.pnDataName.Titule = "Nombre";
            // 
            // pnBody
            // 
            this.pnBody.Controls.Add(this.pnDatas);
            this.pnBody.Controls.Add(this.pnButtons);
            this.pnBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnBody.Location = new System.Drawing.Point(0, 62);
            this.pnBody.Name = "pnBody";
            this.pnBody.Size = new System.Drawing.Size(322, 262);
            this.pnBody.TabIndex = 13;
            // 
            // Ficha_Categoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnBody);
            this.Controls.Add(this.pnTop);
            this.Name = "Ficha_Categoria";
            this.Size = new System.Drawing.Size(322, 324);
            this.pnTop.ResumeLayout(false);
            this.pnButtons.ResumeLayout(false);
            this.pnDatas.ResumeLayout(false);
            this.table.ResumeLayout(false);
            this.pnSelectCategoria.ResumeLayout(false);
            this.pnBody.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbCategoria;
        private System.Windows.Forms.Panel pnTop;
        private System.Windows.Forms.Panel pnButtons;
        private System.Windows.Forms.Panel pnDatas;
        private System.Windows.Forms.TableLayoutPanel table;
        private System.Windows.Forms.Label lbCategoriaPrincipal;
        private System.Windows.Forms.Panel pnBody;
        public System.Windows.Forms.Button btnAccion;

        public System.Windows.Forms.Panel pnSelectCategoria;
        public System.Windows.Forms.ComboBox cbxCategorias;
        private System.Windows.Forms.Button button1;
        public Componentes.pnData pnDataName;
    }
}
