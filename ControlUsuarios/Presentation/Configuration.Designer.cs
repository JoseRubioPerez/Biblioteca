namespace Presentation
{
    partial class Configuration
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TableLayoutPanelContent = new System.Windows.Forms.TableLayoutPanel();
            this.TableLayoutPanelGrid = new System.Windows.Forms.TableLayoutPanel();
            this.GridSearch = new System.Windows.Forms.DataGridView();
            this.PanelResults = new System.Windows.Forms.Panel();
            this.LabelTotalResults = new System.Windows.Forms.Label();
            this.LabelResults = new System.Windows.Forms.Label();
            this.PanelButtonOptiosn = new System.Windows.Forms.Panel();
            this.ButtonChangeMyPassword = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxInfo)).BeginInit();
            this.PanelInfo.SuspendLayout();
            this.TableLayoutPanelContent.SuspendLayout();
            this.TableLayoutPanelGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridSearch)).BeginInit();
            this.PanelResults.SuspendLayout();
            this.PanelButtonOptiosn.SuspendLayout();
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
            this.LabelSubTitle.Location = new System.Drawing.Point(309, 30);
            this.LabelSubTitle.Size = new System.Drawing.Size(387, 26);
            this.LabelSubTitle.Text = "Cambios de contraseña y permisos de cuentas";
            // 
            // LabelTitle
            // 
            this.LabelTitle.Size = new System.Drawing.Size(291, 35);
            this.LabelTitle.Text = "Modulo de Configuración";
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
            this.TableLayoutPanelContent.TabIndex = 3;
            // 
            // TableLayoutPanelGrid
            // 
            this.TableLayoutPanelGrid.ColumnCount = 2;
            this.TableLayoutPanelGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.TableLayoutPanelGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.TableLayoutPanelGrid.Controls.Add(this.GridSearch, 0, 1);
            this.TableLayoutPanelGrid.Controls.Add(this.PanelResults, 1, 0);
            this.TableLayoutPanelGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanelGrid.Location = new System.Drawing.Point(3, 97);
            this.TableLayoutPanelGrid.Name = "TableLayoutPanelGrid";
            this.TableLayoutPanelGrid.RowCount = 2;
            this.TableLayoutPanelGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TableLayoutPanelGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.TableLayoutPanelGrid.Size = new System.Drawing.Size(1056, 530);
            this.TableLayoutPanelGrid.TabIndex = 12;
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Narrow", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridSearch.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GridSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableLayoutPanelGrid.SetColumnSpan(this.GridSearch, 2);
            this.GridSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridSearch.EnableHeadersVisualStyles = false;
            this.GridSearch.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(32)))));
            this.GridSearch.Location = new System.Drawing.Point(0, 106);
            this.GridSearch.Margin = new System.Windows.Forms.Padding(0);
            this.GridSearch.Name = "GridSearch";
            this.GridSearch.ReadOnly = true;
            this.GridSearch.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(205)))), ((int)(((byte)(203)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Narrow", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(32)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridSearch.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.GridSearch.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(205)))), ((int)(((byte)(203)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial Narrow", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(32)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(71)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.GridSearch.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.GridSearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridSearch.Size = new System.Drawing.Size(1056, 424);
            this.GridSearch.TabIndex = 0;
            this.GridSearch.DataSourceChanged += new System.EventHandler(this.DataSourceChangedMethod);
            // 
            // PanelResults
            // 
            this.PanelResults.Controls.Add(this.LabelTotalResults);
            this.PanelResults.Controls.Add(this.LabelResults);
            this.PanelResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelResults.Location = new System.Drawing.Point(739, 0);
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
            // PanelButtonOptiosn
            // 
            this.PanelButtonOptiosn.Controls.Add(this.ButtonChangeMyPassword);
            this.PanelButtonOptiosn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelButtonOptiosn.Location = new System.Drawing.Point(0, 0);
            this.PanelButtonOptiosn.Margin = new System.Windows.Forms.Padding(0);
            this.PanelButtonOptiosn.Name = "PanelButtonOptiosn";
            this.PanelButtonOptiosn.Size = new System.Drawing.Size(1062, 94);
            this.PanelButtonOptiosn.TabIndex = 2;
            // 
            // ButtonChangeMyPassword
            // 
            this.ButtonChangeMyPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonChangeMyPassword.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(32)))));
            this.ButtonChangeMyPassword.FlatAppearance.BorderSize = 3;
            this.ButtonChangeMyPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonChangeMyPassword.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.ButtonChangeMyPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(32)))));
            this.ButtonChangeMyPassword.ImageKey = "PlusBlack.png";
            this.ButtonChangeMyPassword.Location = new System.Drawing.Point(20, 24);
            this.ButtonChangeMyPassword.Name = "ButtonChangeMyPassword";
            this.ButtonChangeMyPassword.Size = new System.Drawing.Size(209, 47);
            this.ButtonChangeMyPassword.TabIndex = 0;
            this.ButtonChangeMyPassword.Text = "Cambiar mi contraseña";
            this.ButtonChangeMyPassword.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonChangeMyPassword.UseVisualStyleBackColor = true;
            this.ButtonChangeMyPassword.Click += new System.EventHandler(this.ControlClickMethod);
            // 
            // Configuration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 698);
            this.Controls.Add(this.TableLayoutPanelContent);
            this.Name = "Configuration";
            this.Text = "Configuration";
            this.Controls.SetChildIndex(this.PanelInfo, 0);
            this.Controls.SetChildIndex(this.TableLayoutPanelContent, 0);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxInfo)).EndInit();
            this.PanelInfo.ResumeLayout(false);
            this.PanelInfo.PerformLayout();
            this.TableLayoutPanelContent.ResumeLayout(false);
            this.TableLayoutPanelGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridSearch)).EndInit();
            this.PanelResults.ResumeLayout(false);
            this.PanelResults.PerformLayout();
            this.PanelButtonOptiosn.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TableLayoutPanelContent;
        public System.Windows.Forms.TableLayoutPanel TableLayoutPanelGrid;
        public System.Windows.Forms.DataGridView GridSearch;
        private System.Windows.Forms.Panel PanelResults;
        private System.Windows.Forms.Label LabelTotalResults;
        private System.Windows.Forms.Label LabelResults;
        private System.Windows.Forms.Panel PanelButtonOptiosn;
        private System.Windows.Forms.Button ButtonChangeMyPassword;
    }
}