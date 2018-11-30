namespace Presentation
{
    partial class LogUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogUser));
            this.PanelHeader = new System.Windows.Forms.Panel();
            this.PictureClose = new System.Windows.Forms.PictureBox();
            this.PictureIcon = new System.Windows.Forms.PictureBox();
            this.LabelSubTitle = new System.Windows.Forms.Label();
            this.LabelTitle = new System.Windows.Forms.Label();
            this.ButtonAccept = new System.Windows.Forms.Button();
            this.PictureLPassword = new System.Windows.Forms.PictureBox();
            this.PictureUser = new System.Windows.Forms.PictureBox();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.ButtonShowPassword = new System.Windows.Forms.Button();
            this.PanelContent = new System.Windows.Forms.Panel();
            this.TextBoxUser = new Presentation.Inputs.TextBoxUI();
            this.TextBoxPassword = new Presentation.Inputs.TextBoxUI();
            this.PanelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureLPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureUser)).BeginInit();
            this.PanelContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelHeader
            // 
            this.PanelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(32)))));
            this.PanelHeader.Controls.Add(this.PictureClose);
            this.PanelHeader.Controls.Add(this.PictureIcon);
            this.PanelHeader.Controls.Add(this.LabelSubTitle);
            this.PanelHeader.Controls.Add(this.LabelTitle);
            this.PanelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelHeader.Location = new System.Drawing.Point(0, 0);
            this.PanelHeader.Margin = new System.Windows.Forms.Padding(0);
            this.PanelHeader.Name = "PanelHeader";
            this.PanelHeader.Size = new System.Drawing.Size(662, 66);
            this.PanelHeader.TabIndex = 0;
            // 
            // PictureClose
            // 
            this.PictureClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PictureClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureClose.Image = global::Presentation.Properties.Resources.CloseWindowWhite;
            this.PictureClose.Location = new System.Drawing.Point(618, 12);
            this.PictureClose.Name = "PictureClose";
            this.PictureClose.Size = new System.Drawing.Size(32, 32);
            this.PictureClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureClose.TabIndex = 6;
            this.PictureClose.TabStop = false;
            this.PictureClose.Click += new System.EventHandler(this.ClickMethod);
            // 
            // PictureIcon
            // 
            this.PictureIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureIcon.Image = global::Presentation.Properties.Resources.IconProgram;
            this.PictureIcon.Location = new System.Drawing.Point(12, 12);
            this.PictureIcon.Name = "PictureIcon";
            this.PictureIcon.Size = new System.Drawing.Size(44, 44);
            this.PictureIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureIcon.TabIndex = 5;
            this.PictureIcon.TabStop = false;
            // 
            // LabelSubTitle
            // 
            this.LabelSubTitle.AutoSize = true;
            this.LabelSubTitle.Font = new System.Drawing.Font("Arial Narrow", 16F);
            this.LabelSubTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.LabelSubTitle.Location = new System.Drawing.Point(230, 26);
            this.LabelSubTitle.Name = "LabelSubTitle";
            this.LabelSubTitle.Size = new System.Drawing.Size(112, 26);
            this.LabelSubTitle.TabIndex = 4;
            this.LabelSubTitle.Text = "¡Bienvenido!";
            // 
            // LabelTitle
            // 
            this.LabelTitle.AutoSize = true;
            this.LabelTitle.Font = new System.Drawing.Font("Arial Narrow", 22F);
            this.LabelTitle.ForeColor = System.Drawing.Color.White;
            this.LabelTitle.Location = new System.Drawing.Point(62, 17);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(162, 35);
            this.LabelTitle.TabIndex = 3;
            this.LabelTitle.Text = "Iniciar Sesión";
            // 
            // ButtonAccept
            // 
            this.ButtonAccept.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonAccept.FlatAppearance.BorderSize = 0;
            this.ButtonAccept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAccept.Image = global::Presentation.Properties.Resources.AcceptWhite;
            this.ButtonAccept.Location = new System.Drawing.Point(512, 161);
            this.ButtonAccept.Name = "ButtonAccept";
            this.ButtonAccept.Size = new System.Drawing.Size(32, 32);
            this.ButtonAccept.TabIndex = 3;
            this.ButtonAccept.UseVisualStyleBackColor = true;
            this.ButtonAccept.Click += new System.EventHandler(this.ClickMethod);
            // 
            // PictureLPassword
            // 
            this.PictureLPassword.Image = global::Presentation.Properties.Resources.LockGray;
            this.PictureLPassword.Location = new System.Drawing.Point(31, 98);
            this.PictureLPassword.Name = "PictureLPassword";
            this.PictureLPassword.Size = new System.Drawing.Size(32, 32);
            this.PictureLPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureLPassword.TabIndex = 3;
            this.PictureLPassword.TabStop = false;
            // 
            // PictureUser
            // 
            this.PictureUser.Image = global::Presentation.Properties.Resources.UserGray;
            this.PictureUser.Location = new System.Drawing.Point(31, 40);
            this.PictureUser.Name = "PictureUser";
            this.PictureUser.Size = new System.Drawing.Size(32, 32);
            this.PictureUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureUser.TabIndex = 1;
            this.PictureUser.TabStop = false;
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonCancel.FlatAppearance.BorderSize = 0;
            this.ButtonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonCancel.Image = global::Presentation.Properties.Resources.CancelWhite;
            this.ButtonCancel.Location = new System.Drawing.Point(576, 161);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(32, 32);
            this.ButtonCancel.TabIndex = 4;
            this.ButtonCancel.UseVisualStyleBackColor = true;
            this.ButtonCancel.Click += new System.EventHandler(this.ClickMethod);
            // 
            // ButtonShowPassword
            // 
            this.ButtonShowPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonShowPassword.FlatAppearance.BorderSize = 0;
            this.ButtonShowPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonShowPassword.Image = global::Presentation.Properties.Resources.ShowPasswordGray;
            this.ButtonShowPassword.Location = new System.Drawing.Point(576, 98);
            this.ButtonShowPassword.Name = "ButtonShowPassword";
            this.ButtonShowPassword.Size = new System.Drawing.Size(32, 32);
            this.ButtonShowPassword.TabIndex = 6;
            this.ButtonShowPassword.TabStop = false;
            this.ButtonShowPassword.UseVisualStyleBackColor = true;
            this.ButtonShowPassword.Click += new System.EventHandler(this.ClickMethod);
            // 
            // PanelContent
            // 
            this.PanelContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.PanelContent.Controls.Add(this.PictureUser);
            this.PanelContent.Controls.Add(this.ButtonShowPassword);
            this.PanelContent.Controls.Add(this.ButtonCancel);
            this.PanelContent.Controls.Add(this.TextBoxUser);
            this.PanelContent.Controls.Add(this.ButtonAccept);
            this.PanelContent.Controls.Add(this.PictureLPassword);
            this.PanelContent.Controls.Add(this.TextBoxPassword);
            this.PanelContent.Location = new System.Drawing.Point(12, 66);
            this.PanelContent.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.PanelContent.Name = "PanelContent";
            this.PanelContent.Size = new System.Drawing.Size(638, 236);
            this.PanelContent.TabIndex = 7;
            // 
            // TextBoxUser
            // 
            this.TextBoxUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.TextBoxUser.BackColorLabel = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.TextBoxUser.BackColorPanel = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.TextBoxUser.BackColorTextBox = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.TextBoxUser.EnableTextBox = true;
            this.TextBoxUser.ForeColorLabel = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.TextBoxUser.ForeColorTextBox = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.TextBoxUser.Location = new System.Drawing.Point(69, 40);
            this.TextBoxUser.MaxLengthTextBox = 32767;
            this.TextBoxUser.Name = "TextBoxUser";
            this.TextBoxUser.PasswordTextBox = '\0';
            this.TextBoxUser.SelectionLengthTextBox = 0;
            this.TextBoxUser.SelectionStartTextBox = 0;
            this.TextBoxUser.Size = new System.Drawing.Size(491, 32);
            this.TextBoxUser.TabIndex = 1;
            this.TextBoxUser.TextLabel = "Usuario: ";
            this.TextBoxUser.TextTextBox = "";
            this.TextBoxUser.Enter += new System.EventHandler(this.EnterTextBoxUI);
            this.TextBoxUser.Leave += new System.EventHandler(this.LeaveTextBoxUI);
            // 
            // TextBoxPassword
            // 
            this.TextBoxPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.TextBoxPassword.BackColorLabel = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.TextBoxPassword.BackColorPanel = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.TextBoxPassword.BackColorTextBox = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.TextBoxPassword.EnableTextBox = true;
            this.TextBoxPassword.ForeColorLabel = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.TextBoxPassword.ForeColorTextBox = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.TextBoxPassword.Location = new System.Drawing.Point(69, 98);
            this.TextBoxPassword.MaxLengthTextBox = 32767;
            this.TextBoxPassword.Name = "TextBoxPassword";
            this.TextBoxPassword.PasswordTextBox = '\0';
            this.TextBoxPassword.SelectionLengthTextBox = 0;
            this.TextBoxPassword.SelectionStartTextBox = 0;
            this.TextBoxPassword.Size = new System.Drawing.Size(491, 32);
            this.TextBoxPassword.TabIndex = 2;
            this.TextBoxPassword.TextLabel = "Contraseña: ";
            this.TextBoxPassword.TextTextBox = "";
            this.TextBoxPassword.Enter += new System.EventHandler(this.EnterTextBoxUI);
            this.TextBoxPassword.Leave += new System.EventHandler(this.LeaveTextBoxUI);
            // 
            // LogUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(662, 314);
            this.Controls.Add(this.PanelContent);
            this.Controls.Add(this.PanelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LogUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio de Sesión";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormClosingMethod);
            this.PanelHeader.ResumeLayout(false);
            this.PanelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureLPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureUser)).EndInit();
            this.PanelContent.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelHeader;
        private System.Windows.Forms.PictureBox PictureIcon;
        private System.Windows.Forms.Label LabelSubTitle;
        private System.Windows.Forms.Label LabelTitle;
        private System.Windows.Forms.PictureBox PictureUser;
        private Presentation.Inputs.TextBoxUI TextBoxUser;
        private Presentation.Inputs.TextBoxUI TextBoxPassword;
        private System.Windows.Forms.PictureBox PictureLPassword;
        private System.Windows.Forms.Button ButtonAccept;
        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.Button ButtonShowPassword;
        private System.Windows.Forms.PictureBox PictureClose;
        private System.Windows.Forms.Panel PanelContent;
    }
}