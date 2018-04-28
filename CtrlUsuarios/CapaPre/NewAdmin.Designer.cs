namespace CapaPre
{
    partial class NewAdmin
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
            this.lbTitulo = new System.Windows.Forms.Label();
            this.tableNewAdmin = new System.Windows.Forms.TableLayoutPanel();
            this.panelContenido = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelDeleteAdmin = new System.Windows.Forms.Panel();
            this.panelEditAdmin = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.panelAddAdmin = new System.Windows.Forms.Panel();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.addAdmin1 = new CapaPre.AddAdmin();
            this.editAdmin1 = new CapaPre.EditAdmin();
            this.deleteAdmin1 = new CapaPre.DeleteAdmin();
            this.tableNewAdmin.SuspendLayout();
            this.panelContenido.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.tableNewAdmin.SetColumnSpan(this.lbTitulo, 3);
            this.lbTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbTitulo.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.Location = new System.Drawing.Point(3, 0);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.lbTitulo.Size = new System.Drawing.Size(1134, 80);
            this.lbTitulo.TabIndex = 17;
            this.lbTitulo.Text = "Crea un nuevo administrador o cambia el modo \"Super Usuario\" a uno ya existente";
            this.lbTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableNewAdmin
            // 
            this.tableNewAdmin.ColumnCount = 3;
            this.tableNewAdmin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableNewAdmin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableNewAdmin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableNewAdmin.Controls.Add(this.lbTitulo, 0, 0);
            this.tableNewAdmin.Controls.Add(this.panelContenido, 1, 2);
            this.tableNewAdmin.Controls.Add(this.panel1, 1, 1);
            this.tableNewAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableNewAdmin.Location = new System.Drawing.Point(0, 0);
            this.tableNewAdmin.Name = "tableNewAdmin";
            this.tableNewAdmin.RowCount = 3;
            this.tableNewAdmin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableNewAdmin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.29274F));
            this.tableNewAdmin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 74.70726F));
            this.tableNewAdmin.Size = new System.Drawing.Size(1140, 507);
            this.tableNewAdmin.TabIndex = 18;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panelDeleteAdmin);
            this.panel1.Controls.Add(this.panelEditAdmin);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.panelAddAdmin);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(60, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1020, 101);
            this.panel1.TabIndex = 20;
            // 
            // panelDeleteAdmin
            // 
            this.panelDeleteAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(43)))), ((int)(((byte)(73)))));
            this.panelDeleteAdmin.Location = new System.Drawing.Point(658, 89);
            this.panelDeleteAdmin.Name = "panelDeleteAdmin";
            this.panelDeleteAdmin.Size = new System.Drawing.Size(200, 4);
            this.panelDeleteAdmin.TabIndex = 5;
            // 
            // panelEditAdmin
            // 
            this.panelEditAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(43)))), ((int)(((byte)(73)))));
            this.panelEditAdmin.Location = new System.Drawing.Point(410, 89);
            this.panelEditAdmin.Name = "panelEditAdmin";
            this.panelEditAdmin.Size = new System.Drawing.Size(200, 4);
            this.panelEditAdmin.TabIndex = 3;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(223)))), ((int)(((byte)(198)))));
            this.btnDelete.Image = global::CapaPre.Properties.Resources.trash;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDelete.Location = new System.Drawing.Point(658, 0);
            this.btnDelete.MaximumSize = new System.Drawing.Size(200, 83);
            this.btnDelete.MinimumSize = new System.Drawing.Size(200, 83);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(200, 83);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Editar administrador";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.EventoClick);
            // 
            // panelAddAdmin
            // 
            this.panelAddAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(43)))), ((int)(((byte)(73)))));
            this.panelAddAdmin.Location = new System.Drawing.Point(162, 89);
            this.panelAddAdmin.Name = "panelAddAdmin";
            this.panelAddAdmin.Size = new System.Drawing.Size(200, 4);
            this.panelAddAdmin.TabIndex = 2;
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(223)))), ((int)(((byte)(198)))));
            this.btnEdit.Image = global::CapaPre.Properties.Resources.edit;
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEdit.Location = new System.Drawing.Point(410, 0);
            this.btnEdit.MaximumSize = new System.Drawing.Size(200, 83);
            this.btnEdit.MinimumSize = new System.Drawing.Size(200, 83);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(200, 83);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Editar administrador";
            this.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.EventoClick);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(223)))), ((int)(((byte)(198)))));
            this.btnAdd.Image = global::CapaPre.Properties.Resources.add;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAdd.Location = new System.Drawing.Point(162, 0);
            this.btnAdd.MaximumSize = new System.Drawing.Size(200, 83);
            this.btnAdd.MinimumSize = new System.Drawing.Size(200, 83);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(200, 83);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Nuevo administrador";
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.EventoClick);
            // 
            // NewAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(223)))), ((int)(((byte)(198)))));
            this.Controls.Add(this.tableNewAdmin);
            this.Font = new System.Drawing.Font("Tahoma", 12F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "NewAdmin";
            this.Size = new System.Drawing.Size(1140, 507);
            this.tableNewAdmin.ResumeLayout(false);
            this.tableNewAdmin.PerformLayout();
            this.panelContenido.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            // 
            // panelContenido
            // 
            this.panelContenido.Controls.Add(this.deleteAdmin1);
            this.panelContenido.Controls.Add(this.addAdmin1);
            this.panelContenido.Controls.Add(this.editAdmin1);
            this.panelContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenido.Location = new System.Drawing.Point(60, 190);
            this.panelContenido.Name = "panelContenido";
            this.panelContenido.Size = new System.Drawing.Size(1020, 314);
            this.panelContenido.TabIndex = 18;
            // 
            // addAdmin1
            // 
            this.addAdmin1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(223)))), ((int)(((byte)(198)))));
            this.addAdmin1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.addAdmin1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.addAdmin1.Location = new System.Drawing.Point(112, 4);
            this.addAdmin1.Margin = new System.Windows.Forms.Padding(4);
            this.addAdmin1.Name = "addAdmin1";
            this.addAdmin1.Size = new System.Drawing.Size(100, 100);
            this.addAdmin1.TabIndex = 1;
            // 
            // editAdmin1
            // 
            this.editAdmin1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(223)))), ((int)(((byte)(198)))));
            this.editAdmin1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.editAdmin1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.editAdmin1.Location = new System.Drawing.Point(4, 4);
            this.editAdmin1.Margin = new System.Windows.Forms.Padding(4);
            this.editAdmin1.Name = "editAdmin1";
            this.editAdmin1.Size = new System.Drawing.Size(100, 100);
            this.editAdmin1.TabIndex = 0;
            // 
            // deleteAdmin1
            // 
            this.deleteAdmin1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(223)))), ((int)(((byte)(198)))));
            this.deleteAdmin1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.deleteAdmin1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.deleteAdmin1.Location = new System.Drawing.Point(232, 4);
            this.deleteAdmin1.Margin = new System.Windows.Forms.Padding(4);
            this.deleteAdmin1.Name = "deleteAdmin1";
            this.deleteAdmin1.Size = new System.Drawing.Size(100, 100);
            this.deleteAdmin1.TabIndex = 2;

        }

        #endregion
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.TableLayoutPanel tableNewAdmin;
        private System.Windows.Forms.Panel panelContenido;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Panel panelAddAdmin;
        private System.Windows.Forms.Panel panelEditAdmin;
        private System.Windows.Forms.Panel panelDeleteAdmin;
        private System.Windows.Forms.Button btnDelete;
        private DeleteAdmin deleteAdmin1;
        private EditAdmin editAdmin1;
        private AddAdmin addAdmin1;
    }
}