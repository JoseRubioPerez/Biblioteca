namespace Presentation
{
    partial class Stats
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
            this.LabelComboSearch = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.GroupBoxSex = new System.Windows.Forms.GroupBox();
            this.RadioButtonBothSex = new System.Windows.Forms.RadioButton();
            this.RadioButtonMan = new System.Windows.Forms.RadioButton();
            this.RadioButtonWoman = new System.Windows.Forms.RadioButton();
            this.CheckBoxService1 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CheckBoxService2 = new System.Windows.Forms.CheckBox();
            this.CheckBoxService3 = new System.Windows.Forms.CheckBox();
            this.CheckBoxService4 = new System.Windows.Forms.CheckBox();
            this.CheckBoxService5 = new System.Windows.Forms.CheckBox();
            this.CheckBoxService6 = new System.Windows.Forms.CheckBox();
            this.CheckBoxService7 = new System.Windows.Forms.CheckBox();
            this.PanelBorder1 = new System.Windows.Forms.Panel();
            this.PanelBorder2 = new System.Windows.Forms.Panel();
            this.PanelBorder3 = new System.Windows.Forms.Panel();
            this.DateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.GroupBoxDateTime = new System.Windows.Forms.GroupBox();
            this.RadioButtonAll = new System.Windows.Forms.RadioButton();
            this.RadioButtonYear = new System.Windows.Forms.RadioButton();
            this.RadioButtonMonth = new System.Windows.Forms.RadioButton();
            this.RadioButtonWeek = new System.Windows.Forms.RadioButton();
            this.RadioButtonToday = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.ButtonCreateReport = new System.Windows.Forms.Button();
            this.PanelDate = new System.Windows.Forms.Panel();
            this.RadioButtonPersonalize = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxInfo)).BeginInit();
            this.PanelInfo.SuspendLayout();
            this.GroupBoxSex.SuspendLayout();
            this.GroupBoxDateTime.SuspendLayout();
            this.PanelDate.SuspendLayout();
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
            this.LabelSubTitle.Location = new System.Drawing.Point(257, 30);
            this.LabelSubTitle.Size = new System.Drawing.Size(611, 26);
            this.LabelSubTitle.Text = "Genera reportes de los movimientos realizados en el centro de información";
            // 
            // LabelTitle
            // 
            this.LabelTitle.Size = new System.Drawing.Size(239, 35);
            this.LabelTitle.Text = "Modulo de Reportes";
            // 
            // LabelComboSearch
            // 
            this.LabelComboSearch.AutoSize = true;
            this.LabelComboSearch.Font = new System.Drawing.Font("Arial Narrow", 16F);
            this.LabelComboSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(32)))));
            this.LabelComboSearch.Location = new System.Drawing.Point(79, 99);
            this.LabelComboSearch.Name = "LabelComboSearch";
            this.LabelComboSearch.Size = new System.Drawing.Size(564, 26);
            this.LabelComboSearch.TabIndex = 8;
            this.LabelComboSearch.Text = "Para crear un reporte, es necesario específicar los siguientes puntos:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(32)))));
            this.label1.Location = new System.Drawing.Point(80, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "Sexo del usuario:";
            // 
            // GroupBoxSex
            // 
            this.GroupBoxSex.Controls.Add(this.RadioButtonBothSex);
            this.GroupBoxSex.Controls.Add(this.RadioButtonMan);
            this.GroupBoxSex.Controls.Add(this.RadioButtonWoman);
            this.GroupBoxSex.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(32)))));
            this.GroupBoxSex.Location = new System.Drawing.Point(217, 168);
            this.GroupBoxSex.Name = "GroupBoxSex";
            this.GroupBoxSex.Size = new System.Drawing.Size(249, 56);
            this.GroupBoxSex.TabIndex = 10;
            this.GroupBoxSex.TabStop = false;
            // 
            // RadioButtonBothSex
            // 
            this.RadioButtonBothSex.AutoSize = true;
            this.RadioButtonBothSex.Dock = System.Windows.Forms.DockStyle.Left;
            this.RadioButtonBothSex.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.RadioButtonBothSex.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(32)))));
            this.RadioButtonBothSex.Location = new System.Drawing.Point(164, 22);
            this.RadioButtonBothSex.Name = "RadioButtonBothSex";
            this.RadioButtonBothSex.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.RadioButtonBothSex.Size = new System.Drawing.Size(82, 31);
            this.RadioButtonBothSex.TabIndex = 13;
            this.RadioButtonBothSex.TabStop = true;
            this.RadioButtonBothSex.Text = "Ambos";
            this.RadioButtonBothSex.UseVisualStyleBackColor = true;
            // 
            // RadioButtonMan
            // 
            this.RadioButtonMan.AutoSize = true;
            this.RadioButtonMan.Dock = System.Windows.Forms.DockStyle.Left;
            this.RadioButtonMan.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.RadioButtonMan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(32)))));
            this.RadioButtonMan.Location = new System.Drawing.Point(75, 22);
            this.RadioButtonMan.Name = "RadioButtonMan";
            this.RadioButtonMan.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.RadioButtonMan.Size = new System.Drawing.Size(89, 31);
            this.RadioButtonMan.TabIndex = 11;
            this.RadioButtonMan.TabStop = true;
            this.RadioButtonMan.Text = "Hombre";
            this.RadioButtonMan.UseVisualStyleBackColor = true;
            // 
            // RadioButtonWoman
            // 
            this.RadioButtonWoman.AutoSize = true;
            this.RadioButtonWoman.Dock = System.Windows.Forms.DockStyle.Left;
            this.RadioButtonWoman.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.RadioButtonWoman.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(32)))));
            this.RadioButtonWoman.Location = new System.Drawing.Point(3, 22);
            this.RadioButtonWoman.Name = "RadioButtonWoman";
            this.RadioButtonWoman.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.RadioButtonWoman.Size = new System.Drawing.Size(72, 31);
            this.RadioButtonWoman.TabIndex = 12;
            this.RadioButtonWoman.TabStop = true;
            this.RadioButtonWoman.Text = "Mujer";
            this.RadioButtonWoman.UseVisualStyleBackColor = true;
            // 
            // CheckBoxService1
            // 
            this.CheckBoxService1.AutoSize = true;
            this.CheckBoxService1.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.CheckBoxService1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(32)))));
            this.CheckBoxService1.Location = new System.Drawing.Point(270, 274);
            this.CheckBoxService1.Name = "CheckBoxService1";
            this.CheckBoxService1.Size = new System.Drawing.Size(176, 27);
            this.CheckBoxService1.TabIndex = 11;
            this.CheckBoxService1.Text = "Consulta o referencia";
            this.CheckBoxService1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(32)))));
            this.label2.Location = new System.Drawing.Point(80, 278);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 23);
            this.label2.TabIndex = 12;
            this.label2.Text = "Servicio(s) consultado(s):";
            // 
            // CheckBoxService2
            // 
            this.CheckBoxService2.AutoSize = true;
            this.CheckBoxService2.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.CheckBoxService2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(32)))));
            this.CheckBoxService2.Location = new System.Drawing.Point(452, 274);
            this.CheckBoxService2.Name = "CheckBoxService2";
            this.CheckBoxService2.Size = new System.Drawing.Size(137, 27);
            this.CheckBoxService2.TabIndex = 13;
            this.CheckBoxService2.Text = "Bases de datos";
            this.CheckBoxService2.UseVisualStyleBackColor = true;
            // 
            // CheckBoxService3
            // 
            this.CheckBoxService3.AutoSize = true;
            this.CheckBoxService3.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.CheckBoxService3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(32)))));
            this.CheckBoxService3.Location = new System.Drawing.Point(595, 274);
            this.CheckBoxService3.Name = "CheckBoxService3";
            this.CheckBoxService3.Size = new System.Drawing.Size(98, 27);
            this.CheckBoxService3.TabIndex = 14;
            this.CheckBoxService3.Text = "Cubículos";
            this.CheckBoxService3.UseVisualStyleBackColor = true;
            // 
            // CheckBoxService4
            // 
            this.CheckBoxService4.AutoSize = true;
            this.CheckBoxService4.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.CheckBoxService4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(32)))));
            this.CheckBoxService4.Location = new System.Drawing.Point(270, 307);
            this.CheckBoxService4.Name = "CheckBoxService4";
            this.CheckBoxService4.Size = new System.Drawing.Size(207, 27);
            this.CheckBoxService4.TabIndex = 15;
            this.CheckBoxService4.Text = "Sala de trabajo en equipo";
            this.CheckBoxService4.UseVisualStyleBackColor = true;
            // 
            // CheckBoxService5
            // 
            this.CheckBoxService5.AutoSize = true;
            this.CheckBoxService5.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.CheckBoxService5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(32)))));
            this.CheckBoxService5.Location = new System.Drawing.Point(483, 307);
            this.CheckBoxService5.Name = "CheckBoxService5";
            this.CheckBoxService5.Size = new System.Drawing.Size(132, 27);
            this.CheckBoxService5.TabIndex = 16;
            this.CheckBoxService5.Text = "Sala de lectura";
            this.CheckBoxService5.UseVisualStyleBackColor = true;
            // 
            // CheckBoxService6
            // 
            this.CheckBoxService6.AutoSize = true;
            this.CheckBoxService6.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.CheckBoxService6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(32)))));
            this.CheckBoxService6.Location = new System.Drawing.Point(621, 307);
            this.CheckBoxService6.Name = "CheckBoxService6";
            this.CheckBoxService6.Size = new System.Drawing.Size(74, 27);
            this.CheckBoxService6.TabIndex = 17;
            this.CheckBoxService6.Text = "Baños";
            this.CheckBoxService6.UseVisualStyleBackColor = true;
            // 
            // CheckBoxService7
            // 
            this.CheckBoxService7.AutoSize = true;
            this.CheckBoxService7.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.CheckBoxService7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(32)))));
            this.CheckBoxService7.Location = new System.Drawing.Point(701, 307);
            this.CheckBoxService7.Name = "CheckBoxService7";
            this.CheckBoxService7.Size = new System.Drawing.Size(66, 27);
            this.CheckBoxService7.TabIndex = 18;
            this.CheckBoxService7.Text = "Otros";
            this.CheckBoxService7.UseVisualStyleBackColor = true;
            // 
            // PanelBorder1
            // 
            this.PanelBorder1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(32)))));
            this.PanelBorder1.Location = new System.Drawing.Point(84, 158);
            this.PanelBorder1.Name = "PanelBorder1";
            this.PanelBorder1.Size = new System.Drawing.Size(900, 4);
            this.PanelBorder1.TabIndex = 19;
            // 
            // PanelBorder2
            // 
            this.PanelBorder2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(32)))));
            this.PanelBorder2.Location = new System.Drawing.Point(84, 243);
            this.PanelBorder2.Name = "PanelBorder2";
            this.PanelBorder2.Size = new System.Drawing.Size(900, 4);
            this.PanelBorder2.TabIndex = 20;
            // 
            // PanelBorder3
            // 
            this.PanelBorder3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(32)))));
            this.PanelBorder3.Location = new System.Drawing.Point(84, 360);
            this.PanelBorder3.Name = "PanelBorder3";
            this.PanelBorder3.Size = new System.Drawing.Size(900, 4);
            this.PanelBorder3.TabIndex = 21;
            // 
            // DateTimePickerStart
            // 
            this.DateTimePickerStart.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(32)))));
            this.DateTimePickerStart.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(32)))));
            this.DateTimePickerStart.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.DateTimePickerStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTimePickerStart.Location = new System.Drawing.Point(109, 29);
            this.DateTimePickerStart.Name = "DateTimePickerStart";
            this.DateTimePickerStart.Size = new System.Drawing.Size(135, 29);
            this.DateTimePickerStart.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(32)))));
            this.label3.Location = new System.Drawing.Point(80, 403);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 23);
            this.label3.TabIndex = 23;
            this.label3.Text = "Fecha:";
            // 
            // GroupBoxDateTime
            // 
            this.GroupBoxDateTime.Controls.Add(this.RadioButtonPersonalize);
            this.GroupBoxDateTime.Controls.Add(this.RadioButtonAll);
            this.GroupBoxDateTime.Controls.Add(this.RadioButtonYear);
            this.GroupBoxDateTime.Controls.Add(this.RadioButtonMonth);
            this.GroupBoxDateTime.Controls.Add(this.RadioButtonWeek);
            this.GroupBoxDateTime.Controls.Add(this.RadioButtonToday);
            this.GroupBoxDateTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(32)))));
            this.GroupBoxDateTime.Location = new System.Drawing.Point(145, 376);
            this.GroupBoxDateTime.Name = "GroupBoxDateTime";
            this.GroupBoxDateTime.Size = new System.Drawing.Size(839, 58);
            this.GroupBoxDateTime.TabIndex = 24;
            this.GroupBoxDateTime.TabStop = false;
            // 
            // RadioButtonAll
            // 
            this.RadioButtonAll.AutoSize = true;
            this.RadioButtonAll.Dock = System.Windows.Forms.DockStyle.Left;
            this.RadioButtonAll.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.RadioButtonAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(32)))));
            this.RadioButtonAll.Location = new System.Drawing.Point(442, 22);
            this.RadioButtonAll.Name = "RadioButtonAll";
            this.RadioButtonAll.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.RadioButtonAll.Size = new System.Drawing.Size(239, 33);
            this.RadioButtonAll.TabIndex = 15;
            this.RadioButtonAll.TabStop = true;
            this.RadioButtonAll.Text = "Origen de los datos a la fecha";
            this.RadioButtonAll.UseVisualStyleBackColor = true;
            // 
            // RadioButtonYear
            // 
            this.RadioButtonYear.AutoSize = true;
            this.RadioButtonYear.Dock = System.Windows.Forms.DockStyle.Left;
            this.RadioButtonYear.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.RadioButtonYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(32)))));
            this.RadioButtonYear.Location = new System.Drawing.Point(336, 22);
            this.RadioButtonYear.Name = "RadioButtonYear";
            this.RadioButtonYear.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.RadioButtonYear.Size = new System.Drawing.Size(106, 33);
            this.RadioButtonYear.TabIndex = 14;
            this.RadioButtonYear.TabStop = true;
            this.RadioButtonYear.Text = "Último año";
            this.RadioButtonYear.UseVisualStyleBackColor = true;
            // 
            // RadioButtonMonth
            // 
            this.RadioButtonMonth.AutoSize = true;
            this.RadioButtonMonth.Dock = System.Windows.Forms.DockStyle.Left;
            this.RadioButtonMonth.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.RadioButtonMonth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(32)))));
            this.RadioButtonMonth.Location = new System.Drawing.Point(227, 22);
            this.RadioButtonMonth.Name = "RadioButtonMonth";
            this.RadioButtonMonth.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.RadioButtonMonth.Size = new System.Drawing.Size(109, 33);
            this.RadioButtonMonth.TabIndex = 13;
            this.RadioButtonMonth.TabStop = true;
            this.RadioButtonMonth.Text = "Último mes";
            this.RadioButtonMonth.UseVisualStyleBackColor = true;
            // 
            // RadioButtonWeek
            // 
            this.RadioButtonWeek.AutoSize = true;
            this.RadioButtonWeek.Dock = System.Windows.Forms.DockStyle.Left;
            this.RadioButtonWeek.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.RadioButtonWeek.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(32)))));
            this.RadioButtonWeek.Location = new System.Drawing.Point(91, 22);
            this.RadioButtonWeek.Name = "RadioButtonWeek";
            this.RadioButtonWeek.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.RadioButtonWeek.Size = new System.Drawing.Size(136, 33);
            this.RadioButtonWeek.TabIndex = 11;
            this.RadioButtonWeek.TabStop = true;
            this.RadioButtonWeek.Text = "Última semana";
            this.RadioButtonWeek.UseVisualStyleBackColor = true;
            // 
            // RadioButtonToday
            // 
            this.RadioButtonToday.AutoSize = true;
            this.RadioButtonToday.Dock = System.Windows.Forms.DockStyle.Left;
            this.RadioButtonToday.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.RadioButtonToday.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(32)))));
            this.RadioButtonToday.Location = new System.Drawing.Point(3, 22);
            this.RadioButtonToday.Name = "RadioButtonToday";
            this.RadioButtonToday.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.RadioButtonToday.Size = new System.Drawing.Size(88, 33);
            this.RadioButtonToday.TabIndex = 12;
            this.RadioButtonToday.TabStop = true;
            this.RadioButtonToday.Text = "Este día";
            this.RadioButtonToday.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(32)))));
            this.label4.Location = new System.Drawing.Point(42, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 23);
            this.label4.TabIndex = 25;
            this.label4.Text = "Inicio:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(32)))));
            this.label5.Location = new System.Drawing.Point(260, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 23);
            this.label5.TabIndex = 26;
            this.label5.Text = "Final:";
            // 
            // DateTimePickerEnd
            // 
            this.DateTimePickerEnd.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(32)))));
            this.DateTimePickerEnd.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(32)))));
            this.DateTimePickerEnd.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.DateTimePickerEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTimePickerEnd.Location = new System.Drawing.Point(325, 29);
            this.DateTimePickerEnd.Name = "DateTimePickerEnd";
            this.DateTimePickerEnd.Size = new System.Drawing.Size(135, 29);
            this.DateTimePickerEnd.TabIndex = 27;
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(32)))));
            this.ButtonCancel.FlatAppearance.BorderSize = 3;
            this.ButtonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonCancel.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.ButtonCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(32)))));
            this.ButtonCancel.ImageKey = "PlusBlack.png";
            this.ButtonCancel.Location = new System.Drawing.Point(809, 553);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(175, 47);
            this.ButtonCancel.TabIndex = 28;
            this.ButtonCancel.Text = "Cancelar";
            this.ButtonCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonCancel.UseVisualStyleBackColor = true;
            this.ButtonCancel.Click += new System.EventHandler(this.ControlClickMethod);
            // 
            // ButtonCreateReport
            // 
            this.ButtonCreateReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonCreateReport.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(32)))));
            this.ButtonCreateReport.FlatAppearance.BorderSize = 3;
            this.ButtonCreateReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonCreateReport.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.ButtonCreateReport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(32)))));
            this.ButtonCreateReport.ImageKey = "PlusBlack.png";
            this.ButtonCreateReport.Location = new System.Drawing.Point(621, 553);
            this.ButtonCreateReport.Name = "ButtonCreateReport";
            this.ButtonCreateReport.Size = new System.Drawing.Size(175, 47);
            this.ButtonCreateReport.TabIndex = 29;
            this.ButtonCreateReport.Text = "Crear Reporte";
            this.ButtonCreateReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonCreateReport.UseVisualStyleBackColor = true;
            this.ButtonCreateReport.Click += new System.EventHandler(this.ControlClickMethod);
            // 
            // PanelDate
            // 
            this.PanelDate.Controls.Add(this.label4);
            this.PanelDate.Controls.Add(this.DateTimePickerStart);
            this.PanelDate.Controls.Add(this.label5);
            this.PanelDate.Controls.Add(this.DateTimePickerEnd);
            this.PanelDate.Location = new System.Drawing.Point(521, 440);
            this.PanelDate.Name = "PanelDate";
            this.PanelDate.Size = new System.Drawing.Size(463, 80);
            this.PanelDate.TabIndex = 30;
            // 
            // RadioButtonPersonalize
            // 
            this.RadioButtonPersonalize.AutoSize = true;
            this.RadioButtonPersonalize.Dock = System.Windows.Forms.DockStyle.Left;
            this.RadioButtonPersonalize.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.RadioButtonPersonalize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(32)))));
            this.RadioButtonPersonalize.Location = new System.Drawing.Point(681, 22);
            this.RadioButtonPersonalize.Name = "RadioButtonPersonalize";
            this.RadioButtonPersonalize.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.RadioButtonPersonalize.Size = new System.Drawing.Size(133, 33);
            this.RadioButtonPersonalize.TabIndex = 16;
            this.RadioButtonPersonalize.TabStop = true;
            this.RadioButtonPersonalize.Text = "Personalizada";
            this.RadioButtonPersonalize.UseVisualStyleBackColor = true;
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 698);
            this.Controls.Add(this.PanelDate);
            this.Controls.Add(this.ButtonCreateReport);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.GroupBoxDateTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PanelBorder3);
            this.Controls.Add(this.PanelBorder2);
            this.Controls.Add(this.PanelBorder1);
            this.Controls.Add(this.CheckBoxService7);
            this.Controls.Add(this.CheckBoxService6);
            this.Controls.Add(this.CheckBoxService5);
            this.Controls.Add(this.CheckBoxService4);
            this.Controls.Add(this.CheckBoxService3);
            this.Controls.Add(this.CheckBoxService2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CheckBoxService1);
            this.Controls.Add(this.GroupBoxSex);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LabelComboSearch);
            this.Name = "Reports";
            this.Text = "Reports";
            this.Controls.SetChildIndex(this.LabelComboSearch, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.GroupBoxSex, 0);
            this.Controls.SetChildIndex(this.CheckBoxService1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.CheckBoxService2, 0);
            this.Controls.SetChildIndex(this.CheckBoxService3, 0);
            this.Controls.SetChildIndex(this.CheckBoxService4, 0);
            this.Controls.SetChildIndex(this.CheckBoxService5, 0);
            this.Controls.SetChildIndex(this.CheckBoxService6, 0);
            this.Controls.SetChildIndex(this.CheckBoxService7, 0);
            this.Controls.SetChildIndex(this.PanelBorder1, 0);
            this.Controls.SetChildIndex(this.PanelBorder2, 0);
            this.Controls.SetChildIndex(this.PanelBorder3, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.GroupBoxDateTime, 0);
            this.Controls.SetChildIndex(this.PanelInfo, 0);
            this.Controls.SetChildIndex(this.ButtonCancel, 0);
            this.Controls.SetChildIndex(this.ButtonCreateReport, 0);
            this.Controls.SetChildIndex(this.PanelDate, 0);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxInfo)).EndInit();
            this.PanelInfo.ResumeLayout(false);
            this.PanelInfo.PerformLayout();
            this.GroupBoxSex.ResumeLayout(false);
            this.GroupBoxSex.PerformLayout();
            this.GroupBoxDateTime.ResumeLayout(false);
            this.GroupBoxDateTime.PerformLayout();
            this.PanelDate.ResumeLayout(false);
            this.PanelDate.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelComboSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox GroupBoxSex;
        private System.Windows.Forms.RadioButton RadioButtonMan;
        private System.Windows.Forms.RadioButton RadioButtonWoman;
        private System.Windows.Forms.RadioButton RadioButtonBothSex;
        private System.Windows.Forms.CheckBox CheckBoxService1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox CheckBoxService2;
        private System.Windows.Forms.CheckBox CheckBoxService3;
        private System.Windows.Forms.CheckBox CheckBoxService4;
        private System.Windows.Forms.CheckBox CheckBoxService5;
        private System.Windows.Forms.CheckBox CheckBoxService6;
        private System.Windows.Forms.CheckBox CheckBoxService7;
        private System.Windows.Forms.Panel PanelBorder1;
        private System.Windows.Forms.Panel PanelBorder2;
        private System.Windows.Forms.Panel PanelBorder3;
        private System.Windows.Forms.DateTimePicker DateTimePickerStart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox GroupBoxDateTime;
        private System.Windows.Forms.RadioButton RadioButtonMonth;
        private System.Windows.Forms.RadioButton RadioButtonWeek;
        private System.Windows.Forms.RadioButton RadioButtonToday;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker DateTimePickerEnd;
        private System.Windows.Forms.RadioButton RadioButtonYear;
        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.Button ButtonCreateReport;
        private System.Windows.Forms.Panel PanelDate;
        private System.Windows.Forms.RadioButton RadioButtonAll;
        private System.Windows.Forms.RadioButton RadioButtonPersonalize;
    }
}