using CapaEntidad;
using CapaNegocio;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CapaPre
{
    internal enum TipoIcono { Danger = 1, Warning = 2, Info = 3 }

    public partial class Main : Form
    {
        #region Instancias

        private Entidad entidad = new Entidad();
        private Negocio negocio = new Negocio();

        #endregion Instancias

        private Control[] arreglo;
        private byte menu;

        public Main()
        {
            InitializeComponent();
            this.Size = new Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);
            MinimumSize = new Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);
            OcultarControlUsers();
        }

        public Main(string user, string password, char supersu)
        {
            InitializeComponent();
            this.Size = new Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);
            MinimumSize = new Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);
            //Entidad
            entidad.setAdminNC(user);
            entidad.setAdminPassword(password);
            entidad.setAdminSuperSu(supersu);
            //Main -> myPassword1
            myPassword1.Admin[0] = user;
            myPassword1.Admin[1] = password;
            myPassword1.supersu = supersu;
            //Main -> othersPasswords1
            othersPasswords1.Admin[0] = user;
            othersPasswords1.Admin[1] = password;
            othersPasswords1.supersu = supersu;

            lbTitulo.Text = "Sistema de Control de Usuarios. Bienvenido: " + entidad.getAdminNC();
            OcultarControlUsers();
        }

        public void OcultarControlUsers()
        {
            UserControl[] ctlUser = new UserControl[] { myPassword1, othersPasswords1, newAdmin1 };
            for (int i = 0; i < ctlUser.Length; i++)
                ctlUser[i].Visible = false;
        }

        public void MostrarCtrl(UserControl ctlUser, DockStyle Estilo)
        {
            if (ctlUser.Visible)
                ctlUser.BringToFront();
            else
            {
                ctlUser.Show();
                ctlUser.BringToFront();
            }
            ctlUser.Parent = panelContenido;
            ctlUser.Dock = Estilo;
        }

        private void EventoClick(object sender, EventArgs e)
        {
            arreglo = new Control[] { pictureClose, pictureMinimize };
            for (; menu < arreglo.Length; menu++)
            {
                if (arreglo[menu] == sender)
                    break;
            }
            switch (menu)
            {
                case 0:
                    Question pregunta = new Question((byte)TipoIcono.Warning, "Salir", "¿Deseas cerrar el programa?", "Sí aceptas, se cerrará tu sesión actual.", true);
                    DialogResult dr = pregunta.ShowDialog();
                    if (dr == DialogResult.Yes)
                    {
                        LogOut logout = new LogOut(entidad.getAdminNC(), entidad.getAdminPassword());
                        logout.ShowDialog();
                        if (logout.ConfirmacionCerrar())
                            Application.Exit();
                    }
                    break;

                case 1: WindowState = (WindowState == FormWindowState.Normal) ? WindowState = FormWindowState.Minimized : WindowState = FormWindowState.Normal; break;
            }
            menu = 0;
        }

        private void EventoClickMenuItem(object sender, EventArgs e)
        {
            byte item = 0;
            ToolStripMenuItem[] menuitem = new ToolStripMenuItem[] { usuariosMenu, ImportarUsuariosMenuItem, AgregarAdminMenuItem, CambiarMiContraMenuItem, CambiarOtraContraMenuItem };
            for (; item < menuitem.Length; item++)
            {
                if (menuitem[item] == sender)
                    break;
            }
            switch (item)
            {
                case 0:
                    break;

                case 2:
                    MostrarCtrl(newAdmin1, DockStyle.Fill);
                    break;

                case 3:
                    MostrarCtrl(myPassword1, DockStyle.Fill);
                    break;

                case 4:
                    MostrarCtrl(othersPasswords1, DockStyle.Fill);
                    break;
            }
            item = 0;
        }

        private void CambiarColorMenuItem(object sender, EventArgs e)
        {
            byte item = 0;
            ToolStripMenuItem[] menuitem = new ToolStripMenuItem[] { usuariosMenu, reportesMenu, configuracionMenu };
            for (; item < menuitem.Length; item++)
            {
                if (menuitem[item] == sender)
                    break;
            }
            switch (item)
            {
                case 0: usuariosMenu.ForeColor = Color.FromArgb(19, 27, 35); break;
                case 1: reportesMenu.ForeColor = Color.FromArgb(19, 27, 35); break;
                case 2: configuracionMenu.ForeColor = Color.FromArgb(19, 27, 35); break;
            }
            item = 0;
        }

        private void ResetColorMenuItem(object sender, EventArgs e)
        {
            byte item = 0;
            ToolStripMenuItem[] menuitem = new ToolStripMenuItem[] { usuariosMenu, reportesMenu, configuracionMenu };
            for (; item < menuitem.Length; item++)
            {
                if (menuitem[item] == sender)
                    break;
            }
            switch (item)
            {
                case 0: usuariosMenu.ForeColor = Color.FromArgb(231, 223, 198); break;
                case 1: reportesMenu.ForeColor = Color.FromArgb(231, 223, 198); break;
                case 2: configuracionMenu.ForeColor = Color.FromArgb(231, 223, 198); break;
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
            if (entidad.getAdminSuperSu() == 'S')
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