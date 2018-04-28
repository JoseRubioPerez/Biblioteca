namespace CapaPre
{
    partial class DeleteAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteAdmin));
            this.tableEditAdmin = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.GridAdmin = new System.Windows.Forms.DataGridView();
            this.panelEditSuperUs = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnAceptar = new System.Windows.Forms.Button();
            this.tableEditAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridAdmin)).BeginInit();
            this.panelEditSuperUs.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableEditAdmin
            // 
            this.tableEditAdmin.ColumnCount = 1;
            this.tableEditAdmin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableEditAdmin.Controls.Add(this.label1, 0, 0);
            this.tableEditAdmin.Controls.Add(this.GridAdmin, 0, 1);
            this.tableEditAdmin.Controls.Add(this.panelEditSuperUs, 0, 2);
            this.tableEditAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableEditAdmin.Location = new System.Drawing.Point(0, 0);
            this.tableEditAdmin.Name = "tableEditAdmin";
            this.tableEditAdmin.RowCount = 3;
            this.tableEditAdmin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.tableEditAdmin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableEditAdmin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableEditAdmin.Size = new System.Drawing.Size(1020, 314);
            this.tableEditAdmin.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1014, 73);
            this.label1.TabIndex = 29;
            this.label1.Text = "Verifique que seleccionó el administrador correcto antes de eliminar. Sí elimina " +
    "un administrador de manera equivocada, tendrá que volver a hacer el registro del" +
    " mismo.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.GridAdmin.Location = new System.Drawing.Point(3, 76);
            this.GridAdmin.MultiSelect = false;
            this.GridAdmin.Name = "GridAdmin";
            this.GridAdmin.ReadOnly = true;
            this.GridAdmin.RowHeadersWidth = 48;
            this.GridAdmin.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.GridAdmin.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.GridAdmin.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridAdmin.Size = new System.Drawing.Size(1014, 162);
            this.GridAdmin.TabIndex = 0;
            this.GridAdmin.TabStop = false;
            // 
            // panelEditSuperUs
            // 
            this.panelEditSuperUs.Controls.Add(this.btnCancelar);
            this.panelEditSuperUs.Controls.Add(this.btnAceptar);
            this.panelEditSuperUs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEditSuperUs.Location = new System.Drawing.Point(3, 244);
            this.panelEditSuperUs.Name = "panelEditSuperUs";
            this.panelEditSuperUs.Size = new System.Drawing.Size(1014, 67);
            this.panelEditSuperUs.TabIndex = 1;
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
            this.btnCancelar.Location = new System.Drawing.Point(718, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(293, 39);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.TabStop = false;
            this.btnCancelar.Text = "Cancelar la operación de eliminar";
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
            this.btnAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAceptar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAceptar.ImageKey = "aceptar.png";
            this.btnAceptar.ImageList = this.imageList1;
            this.btnAceptar.Location = new System.Drawing.Point(3, 3);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(291, 39);
            this.btnAceptar.TabIndex = 3;
            this.btnAceptar.TabStop = false;
            this.btnAceptar.Text = "Aceptar y eliminar administrador";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.EventoClick);
            // 
            // DeleteAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(223)))), ((int)(((byte)(198)))));
            this.Controls.Add(this.tableEditAdmin);
            this.Font = new System.Drawing.Font("Tahoma", 12F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DeleteAdmin";
            this.Size = new System.Drawing.Size(1020, 314);
            this.tableEditAdmin.ResumeLayout(false);
            this.tableEditAdmin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridAdmin)).EndInit();
            this.panelEditSuperUs.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableEditAdmin;
        public System.Windows.Forms.DataGridView GridAdmin;
        private System.Windows.Forms.Panel panelEditSuperUs;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label1;
    }
}
