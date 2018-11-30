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
            this.TableLayoutPanelContent = new System.Windows.Forms.TableLayoutPanel();
            this.PanelBorder = new System.Windows.Forms.Panel();
            this.PanelForm = new System.Windows.Forms.Panel();
            this.PanelDate = new System.Windows.Forms.Panel();
            this.DateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.GroupBoxSex = new System.Windows.Forms.GroupBox();
            this.RadioButtonWoman = new System.Windows.Forms.RadioButton();
            this.RadioButtonMan = new System.Windows.Forms.RadioButton();
            this.RadioButtonBothSex = new System.Windows.Forms.RadioButton();
            this.LabelComboSearch = new System.Windows.Forms.Label();
            this.ComboTypeSearch = new System.Windows.Forms.ComboBox();
            this.ButtonCleanSearch = new System.Windows.Forms.Button();
            this.ComboTypeDepartment = new System.Windows.Forms.ComboBox();
            this.ButtonSearchAll = new System.Windows.Forms.Button();
            this.ButtonSearch = new System.Windows.Forms.Button();
            this.ImageListOptions = new System.Windows.Forms.ImageList(this.components);
            this.TextBoxSearch = new Presentation.Inputs.TextBoxUI();
            this.GroupBoxDepartment = new System.Windows.Forms.GroupBox();
            this.RadioButtonSearchDepartment = new System.Windows.Forms.RadioButton();
            this.RadioButtonAllDepartments = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxInfo)).BeginInit();
            this.PanelInfo.SuspendLayout();
            this.TableLayoutPanelContent.SuspendLayout();
            this.PanelForm.SuspendLayout();
            this.PanelDate.SuspendLayout();
            this.GroupBoxSex.SuspendLayout();
            this.GroupBoxDepartment.SuspendLayout();
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
            this.TableLayoutPanelContent.Controls.Add(this.PanelBorder, 0, 0);
            this.TableLayoutPanelContent.Controls.Add(this.PanelForm, 0, 1);
            this.TableLayoutPanelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanelContent.Location = new System.Drawing.Point(0, 68);
            this.TableLayoutPanelContent.Name = "TableLayoutPanelContent";
            this.TableLayoutPanelContent.RowCount = 2;
            this.TableLayoutPanelContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.TableLayoutPanelContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 96F));
            this.TableLayoutPanelContent.Size = new System.Drawing.Size(1062, 630);
            this.TableLayoutPanelContent.TabIndex = 1;
            // 
            // PanelBorder
            // 
            this.PanelBorder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelBorder.Location = new System.Drawing.Point(0, 0);
            this.PanelBorder.Margin = new System.Windows.Forms.Padding(0);
            this.PanelBorder.Name = "PanelBorder";
            this.PanelBorder.Size = new System.Drawing.Size(1062, 25);
            this.PanelBorder.TabIndex = 0;
            // 
            // PanelForm
            // 
            this.PanelForm.Controls.Add(this.PanelDate);
            this.PanelForm.Controls.Add(this.GroupBoxSex);
            this.PanelForm.Controls.Add(this.LabelComboSearch);
            this.PanelForm.Controls.Add(this.ComboTypeSearch);
            this.PanelForm.Controls.Add(this.ButtonCleanSearch);
            this.PanelForm.Controls.Add(this.ComboTypeDepartment);
            this.PanelForm.Controls.Add(this.ButtonSearchAll);
            this.PanelForm.Controls.Add(this.ButtonSearch);
            this.PanelForm.Controls.Add(this.TextBoxSearch);
            this.PanelForm.Controls.Add(this.GroupBoxDepartment);
            this.PanelForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelForm.Location = new System.Drawing.Point(0, 25);
            this.PanelForm.Margin = new System.Windows.Forms.Padding(0);
            this.PanelForm.Name = "PanelForm";
            this.PanelForm.Size = new System.Drawing.Size(1062, 605);
            this.PanelForm.TabIndex = 1;
            // 
            // PanelDate
            // 
            this.PanelDate.Controls.Add(this.DateTimePickerEnd);
            this.PanelDate.Controls.Add(this.label1);
            this.PanelDate.Controls.Add(this.label2);
            this.PanelDate.Controls.Add(this.DateTimePickerStart);
            this.PanelDate.Location = new System.Drawing.Point(30, 169);
            this.PanelDate.Name = "PanelDate";
            this.PanelDate.Size = new System.Drawing.Size(562, 46);
            this.PanelDate.TabIndex = 21;
            // 
            // DateTimePickerEnd
            // 
            this.DateTimePickerEnd.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(32)))));
            this.DateTimePickerEnd.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(32)))));
            this.DateTimePickerEnd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DateTimePickerEnd.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.DateTimePickerEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTimePickerEnd.Location = new System.Drawing.Point(352, 1);
            this.DateTimePickerEnd.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.DateTimePickerEnd.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.DateTimePickerEnd.Name = "DateTimePickerEnd";
            this.DateTimePickerEnd.Size = new System.Drawing.Size(198, 29);
            this.DateTimePickerEnd.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 16F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(32)))));
            this.label1.Location = new System.Drawing.Point(3, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 26);
            this.label1.TabIndex = 14;
            this.label1.Text = "Desde:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 16F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(32)))));
            this.label2.Location = new System.Drawing.Point(282, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 26);
            this.label2.TabIndex = 17;
            this.label2.Text = "Hasta:";
            // 
            // DateTimePickerStart
            // 
            this.DateTimePickerStart.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(32)))));
            this.DateTimePickerStart.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(32)))));
            this.DateTimePickerStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DateTimePickerStart.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.DateTimePickerStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTimePickerStart.Location = new System.Drawing.Point(78, 1);
            this.DateTimePickerStart.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.DateTimePickerStart.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.DateTimePickerStart.Name = "DateTimePickerStart";
            this.DateTimePickerStart.Size = new System.Drawing.Size(198, 29);
            this.DateTimePickerStart.TabIndex = 13;
            // 
            // GroupBoxSex
            // 
            this.GroupBoxSex.Controls.Add(this.RadioButtonWoman);
            this.GroupBoxSex.Controls.Add(this.RadioButtonMan);
            this.GroupBoxSex.Controls.Add(this.RadioButtonBothSex);
            this.GroupBoxSex.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.GroupBoxSex.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(32)))));
            this.GroupBoxSex.Location = new System.Drawing.Point(30, 169);
            this.GroupBoxSex.Name = "GroupBoxSex";
            this.GroupBoxSex.Size = new System.Drawing.Size(304, 66);
            this.GroupBoxSex.TabIndex = 9;
            this.GroupBoxSex.TabStop = false;
            // 
            // RadioButtonWoman
            // 
            this.RadioButtonWoman.AutoSize = true;
            this.RadioButtonWoman.Dock = System.Windows.Forms.DockStyle.Left;
            this.RadioButtonWoman.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.RadioButtonWoman.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(32)))));
            this.RadioButtonWoman.Location = new System.Drawing.Point(212, 25);
            this.RadioButtonWoman.Name = "RadioButtonWoman";
            this.RadioButtonWoman.Size = new System.Drawing.Size(67, 38);
            this.RadioButtonWoman.TabIndex = 12;
            this.RadioButtonWoman.TabStop = true;
            this.RadioButtonWoman.Text = "Mujer";
            this.RadioButtonWoman.UseVisualStyleBackColor = true;
            // 
            // RadioButtonMan
            // 
            this.RadioButtonMan.AutoSize = true;
            this.RadioButtonMan.Dock = System.Windows.Forms.DockStyle.Left;
            this.RadioButtonMan.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.RadioButtonMan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(32)))));
            this.RadioButtonMan.Location = new System.Drawing.Point(128, 25);
            this.RadioButtonMan.Name = "RadioButtonMan";
            this.RadioButtonMan.Size = new System.Drawing.Size(84, 38);
            this.RadioButtonMan.TabIndex = 11;
            this.RadioButtonMan.TabStop = true;
            this.RadioButtonMan.Text = "Hombre";
            this.RadioButtonMan.UseVisualStyleBackColor = true;
            // 
            // RadioButtonBothSex
            // 
            this.RadioButtonBothSex.AutoSize = true;
            this.RadioButtonBothSex.Dock = System.Windows.Forms.DockStyle.Left;
            this.RadioButtonBothSex.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.RadioButtonBothSex.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(32)))));
            this.RadioButtonBothSex.Location = new System.Drawing.Point(3, 25);
            this.RadioButtonBothSex.Name = "RadioButtonBothSex";
            this.RadioButtonBothSex.Size = new System.Drawing.Size(125, 38);
            this.RadioButtonBothSex.TabIndex = 10;
            this.RadioButtonBothSex.TabStop = true;
            this.RadioButtonBothSex.Text = "Ambos Sexos";
            this.RadioButtonBothSex.UseVisualStyleBackColor = true;
            // 
            // LabelComboSearch
            // 
            this.LabelComboSearch.AutoSize = true;
            this.LabelComboSearch.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.LabelComboSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(32)))));
            this.LabelComboSearch.Location = new System.Drawing.Point(26, 109);
            this.LabelComboSearch.Name = "LabelComboSearch";
            this.LabelComboSearch.Size = new System.Drawing.Size(145, 23);
            this.LabelComboSearch.TabIndex = 20;
            this.LabelComboSearch.Text = "Filtro de Búsqueda:";
            // 
            // ComboTypeSearch
            // 
            this.ComboTypeSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ComboTypeSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboTypeSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ComboTypeSearch.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.ComboTypeSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(32)))));
            this.ComboTypeSearch.FormattingEnabled = true;
            this.ComboTypeSearch.IntegralHeight = false;
            this.ComboTypeSearch.Location = new System.Drawing.Point(177, 104);
            this.ComboTypeSearch.Name = "ComboTypeSearch";
            this.ComboTypeSearch.Size = new System.Drawing.Size(344, 28);
            this.ComboTypeSearch.TabIndex = 19;
            this.ComboTypeSearch.SelectedIndexChanged += new System.EventHandler(this.ComboTypeSearchSelectedChangedMethod);
            // 
            // ButtonCleanSearch
            // 
            this.ButtonCleanSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonCleanSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonCleanSearch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(32)))));
            this.ButtonCleanSearch.FlatAppearance.BorderSize = 3;
            this.ButtonCleanSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonCleanSearch.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.ButtonCleanSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(32)))));
            this.ButtonCleanSearch.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.ButtonCleanSearch.Location = new System.Drawing.Point(876, 14);
            this.ButtonCleanSearch.Name = "ButtonCleanSearch";
            this.ButtonCleanSearch.Size = new System.Drawing.Size(165, 42);
            this.ButtonCleanSearch.TabIndex = 18;
            this.ButtonCleanSearch.Text = "Limpiar Búsqueda";
            this.ButtonCleanSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.ButtonCleanSearch.UseVisualStyleBackColor = true;
            this.ButtonCleanSearch.Click += new System.EventHandler(this.ControlClickMethod);
            // 
            // ComboTypeDepartment
            // 
            this.ComboTypeDepartment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ComboTypeDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboTypeDepartment.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ComboTypeDepartment.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.ComboTypeDepartment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(32)))));
            this.ComboTypeDepartment.FormattingEnabled = true;
            this.ComboTypeDepartment.IntegralHeight = false;
            this.ComboTypeDepartment.Location = new System.Drawing.Point(613, 202);
            this.ComboTypeDepartment.Name = "ComboTypeDepartment";
            this.ComboTypeDepartment.Size = new System.Drawing.Size(412, 28);
            this.ComboTypeDepartment.TabIndex = 8;
            // 
            // ButtonSearchAll
            // 
            this.ButtonSearchAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonSearchAll.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(32)))));
            this.ButtonSearchAll.FlatAppearance.BorderSize = 3;
            this.ButtonSearchAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSearchAll.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.ButtonSearchAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(32)))));
            this.ButtonSearchAll.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.ButtonSearchAll.Location = new System.Drawing.Point(30, 14);
            this.ButtonSearchAll.Name = "ButtonSearchAll";
            this.ButtonSearchAll.Size = new System.Drawing.Size(202, 42);
            this.ButtonSearchAll.TabIndex = 13;
            this.ButtonSearchAll.TabStop = false;
            this.ButtonSearchAll.Text = "Ver todos los registros";
            this.ButtonSearchAll.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.ButtonSearchAll.UseVisualStyleBackColor = true;
            this.ButtonSearchAll.Click += new System.EventHandler(this.ControlClickMethod);
            // 
            // ButtonSearch
            // 
            this.ButtonSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonSearch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(32)))));
            this.ButtonSearch.FlatAppearance.BorderSize = 3;
            this.ButtonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSearch.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.ButtonSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(32)))));
            this.ButtonSearch.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.ButtonSearch.ImageIndex = 0;
            this.ButtonSearch.ImageList = this.ImageListOptions;
            this.ButtonSearch.Location = new System.Drawing.Point(544, 90);
            this.ButtonSearch.Name = "ButtonSearch";
            this.ButtonSearch.Size = new System.Drawing.Size(202, 42);
            this.ButtonSearch.TabIndex = 15;
            this.ButtonSearch.Text = "Realizar Búsqueda";
            this.ButtonSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.ButtonSearch.UseVisualStyleBackColor = true;
            this.ButtonSearch.Click += new System.EventHandler(this.ControlClickMethod);
            // 
            // ImageListOptions
            // 
            this.ImageListOptions.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageListOptions.ImageStream")));
            this.ImageListOptions.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageListOptions.Images.SetKeyName(0, "SearchBlack.png");
            // 
            // TextBoxSearch
            // 
            this.TextBoxSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(205)))), ((int)(((byte)(203)))));
            this.TextBoxSearch.BackColorLabel = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(205)))), ((int)(((byte)(203)))));
            this.TextBoxSearch.BackColorPanel = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(32)))));
            this.TextBoxSearch.BackColorTextBox = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(205)))), ((int)(((byte)(203)))));
            this.TextBoxSearch.EnableTextBox = true;
            this.TextBoxSearch.Font = new System.Drawing.Font("Arial Narrow", 2F);
            this.TextBoxSearch.ForeColorLabel = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(32)))));
            this.TextBoxSearch.ForeColorTextBox = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(32)))));
            this.TextBoxSearch.Location = new System.Drawing.Point(30, 169);
            this.TextBoxSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextBoxSearch.MaxLengthTextBox = 32767;
            this.TextBoxSearch.Name = "TextBoxSearch";
            this.TextBoxSearch.PasswordTextBox = '\0';
            this.TextBoxSearch.SelectionLengthTextBox = 0;
            this.TextBoxSearch.SelectionStartTextBox = 0;
            this.TextBoxSearch.Size = new System.Drawing.Size(995, 35);
            this.TextBoxSearch.TabIndex = 3;
            this.TextBoxSearch.TextLabel = "Número de Control:";
            this.TextBoxSearch.TextTextBox = "";
            // 
            // GroupBoxDepartment
            // 
            this.GroupBoxDepartment.Controls.Add(this.RadioButtonSearchDepartment);
            this.GroupBoxDepartment.Controls.Add(this.RadioButtonAllDepartments);
            this.GroupBoxDepartment.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.GroupBoxDepartment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(32)))));
            this.GroupBoxDepartment.Location = new System.Drawing.Point(30, 169);
            this.GroupBoxDepartment.Name = "GroupBoxDepartment";
            this.GroupBoxDepartment.Size = new System.Drawing.Size(577, 60);
            this.GroupBoxDepartment.TabIndex = 5;
            this.GroupBoxDepartment.TabStop = false;
            // 
            // RadioButtonSearchDepartment
            // 
            this.RadioButtonSearchDepartment.AutoSize = true;
            this.RadioButtonSearchDepartment.Dock = System.Windows.Forms.DockStyle.Left;
            this.RadioButtonSearchDepartment.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.RadioButtonSearchDepartment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(32)))));
            this.RadioButtonSearchDepartment.Location = new System.Drawing.Point(285, 25);
            this.RadioButtonSearchDepartment.Name = "RadioButtonSearchDepartment";
            this.RadioButtonSearchDepartment.Size = new System.Drawing.Size(273, 32);
            this.RadioButtonSearchDepartment.TabIndex = 7;
            this.RadioButtonSearchDepartment.TabStop = true;
            this.RadioButtonSearchDepartment.Text = "Especificar Carrera y Departamento";
            this.RadioButtonSearchDepartment.UseVisualStyleBackColor = true;
            this.RadioButtonSearchDepartment.CheckedChanged += new System.EventHandler(this.RadioButtonDepartmentCheckedChangedMethod);
            // 
            // RadioButtonAllDepartments
            // 
            this.RadioButtonAllDepartments.AutoSize = true;
            this.RadioButtonAllDepartments.Dock = System.Windows.Forms.DockStyle.Left;
            this.RadioButtonAllDepartments.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.RadioButtonAllDepartments.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(32)))));
            this.RadioButtonAllDepartments.Location = new System.Drawing.Point(3, 25);
            this.RadioButtonAllDepartments.Name = "RadioButtonAllDepartments";
            this.RadioButtonAllDepartments.Size = new System.Drawing.Size(282, 32);
            this.RadioButtonAllDepartments.TabIndex = 6;
            this.RadioButtonAllDepartments.TabStop = true;
            this.RadioButtonAllDepartments.Text = "Todas las Carreras y Departamentos";
            this.RadioButtonAllDepartments.UseVisualStyleBackColor = true;
            this.RadioButtonAllDepartments.CheckedChanged += new System.EventHandler(this.RadioButtonDepartmentCheckedChangedMethod);
            // 
            // Moves
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 698);
            this.Controls.Add(this.TableLayoutPanelContent);
            this.Name = "Moves";
            this.Text = "Moves";
            this.Controls.SetChildIndex(this.PanelInfo, 0);
            this.Controls.SetChildIndex(this.TableLayoutPanelContent, 0);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxInfo)).EndInit();
            this.PanelInfo.ResumeLayout(false);
            this.PanelInfo.PerformLayout();
            this.TableLayoutPanelContent.ResumeLayout(false);
            this.PanelForm.ResumeLayout(false);
            this.PanelForm.PerformLayout();
            this.PanelDate.ResumeLayout(false);
            this.PanelDate.PerformLayout();
            this.GroupBoxSex.ResumeLayout(false);
            this.GroupBoxSex.PerformLayout();
            this.GroupBoxDepartment.ResumeLayout(false);
            this.GroupBoxDepartment.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TableLayoutPanelContent;
        private System.Windows.Forms.Panel PanelBorder;
        public System.Windows.Forms.Button ButtonSearch;
        private System.Windows.Forms.ImageList ImageListOptions;
        private System.Windows.Forms.Panel PanelForm;
        public Inputs.TextBoxUI TextBoxSearch;
        private System.Windows.Forms.GroupBox GroupBoxSex;
        private System.Windows.Forms.RadioButton RadioButtonMan;
        private System.Windows.Forms.RadioButton RadioButtonBothSex;
        public System.Windows.Forms.ComboBox ComboTypeDepartment;
        public System.Windows.Forms.Button ButtonSearchAll;
        private System.Windows.Forms.RadioButton RadioButtonWoman;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DateTimePickerStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DateTimePickerEnd;
        private System.Windows.Forms.GroupBox GroupBoxDepartment;
        private System.Windows.Forms.RadioButton RadioButtonSearchDepartment;
        private System.Windows.Forms.RadioButton RadioButtonAllDepartments;
        public System.Windows.Forms.Button ButtonCleanSearch;
        private System.Windows.Forms.Label LabelComboSearch;
        public System.Windows.Forms.ComboBox ComboTypeSearch;
        private System.Windows.Forms.Panel PanelDate;
    }
}