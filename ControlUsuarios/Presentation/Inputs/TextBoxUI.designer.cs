namespace Presentation.Inputs
{
    partial class TextBoxUI
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
            this.LabelControl = new System.Windows.Forms.Label();
            this.PanelControl = new System.Windows.Forms.Panel();
            this.TextBoxControl = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LabelControl
            // 
            this.LabelControl.AutoSize = true;
            this.LabelControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.LabelControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.LabelControl.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelControl.ForeColor = System.Drawing.Color.White;
            this.LabelControl.Location = new System.Drawing.Point(0, 0);
            this.LabelControl.Margin = new System.Windows.Forms.Padding(0);
            this.LabelControl.Name = "LabelControl";
            this.LabelControl.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.LabelControl.Size = new System.Drawing.Size(160, 24);
            this.LabelControl.TabIndex = 0;
            this.LabelControl.Text = "Change my text";
            this.LabelControl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PanelControl
            // 
            this.PanelControl.BackColor = System.Drawing.Color.White;
            this.PanelControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelControl.Location = new System.Drawing.Point(0, 31);
            this.PanelControl.Name = "PanelControl";
            this.PanelControl.Size = new System.Drawing.Size(491, 5);
            this.PanelControl.TabIndex = 3;
            // 
            // TextBoxControl
            // 
            this.TextBoxControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.TextBoxControl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBoxControl.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxControl.ForeColor = System.Drawing.Color.White;
            this.TextBoxControl.Location = new System.Drawing.Point(160, 0);
            this.TextBoxControl.Margin = new System.Windows.Forms.Padding(0);
            this.TextBoxControl.Name = "TextBoxControl";
            this.TextBoxControl.Size = new System.Drawing.Size(331, 25);
            this.TextBoxControl.TabIndex = 4;
            // 
            // TextBoxUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.Controls.Add(this.TextBoxControl);
            this.Controls.Add(this.LabelControl);
            this.Controls.Add(this.PanelControl);
            this.Name = "TextBoxUI";
            this.Size = new System.Drawing.Size(491, 36);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel PanelControl;
        private System.Windows.Forms.Label LabelControl;
        private System.Windows.Forms.TextBox TextBoxControl;
    }
}
