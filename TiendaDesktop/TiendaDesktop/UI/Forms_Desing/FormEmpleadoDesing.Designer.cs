namespace TiendaDesktop.UI.Forms_Desing
{
    partial class FormEmpleadoDesing
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
            this.pnPermisos = new System.Windows.Forms.Panel();
            this.pnRol = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.rvRols1 = new TiendaDesktop.UI.View.RvRols();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnChoisse = new System.Windows.Forms.FlowLayoutPanel();
            this.lbRolSeleccionado = new System.Windows.Forms.Label();
            this.pnLabelRol = new System.Windows.Forms.Panel();
            this.lbRol = new System.Windows.Forms.Label();
            this.pnDni = new System.Windows.Forms.Panel();
            this.tableDni = new System.Windows.Forms.TableLayoutPanel();
            this.pnDataDni = new TiendaDesktop.UI.Componentes.pnData();
            this.pnDate = new System.Windows.Forms.Panel();
            this.pnDatePicker = new System.Windows.Forms.Panel();
            this.dtFechaContratacion = new System.Windows.Forms.DateTimePicker();
            this.pnNameDate = new System.Windows.Forms.Panel();
            this.lbTituleDate = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.pnCentral.SuspendLayout();
            this.pnDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
            this.pnLeft.SuspendLayout();
            this.pnPermisos.SuspendLayout();
            this.pnRol.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnLabelRol.SuspendLayout();
            this.pnDni.SuspendLayout();
            this.tableDni.SuspendLayout();
            this.pnDate.SuspendLayout();
            this.pnDatePicker.SuspendLayout();
            this.pnNameDate.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnCentral
            // 
            this.pnCentral.Controls.Add(this.pnPermisos);
            this.pnCentral.Controls.Add(this.pnDni);
            this.pnCentral.Size = new System.Drawing.Size(924, 764);
            this.pnCentral.Controls.SetChildIndex(this.pnDatos, 0);
            this.pnCentral.Controls.SetChildIndex(this.pnDni, 0);
            this.pnCentral.Controls.SetChildIndex(this.pnPermisos, 0);
            this.pnCentral.Controls.SetChildIndex(this.pnTopDireccion, 0);
            this.pnCentral.Controls.SetChildIndex(this.pnDataDireccion, 0);
            // 
            // pnContenDatos
            // 
            this.pnContenDatos.Padding = new System.Windows.Forms.Padding(20, 20, 20, 0);
            this.pnContenDatos.Size = new System.Drawing.Size(907, 281);
            // 
            // pnDataDireccion
            // 
            this.pnDataDireccion.Location = new System.Drawing.Point(0, 645);
            this.pnDataDireccion.Size = new System.Drawing.Size(907, 192);
            // 
            // pnTopDireccion
            // 
            this.pnTopDireccion.Location = new System.Drawing.Point(0, 604);
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
            this.pnLeft.Controls.Add(this.panel3);
            this.pnLeft.Size = new System.Drawing.Size(256, 764);
            this.pnLeft.Controls.SetChildIndex(this.panel3, 0);
            // 
            // pnPermisos
            // 
            this.pnPermisos.Controls.Add(this.pnRol);
            this.pnPermisos.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnPermisos.Location = new System.Drawing.Point(0, 433);
            this.pnPermisos.Name = "pnPermisos";
            this.pnPermisos.Size = new System.Drawing.Size(907, 171);
            this.pnPermisos.TabIndex = 2;
            // 
            // pnRol
            // 
            this.pnRol.Controls.Add(this.panel4);
            this.pnRol.Controls.Add(this.pnLabelRol);
            this.pnRol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnRol.Location = new System.Drawing.Point(0, 0);
            this.pnRol.Name = "pnRol";
            this.pnRol.Size = new System.Drawing.Size(907, 171);
            this.pnRol.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.rvRols1);
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 48);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(907, 123);
            this.panel4.TabIndex = 0;
            // 
            // rvRols1
            // 
            this.rvRols1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rvRols1.Location = new System.Drawing.Point(0, 49);
            this.rvRols1.Name = "rvRols1";
            this.rvRols1.Padding = new System.Windows.Forms.Padding(42, 10, 10, 10);
            this.rvRols1.Size = new System.Drawing.Size(907, 74);
            this.rvRols1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnChoisse);
            this.panel1.Controls.Add(this.lbRolSeleccionado);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(35, 10, 10, 10);
            this.panel1.Size = new System.Drawing.Size(907, 49);
            this.panel1.TabIndex = 2;
            // 
            // pnChoisse
            // 
            this.pnChoisse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnChoisse.Location = new System.Drawing.Point(172, 10);
            this.pnChoisse.Name = "pnChoisse";
            this.pnChoisse.Size = new System.Drawing.Size(725, 29);
            this.pnChoisse.TabIndex = 1;
            // 
            // lbRolSeleccionado
            // 
            this.lbRolSeleccionado.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbRolSeleccionado.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRolSeleccionado.Location = new System.Drawing.Point(35, 10);
            this.lbRolSeleccionado.Name = "lbRolSeleccionado";
            this.lbRolSeleccionado.Size = new System.Drawing.Size(137, 29);
            this.lbRolSeleccionado.TabIndex = 2;
            this.lbRolSeleccionado.Text = "Rol Seleccionado :";
            this.lbRolSeleccionado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnLabelRol
            // 
            this.pnLabelRol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pnLabelRol.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnLabelRol.Controls.Add(this.lbRol);
            this.pnLabelRol.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnLabelRol.Location = new System.Drawing.Point(0, 0);
            this.pnLabelRol.Name = "pnLabelRol";
            this.pnLabelRol.Padding = new System.Windows.Forms.Padding(30, 10, 10, 10);
            this.pnLabelRol.Size = new System.Drawing.Size(907, 48);
            this.pnLabelRol.TabIndex = 1;
            // 
            // lbRol
            // 
            this.lbRol.AutoSize = true;
            this.lbRol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbRol.Font = new System.Drawing.Font("Gin and Soda Personal Use", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRol.Location = new System.Drawing.Point(30, 10);
            this.lbRol.Name = "lbRol";
            this.lbRol.Size = new System.Drawing.Size(41, 18);
            this.lbRol.TabIndex = 0;
            this.lbRol.Text = "Rol";
            // 
            // pnDni
            // 
            this.pnDni.Controls.Add(this.tableDni);
            this.pnDni.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnDni.Location = new System.Drawing.Point(0, 328);
            this.pnDni.Name = "pnDni";
            this.pnDni.Padding = new System.Windows.Forms.Padding(20, 0, 20, 20);
            this.pnDni.Size = new System.Drawing.Size(907, 105);
            this.pnDni.TabIndex = 7;
            // 
            // tableDni
            // 
            this.tableDni.ColumnCount = 2;
            this.tableDni.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableDni.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableDni.Controls.Add(this.pnDataDni, 0, 0);
            this.tableDni.Controls.Add(this.pnDate, 1, 0);
            this.tableDni.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableDni.Location = new System.Drawing.Point(20, 0);
            this.tableDni.Name = "tableDni";
            this.tableDni.Padding = new System.Windows.Forms.Padding(7);
            this.tableDni.RowCount = 1;
            this.tableDni.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableDni.Size = new System.Drawing.Size(867, 85);
            this.tableDni.TabIndex = 0;
            // 
            // pnDataDni
            // 
            this.pnDataDni.ColorTitule = System.Drawing.Color.Empty;
            this.pnDataDni.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnDataDni.Font = new System.Drawing.Font("Cambria", 9F);
            this.pnDataDni.FontLabel = new System.Drawing.Font("Gin and Soda Personal Use", 11.25F);
            this.pnDataDni.Imagen = null;
            this.pnDataDni.IsPassword = false;
            this.pnDataDni.Location = new System.Drawing.Point(9, 9);
            this.pnDataDni.Margin = new System.Windows.Forms.Padding(2);
            this.pnDataDni.Multiline = false;
            this.pnDataDni.Name = "pnDataDni";
            this.pnDataDni.Padding = new System.Windows.Forms.Padding(7, 0, 7, 7);
            this.pnDataDni.Size = new System.Drawing.Size(422, 67);
            this.pnDataDni.TabIndex = 0;
            this.pnDataDni.Texto = "";
            this.pnDataDni.TextoHint = null;
            this.pnDataDni.Tipo_De_Texto = TiendaDesktop.UI.Componentes.pnData.TipeText.All;
            this.pnDataDni.Titule = "DNI";
            // 
            // pnDate
            // 
            this.pnDate.Controls.Add(this.pnDatePicker);
            this.pnDate.Controls.Add(this.pnNameDate);
            this.pnDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnDate.Location = new System.Drawing.Point(436, 10);
            this.pnDate.Name = "pnDate";
            this.pnDate.Size = new System.Drawing.Size(421, 65);
            this.pnDate.TabIndex = 1;
            this.pnDate.Visible = false;
            // 
            // pnDatePicker
            // 
            this.pnDatePicker.Controls.Add(this.dtFechaContratacion);
            this.pnDatePicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnDatePicker.Location = new System.Drawing.Point(0, 24);
            this.pnDatePicker.Name = "pnDatePicker";
            this.pnDatePicker.Padding = new System.Windows.Forms.Padding(10);
            this.pnDatePicker.Size = new System.Drawing.Size(421, 41);
            this.pnDatePicker.TabIndex = 2;
            // 
            // dtFechaContratacion
            // 
            this.dtFechaContratacion.Dock = System.Windows.Forms.DockStyle.Left;
            this.dtFechaContratacion.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFechaContratacion.Location = new System.Drawing.Point(10, 10);
            this.dtFechaContratacion.Name = "dtFechaContratacion";
            this.dtFechaContratacion.Size = new System.Drawing.Size(241, 22);
            this.dtFechaContratacion.TabIndex = 0;
            // 
            // pnNameDate
            // 
            this.pnNameDate.Controls.Add(this.lbTituleDate);
            this.pnNameDate.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnNameDate.Font = new System.Drawing.Font("Gin and Soda Personal Use", 9.75F);
            this.pnNameDate.Location = new System.Drawing.Point(0, 0);
            this.pnNameDate.Name = "pnNameDate";
            this.pnNameDate.Padding = new System.Windows.Forms.Padding(9, 3, 3, 3);
            this.pnNameDate.Size = new System.Drawing.Size(421, 24);
            this.pnNameDate.TabIndex = 1;
            // 
            // lbTituleDate
            // 
            this.lbTituleDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbTituleDate.Font = new System.Drawing.Font("Gin and Soda Personal Use", 11.25F);
            this.lbTituleDate.Location = new System.Drawing.Point(9, 3);
            this.lbTituleDate.Name = "lbTituleDate";
            this.lbTituleDate.Size = new System.Drawing.Size(409, 18);
            this.lbTituleDate.TabIndex = 0;
            this.lbTituleDate.Text = "Fecha contratacion";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 697);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(25, 15, 25, 15);
            this.panel3.Size = new System.Drawing.Size(256, 67);
            this.panel3.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(25, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(206, 37);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FormEmpleadoDesing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 813);
            this.Name = "FormEmpleadoDesing";
            this.pnCentral.ResumeLayout(false);
            this.pnDatos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
            this.pnLeft.ResumeLayout(false);
            this.pnPermisos.ResumeLayout(false);
            this.pnRol.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.pnLabelRol.ResumeLayout(false);
            this.pnLabelRol.PerformLayout();
            this.pnDni.ResumeLayout(false);
            this.tableDni.ResumeLayout(false);
            this.pnDate.ResumeLayout(false);
            this.pnDatePicker.ResumeLayout(false);
            this.pnNameDate.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnPermisos;
        private System.Windows.Forms.Label lbRol;
        private System.Windows.Forms.Panel pnLabelRol;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbRolSeleccionado;
        public View.RvRols rvRols1;
 
        public System.Windows.Forms.FlowLayoutPanel pnChoisse;
        public System.Windows.Forms.TableLayoutPanel tableDni;
        public Componentes.pnData pnDataDni;
        public System.Windows.Forms.Panel pnDni;
        public System.Windows.Forms.Panel pnRol;
        public System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel pnNameDate;
        private System.Windows.Forms.Label lbTituleDate;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pnDatePicker;
        public System.Windows.Forms.Panel pnDate;
        public System.Windows.Forms.DateTimePicker dtFechaContratacion;
    }
}