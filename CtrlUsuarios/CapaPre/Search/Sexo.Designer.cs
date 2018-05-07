namespace CapaPre.Search
{
    partial class Sexo
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
            this.groupSexo = new System.Windows.Forms.GroupBox();
            this.radioMujer = new System.Windows.Forms.RadioButton();
            this.radioHombre = new System.Windows.Forms.RadioButton();
            this.groupSexo.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupSexo
            // 
            this.groupSexo.Controls.Add(this.radioMujer);
            this.groupSexo.Controls.Add(this.radioHombre);
            this.groupSexo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupSexo.Location = new System.Drawing.Point(0, 0);
            this.groupSexo.Name = "groupSexo";
            this.groupSexo.Size = new System.Drawing.Size(528, 36);
            this.groupSexo.TabIndex = 0;
            this.groupSexo.TabStop = false;
            // 
            // radioMujer
            // 
            this.radioMujer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioMujer.AutoSize = true;
            this.radioMujer.Location = new System.Drawing.Point(296, 10);
            this.radioMujer.Name = "radioMujer";
            this.radioMujer.Size = new System.Drawing.Size(74, 23);
            this.radioMujer.TabIndex = 1;
            this.radioMujer.TabStop = true;
            this.radioMujer.Text = "Mujer";
            this.radioMujer.UseVisualStyleBackColor = true;
            this.radioMujer.CheckedChanged += new System.EventHandler(this.Validar);
            // 
            // radioHombre
            // 
            this.radioHombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioHombre.AutoSize = true;
            this.radioHombre.Location = new System.Drawing.Point(159, 10);
            this.radioHombre.Name = "radioHombre";
            this.radioHombre.Size = new System.Drawing.Size(91, 23);
            this.radioHombre.TabIndex = 0;
            this.radioHombre.TabStop = true;
            this.radioHombre.Text = "Hombre";
            this.radioHombre.UseVisualStyleBackColor = true;
            // 
            // Sexo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(223)))), ((int)(((byte)(198)))));
            this.Controls.Add(this.groupSexo);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Sexo";
            this.Size = new System.Drawing.Size(528, 36);
            this.groupSexo.ResumeLayout(false);
            this.groupSexo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupSexo;
        public System.Windows.Forms.RadioButton radioMujer;
        public System.Windows.Forms.RadioButton radioHombre;
    }
}
