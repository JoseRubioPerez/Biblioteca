namespace Presentation
{
    partial class FormFather
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
            this.PanelInfo = new System.Windows.Forms.Panel();
            this.PictureBoxInfo = new System.Windows.Forms.PictureBox();
            this.ToolTipInfo = new System.Windows.Forms.ToolTip(this.components);
            this.LabelSubTitle = new System.Windows.Forms.Label();
            this.LabelTitle = new System.Windows.Forms.Label();
            this.PanelInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelInfo
            // 
            this.PanelInfo.Controls.Add(this.LabelSubTitle);
            this.PanelInfo.Controls.Add(this.LabelTitle);
            this.PanelInfo.Controls.Add(this.PictureBoxInfo);
            this.PanelInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelInfo.Location = new System.Drawing.Point(0, 0);
            this.PanelInfo.Name = "PanelInfo";
            this.PanelInfo.Size = new System.Drawing.Size(922, 68);
            this.PanelInfo.TabIndex = 0;
            // 
            // PictureBoxInfo
            // 
            this.PictureBoxInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PictureBoxInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureBoxInfo.Image = global::Presentation.Properties.Resources.InformationBlue;
            this.PictureBoxInfo.Location = new System.Drawing.Point(866, 12);
            this.PictureBoxInfo.Name = "PictureBoxInfo";
            this.PictureBoxInfo.Size = new System.Drawing.Size(44, 44);
            this.PictureBoxInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxInfo.TabIndex = 1;
            this.PictureBoxInfo.TabStop = false;
            this.ToolTipInfo.SetToolTip(this.PictureBoxInfo, "Información sobre esta ventana");
            // 
            // ToolTipInfo
            // 
            this.ToolTipInfo.BackColor = System.Drawing.Color.White;
            this.ToolTipInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(32)))));
            // 
            // LabelSubTitle
            // 
            this.LabelSubTitle.AutoSize = true;
            this.LabelSubTitle.Font = new System.Drawing.Font("Arial Narrow", 16F);
            this.LabelSubTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(56)))), ((int)(((byte)(65)))));
            this.LabelSubTitle.Location = new System.Drawing.Point(253, 30);
            this.LabelSubTitle.Name = "LabelSubTitle";
            this.LabelSubTitle.Size = new System.Drawing.Size(351, 26);
            this.LabelSubTitle.TabIndex = 4;
            this.LabelSubTitle.Text = "Administración de los usuarios del sistema";
            // 
            // LabelTitle
            // 
            this.LabelTitle.AutoSize = true;
            this.LabelTitle.Font = new System.Drawing.Font("Arial Narrow", 22F);
            this.LabelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(32)))));
            this.LabelTitle.Location = new System.Drawing.Point(12, 21);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(235, 35);
            this.LabelTitle.TabIndex = 3;
            this.LabelTitle.Text = "Modulo de Usuarios";
            // 
            // FormFather
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(205)))), ((int)(((byte)(203)))));
            this.ClientSize = new System.Drawing.Size(922, 698);
            this.Controls.Add(this.PanelInfo);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormFather";
            this.Text = "WinFather";
            this.PanelInfo.ResumeLayout(false);
            this.PanelInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.PictureBox PictureBoxInfo;
        public System.Windows.Forms.ToolTip ToolTipInfo;
        public System.Windows.Forms.Panel PanelInfo;
        public System.Windows.Forms.Label LabelSubTitle;
        public System.Windows.Forms.Label LabelTitle;
    }
}