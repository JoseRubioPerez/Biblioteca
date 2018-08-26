namespace Application
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelVentana = new System.Windows.Forms.Panel();
            this.panelContenido = new System.Windows.Forms.Panel();
            this.panelMenuStrip = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.usuariosMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.MovimientosMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.configuracionMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.AgregarAdminMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CambiarMiContraMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CambiarOtraContraMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.pictureIcon = new System.Windows.Forms.PictureBox();
            this.pictureMinimize = new System.Windows.Forms.PictureBox();
            this.pictureClose = new System.Windows.Forms.PictureBox();
            this.ImportarAlumnosMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ImportarEmpleadosMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ImportarUsuariosMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelMain.SuspendLayout();
            this.panelVentana.SuspendLayout();
            this.panelMenuStrip.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureClose)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(43)))), ((int)(((byte)(73)))));
            this.panelMain.Controls.Add(this.panelVentana);
            this.panelMain.Controls.Add(this.lbTitulo);
            this.panelMain.Controls.Add(this.pictureIcon);
            this.panelMain.Controls.Add(this.pictureMinimize);
            this.panelMain.Controls.Add(this.pictureClose);
            this.panelMain.Location = new System.Drawing.Point(10, 10);
            this.panelMain.Margin = new System.Windows.Forms.Padding(1);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1140, 611);
            this.panelMain.TabIndex = 0;
            // 
            // panelVentana
            // 
            this.panelVentana.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelVentana.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(223)))), ((int)(((byte)(198)))));
            this.panelVentana.Controls.Add(this.panelContenido);
            this.panelVentana.Controls.Add(this.panelMenuStrip);
            this.panelVentana.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.panelVentana.Location = new System.Drawing.Point(0, 45);
            this.panelVentana.Name = "panelVentana";
            this.panelVentana.Size = new System.Drawing.Size(1140, 566);
            this.panelVentana.TabIndex = 4;
            // 
            // panelContenido
            // 
            this.panelContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(5)))));
            this.panelContenido.Location = new System.Drawing.Point(0, 59);
            this.panelContenido.Name = "panelContenido";
            this.panelContenido.Size = new System.Drawing.Size(1140, 507);
            this.panelContenido.TabIndex = 1;
            // 
            // panelMenuStrip
            // 
            this.panelMenuStrip.Controls.Add(this.menuStrip1);
            this.panelMenuStrip.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.panelMenuStrip.MaximumSize = new System.Drawing.Size(0, 59);
            this.panelMenuStrip.MinimumSize = new System.Drawing.Size(0, 59);
            this.panelMenuStrip.Name = "panelMenuStrip";
            this.panelMenuStrip.Size = new System.Drawing.Size(1140, 59);
            this.panelMenuStrip.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(43)))), ((int)(((byte)(73)))));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuariosMenu,
            this.MovimientosMenu,
            this.reportesMenu,
            this.configuracionMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1140, 59);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // usuariosMenu
            // 
            this.usuariosMenu.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuariosMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(223)))), ((int)(((byte)(198)))));
            this.usuariosMenu.Image = global::Application.Properties.Resources.group_users;
            this.usuariosMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.usuariosMenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.usuariosMenu.Name = "usuariosMenu";
            this.usuariosMenu.Size = new System.Drawing.Size(139, 55);
            this.usuariosMenu.Text = "Usuarios";
            this.usuariosMenu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.usuariosMenu.Click += new System.EventHandler(this.EventoClickMenuItem);
            this.usuariosMenu.MouseEnter += new System.EventHandler(this.CambiarColorMenuItem);
            this.usuariosMenu.MouseLeave += new System.EventHandler(this.ResetColorMenuItem);
            // 
            // MovimientosMenu
            // 
            this.MovimientosMenu.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.MovimientosMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(223)))), ((int)(((byte)(198)))));
            this.MovimientosMenu.Image = global::Application.Properties.Resources.moves;
            this.MovimientosMenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MovimientosMenu.Name = "MovimientosMenu";
            this.MovimientosMenu.Size = new System.Drawing.Size(262, 55);
            this.MovimientosMenu.Text = "Movimiento de usuarios";
            this.MovimientosMenu.Click += new System.EventHandler(this.EventoClickMenuItem);
            this.MovimientosMenu.MouseEnter += new System.EventHandler(this.CambiarColorMenuItem);
            this.MovimientosMenu.MouseLeave += new System.EventHandler(this.ResetColorMenuItem);
            // 
            // reportesMenu
            // 
            this.reportesMenu.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportesMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(223)))), ((int)(((byte)(198)))));
            this.reportesMenu.Image = global::Application.Properties.Resources.chart;
            this.reportesMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reportesMenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.reportesMenu.Name = "reportesMenu";
            this.reportesMenu.Size = new System.Drawing.Size(143, 55);
            this.reportesMenu.Text = "Reportes";
            this.reportesMenu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.reportesMenu.Click += new System.EventHandler(this.EventoClickMenuItem);
            this.reportesMenu.MouseEnter += new System.EventHandler(this.CambiarColorMenuItem);
            this.reportesMenu.MouseLeave += new System.EventHandler(this.ResetColorMenuItem);
            // 
            // configuracionMenu
            // 
            this.configuracionMenu.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.configuracionMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ImportarUsuariosMenuItem,
            this.AgregarAdminMenuItem,
            this.CambiarMiContraMenuItem,
            this.CambiarOtraContraMenuItem});
            this.configuracionMenu.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.configuracionMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(223)))), ((int)(((byte)(198)))));
            this.configuracionMenu.Image = global::Application.Properties.Resources.config;
            this.configuracionMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.configuracionMenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.configuracionMenu.Name = "configuracionMenu";
            this.configuracionMenu.Size = new System.Drawing.Size(181, 55);
            this.configuracionMenu.Text = "Configuración";
            this.configuracionMenu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.configuracionMenu.MouseEnter += new System.EventHandler(this.CambiarColorMenuItem);
            this.configuracionMenu.MouseLeave += new System.EventHandler(this.ResetColorMenuItem);
            // 
            // AgregarAdminMenuItem
            // 
            this.AgregarAdminMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.AgregarAdminMenuItem.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgregarAdminMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.AgregarAdminMenuItem.Name = "AgregarAdminMenuItem";
            this.AgregarAdminMenuItem.Size = new System.Drawing.Size(336, 22);
            this.AgregarAdminMenuItem.Text = "Agregar, editar o eliminar administrador";
            this.AgregarAdminMenuItem.Click += new System.EventHandler(this.EventoClickMenuItem);
            // 
            // CambiarMiContraMenuItem
            // 
            this.CambiarMiContraMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.CambiarMiContraMenuItem.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.CambiarMiContraMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.CambiarMiContraMenuItem.Name = "CambiarMiContraMenuItem";
            this.CambiarMiContraMenuItem.Size = new System.Drawing.Size(336, 22);
            this.CambiarMiContraMenuItem.Text = "Cambiar mi contraseña";
            this.CambiarMiContraMenuItem.Click += new System.EventHandler(this.EventoClickMenuItem);
            // 
            // CambiarOtraContraMenuItem
            // 
            this.CambiarOtraContraMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.CambiarOtraContraMenuItem.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.CambiarOtraContraMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.CambiarOtraContraMenuItem.Name = "CambiarOtraContraMenuItem";
            this.CambiarOtraContraMenuItem.Size = new System.Drawing.Size(336, 22);
            this.CambiarOtraContraMenuItem.Text = "Cambiar contraseña de otro administrador";
            this.CambiarOtraContraMenuItem.Click += new System.EventHandler(this.EventoClickMenuItem);
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.Location = new System.Drawing.Point(45, 12);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(241, 18);
            this.lbTitulo.TabIndex = 3;
            this.lbTitulo.Text = "Sistema de Control de Usuarios";
            this.lbTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureIcon
            // 
            this.pictureIcon.Image = global::Application.Properties.Resources.group_users;
            this.pictureIcon.Location = new System.Drawing.Point(3, 3);
            this.pictureIcon.Name = "pictureIcon";
            this.pictureIcon.Size = new System.Drawing.Size(36, 36);
            this.pictureIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureIcon.TabIndex = 2;
            this.pictureIcon.TabStop = false;
            // 
            // pictureMinimize
            // 
            this.pictureMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureMinimize.Image = global::Application.Properties.Resources.minimize;
            this.pictureMinimize.Location = new System.Drawing.Point(1075, 2);
            this.pictureMinimize.Name = "pictureMinimize";
            this.pictureMinimize.Size = new System.Drawing.Size(28, 28);
            this.pictureMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureMinimize.TabIndex = 1;
            this.pictureMinimize.TabStop = false;
            this.pictureMinimize.Click += new System.EventHandler(this.EventoClick);
            // 
            // pictureClose
            // 
            this.pictureClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureClose.Image = global::Application.Properties.Resources.close;
            this.pictureClose.Location = new System.Drawing.Point(1109, 3);
            this.pictureClose.Name = "pictureClose";
            this.pictureClose.Size = new System.Drawing.Size(28, 28);
            this.pictureClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureClose.TabIndex = 0;
            this.pictureClose.TabStop = false;
            this.pictureClose.Click += new System.EventHandler(this.EventoClick);
            // 
            // ImportarAlumnosMenuItem
            // 
            this.ImportarAlumnosMenuItem.Name = "ImportarAlumnosMenuItem";
            this.ImportarAlumnosMenuItem.Size = new System.Drawing.Size(285, 22);
            this.ImportarAlumnosMenuItem.Text = "Importar Alumnos";
            this.ImportarAlumnosMenuItem.Click += new System.EventHandler(this.EventoClickMenuItem);
            // 
            // ImportarEmpleadosMenuItem
            // 
            this.ImportarEmpleadosMenuItem.Name = "ImportarEmpleadosMenuItem";
            this.ImportarEmpleadosMenuItem.Size = new System.Drawing.Size(285, 22);
            this.ImportarEmpleadosMenuItem.Text = "Importar Empleados y/o Docentes";
            this.ImportarEmpleadosMenuItem.Click += new System.EventHandler(this.EventoClickMenuItem);
            // 
            // ImportarUsuariosMenuItem
            // 
            this.ImportarUsuariosMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.ImportarUsuariosMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ImportarAlumnosMenuItem,
            this.ImportarEmpleadosMenuItem});
            this.ImportarUsuariosMenuItem.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.ImportarUsuariosMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.ImportarUsuariosMenuItem.Name = "ImportarUsuariosMenuItem";
            this.ImportarUsuariosMenuItem.Size = new System.Drawing.Size(336, 22);
            this.ImportarUsuariosMenuItem.Text = "Importar Usuarios";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(1160, 631);
            this.Controls.Add(this.panelMain);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(223)))), ((int)(((byte)(198)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Control de Usuarios";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CancelarF4);
            this.Load += new System.EventHandler(this.Main_Load);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.panelVentana.ResumeLayout(false);
            this.panelMenuStrip.ResumeLayout(false);
            this.panelMenuStrip.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.PictureBox pictureMinimize;
        private System.Windows.Forms.PictureBox pictureClose;
        private System.Windows.Forms.PictureBox pictureIcon;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Panel panelVentana;
        private System.Windows.Forms.Panel panelMenuStrip;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem usuariosMenu;
        private System.Windows.Forms.ToolStripMenuItem reportesMenu;
        private System.Windows.Forms.ToolStripMenuItem configuracionMenu;
        private System.Windows.Forms.Panel panelContenido;
        private System.Windows.Forms.ToolStripMenuItem CambiarMiContraMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CambiarOtraContraMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AgregarAdminMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MovimientosMenu;
        private System.Windows.Forms.ToolStripMenuItem ImportarUsuariosMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ImportarAlumnosMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ImportarEmpleadosMenuItem;
    }
}