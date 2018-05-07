using CapaEntidad;
using CapaNegocio;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CapaPre
{
    internal enum TypeIcon { Danger = 1, Warning = 2, Info = 3 }

    public partial class Main : Form
    {
        #region Instancias

        private Entidad entidad = new Entidad();
        private Negocio negocio = new Negocio();
        Users usuarios = new Users();
        private AddEditDeleteAdmin addEditDeleteAdmin = new AddEditDeleteAdmin();
        private ChangeMyPassword changeMyPassword = new ChangeMyPassword();
        private ChangeOthersPasswords changeOthersPasswords = new ChangeOthersPasswords();

        #endregion Instancias

        private Control[] arreglo;
        private byte menu;

        public Main()
        {
            InitializeComponent();
            this.Size = new Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);
            MinimumSize = new Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);
        }

        public Main(string user, string password, char supersu)
        {
            InitializeComponent();
            this.Size = new Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);
            MinimumSize = new Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);
            entidad.setAdminNC(user); entidad.setAdminPassword(password); entidad.setAdminSuperSu(supersu);
            //ChangeMyPassword
            changeMyPassword.Admin[0] = entidad.getAdminNC();
            changeMyPassword.Admin[1] = entidad.getAdminPassword();
            changeMyPassword.supersu = supersu;
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
                    Question pregunta = new Question((byte)TypeIcon.Warning, "Salir", "¿Deseas cerrar el programa?", "Sí aceptas, se cerrará tu sesión actual.", true);
                    DialogResult dr = pregunta.ShowDialog();
                    if (dr == DialogResult.Yes)
                    {
                        LogOut logout = new LogOut(entidad.getAdminNC(), entidad.getAdminPassword());
                        logout.ShowDialog();
                        if (logout.ConfirmacionCerrar())
                        {
                            negocio.Bitacora(entidad.getAdminNC(), "Control de Usuarios", "Salida");
                            Application.Exit();
                        }
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
                if (menuitem[item] == sender)
                    break;
            switch (item)
            {
                case 0: MostrarForm(usuarios); break;
                case 1:
                    break;
                case 2: MostrarForm(addEditDeleteAdmin); break;
                case 3: MostrarForm(changeMyPassword); break;
                case 4: MostrarForm(changeOthersPasswords); break;
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
            lbTitulo.Text = "Sistema de Control de Usuarios. Bienvenido: " +
                negocio.ExistUserOrAdmin(entidad.getAdminNC(), "ExistAdmin").Rows[0]["nombres"].ToString() + " " +
                negocio.ExistUserOrAdmin(entidad.getAdminNC(), "ExistAdmin").Rows[0]["apellidopat"].ToString() + " " +
                negocio.ExistUserOrAdmin(entidad.getAdminNC(), "ExistAdmin").Rows[0]["apellidomat"].ToString();

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