﻿namespace Application.Search
{
    partial class Service
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
            this.comboAreas = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // comboAreas
            // 
            this.comboAreas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboAreas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboAreas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboAreas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboAreas.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboAreas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.comboAreas.FormattingEnabled = true;
            this.comboAreas.Items.AddRange(new object[] {
            "Consulta o referencia",
            "Bases de datos",
            "Cubículos",
            "Sala de trabajo en equipo",
            "Sala de lectura",
            "Baños",
            "Otros"});
            this.comboAreas.Location = new System.Drawing.Point(3, 5);
            this.comboAreas.Name = "comboAreas";
            this.comboAreas.Size = new System.Drawing.Size(522, 27);
            this.comboAreas.TabIndex = 1;
            // 
            // Servicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(223)))), ((int)(((byte)(198)))));
            this.Controls.Add(this.comboAreas);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Servicio";
            this.Size = new System.Drawing.Size(528, 36);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ComboBox comboAreas;
    }
}