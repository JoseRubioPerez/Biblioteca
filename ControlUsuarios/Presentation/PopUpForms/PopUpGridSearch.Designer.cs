namespace Presentation.PopUpForms
{
    partial class PopUpGridSearch
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PopUpGridSearch));
            this.GridSearch = new System.Windows.Forms.DataGridView();
            this.LabelTotalResults = new System.Windows.Forms.Label();
            this.LabelResults = new System.Windows.Forms.Label();
            this.ImageListOptions = new System.Windows.Forms.ImageList(this.components);
            this.ButtonCreateReport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PictureIcon)).BeginInit();
            this.PanelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelTitle
            // 
            this.LabelTitle.Size = new System.Drawing.Size(410, 35);
            this.LabelTitle.Text = "Resultados de Búsqueda Realizada";
            // 
            // ButtonAccept
            // 
            this.ButtonAccept.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(32)))));
            this.ButtonAccept.FlatAppearance.BorderSize = 3;
            this.ButtonAccept.Location = new System.Drawing.Point(467, 539);
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(32)))));
            this.ButtonCancel.FlatAppearance.BorderSize = 3;
            this.ButtonCancel.Location = new System.Drawing.Point(594, 539);
            // 
            // PanelContent
            // 
            this.PanelContent.Controls.Add(this.ButtonCreateReport);
            this.PanelContent.Controls.Add(this.LabelTotalResults);
            this.PanelContent.Controls.Add(this.LabelResults);
            this.PanelContent.Controls.Add(this.GridSearch);
            this.PanelContent.Size = new System.Drawing.Size(1187, 610);
            this.PanelContent.Controls.SetChildIndex(this.GridSearch, 0);
            this.PanelContent.Controls.SetChildIndex(this.LabelResults, 0);
            this.PanelContent.Controls.SetChildIndex(this.LabelTotalResults, 0);
            this.PanelContent.Controls.SetChildIndex(this.LabelComboSearch, 0);
            this.PanelContent.Controls.SetChildIndex(this.ButtonAccept, 0);
            this.PanelContent.Controls.SetChildIndex(this.PanelBorder1, 0);
            this.PanelContent.Controls.SetChildIndex(this.ButtonCancel, 0);
            this.PanelContent.Controls.SetChildIndex(this.ButtonCreateReport, 0);
            // 
            // GridSearch
            // 
            this.GridSearch.AllowUserToAddRows = false;
            this.GridSearch.AllowUserToDeleteRows = false;
            this.GridSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridSearch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
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
            this.GridSearch.Location = new System.Drawing.Point(9, 99);
            this.GridSearch.Margin = new System.Windows.Forms.Padding(0);
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
            this.GridSearch.Size = new System.Drawing.Size(1166, 415);
            this.GridSearch.TabIndex = 10;
            // 
            // LabelTotalResults
            // 
            this.LabelTotalResults.AutoSize = true;
            this.LabelTotalResults.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTotalResults.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(32)))));
            this.LabelTotalResults.Location = new System.Drawing.Point(813, 36);
            this.LabelTotalResults.Name = "LabelTotalResults";
            this.LabelTotalResults.Size = new System.Drawing.Size(25, 27);
            this.LabelTotalResults.TabIndex = 12;
            this.LabelTotalResults.Text = "0";
            // 
            // LabelResults
            // 
            this.LabelResults.AutoSize = true;
            this.LabelResults.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.LabelResults.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(32)))));
            this.LabelResults.Location = new System.Drawing.Point(715, 40);
            this.LabelResults.Name = "LabelResults";
            this.LabelResults.Size = new System.Drawing.Size(92, 23);
            this.LabelResults.TabIndex = 11;
            this.LabelResults.Text = "Resultados:";
            // 
            // ImageListOptions
            // 
            this.ImageListOptions.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageListOptions.ImageStream")));
            this.ImageListOptions.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageListOptions.Images.SetKeyName(0, "ReportBlack.png");
            this.ImageListOptions.Images.SetKeyName(1, "SearchBlack.png");
            // 
            // ButtonCreateReport
            // 
            this.ButtonCreateReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonCreateReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonCreateReport.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(32)))));
            this.ButtonCreateReport.FlatAppearance.BorderSize = 3;
            this.ButtonCreateReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonCreateReport.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.ButtonCreateReport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(32)))));
            this.ButtonCreateReport.ImageKey = "ReportBlack.png";
            this.ButtonCreateReport.ImageList = this.ImageListOptions;
            this.ButtonCreateReport.Location = new System.Drawing.Point(736, 539);
            this.ButtonCreateReport.Name = "ButtonCreateReport";
            this.ButtonCreateReport.Size = new System.Drawing.Size(439, 47);
            this.ButtonCreateReport.TabIndex = 13;
            this.ButtonCreateReport.Text = "Generar reporte a partir de la búsqueda realizada";
            this.ButtonCreateReport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonCreateReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonCreateReport.UseVisualStyleBackColor = true;
            this.ButtonCreateReport.Click += new System.EventHandler(this.ButtonCreateReport_Click);
            // 
            // PopUpGridSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 692);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.Name = "PopUpGridSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PopUpGridSearch";
            ((System.ComponentModel.ISupportInitialize)(this.PictureIcon)).EndInit();
            this.PanelContent.ResumeLayout(false);
            this.PanelContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridSearch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView GridSearch;
        private System.Windows.Forms.Label LabelTotalResults;
        private System.Windows.Forms.Label LabelResults;
        private System.Windows.Forms.ImageList ImageListOptions;
        private System.Windows.Forms.Button ButtonCreateReport;
    }
}