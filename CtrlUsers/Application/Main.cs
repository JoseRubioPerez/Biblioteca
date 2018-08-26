using System;
using System.Drawing;
using System.Windows.Forms;
using BusinessLayer;
using Entity;

namespace Application
{
    internal enum TypeIcon { Danger = 1, Warning = 2, Info = 3 }

    public partial class Main : Form
    {
        #region Instancias

        public SessionsEntity ObjSession = new SessionsEntity();
        public ConfigEntity ObjConfig = new ConfigEntity();
        private Business ObjBusiness = new Business();
        private Users usuarios = new Users();
        private Moves moves = new Moves();
        private Reports reportes = new Reports();
        private AddEditDeleteAdmin addEditDeleteAdmin = new AddEditDeleteAdmin();
        private ChangeMyPassword changeMyPassword = new ChangeMyPassword();
        private ChangeOthersPasswords changeOthersPasswords = new ChangeOthersPasswords();
        private ImportUsers importUsers = new ImportUsers();

        #endregion Instancias

        private Control[] arreglo;
        private byte menu;

        public Main()
        {
            InitializeComponent();
            this.Size = new Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);
            MinimumSize = new Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);
        }

        public Main(SessionsEntity ObjSession)
        {
            InitializeComponent();
            this.Size = new Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);
            MinimumSize = new Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);
            this.ObjSession.Username = ObjSession.Username;
            this.ObjSession.Password = ObjSession.Password;
            this.ObjSession.SuperSu = ObjSession.SuperSu;
            //ChangeMyPassword
            //changeMyPassword.Admin[0] = entidad.getAdminNC();
            //changeMyPassword.Admin[1] = entidad.getAdminPassword();
            //changeMyPassword.supersu = supersu;
            //Moves
            //moves.Usuario = entidad.getAdminNC();
            //Reports
            //reportes.Usuario = entidad.getAdminNC();
        }

        public void MostrarForm(Form Formulario)
        {
            Formulario.TopLevel = false;
            Formulario.Parent = panelContenido;
            Formulario.Dock = DockStyle.Fill;
            if (Formulario.Visible == false)
                Formulario.Show();
            Formulario.BringToFront();
        }

        private void EventoClick(object sender, EventArgs e)
        {
            arreglo = new Control[] { pictureClose, pictureMinimize };
            for (; menu < arreglo.Length; menu++)
                if (arreglo[menu] == sender)
                    break;
            switch (menu)
            {
                case 0:
                    Alerts pregunta = new Alerts((byte)TypeIcon.Warning, "Salir", "¿Deseas cerrar el programa?", "Sí aceptas, se cerrará tu sesión actual.", true);
                    DialogResult dr = pregunta.ShowDialog();
                    if (dr == DialogResult.Yes)
                    {
                        LogOut logout = new LogOut(this.ObjSession);
                        logout.ShowDialog();
                        if (logout.ConfirmacionCerrar())
                        {
                            ObjBusiness.Bitacora(this.ObjSession.Username, "Control de Usuarios", "Salida");
                            System.Windows.Forms.Application.Exit();
                        }
                    }
                    break;

                case 1:
                    WindowState = (WindowState == FormWindowState.Normal) ? WindowState = FormWindowState.Minimized : WindowState = FormWindowState.Normal;
                    this.Size = new Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);
                    MinimumSize = new Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);
                    break;
            }
            menu = 0;
        }

        private void EventoClickMenuItem(object sender, EventArgs e)
        {
            byte item = 0;
            ToolStripMenuItem[] menuitem = new ToolStripMenuItem[] {
                usuariosMenu, //0
                MovimientosMenu, //1
                reportesMenu, //2
                ImportarAlumnosMenuItem, //3
                ImportarEmpleadosMenuItem, //4
                AgregarAdminMenuItem, //5
                CambiarMiContraMenuItem, //6
                CambiarOtraContraMenuItem }; //7
            for (; item < menuitem.Length; item++)
                if (menuitem[item] == sender)
                    break;
            switch (item)
            {
                case 0: MostrarForm(usuarios); break; //usuariosMenu
                case 1: MostrarForm(moves); break; //MovimientosMenu
                case 2: MostrarForm(reportes); break; //reportesMenu
                case 3:
                    ObjConfig.TypeImport = true;
                    importUsers.UserConfigs(ObjConfig);
                    MostrarForm(importUsers);
                    break; //ImportarAlumnoMenuItem
                case 4:
                    ObjConfig.TypeImport = false;
                    importUsers.UserConfigs(ObjConfig);
                    MostrarForm(importUsers); //ImportarEmpleadosMenuItem
                    break;
                case 5: MostrarForm(addEditDeleteAdmin); break; //AgregarAdminMenuItem
                case 6: MostrarForm(changeMyPassword); break; //CambiarMiContraMenuItem
                case 7: MostrarForm(changeOthersPasswords); break; //CambiarOtraContraMenuItem
            }
            item = 0;
        }

        private void CambiarColorMenuItem(object sender, EventArgs e)
        {
            byte item = 0;
            ToolStripMenuItem[] menuitem = new ToolStripMenuItem[] { usuariosMenu, MovimientosMenu, reportesMenu, configuracionMenu };
            for (; item < menuitem.Length; item++)
            {
                if (menuitem[item] == sender)
                    break;
            }
            switch (item)
            {
                case 0: usuariosMenu.ForeColor = Color.FromArgb(19, 27, 35); break;
                case 1: MovimientosMenu.ForeColor = Color.FromArgb(19, 27, 35); break;
                case 2: reportesMenu.ForeColor = Color.FromArgb(19, 27, 35); break;
                case 3: configuracionMenu.ForeColor = Color.FromArgb(19, 27, 35); break;
            }
            item = 0;
        }

        private void ResetColorMenuItem(object sender, EventArgs e)
        {
            byte item = 0;
            ToolStripMenuItem[] menuitem = new ToolStripMenuItem[] { usuariosMenu, MovimientosMenu, reportesMenu, configuracionMenu };
            for (; item < menuitem.Length; item++)
            {
                if (menuitem[item] == sender)
                    break;
            }
            switch (item)
            {
                case 0: usuariosMenu.ForeColor = Color.FromArgb(231, 223, 198); break;
                case 1: MovimientosMenu.ForeColor = Color.FromArgb(231, 223, 198); break;
                case 2: reportesMenu.ForeColor = Color.FromArgb(231, 223, 198); break;
                case 3: configuracionMenu.ForeColor = Color.FromArgb(231, 223, 198); break;
            }
            item = 0;
        }

        private void CancelarF4(object sender, FormClosingEventArgs e)
        {
            switch (e.CloseReason)
            {
                case CloseReason.UserClosing: e.Cancel = true; break;
                case CloseReason.ApplicationExitCall: e.Cancel = false; break;
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            lbTitulo.Text = "Sistema de Control de Usuarios. Bienvenido: " +
                ObjBusiness.ExistUserOrAdmin(this.ObjSession.Username, "ExistAdmin").Rows[0]["nombres"].ToString() + " " +
                ObjBusiness.ExistUserOrAdmin(this.ObjSession.Username, "ExistAdmin").Rows[0]["apellidopat"].ToString() + " " +
                ObjBusiness.ExistUserOrAdmin(this.ObjSession.Username, "ExistAdmin").Rows[0]["apellidomat"].ToString();

            if (this.ObjSession.SuperSu.Equals('S'))
            {
                AgregarAdminMenuItem.Visible = true;
                CambiarOtraContraMenuItem.Visible = true;
            }
            else
            {
                AgregarAdminMenuItem.Visible = false;
                CambiarOtraContraMenuItem.Visible = false;
            }
        }
    }
}