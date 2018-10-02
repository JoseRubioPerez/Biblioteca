namespace Presentation
{
    partial class Binnacle
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
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxInfo)).BeginInit();
            this.PanelInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // PictureBoxInfo
            // 
            this.PictureBoxInfo.Location = new System.Drawing.Point(744, 12);
            this.ToolTipInfo.SetToolTip(this.PictureBoxInfo, "Información sobre esta ventana");
            // 
            // PanelInfo
            // 
            this.PanelInfo.Size = new System.Drawing.Size(800, 68);
            // 
            // LabelSubTitle
            // 
            this.LabelSubTitle.Location = new System.Drawing.Point(270, 30);
            this.LabelSubTitle.Size = new System.Drawing.Size(291, 26);
            this.LabelSubTitle.Text = "Registros de actividad del software";
            // 
            // LabelTitle
            // 
            this.LabelTitle.Size = new System.Drawing.Size(252, 35);
            this.LabelTitle.Text = "Bitácoras del Sistema";
            // 
            // Binnacle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "Binnacle";
            this.Text = "Binnacle";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxInfo)).EndInit();
            this.PanelInfo.ResumeLayout(false);
            this.PanelInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
    }
}