namespace CapaPre
{
    partial class LogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            this.panelLogOut = new System.Windows.Forms.Panel();
            this.panelContenido = new System.Windows.Forms.Panel();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.lbError = new System.Windows.Forms.Label();
            this.panelTabla = new System.Windows.Forms.Panel();
            this.TablaLogOut = new System.Windows.Forms.TableLayoutPanel();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.panelUsuario = new System.Windows.Forms.Panel();
            this.panelPassword = new System.Windows.Forms.Panel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.panelUser = new System.Windows.Forms.Panel();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.lbPassword = new System.Windows.Forms.Label();
            this.lbNumControl = new System.Windows.Forms.Label();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.lbIcon = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.pictureClose = new System.Windows.Forms.PictureBox();
            this.pictureIcon = new System.Windows.Forms.PictureBox();
            this.panelLogOut.SuspendLayout();
            this.panelContenido.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.panelTabla.SuspendLayout();
            this.TablaLogOut.SuspendLayout();
            this.panelUsuario.SuspendLayout();
            this.panelTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLogOut
            // 
            this.panelLogOut.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelLogOut.Controls.Add(this.panelContenido);
            this.panelLogOut.Controls.Add(this.panelTitulo);
            this.panelLogOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.panelLogOut.Location = new System.Drawing.Point(10, 10);
            this.panelLogOut.Margin = new System.Windows.Forms.Padding(1);
            this.panelLogOut.Name = "panelLogOut";
            this.panelLogOut.Size = new System.Drawing.Size(556, 293);
            this.panelLogOut.TabIndex = 1;
            // 
            // panelContenido
            // 
            this.panelContenido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(223)))), ((int)(((byte)(198)))));
            this.panelContenido.Controls.Add(this.panelButtons);
            this.panelContenido.Controls.Add(this.panelTabla);
            this.panelContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenido.Location = new System.Drawing.Point(0, 73);
            this.panelContenido.Name = "panelContenido";
            this.panelContenido.Size = new System.Drawing.Size(556, 220);
            this.panelContenido.TabIndex = 1;
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.lbError);
            this.panelButtons.Controls.Add(this.btnCancelar);
            this.panelButtons.Controls.Add(this.btnAceptar);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelButtons.Location = new System.Drawing.Point(0, 173);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(556, 47);
            this.panelButtons.TabIndex = 2;
            // 
            // lbError
            // 
            this.lbError.AutoSize = true;
            this.lbError.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.lbError.Location = new System.Drawing.Point(15, 11);
            this.lbError.Name = "lbError";
            this.lbError.Size = new System.Drawing.Size(0, 23);
            this.lbError.TabIndex = 6;
            this.lbError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelTabla
            // 
            this.panelTabla.Controls.Add(this.TablaLogOut);
            this.panelTabla.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTabla.Location = new System.Drawing.Point(0, 0);
            this.panelTabla.Name = "panelTabla";
            this.panelTabla.Size = new System.Drawing.Size(556, 173);
            this.panelTabla.TabIndex = 1;
            // 
            // TablaLogOut
            // 
            this.TablaLogOut.ColumnCount = 1;
            this.TablaLogOut.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TablaLogOut.Controls.Add(this.lbTitulo, 0, 0);
            this.TablaLogOut.Controls.Add(this.panelUsuario, 0, 1);
            this.TablaLogOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TablaLogOut.Location = new System.Drawing.Point(0, 0);
            this.TablaLogOut.Name = "TablaLogOut";
            this.TablaLogOut.RowCount = 2;
            this.TablaLogOut.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.0559F));
            this.TablaLogOut.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 68.9441F));
            this.TablaLogOut.Size = new System.Drawing.Size(556, 173);
            this.TablaLogOut.TabIndex = 0;
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbTitulo.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.lbTitulo.Location = new System.Drawing.Point(3, 0);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(550, 53);
            this.lbTitulo.TabIndex = 4;
            this.lbTitulo.Text = "Confirmación de autenticación";
            this.lbTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelUsuario
            // 
            this.panelUsuario.Controls.Add(this.panelPassword);
            this.panelUsuario.Controls.Add(this.txtPassword);
            this.panelUsuario.Controls.Add(this.panelUser);
            this.panelUsuario.Controls.Add(this.txtUser);
            this.panelUsuario.Controls.Add(this.lbPassword);
            this.panelUsuario.Controls.Add(this.lbNumControl);
            this.panelUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelUsuario.Location = new System.Drawing.Point(3, 56);
            this.panelUsuario.Name = "panelUsuario";
            this.panelUsuario.Size = new System.Drawing.Size(550, 114);
            this.panelUsuario.TabIndex = 5;
            // 
            // panelPassword
            // 
            this.panelPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.panelPassword.Location = new System.Drawing.Point(255, 87);
            this.panelPassword.Name = "panelPassword";
            this.panelPassword.Size = new System.Drawing.Size(245, 3);
            this.panelPassword.TabIndex = 9;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(223)))), ((int)(((byte)(198)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.txtPassword.Location = new System.Drawing.Point(255, 68);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(245, 20);
            this.txtPassword.TabIndex = 10;
            // 
            // panelUser
            // 
            this.panelUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.panelUser.Location = new System.Drawing.Point(255, 44);
            this.panelUser.Name = "panelUser";
            this.panelUser.Size = new System.Drawing.Size(245, 3);
            this.panelUser.TabIndex = 7;
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(223)))), ((int)(((byte)(198)))));
            this.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUser.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.txtUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.txtUser.Location = new System.Drawing.Point(255, 25);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(245, 20);
            this.txtUser.TabIndex = 8;
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.lbPassword.Location = new System.Drawing.Point(124, 65);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(125, 23);
            this.lbPassword.TabIndex = 6;
            this.lbPassword.Text = "Contraseña:";
            this.lbPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbNumControl
            // 
            this.lbNumControl.AutoSize = true;
            this.lbNumControl.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumControl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.lbNumControl.Location = new System.Drawing.Point(50, 24);
            this.lbNumControl.Name = "lbNumControl";
            this.lbNumControl.Size = new System.Drawing.Size(199, 23);
            this.lbNumControl.TabIndex = 5;
            this.lbNumControl.Text = "Número de Control:";
            this.lbNumControl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.panelTitulo.Controls.Add(this.pictureClose);
            this.panelTitulo.Controls.Add(this.pictureIcon);
            this.panelTitulo.Controls.Add(this.lbIcon);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(556, 73);
            this.panelTitulo.TabIndex = 0;
            // 
            // lbIcon
            // 
            this.lbIcon.AutoSize = true;
            this.lbIcon.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIcon.Location = new System.Drawing.Point(55, 27);
            this.lbIcon.Name = "lbIcon";
            this.lbIcon.Size = new System.Drawing.Size(141, 23);
            this.lbIcon.TabIndex = 3;
            this.lbIcon.Text = "Iniciar Sesión";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackgroundImage = global::CapaPre.Properties.Resources.delete;
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Location = new System.Drawing.Point(488, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(40, 40);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.EventoClick);
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackgroundImage = global::CapaPre.Properties.Resources.aceptar;
            this.btnAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Location = new System.Drawing.Point(427, 3);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(40, 40);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.EventoClick);
            // 
            // pictureClose
            // 
            this.pictureClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureClose.Image = global::CapaPre.Properties.Resources.close2;
            this.pictureClose.Location = new System.Drawing.Point(526, 3);
            this.pictureClose.Name = "pictureClose";
            this.pictureClose.Size = new System.Drawing.Size(30, 30);
            this.pictureClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureClose.TabIndex = 4;
            this.pictureClose.TabStop = false;
            this.pictureClose.Click += new System.EventHandler(this.EventoClick);
            // 
            // pictureIcon
            // 
            this.pictureIcon.Image = global::CapaPre.Properties.Resources.login;
            this.pictureIcon.Location = new System.Drawing.Point(19, 21);
            this.pictureIcon.Name = "pictureIcon";
            this.pictureIcon.Size = new System.Drawing.Size(30, 30);
            this.pictureIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureIcon.TabIndex = 2;
            this.pictureIcon.TabStop = false;
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(90)))), ((int)(((byte)(95)))));
            this.ClientSize = new System.Drawing.Size(576, 313);
            this.Controls.Add(this.panelLogOut);
            this.Font = new System.Drawing.Font("Tahoma", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "LogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LogIn";
            this.panelLogOut.ResumeLayout(false);
            this.panelContenido.ResumeLayout(false);
            this.panelButtons.ResumeLayout(false);
            this.panelButtons.PerformLayout();
            this.panelTabla.ResumeLayout(false);
            this.TablaLogOut.ResumeLayout(false);
            this.TablaLogOut.PerformLayout();
            this.panelUsuario.ResumeLayout(false);
            this.panelUsuario.PerformLayout();
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLogOut;
        private System.Windows.Forms.Panel panelContenido;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Label lbError;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Panel panelTabla;
        private System.Windows.Forms.TableLayoutPanel TablaLogOut;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Panel panelUsuario;
        private System.Windows.Forms.Panel panelPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Panel panelUser;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Label lbNumControl;
        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.PictureBox pictureClose;
        private System.Windows.Forms.PictureBox pictureIcon;
        private System.Windows.Forms.Label lbIcon;
    }
}