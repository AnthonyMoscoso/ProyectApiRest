namespace TiendaDesktop.UI
{
    partial class FormPersona
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
            this.pnCentral = new System.Windows.Forms.Panel();
            this.pnDataDireccion = new System.Windows.Forms.Panel();
            this.tableDireccion = new System.Windows.Forms.TableLayoutPanel();
            this.pnColumnDown = new System.Windows.Forms.Panel();
            this.pnDataCalle = new TiendaDesktop.UI.Componentes.pnData();
            this.pnColumnTop = new System.Windows.Forms.Panel();
            this.tableDatosDireccion = new System.Windows.Forms.TableLayoutPanel();
            this.pnCodigoPostal = new TiendaDesktop.UI.Componentes.pnData();
            this.pnPoblacion = new TiendaDesktop.UI.Componentes.pnData();
            this.pnTopDireccion = new System.Windows.Forms.Panel();
            this.lbDireccion = new System.Windows.Forms.Label();
            this.pnDatos = new System.Windows.Forms.Panel();
            this.pnContenDatos = new System.Windows.Forms.Panel();
            this.tableDatos = new System.Windows.Forms.TableLayoutPanel();
            this.pnDataNombre = new TiendaDesktop.UI.Componentes.pnData();
            this.pnDataApellido = new TiendaDesktop.UI.Componentes.pnData();
            this.pnDataEmail = new TiendaDesktop.UI.Componentes.pnData();
            this.pnDataPhone = new TiendaDesktop.UI.Componentes.pnData();
            this.pnDataUsername = new TiendaDesktop.UI.Componentes.pnData();
            this.pnDataPass = new TiendaDesktop.UI.Componentes.pnData();
            this.pnLabelDatos = new System.Windows.Forms.Panel();
            this.lbDatos = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.PictureBox();
            this.pnLeft = new System.Windows.Forms.Panel();
            this.imageFile1 = new TiendaDesktop.UI.Componentes.ImageFile();
            this.pnBody = new System.Windows.Forms.Panel();
            this.pnCentral.SuspendLayout();
            this.pnDataDireccion.SuspendLayout();
            this.tableDireccion.SuspendLayout();
            this.pnColumnDown.SuspendLayout();
            this.pnColumnTop.SuspendLayout();
            this.tableDatosDireccion.SuspendLayout();
            this.pnTopDireccion.SuspendLayout();
            this.pnDatos.SuspendLayout();
            this.pnContenDatos.SuspendLayout();
            this.tableDatos.SuspendLayout();
            this.pnLabelDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
            this.pnLeft.SuspendLayout();
            this.pnBody.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnCentral
            // 
            this.pnCentral.AutoScroll = true;
            this.pnCentral.Controls.Add(this.pnDataDireccion);
            this.pnCentral.Controls.Add(this.pnTopDireccion);
            this.pnCentral.Controls.Add(this.pnDatos);
            this.pnCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnCentral.Location = new System.Drawing.Point(256, 0);
            this.pnCentral.Name = "pnCentral";
            this.pnCentral.Size = new System.Drawing.Size(918, 740);
            this.pnCentral.TabIndex = 1;
            // 
            // pnDataDireccion
            // 
            this.pnDataDireccion.BackColor = System.Drawing.Color.White;
            this.pnDataDireccion.Controls.Add(this.tableDireccion);
            this.pnDataDireccion.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnDataDireccion.Location = new System.Drawing.Point(0, 376);
            this.pnDataDireccion.Name = "pnDataDireccion";
            this.pnDataDireccion.Padding = new System.Windows.Forms.Padding(20);
            this.pnDataDireccion.Size = new System.Drawing.Size(918, 209);
            this.pnDataDireccion.TabIndex = 5;
            // 
            // tableDireccion
            // 
            this.tableDireccion.ColumnCount = 1;
            this.tableDireccion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableDireccion.Controls.Add(this.pnColumnDown, 0, 1);
            this.tableDireccion.Controls.Add(this.pnColumnTop, 0, 0);
            this.tableDireccion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableDireccion.Location = new System.Drawing.Point(20, 20);
            this.tableDireccion.Name = "tableDireccion";
            this.tableDireccion.Padding = new System.Windows.Forms.Padding(10);
            this.tableDireccion.RowCount = 2;
            this.tableDireccion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableDireccion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableDireccion.Size = new System.Drawing.Size(878, 169);
            this.tableDireccion.TabIndex = 2;
            // 
            // pnColumnDown
            // 
            this.pnColumnDown.Controls.Add(this.pnDataCalle);
            this.pnColumnDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnColumnDown.Location = new System.Drawing.Point(13, 87);
            this.pnColumnDown.Name = "pnColumnDown";
            this.pnColumnDown.Size = new System.Drawing.Size(852, 69);
            this.pnColumnDown.TabIndex = 6;
            // 
            // pnDataCalle
            // 
            this.pnDataCalle.ColorTitule = System.Drawing.Color.Empty;
            this.pnDataCalle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnDataCalle.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnDataCalle.FontLabel = new System.Drawing.Font("Gin and Soda Personal Use", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnDataCalle.Imagen = null;
            this.pnDataCalle.IsPassword = false;
            this.pnDataCalle.Location = new System.Drawing.Point(0, 0);
            this.pnDataCalle.Margin = new System.Windows.Forms.Padding(2);
            this.pnDataCalle.Multiline = false;
            this.pnDataCalle.Name = "pnDataCalle";
            this.pnDataCalle.Size = new System.Drawing.Size(852, 69);
            this.pnDataCalle.TabIndex = 3;
            this.pnDataCalle.Texto = "";
            this.pnDataCalle.TextoHint = null;
            this.pnDataCalle.Tipo_De_Texto = TiendaDesktop.UI.Componentes.pnData.TipeText.All;
            this.pnDataCalle.Titule = "Calle";
            // 
            // pnColumnTop
            // 
            this.pnColumnTop.Controls.Add(this.tableDatosDireccion);
            this.pnColumnTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnColumnTop.Location = new System.Drawing.Point(13, 13);
            this.pnColumnTop.Name = "pnColumnTop";
            this.pnColumnTop.Size = new System.Drawing.Size(852, 68);
            this.pnColumnTop.TabIndex = 5;
            // 
            // tableDatosDireccion
            // 
            this.tableDatosDireccion.ColumnCount = 2;
            this.tableDatosDireccion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableDatosDireccion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableDatosDireccion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableDatosDireccion.Controls.Add(this.pnCodigoPostal, 1, 0);
            this.tableDatosDireccion.Controls.Add(this.pnPoblacion, 0, 0);
            this.tableDatosDireccion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableDatosDireccion.Location = new System.Drawing.Point(0, 0);
            this.tableDatosDireccion.Name = "tableDatosDireccion";
            this.tableDatosDireccion.RowCount = 1;
            this.tableDatosDireccion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableDatosDireccion.Size = new System.Drawing.Size(852, 68);
            this.tableDatosDireccion.TabIndex = 2;
            // 
            // pnCodigoPostal
            // 
            this.pnCodigoPostal.ColorTitule = System.Drawing.Color.Empty;
            this.pnCodigoPostal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnCodigoPostal.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnCodigoPostal.FontLabel = new System.Drawing.Font("Gin and Soda Personal Use", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnCodigoPostal.Imagen = null;
            this.pnCodigoPostal.IsPassword = false;
            this.pnCodigoPostal.Location = new System.Drawing.Point(428, 2);
            this.pnCodigoPostal.Margin = new System.Windows.Forms.Padding(2);
            this.pnCodigoPostal.Multiline = false;
            this.pnCodigoPostal.Name = "pnCodigoPostal";
            this.pnCodigoPostal.Size = new System.Drawing.Size(422, 64);
            this.pnCodigoPostal.TabIndex = 4;
            this.pnCodigoPostal.Texto = "";
            this.pnCodigoPostal.TextoHint = null;
            this.pnCodigoPostal.Tipo_De_Texto = TiendaDesktop.UI.Componentes.pnData.TipeText.All;
            this.pnCodigoPostal.Titule = "Codigo Postal";
            // 
            // pnPoblacion
            // 
            this.pnPoblacion.ColorTitule = System.Drawing.Color.Empty;
            this.pnPoblacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnPoblacion.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnPoblacion.FontLabel = new System.Drawing.Font("Gin and Soda Personal Use", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnPoblacion.Imagen = null;
            this.pnPoblacion.IsPassword = false;
            this.pnPoblacion.Location = new System.Drawing.Point(2, 2);
            this.pnPoblacion.Margin = new System.Windows.Forms.Padding(2);
            this.pnPoblacion.Multiline = false;
            this.pnPoblacion.Name = "pnPoblacion";
            this.pnPoblacion.Size = new System.Drawing.Size(422, 64);
            this.pnPoblacion.TabIndex = 2;
            this.pnPoblacion.Texto = "";
            this.pnPoblacion.TextoHint = null;
            this.pnPoblacion.Tipo_De_Texto = TiendaDesktop.UI.Componentes.pnData.TipeText.All;
            this.pnPoblacion.Titule = "Poblacion";
            // 
            // pnTopDireccion
            // 
            this.pnTopDireccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pnTopDireccion.Controls.Add(this.lbDireccion);
            this.pnTopDireccion.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTopDireccion.Location = new System.Drawing.Point(0, 335);
            this.pnTopDireccion.Name = "pnTopDireccion";
            this.pnTopDireccion.Padding = new System.Windows.Forms.Padding(30, 10, 10, 10);
            this.pnTopDireccion.Size = new System.Drawing.Size(918, 41);
            this.pnTopDireccion.TabIndex = 6;
            // 
            // lbDireccion
            // 
            this.lbDireccion.AutoSize = true;
            this.lbDireccion.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbDireccion.Font = new System.Drawing.Font("Gin and Soda Personal Use", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDireccion.Location = new System.Drawing.Point(30, 10);
            this.lbDireccion.Name = "lbDireccion";
            this.lbDireccion.Size = new System.Drawing.Size(101, 20);
            this.lbDireccion.TabIndex = 0;
            this.lbDireccion.Text = "Direccion";
            // 
            // pnDatos
            // 
            this.pnDatos.Controls.Add(this.pnContenDatos);
            this.pnDatos.Controls.Add(this.pnLabelDatos);
            this.pnDatos.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnDatos.Location = new System.Drawing.Point(0, 0);
            this.pnDatos.Name = "pnDatos";
            this.pnDatos.Size = new System.Drawing.Size(918, 335);
            this.pnDatos.TabIndex = 0;
            // 
            // pnContenDatos
            // 
            this.pnContenDatos.BackColor = System.Drawing.Color.White;
            this.pnContenDatos.Controls.Add(this.tableDatos);
            this.pnContenDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnContenDatos.Location = new System.Drawing.Point(0, 47);
            this.pnContenDatos.Name = "pnContenDatos";
            this.pnContenDatos.Padding = new System.Windows.Forms.Padding(20);
            this.pnContenDatos.Size = new System.Drawing.Size(918, 288);
            this.pnContenDatos.TabIndex = 8;
            // 
            // tableDatos
            // 
            this.tableDatos.ColumnCount = 2;
            this.tableDatos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableDatos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableDatos.Controls.Add(this.pnDataNombre, 0, 0);
            this.tableDatos.Controls.Add(this.pnDataApellido, 1, 0);
            this.tableDatos.Controls.Add(this.pnDataEmail, 1, 2);
            this.tableDatos.Controls.Add(this.pnDataPhone, 0, 2);
            this.tableDatos.Controls.Add(this.pnDataUsername, 0, 1);
            this.tableDatos.Controls.Add(this.pnDataPass, 1, 1);
            this.tableDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableDatos.Location = new System.Drawing.Point(20, 20);
            this.tableDatos.Name = "tableDatos";
            this.tableDatos.Padding = new System.Windows.Forms.Padding(5);
            this.tableDatos.RowCount = 3;
            this.tableDatos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableDatos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableDatos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableDatos.Size = new System.Drawing.Size(878, 248);
            this.tableDatos.TabIndex = 6;
            // 
            // pnDataNombre
            // 
            this.pnDataNombre.ColorTitule = System.Drawing.Color.Empty;
            this.pnDataNombre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnDataNombre.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnDataNombre.FontLabel = new System.Drawing.Font("Gin and Soda Personal Use", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnDataNombre.Imagen = null;
            this.pnDataNombre.IsPassword = false;
            this.pnDataNombre.Location = new System.Drawing.Point(7, 7);
            this.pnDataNombre.Margin = new System.Windows.Forms.Padding(2);
            this.pnDataNombre.Multiline = false;
            this.pnDataNombre.Name = "pnDataNombre";
            this.pnDataNombre.Padding = new System.Windows.Forms.Padding(7);
            this.pnDataNombre.Size = new System.Drawing.Size(430, 75);
            this.pnDataNombre.TabIndex = 0;
            this.pnDataNombre.Texto = "";
            this.pnDataNombre.TextoHint = null;
            this.pnDataNombre.Tipo_De_Texto = TiendaDesktop.UI.Componentes.pnData.TipeText.All;
            this.pnDataNombre.Titule = "Nombre";
            // 
            // pnDataApellido
            // 
            this.pnDataApellido.ColorTitule = System.Drawing.Color.Empty;
            this.pnDataApellido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnDataApellido.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnDataApellido.FontLabel = new System.Drawing.Font("Gin and Soda Personal Use", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnDataApellido.Imagen = null;
            this.pnDataApellido.IsPassword = false;
            this.pnDataApellido.Location = new System.Drawing.Point(441, 7);
            this.pnDataApellido.Margin = new System.Windows.Forms.Padding(2);
            this.pnDataApellido.Multiline = false;
            this.pnDataApellido.Name = "pnDataApellido";
            this.pnDataApellido.Padding = new System.Windows.Forms.Padding(7);
            this.pnDataApellido.Size = new System.Drawing.Size(430, 75);
            this.pnDataApellido.TabIndex = 1;
            this.pnDataApellido.Texto = "";
            this.pnDataApellido.TextoHint = null;
            this.pnDataApellido.Tipo_De_Texto = TiendaDesktop.UI.Componentes.pnData.TipeText.All;
            this.pnDataApellido.Titule = "Apellido";
            // 
            // pnDataEmail
            // 
            this.pnDataEmail.ColorTitule = System.Drawing.Color.Empty;
            this.pnDataEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnDataEmail.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnDataEmail.FontLabel = new System.Drawing.Font("Gin and Soda Personal Use", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnDataEmail.Imagen = null;
            this.pnDataEmail.IsPassword = false;
            this.pnDataEmail.Location = new System.Drawing.Point(441, 165);
            this.pnDataEmail.Margin = new System.Windows.Forms.Padding(2);
            this.pnDataEmail.Multiline = false;
            this.pnDataEmail.Name = "pnDataEmail";
            this.pnDataEmail.Padding = new System.Windows.Forms.Padding(7);
            this.pnDataEmail.Size = new System.Drawing.Size(430, 76);
            this.pnDataEmail.TabIndex = 2;
            this.pnDataEmail.Texto = "";
            this.pnDataEmail.TextoHint = null;
            this.pnDataEmail.Tipo_De_Texto = TiendaDesktop.UI.Componentes.pnData.TipeText.All;
            this.pnDataEmail.Titule = "Email";
            // 
            // pnDataPhone
            // 
            this.pnDataPhone.ColorTitule = System.Drawing.Color.Empty;
            this.pnDataPhone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnDataPhone.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnDataPhone.FontLabel = new System.Drawing.Font("Gin and Soda Personal Use", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnDataPhone.Imagen = null;
            this.pnDataPhone.IsPassword = false;
            this.pnDataPhone.Location = new System.Drawing.Point(7, 165);
            this.pnDataPhone.Margin = new System.Windows.Forms.Padding(2);
            this.pnDataPhone.Multiline = false;
            this.pnDataPhone.Name = "pnDataPhone";
            this.pnDataPhone.Padding = new System.Windows.Forms.Padding(7);
            this.pnDataPhone.Size = new System.Drawing.Size(430, 76);
            this.pnDataPhone.TabIndex = 0;
            this.pnDataPhone.Texto = "";
            this.pnDataPhone.TextoHint = null;
            this.pnDataPhone.Tipo_De_Texto = TiendaDesktop.UI.Componentes.pnData.TipeText.ONLY_NUMBERS;
            this.pnDataPhone.Titule = "Telefono";
            // 
            // pnDataUsername
            // 
            this.pnDataUsername.ColorTitule = System.Drawing.Color.Empty;
            this.pnDataUsername.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnDataUsername.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnDataUsername.FontLabel = new System.Drawing.Font("Gin and Soda Personal Use", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnDataUsername.Imagen = null;
            this.pnDataUsername.IsPassword = false;
            this.pnDataUsername.Location = new System.Drawing.Point(7, 86);
            this.pnDataUsername.Margin = new System.Windows.Forms.Padding(2);
            this.pnDataUsername.Multiline = false;
            this.pnDataUsername.Name = "pnDataUsername";
            this.pnDataUsername.Padding = new System.Windows.Forms.Padding(7);
            this.pnDataUsername.Size = new System.Drawing.Size(430, 75);
            this.pnDataUsername.TabIndex = 4;
            this.pnDataUsername.Texto = "";
            this.pnDataUsername.TextoHint = null;
            this.pnDataUsername.Tipo_De_Texto = TiendaDesktop.UI.Componentes.pnData.TipeText.All;
            this.pnDataUsername.Titule = "Username";
            // 
            // pnDataPass
            // 
            this.pnDataPass.ColorTitule = System.Drawing.Color.Empty;
            this.pnDataPass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnDataPass.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnDataPass.FontLabel = new System.Drawing.Font("Gin and Soda Personal Use", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnDataPass.Imagen = null;
            this.pnDataPass.IsPassword = true;
            this.pnDataPass.Location = new System.Drawing.Point(441, 86);
            this.pnDataPass.Margin = new System.Windows.Forms.Padding(2);
            this.pnDataPass.Multiline = false;
            this.pnDataPass.Name = "pnDataPass";
            this.pnDataPass.Padding = new System.Windows.Forms.Padding(7);
            this.pnDataPass.Size = new System.Drawing.Size(430, 75);
            this.pnDataPass.TabIndex = 3;
            this.pnDataPass.Texto = "";
            this.pnDataPass.TextoHint = null;
            this.pnDataPass.Tipo_De_Texto = TiendaDesktop.UI.Componentes.pnData.TipeText.All;
            this.pnDataPass.Titule = "Password";
            // 
            // pnLabelDatos
            // 
            this.pnLabelDatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pnLabelDatos.Controls.Add(this.lbDatos);
            this.pnLabelDatos.Controls.Add(this.btnSave);
            this.pnLabelDatos.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnLabelDatos.Location = new System.Drawing.Point(0, 0);
            this.pnLabelDatos.Name = "pnLabelDatos";
            this.pnLabelDatos.Padding = new System.Windows.Forms.Padding(30, 12, 12, 12);
            this.pnLabelDatos.Size = new System.Drawing.Size(918, 47);
            this.pnLabelDatos.TabIndex = 7;
            // 
            // lbDatos
            // 
            this.lbDatos.AutoSize = true;
            this.lbDatos.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbDatos.Font = new System.Drawing.Font("Gin and Soda Personal Use", 15.75F, System.Drawing.FontStyle.Bold);
            this.lbDatos.Location = new System.Drawing.Point(30, 12);
            this.lbDatos.Name = "lbDatos";
            this.lbDatos.Size = new System.Drawing.Size(67, 20);
            this.lbDatos.TabIndex = 6;
            this.lbDatos.Text = "Datos";
            // 
            // btnSave
            // 
            this.btnSave.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSave.Image = global::TiendaDesktop.Properties.Resources.save__1_;
            this.btnSave.Location = new System.Drawing.Point(867, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(39, 23);
            this.btnSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSave.TabIndex = 5;
            this.btnSave.TabStop = false;
            // 
            // pnLeft
            // 
            this.pnLeft.BackColor = System.Drawing.Color.LightGreen;
            this.pnLeft.Controls.Add(this.imageFile1);
            this.pnLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnLeft.Location = new System.Drawing.Point(0, 0);
            this.pnLeft.Name = "pnLeft";
            this.pnLeft.Size = new System.Drawing.Size(256, 740);
            this.pnLeft.TabIndex = 2;
            // 
            // imageFile1
            // 
            this.imageFile1.Dock = System.Windows.Forms.DockStyle.Top;
            this.imageFile1.Location = new System.Drawing.Point(0, 0);
            this.imageFile1.Name = "imageFile1";
            this.imageFile1.Size = new System.Drawing.Size(256, 335);
            this.imageFile1.TabIndex = 0;
            // 
            // pnBody
            // 
            this.pnBody.Controls.Add(this.pnCentral);
            this.pnBody.Controls.Add(this.pnLeft);
            this.pnBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnBody.Location = new System.Drawing.Point(0, 49);
            this.pnBody.Name = "pnBody";
            this.pnBody.Size = new System.Drawing.Size(1174, 740);
            this.pnBody.TabIndex = 1;
            // 
            // FormPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 789);
            this.Controls.Add(this.pnBody);
            this.Name = "FormPersona";
            this.Text = "FormEmpleado";
            this.Controls.SetChildIndex(this.pnBody, 0);
            this.pnCentral.ResumeLayout(false);
            this.pnDataDireccion.ResumeLayout(false);
            this.tableDireccion.ResumeLayout(false);
            this.pnColumnDown.ResumeLayout(false);
            this.pnColumnTop.ResumeLayout(false);
            this.tableDatosDireccion.ResumeLayout(false);
            this.pnTopDireccion.ResumeLayout(false);
            this.pnTopDireccion.PerformLayout();
            this.pnDatos.ResumeLayout(false);
            this.pnContenDatos.ResumeLayout(false);
            this.tableDatos.ResumeLayout(false);
            this.pnLabelDatos.ResumeLayout(false);
            this.pnLabelDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
            this.pnLeft.ResumeLayout(false);
            this.pnBody.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbDireccion;
        private System.Windows.Forms.Panel pnBody;
        public System.Windows.Forms.TableLayoutPanel tableDireccion;
        private System.Windows.Forms.Panel pnColumnDown;
        private System.Windows.Forms.Panel pnColumnTop;
        public System.Windows.Forms.TableLayoutPanel tableDatosDireccion;
        private System.Windows.Forms.Panel pnLabelDatos;
        private System.Windows.Forms.Label lbDatos;
        private Componentes.ImageFile imageFile1;
        public System.Windows.Forms.Panel pnCentral;
        public System.Windows.Forms.Panel pnContenDatos;
        public Componentes.pnData pnDataNombre;
        public System.Windows.Forms.TableLayoutPanel tableDatos;
        public System.Windows.Forms.Panel pnDataDireccion;
        public System.Windows.Forms.Panel pnTopDireccion;
        public System.Windows.Forms.Panel pnDatos;
        public Componentes.pnData pnDataUsername;
        public Componentes.pnData pnDataPhone;
        public Componentes.pnData pnDataPass;
        public Componentes.pnData pnDataEmail;
        public Componentes.pnData pnDataApellido;
        public System.Windows.Forms.PictureBox btnSave;
        public Componentes.pnData pnCodigoPostal;
        public Componentes.pnData pnDataCalle;
        public Componentes.pnData pnPoblacion;
        public System.Windows.Forms.Panel pnLeft;
    }
}