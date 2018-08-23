namespace Application.Search
{
    partial class Status
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
            this.groupStatus = new System.Windows.Forms.GroupBox();
            this.radioInactivo = new System.Windows.Forms.RadioButton();
            this.radioActivo = new System.Windows.Forms.RadioButton();
            this.groupStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupStatus
            // 
            this.groupStatus.Controls.Add(this.radioInactivo);
            this.groupStatus.Controls.Add(this.radioActivo);
            this.groupStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupStatus.Location = new System.Drawing.Point(0, 0);
            this.groupStatus.Name = "groupStatus";
            this.groupStatus.Size = new System.Drawing.Size(528, 36);
            this.groupStatus.TabIndex = 1;
            this.groupStatus.TabStop = false;
            // 
            // radioInactivo
            // 
            this.radioInactivo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioInactivo.AutoSize = true;
            this.radioInactivo.Location = new System.Drawing.Point(286, 10);
            this.radioInactivo.Name = "radioInactivo";
            this.radioInactivo.Size = new System.Drawing.Size(93, 23);
            this.radioInactivo.TabIndex = 1;
            this.radioInactivo.TabStop = true;
            this.radioInactivo.Text = "Inactivo";
            this.radioInactivo.UseVisualStyleBackColor = true;
            this.radioInactivo.CheckedChanged += new System.EventHandler(this.Validar);
            // 
            // radioActivo
            // 
            this.radioActivo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioActivo.AutoSize = true;
            this.radioActivo.Location = new System.Drawing.Point(149, 10);
            this.radioActivo.Name = "radioActivo";
            this.radioActivo.Size = new System.Drawing.Size(78, 23);
            this.radioActivo.TabIndex = 0;
            this.radioActivo.TabStop = true;
            this.radioActivo.Text = "Activo";
            this.radioActivo.UseVisualStyleBackColor = true;
            // 
            // Status
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(223)))), ((int)(((byte)(198)))));
            this.Controls.Add(this.groupStatus);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Status";
            this.Size = new System.Drawing.Size(528, 36);
            this.groupStatus.ResumeLayout(false);
            this.groupStatus.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupStatus;
        public System.Windows.Forms.RadioButton radioInactivo;
        public System.Windows.Forms.RadioButton radioActivo;
    }
}
