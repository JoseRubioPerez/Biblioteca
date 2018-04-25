using CapaNegocio;
using System;
using System.Data;
using System.Windows.Forms;

namespace CapaPre
{
    public partial class LogIn : Form
    {
        #region Instancias

        private Negocio negocio = new Negocio();

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

        private void LogIn_Load(object sender, EventArgs e)
        {
            txtUser.Text = "Usuario";
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
                    dt = negocio.Sesion(txtUser.Text.Trim(), txtPassword.Text.Trim());
                    try
                    {
                        if (dt.Rows.Count > 0)
                        {
                            Main main = new Main(dt.Rows[0][0].ToString(), dt.Rows[0][1].ToString(), Convert.ToChar(dt.Rows[0][2].ToString()));
                            main.Show();
                            this.Hide();
                        }
                        else
                        {
                            Question pregunta = new Question((byte)TipoIcono.Danger, "Inicio de Sesión", "Usuario o contraseña incorrecta", "Verifica que el usuario y\ncontraseña sean correctos.", false);
                            pregunta.Show();
                            pregunta.Focus();
                        }
                    }
                    catch (Exception)
                    {
                        Question pregunta = new Question((byte)TipoIcono.Danger, "Error de conexión", "Error al conectar a la base de datos", "1. Verifique que su archivo App.config tenga escrito correctamente el nombre " +
                            "de su instancia SQL y el nombre de pase de datos.\n2. Asegurse de que en su manejador de base de datos tenga la base de datos \"pBiblioteca\".", false);
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

        private void txtUser_Enter(object sender, EventArgs e)
        {
            if (txtUser.Text == "Usuario" || txtUser.Text == "")
                txtUser.Text = "";
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            placeholderUser = txtUser.Text.Trim();
            if (placeholderUser.Equals("Usuario"))
                txtUser.Text = "Usuario";
            else
                txtUser.Text = (placeholderUser.Equals("")) ? "Usuario" : placeholderUser;
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Contraseña" || txtPassword.Text == "")
                txtPassword.Text = "";
            txtPassword.PasswordChar = '*';
        }

        private void txtPassword_Leave(object sender, EventArgs e)
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