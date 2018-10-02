namespace Presentation.Inputs
{
    partial class GridViewUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GridViewUI));
            this.GridSearchUI = new System.Windows.Forms.DataGridView();
            this.ButtonCleanSearch = new System.Windows.Forms.Button();
            this.ComboTypeSearch = new System.Windows.Forms.ComboBox();
            this.LabelResults = new System.Windows.Forms.Label();
            this.LabelComboSearch = new System.Windows.Forms.Label();
            this.LabelTotalResults = new System.Windows.Forms.Label();
            this.ButtonSearch = new System.Windows.Forms.Button();
            this.TableLayoutPanelUI = new System.Windows.Forms.TableLayoutPanel();
            this.PanelSearch = new System.Windows.Forms.Panel();
            this.TextBoxSearch = new Presentation.Inputs.TextBoxUI();
            this.PanelComboUI = new System.Windows.Forms.Panel();
            this.PanelResults = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.GridSearchUI)).BeginInit();
            this.TableLayoutPanelUI.SuspendLayout();
            this.PanelSearch.SuspendLayout();
            this.PanelComboUI.SuspendLayout();
            this.PanelResults.SuspendLayout();
            this.SuspendLayout();
            // 
            // GridSearchUI
            // 
            this.GridSearchUI.AllowUserToAddRows = false;
            this.GridSearchUI.AllowUserToDeleteRows = false;
            this.GridSearchUI.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(205)))), ((int)(((byte)(203)))));
            this.GridSearchUI.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridSearchUI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableLayoutPanelUI.SetColumnSpan(this.GridSearchUI, 2);
            this.GridSearchUI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridSearchUI.Location = new System.Drawing.Point(0, 210);
            this.GridSearchUI.Margin = new System.Windows.Forms.Padding(0);
            this.GridSearchUI.Name = "GridSearchUI";
            this.GridSearchUI.ReadOnly = true;
            this.GridSearchUI.Size = new System.Drawing.Size(1062, 315);
            this.GridSearchUI.TabIndex = 0;
            this.GridSearchUI.DataSourceChanged += new System.EventHandler(this.DataSourceChangedMethod);
            // 
            // ButtonCleanSearch
            // 
            this.ButtonCleanSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonCleanSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonCleanSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonCleanSearch.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.ButtonCleanSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(32)))));
            this.ButtonCleanSearch.Location = new System.Drawing.Point(910, 3);
            this.ButtonCleanSearch.Name = "ButtonCleanSearch";
            this.ButtonCleanSearch.Size = new System.Drawing.Size(149, 36);
            this.ButtonCleanSearch.TabIndex = 10;
            this.ButtonCleanSearch.TabStop = false;
            this.ButtonCleanSearch.Text = "Limpiar Búsqueda";
            this.ButtonCleanSearch.UseVisualStyleBackColor = true;
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
            this.ComboTypeSearch.Items.AddRange(new object[] {
            "Ninguno"});
            this.ComboTypeSearch.Location = new System.Drawing.Point(154, 64);
            this.ComboTypeSearch.Name = "ComboTypeSearch";
            this.ComboTypeSearch.Size = new System.Drawing.Size(344, 28);
            this.ComboTypeSearch.TabIndex = 1;
            this.ComboTypeSearch.Click += new System.EventHandler(this.ComboTypeSearchClickMethod);
            // 
            // LabelResults
            // 
            this.LabelResults.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LabelResults.AutoSize = true;
            this.LabelResults.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.LabelResults.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(32)))));
            this.LabelResults.Location = new System.Drawing.Point(16, 75);
            this.LabelResults.Name = "LabelResults";
            this.LabelResults.Size = new System.Drawing.Size(92, 23);
            this.LabelResults.TabIndex = 4;
            this.LabelResults.Text = "Resultados:";
            // 
            // LabelComboSearch
            // 
            this.LabelComboSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LabelComboSearch.AutoSize = true;
            this.LabelComboSearch.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.LabelComboSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(32)))));
            this.LabelComboSearch.Location = new System.Drawing.Point(3, 69);
            this.LabelComboSearch.Name = "LabelComboSearch";
            this.LabelComboSearch.Size = new System.Drawing.Size(145, 23);
            this.LabelComboSearch.TabIndex = 5;
            this.LabelComboSearch.Text = "Filtro de Búsqueda:";
            // 
            // LabelTotalResults
            // 
            this.LabelTotalResults.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LabelTotalResults.AutoSize = true;
            this.LabelTotalResults.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTotalResults.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(32)))));
            this.LabelTotalResults.Location = new System.Drawing.Point(114, 71);
            this.LabelTotalResults.Name = "LabelTotalResults";
            this.LabelTotalResults.Size = new System.Drawing.Size(25, 27);
            this.LabelTotalResults.TabIndex = 6;
            this.LabelTotalResults.Text = "0";
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
            this.ButtonSearch.Location = new System.Drawing.Point(696, 69);
            this.ButtonSearch.Name = "ButtonSearch";
            this.ButtonSearch.Size = new System.Drawing.Size(32, 32);
            this.ButtonSearch.TabIndex = 3;
            this.ButtonSearch.UseVisualStyleBackColor = true;
            this.ButtonSearch.Click += new System.EventHandler(this.SearchClickMethod);
            // 
            // TableLayoutPanelUI
            // 
            this.TableLayoutPanelUI.ColumnCount = 2;
            this.TableLayoutPanelUI.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.TableLayoutPanelUI.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.TableLayoutPanelUI.Controls.Add(this.PanelSearch, 0, 1);
            this.TableLayoutPanelUI.Controls.Add(this.GridSearchUI, 0, 2);
            this.TableLayoutPanelUI.Controls.Add(this.PanelComboUI, 0, 0);
            this.TableLayoutPanelUI.Controls.Add(this.PanelResults, 1, 1);
            this.TableLayoutPanelUI.Controls.Add(this.ButtonCleanSearch, 1, 0);
            this.TableLayoutPanelUI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanelUI.Location = new System.Drawing.Point(0, 0);
            this.TableLayoutPanelUI.Name = "TableLayoutPanelUI";
            this.TableLayoutPanelUI.RowCount = 3;
            this.TableLayoutPanelUI.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TableLayoutPanelUI.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TableLayoutPanelUI.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.TableLayoutPanelUI.Size = new System.Drawing.Size(1062, 525);
            this.TableLayoutPanelUI.TabIndex = 11;
            // 
            // PanelSearch
            // 
            this.PanelSearch.Controls.Add(this.TextBoxSearch);
            this.PanelSearch.Controls.Add(this.ButtonSearch);
            this.PanelSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelSearch.Location = new System.Drawing.Point(0, 105);
            this.PanelSearch.Margin = new System.Windows.Forms.Padding(0);
            this.PanelSearch.Name = "PanelSearch";
            this.PanelSearch.Size = new System.Drawing.Size(743, 105);
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
            this.TextBoxSearch.Location = new System.Drawing.Point(3, 65);
            this.TextBoxSearch.MaxLengthTextBox = 32767;
            this.TextBoxSearch.Name = "TextBoxSearch";
            this.TextBoxSearch.PasswordTextBox = '\0';
            this.TextBoxSearch.SelectionLengthTextBox = 0;
            this.TextBoxSearch.SelectionStartTextBox = 0;
            this.TextBoxSearch.Size = new System.Drawing.Size(687, 36);
            this.TextBoxSearch.TabIndex = 2;
            this.TextBoxSearch.TextLabel = "Change my text";
            this.TextBoxSearch.TextTextBox = "";
            // 
            // PanelComboUI
            // 
            this.PanelComboUI.Controls.Add(this.LabelComboSearch);
            this.PanelComboUI.Controls.Add(this.ComboTypeSearch);
            this.PanelComboUI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelComboUI.Location = new System.Drawing.Point(0, 0);
            this.PanelComboUI.Margin = new System.Windows.Forms.Padding(0);
            this.PanelComboUI.Name = "PanelComboUI";
            this.PanelComboUI.Size = new System.Drawing.Size(743, 105);
            this.PanelComboUI.TabIndex = 12;
            // 
            // PanelResults
            // 
            this.PanelResults.Controls.Add(this.LabelTotalResults);
            this.PanelResults.Controls.Add(this.LabelResults);
            this.PanelResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelResults.Location = new System.Drawing.Point(743, 105);
            this.PanelResults.Margin = new System.Windows.Forms.Padding(0);
            this.PanelResults.Name = "PanelResults";
            this.PanelResults.Size = new System.Drawing.Size(319, 105);
            this.PanelResults.TabIndex = 12;
            // 
            // GridViewUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(205)))), ((int)(((byte)(203)))));
            this.Controls.Add(this.TableLayoutPanelUI);
            this.Name = "GridViewUI";
            this.Size = new System.Drawing.Size(1062, 525);
            ((System.ComponentModel.ISupportInitialize)(this.GridSearchUI)).EndInit();
            this.TableLayoutPanelUI.ResumeLayout(false);
            this.PanelSearch.ResumeLayout(false);
            this.PanelComboUI.ResumeLayout(false);
            this.PanelComboUI.PerformLayout();
            this.PanelResults.ResumeLayout(false);
            this.PanelResults.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label LabelResults;
        private System.Windows.Forms.Label LabelComboSearch;
        private System.Windows.Forms.Label LabelTotalResults;
        private System.Windows.Forms.Button ButtonSearch;
        public System.Windows.Forms.DataGridView GridSearchUI;
        public System.Windows.Forms.Button ButtonCleanSearch;
        public System.Windows.Forms.ComboBox ComboTypeSearch;
        public TextBoxUI TextBoxSearch;
        private System.Windows.Forms.Panel PanelResults;
        private System.Windows.Forms.Panel PanelComboUI;
        private System.Windows.Forms.Panel PanelSearch;
        public System.Windows.Forms.TableLayoutPanel TableLayoutPanelUI;
    }
}
