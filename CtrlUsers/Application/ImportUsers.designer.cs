namespace Application
{
    partial class ImportUsers
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TablePanelImportUsers = new System.Windows.Forms.TableLayoutPanel();
            this.GridCSV = new System.Windows.Forms.DataGridView();
            this.LabelTitle = new System.Windows.Forms.Label();
            this.PanelContenido = new System.Windows.Forms.Panel();
            this.LabelFile2 = new System.Windows.Forms.Label();
            this.ButtonFile = new System.Windows.Forms.Button();
            this.LabelFile = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonImportUsers = new System.Windows.Forms.Button();
            this.TablePanelImportUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridCSV)).BeginInit();
            this.PanelContenido.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TablePanelImportUsers
            // 
            this.TablePanelImportUsers.ColumnCount = 2;
            this.TablePanelImportUsers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TablePanelImportUsers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 254F));
            this.TablePanelImportUsers.Controls.Add(this.GridCSV, 0, 2);
            this.TablePanelImportUsers.Controls.Add(this.LabelTitle, 0, 0);
            this.TablePanelImportUsers.Controls.Add(this.PanelContenido, 0, 1);
            this.TablePanelImportUsers.Controls.Add(this.panel1, 1, 2);
            this.TablePanelImportUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TablePanelImportUsers.Location = new System.Drawing.Point(0, 0);
            this.TablePanelImportUsers.Name = "TablePanelImportUsers";
            this.TablePanelImportUsers.RowCount = 3;
            this.TablePanelImportUsers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.TablePanelImportUsers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.TablePanelImportUsers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TablePanelImportUsers.Size = new System.Drawing.Size(1140, 507);
            this.TablePanelImportUsers.TabIndex = 0;
            // 
            // GridCSV
            // 
            this.GridCSV.AllowUserToAddRows = false;
            this.GridCSV.AllowUserToDeleteRows = false;
            this.GridCSV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.GridCSV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.GridCSV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(223)))), ((int)(((byte)(198)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridCSV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GridCSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridCSV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GridCSV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridCSV.Location = new System.Drawing.Point(3, 143);
            this.GridCSV.Name = "GridCSV";
            this.GridCSV.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridCSV.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.GridCSV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridCSV.Size = new System.Drawing.Size(880, 361);
            this.GridCSV.TabIndex = 22;
            this.GridCSV.TabStop = false;
            // 
            // LabelTitle
            // 
            this.LabelTitle.AutoSize = true;
            this.TablePanelImportUsers.SetColumnSpan(this.LabelTitle, 2);
            this.LabelTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelTitle.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTitle.Location = new System.Drawing.Point(3, 0);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(1134, 60);
            this.LabelTitle.TabIndex = 20;
            this.LabelTitle.Text = "Importación de usuarios a la base de datos por medio de archivo de Excel (xlsx)";
            this.LabelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PanelContenido
            // 
            this.TablePanelImportUsers.SetColumnSpan(this.PanelContenido, 2);
            this.PanelContenido.Controls.Add(this.LabelFile2);
            this.PanelContenido.Controls.Add(this.ButtonFile);
            this.PanelContenido.Controls.Add(this.LabelFile);
            this.PanelContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContenido.Location = new System.Drawing.Point(3, 63);
            this.PanelContenido.Name = "PanelContenido";
            this.PanelContenido.Size = new System.Drawing.Size(1134, 74);
            this.PanelContenido.TabIndex = 21;
            // 
            // LabelFile2
            // 
            this.LabelFile2.AutoSize = true;
            this.LabelFile2.Font = new System.Drawing.Font("Tahoma", 14F);
            this.LabelFile2.Location = new System.Drawing.Point(625, 30);
            this.LabelFile2.Name = "LabelFile2";
            this.LabelFile2.Size = new System.Drawing.Size(371, 23);
            this.LabelFile2.TabIndex = 30;
            this.LabelFile2.Text = "Archivo de Excel con los datos de usuarios:";
            this.LabelFile2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ButtonFile
            // 
            this.ButtonFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonFile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonFile.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.ButtonFile.Location = new System.Drawing.Point(431, 27);
            this.ButtonFile.Name = "ButtonFile";
            this.ButtonFile.Size = new System.Drawing.Size(188, 31);
            this.ButtonFile.TabIndex = 29;
            this.ButtonFile.Text = "Buscar";
            this.ButtonFile.UseVisualStyleBackColor = true;
            this.ButtonFile.Click += new System.EventHandler(this.EventoClick);
            // 
            // LabelFile
            // 
            this.LabelFile.AutoSize = true;
            this.LabelFile.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelFile.Location = new System.Drawing.Point(9, 28);
            this.LabelFile.Name = "LabelFile";
            this.LabelFile.Size = new System.Drawing.Size(416, 25);
            this.LabelFile.TabIndex = 21;
            this.LabelFile.Text = "Archivo de Excel con los datos de usuarios:";
            this.LabelFile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ButtonImportUsers);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(889, 143);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(248, 361);
            this.panel1.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14F);
            this.label1.Location = new System.Drawing.Point(45, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 69);
            this.label1.TabIndex = 31;
            this.label1.Text = "Asegurate de que\r\nlos datos estan\r\ncorrectos";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ButtonImportUsers
            // 
            this.ButtonImportUsers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonImportUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonImportUsers.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonImportUsers.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.ButtonImportUsers.Location = new System.Drawing.Point(30, 3);
            this.ButtonImportUsers.Name = "ButtonImportUsers";
            this.ButtonImportUsers.Size = new System.Drawing.Size(188, 64);
            this.ButtonImportUsers.TabIndex = 30;
            this.ButtonImportUsers.Text = "Iniciar Importación\r\nDe Usuarios";
            this.ButtonImportUsers.UseVisualStyleBackColor = true;
            this.ButtonImportUsers.Click += new System.EventHandler(this.EventoClick);
            // 
            // ImportUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 507);
            this.Controls.Add(this.TablePanelImportUsers);
            this.Name = "ImportUsers";
            this.Text = "ImportUsers";
            this.TablePanelImportUsers.ResumeLayout(false);
            this.TablePanelImportUsers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridCSV)).EndInit();
            this.PanelContenido.ResumeLayout(false);
            this.PanelContenido.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TablePanelImportUsers;
        private System.Windows.Forms.Panel PanelContenido;
        private System.Windows.Forms.Label LabelFile;
        private System.Windows.Forms.Button ButtonFile;
        private System.Windows.Forms.Label LabelFile2;
        public System.Windows.Forms.DataGridView GridCSV;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ButtonImportUsers;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label LabelTitle;
    }
}