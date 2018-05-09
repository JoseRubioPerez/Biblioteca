namespace CapaPre.Search
{
    partial class Fecha
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
            this.dateInicio = new System.Windows.Forms.DateTimePicker();
            this.lbMoves = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateFin = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // dateInicio
            // 
            this.dateInicio.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.dateInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateInicio.Location = new System.Drawing.Point(140, 5);
            this.dateInicio.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.dateInicio.MinDate = new System.DateTime(1970, 1, 1, 0, 0, 0, 0);
            this.dateInicio.Name = "dateInicio";
            this.dateInicio.Size = new System.Drawing.Size(141, 27);
            this.dateInicio.TabIndex = 1;
            // 
            // lbMoves
            // 
            this.lbMoves.AutoSize = true;
            this.lbMoves.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lbMoves.Location = new System.Drawing.Point(12, 9);
            this.lbMoves.Name = "lbMoves";
            this.lbMoves.Size = new System.Drawing.Size(122, 19);
            this.lbMoves.TabIndex = 22;
            this.lbMoves.Text = "Buscar desde:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(287, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 19);
            this.label1.TabIndex = 24;
            this.label1.Text = "hasta:";
            // 
            // dateFin
            // 
            this.dateFin.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.dateFin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFin.Location = new System.Drawing.Point(353, 5);
            this.dateFin.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.dateFin.MinDate = new System.DateTime(1970, 1, 1, 0, 0, 0, 0);
            this.dateFin.Name = "dateFin";
            this.dateFin.Size = new System.Drawing.Size(141, 27);
            this.dateFin.TabIndex = 23;
            // 
            // Fecha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(223)))), ((int)(((byte)(198)))));
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateFin);
            this.Controls.Add(this.lbMoves);
            this.Controls.Add(this.dateInicio);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Fecha";
            this.Size = new System.Drawing.Size(528, 36);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbMoves;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DateTimePicker dateInicio;
        public System.Windows.Forms.DateTimePicker dateFin;
    }
}
