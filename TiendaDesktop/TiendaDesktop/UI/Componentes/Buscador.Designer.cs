namespace TiendaDesktop.UI.Componentes
{
    partial class Buscador
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
            this.pnCancel = new System.Windows.Forms.Panel();
            this.ptbxCancel = new System.Windows.Forms.PictureHover();
            this.pnLupa = new System.Windows.Forms.Panel();
            this.ptbxLupa = new System.Windows.Forms.PictureHover();
            this.pnSearch = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.HintText();
            this.pnCancel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbxCancel)).BeginInit();
            this.pnLupa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbxLupa)).BeginInit();
            this.pnSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnCancel
            // 
            this.pnCancel.BackColor = System.Drawing.Color.White;
            this.pnCancel.Controls.Add(this.ptbxCancel);
            this.pnCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnCancel.Location = new System.Drawing.Point(113, 0);
            this.pnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.pnCancel.Name = "pnCancel";
            this.pnCancel.Padding = new System.Windows.Forms.Padding(2);
            this.pnCancel.Size = new System.Drawing.Size(21, 23);
            this.pnCancel.TabIndex = 3;
            this.pnCancel.Visible = false;
            // 
            // ptbxCancel
            // 
            this.ptbxCancel.BackColor = System.Drawing.Color.White;
            this.ptbxCancel.Clicked = false;
            this.ptbxCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ptbxCancel.Hover = false;
            this.ptbxCancel.Image = global::TiendaDesktop.Properties.Resources.alert;
            this.ptbxCancel.ImageHover = null;
            this.ptbxCancel.Location = new System.Drawing.Point(2, 2);
            this.ptbxCancel.MargingOut = new System.Windows.Forms.Padding(2);
            this.ptbxCancel.Name = "ptbxCancel";
            this.ptbxCancel.Size = new System.Drawing.Size(17, 19);
            this.ptbxCancel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbxCancel.TabIndex = 1;
            this.ptbxCancel.TabStop = false;
            // 
            // pnLupa
            // 
            this.pnLupa.BackColor = System.Drawing.Color.White;
            this.pnLupa.Controls.Add(this.ptbxLupa);
            this.pnLupa.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnLupa.Location = new System.Drawing.Point(0, 0);
            this.pnLupa.Margin = new System.Windows.Forms.Padding(2);
            this.pnLupa.Name = "pnLupa";
            this.pnLupa.Padding = new System.Windows.Forms.Padding(2);
            this.pnLupa.Size = new System.Drawing.Size(22, 23);
            this.pnLupa.TabIndex = 4;
            // 
            // ptbxLupa
            // 
            this.ptbxLupa.Clicked = false;
            this.ptbxLupa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ptbxLupa.Hover = false;
            this.ptbxLupa.ImageHover = null;
            this.ptbxLupa.Location = new System.Drawing.Point(2, 2);
            this.ptbxLupa.MargingOut = new System.Windows.Forms.Padding(2);
            this.ptbxLupa.Name = "ptbxLupa";
            this.ptbxLupa.Size = new System.Drawing.Size(18, 19);
            this.ptbxLupa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbxLupa.TabIndex = 2;
            this.ptbxLupa.TabStop = false;
            // 
            // pnSearch
            // 
            this.pnSearch.BackColor = System.Drawing.Color.White;
            this.pnSearch.Controls.Add(this.txtSearch);
            this.pnSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnSearch.Location = new System.Drawing.Point(22, 0);
            this.pnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.pnSearch.Name = "pnSearch";
            this.pnSearch.Padding = new System.Windows.Forms.Padding(2);
            this.pnSearch.Size = new System.Drawing.Size(91, 23);
            this.pnSearch.TabIndex = 5;
            // 
            // txtSearch
            // 
            this.txtSearch.AutoCompleteCustomSource.AddRange(new string[] {
            "bbbbbbbbbb",
            "b",
            "b",
            "bfgdfg",
            "bbbdffdgdf",
            "bfdgfg",
            "bfdghfhdf"});
            this.txtSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtSearch.BackColor = System.Drawing.Color.White;
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSearch.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.Gray;
            this.txtSearch.Hint = "Search";
            this.txtSearch.Location = new System.Drawing.Point(2, 2);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearch.MaxLength = 80;
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(87, 19);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.Text = "Search";
            this.txtSearch.Tipo_De_Texto = System.Windows.Forms.HintText.TipeText.All;
            // 
            // Buscador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnSearch);
            this.Controls.Add(this.pnLupa);
            this.Controls.Add(this.pnCancel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Buscador";
            this.Size = new System.Drawing.Size(134, 23);
            this.pnCancel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbxCancel)).EndInit();
            this.pnLupa.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbxLupa)).EndInit();
            this.pnSearch.ResumeLayout(false);
            this.pnSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.HintText txtSearch;
        private System.Windows.Forms.PictureHover ptbxCancel;
        private System.Windows.Forms.PictureHover ptbxLupa;
        private System.Windows.Forms.Panel pnCancel;
        private System.Windows.Forms.Panel pnLupa;
        private System.Windows.Forms.Panel pnSearch;
    }
}