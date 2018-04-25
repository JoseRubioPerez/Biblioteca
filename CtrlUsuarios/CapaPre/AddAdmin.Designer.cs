namespace CapaPre
{
    partial class AddAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAdmin));
            this.tableEditAdmin = new System.Windows.Forms.TableLayoutPanel();
            this.GridAdmin = new System.Windows.Forms.DataGridView();
            this.panelEditSuperUs = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioN = new System.Windows.Forms.RadioButton();
            this.radioS = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.pictureShoPass2 = new System.Windows.Forms.PictureBox();
            this.panelMyPassword = new System.Windows.Forms.Panel();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.pictureShowPass1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnAceptar = new System.Windows.Forms.Button();
            this.tableEditAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridAdmin)).BeginInit();
            this.panelEditSuperUs.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureShoPass2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureShowPass1)).BeginInit();
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
            this.tableEditAdmin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.72612F));
            this.tableEditAdmin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.27388F));
            this.tableEditAdmin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableEditAdmin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableEditAdmin.Size = new System.Drawing.Size(1020, 314);
            this.tableEditAdmin.TabIndex = 26;
            // 
            // GridAdmin
            // 
            this.GridAdmin.AllowUserToAddRows = false;
            this.GridAdmin.AllowUserToDeleteRows = false;
            this.GridAdmin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridAdmin.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(223)))), ((int)(((byte)(198)))));
            this.GridAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridAdmin.Location = new System.Drawing.Point(3, 3);
            this.GridAdmin.Name = "GridAdmin";
            this.GridAdmin.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.GridAdmin.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.GridAdmin.Size = new System.Drawing.Size(1014, 147);
            this.GridAdmin.TabIndex = 0;
            // 
            // panelEditSuperUs
            // 
            this.panelEditSuperUs.Controls.Add(this.panel1);
            this.panelEditSuperUs.Controls.Add(this.btnCancelar);
            this.panelEditSuperUs.Controls.Add(this.btnAceptar);
            this.panelEditSuperUs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEditSuperUs.Location = new System.Drawing.Point(3, 156);
            this.panelEditSuperUs.Name = "panelEditSuperUs";
            this.panelEditSuperUs.Size = new System.Drawing.Size(1014, 155);
            this.panelEditSuperUs.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.txtConfirmPassword);
            this.panel1.Controls.Add(this.pictureShoPass2);
            this.panel1.Controls.Add(this.panelMyPassword);
            this.panel1.Controls.Add(this.txtNewPassword);
            this.panel1.Controls.Add(this.pictureShowPass1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.MinimumSize = new System.Drawing.Size(777, 111);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(777, 155);
            this.panel1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(30, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(533, 19);
            this.label3.TabIndex = 29;
            this.label3.Text = "Permitir al administrador seleccionado el modo \"Super Usuario\":";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioN);
            this.groupBox1.Controls.Add(this.radioS);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 14F);
            this.groupBox1.Location = new System.Drawing.Point(590, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(168, 48);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            // 
            // radioN
            // 
            this.radioN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioN.AutoSize = true;
            this.radioN.Location = new System.Drawing.Point(88, 11);
            this.radioN.Name = "radioN";
            this.radioN.Size = new System.Drawing.Size(51, 27);
            this.radioN.TabIndex = 2;
            this.radioN.TabStop = true;
            this.radioN.Text = "No";
            this.radioN.UseVisualStyleBackColor = true;
            // 
            // radioS
            // 
            this.radioS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioS.AutoSize = true;
            this.radioS.Location = new System.Drawing.Point(29, 11);
            this.radioS.Name = "radioS";
            this.radioS.Size = new System.Drawing.Size(43, 27);
            this.radioS.TabIndex = 1;
            this.radioS.TabStop = true;
            this.radioS.Text = "Si";
            this.radioS.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.panel2.Location = new System.Drawing.Point(427, 86);
            this.panel2.MaximumSize = new System.Drawing.Size(282, 3);
            this.panel2.MinimumSize = new System.Drawing.Size(282, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(282, 3);
            this.panel2.TabIndex = 14;
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(223)))), ((int)(((byte)(198)))));
            this.txtConfirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConfirmPassword.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.txtConfirmPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.txtConfirmPassword.Location = new System.Drawing.Point(427, 63);
            this.txtConfirmPassword.MaximumSize = new System.Drawing.Size(282, 20);
            this.txtConfirmPassword.MinimumSize = new System.Drawing.Size(282, 20);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '*';
            this.txtConfirmPassword.Size = new System.Drawing.Size(282, 26);
            this.txtConfirmPassword.TabIndex = 13;
            // 
            // pictureShoPass2
            // 
            this.pictureShoPass2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureShoPass2.Image = global::CapaPre.Properties.Resources.Showpass;
            this.pictureShoPass2.Location = new System.Drawing.Point(728, 62);
            this.pictureShoPass2.MaximumSize = new System.Drawing.Size(30, 30);
            this.pictureShoPass2.MinimumSize = new System.Drawing.Size(30, 30);
            this.pictureShoPass2.Name = "pictureShoPass2";
            this.pictureShoPass2.Size = new System.Drawing.Size(30, 30);
            this.pictureShoPass2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureShoPass2.TabIndex = 15;
            this.pictureShoPass2.TabStop = false;
            // 
            // panelMyPassword
            // 
            this.panelMyPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.panelMyPassword.Location = new System.Drawing.Point(400, 40);
            this.panelMyPassword.MaximumSize = new System.Drawing.Size(282, 3);
            this.panelMyPassword.MinimumSize = new System.Drawing.Size(282, 3);
            this.panelMyPassword.Name = "panelMyPassword";
            this.panelMyPassword.Size = new System.Drawing.Size(282, 3);
            this.panelMyPassword.TabIndex = 11;
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(223)))), ((int)(((byte)(198)))));
            this.txtNewPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNewPassword.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.txtNewPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.txtNewPassword.Location = new System.Drawing.Point(400, 17);
            this.txtNewPassword.MaximumSize = new System.Drawing.Size(282, 20);
            this.txtNewPassword.MinimumSize = new System.Drawing.Size(282, 20);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.PasswordChar = '*';
            this.txtNewPassword.Size = new System.Drawing.Size(282, 26);
            this.txtNewPassword.TabIndex = 10;
            // 
            // pictureShowPass1
            // 
            this.pictureShowPass1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureShowPass1.Image = global::CapaPre.Properties.Resources.Showpass;
            this.pictureShowPass1.Location = new System.Drawing.Point(728, 13);
            this.pictureShowPass1.MaximumSize = new System.Drawing.Size(30, 30);
            this.pictureShowPass1.MinimumSize = new System.Drawing.Size(30, 30);
            this.pictureShowPass1.Name = "pictureShowPass1";
            this.pictureShowPass1.Size = new System.Drawing.Size(30, 30);
            this.pictureShowPass1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureShowPass1.TabIndex = 12;
            this.pictureShowPass1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(30, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(394, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Confirmar contraseña del nuevo administrador:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(30, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(364, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nueva contraseña del nuevo administrador:";
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
            this.btnCancelar.Location = new System.Drawing.Point(808, 113);
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
            this.btnAceptar.Location = new System.Drawing.Point(808, 53);
            this.btnAceptar.MaximumSize = new System.Drawing.Size(203, 39);
            this.btnAceptar.MinimumSize = new System.Drawing.Size(203, 39);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(203, 39);
            this.btnAceptar.TabIndex = 3;
            this.btnAceptar.Text = "Aceptar y terminar";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // AddAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(223)))), ((int)(((byte)(198)))));
            this.Controls.Add(this.tableEditAdmin);
            this.Font = new System.Drawing.Font("Tahoma", 12F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddAdmin";
            this.Size = new System.Drawing.Size(1020, 314);
            this.tableEditAdmin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridAdmin)).EndInit();
            this.panelEditSuperUs.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureShoPass2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureShowPass1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableEditAdmin;
        public System.Windows.Forms.DataGridView GridAdmin;
        private System.Windows.Forms.Panel panelEditSuperUs;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.PictureBox pictureShoPass2;
        private System.Windows.Forms.Panel panelMyPassword;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.PictureBox pictureShowPass1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioN;
        private System.Windows.Forms.RadioButton radioS;
    }
}
