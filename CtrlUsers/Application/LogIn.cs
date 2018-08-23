using BusinessLayer;
using System;
using System.Data;
using System.Windows.Forms;
using Entity;

namespace Application
{
    public partial class LogIn : Form
    {
        #region Instancias

        private SessionsEntity ObjSession = new SessionsEntity();
        private Business ObjBusiness = new Business();

        #endregion Instancias

        private DataTable dt;
        private Control[] arreglo;
        private byte menu;
        private string placeholderUser = "";
        private string placeholderPassword = "";

        public LogIn()
        {
            InitializeComponent();
        }

        public LogIn(SessionsEntity ObjSession)
        {
            InitializeComponent();
            this.ObjSession.Username = ObjSession.Username;
            this.ObjSession.Password = ObjSession.Password;
            this.ObjSession.SuperSu = ObjSession.SuperSu;
        }

        private void LogIn_Load(object sender, EventArgs e)
        {
            txtUser.Text = "Número de Control";
            txtPassword.Text = "Contraseña";
        }

        private void EventoClick(object sender, EventArgs e)
        {
            arreglo = new Control[] { btnAceptar, btnCancelar, pictureClose };
            for (; menu < arreglo.Length; menu++)
            {
                if (arreglo[menu] == sender)
                    break;
            }
            switch (menu)
            {
                case 0:
                    this.ObjSession.Username = txtUser.Text.Trim();
                    this.ObjSession.Password = txtPassword.Text.Trim();
                    dt = ObjBusiness.Sesion(this.ObjSession);
                    try
                    {
                        if (dt.Rows.Count > 0 && dt.Columns.Count == 3)
                        {
                            this.ObjSession.Username = dt.Rows[0]["nc"].ToString();
                            this.ObjSession.Password = dt.Rows[0]["password"].ToString();
                            this.ObjSession.SuperSu = Convert.ToChar(dt.Rows[0]["superus"].ToString());
                            ObjBusiness.Bitacora(txtUser.Text.Trim(), "Control de Usuarios", "Entrada");
                            Main main = new Main(this.ObjSession);
                            main.Show();
                            this.Hide();
                        }
                        else
                        {
                            Alerts pregunta = new Alerts((byte)TypeIcon.Danger, "Inicio de Sesión", "Usuario o contraseña incorrecta", "Verifica que el usuario y\ncontraseña sean correctos.", false);
                            pregunta.Show();
                            pregunta.Focus();
                        }
                    }
                    catch (Exception ex)
                    {
                        Alerts pregunta = new Alerts((byte)TypeIcon.Danger, "Error de conexión", "Error al conectar a la base de datos", "1. Verifique que su archivo App.config tenga escrito correctamente el nombre " +
                            "de su instancia SQL y el nombre de pase de datos.\n2. Asegurse de que en su manejador de base de datos tenga la base de datos \"pBiblioteca\".", false);
                        MessageBox.Show(ex.ToString());
                        pregunta.Show();
                        pregunta.Focus();
                    }
                    txtUser.Text = "";
                    txtPassword.Text = "";
                    break;

                case 1:
                case 2:
                    this.Close();
                    btnCancelar.DialogResult = DialogResult.No;
                    break;
            }
            menu = 0;
        }

        private void TextUserEnter(object sender, EventArgs e)
        {
            if (txtUser.Text == "Número de Control" || txtUser.Text == "")
                txtUser.Text = "";
        }

        private void TextUserLeave(object sender, EventArgs e)
        {
            placeholderUser = txtUser.Text.Trim();
            if (placeholderUser.Equals("Número de Control"))
                txtUser.Text = "Número de Control";
            else
                txtUser.Text = (placeholderUser.Equals("")) ? "Número de Control" : placeholderUser;
        }

        private void TextPasswordEnter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Contraseña" || txtPassword.Text == "")
                txtPassword.Text = "";
            txtPassword.PasswordChar = '*';
        }

        private void TextPasswordLeave(object sender, EventArgs e)
        {
            placeholderPassword = txtPassword.Text.Trim();
            if (placeholderPassword.Equals("Contraseña"))
                txtPassword.Text = "Contraseña";
            else
            {
                if (placeholderPassword.Equals(""))
                {
                    txtPassword.PasswordChar = '\0';
                    txtPassword.Text = "Contraseña";
                }
                else
                {
                    txtPassword.PasswordChar = '*';
                    txtPassword.Text = placeholderPassword;
                }
            }
        }
    }
}