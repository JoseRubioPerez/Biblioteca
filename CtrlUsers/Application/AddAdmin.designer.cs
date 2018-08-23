namespace Application
{
    partial class AddAdmin : FatherConfig
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAdmin));
            this.tableAddAdmin = new System.Windows.Forms.TableLayoutPanel();
            this.gridAddAdmin = new System.Windows.Forms.DataGridView();
            this.panelOpciones = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lbSuperUsuario = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioN = new System.Windows.Forms.RadioButton();
            this.radioS = new System.Windows.Forms.RadioButton();
            this.panelConfirmPassword = new System.Windows.Forms.Panel();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.pictureShowPass2 = new System.Windows.Forms.PictureBox();
            this.panelMyPassword = new System.Windows.Forms.Panel();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.pictureShowPass1 = new System.Windows.Forms.PictureBox();
            this.lbConfirmPassword = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.tableAddAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridAddAdmin)).BeginInit();
            this.panelOpciones.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureShowPass2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureShowPass1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableAddAdmin
            // 
            this.tableAddAdmin.ColumnCount = 1;
            this.tableAddAdmin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableAddAdmin.Controls.Add(this.gridAddAdmin, 0, 0);
            this.tableAddAdmin.Controls.Add(this.panelOpciones, 0, 1);
            this.tableAddAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableAddAdmin.Location = new System.Drawing.Point(0, 0);
            this.tableAddAdmin.Name = "tableAddAdmin";
            this.tableAddAdmin.RowCount = 2;
            this.tableAddAdmin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.05949F));
            this.tableAddAdmin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 56.94051F));
            this.tableAddAdmin.Size = new System.Drawing.Size(1140, 353);
            this.tableAddAdmin.TabIndex = 0;
            // 
            // gridAddAdmin
            // 
            this.gridAddAdmin.AllowUserToAddRows = false;
            this.gridAddAdmin.AllowUserToDeleteRows = false;
            this.gridAddAdmin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridAddAdmin.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.gridAddAdmin.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(223)))), ((int)(((byte)(198)))));
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 12F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridAddAdmin.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.gridAddAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAddAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gridAddAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridAddAdmin.Location = new System.Drawing.Point(3, 3);
            this.gridAddAdmin.MultiSelect = false;
            this.gridAddAdmin.Name = "gridAddAdmin";
            this.gridAddAdmin.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 12F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridAddAdmin.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.gridAddAdmin.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridAddAdmin.Size = new System.Drawing.Size(1134, 146);
            this.gridAddAdmin.TabIndex = 0;
            this.gridAddAdmin.TabStop = false;
            // 
            // panelOpciones
            // 
            this.panelOpciones.Controls.Add(this.btnCancelar);
            this.panelOpciones.Controls.Add(this.btnAceptar);
            this.panelOpciones.Controls.Add(this.lbSuperUsuario);
            this.panelOpciones.Controls.Add(this.groupBox1);
            this.panelOpciones.Controls.Add(this.panelConfirmPassword);
            this.panelOpciones.Controls.Add(this.txtConfirmPassword);
            this.panelOpciones.Controls.Add(this.pictureShowPass2);
            this.panelOpciones.Controls.Add(this.panelMyPassword);
            this.panelOpciones.Controls.Add(this.txtNewPassword);
            this.panelOpciones.Controls.Add(this.pictureShowPass1);
            this.panelOpciones.Controls.Add(this.lbConfirmPassword);
            this.panelOpciones.Controls.Add(this.lbPassword);
            this.panelOpciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOpciones.Location = new System.Drawing.Point(3, 155);
            this.panelOpciones.MinimumSize = new System.Drawing.Size(0, 195);
            this.panelOpciones.Name = "panelOpciones";
            this.panelOpciones.Size = new System.Drawing.Size(1134, 195);
            this.panelOpciones.TabIndex = 1;
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
            this.btnCancelar.Location = new System.Drawing.Point(1006, 147);
            this.btnCancelar.MaximumSize = new System.Drawing.Size(119, 39);
            this.btnCancelar.MinimumSize = new System.Drawing.Size(119, 39);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(119, 39);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.TabStop = false;
            this.btnCancelar.Text = "Cancelar";
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
            this.btnAceptar.Location = new System.Drawing.Point(791, 147);
            this.btnAceptar.MaximumSize = new System.Drawing.Size(182, 39);
            this.btnAceptar.MinimumSize = new System.Drawing.Size(182, 39);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(182, 39);
            this.btnAceptar.TabIndex = 5;
            this.btnAceptar.TabStop = false;
            this.btnAceptar.Text = "Aceptar y agregar";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.EventoClick);
            // 
            // lbSuperUsuario
            // 
            this.lbSuperUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSuperUsuario.AutoSize = true;
            this.lbSuperUsuario.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lbSuperUsuario.Location = new System.Drawing.Point(701, 17);
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
            this.groupBox1.Location = new System.Drawing.Point(848, 40);
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
            this.radioN.CheckedChanged += new System.EventHandler(this.ConfirmPassword);
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
            // panelConfirmPassword
            // 
            this.panelConfirmPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.panelConfirmPassword.Location = new System.Drawing.Point(215, 81);
            this.panelConfirmPassword.MaximumSize = new System.Drawing.Size(282, 3);
            this.panelConfirmPassword.MinimumSize = new System.Drawing.Size(282, 3);
            this.panelConfirmPassword.Name = "panelConfirmPassword";
            this.panelConfirmPassword.Size = new System.Drawing.Size(282, 3);
            this.panelConfirmPassword.TabIndex = 36;
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(223)))), ((int)(((byte)(198)))));
            this.txtConfirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConfirmPassword.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.txtConfirmPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.txtConfirmPassword.Location = new System.Drawing.Point(215, 58);
            this.txtConfirmPassword.MaximumSize = new System.Drawing.Size(282, 20);
            this.txtConfirmPassword.MaxLength = 16;
            this.txtConfirmPassword.MinimumSize = new System.Drawing.Size(282, 20);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '*';
            this.txtConfirmPassword.Size = new System.Drawing.Size(282, 26);
            this.txtConfirmPassword.TabIndex = 2;
            this.txtConfirmPassword.TextChanged += new System.EventHandler(this.ConfirmPassword);
            // 
            // pictureShowPass2
            // 
            this.pictureShowPass2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureShowPass2.Image = global::Application.Properties.Resources.showPass;
            this.pictureShowPass2.Location = new System.Drawing.Point(503, 58);
            this.pictureShowPass2.MaximumSize = new System.Drawing.Size(30, 30);
            this.pictureShowPass2.MinimumSize = new System.Drawing.Size(30, 30);
            this.pictureShowPass2.Name = "pictureShowPass2";
            this.pictureShowPass2.Size = new System.Drawing.Size(30, 30);
            this.pictureShowPass2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureShowPass2.TabIndex = 37;
            this.pictureShowPass2.TabStop = false;
            this.pictureShowPass2.Click += new System.EventHandler(this.EventoClick);
            // 
            // panelMyPassword
            // 
            this.panelMyPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.panelMyPassword.Location = new System.Drawing.Point(313, 35);
            this.panelMyPassword.MaximumSize = new System.Drawing.Size(282, 3);
            this.panelMyPassword.MinimumSize = new System.Drawing.Size(282, 3);
            this.panelMyPassword.Name = "panelMyPassword";
            this.panelMyPassword.Size = new System.Drawing.Size(282, 3);
            this.panelMyPassword.TabIndex = 34;
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(223)))), ((int)(((byte)(198)))));
            this.txtNewPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNewPassword.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.txtNewPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.txtNewPassword.Location = new System.Drawing.Point(313, 12);
            this.txtNewPassword.MaximumSize = new System.Drawing.Size(282, 20);
            this.txtNewPassword.MaxLength = 16;
            this.txtNewPassword.MinimumSize = new System.Drawing.Size(282, 20);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.PasswordChar = '*';
            this.txtNewPassword.Size = new System.Drawing.Size(282, 26);
            this.txtNewPassword.TabIndex = 1;
            // 
            // pictureShowPass1
            // 
            this.pictureShowPass1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureShowPass1.Image = global::Application.Properties.Resources.showPass;
            this.pictureShowPass1.Location = new System.Drawing.Point(601, 8);
            this.pictureShowPass1.MaximumSize = new System.Drawing.Size(30, 30);
            this.pictureShowPass1.MinimumSize = new System.Drawing.Size(30, 30);
            this.pictureShowPass1.Name = "pictureShowPass1";
            this.pictureShowPass1.Size = new System.Drawing.Size(30, 30);
            this.pictureShowPass1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureShowPass1.TabIndex = 35;
            this.pictureShowPass1.TabStop = false;
            this.pictureShowPass1.Click += new System.EventHandler(this.EventoClick);
            // 
            // lbConfirmPassword
            // 
            this.lbConfirmPassword.AutoSize = true;
            this.lbConfirmPassword.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lbConfirmPassword.Location = new System.Drawing.Point(18, 63);
            this.lbConfirmPassword.Name = "lbConfirmPassword";
            this.lbConfirmPassword.Size = new System.Drawing.Size(191, 19);
            this.lbConfirmPassword.TabIndex = 33;
            this.lbConfirmPassword.Text = "Confirmar contraseña:";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lbPassword.Location = new System.Drawing.Point(18, 17);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(289, 19);
            this.lbPassword.TabIndex = 32;
            this.lbPassword.Text = "Contraseña para el administrador:";
            // 
            // AddAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 353);
            this.Controls.Add(this.tableAddAdmin);
            this.Name = "AddAdmin";
            this.Text = "AddAdmin";
            this.ParentChanged += new System.EventHandler(this.CargarVentana);
            this.tableAddAdmin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridAddAdmin)).EndInit();
            this.panelOpciones.ResumeLayout(false);
            this.panelOpciones.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureShowPass2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureShowPass1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableAddAdmin;
        private System.Windows.Forms.Panel panelOpciones;
        private System.Windows.Forms.Label lbSuperUsuario;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioN;
        private System.Windows.Forms.RadioButton radioS;
        private System.Windows.Forms.Panel panelConfirmPassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.PictureBox pictureShowPass2;
        private System.Windows.Forms.Panel panelMyPassword;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.PictureBox pictureShowPass1;
        private System.Windows.Forms.Label lbConfirmPassword;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnAceptar;
        public System.Windows.Forms.DataGridView gridAddAdmin;
    }
}