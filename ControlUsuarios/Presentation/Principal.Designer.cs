namespace Presentation
{
    partial class Principal
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.PanelHeader = new System.Windows.Forms.Panel();
            this.LabelSubTitle = new System.Windows.Forms.Label();
            this.LabelTitle = new System.Windows.Forms.Label();
            this.TimerSlideEnter = new System.Windows.Forms.Timer(this.components);
            this.TimerSlideLeave = new System.Windows.Forms.Timer(this.components);
            this.PanelCanvas = new System.Windows.Forms.Panel();
            this.PanelContent = new System.Windows.Forms.Panel();
            this.ButtonLogOut = new System.Windows.Forms.Button();
            this.ButtonConfiguration = new System.Windows.Forms.Button();
            this.ButtonBinnacle = new System.Windows.Forms.Button();
            this.ButtonStats = new System.Windows.Forms.Button();
            this.ButtonMoves = new System.Windows.Forms.Button();
            this.ButtonUsers = new System.Windows.Forms.Button();
            this.PictureIcon = new System.Windows.Forms.PictureBox();
            this.PictureMinimize = new System.Windows.Forms.PictureBox();
            this.PictureClose = new System.Windows.Forms.PictureBox();
            this.PanelHeader.SuspendLayout();
            this.PanelCanvas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureClose)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelHeader
            // 
            this.PanelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(32)))));
            this.PanelHeader.Controls.Add(this.PictureIcon);
            this.PanelHeader.Controls.Add(this.PictureMinimize);
            this.PanelHeader.Controls.Add(this.LabelSubTitle);
            this.PanelHeader.Controls.Add(this.PictureClose);
            this.PanelHeader.Controls.Add(this.LabelTitle);
            this.PanelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelHeader.Location = new System.Drawing.Point(0, 0);
            this.PanelHeader.Margin = new System.Windows.Forms.Padding(0);
            this.PanelHeader.Name = "PanelHeader";
            this.PanelHeader.Size = new System.Drawing.Size(1152, 70);
            this.PanelHeader.TabIndex = 0;
            // 
            // LabelSubTitle
            // 
            this.LabelSubTitle.AutoSize = true;
            this.LabelSubTitle.Font = new System.Drawing.Font("Arial Narrow", 16F);
            this.LabelSubTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.LabelSubTitle.Location = new System.Drawing.Point(302, 26);
            this.LabelSubTitle.Name = "LabelSubTitle";
            this.LabelSubTitle.Size = new System.Drawing.Size(480, 26);
            this.LabelSubTitle.TabIndex = 1;
            this.LabelSubTitle.Text = "Centro de información del Instituto Tecnológico de Delicias";
            // 
            // LabelTitle
            // 
            this.LabelTitle.AutoSize = true;
            this.LabelTitle.Font = new System.Drawing.Font("Arial Narrow", 22F);
            this.LabelTitle.ForeColor = System.Drawing.Color.White;
            this.LabelTitle.Location = new System.Drawing.Point(62, 17);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(234, 35);
            this.LabelTitle.TabIndex = 0;
            this.LabelTitle.Text = "Control de Usuarios";
            // 
            // TimerSlideEnter
            // 
            this.TimerSlideEnter.Interval = 5;
            this.TimerSlideEnter.Tick += new System.EventHandler(this.TimerEnterSlideEffectMethod);
            // 
            // TimerSlideLeave
            // 
            this.TimerSlideLeave.Interval = 5;
            this.TimerSlideLeave.Tick += new System.EventHandler(this.TimerLeaveSlideEffectMethod);
            // 
            // PanelCanvas
            // 
            this.PanelCanvas.Controls.Add(this.ButtonLogOut);
            this.PanelCanvas.Controls.Add(this.ButtonConfiguration);
            this.PanelCanvas.Controls.Add(this.ButtonBinnacle);
            this.PanelCanvas.Controls.Add(this.ButtonStats);
            this.PanelCanvas.Controls.Add(this.ButtonMoves);
            this.PanelCanvas.Controls.Add(this.ButtonUsers);
            this.PanelCanvas.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelCanvas.Location = new System.Drawing.Point(0, 70);
            this.PanelCanvas.Name = "PanelCanvas";
            this.PanelCanvas.Size = new System.Drawing.Size(90, 698);
            this.PanelCanvas.TabIndex = 9;
            this.PanelCanvas.MouseEnter += new System.EventHandler(this.MouseEnterTimerSlide);
            this.PanelCanvas.MouseLeave += new System.EventHandler(this.MouseLeaveTimerSlide);
            // 
            // PanelContent
            // 
            this.PanelContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(205)))), ((int)(((byte)(203)))));
            this.PanelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContent.Location = new System.Drawing.Point(90, 70);
            this.PanelContent.Margin = new System.Windows.Forms.Padding(0);
            this.PanelContent.Name = "PanelContent";
            this.PanelContent.Size = new System.Drawing.Size(1062, 698);
            this.PanelContent.TabIndex = 10;
            // 
            // ButtonLogOut
            // 
            this.ButtonLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonLogOut.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonLogOut.FlatAppearance.BorderSize = 0;
            this.ButtonLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonLogOut.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.ButtonLogOut.ForeColor = System.Drawing.Color.White;
            this.ButtonLogOut.Image = global::Presentation.Properties.Resources.LogOutWhite;
            this.ButtonLogOut.Location = new System.Drawing.Point(0, 270);
            this.ButtonLogOut.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonLogOut.Name = "ButtonLogOut";
            this.ButtonLogOut.Size = new System.Drawing.Size(90, 54);
            this.ButtonLogOut.TabIndex = 9;
            this.ButtonLogOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonLogOut.UseVisualStyleBackColor = true;
            // 
            // ButtonConfiguration
            // 
            this.ButtonConfiguration.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonConfiguration.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonConfiguration.FlatAppearance.BorderSize = 0;
            this.ButtonConfiguration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonConfiguration.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.ButtonConfiguration.ForeColor = System.Drawing.Color.White;
            this.ButtonConfiguration.Image = global::Presentation.Properties.Resources.ConfigWhite;
            this.ButtonConfiguration.Location = new System.Drawing.Point(0, 216);
            this.ButtonConfiguration.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonConfiguration.Name = "ButtonConfiguration";
            this.ButtonConfiguration.Size = new System.Drawing.Size(90, 54);
            this.ButtonConfiguration.TabIndex = 8;
            this.ButtonConfiguration.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonConfiguration.UseVisualStyleBackColor = true;
            this.ButtonConfiguration.Click += new System.EventHandler(this.ClickMethod);
            this.ButtonConfiguration.MouseEnter += new System.EventHandler(this.MouseEnterTimerSlide);
            this.ButtonConfiguration.MouseLeave += new System.EventHandler(this.MouseLeaveTimerSlide);
            // 
            // ButtonBinnacle
            // 
            this.ButtonBinnacle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonBinnacle.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonBinnacle.FlatAppearance.BorderSize = 0;
            this.ButtonBinnacle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonBinnacle.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.ButtonBinnacle.ForeColor = System.Drawing.Color.White;
            this.ButtonBinnacle.Image = global::Presentation.Properties.Resources.BinnacleWhite;
            this.ButtonBinnacle.Location = new System.Drawing.Point(0, 162);
            this.ButtonBinnacle.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonBinnacle.Name = "ButtonBinnacle";
            this.ButtonBinnacle.Size = new System.Drawing.Size(90, 54);
            this.ButtonBinnacle.TabIndex = 4;
            this.ButtonBinnacle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonBinnacle.UseVisualStyleBackColor = true;
            this.ButtonBinnacle.Click += new System.EventHandler(this.ClickMethod);
            this.ButtonBinnacle.MouseEnter += new System.EventHandler(this.MouseEnterTimerSlide);
            this.ButtonBinnacle.MouseLeave += new System.EventHandler(this.MouseLeaveTimerSlide);
            // 
            // ButtonStats
            // 
            this.ButtonStats.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonStats.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonStats.FlatAppearance.BorderSize = 0;
            this.ButtonStats.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonStats.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.ButtonStats.ForeColor = System.Drawing.Color.White;
            this.ButtonStats.Image = global::Presentation.Properties.Resources.StatsWhite;
            this.ButtonStats.Location = new System.Drawing.Point(0, 108);
            this.ButtonStats.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonStats.Name = "ButtonStats";
            this.ButtonStats.Size = new System.Drawing.Size(90, 54);
            this.ButtonStats.TabIndex = 5;
            this.ButtonStats.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonStats.UseVisualStyleBackColor = true;
            this.ButtonStats.Click += new System.EventHandler(this.ClickMethod);
            this.ButtonStats.MouseEnter += new System.EventHandler(this.MouseEnterTimerSlide);
            this.ButtonStats.MouseLeave += new System.EventHandler(this.MouseLeaveTimerSlide);
            // 
            // ButtonMoves
            // 
            this.ButtonMoves.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonMoves.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonMoves.FlatAppearance.BorderSize = 0;
            this.ButtonMoves.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonMoves.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.ButtonMoves.ForeColor = System.Drawing.Color.White;
            this.ButtonMoves.Image = global::Presentation.Properties.Resources.MovesWhite;
            this.ButtonMoves.Location = new System.Drawing.Point(0, 54);
            this.ButtonMoves.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonMoves.Name = "ButtonMoves";
            this.ButtonMoves.Size = new System.Drawing.Size(90, 54);
            this.ButtonMoves.TabIndex = 6;
            this.ButtonMoves.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonMoves.UseVisualStyleBackColor = true;
            this.ButtonMoves.Click += new System.EventHandler(this.ClickMethod);
            this.ButtonMoves.MouseEnter += new System.EventHandler(this.MouseEnterTimerSlide);
            this.ButtonMoves.MouseLeave += new System.EventHandler(this.MouseLeaveTimerSlide);
            // 
            // ButtonUsers
            // 
            this.ButtonUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonUsers.FlatAppearance.BorderSize = 0;
            this.ButtonUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonUsers.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.ButtonUsers.ForeColor = System.Drawing.Color.White;
            this.ButtonUsers.Image = global::Presentation.Properties.Resources.UsersWhite;
            this.ButtonUsers.Location = new System.Drawing.Point(0, 0);
            this.ButtonUsers.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonUsers.Name = "ButtonUsers";
            this.ButtonUsers.Size = new System.Drawing.Size(90, 54);
            this.ButtonUsers.TabIndex = 3;
            this.ButtonUsers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonUsers.UseVisualStyleBackColor = true;
            this.ButtonUsers.Click += new System.EventHandler(this.ClickMethod);
            this.ButtonUsers.MouseEnter += new System.EventHandler(this.MouseEnterTimerSlide);
            this.ButtonUsers.MouseLeave += new System.EventHandler(this.MouseLeaveTimerSlide);
            // 
            // PictureIcon
            // 
            this.PictureIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureIcon.Image = global::Presentation.Properties.Resources.IconProgram;
            this.PictureIcon.Location = new System.Drawing.Point(12, 12);
            this.PictureIcon.Name = "PictureIcon";
            this.PictureIcon.Size = new System.Drawing.Size(44, 44);
            this.PictureIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureIcon.TabIndex = 2;
            this.PictureIcon.TabStop = false;
            // 
            // PictureMinimize
            // 
            this.PictureMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PictureMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureMinimize.Image = ((System.Drawing.Image)(resources.GetObject("PictureMinimize.Image")));
            this.PictureMinimize.Location = new System.Drawing.Point(1070, 12);
            this.PictureMinimize.Name = "PictureMinimize";
            this.PictureMinimize.Size = new System.Drawing.Size(32, 32);
            this.PictureMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureMinimize.TabIndex = 1;
            this.PictureMinimize.TabStop = false;
            this.PictureMinimize.Click += new System.EventHandler(this.PictureClickMethod);
            // 
            // PictureClose
            // 
            this.PictureClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PictureClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureClose.Image = global::Presentation.Properties.Resources.CloseWindowWhite;
            this.PictureClose.Location = new System.Drawing.Point(1108, 12);
            this.PictureClose.Name = "PictureClose";
            this.PictureClose.Size = new System.Drawing.Size(32, 32);
            this.PictureClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureClose.TabIndex = 0;
            this.PictureClose.TabStop = false;
            this.PictureClose.Click += new System.EventHandler(this.PictureClickMethod);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(1152, 768);
            this.Controls.Add(this.PanelContent);
            this.Controls.Add(this.PanelCanvas);
            this.Controls.Add(this.PanelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control de Usuarios";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormClosingMethod);
            this.PanelHeader.ResumeLayout(false);
            this.PanelHeader.PerformLayout();
            this.PanelCanvas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelHeader;
        private System.Windows.Forms.PictureBox PictureClose;
        private System.Windows.Forms.PictureBox PictureMinimize;
        private System.Windows.Forms.Button ButtonUsers;
        private System.Windows.Forms.Button ButtonBinnacle;
        private System.Windows.Forms.Button ButtonStats;
        private System.Windows.Forms.Button ButtonMoves;
        private System.Windows.Forms.PictureBox PictureIcon;
        private System.Windows.Forms.Label LabelSubTitle;
        private System.Windows.Forms.Label LabelTitle;
        private System.Windows.Forms.Button ButtonConfiguration;
        private System.Windows.Forms.Timer TimerSlideEnter;
        private System.Windows.Forms.Timer TimerSlideLeave;
        private System.Windows.Forms.Panel PanelCanvas;
        private System.Windows.Forms.Panel PanelContent;
        private System.Windows.Forms.Button ButtonLogOut;
    }
}

