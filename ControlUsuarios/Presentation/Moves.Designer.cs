namespace Presentation
{
    partial class Moves
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Moves));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TableLayoutPanelContent = new System.Windows.Forms.TableLayoutPanel();
            this.TableLayoutPanelGrid = new System.Windows.Forms.TableLayoutPanel();
            this.PanelSearch = new System.Windows.Forms.Panel();
            this.TextBoxSearch = new Presentation.Inputs.TextBoxUI();
            this.ButtonSearch = new System.Windows.Forms.Button();
            this.GridSearch = new System.Windows.Forms.DataGridView();
            this.PanelResults = new System.Windows.Forms.Panel();
            this.LabelTotalResults = new System.Windows.Forms.Label();
            this.LabelResults = new System.Windows.Forms.Label();
            this.PanelFilter = new System.Windows.Forms.Panel();
            this.ButtonCleanSearch = new System.Windows.Forms.Button();
            this.LabelComboSearch = new System.Windows.Forms.Label();
            this.ComboTypeSearch = new System.Windows.Forms.ComboBox();
            this.ButtonCreateReport = new System.Windows.Forms.Button();
            this.ImageListOptions = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxInfo)).BeginInit();
            this.PanelInfo.SuspendLayout();
            this.TableLayoutPanelContent.SuspendLayout();
            this.TableLayoutPanelGrid.SuspendLayout();
            this.PanelSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridSearch)).BeginInit();
            this.PanelResults.SuspendLayout();
            this.PanelFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // PictureBoxInfo
            // 
            this.PictureBoxInfo.Location = new System.Drawing.Point(1006, 12);
            this.ToolTipInfo.SetToolTip(this.PictureBoxInfo, "Información sobre esta ventana");
            this.PictureBoxInfo.Click += new System.EventHandler(this.ControlClickMethod);
            // 
            // PanelInfo
            // 
            this.PanelInfo.Size = new System.Drawing.Size(1062, 68);
            // 
            // LabelSubTitle
            // 
            this.LabelSubTitle.Location = new System.Drawing.Point(300, 30);
            this.LabelSubTitle.Size = new System.Drawing.Size(595, 26);
            this.LabelSubTitle.Text = "Movimientos realizados por los usuarios dentro del centro de información";
            // 
            // LabelTitle
            // 
            this.LabelTitle.Size = new System.Drawing.Size(282, 35);
            this.LabelTitle.Text = "Modulo de  Movimientos";
            // 
            // TableLayoutPanelContent
            // 
            this.TableLayoutPanelContent.ColumnCount = 1;
            this.TableLayoutPanelContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanelContent.Controls.Add(this.TableLayoutPanelGrid, 0, 1);
            this.TableLayoutPanelContent.Controls.Add(this.PanelFilter, 0, 0);
            this.TableLayoutPanelContent.Controls.Add(this.ButtonCreateReport, 0, 2);
            this.TableLayoutPanelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanelContent.Location = new System.Drawing.Point(0, 68);
            this.TableLayoutPanelContent.Name = "TableLayoutPanelContent";
            this.TableLayoutPanelContent.RowCount = 3;
            this.TableLayoutPanelContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.TableLayoutPanelContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.TableLayoutPanelContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TableLayoutPanelContent.Size = new System.Drawing.Size(1062, 630);
            this.TableLayoutPanelContent.TabIndex = 1;
            // 
            // TableLayoutPanelGrid
            // 
            this.TableLayoutPanelGrid.ColumnCount = 2;
            this.TableLayoutPanelGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.TableLayoutPanelGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.TableLayoutPanelGrid.Controls.Add(this.PanelSearch, 0, 0);
            this.TableLayoutPanelGrid.Controls.Add(this.GridSearch, 0, 1);
            this.TableLayoutPanelGrid.Controls.Add(this.PanelResults, 1, 0);
            this.TableLayoutPanelGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanelGrid.Location = new System.Drawing.Point(3, 97);
            this.TableLayoutPanelGrid.Name = "TableLayoutPanelGrid";
            this.TableLayoutPanelGrid.RowCount = 3;
            this.TableLayoutPanelGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TableLayoutPanelGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TableLayoutPanelGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.TableLayoutPanelGrid.Size = new System.Drawing.Size(1056, 466);
            this.TableLayoutPanelGrid.TabIndex = 13;
            // 
            // PanelSearch
            // 
            this.PanelSearch.Controls.Add(this.TextBoxSearch);
            this.PanelSearch.Controls.Add(this.ButtonSearch);
            this.PanelSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelSearch.Location = new System.Drawing.Point(0, 0);
            this.PanelSearch.Margin = new System.Windows.Forms.Padding(0);
            this.PanelSearch.Name = "PanelSearch";
            this.PanelSearch.Size = new System.Drawing.Size(739, 93);
            this.PanelSearch.TabIndex = 12;
            // 
            // TextBoxSearch
            // 
            this.TextBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(205)))), ((int)(((byte)(203)))));
            this.TextBoxSearch.BackColorLabel = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(205)))), ((int)(((byte)(203)))));
            this.TextBoxSearch.BackColorPanel = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(32)))));
            this.TextBoxSearch.BackColorTextBox = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(205)))), ((int)(((byte)(203)))));
            this.TextBoxSearch.EnableTextBox = true;
            this.TextBoxSearch.ForeColorLabel = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(32)))));
            this.TextBoxSearch.ForeColorTextBox = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(32)))));
            this.TextBoxSearch.Location = new System.Drawing.Point(3, 53);
            this.TextBoxSearch.MaxLengthTextBox = 32767;
            this.TextBoxSearch.Name = "TextBoxSearch";
            this.TextBoxSearch.PasswordTextBox = '\0';
            this.TextBoxSearch.SelectionLengthTextBox = 0;
            this.TextBoxSearch.SelectionStartTextBox = 0;
            this.TextBoxSearch.Size = new System.Drawing.Size(683, 36);
            this.TextBoxSearch.TabIndex = 2;
            this.TextBoxSearch.TextLabel = "Change my text";
            this.TextBoxSearch.TextTextBox = "";
            // 
            // ButtonSearch
            // 
            this.ButtonSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonSearch.FlatAppearance.BorderSize = 0;
            this.ButtonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSearch.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.ButtonSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(32)))));
            this.ButtonSearch.Image = ((System.Drawing.Image)(resources.GetObject("ButtonSearch.Image")));
            this.ButtonSearch.Location = new System.Drawing.Point(692, 57);
            this.ButtonSearch.Name = "ButtonSearch";
            this.ButtonSearch.Size = new System.Drawing.Size(32, 32);
            this.ButtonSearch.TabIndex = 3;
            this.ButtonSearch.UseVisualStyleBackColor = true;
            this.ButtonSearch.Click += new System.EventHandler(this.ControlClickMethod);
            // 
            // GridSearch
            // 
            this.GridSearch.AllowUserToAddRows = false;
            this.GridSearch.AllowUserToDeleteRows = false;
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
            this.TableLayoutPanelGrid.SetColumnSpan(this.GridSearch, 2);
            this.GridSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridSearch.EnableHeadersVisualStyles = false;
            this.GridSearch.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(32)))));
            this.GridSearch.Location = new System.Drawing.Point(0, 93);
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
            this.TableLayoutPanelGrid.SetRowSpan(this.GridSearch, 2);
            this.GridSearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridSearch.Size = new System.Drawing.Size(1056, 373);
            this.GridSearch.TabIndex = 0;
            // 
            // PanelResults
            // 
            this.PanelResults.Controls.Add(this.LabelTotalResults);
            this.PanelResults.Controls.Add(this.LabelResults);
            this.PanelResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelResults.Location = new System.Drawing.Point(739, 0);
            this.PanelResults.Margin = new System.Windows.Forms.Padding(0);
            this.PanelResults.Name = "PanelResults";
            this.PanelResults.Size = new System.Drawing.Size(317, 93);
            this.PanelResults.TabIndex = 12;
            // 
            // LabelTotalResults
            // 
            this.LabelTotalResults.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LabelTotalResults.AutoSize = true;
            this.LabelTotalResults.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTotalResults.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(32)))));
            this.LabelTotalResults.Location = new System.Drawing.Point(114, 59);
            this.LabelTotalResults.Name = "LabelTotalResults";
            this.LabelTotalResults.Size = new System.Drawing.Size(25, 27);
            this.LabelTotalResults.TabIndex = 6;
            this.LabelTotalResults.Text = "0";
            // 
            // LabelResults
            // 
            this.LabelResults.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LabelResults.AutoSize = true;
            this.LabelResults.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.LabelResults.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(32)))));
            this.LabelResults.Location = new System.Drawing.Point(16, 63);
            this.LabelResults.Name = "LabelResults";
            this.LabelResults.Size = new System.Drawing.Size(92, 23);
            this.LabelResults.TabIndex = 4;
            this.LabelResults.Text = "Resultados:";
            // 
            // PanelFilter
            // 
            this.PanelFilter.Controls.Add(this.ButtonCleanSearch);
            this.PanelFilter.Controls.Add(this.LabelComboSearch);
            this.PanelFilter.Controls.Add(this.ComboTypeSearch);
            this.PanelFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelFilter.Location = new System.Drawing.Point(0, 0);
            this.PanelFilter.Margin = new System.Windows.Forms.Padding(0);
            this.PanelFilter.Name = "PanelFilter";
            this.PanelFilter.Size = new System.Drawing.Size(1062, 94);
            this.PanelFilter.TabIndex = 0;
            // 
            // ButtonCleanSearch
            // 
            this.ButtonCleanSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonCleanSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonCleanSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonCleanSearch.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.ButtonCleanSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(32)))));
            this.ButtonCleanSearch.Location = new System.Drawing.Point(901, 48);
            this.ButtonCleanSearch.Name = "ButtonCleanSearch";
            this.ButtonCleanSearch.Size = new System.Drawing.Size(149, 36);
            this.ButtonCleanSearch.TabIndex = 11;
            this.ButtonCleanSearch.TabStop = false;
            this.ButtonCleanSearch.Text = "Limpiar Búsqueda";
            this.ButtonCleanSearch.UseVisualStyleBackColor = true;
            this.ButtonCleanSearch.Click += new System.EventHandler(this.ControlClickMethod);
            // 
            // LabelComboSearch
            // 
            this.LabelComboSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LabelComboSearch.AutoSize = true;
            this.LabelComboSearch.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.LabelComboSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(32)))));
            this.LabelComboSearch.Location = new System.Drawing.Point(14, 48);
            this.LabelComboSearch.Name = "LabelComboSearch";
            this.LabelComboSearch.Size = new System.Drawing.Size(145, 23);
            this.LabelComboSearch.TabIndex = 7;
            this.LabelComboSearch.Text = "Filtro de Búsqueda:";
            // 
            // ComboTypeSearch
            // 
            this.ComboTypeSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ComboTypeSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ComboTypeSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboTypeSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ComboTypeSearch.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.ComboTypeSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(32)))));
            this.ComboTypeSearch.FormattingEnabled = true;
            this.ComboTypeSearch.Location = new System.Drawing.Point(165, 43);
            this.ComboTypeSearch.Name = "ComboTypeSearch";
            this.ComboTypeSearch.Size = new System.Drawing.Size(344, 28);
            this.ComboTypeSearch.TabIndex = 6;
            // 
            // ButtonCreateReport
            // 
            this.ButtonCreateReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonCreateReport.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(32)))));
            this.ButtonCreateReport.FlatAppearance.BorderSize = 3;
            this.ButtonCreateReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonCreateReport.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.ButtonCreateReport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(32)))));
            this.ButtonCreateReport.ImageKey = "ReportBlack.png";
            this.ButtonCreateReport.ImageList = this.ImageListOptions;
            this.ButtonCreateReport.Location = new System.Drawing.Point(3, 569);
            this.ButtonCreateReport.Name = "ButtonCreateReport";
            this.ButtonCreateReport.Size = new System.Drawing.Size(1056, 58);
            this.ButtonCreateReport.TabIndex = 1;
            this.ButtonCreateReport.Text = "Generar reporte a partir de la búsqueda realizada";
            this.ButtonCreateReport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonCreateReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonCreateReport.UseVisualStyleBackColor = true;
            this.ButtonCreateReport.Click += new System.EventHandler(this.ControlClickMethod);
            // 
            // ImageListOptions
            // 
            this.ImageListOptions.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageListOptions.ImageStream")));
            this.ImageListOptions.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageListOptions.Images.SetKeyName(0, "ReportBlack.png");
            // 
            // Moves
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 698);
            this.Controls.Add(this.TableLayoutPanelContent);
            this.Name = "Moves";
            this.Text = "Moves";
            this.Load += new System.EventHandler(this.MovesLoadMethod);
            this.Controls.SetChildIndex(this.PanelInfo, 0);
            this.Controls.SetChildIndex(this.TableLayoutPanelContent, 0);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxInfo)).EndInit();
            this.PanelInfo.ResumeLayout(false);
            this.PanelInfo.PerformLayout();
            this.TableLayoutPanelContent.ResumeLayout(false);
            this.TableLayoutPanelGrid.ResumeLayout(false);
            this.PanelSearch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridSearch)).EndInit();
            this.PanelResults.ResumeLayout(false);
            this.PanelResults.PerformLayout();
            this.PanelFilter.ResumeLayout(false);
            this.PanelFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TableLayoutPanelContent;
        private System.Windows.Forms.Panel PanelFilter;
        private System.Windows.Forms.Label LabelComboSearch;
        public System.Windows.Forms.ComboBox ComboTypeSearch;
        private System.Windows.Forms.Button ButtonCreateReport;
        private System.Windows.Forms.ImageList ImageListOptions;
        public System.Windows.Forms.Button ButtonCleanSearch;
        public System.Windows.Forms.TableLayoutPanel TableLayoutPanelGrid;
        private System.Windows.Forms.Panel PanelSearch;
        public Inputs.TextBoxUI TextBoxSearch;
        private System.Windows.Forms.Button ButtonSearch;
        public System.Windows.Forms.DataGridView GridSearch;
        private System.Windows.Forms.Panel PanelResults;
        private System.Windows.Forms.Label LabelTotalResults;
        private System.Windows.Forms.Label LabelResults;
    }
}