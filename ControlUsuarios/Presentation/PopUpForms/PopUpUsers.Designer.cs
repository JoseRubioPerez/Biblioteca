namespace Presentation.PopUpForms
{
    partial class PopUpUsers
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ComboDepartmentCareer = new System.Windows.Forms.ComboBox();
            this.RadioButtonMan = new System.Windows.Forms.RadioButton();
            this.RadioButtonWoman = new System.Windows.Forms.RadioButton();
            this.RadioButtonActive = new System.Windows.Forms.RadioButton();
            this.RadioButtonDisable = new System.Windows.Forms.RadioButton();
            this.TextBoxNumControl = new System.Windows.Forms.TextBox();
            this.TextBoxFirstName = new System.Windows.Forms.TextBox();
            this.TextBoxSecondName = new System.Windows.Forms.TextBox();
            this.TextBoxLastName2 = new System.Windows.Forms.TextBox();
            this.TextBoxLastName = new System.Windows.Forms.TextBox();
            this.GroupBoxSex = new System.Windows.Forms.GroupBox();
            this.GroupBoxStatus = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureIcon)).BeginInit();
            this.PanelContent.SuspendLayout();
            this.GroupBoxSex.SuspendLayout();
            this.GroupBoxStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelBorder1
            // 
            this.PanelBorder1.Size = new System.Drawing.Size(950, 3);
            // 
            // ButtonAccept
            // 
            this.ButtonAccept.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(32)))));
            this.ButtonAccept.FlatAppearance.BorderSize = 3;
            this.ButtonAccept.Location = new System.Drawing.Point(669, 378);
            this.ButtonAccept.TabStop = false;
            this.ButtonAccept.Click += new System.EventHandler(this.ControlClickMethod);
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(32)))));
            this.ButtonCancel.FlatAppearance.BorderSize = 3;
            this.ButtonCancel.Location = new System.Drawing.Point(838, 378);
            this.ButtonCancel.TabStop = false;
            this.ButtonCancel.Click += new System.EventHandler(this.ControlClickMethod);
            // 
            // PanelContent
            // 
            this.PanelContent.Controls.Add(this.GroupBoxStatus);
            this.PanelContent.Controls.Add(this.GroupBoxSex);
            this.PanelContent.Controls.Add(this.TextBoxLastName2);
            this.PanelContent.Controls.Add(this.TextBoxLastName);
            this.PanelContent.Controls.Add(this.TextBoxSecondName);
            this.PanelContent.Controls.Add(this.TextBoxFirstName);
            this.PanelContent.Controls.Add(this.TextBoxNumControl);
            this.PanelContent.Controls.Add(this.ComboDepartmentCareer);
            this.PanelContent.Controls.Add(this.label8);
            this.PanelContent.Controls.Add(this.label7);
            this.PanelContent.Controls.Add(this.label6);
            this.PanelContent.Controls.Add(this.label5);
            this.PanelContent.Controls.Add(this.label4);
            this.PanelContent.Controls.Add(this.label3);
            this.PanelContent.Controls.Add(this.label2);
            this.PanelContent.Controls.Add(this.label1);
            this.PanelContent.Size = new System.Drawing.Size(998, 437);
            this.PanelContent.Controls.SetChildIndex(this.LabelComboSearch, 0);
            this.PanelContent.Controls.SetChildIndex(this.ButtonAccept, 0);
            this.PanelContent.Controls.SetChildIndex(this.PanelBorder1, 0);
            this.PanelContent.Controls.SetChildIndex(this.ButtonCancel, 0);
            this.PanelContent.Controls.SetChildIndex(this.label1, 0);
            this.PanelContent.Controls.SetChildIndex(this.label2, 0);
            this.PanelContent.Controls.SetChildIndex(this.label3, 0);
            this.PanelContent.Controls.SetChildIndex(this.label4, 0);
            this.PanelContent.Controls.SetChildIndex(this.label5, 0);
            this.PanelContent.Controls.SetChildIndex(this.label6, 0);
            this.PanelContent.Controls.SetChildIndex(this.label7, 0);
            this.PanelContent.Controls.SetChildIndex(this.label8, 0);
            this.PanelContent.Controls.SetChildIndex(this.ComboDepartmentCareer, 0);
            this.PanelContent.Controls.SetChildIndex(this.TextBoxNumControl, 0);
            this.PanelContent.Controls.SetChildIndex(this.TextBoxFirstName, 0);
            this.PanelContent.Controls.SetChildIndex(this.TextBoxSecondName, 0);
            this.PanelContent.Controls.SetChildIndex(this.TextBoxLastName, 0);
            this.PanelContent.Controls.SetChildIndex(this.TextBoxLastName2, 0);
            this.PanelContent.Controls.SetChildIndex(this.GroupBoxSex, 0);
            this.PanelContent.Controls.SetChildIndex(this.GroupBoxStatus, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(32)))));
            this.label1.Location = new System.Drawing.Point(37, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 23);
            this.label1.TabIndex = 10;
            this.label1.Text = "Número de Control:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(32)))));
            this.label2.Location = new System.Drawing.Point(37, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 23);
            this.label2.TabIndex = 11;
            this.label2.Text = "Primer Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(32)))));
            this.label3.Location = new System.Drawing.Point(495, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 23);
            this.label3.TabIndex = 12;
            this.label3.Text = "Segundo Nombre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(32)))));
            this.label4.Location = new System.Drawing.Point(37, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 23);
            this.label4.TabIndex = 13;
            this.label4.Text = "Primer Apellido:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(32)))));
            this.label5.Location = new System.Drawing.Point(495, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 23);
            this.label5.TabIndex = 14;
            this.label5.Text = "Segundo Apellido:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(32)))));
            this.label6.Location = new System.Drawing.Point(37, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 23);
            this.label6.TabIndex = 15;
            this.label6.Text = "Departamento:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(32)))));
            this.label7.Location = new System.Drawing.Point(37, 284);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 23);
            this.label7.TabIndex = 16;
            this.label7.Text = "Sexo:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(32)))));
            this.label8.Location = new System.Drawing.Point(37, 341);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 23);
            this.label8.TabIndex = 17;
            this.label8.Text = "Status:";
            // 
            // ComboDepartmentCareer
            // 
            this.ComboDepartmentCareer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ComboDepartmentCareer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboDepartmentCareer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ComboDepartmentCareer.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.ComboDepartmentCareer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(32)))));
            this.ComboDepartmentCareer.FormattingEnabled = true;
            this.ComboDepartmentCareer.Location = new System.Drawing.Point(154, 223);
            this.ComboDepartmentCareer.Name = "ComboDepartmentCareer";
            this.ComboDepartmentCareer.Size = new System.Drawing.Size(328, 31);
            this.ComboDepartmentCareer.TabIndex = 6;
            // 
            // RadioButtonMan
            // 
            this.RadioButtonMan.AutoSize = true;
            this.RadioButtonMan.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.RadioButtonMan.Location = new System.Drawing.Point(6, 20);
            this.RadioButtonMan.Name = "RadioButtonMan";
            this.RadioButtonMan.Size = new System.Drawing.Size(84, 27);
            this.RadioButtonMan.TabIndex = 19;
            this.RadioButtonMan.TabStop = true;
            this.RadioButtonMan.Text = "Hombre";
            this.RadioButtonMan.UseVisualStyleBackColor = true;
            this.RadioButtonMan.Click += new System.EventHandler(this.ControlClickMethod);
            // 
            // RadioButtonWoman
            // 
            this.RadioButtonWoman.AutoSize = true;
            this.RadioButtonWoman.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.RadioButtonWoman.Location = new System.Drawing.Point(96, 20);
            this.RadioButtonWoman.Name = "RadioButtonWoman";
            this.RadioButtonWoman.Size = new System.Drawing.Size(67, 27);
            this.RadioButtonWoman.TabIndex = 20;
            this.RadioButtonWoman.TabStop = true;
            this.RadioButtonWoman.Text = "Mujer";
            this.RadioButtonWoman.UseVisualStyleBackColor = true;
            this.RadioButtonWoman.Click += new System.EventHandler(this.ControlClickMethod);
            // 
            // RadioButtonActive
            // 
            this.RadioButtonActive.AutoSize = true;
            this.RadioButtonActive.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.RadioButtonActive.Location = new System.Drawing.Point(6, 20);
            this.RadioButtonActive.Name = "RadioButtonActive";
            this.RadioButtonActive.Size = new System.Drawing.Size(68, 27);
            this.RadioButtonActive.TabIndex = 21;
            this.RadioButtonActive.TabStop = true;
            this.RadioButtonActive.Text = "Activo";
            this.RadioButtonActive.UseVisualStyleBackColor = true;
            this.RadioButtonActive.Click += new System.EventHandler(this.ControlClickMethod);
            // 
            // RadioButtonDisable
            // 
            this.RadioButtonDisable.AutoSize = true;
            this.RadioButtonDisable.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.RadioButtonDisable.Location = new System.Drawing.Point(80, 20);
            this.RadioButtonDisable.Name = "RadioButtonDisable";
            this.RadioButtonDisable.Size = new System.Drawing.Size(79, 27);
            this.RadioButtonDisable.TabIndex = 22;
            this.RadioButtonDisable.TabStop = true;
            this.RadioButtonDisable.Text = "Inactivo";
            this.RadioButtonDisable.UseVisualStyleBackColor = true;
            this.RadioButtonDisable.Click += new System.EventHandler(this.ControlClickMethod);
            // 
            // TextBoxNumControl
            // 
            this.TextBoxNumControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxNumControl.Enabled = false;
            this.TextBoxNumControl.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.TextBoxNumControl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(32)))));
            this.TextBoxNumControl.Location = new System.Drawing.Point(188, 84);
            this.TextBoxNumControl.Name = "TextBoxNumControl";
            this.TextBoxNumControl.Size = new System.Drawing.Size(293, 29);
            this.TextBoxNumControl.TabIndex = 1;
            // 
            // TextBoxFirstName
            // 
            this.TextBoxFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxFirstName.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.TextBoxFirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(32)))));
            this.TextBoxFirstName.Location = new System.Drawing.Point(162, 131);
            this.TextBoxFirstName.Name = "TextBoxFirstName";
            this.TextBoxFirstName.Size = new System.Drawing.Size(320, 29);
            this.TextBoxFirstName.TabIndex = 2;
            // 
            // TextBoxSecondName
            // 
            this.TextBoxSecondName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxSecondName.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.TextBoxSecondName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(32)))));
            this.TextBoxSecondName.Location = new System.Drawing.Point(639, 131);
            this.TextBoxSecondName.Name = "TextBoxSecondName";
            this.TextBoxSecondName.Size = new System.Drawing.Size(320, 29);
            this.TextBoxSecondName.TabIndex = 3;
            // 
            // TextBoxLastName2
            // 
            this.TextBoxLastName2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxLastName2.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.TextBoxLastName2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(32)))));
            this.TextBoxLastName2.Location = new System.Drawing.Point(639, 178);
            this.TextBoxLastName2.Name = "TextBoxLastName2";
            this.TextBoxLastName2.Size = new System.Drawing.Size(320, 29);
            this.TextBoxLastName2.TabIndex = 5;
            // 
            // TextBoxLastName
            // 
            this.TextBoxLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxLastName.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.TextBoxLastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(32)))));
            this.TextBoxLastName.Location = new System.Drawing.Point(161, 178);
            this.TextBoxLastName.Name = "TextBoxLastName";
            this.TextBoxLastName.Size = new System.Drawing.Size(320, 29);
            this.TextBoxLastName.TabIndex = 4;
            // 
            // GroupBoxSex
            // 
            this.GroupBoxSex.Controls.Add(this.RadioButtonMan);
            this.GroupBoxSex.Controls.Add(this.RadioButtonWoman);
            this.GroupBoxSex.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GroupBoxSex.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.GroupBoxSex.Location = new System.Drawing.Point(104, 262);
            this.GroupBoxSex.Name = "GroupBoxSex";
            this.GroupBoxSex.Size = new System.Drawing.Size(183, 53);
            this.GroupBoxSex.TabIndex = 23;
            this.GroupBoxSex.TabStop = false;
            // 
            // GroupBoxStatus
            // 
            this.GroupBoxStatus.Controls.Add(this.RadioButtonActive);
            this.GroupBoxStatus.Controls.Add(this.RadioButtonDisable);
            this.GroupBoxStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GroupBoxStatus.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.GroupBoxStatus.Location = new System.Drawing.Point(104, 321);
            this.GroupBoxStatus.Name = "GroupBoxStatus";
            this.GroupBoxStatus.Size = new System.Drawing.Size(182, 53);
            this.GroupBoxStatus.TabIndex = 24;
            this.GroupBoxStatus.TabStop = false;
            // 
            // PopUpUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 519);
            this.Name = "PopUpUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PopUpUsers";
            ((System.ComponentModel.ISupportInitialize)(this.PictureIcon)).EndInit();
            this.PanelContent.ResumeLayout(false);
            this.PanelContent.PerformLayout();
            this.GroupBoxSex.ResumeLayout(false);
            this.GroupBoxSex.PerformLayout();
            this.GroupBoxStatus.ResumeLayout(false);
            this.GroupBoxStatus.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.ComboBox ComboDepartmentCareer;
        private System.Windows.Forms.TextBox TextBoxNumControl;
        private System.Windows.Forms.RadioButton RadioButtonDisable;
        private System.Windows.Forms.RadioButton RadioButtonActive;
        private System.Windows.Forms.RadioButton RadioButtonWoman;
        private System.Windows.Forms.RadioButton RadioButtonMan;
        private System.Windows.Forms.TextBox TextBoxSecondName;
        private System.Windows.Forms.TextBox TextBoxFirstName;
        private System.Windows.Forms.TextBox TextBoxLastName2;
        private System.Windows.Forms.TextBox TextBoxLastName;
        private System.Windows.Forms.GroupBox GroupBoxStatus;
        private System.Windows.Forms.GroupBox GroupBoxSex;
    }
}