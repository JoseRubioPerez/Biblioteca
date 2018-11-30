namespace Presentation
{
    partial class Alerts
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
            this.TableLayoutPanelHeader = new System.Windows.Forms.TableLayoutPanel();
            this.LabelTitle = new System.Windows.Forms.Label();
            this.LabelSubTitle = new System.Windows.Forms.Label();
            this.PictureClose = new System.Windows.Forms.PictureBox();
            this.PictureBoxIcon = new System.Windows.Forms.PictureBox();
            this.TableLayoutPanelContent = new System.Windows.Forms.TableLayoutPanel();
            this.PanelButtons = new System.Windows.Forms.Panel();
            this.ButtonYes = new System.Windows.Forms.Button();
            this.ButtonNo = new System.Windows.Forms.Button();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.FlowLayoutPanelText = new System.Windows.Forms.FlowLayoutPanel();
            this.LabelText = new System.Windows.Forms.Label();
            this.PanelHeader.SuspendLayout();
            this.TableLayoutPanelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxIcon)).BeginInit();
            this.TableLayoutPanelContent.SuspendLayout();
            this.PanelButtons.SuspendLayout();
            this.FlowLayoutPanelText.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelHeader
            // 
            this.PanelHeader.Controls.Add(this.TableLayoutPanelHeader);
            this.PanelHeader.Controls.Add(this.PictureClose);
            this.PanelHeader.Controls.Add(this.PictureBoxIcon);
            this.PanelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelHeader.Location = new System.Drawing.Point(0, 0);
            this.PanelHeader.Margin = new System.Windows.Forms.Padding(0);
            this.PanelHeader.Name = "PanelHeader";
            this.PanelHeader.Size = new System.Drawing.Size(851, 80);
            this.PanelHeader.TabIndex = 0;
            // 
            // TableLayoutPanelHeader
            // 
            this.TableLayoutPanelHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TableLayoutPanelHeader.ColumnCount = 2;
            this.TableLayoutPanelHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.TableLayoutPanelHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.TableLayoutPanelHeader.Controls.Add(this.LabelTitle, 0, 0);
            this.TableLayoutPanelHeader.Controls.Add(this.LabelSubTitle, 1, 0);
            this.TableLayoutPanelHeader.Location = new System.Drawing.Point(59, 18);
            this.TableLayoutPanelHeader.Margin = new System.Windows.Forms.Padding(0);
            this.TableLayoutPanelHeader.Name = "TableLayoutPanelHeader";
            this.TableLayoutPanelHeader.RowCount = 1;
            this.TableLayoutPanelHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanelHeader.Size = new System.Drawing.Size(745, 44);
            this.TableLayoutPanelHeader.TabIndex = 8;
            // 
            // LabelTitle
            // 
            this.LabelTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LabelTitle.AutoSize = true;
            this.LabelTitle.Font = new System.Drawing.Font("Arial Narrow", 22F);
            this.LabelTitle.ForeColor = System.Drawing.Color.White;
            this.LabelTitle.Location = new System.Drawing.Point(3, 9);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(162, 35);
            this.LabelTitle.TabIndex = 5;
            this.LabelTitle.Text = "Iniciar Sesión";
            // 
            // LabelSubTitle
            // 
            this.LabelSubTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LabelSubTitle.AutoSize = true;
            this.LabelSubTitle.Font = new System.Drawing.Font("Arial Narrow", 16F);
            this.LabelSubTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.LabelSubTitle.Location = new System.Drawing.Point(301, 18);
            this.LabelSubTitle.Name = "LabelSubTitle";
            this.LabelSubTitle.Size = new System.Drawing.Size(112, 26);
            this.LabelSubTitle.TabIndex = 6;
            this.LabelSubTitle.Text = "¡Bienvenido!";
            // 
            // PictureClose
            // 
            this.PictureClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PictureClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureClose.Image = global::Presentation.Properties.Resources.CloseWindowWhite;
            this.PictureClose.Location = new System.Drawing.Point(807, 12);
            this.PictureClose.Name = "PictureClose";
            this.PictureClose.Size = new System.Drawing.Size(32, 32);
            this.PictureClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureClose.TabIndex = 7;
            this.PictureClose.TabStop = false;
            this.PictureClose.Click += new System.EventHandler(this.PictureCloseClickMethod);
            // 
            // PictureBoxIcon
            // 
            this.PictureBoxIcon.Image = global::Presentation.Properties.Resources.InformationWhite;
            this.PictureBoxIcon.Location = new System.Drawing.Point(12, 18);
            this.PictureBoxIcon.Name = "PictureBoxIcon";
            this.PictureBoxIcon.Size = new System.Drawing.Size(44, 44);
            this.PictureBoxIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxIcon.TabIndex = 1;
            this.PictureBoxIcon.TabStop = false;
            // 
            // TableLayoutPanelContent
            // 
            this.TableLayoutPanelContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TableLayoutPanelContent.AutoScroll = true;
            this.TableLayoutPanelContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(205)))), ((int)(((byte)(203)))));
            this.TableLayoutPanelContent.ColumnCount = 1;
            this.TableLayoutPanelContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanelContent.Controls.Add(this.PanelButtons, 0, 1);
            this.TableLayoutPanelContent.Controls.Add(this.FlowLayoutPanelText, 0, 0);
            this.TableLayoutPanelContent.Location = new System.Drawing.Point(19, 80);
            this.TableLayoutPanelContent.Margin = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.TableLayoutPanelContent.Name = "TableLayoutPanelContent";
            this.TableLayoutPanelContent.RowCount = 2;
            this.TableLayoutPanelContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.TableLayoutPanelContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TableLayoutPanelContent.Size = new System.Drawing.Size(813, 339);
            this.TableLayoutPanelContent.TabIndex = 1;
            // 
            // PanelButtons
            // 
            this.PanelButtons.Controls.Add(this.ButtonYes);
            this.PanelButtons.Controls.Add(this.ButtonNo);
            this.PanelButtons.Controls.Add(this.ButtonCancel);
            this.PanelButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelButtons.Location = new System.Drawing.Point(0, 271);
            this.PanelButtons.Margin = new System.Windows.Forms.Padding(0);
            this.PanelButtons.Name = "PanelButtons";
            this.PanelButtons.Size = new System.Drawing.Size(813, 68);
            this.PanelButtons.TabIndex = 0;
            // 
            // ButtonYes
            // 
            this.ButtonYes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonYes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonYes.FlatAppearance.BorderSize = 2;
            this.ButtonYes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonYes.Location = new System.Drawing.Point(402, 15);
            this.ButtonYes.Margin = new System.Windows.Forms.Padding(3, 10, 10, 3);
            this.ButtonYes.Name = "ButtonYes";
            this.ButtonYes.Size = new System.Drawing.Size(113, 38);
            this.ButtonYes.TabIndex = 2;
            this.ButtonYes.Text = "Si";
            this.ButtonYes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonYes.UseVisualStyleBackColor = true;
            // 
            // ButtonNo
            // 
            this.ButtonNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonNo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonNo.FlatAppearance.BorderSize = 2;
            this.ButtonNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonNo.Location = new System.Drawing.Point(546, 15);
            this.ButtonNo.Margin = new System.Windows.Forms.Padding(3, 10, 10, 3);
            this.ButtonNo.Name = "ButtonNo";
            this.ButtonNo.Size = new System.Drawing.Size(113, 38);
            this.ButtonNo.TabIndex = 1;
            this.ButtonNo.Text = "No";
            this.ButtonNo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonNo.UseVisualStyleBackColor = true;
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonCancel.FlatAppearance.BorderSize = 2;
            this.ButtonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonCancel.Location = new System.Drawing.Point(690, 15);
            this.ButtonCancel.Margin = new System.Windows.Forms.Padding(3, 10, 10, 3);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(113, 38);
            this.ButtonCancel.TabIndex = 0;
            this.ButtonCancel.Text = "Cancelar";
            this.ButtonCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonCancel.UseVisualStyleBackColor = true;
            // 
            // FlowLayoutPanelText
            // 
            this.FlowLayoutPanelText.AutoScroll = true;
            this.FlowLayoutPanelText.Controls.Add(this.LabelText);
            this.FlowLayoutPanelText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlowLayoutPanelText.Location = new System.Drawing.Point(0, 0);
            this.FlowLayoutPanelText.Margin = new System.Windows.Forms.Padding(0);
            this.FlowLayoutPanelText.Name = "FlowLayoutPanelText";
            this.FlowLayoutPanelText.Size = new System.Drawing.Size(813, 271);
            this.FlowLayoutPanelText.TabIndex = 1;
            // 
            // LabelText
            // 
            this.LabelText.AutoSize = true;
            this.LabelText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LabelText.Location = new System.Drawing.Point(3, 0);
            this.LabelText.Name = "LabelText";
            this.LabelText.Padding = new System.Windows.Forms.Padding(40);
            this.LabelText.Size = new System.Drawing.Size(203, 103);
            this.LabelText.TabIndex = 0;
            this.LabelText.Text = "Change My Text";
            this.LabelText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Alerts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(851, 438);
            this.Controls.Add(this.TableLayoutPanelContent);
            this.Controls.Add(this.PanelHeader);
            this.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Alerts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "¡Alerta!";
            this.PanelHeader.ResumeLayout(false);
            this.TableLayoutPanelHeader.ResumeLayout(false);
            this.TableLayoutPanelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxIcon)).EndInit();
            this.TableLayoutPanelContent.ResumeLayout(false);
            this.PanelButtons.ResumeLayout(false);
            this.FlowLayoutPanelText.ResumeLayout(false);
            this.FlowLayoutPanelText.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelHeader;
        private System.Windows.Forms.PictureBox PictureBoxIcon;
        private System.Windows.Forms.Label LabelSubTitle;
        private System.Windows.Forms.Label LabelTitle;
        private System.Windows.Forms.PictureBox PictureClose;
        private System.Windows.Forms.TableLayoutPanel TableLayoutPanelContent;
        private System.Windows.Forms.Panel PanelButtons;
        private System.Windows.Forms.Label LabelText;
        private System.Windows.Forms.FlowLayoutPanel FlowLayoutPanelText;
        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.Button ButtonYes;
        private System.Windows.Forms.Button ButtonNo;
        private System.Windows.Forms.TableLayoutPanel TableLayoutPanelHeader;
    }
}