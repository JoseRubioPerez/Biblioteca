namespace Application
{
    partial class Moves
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Moves));
            this.tableMoves = new System.Windows.Forms.TableLayoutPanel();
            this.GridSearch = new System.Windows.Forms.DataGridView();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.panelPDF = new System.Windows.Forms.Panel();
            this.btnPDF = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panelSearch = new System.Windows.Forms.Panel();
            this.btnAllUsers = new System.Windows.Forms.Button();
            this.fecha1 = new Application.Search.DateFilter();
            this.servicio1 = new Application.Search.Service();
            this.numControl1 = new Application.Search.NumCtrl();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lbTotal = new System.Windows.Forms.Label();
            this.comboTypeMoves = new System.Windows.Forms.ComboBox();
            this.lbMoves = new System.Windows.Forms.Label();
            this.tableMoves.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridSearch)).BeginInit();
            this.panelPDF.SuspendLayout();
            this.panelSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableMoves
            // 
            this.tableMoves.ColumnCount = 1;
            this.tableMoves.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableMoves.Controls.Add(this.GridSearch, 0, 2);
            this.tableMoves.Controls.Add(this.lbTitulo, 0, 0);
            this.tableMoves.Controls.Add(this.panelPDF, 0, 3);
            this.tableMoves.Controls.Add(this.panelSearch, 0, 1);
            this.tableMoves.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableMoves.Location = new System.Drawing.Point(0, 0);
            this.tableMoves.Name = "tableMoves";
            this.tableMoves.RowCount = 4;
            this.tableMoves.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.88172F));
            this.tableMoves.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 73.11828F));
            this.tableMoves.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 256F));
            this.tableMoves.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableMoves.Size = new System.Drawing.Size(1140, 507);
            this.tableMoves.TabIndex = 0;
            // 
            // GridSearch
            // 
            this.GridSearch.AllowUserToAddRows = false;
            this.GridSearch.AllowUserToDeleteRows = false;
            this.GridSearch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridSearch.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.GridSearch.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(223)))), ((int)(((byte)(198)))));
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridSearch.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.GridSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GridSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridSearch.Location = new System.Drawing.Point(3, 189);
            this.GridSearch.Name = "GridSearch";
            this.GridSearch.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridSearch.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.GridSearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridSearch.Size = new System.Drawing.Size(1134, 250);
            this.GridSearch.TabIndex = 20;
            this.GridSearch.TabStop = false;
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbTitulo.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.Location = new System.Drawing.Point(3, 0);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(1134, 50);
            this.lbTitulo.TabIndex = 18;
            this.lbTitulo.Text = "Mira los movimientos que consultan los usuarios en el centro de información";
            this.lbTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelPDF
            // 
            this.panelPDF.Controls.Add(this.btnPDF);
            this.panelPDF.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPDF.Location = new System.Drawing.Point(3, 445);
            this.panelPDF.Name = "panelPDF";
            this.panelPDF.Size = new System.Drawing.Size(1134, 59);
            this.panelPDF.TabIndex = 19;
            // 
            // btnPDF
            // 
            this.btnPDF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPDF.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnPDF.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.btnPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPDF.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btnPDF.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPDF.ImageKey = "pdf.png";
            this.btnPDF.ImageList = this.imageList1;
            this.btnPDF.Location = new System.Drawing.Point(599, 0);
            this.btnPDF.MaximumSize = new System.Drawing.Size(535, 59);
            this.btnPDF.MinimumSize = new System.Drawing.Size(535, 59);
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.Size = new System.Drawing.Size(535, 59);
            this.btnPDF.TabIndex = 1;
            this.btnPDF.TabStop = false;
            this.btnPDF.Text = " Generar reporte con los datos actuales que hay en la tabla";
            this.btnPDF.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPDF.UseVisualStyleBackColor = true;
            this.btnPDF.Click += new System.EventHandler(this.EventoClick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "pdf.png");
            this.imageList1.Images.SetKeyName(1, "searchClean.png");
            // 
            // panelSearch
            // 
            this.panelSearch.Controls.Add(this.btnAllUsers);
            this.panelSearch.Controls.Add(this.fecha1);
            this.panelSearch.Controls.Add(this.servicio1);
            this.panelSearch.Controls.Add(this.numControl1);
            this.panelSearch.Controls.Add(this.btnSearch);
            this.panelSearch.Controls.Add(this.lbTotal);
            this.panelSearch.Controls.Add(this.comboTypeMoves);
            this.panelSearch.Controls.Add(this.lbMoves);
            this.panelSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSearch.Location = new System.Drawing.Point(3, 53);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(1134, 130);
            this.panelSearch.TabIndex = 21;
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
            this.btnAllUsers.Location = new System.Drawing.Point(856, 3);
            this.btnAllUsers.MaximumSize = new System.Drawing.Size(269, 45);
            this.btnAllUsers.MinimumSize = new System.Drawing.Size(269, 45);
            this.btnAllUsers.Name = "btnAllUsers";
            this.btnAllUsers.Size = new System.Drawing.Size(269, 45);
            this.btnAllUsers.TabIndex = 28;
            this.btnAllUsers.TabStop = false;
            this.btnAllUsers.Text = "Mostrar todos los usuarios";
            this.btnAllUsers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAllUsers.UseVisualStyleBackColor = true;
            this.btnAllUsers.Click += new System.EventHandler(this.EventoClick);
            // 
            // fecha1
            // 
            this.fecha1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(223)))), ((int)(((byte)(198)))));
            this.fecha1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.fecha1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.fecha1.Location = new System.Drawing.Point(11, 61);
            this.fecha1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.fecha1.Name = "fecha1";
            this.fecha1.Size = new System.Drawing.Size(528, 36);
            this.fecha1.TabIndex = 27;
            // 
            // servicio1
            // 
            this.servicio1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(223)))), ((int)(((byte)(198)))));
            this.servicio1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.servicio1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.servicio1.Location = new System.Drawing.Point(11, 61);
            this.servicio1.Margin = new System.Windows.Forms.Padding(4);
            this.servicio1.Name = "servicio1";
            this.servicio1.Size = new System.Drawing.Size(528, 36);
            this.servicio1.TabIndex = 26;
            // 
            // numControl1
            // 
            this.numControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(223)))), ((int)(((byte)(198)))));
            this.numControl1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.numControl1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.numControl1.Location = new System.Drawing.Point(11, 61);
            this.numControl1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.numControl1.Name = "numControl1";
            this.numControl1.Size = new System.Drawing.Size(528, 36);
            this.numControl1.TabIndex = 25;
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = global::Application.Properties.Resources.search;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(547, 61);
            this.btnSearch.MaximumSize = new System.Drawing.Size(40, 40);
            this.btnSearch.MinimumSize = new System.Drawing.Size(40, 40);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(40, 40);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.EventoClick);
            // 
            // lbTotal
            // 
            this.lbTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lbTotal.Location = new System.Drawing.Point(889, 100);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(160, 19);
            this.lbTotal.TabIndex = 23;
            this.lbTotal.Text = "Total de registros:";
            // 
            // comboTypeMoves
            // 
            this.comboTypeMoves.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboTypeMoves.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboTypeMoves.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTypeMoves.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboTypeMoves.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.comboTypeMoves.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.comboTypeMoves.FormattingEnabled = true;
            this.comboTypeMoves.Items.AddRange(new object[] {
            "Número de Control",
            "Servicio utilizado",
            "Fecha"});
            this.comboTypeMoves.Location = new System.Drawing.Point(225, 13);
            this.comboTypeMoves.MaximumSize = new System.Drawing.Size(275, 0);
            this.comboTypeMoves.MinimumSize = new System.Drawing.Size(275, 0);
            this.comboTypeMoves.Name = "comboTypeMoves";
            this.comboTypeMoves.Size = new System.Drawing.Size(275, 27);
            this.comboTypeMoves.TabIndex = 1;
            this.comboTypeMoves.SelectedIndexChanged += new System.EventHandler(this.ValidarCombo);
            // 
            // lbMoves
            // 
            this.lbMoves.AutoSize = true;
            this.lbMoves.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lbMoves.Location = new System.Drawing.Point(9, 16);
            this.lbMoves.Name = "lbMoves";
            this.lbMoves.Size = new System.Drawing.Size(210, 19);
            this.lbMoves.TabIndex = 21;
            this.lbMoves.Text = "Buscar movimientos por:";
            // 
            // Moves
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 507);
            this.Controls.Add(this.tableMoves);
            this.Name = "Moves";
            this.Text = "Moves";
            this.Load += new System.EventHandler(this.CargarVentana);
            this.tableMoves.ResumeLayout(false);
            this.tableMoves.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridSearch)).EndInit();
            this.panelPDF.ResumeLayout(false);
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableMoves;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Panel panelPDF;
        public System.Windows.Forms.DataGridView GridSearch;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnPDF;
        private System.Windows.Forms.Label lbMoves;
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.ComboBox comboTypeMoves;
        private System.Windows.Forms.Button btnSearch;
        private Search.NumCtrl numControl1;
        private Search.Service servicio1;
        private Search.DateFilter fecha1;
        private System.Windows.Forms.Button btnAllUsers;
    }
}