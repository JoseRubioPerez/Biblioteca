namespace Presentation
{
    partial class Imports
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LabelComboSearch = new System.Windows.Forms.Label();
            this.ButtonExamine = new System.Windows.Forms.Button();
            this.GridSearch = new System.Windows.Forms.DataGridView();
            this.ButtonImportTable = new System.Windows.Forms.Button();
            this.LabelTotal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxInfo)).BeginInit();
            this.PanelInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBoxInfo
            // 
            this.PictureBoxInfo.Location = new System.Drawing.Point(1006, 12);
            this.ToolTipInfo.SetToolTip(this.PictureBoxInfo, "Información sobre esta ventana");
            // 
            // PanelInfo
            // 
            this.PanelInfo.Size = new System.Drawing.Size(1062, 68);
            // 
            // LabelSubTitle
            // 
            this.LabelSubTitle.Location = new System.Drawing.Point(285, 30);
            this.LabelSubTitle.Size = new System.Drawing.Size(429, 26);
            this.LabelSubTitle.Text = "Agrega nuevos usuarios de forma masiva al sistema";
            // 
            // LabelTitle
            // 
            this.LabelTitle.Size = new System.Drawing.Size(267, 35);
            this.LabelTitle.Text = "Modulo de Importación";
            // 
            // LabelComboSearch
            // 
            this.LabelComboSearch.AutoSize = true;
            this.LabelComboSearch.Font = new System.Drawing.Font("Arial Narrow", 16F);
            this.LabelComboSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(32)))));
            this.LabelComboSearch.Location = new System.Drawing.Point(13, 113);
            this.LabelComboSearch.Name = "LabelComboSearch";
            this.LabelComboSearch.Size = new System.Drawing.Size(273, 26);
            this.LabelComboSearch.TabIndex = 6;
            this.LabelComboSearch.Text = "Seleccione el archivo a importar:";
            // 
            // ButtonExamine
            // 
            this.ButtonExamine.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.ButtonExamine.Location = new System.Drawing.Point(292, 108);
            this.ButtonExamine.Name = "ButtonExamine";
            this.ButtonExamine.Size = new System.Drawing.Size(148, 31);
            this.ButtonExamine.TabIndex = 7;
            this.ButtonExamine.Text = "Examinar...";
            this.ButtonExamine.UseVisualStyleBackColor = true;
            this.ButtonExamine.Click += new System.EventHandler(this.ControlClickMethod);
            // 
            // GridSearch
            // 
            this.GridSearch.AllowUserToAddRows = false;
            this.GridSearch.AllowUserToDeleteRows = false;
            this.GridSearch.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.GridSearch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridSearch.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.GridSearch.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(205)))), ((int)(((byte)(203)))));
            this.GridSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridSearch.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.GridSearch.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial Narrow", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridSearch.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.GridSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridSearch.EnableHeadersVisualStyles = false;
            this.GridSearch.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(32)))));
            this.GridSearch.Location = new System.Drawing.Point(11, 324);
            this.GridSearch.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.GridSearch.Name = "GridSearch";
            this.GridSearch.ReadOnly = true;
            this.GridSearch.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(205)))), ((int)(((byte)(203)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial Narrow", 12F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(32)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridSearch.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.GridSearch.RowHeadersVisible = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(205)))), ((int)(((byte)(203)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial Narrow", 12F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(32)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(71)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.GridSearch.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.GridSearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridSearch.Size = new System.Drawing.Size(1039, 365);
            this.GridSearch.TabIndex = 11;
            // 
            // ButtonImportTable
            // 
            this.ButtonImportTable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonImportTable.Enabled = false;
            this.ButtonImportTable.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.ButtonImportTable.Location = new System.Drawing.Point(908, 107);
            this.ButtonImportTable.Name = "ButtonImportTable";
            this.ButtonImportTable.Size = new System.Drawing.Size(142, 31);
            this.ButtonImportTable.TabIndex = 10;
            this.ButtonImportTable.Text = "Importar";
            this.ButtonImportTable.UseVisualStyleBackColor = true;
            this.ButtonImportTable.Click += new System.EventHandler(this.ControlClickMethod);
            // 
            // LabelTotal
            // 
            this.LabelTotal.AutoSize = true;
            this.LabelTotal.Font = new System.Drawing.Font("Arial Narrow", 16F);
            this.LabelTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(32)))));
            this.LabelTotal.Location = new System.Drawing.Point(191, 286);
            this.LabelTotal.Name = "LabelTotal";
            this.LabelTotal.Size = new System.Drawing.Size(22, 26);
            this.LabelTotal.TabIndex = 12;
            this.LabelTotal.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 16F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(32)))));
            this.label2.Location = new System.Drawing.Point(12, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 26);
            this.label2.TabIndex = 13;
            this.label2.Text = "Total de Registros:";
            // 
            // Imports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 698);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LabelTotal);
            this.Controls.Add(this.ButtonImportTable);
            this.Controls.Add(this.GridSearch);
            this.Controls.Add(this.ButtonExamine);
            this.Controls.Add(this.LabelComboSearch);
            this.Name = "Imports";
            this.Text = "Imports";
            this.Controls.SetChildIndex(this.LabelComboSearch, 0);
            this.Controls.SetChildIndex(this.ButtonExamine, 0);
            this.Controls.SetChildIndex(this.GridSearch, 0);
            this.Controls.SetChildIndex(this.PanelInfo, 0);
            this.Controls.SetChildIndex(this.ButtonImportTable, 0);
            this.Controls.SetChildIndex(this.LabelTotal, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxInfo)).EndInit();
            this.PanelInfo.ResumeLayout(false);
            this.PanelInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelComboSearch;
        private System.Windows.Forms.Button ButtonExamine;
        public System.Windows.Forms.DataGridView GridSearch;
        private System.Windows.Forms.Button ButtonImportTable;
        private System.Windows.Forms.Label LabelTotal;
        private System.Windows.Forms.Label label2;
    }
}