namespace CapaPre.Search
{
    partial class NumControl
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
            this.panelBorde = new System.Windows.Forms.Panel();
            this.txtNumControl = new System.Windows.Forms.TextBox();
            this.lbSearch = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panelBorde
            // 
            this.panelBorde.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.panelBorde.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBorde.Location = new System.Drawing.Point(0, 33);
            this.panelBorde.Name = "panelBorde";
            this.panelBorde.Size = new System.Drawing.Size(528, 3);
            this.panelBorde.TabIndex = 0;
            // 
            // txtNumControl
            // 
            this.txtNumControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNumControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(223)))), ((int)(((byte)(198)))));
            this.txtNumControl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNumControl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.txtNumControl.Location = new System.Drawing.Point(178, 6);
            this.txtNumControl.MaxLength = 9;
            this.txtNumControl.Name = "txtNumControl";
            this.txtNumControl.Size = new System.Drawing.Size(347, 20);
            this.txtNumControl.TabIndex = 1;
            this.txtNumControl.TextChanged += new System.EventHandler(this.Validar);
            // 
            // lbSearch
            // 
            this.lbSearch.AutoSize = true;
            this.lbSearch.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lbSearch.Location = new System.Drawing.Point(3, 6);
            this.lbSearch.Name = "lbSearch";
            this.lbSearch.Size = new System.Drawing.Size(169, 19);
            this.lbSearch.TabIndex = 2;
            this.lbSearch.Text = "Número de Control:";
            // 
            // NumControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(223)))), ((int)(((byte)(198)))));
            this.Controls.Add(this.lbSearch);
            this.Controls.Add(this.txtNumControl);
            this.Controls.Add(this.panelBorde);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "NumControl";
            this.Size = new System.Drawing.Size(528, 36);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelBorde;
        private System.Windows.Forms.Label lbSearch;
        public System.Windows.Forms.TextBox txtNumControl;
    }
}
