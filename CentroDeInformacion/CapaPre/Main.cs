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

        /*private Usuarios.Usuarios usuarios = new Usuarios.Usuarios();
        private Configuracion configuracion = new Configuracion();
        private Entidad entidad = new Entidad();*/
        private Negocio negocio = new Negocio();

        #endregion Instancias

        private ToolStripMenuItem[] menuitem;
        private Control[] arreglo;
        private byte item;
        private byte menu;
        private string[] Admin = new string[2];
        private char superUsuario = 'N';

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
            Admin[0] = user; Admin[1] = password; superUsuario = supersu;
            lbTitulo.Text = "Sistema de Control de Usuarios. Bienvenido: " + user;
        }

        public void MostrarForm(Form Formulario, DockStyle Estilo)
        {
            panelContenido.Controls.Clear();
            Formulario.TopLevel = false;
            Formulario.Parent = panelContenido;
            Formulario.Dock = Estilo;
            Formulario.Show();
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
                        LogOut logout = new LogOut(Admin);
                        logout.ShowDialog();
                        if (logout.ConfirmacionCerrar())
                            Application.Exit();
                    }
                    break;

                case 1: WindowState = (WindowState == FormWindowState.Normal) ? WindowState = FormWindowState.Minimized : WindowState = FormWindowState.Normal; break;
            }
            menu = 0;
        }

        private void CambiarColorMenuItem(object sender, EventArgs e)
        {
            menuitem = new ToolStripMenuItem[] { usuariosMenu, reportesMenu, configuracionMenu };
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
            menuitem = new ToolStripMenuItem[] { usuariosMenu, reportesMenu, configuracionMenu };
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
    }
}
