namespace CapaPre
{
    partial class EditAdmin : FatherConfig
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditAdmin));
            this.tableEditAdmin = new System.Windows.Forms.TableLayoutPanel();
            this.gridEditAdmin = new System.Windows.Forms.DataGridView();
            this.panelOpciones = new System.Windows.Forms.Panel();
            this.lbSuperUsuario = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioN = new System.Windows.Forms.RadioButton();
            this.radioS = new System.Windows.Forms.RadioButton();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnAceptar = new System.Windows.Forms.Button();
            this.tableEditAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridEditAdmin)).BeginInit();
            this.panelOpciones.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableEditAdmin
            // 
            this.tableEditAdmin.ColumnCount = 1;
            this.tableEditAdmin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableEditAdmin.Controls.Add(this.gridEditAdmin, 0, 0);
            this.tableEditAdmin.Controls.Add(this.panelOpciones, 0, 1);
            this.tableEditAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableEditAdmin.Location = new System.Drawing.Point(0, 0);
            this.tableEditAdmin.Name = "tableEditAdmin";
            this.tableEditAdmin.RowCount = 2;
            this.tableEditAdmin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57.50708F));
            this.tableEditAdmin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.49292F));
            this.tableEditAdmin.Size = new System.Drawing.Size(1140, 353);
            this.tableEditAdmin.TabIndex = 1;
            // 
            // gridEditAdmin
            // 
            this.gridEditAdmin.AllowUserToAddRows = false;
            this.gridEditAdmin.AllowUserToDeleteRows = false;
            this.gridEditAdmin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridEditAdmin.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.gridEditAdmin.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(223)))), ((int)(((byte)(198)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridEditAdmin.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridEditAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridEditAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gridEditAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridEditAdmin.Location = new System.Drawing.Point(3, 3);
            this.gridEditAdmin.MultiSelect = false;
            this.gridEditAdmin.Name = "gridEditAdmin";
            this.gridEditAdmin.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridEditAdmin.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridEditAdmin.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridEditAdmin.Size = new System.Drawing.Size(1134, 196);
            this.gridEditAdmin.TabIndex = 0;
            this.gridEditAdmin.TabStop = false;
            // 
            // panelOpciones
            // 
            this.panelOpciones.Controls.Add(this.lbSuperUsuario);
            this.panelOpciones.Controls.Add(this.groupBox1);
            this.panelOpciones.Controls.Add(this.btnCancelar);
            this.panelOpciones.Controls.Add(this.btnAceptar);
            this.panelOpciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOpciones.Location = new System.Drawing.Point(3, 205);
            this.panelOpciones.Name = "panelOpciones";
            this.panelOpciones.Size = new System.Drawing.Size(1134, 145);
            this.panelOpciones.TabIndex = 1;
            // 
            // lbSuperUsuario
            // 
            this.lbSuperUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSuperUsuario.AutoSize = true;
            this.lbSuperUsuario.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lbSuperUsuario.Location = new System.Drawing.Point(19, 16);
            this.lbSuperUsuario.Name = "lbSuperUsuario";
            this.lbSuperUsuario.Size = new System.Drawing.Size(418, 19);
            this.lbSuperUsuario.TabIndex = 39;
            this.lbSuperUsuario.Text = "Permitir al administrador el modo \"Super Usuario\"";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.radioN);
            this.groupBox1.Controls.Add(this.radioS);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 14F);
            this.groupBox1.Location = new System.Drawing.Point(166, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(125, 48);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            // 
            // radioN
            // 
            this.radioN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioN.AutoSize = true;
            this.radioN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioN.Location = new System.Drawing.Point(61, 11);
            this.radioN.Name = "radioN";
            this.radioN.Size = new System.Drawing.Size(51, 27);
            this.radioN.TabIndex = 4;
            this.radioN.TabStop = true;
            this.radioN.Text = "No";
            this.radioN.UseVisualStyleBackColor = true;
            // 
            // radioS
            // 
            this.radioS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioS.AutoSize = true;
            this.radioS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioS.Location = new System.Drawing.Point(12, 11);
            this.radioS.Name = "radioS";
            this.radioS.Size = new System.Drawing.Size(43, 27);
            this.radioS.TabIndex = 3;
            this.radioS.TabStop = true;
            this.radioS.Text = "Si";
            this.radioS.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.ImageKey = "delete.png";
            this.btnCancelar.ImageList = this.imageList1;
            this.btnCancelar.Location = new System.Drawing.Point(922, 97);
            this.btnCancelar.MaximumSize = new System.Drawing.Size(203, 39);
            this.btnCancelar.MinimumSize = new System.Drawing.Size(203, 39);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(203, 39);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.TabStop = false;
            this.btnCancelar.Text = "Cancelar la edición";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.EventoClick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "aceptar.png");
            this.imageList1.Images.SetKeyName(1, "delete.png");
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAceptar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAceptar.ImageKey = "aceptar.png";
            this.btnAceptar.ImageList = this.imageList1;
            this.btnAceptar.Location = new System.Drawing.Point(684, 97);
            this.btnAceptar.MaximumSize = new System.Drawing.Size(203, 39);
            this.btnAceptar.MinimumSize = new System.Drawing.Size(203, 39);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(203, 39);
            this.btnAceptar.TabIndex = 5;
            this.btnAceptar.TabStop = false;
            this.btnAceptar.Text = "Aceptar y terminar";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.EventoClick);
            // 
            // EditAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 353);
            this.Controls.Add(this.tableEditAdmin);
            this.Name = "EditAdmin";
            this.Text = "EditAdmin";
            this.ParentChanged += new System.EventHandler(this.CargarVentana);
            this.tableEditAdmin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridEditAdmin)).EndInit();
            this.panelOpciones.ResumeLayout(false);
            this.panelOpciones.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableEditAdmin;
        private System.Windows.Forms.Panel panelOpciones;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lbSuperUsuario;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioN;
        private System.Windows.Forms.RadioButton radioS;
        private System.Windows.Forms.ImageList imageList1;
        public System.Windows.Forms.DataGridView gridEditAdmin;
    }
}