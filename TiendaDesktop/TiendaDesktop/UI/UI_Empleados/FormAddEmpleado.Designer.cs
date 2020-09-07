namespace TiendaDesktop.UI
{
    partial class FormAddEmpleado
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
            this.tableDni = new System.Windows.Forms.TableLayoutPanel();
            this.pnDataDni = new TiendaDesktop.UI.Componentes.pnData();
            this.pnRol.SuspendLayout();
            this.panel4.SuspendLayout();
            this.pnCentral.SuspendLayout();
            this.pnDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
            this.SuspendLayout();
            // 
            // rvRols1
            // 
            this.rvRols1.Size = new System.Drawing.Size(907, 74);
            // 
            // pnDni
            // 
            this.pnDni.Size = new System.Drawing.Size(907, 105);
            // 
            // pnRol
            // 
            this.pnRol.Size = new System.Drawing.Size(907, 171);
            // 
            // panel4
            // 
            this.panel4.Size = new System.Drawing.Size(907, 123);
            // 
            // pnCentral
            // 
            this.pnCentral.Size = new System.Drawing.Size(924, 764);
            // 
            // pnContenDatos
            // 
            this.pnContenDatos.Size = new System.Drawing.Size(907, 281);
            // 
            // pnDataDireccion
            // 
            this.pnDataDireccion.Size = new System.Drawing.Size(907, 192);
            // 
            // pnTopDireccion
            // 
            this.pnTopDireccion.Size = new System.Drawing.Size(907, 41);
            // 
            // pnDatos
            // 
            this.pnDatos.Size = new System.Drawing.Size(907, 328);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(856, 12);
            // 
            // pnDataCalle
            // 
            this.pnDataCalle.Size = new System.Drawing.Size(841, 60);
            // 
            // pnLeft
            // 
            this.pnLeft.Size = new System.Drawing.Size(256, 764);
            // 
            // tableDni
            // 
            this.tableDni.ColumnCount = 2;
            this.tableDni.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableDni.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableDni.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableDni.Location = new System.Drawing.Point(20, 0);
            this.tableDni.Name = "tableDni";
            this.tableDni.Padding = new System.Windows.Forms.Padding(7);
            this.tableDni.RowCount = 1;
            this.tableDni.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableDni.Size = new System.Drawing.Size(884, 85);
            this.tableDni.TabIndex = 0;
            // 
            // pnDataDni
            // 
            this.pnDataDni.ColorTitule = System.Drawing.Color.Empty;
            this.pnDataDni.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnDataDni.Font = new System.Drawing.Font("Gin and Soda Personal Use", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnDataDni.FontLabel = null;
            this.pnDataDni.Imagen = null;
            this.pnDataDni.IsPassword = false;
            this.pnDataDni.Location = new System.Drawing.Point(9, 9);
            this.pnDataDni.Margin = new System.Windows.Forms.Padding(2);
            this.pnDataDni.Multiline = false;
            this.pnDataDni.Name = "pnDataDni";
            this.pnDataDni.Padding = new System.Windows.Forms.Padding(7, 0, 7, 7);
            this.pnDataDni.Size = new System.Drawing.Size(431, 67);
            this.pnDataDni.TabIndex = 0;
            this.pnDataDni.Texto = "";
            this.pnDataDni.TextoHint = null;
            this.pnDataDni.Tipo_De_Texto = TiendaDesktop.UI.Componentes.pnData.TipeText.All;
            this.pnDataDni.Titule = "DNI";
            // 
            // FormAddEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 813);
            this.Name = "FormAddEmpleado";
            this.pnRol.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.pnCentral.ResumeLayout(false);
            this.pnDatos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnDni;
        private System.Windows.Forms.TableLayoutPanel tableDni;
        private Componentes.pnData pnDataDni;
    }
}