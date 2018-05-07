namespace CapaPre.Search
{
    partial class AmbosApellidos
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbSearch = new System.Windows.Forms.Label();
            this.txtApellidoPaterno = new System.Windows.Forms.TextBox();
            this.lbSearch02 = new System.Windows.Forms.Label();
            this.txtApellidoMaterno = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(835, 3);
            this.panel1.TabIndex = 0;
            // 
            // lbSearch
            // 
            this.lbSearch.AutoSize = true;
            this.lbSearch.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lbSearch.Location = new System.Drawing.Point(3, 7);
            this.lbSearch.Name = "lbSearch";
            this.lbSearch.Size = new System.Drawing.Size(151, 19);
            this.lbSearch.TabIndex = 6;
            this.lbSearch.Text = "Apellido paterno:";
            // 
            // txtApellidoPaterno
            // 
            this.txtApellidoPaterno.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtApellidoPaterno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(223)))), ((int)(((byte)(198)))));
            this.txtApellidoPaterno.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtApellidoPaterno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.txtApellidoPaterno.Location = new System.Drawing.Point(160, 6);
            this.txtApellidoPaterno.MaxLength = 40;
            this.txtApellidoPaterno.Name = "txtApellidoPaterno";
            this.txtApellidoPaterno.Size = new System.Drawing.Size(254, 20);
            this.txtApellidoPaterno.TabIndex = 1;
            // 
            // lbSearch02
            // 
            this.lbSearch02.AutoSize = true;
            this.lbSearch02.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lbSearch02.Location = new System.Drawing.Point(420, 7);
            this.lbSearch02.Name = "lbSearch02";
            this.lbSearch02.Size = new System.Drawing.Size(156, 19);
            this.lbSearch02.TabIndex = 8;
            this.lbSearch02.Text = "Apellido materno:";
            // 
            // txtApellidoMaterno
            // 
            this.txtApellidoMaterno.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtApellidoMaterno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(223)))), ((int)(((byte)(198)))));
            this.txtApellidoMaterno.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtApellidoMaterno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.txtApellidoMaterno.Location = new System.Drawing.Point(582, 6);
            this.txtApellidoMaterno.MaxLength = 40;
            this.txtApellidoMaterno.Name = "txtApellidoMaterno";
            this.txtApellidoMaterno.Size = new System.Drawing.Size(250, 20);
            this.txtApellidoMaterno.TabIndex = 2;
            // 
            // AmbosApellidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(223)))), ((int)(((byte)(198)))));
            this.Controls.Add(this.lbSearch02);
            this.Controls.Add(this.txtApellidoMaterno);
            this.Controls.Add(this.lbSearch);
            this.Controls.Add(this.txtApellidoPaterno);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "AmbosApellidos";
            this.Size = new System.Drawing.Size(835, 36);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbSearch;
        public System.Windows.Forms.TextBox txtApellidoPaterno;
        private System.Windows.Forms.Label lbSearch02;
        public System.Windows.Forms.TextBox txtApellidoMaterno;
    }
}
