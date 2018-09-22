namespace Application
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
            this.PanelLogIn = new System.Windows.Forms.Panel();
            this.PanelContent = new System.Windows.Forms.Panel();
            this.PanelBorderPassword = new System.Windows.Forms.Panel();
            this.PanelBorderUser = new System.Windows.Forms.Panel();
            this.ButtonCancelar = new System.Windows.Forms.Button();
            this.PicturePassword = new System.Windows.Forms.PictureBox();
            this.PictureUser = new System.Windows.Forms.PictureBox();
            this.ButtonAccept = new System.Windows.Forms.Button();
            this.TextBoxPassword = new System.Windows.Forms.TextBox();
            this.TextBoxUser = new System.Windows.Forms.TextBox();
            this.PanelHeader = new System.Windows.Forms.Panel();
            this.LabelTitle = new System.Windows.Forms.Label();
            this.PictureClose = new System.Windows.Forms.PictureBox();
            this.PictureIcon = new System.Windows.Forms.PictureBox();
            this.PanelLogIn.SuspendLayout();
            this.PanelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicturePassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureUser)).BeginInit();
            this.PanelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelLogIn
            // 
            this.PanelLogIn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelLogIn.Controls.Add(this.PanelContent);
            this.PanelLogIn.Controls.Add(this.PanelHeader);
            this.PanelLogIn.Location = new System.Drawing.Point(10, 10);
            this.PanelLogIn.Margin = new System.Windows.Forms.Padding(1);
            this.PanelLogIn.Name = "PanelLogIn";
            this.PanelLogIn.Size = new System.Drawing.Size(432, 236);
            this.PanelLogIn.TabIndex = 2;
            // 
            // PanelContent
            // 
            this.PanelContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(223)))), ((int)(((byte)(198)))));
            this.PanelContent.Controls.Add(this.PanelBorderPassword);
            this.PanelContent.Controls.Add(this.PanelBorderUser);
            this.PanelContent.Controls.Add(this.ButtonCancelar);
            this.PanelContent.Controls.Add(this.PicturePassword);
            this.PanelContent.Controls.Add(this.PictureUser);
            this.PanelContent.Controls.Add(this.ButtonAccept);
            this.PanelContent.Controls.Add(this.TextBoxPassword);
            this.PanelContent.Controls.Add(this.TextBoxUser);
            this.PanelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.PanelContent.Location = new System.Drawing.Point(0, 49);
            this.PanelContent.Name = "PanelContent";
            this.PanelContent.Size = new System.Drawing.Size(432, 187);
            this.PanelContent.TabIndex = 3;
            // 
            // PanelBorderPassword
            // 
            this.PanelBorderPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.PanelBorderPassword.Location = new System.Drawing.Point(85, 94);
            this.PanelBorderPassword.Name = "PanelBorderPassword";
            this.PanelBorderPassword.Size = new System.Drawing.Size(296, 3);
            this.PanelBorderPassword.TabIndex = 10;
            // 
            // PanelBorderUser
            // 
            this.PanelBorderUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.PanelBorderUser.Location = new System.Drawing.Point(85, 48);
            this.PanelBorderUser.Name = "PanelBorderUser";
            this.PanelBorderUser.Size = new System.Drawing.Size(296, 3);
            this.PanelBorderUser.TabIndex = 9;
            // 
            // ButtonCancelar
            // 
            this.ButtonCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonCancelar.BackgroundImage = global::Application.Properties.Resources.delete;
            this.ButtonCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonCancelar.FlatAppearance.BorderSize = 0;
            this.ButtonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonCancelar.Location = new System.Drawing.Point(353, 135);
            this.ButtonCancelar.Name = "ButtonCancelar";
            this.ButtonCancelar.Size = new System.Drawing.Size(28, 28);
            this.ButtonCancelar.TabIndex = 4;
            this.ButtonCancelar.UseVisualStyleBackColor = true;
            this.ButtonCancelar.Click += new System.EventHandler(this.EventoClick);
            // 
            // PicturePassword
            // 
            this.PicturePassword.Image = global::Application.Properties.Resources.login;
            this.PicturePassword.Location = new System.Drawing.Point(51, 68);
            this.PicturePassword.Name = "PicturePassword";
            this.PicturePassword.Size = new System.Drawing.Size(28, 28);
            this.PicturePassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicturePassword.TabIndex = 7;
            this.PicturePassword.TabStop = false;
            // 
            // PictureUser
            // 
            this.PictureUser.Image = global::Application.Properties.Resources.user;
            this.PictureUser.Location = new System.Drawing.Point(51, 23);
            this.PictureUser.Name = "PictureUser";
            this.PictureUser.Size = new System.Drawing.Size(28, 28);
            this.PictureUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureUser.TabIndex = 6;
            this.PictureUser.TabStop = false;
            // 
            // ButtonAccept
            // 
            this.ButtonAccept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonAccept.BackgroundImage = global::Application.Properties.Resources.accept;
            this.ButtonAccept.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonAccept.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonAccept.FlatAppearance.BorderSize = 0;
            this.ButtonAccept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAccept.Location = new System.Drawing.Point(302, 135);
            this.ButtonAccept.Name = "ButtonAccept";
            this.ButtonAccept.Size = new System.Drawing.Size(28, 28);
            this.ButtonAccept.TabIndex = 3;
            this.ButtonAccept.UseVisualStyleBackColor = true;
            this.ButtonAccept.Click += new System.EventHandler(this.EventoClick);
            // 
            // TextBoxPassword
            // 
            this.TextBoxPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(223)))), ((int)(((byte)(198)))));
            this.TextBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.TextBoxPassword.Location = new System.Drawing.Point(85, 74);
            this.TextBoxPassword.Name = "TextBoxPassword";
            this.TextBoxPassword.PasswordChar = '*';
            this.TextBoxPassword.Size = new System.Drawing.Size(296, 19);
            this.TextBoxPassword.TabIndex = 2;
            this.TextBoxPassword.Enter += new System.EventHandler(this.TextPasswordEnter);
            this.TextBoxPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxPasswordKeyDown);
            this.TextBoxPassword.Leave += new System.EventHandler(this.TextPasswordLeave);
            // 
            // TextBoxUser
            // 
            this.TextBoxUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(223)))), ((int)(((byte)(198)))));
            this.TextBoxUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.TextBoxUser.Location = new System.Drawing.Point(85, 29);
            this.TextBoxUser.MaxLength = 9;
            this.TextBoxUser.Name = "TextBoxUser";
            this.TextBoxUser.Size = new System.Drawing.Size(296, 19);
            this.TextBoxUser.TabIndex = 1;
            this.TextBoxUser.Enter += new System.EventHandler(this.TextUserEnter);
            this.TextBoxUser.Leave += new System.EventHandler(this.TextUserLeave);
            // 
            // PanelHeader
            // 
            this.PanelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(43)))), ((int)(((byte)(73)))));
            this.PanelHeader.Controls.Add(this.LabelTitle);
            this.PanelHeader.Controls.Add(this.PictureClose);
            this.PanelHeader.Controls.Add(this.PictureIcon);
            this.PanelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelHeader.Location = new System.Drawing.Point(0, 0);
            this.PanelHeader.Name = "PanelHeader";
            this.PanelHeader.Size = new System.Drawing.Size(432, 49);
            this.PanelHeader.TabIndex = 2;
            // 
            // LabelTitle
            // 
            this.LabelTitle.AutoSize = true;
            this.LabelTitle.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTitle.Location = new System.Drawing.Point(56, 15);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(127, 18);
            this.LabelTitle.TabIndex = 5;
            this.LabelTitle.Text = "Inicio de Sesión";
            this.LabelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PictureClose
            // 
            this.PictureClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PictureClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureClose.Image = global::Application.Properties.Resources.close;
            this.PictureClose.Location = new System.Drawing.Point(401, 3);
            this.PictureClose.Name = "PictureClose";
            this.PictureClose.Size = new System.Drawing.Size(28, 28);
            this.PictureClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureClose.TabIndex = 1;
            this.PictureClose.TabStop = false;
            this.PictureClose.Click += new System.EventHandler(this.EventoClick);
            // 
            // PictureIcon
            // 
            this.PictureIcon.Image = global::Application.Properties.Resources.login;
            this.PictureIcon.Location = new System.Drawing.Point(14, 6);
            this.PictureIcon.Name = "PictureIcon";
            this.PictureIcon.Size = new System.Drawing.Size(36, 36);
            this.PictureIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureIcon.TabIndex = 4;
            this.PictureIcon.TabStop = false;
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(452, 256);
            this.Controls.Add(this.PanelLogIn);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(223)))), ((int)(((byte)(198)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LogIn";
            this.Load += new System.EventHandler(this.LogIn_Load);
            this.PanelLogIn.ResumeLayout(false);
            this.PanelContent.ResumeLayout(false);
            this.PanelContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicturePassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureUser)).EndInit();
            this.PanelHeader.ResumeLayout(false);
            this.PanelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureClose;
        private System.Windows.Forms.Panel PanelLogIn;
        private System.Windows.Forms.Panel PanelHeader;
        private System.Windows.Forms.Label LabelTitle;
        private System.Windows.Forms.PictureBox PictureIcon;
        private System.Windows.Forms.Panel PanelContent;
        private System.Windows.Forms.TextBox TextBoxPassword;
        private System.Windows.Forms.TextBox TextBoxUser;
        private System.Windows.Forms.PictureBox PicturePassword;
        private System.Windows.Forms.PictureBox PictureUser;
        private System.Windows.Forms.Button ButtonAccept;
        private System.Windows.Forms.Button ButtonCancelar;
        private System.Windows.Forms.Panel PanelBorderUser;
        private System.Windows.Forms.Panel PanelBorderPassword;
    }
}