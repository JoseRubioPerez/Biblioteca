namespace Application
{
    partial class Reports
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
            this.TablePanelReports = new System.Windows.Forms.TableLayoutPanel();
            this.LabelHeader2 = new System.Windows.Forms.Label();
            this.LabelHeader = new System.Windows.Forms.Label();
            this.panelTipoReporte = new System.Windows.Forms.Panel();
            this.ButtonClean = new System.Windows.Forms.Button();
            this.ButtonReport = new System.Windows.Forms.Button();
            this.ComboServicios = new System.Windows.Forms.ComboBox();
            this.LabelServicio = new System.Windows.Forms.Label();
            this.TablePanelReports.SuspendLayout();
            this.panelTipoReporte.SuspendLayout();
            this.SuspendLayout();
            // 
            // TablePanelReports
            // 
            this.TablePanelReports.ColumnCount = 1;
            this.TablePanelReports.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TablePanelReports.Controls.Add(this.LabelHeader2, 0, 1);
            this.TablePanelReports.Controls.Add(this.LabelHeader, 0, 0);
            this.TablePanelReports.Controls.Add(this.panelTipoReporte, 0, 2);
            this.TablePanelReports.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TablePanelReports.Location = new System.Drawing.Point(0, 0);
            this.TablePanelReports.Name = "TablePanelReports";
            this.TablePanelReports.RowCount = 3;
            this.TablePanelReports.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.TablePanelReports.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.TablePanelReports.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TablePanelReports.Size = new System.Drawing.Size(1140, 507);
            this.TablePanelReports.TabIndex = 0;
            // 
            // LabelHeader2
            // 
            this.LabelHeader2.AutoSize = true;
            this.LabelHeader2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelHeader2.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelHeader2.Location = new System.Drawing.Point(3, 60);
            this.LabelHeader2.Name = "LabelHeader2";
            this.LabelHeader2.Size = new System.Drawing.Size(1134, 45);
            this.LabelHeader2.TabIndex = 20;
            this.LabelHeader2.Text = "Por favor, elige un tipo de servicio y un tipo de sexo para generar un reporte";
            this.LabelHeader2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelHeader
            // 
            this.LabelHeader.AutoSize = true;
            this.LabelHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelHeader.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelHeader.Location = new System.Drawing.Point(3, 0);
            this.LabelHeader.Name = "LabelHeader";
            this.LabelHeader.Size = new System.Drawing.Size(1134, 60);
            this.LabelHeader.TabIndex = 19;
            this.LabelHeader.Text = "Genera los reportes necesarios de los datos almacenados del centro de información" +
    "";
            this.LabelHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelTipoReporte
            // 
            this.panelTipoReporte.Controls.Add(this.ButtonClean);
            this.panelTipoReporte.Controls.Add(this.ButtonReport);
            this.panelTipoReporte.Controls.Add(this.ComboServicios);
            this.panelTipoReporte.Controls.Add(this.LabelServicio);
            this.panelTipoReporte.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTipoReporte.Location = new System.Drawing.Point(3, 108);
            this.panelTipoReporte.Name = "panelTipoReporte";
            this.panelTipoReporte.Size = new System.Drawing.Size(1134, 396);
            this.panelTipoReporte.TabIndex = 21;
            // 
            // ButtonClean
            // 
            this.ButtonClean.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonClean.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonClean.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.ButtonClean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonClean.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.ButtonClean.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonClean.ImageKey = "searchClean.png";
            this.ButtonClean.Location = new System.Drawing.Point(664, 219);
            this.ButtonClean.Name = "ButtonClean";
            this.ButtonClean.Size = new System.Drawing.Size(166, 32);
            this.ButtonClean.TabIndex = 7;
            this.ButtonClean.TabStop = false;
            this.ButtonClean.Text = "Limpiar campos";
            this.ButtonClean.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonClean.UseVisualStyleBackColor = true;
            this.ButtonClean.Click += new System.EventHandler(this.EventoClick);
            // 
            // ButtonReport
            // 
            this.ButtonReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonReport.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.ButtonReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonReport.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.ButtonReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonReport.ImageKey = "searchClean.png";
            this.ButtonReport.Location = new System.Drawing.Point(458, 219);
            this.ButtonReport.Name = "ButtonReport";
            this.ButtonReport.Size = new System.Drawing.Size(166, 32);
            this.ButtonReport.TabIndex = 6;
            this.ButtonReport.TabStop = false;
            this.ButtonReport.Text = "Generar reporte";
            this.ButtonReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonReport.UseVisualStyleBackColor = true;
            this.ButtonReport.Click += new System.EventHandler(this.EventoClick);
            // 
            // ComboServicios
            // 
            this.ComboServicios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboServicios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ComboServicios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboServicios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboServicios.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.ComboServicios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.ComboServicios.FormattingEnabled = true;
            this.ComboServicios.Items.AddRange(new object[] {
            "Consulta o Referencia",
            "Bases de Datos",
            "Cubículos",
            "Sala de Trabajo en Equipo",
            "Sala de Lectura",
            "Baños",
            "Otros"});
            this.ComboServicios.Location = new System.Drawing.Point(457, 145);
            this.ComboServicios.Name = "ComboServicios";
            this.ComboServicios.Size = new System.Drawing.Size(373, 27);
            this.ComboServicios.TabIndex = 1;
            // 
            // LabelServicio
            // 
            this.LabelServicio.AutoSize = true;
            this.LabelServicio.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelServicio.Location = new System.Drawing.Point(304, 148);
            this.LabelServicio.Name = "LabelServicio";
            this.LabelServicio.Size = new System.Drawing.Size(147, 19);
            this.LabelServicio.TabIndex = 0;
            this.LabelServicio.Text = "Elige un servicio:";
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(223)))), ((int)(((byte)(198)))));
            this.ClientSize = new System.Drawing.Size(1140, 507);
            this.Controls.Add(this.TablePanelReports);
            this.Font = new System.Drawing.Font("Tahoma", 12F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Reports";
            this.Text = "Reports";
            this.TablePanelReports.ResumeLayout(false);
            this.TablePanelReports.PerformLayout();
            this.panelTipoReporte.ResumeLayout(false);
            this.panelTipoReporte.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TablePanelReports;
        private System.Windows.Forms.Label LabelHeader;
        private System.Windows.Forms.Panel panelTipoReporte;
        private System.Windows.Forms.Label LabelHeader2;
        private System.Windows.Forms.Label LabelServicio;
        private System.Windows.Forms.ComboBox ComboServicios;
        private System.Windows.Forms.Button ButtonReport;
        private System.Windows.Forms.Button ButtonClean;
    }
}