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

        public AdminEntity ObjSession = new AdminEntity();
        public ConfigEntity ObjConfig = new ConfigEntity();
        private Business ObjBusiness = new Business();
        private Users ObjUsuarios = new Users();
        private Moves ObjMoves = new Moves();
        private Reports ObjReportes = new Reports();
        private AddEditDeleteAdmin ObjAddEditDeleteAdmin = new AddEditDeleteAdmin();
        private ChangeMyPassword ObjChangeMyPassword = new ChangeMyPassword();
        private ChangeOthersPasswords ObjChangeOthersPasswords = new ChangeOthersPasswords();
        private ImportUsers ObjImportUsers = new ImportUsers();
        private Alerts ObjAlert;

        #endregion Instancias

        private Control[] arreglo;
        private byte menu;

        public Main()
        {
            InitializeComponent();
            Size = new Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);
            MinimumSize = new Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);
        }

        public Main(AdminEntity ObjSession)
        {
            InitializeComponent();
            Size = new Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);
            MinimumSize = new Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);
            this.ObjSession.NumControl = ObjSession.NumControl;
            this.ObjSession.Password = ObjSession.Password;
            this.ObjSession.SuperSu = ObjSession.SuperSu;
        }

        public void MostrarForm(Form Formulario)
        {
            Formulario.TopLevel = false;
            Formulario.Parent = panelContenido;
            Formulario.Dock = DockStyle.Fill;
            if (!Formulario.Visible) Formulario.Show();
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
                    {
                        ObjAlert = new Alerts((byte)TypeIcon.Warning, "Salir", "¿Deseas cerrar el programa?", "Sí aceptas, se cerrará tu sesión actual.", true);
                        var dr = ObjAlert.ShowDialog();
                        if (dr == DialogResult.Yes)
                        {
                            using (var logout = new LogOut(ObjSession))
                            {
                                logout.ShowDialog();
                                if (logout.ConfirmacionCerrar())
                                {
                                    ObjBusiness.Bitacora(ObjSession.NumControl, "Control de Usuarios", "Salida");
                                    System.Windows.Forms.Application.Exit();
                                }
                            }
                        }
                        break;
                    }
                case 1:
                    {
                        WindowState = (WindowState == FormWindowState.Normal) ? WindowState = FormWindowState.Minimized : WindowState = FormWindowState.Normal;
                        Size = new Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);
                        MinimumSize = new Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);
                        break;
                    }
                default:
                    throw new Exception("Evento Clic fuera de los límites posibles.");
            }
            menu = 0;
        }

        private void EventoClickMenuItem(object sender, EventArgs e)
        {
            byte item = 0;
            var menuitem = new ToolStripMenuItem[] {
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
                case 0: MostrarForm(ObjUsuarios); break;
                case 1: MostrarForm(ObjMoves); break;
                case 2:
                    MostrarForm(ObjReportes);
                    ObjReportes.UserSession(ObjSession);
                    break;
                case 3:
                    ObjConfig.TypeImport = true;
                    ObjImportUsers.UserConfigs(ObjConfig);
                    MostrarForm(ObjImportUsers);
                    break;
                case 4:
                    ObjConfig.TypeImport = false;
                    ObjImportUsers.UserConfigs(ObjConfig);
                    MostrarForm(ObjImportUsers);
                    break;
                case 5: MostrarForm(ObjAddEditDeleteAdmin); break;
                case 6: MostrarForm(ObjChangeMyPassword); break;
                case 7: MostrarForm(ObjChangeOthersPasswords); break;
            }
            item = 0;
        }

        private void CambiarColorMenuItem(object sender, EventArgs e)
        {
            byte item = 0;
            var menuitem = new ToolStripMenuItem[] { usuariosMenu, MovimientosMenu, reportesMenu, configuracionMenu };
            for (; item < menuitem.Length; item++)
            {
                if (menuitem[item] == sender)
                    break;
            }
            switch (item)
            {
                case 0:
                    {
                        usuariosMenu.ForeColor = Color.FromArgb(19, 27, 35); break;
                    }
                case 1:
                    {
                        MovimientosMenu.ForeColor = Color.FromArgb(19, 27, 35); break;
                    }
                case 2:
                    {
                        reportesMenu.ForeColor = Color.FromArgb(19, 27, 35); break;
                    }
                case 3:
                    {
                        configuracionMenu.ForeColor = Color.FromArgb(19, 27, 35); break;
                    }
                default:
                    throw new Exception("Unexpected Case");
            }
            item = 0;
        }

        private void ResetColorMenuItem(object sender, EventArgs e)
        {
            byte item = 0;
            var menuitem = new ToolStripMenuItem[] { usuariosMenu, MovimientosMenu, reportesMenu, configuracionMenu };
            for (; item < menuitem.Length; item++)
            {
                if (menuitem[item] == sender)
                    break;
            }
            switch (item)
            {
                case 0:
                    {
                        usuariosMenu.ForeColor = Color.FromArgb(231, 223, 198); break;
                    }
                case 1:
                    {
                        MovimientosMenu.ForeColor = Color.FromArgb(231, 223, 198); break;
                    }
                case 2:
                    {
                        reportesMenu.ForeColor = Color.FromArgb(231, 223, 198); break;
                    }
                case 3:
                    {
                        configuracionMenu.ForeColor = Color.FromArgb(231, 223, 198); break;
                    }
                default:
                    throw new Exception("Unexpected Case");
            }
            item = 0;
        }

        private static void CancelarF4(object sender, FormClosingEventArgs e)
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
                ObjBusiness.ExistUserOrAdmin(ObjSession.NumControl, "ExistAdmin").Rows[0]["nombres"] + " " +
                ObjBusiness.ExistUserOrAdmin(ObjSession.NumControl, "ExistAdmin").Rows[0]["apellidopat"] + " " +
                ObjBusiness.ExistUserOrAdmin(ObjSession.NumControl, "ExistAdmin").Rows[0]["apellidomat"];

            if (ObjSession.SuperSu.Equals('S'))
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