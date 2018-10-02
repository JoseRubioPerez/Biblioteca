namespace Presentation
{
    partial class Users
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Users));
            this.TableLayoutPanelContent = new System.Windows.Forms.TableLayoutPanel();
            this.TableLayoutPanelGrid = new System.Windows.Forms.TableLayoutPanel();
            this.PanelSearch = new System.Windows.Forms.Panel();
            this.TextBoxSearch = new Presentation.Inputs.TextBoxUI();
            this.ButtonSearch = new System.Windows.Forms.Button();
            this.GridSearch = new System.Windows.Forms.DataGridView();
            this.PanelComboUI = new System.Windows.Forms.Panel();
            this.LabelComboSearch = new System.Windows.Forms.Label();
            this.ComboTypeSearch = new System.Windows.Forms.ComboBox();
            this.PanelResults = new System.Windows.Forms.Panel();
            this.LabelTotalResults = new System.Windows.Forms.Label();
            this.LabelResults = new System.Windows.Forms.Label();
            this.ButtonCleanSearch = new System.Windows.Forms.Button();
            this.PanelButtonOptiosn = new System.Windows.Forms.Panel();
            this.ButtonNewUser = new System.Windows.Forms.Button();
            this.ImageListOptions = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxInfo)).BeginInit();
            this.PanelInfo.SuspendLayout();
            this.TableLayoutPanelContent.SuspendLayout();
            this.TableLayoutPanelGrid.SuspendLayout();
            this.PanelSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridSearch)).BeginInit();
            this.PanelComboUI.SuspendLayout();
            this.PanelResults.SuspendLayout();
            this.PanelButtonOptiosn.SuspendLayout();
            this.SuspendLayout();
            // 
            // PictureBoxInfo
            // 
            this.PictureBoxInfo.Location = new System.Drawing.Point(1008, 12);
            this.ToolTipInfo.SetToolTip(this.PictureBoxInfo, "Información sobre esta ventana: Usuarios");
            this.PictureBoxInfo.Click += new System.EventHandler(this.ControlClickMethod);
            // 
            // PanelInfo
            // 
            this.PanelInfo.Margin = new System.Windows.Forms.Padding(0);
            this.PanelInfo.Size = new System.Drawing.Size(1062, 68);
            // 
            // TableLayoutPanelContent
            // 
            this.TableLayoutPanelContent.ColumnCount = 1;
            this.TableLayoutPanelContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanelContent.Controls.Add(this.TableLayoutPanelGrid, 0, 1);
            this.TableLayoutPanelContent.Controls.Add(this.PanelButtonOptiosn, 0, 0);
            this.TableLayoutPanelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanelContent.Location = new System.Drawing.Point(0, 68);
            this.TableLayoutPanelContent.Margin = new System.Windows.Forms.Padding(0);
            this.TableLayoutPanelContent.Name = "TableLayoutPanelContent";
            this.TableLayoutPanelContent.RowCount = 2;
            this.TableLayoutPanelContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.TableLayoutPanelContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.TableLayoutPanelContent.Size = new System.Drawing.Size(1062, 630);
            this.TableLayoutPanelContent.TabIndex = 2;
            // 
            // TableLayoutPanelGrid
            // 
            this.TableLayoutPanelGrid.ColumnCount = 2;
            this.TableLayoutPanelGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.TableLayoutPanelGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.TableLayoutPanelGrid.Controls.Add(this.PanelSearch, 0, 1);
            this.TableLayoutPanelGrid.Controls.Add(this.GridSearch, 0, 2);
            this.TableLayoutPanelGrid.Controls.Add(this.PanelComboUI, 0, 0);
            this.TableLayoutPanelGrid.Controls.Add(this.PanelResults, 1, 1);
            this.TableLayoutPanelGrid.Controls.Add(this.ButtonCleanSearch, 1, 0);
            this.TableLayoutPanelGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanelGrid.Location = new System.Drawing.Point(3, 97);
            this.TableLayoutPanelGrid.Name = "TableLayoutPanelGrid";
            this.TableLayoutPanelGrid.RowCount = 3;
            this.TableLayoutPanelGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TableLayoutPanelGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TableLayoutPanelGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.TableLayoutPanelGrid.Size = new System.Drawing.Size(1056, 530);
            this.TableLayoutPanelGrid.TabIndex = 12;
            // 
            // PanelSearch
            // 
            this.PanelSearch.Controls.Add(this.TextBoxSearch);
            this.PanelSearch.Controls.Add(this.ButtonSearch);
            this.PanelSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelSearch.Location = new System.Drawing.Point(0, 106);
            this.PanelSearch.Margin = new System.Windows.Forms.Padding(0);
            this.PanelSearch.Name = "PanelSearch";
            this.PanelSearch.Size = new System.Drawing.Size(739, 106);
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
            this.TextBoxSearch.Location = new System.Drawing.Point(3, 66);
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
            this.ButtonSearch.Location = new System.Drawing.Point(692, 70);
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
            this.GridSearch.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(205)))), ((int)(((byte)(203)))));
            this.GridSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableLayoutPanelGrid.SetColumnSpan(this.GridSearch, 2);
            this.GridSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridSearch.Location = new System.Drawing.Point(0, 212);
            this.GridSearch.Margin = new System.Windows.Forms.Padding(0);
            this.GridSearch.Name = "GridSearch";
            this.GridSearch.ReadOnly = true;
            this.GridSearch.Size = new System.Drawing.Size(1056, 318);
            this.GridSearch.TabIndex = 0;
            this.GridSearch.DataSourceChanged += new System.EventHandler(this.DataSourceChangedMethod);
            // 
            // PanelComboUI
            // 
            this.PanelComboUI.Controls.Add(this.LabelComboSearch);
            this.PanelComboUI.Controls.Add(this.ComboTypeSearch);
            this.PanelComboUI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelComboUI.Location = new System.Drawing.Point(0, 0);
            this.PanelComboUI.Margin = new System.Windows.Forms.Padding(0);
            this.PanelComboUI.Name = "PanelComboUI";
            this.PanelComboUI.Size = new System.Drawing.Size(739, 106);
            this.PanelComboUI.TabIndex = 12;
            // 
            // LabelComboSearch
            // 
            this.LabelComboSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LabelComboSearch.AutoSize = true;
            this.LabelComboSearch.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.LabelComboSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(32)))));
            this.LabelComboSearch.Location = new System.Drawing.Point(3, 70);
            this.LabelComboSearch.Name = "LabelComboSearch";
            this.LabelComboSearch.Size = new System.Drawing.Size(145, 23);
            this.LabelComboSearch.TabIndex = 5;
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
            this.ComboTypeSearch.Items.AddRange(new object[] {
            "Ninguno"});
            this.ComboTypeSearch.Location = new System.Drawing.Point(154, 65);
            this.ComboTypeSearch.Name = "ComboTypeSearch";
            this.ComboTypeSearch.Size = new System.Drawing.Size(344, 28);
            this.ComboTypeSearch.TabIndex = 1;
            this.ComboTypeSearch.Click += new System.EventHandler(this.ComboTypeSearchClickMethod);
            // 
            // PanelResults
            // 
            this.PanelResults.Controls.Add(this.LabelTotalResults);
            this.PanelResults.Controls.Add(this.LabelResults);
            this.PanelResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelResults.Location = new System.Drawing.Point(739, 106);
            this.PanelResults.Margin = new System.Windows.Forms.Padding(0);
            this.PanelResults.Name = "PanelResults";
            this.PanelResults.Size = new System.Drawing.Size(317, 106);
            this.PanelResults.TabIndex = 12;
            // 
            // LabelTotalResults
            // 
            this.LabelTotalResults.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LabelTotalResults.AutoSize = true;
            this.LabelTotalResults.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTotalResults.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(32)))));
            this.LabelTotalResults.Location = new System.Drawing.Point(114, 72);
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
            this.LabelResults.Location = new System.Drawing.Point(16, 76);
            this.LabelResults.Name = "LabelResults";
            this.LabelResults.Size = new System.Drawing.Size(92, 23);
            this.LabelResults.TabIndex = 4;
            this.LabelResults.Text = "Resultados:";
            // 
            // ButtonCleanSearch
            // 
            this.ButtonCleanSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonCleanSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonCleanSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonCleanSearch.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.ButtonCleanSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(32)))));
            this.ButtonCleanSearch.Location = new System.Drawing.Point(904, 3);
            this.ButtonCleanSearch.Name = "ButtonCleanSearch";
            this.ButtonCleanSearch.Size = new System.Drawing.Size(149, 36);
            this.ButtonCleanSearch.TabIndex = 10;
            this.ButtonCleanSearch.TabStop = false;
            this.ButtonCleanSearch.Text = "Limpiar Búsqueda";
            this.ButtonCleanSearch.UseVisualStyleBackColor = true;
            this.ButtonCleanSearch.Click += new System.EventHandler(this.ControlClickMethod);
            // 
            // PanelButtonOptiosn
            // 
            this.PanelButtonOptiosn.Controls.Add(this.ButtonNewUser);
            this.PanelButtonOptiosn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelButtonOptiosn.Location = new System.Drawing.Point(0, 0);
            this.PanelButtonOptiosn.Margin = new System.Windows.Forms.Padding(0);
            this.PanelButtonOptiosn.Name = "PanelButtonOptiosn";
            this.PanelButtonOptiosn.Size = new System.Drawing.Size(1062, 94);
            this.PanelButtonOptiosn.TabIndex = 2;
            // 
            // ButtonNewUser
            // 
            this.ButtonNewUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonNewUser.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(32)))));
            this.ButtonNewUser.FlatAppearance.BorderSize = 3;
            this.ButtonNewUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonNewUser.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.ButtonNewUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(32)))));
            this.ButtonNewUser.ImageKey = "PlusBlack.png";
            this.ButtonNewUser.ImageList = this.ImageListOptions;
            this.ButtonNewUser.Location = new System.Drawing.Point(20, 24);
            this.ButtonNewUser.Name = "ButtonNewUser";
            this.ButtonNewUser.Size = new System.Drawing.Size(175, 47);
            this.ButtonNewUser.TabIndex = 0;
            this.ButtonNewUser.Text = "Nuevo Usuario";
            this.ButtonNewUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonNewUser.UseVisualStyleBackColor = true;
            // 
            // ImageListOptions
            // 
            this.ImageListOptions.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageListOptions.ImageStream")));
            this.ImageListOptions.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageListOptions.Images.SetKeyName(0, "PlusBlack.png");
            this.ImageListOptions.Images.SetKeyName(1, "EditBlack.png");
            this.ImageListOptions.Images.SetKeyName(2, "DeleteBlack.png");
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 698);
            this.Controls.Add(this.TableLayoutPanelContent);
            this.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.Name = "Users";
            this.Text = "Users";
            this.Controls.SetChildIndex(this.PanelInfo, 0);
            this.Controls.SetChildIndex(this.TableLayoutPanelContent, 0);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxInfo)).EndInit();
            this.PanelInfo.ResumeLayout(false);
            this.PanelInfo.PerformLayout();
            this.TableLayoutPanelContent.ResumeLayout(false);
            this.TableLayoutPanelGrid.ResumeLayout(false);
            this.PanelSearch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridSearch)).EndInit();
            this.PanelComboUI.ResumeLayout(false);
            this.PanelComboUI.PerformLayout();
            this.PanelResults.ResumeLayout(false);
            this.PanelResults.PerformLayout();
            this.PanelButtonOptiosn.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel TableLayoutPanelContent;
        private System.Windows.Forms.Panel PanelButtonOptiosn;
        private System.Windows.Forms.Button ButtonNewUser;
        private System.Windows.Forms.ImageList ImageListOptions;
        public System.Windows.Forms.TableLayoutPanel TableLayoutPanelGrid;
        private System.Windows.Forms.Panel PanelSearch;
        public Inputs.TextBoxUI TextBoxSearch;
        private System.Windows.Forms.Button ButtonSearch;
        public System.Windows.Forms.DataGridView GridSearch;
        private System.Windows.Forms.Panel PanelComboUI;
        private System.Windows.Forms.Label LabelComboSearch;
        public System.Windows.Forms.ComboBox ComboTypeSearch;
        private System.Windows.Forms.Panel PanelResults;
        private System.Windows.Forms.Label LabelTotalResults;
        private System.Windows.Forms.Label LabelResults;
        public System.Windows.Forms.Button ButtonCleanSearch;
    }
}