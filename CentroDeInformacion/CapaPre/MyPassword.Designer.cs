﻿namespace CapaPre
{
    partial class MyPassword
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
            this.lbMyPassword = new System.Windows.Forms.Label();
            this.lbNewPassword = new System.Windows.Forms.Label();
            this.lbConfirmPassword = new System.Windows.Forms.Label();
            this.txtMyPassword = new System.Windows.Forms.TextBox();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.panelMyPassword = new System.Windows.Forms.Panel();
            this.panelNewPassword = new System.Windows.Forms.Panel();
            this.panelConfirmPassword = new System.Windows.Forms.Panel();
            this.TableContenido = new System.Windows.Forms.TableLayoutPanel();
            this.panelContenido = new System.Windows.Forms.Panel();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.pictureShowPass3 = new System.Windows.Forms.PictureBox();
            this.pictureShowPass2 = new System.Windows.Forms.PictureBox();
            this.pictureShowPass1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelConfirmPassword.SuspendLayout();
            this.TableContenido.SuspendLayout();
            this.panelContenido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureShowPass3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureShowPass2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureShowPass1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbMyPassword
            // 
            this.lbMyPassword.AutoSize = true;
            this.lbMyPassword.Font = new System.Drawing.Font("Tahoma", 16F);
            this.lbMyPassword.Location = new System.Drawing.Point(186, 64);
            this.lbMyPassword.Name = "lbMyPassword";
            this.lbMyPassword.Size = new System.Drawing.Size(195, 27);
            this.lbMyPassword.TabIndex = 1;
            this.lbMyPassword.Text = "Contraseña actual:";
            // 
            // lbNewPassword
            // 
            this.lbNewPassword.AutoSize = true;
            this.lbNewPassword.Font = new System.Drawing.Font("Tahoma", 16F);
            this.lbNewPassword.Location = new System.Drawing.Point(186, 151);
            this.lbNewPassword.Name = "lbNewPassword";
            this.lbNewPassword.Size = new System.Drawing.Size(196, 27);
            this.lbNewPassword.TabIndex = 2;
            this.lbNewPassword.Text = "Nueva contraseña:";
            // 
            // lbConfirmPassword
            // 
            this.lbConfirmPassword.AutoSize = true;
            this.lbConfirmPassword.Font = new System.Drawing.Font("Tahoma", 16F);
            this.lbConfirmPassword.Location = new System.Drawing.Point(86, 238);
            this.lbConfirmPassword.Name = "lbConfirmPassword";
            this.lbConfirmPassword.Size = new System.Drawing.Size(295, 27);
            this.lbConfirmPassword.TabIndex = 3;
            this.lbConfirmPassword.Text = "Confirmar contraseña nueva:";
            // 
            // txtMyPassword
            // 
            this.txtMyPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(223)))), ((int)(((byte)(198)))));
            this.txtMyPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMyPassword.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.txtMyPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.txtMyPassword.Location = new System.Drawing.Point(388, 67);
            this.txtMyPassword.MaximumSize = new System.Drawing.Size(282, 20);
            this.txtMyPassword.MinimumSize = new System.Drawing.Size(282, 20);
            this.txtMyPassword.Name = "txtMyPassword";
            this.txtMyPassword.Size = new System.Drawing.Size(282, 20);
            this.txtMyPassword.TabIndex = 1;
            this.txtMyPassword.TextChanged += new System.EventHandler(this.Coincidencia);
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(223)))), ((int)(((byte)(198)))));
            this.txtNewPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNewPassword.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.txtNewPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.txtNewPassword.Location = new System.Drawing.Point(388, 154);
            this.txtNewPassword.MaximumSize = new System.Drawing.Size(282, 20);
            this.txtNewPassword.MinimumSize = new System.Drawing.Size(282, 20);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(282, 20);
            this.txtNewPassword.TabIndex = 2;
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(223)))), ((int)(((byte)(198)))));
            this.txtConfirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConfirmPassword.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.txtConfirmPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.txtConfirmPassword.Location = new System.Drawing.Point(388, 241);
            this.txtConfirmPassword.MaximumSize = new System.Drawing.Size(282, 20);
            this.txtConfirmPassword.MinimumSize = new System.Drawing.Size(282, 20);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(282, 20);
            this.txtConfirmPassword.TabIndex = 3;
            // 
            // panelMyPassword
            // 
            this.panelMyPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.panelMyPassword.Location = new System.Drawing.Point(388, 90);
            this.panelMyPassword.MaximumSize = new System.Drawing.Size(282, 3);
            this.panelMyPassword.MinimumSize = new System.Drawing.Size(282, 3);
            this.panelMyPassword.Name = "panelMyPassword";
            this.panelMyPassword.Size = new System.Drawing.Size(282, 3);
            this.panelMyPassword.TabIndex = 7;
            // 
            // panelNewPassword
            // 
            this.panelNewPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.panelNewPassword.Location = new System.Drawing.Point(388, 177);
            this.panelNewPassword.MaximumSize = new System.Drawing.Size(282, 3);
            this.panelNewPassword.MinimumSize = new System.Drawing.Size(282, 3);
            this.panelNewPassword.Name = "panelNewPassword";
            this.panelNewPassword.Size = new System.Drawing.Size(282, 3);
            this.panelNewPassword.TabIndex = 8;
            // 
            // panelConfirmPassword
            // 
            this.panelConfirmPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.panelConfirmPassword.Controls.Add(this.panel1);
            this.panelConfirmPassword.Controls.Add(this.textBox1);
            this.panelConfirmPassword.Controls.Add(this.pictureBox1);
            this.panelConfirmPassword.Controls.Add(this.label1);
            this.panelConfirmPassword.Location = new System.Drawing.Point(388, 264);
            this.panelConfirmPassword.MaximumSize = new System.Drawing.Size(282, 3);
            this.panelConfirmPassword.MinimumSize = new System.Drawing.Size(282, 3);
            this.panelConfirmPassword.Name = "panelConfirmPassword";
            this.panelConfirmPassword.Size = new System.Drawing.Size(282, 3);
            this.panelConfirmPassword.TabIndex = 8;
            // 
            // TableContenido
            // 
            this.TableContenido.ColumnCount = 3;
            this.TableContenido.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.TableContenido.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.TableContenido.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.TableContenido.Controls.Add(this.panelContenido, 1, 1);
            this.TableContenido.Controls.Add(this.lbTitulo, 0, 0);
            this.TableContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableContenido.Location = new System.Drawing.Point(0, 0);
            this.TableContenido.Name = "TableContenido";
            this.TableContenido.RowCount = 2;
            this.TableContenido.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19F));
            this.TableContenido.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 81F));
            this.TableContenido.Size = new System.Drawing.Size(1140, 507);
            this.TableContenido.TabIndex = 14;
            // 
            // panelContenido
            // 
            this.panelContenido.Controls.Add(this.panelMyPassword);
            this.panelContenido.Controls.Add(this.panelConfirmPassword);
            this.panelContenido.Controls.Add(this.panelNewPassword);
            this.panelContenido.Controls.Add(this.lbMyPassword);
            this.panelContenido.Controls.Add(this.lbNewPassword);
            this.panelContenido.Controls.Add(this.btnCancelar);
            this.panelContenido.Controls.Add(this.lbConfirmPassword);
            this.panelContenido.Controls.Add(this.btnAceptar);
            this.panelContenido.Controls.Add(this.txtMyPassword);
            this.panelContenido.Controls.Add(this.pictureShowPass3);
            this.panelContenido.Controls.Add(this.txtNewPassword);
            this.panelContenido.Controls.Add(this.pictureShowPass2);
            this.panelContenido.Controls.Add(this.txtConfirmPassword);
            this.panelContenido.Controls.Add(this.pictureShowPass1);
            this.panelContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenido.Location = new System.Drawing.Point(174, 99);
            this.panelContenido.Name = "panelContenido";
            this.panelContenido.Size = new System.Drawing.Size(792, 405);
            this.panelContenido.TabIndex = 15;
            // 
            // lbTitulo
            // 
            this.lbTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTitulo.AutoSize = true;
            this.TableContenido.SetColumnSpan(this.lbTitulo, 3);
            this.lbTitulo.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.Location = new System.Drawing.Point(3, 0);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.lbTitulo.Size = new System.Drawing.Size(1134, 96);
            this.lbTitulo.TabIndex = 16;
            this.lbTitulo.Text = "Aquí podrás cambiar tu contraseña como administrador\r\nRecuerda ser cuidadoso y no" +
    " abusar de los cambios de contraseña";
            this.lbTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackgroundImage = global::CapaPre.Properties.Resources.delete;
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Location = new System.Drawing.Point(666, 303);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(40, 40);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.EventoClick);
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackgroundImage = global::CapaPre.Properties.Resources.aceptar;
            this.btnAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Location = new System.Drawing.Point(604, 303);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(40, 40);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.EventoClick);
            // 
            // pictureShowPass3
            // 
            this.pictureShowPass3.Image = global::CapaPre.Properties.Resources.Showpass;
            this.pictureShowPass3.Location = new System.Drawing.Point(676, 236);
            this.pictureShowPass3.MaximumSize = new System.Drawing.Size(30, 30);
            this.pictureShowPass3.MinimumSize = new System.Drawing.Size(30, 30);
            this.pictureShowPass3.Name = "pictureShowPass3";
            this.pictureShowPass3.Size = new System.Drawing.Size(30, 30);
            this.pictureShowPass3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureShowPass3.TabIndex = 11;
            this.pictureShowPass3.TabStop = false;
            this.pictureShowPass3.Click += new System.EventHandler(this.MostrarPassword);
            // 
            // pictureShowPass2
            // 
            this.pictureShowPass2.Image = global::CapaPre.Properties.Resources.Showpass;
            this.pictureShowPass2.Location = new System.Drawing.Point(676, 149);
            this.pictureShowPass2.MaximumSize = new System.Drawing.Size(30, 30);
            this.pictureShowPass2.MinimumSize = new System.Drawing.Size(30, 30);
            this.pictureShowPass2.Name = "pictureShowPass2";
            this.pictureShowPass2.Size = new System.Drawing.Size(30, 30);
            this.pictureShowPass2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureShowPass2.TabIndex = 10;
            this.pictureShowPass2.TabStop = false;
            this.pictureShowPass2.Click += new System.EventHandler(this.MostrarPassword);
            // 
            // pictureShowPass1
            // 
            this.pictureShowPass1.Image = global::CapaPre.Properties.Resources.Showpass;
            this.pictureShowPass1.Location = new System.Drawing.Point(676, 62);
            this.pictureShowPass1.MaximumSize = new System.Drawing.Size(30, 30);
            this.pictureShowPass1.MinimumSize = new System.Drawing.Size(30, 30);
            this.pictureShowPass1.Name = "pictureShowPass1";
            this.pictureShowPass1.Size = new System.Drawing.Size(30, 30);
            this.pictureShowPass1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureShowPass1.TabIndex = 9;
            this.pictureShowPass1.TabStop = false;
            this.pictureShowPass1.Click += new System.EventHandler(this.MostrarPassword);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(223)))), ((int)(((byte)(198)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.textBox1.Location = new System.Drawing.Point(0, -23);
            this.textBox1.MaximumSize = new System.Drawing.Size(282, 20);
            this.textBox1.MinimumSize = new System.Drawing.Size(282, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(282, 20);
            this.textBox1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CapaPre.Properties.Resources.Showpass;
            this.pictureBox1.Location = new System.Drawing.Point(288, -29);
            this.pictureBox1.MaximumSize = new System.Drawing.Size(30, 30);
            this.pictureBox1.MinimumSize = new System.Drawing.Size(30, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.MostrarPassword);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 16F);
            this.label1.Location = new System.Drawing.Point(-302, -26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "Confirmar contraseña nueva:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.MaximumSize = new System.Drawing.Size(282, 3);
            this.panel1.MinimumSize = new System.Drawing.Size(282, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(282, 3);
            this.panel1.TabIndex = 8;
            // 
            // MyPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(223)))), ((int)(((byte)(198)))));
            this.Controls.Add(this.TableContenido);
            this.Font = new System.Drawing.Font("Tahoma", 12F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MyPassword";
            this.Size = new System.Drawing.Size(1140, 507);
            this.panelConfirmPassword.ResumeLayout(false);
            this.panelConfirmPassword.PerformLayout();
            this.TableContenido.ResumeLayout(false);
            this.TableContenido.PerformLayout();
            this.panelContenido.ResumeLayout(false);
            this.panelContenido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureShowPass3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureShowPass2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureShowPass1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbMyPassword;
        private System.Windows.Forms.Label lbNewPassword;
        private System.Windows.Forms.Label lbConfirmPassword;
        private System.Windows.Forms.TextBox txtMyPassword;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Panel panelMyPassword;
        private System.Windows.Forms.Panel panelNewPassword;
        private System.Windows.Forms.Panel panelConfirmPassword;
        private System.Windows.Forms.PictureBox pictureShowPass1;
        private System.Windows.Forms.PictureBox pictureShowPass2;
        private System.Windows.Forms.PictureBox pictureShowPass3;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TableLayoutPanel TableContenido;
        private System.Windows.Forms.Panel panelContenido;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}
