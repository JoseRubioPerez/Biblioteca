namespace CapaPre
{
    partial class NewAdmin
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
            this.lbTitulo = new System.Windows.Forms.Label();
            this.tableNewAdmin = new System.Windows.Forms.TableLayoutPanel();
            this.panelContenido = new System.Windows.Forms.Panel();
            this.tableNewAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.tableNewAdmin.SetColumnSpan(this.lbTitulo, 3);
            this.lbTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbTitulo.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.Location = new System.Drawing.Point(3, 0);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.lbTitulo.Size = new System.Drawing.Size(1134, 80);
            this.lbTitulo.TabIndex = 17;
            this.lbTitulo.Text = "Crea un nuevo administrador o cambia el modo \"Super Usuario\" a uno ya existente";
            this.lbTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableNewAdmin
            // 
            this.tableNewAdmin.ColumnCount = 3;
            this.tableNewAdmin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableNewAdmin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableNewAdmin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableNewAdmin.Controls.Add(this.lbTitulo, 0, 0);
            this.tableNewAdmin.Controls.Add(this.panelContenido, 1, 1);
            this.tableNewAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableNewAdmin.Location = new System.Drawing.Point(0, 0);
            this.tableNewAdmin.Name = "tableNewAdmin";
            this.tableNewAdmin.RowCount = 2;
            this.tableNewAdmin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableNewAdmin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableNewAdmin.Size = new System.Drawing.Size(1140, 507);
            this.tableNewAdmin.TabIndex = 18;
            // 
            // panelContenido
            // 
            this.panelContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenido.Location = new System.Drawing.Point(117, 83);
            this.panelContenido.Name = "panelContenido";
            this.panelContenido.Size = new System.Drawing.Size(906, 421);
            this.panelContenido.TabIndex = 18;
            // 
            // NewAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(223)))), ((int)(((byte)(198)))));
            this.Controls.Add(this.tableNewAdmin);
            this.Font = new System.Drawing.Font("Tahoma", 12F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "NewAdmin";
            this.Size = new System.Drawing.Size(1140, 507);
            this.tableNewAdmin.ResumeLayout(false);
            this.tableNewAdmin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.TableLayoutPanel tableNewAdmin;
        private System.Windows.Forms.Panel panelContenido;
    }
}
