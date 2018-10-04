namespace Presentation.PopUpForms
{
    partial class PopUpFather
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
            this.PanelHeader = new System.Windows.Forms.Panel();
            this.PictureIcon = new System.Windows.Forms.PictureBox();
            this.PictureClose = new System.Windows.Forms.PictureBox();
            this.LabelTitle = new System.Windows.Forms.Label();
            this.LabelComboSearch = new System.Windows.Forms.Label();
            this.PanelBorder1 = new System.Windows.Forms.Panel();
            this.ButtonAccept = new System.Windows.Forms.Button();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.PanelContent = new System.Windows.Forms.Panel();
            this.PanelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureClose)).BeginInit();
            this.PanelContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelHeader
            // 
            this.PanelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(32)))));
            this.PanelHeader.Controls.Add(this.PictureIcon);
            this.PanelHeader.Controls.Add(this.PictureClose);
            this.PanelHeader.Controls.Add(this.LabelTitle);
            this.PanelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelHeader.Location = new System.Drawing.Point(0, 0);
            this.PanelHeader.Margin = new System.Windows.Forms.Padding(0);
            this.PanelHeader.Name = "PanelHeader";
            this.PanelHeader.Size = new System.Drawing.Size(972, 70);
            this.PanelHeader.TabIndex = 1;
            // 
            // PictureIcon
            // 
            this.PictureIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureIcon.Image = global::Presentation.Properties.Resources.IconProgram;
            this.PictureIcon.Location = new System.Drawing.Point(17, 13);
            this.PictureIcon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PictureIcon.Name = "PictureIcon";
            this.PictureIcon.Size = new System.Drawing.Size(44, 44);
            this.PictureIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureIcon.TabIndex = 2;
            this.PictureIcon.TabStop = false;
            // 
            // PictureClose
            // 
            this.PictureClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PictureClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureClose.Image = global::Presentation.Properties.Resources.CloseWindowWhite;
            this.PictureClose.Location = new System.Drawing.Point(927, 13);
            this.PictureClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PictureClose.Name = "PictureClose";
            this.PictureClose.Size = new System.Drawing.Size(32, 32);
            this.PictureClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureClose.TabIndex = 0;
            this.PictureClose.TabStop = false;
            this.PictureClose.Click += new System.EventHandler(this.PictureCloseClickMethod);
            // 
            // LabelTitle
            // 
            this.LabelTitle.AutoSize = true;
            this.LabelTitle.Font = new System.Drawing.Font("Arial Narrow", 22F);
            this.LabelTitle.ForeColor = System.Drawing.Color.White;
            this.LabelTitle.Location = new System.Drawing.Point(69, 22);
            this.LabelTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(234, 35);
            this.LabelTitle.TabIndex = 0;
            this.LabelTitle.Text = "Control de Usuarios";
            // 
            // LabelComboSearch
            // 
            this.LabelComboSearch.AutoSize = true;
            this.LabelComboSearch.Font = new System.Drawing.Font("Arial Narrow", 16F);
            this.LabelComboSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(32)))));
            this.LabelComboSearch.Location = new System.Drawing.Point(4, 31);
            this.LabelComboSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelComboSearch.Name = "LabelComboSearch";
            this.LabelComboSearch.Size = new System.Drawing.Size(138, 26);
            this.LabelComboSearch.TabIndex = 6;
            this.LabelComboSearch.Text = "Change my text";
            // 
            // PanelBorder1
            // 
            this.PanelBorder1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(32)))));
            this.PanelBorder1.Location = new System.Drawing.Point(9, 60);
            this.PanelBorder1.Name = "PanelBorder1";
            this.PanelBorder1.Size = new System.Drawing.Size(700, 3);
            this.PanelBorder1.TabIndex = 7;
            // 
            // ButtonAccept
            // 
            this.ButtonAccept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonAccept.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonAccept.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(32)))));
            this.ButtonAccept.FlatAppearance.BorderSize = 3;
            this.ButtonAccept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAccept.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.ButtonAccept.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(32)))));
            this.ButtonAccept.ImageKey = "PlusBlack.png";
            this.ButtonAccept.Location = new System.Drawing.Point(649, 393);
            this.ButtonAccept.Name = "ButtonAccept";
            this.ButtonAccept.Size = new System.Drawing.Size(121, 47);
            this.ButtonAccept.TabIndex = 8;
            this.ButtonAccept.Text = "Aceptar";
            this.ButtonAccept.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonAccept.UseVisualStyleBackColor = true;
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(32)))));
            this.ButtonCancel.FlatAppearance.BorderSize = 3;
            this.ButtonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonCancel.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.ButtonCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(32)))));
            this.ButtonCancel.ImageKey = "PlusBlack.png";
            this.ButtonCancel.Location = new System.Drawing.Point(818, 393);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(121, 47);
            this.ButtonCancel.TabIndex = 9;
            this.ButtonCancel.Text = "Cancelar";
            this.ButtonCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonCancel.UseVisualStyleBackColor = true;
            // 
            // PanelContent
            // 
            this.PanelContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(205)))), ((int)(((byte)(203)))));
            this.PanelContent.Controls.Add(this.ButtonCancel);
            this.PanelContent.Controls.Add(this.PanelBorder1);
            this.PanelContent.Controls.Add(this.ButtonAccept);
            this.PanelContent.Controls.Add(this.LabelComboSearch);
            this.PanelContent.Location = new System.Drawing.Point(17, 70);
            this.PanelContent.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.PanelContent.Name = "PanelContent";
            this.PanelContent.Size = new System.Drawing.Size(942, 443);
            this.PanelContent.TabIndex = 10;
            // 
            // PopUpFather
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(972, 525);
            this.Controls.Add(this.PanelContent);
            this.Controls.Add(this.PanelHeader);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PopUpFather";
            this.Text = "PopUpFather";
            this.PanelHeader.ResumeLayout(false);
            this.PanelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureClose)).EndInit();
            this.PanelContent.ResumeLayout(false);
            this.PanelContent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelHeader;
        private System.Windows.Forms.PictureBox PictureClose;
        public System.Windows.Forms.Label LabelTitle;
        public System.Windows.Forms.PictureBox PictureIcon;
        public System.Windows.Forms.Label LabelComboSearch;
        public System.Windows.Forms.Panel PanelBorder1;
        public System.Windows.Forms.Button ButtonAccept;
        public System.Windows.Forms.Button ButtonCancel;
        public System.Windows.Forms.Panel PanelContent;
    }
}