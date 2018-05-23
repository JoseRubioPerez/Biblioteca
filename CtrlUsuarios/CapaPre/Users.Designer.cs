namespace CapaPre
{
    partial class Users : FatherConfig
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Users));
            this.comboTypeSearch = new System.Windows.Forms.ComboBox();
            this.GridSearch = new System.Windows.Forms.DataGridView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tableUsers = new System.Windows.Forms.TableLayoutPanel();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.panelContenido = new System.Windows.Forms.Panel();
            this.status1 = new CapaPre.Search.Status();
            this.area1 = new CapaPre.Search.Area();
            this.sexo1 = new CapaPre.Search.Sexo();
            this.ambosApellidos1 = new CapaPre.Search.AmbosApellidos();
            this.nombres1 = new CapaPre.Search.Nombres();
            this.numControl1 = new CapaPre.Search.NumControl();
            this.lbSearch02 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnAllUsers = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GridSearch)).BeginInit();
            this.tableUsers.SuspendLayout();
            this.panelContenido.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboTypeSearch
            // 
            this.comboTypeSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboTypeSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboTypeSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTypeSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboTypeSearch.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.comboTypeSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.comboTypeSearch.FormattingEnabled = true;
            this.comboTypeSearch.Items.AddRange(new object[] {
            "Número de Control",
            "Nombres",
            "Apellidos",
            "Sexo",
            "Carrera o Departamento",
            "Status"});
            this.comboTypeSearch.Location = new System.Drawing.Point(112, 14);
            this.comboTypeSearch.MaximumSize = new System.Drawing.Size(275, 0);
            this.comboTypeSearch.MinimumSize = new System.Drawing.Size(275, 0);
            this.comboTypeSearch.Name = "comboTypeSearch";
            this.comboTypeSearch.Size = new System.Drawing.Size(275, 27);
            this.comboTypeSearch.TabIndex = 1;
            this.comboTypeSearch.SelectedIndexChanged += new System.EventHandler(this.ValidarCombo);
            // 
            // GridSearch
            // 
            this.GridSearch.AllowUserToAddRows = false;
            this.GridSearch.AllowUserToDeleteRows = false;
            this.GridSearch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.GridSearch.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.GridSearch.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(223)))), ((int)(((byte)(198)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridSearch.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GridSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableUsers.SetColumnSpan(this.GridSearch, 2);
            this.GridSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GridSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridSearch.Location = new System.Drawing.Point(3, 225);
            this.GridSearch.Name = "GridSearch";
            this.GridSearch.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridSearch.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.GridSearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridSearch.Size = new System.Drawing.Size(1134, 279);
            this.GridSearch.TabIndex = 12;
            this.GridSearch.TabStop = false;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "usuarios.png");
            this.imageList1.Images.SetKeyName(1, "searchClean.png");
            // 
            // tableUsers
            // 
            this.tableUsers.ColumnCount = 2;
            this.tableUsers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableUsers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableUsers.Controls.Add(this.panel1, 1, 1);
            this.tableUsers.Controls.Add(this.lbTitulo, 0, 0);
            this.tableUsers.Controls.Add(this.panelContenido, 1, 0);
            this.tableUsers.Controls.Add(this.GridSearch, 0, 2);
            this.tableUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableUsers.Location = new System.Drawing.Point(0, 0);
            this.tableUsers.Name = "tableUsers";
            this.tableUsers.RowCount = 3;
            this.tableUsers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.81078F));
            this.tableUsers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.20406F));
            this.tableUsers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.98516F));
            this.tableUsers.Size = new System.Drawing.Size(1140, 507);
            this.tableUsers.TabIndex = 14;
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.tableUsers.SetColumnSpan(this.lbTitulo, 2);
            this.lbTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbTitulo.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.Location = new System.Drawing.Point(3, 0);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(1134, 85);
            this.lbTitulo.TabIndex = 17;
            this.lbTitulo.Text = "Busca usuarios existenes en el sistema por medio de varias formas de filtrado";
            this.lbTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelContenido
            // 
            this.panelContenido.Controls.Add(this.status1);
            this.panelContenido.Controls.Add(this.area1);
            this.panelContenido.Controls.Add(this.sexo1);
            this.panelContenido.Controls.Add(this.ambosApellidos1);
            this.panelContenido.Controls.Add(this.nombres1);
            this.panelContenido.Controls.Add(this.numControl1);
            this.panelContenido.Controls.Add(this.lbSearch02);
            this.panelContenido.Controls.Add(this.comboTypeSearch);
            this.panelContenido.Controls.Add(this.btnSearch);
            this.panelContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenido.Location = new System.Drawing.Point(3, 88);
            this.panelContenido.Name = "panelContenido";
            this.panelContenido.Size = new System.Drawing.Size(834, 131);
            this.panelContenido.TabIndex = 16;
            // 
            // status1
            // 
            this.status1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(223)))), ((int)(((byte)(198)))));
            this.status1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.status1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.status1.Location = new System.Drawing.Point(13, 61);
            this.status1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.status1.Name = "status1";
            this.status1.Size = new System.Drawing.Size(746, 36);
            this.status1.TabIndex = 6;
            // 
            // area1
            // 
            this.area1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(223)))), ((int)(((byte)(198)))));
            this.area1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.area1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.area1.Location = new System.Drawing.Point(13, 61);
            this.area1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.area1.Name = "area1";
            this.area1.Size = new System.Drawing.Size(746, 36);
            this.area1.TabIndex = 5;
            // 
            // sexo1
            // 
            this.sexo1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(223)))), ((int)(((byte)(198)))));
            this.sexo1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.sexo1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.sexo1.Location = new System.Drawing.Point(13, 61);
            this.sexo1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.sexo1.Name = "sexo1";
            this.sexo1.Size = new System.Drawing.Size(746, 36);
            this.sexo1.TabIndex = 4;
            // 
            // ambosApellidos1
            // 
            this.ambosApellidos1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(223)))), ((int)(((byte)(198)))));
            this.ambosApellidos1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.ambosApellidos1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.ambosApellidos1.Location = new System.Drawing.Point(13, 61);
            this.ambosApellidos1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ambosApellidos1.Name = "ambosApellidos1";
            this.ambosApellidos1.Size = new System.Drawing.Size(746, 36);
            this.ambosApellidos1.TabIndex = 3;
            // 
            // nombres1
            // 
            this.nombres1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(223)))), ((int)(((byte)(198)))));
            this.nombres1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.nombres1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.nombres1.Location = new System.Drawing.Point(13, 61);
            this.nombres1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.nombres1.Name = "nombres1";
            this.nombres1.Size = new System.Drawing.Size(746, 36);
            this.nombres1.TabIndex = 3;
            // 
            // numControl1
            // 
            this.numControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(223)))), ((int)(((byte)(198)))));
            this.numControl1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.numControl1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.numControl1.Location = new System.Drawing.Point(13, 61);
            this.numControl1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.numControl1.Name = "numControl1";
            this.numControl1.Size = new System.Drawing.Size(746, 36);
            this.numControl1.TabIndex = 2;
            // 
            // lbSearch02
            // 
            this.lbSearch02.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSearch02.AutoSize = true;
            this.lbSearch02.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lbSearch02.Location = new System.Drawing.Point(9, 18);
            this.lbSearch02.Name = "lbSearch02";
            this.lbSearch02.Size = new System.Drawing.Size(97, 19);
            this.lbSearch02.TabIndex = 4;
            this.lbSearch02.Text = "Filtrar por:";
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = global::CapaPre.Properties.Resources.seach;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(767, 61);
            this.btnSearch.MaximumSize = new System.Drawing.Size(40, 40);
            this.btnSearch.MinimumSize = new System.Drawing.Size(40, 40);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(40, 40);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.EventoClick);
            // 
            // btnAllUsers
            // 
            this.btnAllUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAllUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAllUsers.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.btnAllUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAllUsers.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btnAllUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAllUsers.ImageKey = "searchClean.png";
            this.btnAllUsers.ImageList = this.imageList1;
            this.btnAllUsers.Location = new System.Drawing.Point(7, 3);
            this.btnAllUsers.MaximumSize = new System.Drawing.Size(284, 54);
            this.btnAllUsers.MinimumSize = new System.Drawing.Size(284, 54);
            this.btnAllUsers.Name = "btnAllUsers";
            this.btnAllUsers.Size = new System.Drawing.Size(284, 54);
            this.btnAllUsers.TabIndex = 0;
            this.btnAllUsers.TabStop = false;
            this.btnAllUsers.Text = "Limpiar búsqueda y volver \r\na mostrar todos los usuarios";
            this.btnAllUsers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAllUsers.UseVisualStyleBackColor = true;
            this.btnAllUsers.Click += new System.EventHandler(this.EventoClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbTotal);
            this.panel1.Controls.Add(this.btnAllUsers);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(843, 88);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(294, 131);
            this.panel1.TabIndex = 7;
            // 
            // lbTotal
            // 
            this.lbTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lbTotal.Location = new System.Drawing.Point(3, 103);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(160, 19);
            this.lbTotal.TabIndex = 24;
            this.lbTotal.Text = "Total de registros:";
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 507);
            this.Controls.Add(this.tableUsers);
            this.Name = "Users";
            this.Text = "Users";
            this.Load += new System.EventHandler(this.CargarVentana);
            ((System.ComponentModel.ISupportInitialize)(this.GridSearch)).EndInit();
            this.tableUsers.ResumeLayout(false);
            this.tableUsers.PerformLayout();
            this.panelContenido.ResumeLayout(false);
            this.panelContenido.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox comboTypeSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TableLayoutPanel tableUsers;
        private System.Windows.Forms.Panel panelContenido;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Button btnAllUsers;
        private System.Windows.Forms.Label lbSearch02;
        public System.Windows.Forms.DataGridView GridSearch;
        private Search.NumControl numControl1;
        private Search.Nombres nombres1;
        private Search.AmbosApellidos ambosApellidos1;
        private Search.Sexo sexo1;
        private Search.Area area1;
        private Search.Status status1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbTotal;
    }
}