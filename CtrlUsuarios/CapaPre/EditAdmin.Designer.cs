namespace CapaPre
{
    partial class EditAdmin
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditAdmin));
            this.tableEditAdmin = new System.Windows.Forms.TableLayoutPanel();
            this.GridAdmin = new System.Windows.Forms.DataGridView();
            this.panelEditSuperUs = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioN = new System.Windows.Forms.RadioButton();
            this.radioS = new System.Windows.Forms.RadioButton();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnAceptar = new System.Windows.Forms.Button();
            this.tableEditAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridAdmin)).BeginInit();
            this.panelEditSuperUs.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableEditAdmin
            // 
            this.tableEditAdmin.ColumnCount = 1;
            this.tableEditAdmin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableEditAdmin.Controls.Add(this.GridAdmin, 0, 0);
            this.tableEditAdmin.Controls.Add(this.panelEditSuperUs, 0, 1);
            this.tableEditAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableEditAdmin.Location = new System.Drawing.Point(0, 0);
            this.tableEditAdmin.Name = "tableEditAdmin";
            this.tableEditAdmin.RowCount = 2;
            this.tableEditAdmin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 63.05732F));
            this.tableEditAdmin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.94268F));
            this.tableEditAdmin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableEditAdmin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableEditAdmin.Size = new System.Drawing.Size(1020, 314);
            this.tableEditAdmin.TabIndex = 25;
            // 
            // GridAdmin
            // 
            this.GridAdmin.AllowUserToAddRows = false;
            this.GridAdmin.AllowUserToDeleteRows = false;
            this.GridAdmin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridAdmin.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.GridAdmin.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(223)))), ((int)(((byte)(198)))));
            this.GridAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GridAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridAdmin.Location = new System.Drawing.Point(3, 3);
            this.GridAdmin.MultiSelect = false;
            this.GridAdmin.Name = "GridAdmin";
            this.GridAdmin.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.GridAdmin.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.GridAdmin.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridAdmin.Size = new System.Drawing.Size(1014, 191);
            this.GridAdmin.TabIndex = 0;
            // 
            // panelEditSuperUs
            // 
            this.panelEditSuperUs.Controls.Add(this.label1);
            this.panelEditSuperUs.Controls.Add(this.groupBox1);
            this.panelEditSuperUs.Controls.Add(this.btnCancelar);
            this.panelEditSuperUs.Controls.Add(this.btnAceptar);
            this.panelEditSuperUs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEditSuperUs.Location = new System.Drawing.Point(3, 200);
            this.panelEditSuperUs.Name = "panelEditSuperUs";
            this.panelEditSuperUs.Size = new System.Drawing.Size(1014, 111);
            this.panelEditSuperUs.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(16, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(533, 19);
            this.label1.TabIndex = 28;
            this.label1.Text = "Permitir al administrador seleccionado el modo \"Super Usuario\":";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioN);
            this.groupBox1.Controls.Add(this.radioS);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 14F);
            this.groupBox1.Location = new System.Drawing.Point(555, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(136, 50);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            // 
            // radioN
            // 
            this.radioN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioN.AutoSize = true;
            this.radioN.Location = new System.Drawing.Point(65, 16);
            this.radioN.Name = "radioN";
            this.radioN.Size = new System.Drawing.Size(51, 27);
            this.radioN.TabIndex = 2;
            this.radioN.TabStop = true;
            this.radioN.Text = "No";
            this.radioN.UseVisualStyleBackColor = true;
            this.radioN.CheckedChanged += new System.EventHandler(this.ConfirmarSuperUsuario);
            // 
            // radioS
            // 
            this.radioS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioS.AutoSize = true;
            this.radioS.Location = new System.Drawing.Point(6, 16);
            this.radioS.Name = "radioS";
            this.radioS.Size = new System.Drawing.Size(43, 27);
            this.radioS.TabIndex = 1;
            this.radioS.TabStop = true;
            this.radioS.Text = "Si";
            this.radioS.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.ImageKey = "delete.png";
            this.btnCancelar.ImageList = this.imageList1;
            this.btnCancelar.Location = new System.Drawing.Point(808, 69);
            this.btnCancelar.MaximumSize = new System.Drawing.Size(203, 39);
            this.btnCancelar.MinimumSize = new System.Drawing.Size(203, 39);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(203, 39);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar la edición";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
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
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAceptar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAceptar.ImageKey = "aceptar.png";
            this.btnAceptar.ImageList = this.imageList1;
            this.btnAceptar.Location = new System.Drawing.Point(808, 14);
            this.btnAceptar.MaximumSize = new System.Drawing.Size(203, 39);
            this.btnAceptar.MinimumSize = new System.Drawing.Size(203, 39);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(203, 39);
            this.btnAceptar.TabIndex = 3;
            this.btnAceptar.Text = "Aceptar y terminar";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // EditAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(223)))), ((int)(((byte)(198)))));
            this.Controls.Add(this.tableEditAdmin);
            this.Font = new System.Drawing.Font("Tahoma", 12F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EditAdmin";
            this.Size = new System.Drawing.Size(1020, 314);
            this.tableEditAdmin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridAdmin)).EndInit();
            this.panelEditSuperUs.ResumeLayout(false);
            this.panelEditSuperUs.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TableLayoutPanel tableEditAdmin;
        private System.Windows.Forms.Panel panelEditSuperUs;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioN;
        private System.Windows.Forms.RadioButton radioS;
        public System.Windows.Forms.DataGridView GridAdmin;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label1;
    }
}
