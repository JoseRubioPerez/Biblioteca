namespace CapaPre
{
    partial class Reports
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reports));
            this.tablePrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.panelTipoReporte = new System.Windows.Forms.Panel();
            this.tableReportes = new System.Windows.Forms.TableLayoutPanel();
            this.panelServicios = new System.Windows.Forms.Panel();
            this.btnServicioOtros = new System.Windows.Forms.Button();
            this.btnServicioBanios = new System.Windows.Forms.Button();
            this.btnServicioLectura = new System.Windows.Forms.Button();
            this.btnServicioSalaTrabajo = new System.Windows.Forms.Button();
            this.btnServicioCubiculos = new System.Windows.Forms.Button();
            this.btnServicioBD = new System.Windows.Forms.Button();
            this.btnServicioConsulta = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panelRefUsuarios = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureUsuarios = new System.Windows.Forms.PictureBox();
            this.panelRefServicios = new System.Windows.Forms.Panel();
            this.pictureServicios = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panelUsuarios = new System.Windows.Forms.Panel();
            this.GridHombres = new System.Windows.Forms.DataGridView();
            this.GridMujeres = new System.Windows.Forms.DataGridView();
            this.btnUsuarioSalaPorSexo = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tablePrincipal.SuspendLayout();
            this.panelTipoReporte.SuspendLayout();
            this.tableReportes.SuspendLayout();
            this.panelServicios.SuspendLayout();
            this.panelRefUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUsuarios)).BeginInit();
            this.panelRefServicios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureServicios)).BeginInit();
            this.panelUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridHombres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridMujeres)).BeginInit();
            this.SuspendLayout();
            // 
            // tablePrincipal
            // 
            this.tablePrincipal.ColumnCount = 1;
            this.tablePrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tablePrincipal.Controls.Add(this.label1, 0, 1);
            this.tablePrincipal.Controls.Add(this.lbTitulo, 0, 0);
            this.tablePrincipal.Controls.Add(this.panelTipoReporte, 0, 2);
            this.tablePrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePrincipal.Location = new System.Drawing.Point(0, 0);
            this.tablePrincipal.Name = "tablePrincipal";
            this.tablePrincipal.RowCount = 3;
            this.tablePrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tablePrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tablePrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tablePrincipal.Size = new System.Drawing.Size(1140, 507);
            this.tablePrincipal.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1134, 45);
            this.label1.TabIndex = 20;
            this.label1.Text = "A continuación, se enlistan los tipos de repotes que se pueden generar en este ap" +
    "artado";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbTitulo.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.Location = new System.Drawing.Point(3, 0);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(1134, 60);
            this.lbTitulo.TabIndex = 19;
            this.lbTitulo.Text = "Genera los reportes necesarios de los datos almacenados del centro de información" +
    "";
            this.lbTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelTipoReporte
            // 
            this.panelTipoReporte.Controls.Add(this.tableReportes);
            this.panelTipoReporte.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTipoReporte.Location = new System.Drawing.Point(3, 108);
            this.panelTipoReporte.Name = "panelTipoReporte";
            this.panelTipoReporte.Size = new System.Drawing.Size(1134, 396);
            this.panelTipoReporte.TabIndex = 21;
            // 
            // tableReportes
            // 
            this.tableReportes.ColumnCount = 2;
            this.tableReportes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableReportes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableReportes.Controls.Add(this.panelServicios, 1, 1);
            this.tableReportes.Controls.Add(this.panelRefUsuarios, 0, 0);
            this.tableReportes.Controls.Add(this.panelRefServicios, 1, 0);
            this.tableReportes.Controls.Add(this.panelUsuarios, 0, 1);
            this.tableReportes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableReportes.Location = new System.Drawing.Point(0, 0);
            this.tableReportes.Name = "tableReportes";
            this.tableReportes.RowCount = 2;
            this.tableReportes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.87879F));
            this.tableReportes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.12122F));
            this.tableReportes.Size = new System.Drawing.Size(1134, 396);
            this.tableReportes.TabIndex = 0;
            // 
            // panelServicios
            // 
            this.panelServicios.Controls.Add(this.btnServicioOtros);
            this.panelServicios.Controls.Add(this.btnServicioBanios);
            this.panelServicios.Controls.Add(this.btnServicioLectura);
            this.panelServicios.Controls.Add(this.btnServicioSalaTrabajo);
            this.panelServicios.Controls.Add(this.btnServicioCubiculos);
            this.panelServicios.Controls.Add(this.btnServicioBD);
            this.panelServicios.Controls.Add(this.btnServicioConsulta);
            this.panelServicios.Controls.Add(this.label4);
            this.panelServicios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelServicios.Location = new System.Drawing.Point(570, 54);
            this.panelServicios.Name = "panelServicios";
            this.panelServicios.Size = new System.Drawing.Size(561, 339);
            this.panelServicios.TabIndex = 26;
            // 
            // btnServicioOtros
            // 
            this.btnServicioOtros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnServicioOtros.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnServicioOtros.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btnServicioOtros.Location = new System.Drawing.Point(29, 224);
            this.btnServicioOtros.Name = "btnServicioOtros";
            this.btnServicioOtros.Size = new System.Drawing.Size(96, 31);
            this.btnServicioOtros.TabIndex = 30;
            this.btnServicioOtros.Text = "Otros";
            this.btnServicioOtros.UseVisualStyleBackColor = true;
            this.btnServicioOtros.Click += new System.EventHandler(this.EventoClick);
            // 
            // btnServicioBanios
            // 
            this.btnServicioBanios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnServicioBanios.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnServicioBanios.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btnServicioBanios.Location = new System.Drawing.Point(438, 168);
            this.btnServicioBanios.Name = "btnServicioBanios";
            this.btnServicioBanios.Size = new System.Drawing.Size(96, 31);
            this.btnServicioBanios.TabIndex = 29;
            this.btnServicioBanios.Text = "Baños";
            this.btnServicioBanios.UseVisualStyleBackColor = true;
            this.btnServicioBanios.Click += new System.EventHandler(this.EventoClick);
            // 
            // btnServicioLectura
            // 
            this.btnServicioLectura.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnServicioLectura.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnServicioLectura.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btnServicioLectura.Location = new System.Drawing.Point(278, 168);
            this.btnServicioLectura.Name = "btnServicioLectura";
            this.btnServicioLectura.Size = new System.Drawing.Size(144, 31);
            this.btnServicioLectura.TabIndex = 28;
            this.btnServicioLectura.Text = "Sala de lectura";
            this.btnServicioLectura.UseVisualStyleBackColor = true;
            this.btnServicioLectura.Click += new System.EventHandler(this.EventoClick);
            // 
            // btnServicioSalaTrabajo
            // 
            this.btnServicioSalaTrabajo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnServicioSalaTrabajo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnServicioSalaTrabajo.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btnServicioSalaTrabajo.Location = new System.Drawing.Point(29, 168);
            this.btnServicioSalaTrabajo.Name = "btnServicioSalaTrabajo";
            this.btnServicioSalaTrabajo.Size = new System.Drawing.Size(229, 31);
            this.btnServicioSalaTrabajo.TabIndex = 27;
            this.btnServicioSalaTrabajo.Text = "Sala de trabajo en equipo";
            this.btnServicioSalaTrabajo.UseVisualStyleBackColor = true;
            this.btnServicioSalaTrabajo.Click += new System.EventHandler(this.EventoClick);
            // 
            // btnServicioCubiculos
            // 
            this.btnServicioCubiculos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnServicioCubiculos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnServicioCubiculos.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btnServicioCubiculos.Location = new System.Drawing.Point(438, 110);
            this.btnServicioCubiculos.Name = "btnServicioCubiculos";
            this.btnServicioCubiculos.Size = new System.Drawing.Size(96, 31);
            this.btnServicioCubiculos.TabIndex = 26;
            this.btnServicioCubiculos.Text = "Cubículos";
            this.btnServicioCubiculos.UseVisualStyleBackColor = true;
            this.btnServicioCubiculos.Click += new System.EventHandler(this.EventoClick);
            // 
            // btnServicioBD
            // 
            this.btnServicioBD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnServicioBD.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnServicioBD.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btnServicioBD.Location = new System.Drawing.Point(278, 110);
            this.btnServicioBD.Name = "btnServicioBD";
            this.btnServicioBD.Size = new System.Drawing.Size(144, 31);
            this.btnServicioBD.TabIndex = 25;
            this.btnServicioBD.Text = "Base de datos";
            this.btnServicioBD.UseVisualStyleBackColor = true;
            this.btnServicioBD.Click += new System.EventHandler(this.EventoClick);
            // 
            // btnServicioConsulta
            // 
            this.btnServicioConsulta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnServicioConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnServicioConsulta.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btnServicioConsulta.Location = new System.Drawing.Point(29, 110);
            this.btnServicioConsulta.Name = "btnServicioConsulta";
            this.btnServicioConsulta.Size = new System.Drawing.Size(229, 31);
            this.btnServicioConsulta.TabIndex = 24;
            this.btnServicioConsulta.Text = "Consulta o referencia";
            this.btnServicioConsulta.UseVisualStyleBackColor = true;
            this.btnServicioConsulta.Click += new System.EventHandler(this.EventoClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.ImageKey = "Moves.png";
            this.label4.Location = new System.Drawing.Point(28, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(506, 57);
            this.label4.TabIndex = 23;
            this.label4.Text = "Haga clic en el botón con el servicio para generar un reporte.\r\n\r\nNúmero de veces" +
    " que se proporcionó el servicio de:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelRefUsuarios
            // 
            this.panelRefUsuarios.Controls.Add(this.label2);
            this.panelRefUsuarios.Controls.Add(this.pictureUsuarios);
            this.panelRefUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRefUsuarios.Location = new System.Drawing.Point(3, 3);
            this.panelRefUsuarios.Name = "panelRefUsuarios";
            this.panelRefUsuarios.Size = new System.Drawing.Size(561, 45);
            this.panelRefUsuarios.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(197, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 25);
            this.label2.TabIndex = 21;
            this.label2.Text = "Referente a usuarios";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureUsuarios
            // 
            this.pictureUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureUsuarios.Image = global::CapaPre.Properties.Resources.usuarios;
            this.pictureUsuarios.Location = new System.Drawing.Point(159, 6);
            this.pictureUsuarios.MaximumSize = new System.Drawing.Size(32, 32);
            this.pictureUsuarios.MinimumSize = new System.Drawing.Size(32, 32);
            this.pictureUsuarios.Name = "pictureUsuarios";
            this.pictureUsuarios.Size = new System.Drawing.Size(32, 32);
            this.pictureUsuarios.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureUsuarios.TabIndex = 25;
            this.pictureUsuarios.TabStop = false;
            // 
            // panelRefServicios
            // 
            this.panelRefServicios.Controls.Add(this.pictureServicios);
            this.panelRefServicios.Controls.Add(this.label3);
            this.panelRefServicios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRefServicios.Location = new System.Drawing.Point(570, 3);
            this.panelRefServicios.Name = "panelRefServicios";
            this.panelRefServicios.Size = new System.Drawing.Size(561, 45);
            this.panelRefServicios.TabIndex = 24;
            // 
            // pictureServicios
            // 
            this.pictureServicios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureServicios.Image = global::CapaPre.Properties.Resources.Moves;
            this.pictureServicios.Location = new System.Drawing.Point(158, 6);
            this.pictureServicios.MaximumSize = new System.Drawing.Size(32, 32);
            this.pictureServicios.MinimumSize = new System.Drawing.Size(32, 32);
            this.pictureServicios.Name = "pictureServicios";
            this.pictureServicios.Size = new System.Drawing.Size(32, 32);
            this.pictureServicios.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureServicios.TabIndex = 26;
            this.pictureServicios.TabStop = false;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.ImageKey = "Moves.png";
            this.label3.Location = new System.Drawing.Point(196, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 25);
            this.label3.TabIndex = 22;
            this.label3.Text = "Referente a servicios";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panelUsuarios
            // 
            this.panelUsuarios.Controls.Add(this.GridHombres);
            this.panelUsuarios.Controls.Add(this.GridMujeres);
            this.panelUsuarios.Controls.Add(this.btnUsuarioSalaPorSexo);
            this.panelUsuarios.Controls.Add(this.label9);
            this.panelUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelUsuarios.Location = new System.Drawing.Point(3, 54);
            this.panelUsuarios.Name = "panelUsuarios";
            this.panelUsuarios.Size = new System.Drawing.Size(561, 339);
            this.panelUsuarios.TabIndex = 25;
            // 
            // GridHombres
            // 
            this.GridHombres.AllowUserToAddRows = false;
            this.GridHombres.AllowUserToDeleteRows = false;
            this.GridHombres.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.GridHombres.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(223)))), ((int)(((byte)(198)))));
            this.GridHombres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridHombres.Location = new System.Drawing.Point(430, 307);
            this.GridHombres.Name = "GridHombres";
            this.GridHombres.ReadOnly = true;
            this.GridHombres.Size = new System.Drawing.Size(61, 26);
            this.GridHombres.TabIndex = 30;
            // 
            // GridMujeres
            // 
            this.GridMujeres.AllowUserToAddRows = false;
            this.GridMujeres.AllowUserToDeleteRows = false;
            this.GridMujeres.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.GridMujeres.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(223)))), ((int)(((byte)(198)))));
            this.GridMujeres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridMujeres.Location = new System.Drawing.Point(497, 307);
            this.GridMujeres.Name = "GridMujeres";
            this.GridMujeres.ReadOnly = true;
            this.GridMujeres.Size = new System.Drawing.Size(61, 26);
            this.GridMujeres.TabIndex = 29;
            // 
            // btnUsuarioSalaPorSexo
            // 
            this.btnUsuarioSalaPorSexo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUsuarioSalaPorSexo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUsuarioSalaPorSexo.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btnUsuarioSalaPorSexo.Location = new System.Drawing.Point(23, 86);
            this.btnUsuarioSalaPorSexo.Name = "btnUsuarioSalaPorSexo";
            this.btnUsuarioSalaPorSexo.Size = new System.Drawing.Size(188, 31);
            this.btnUsuarioSalaPorSexo.TabIndex = 28;
            this.btnUsuarioSalaPorSexo.Text = "Generar este reporte";
            this.btnUsuarioSalaPorSexo.UseVisualStyleBackColor = true;
            this.btnUsuarioSalaPorSexo.Click += new System.EventHandler(this.EventoClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label9.ImageKey = "Moves.png";
            this.label9.Location = new System.Drawing.Point(19, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(397, 38);
            this.label9.TabIndex = 26;
            this.label9.Text = "Número de usuarios que utilizaron los servicios \r\nde biblioteca en sala, por sexo" +
    "";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Moves.png");
            this.imageList1.Images.SetKeyName(1, "usuarios.png");
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(223)))), ((int)(((byte)(198)))));
            this.ClientSize = new System.Drawing.Size(1140, 507);
            this.Controls.Add(this.tablePrincipal);
            this.Font = new System.Drawing.Font("Tahoma", 12F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Reports";
            this.Text = "Reports";
            this.tablePrincipal.ResumeLayout(false);
            this.tablePrincipal.PerformLayout();
            this.panelTipoReporte.ResumeLayout(false);
            this.tableReportes.ResumeLayout(false);
            this.panelServicios.ResumeLayout(false);
            this.panelServicios.PerformLayout();
            this.panelRefUsuarios.ResumeLayout(false);
            this.panelRefUsuarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUsuarios)).EndInit();
            this.panelRefServicios.ResumeLayout(false);
            this.panelRefServicios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureServicios)).EndInit();
            this.panelUsuarios.ResumeLayout(false);
            this.panelUsuarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridHombres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridMujeres)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tablePrincipal;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Panel panelTipoReporte;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableReportes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelRefUsuarios;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelRefServicios;
        private System.Windows.Forms.PictureBox pictureUsuarios;
        private System.Windows.Forms.PictureBox pictureServicios;
        private System.Windows.Forms.Panel panelServicios;
        private System.Windows.Forms.Panel panelUsuarios;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnServicioOtros;
        private System.Windows.Forms.Button btnServicioBanios;
        private System.Windows.Forms.Button btnServicioLectura;
        private System.Windows.Forms.Button btnServicioSalaTrabajo;
        private System.Windows.Forms.Button btnServicioCubiculos;
        private System.Windows.Forms.Button btnServicioBD;
        private System.Windows.Forms.Button btnServicioConsulta;
        private System.Windows.Forms.Button btnUsuarioSalaPorSexo;
        private System.Windows.Forms.DataGridView GridMujeres;
        private System.Windows.Forms.DataGridView GridHombres;
    }
}