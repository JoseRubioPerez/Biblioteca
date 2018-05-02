using System;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPre
{
    public partial class LogIn : Form
    {
        private Control[] arreglo;
        private byte menu;

        #region Instancias

        Negocio negocio = new Negocio();

        #endregion

        public LogIn()
        {
            InitializeComponent();
            lbError.Text = "";
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
                    if (negocio.Sesion(txtUser.Text.Trim(), txtPassword.Text.Trim()).Rows.Count > 0)
                    {
                        negocio.Bitacora(txtUser.Text.Trim(), "Registro de Usuarios","Entrada");
                        Main main = new Main();
                        main.Show();
                        this.Hide();
                    }
                    else
                    {
                        txtUser.Text = "";
                        txtPassword.Text = "";
                        txtUser.Focus();
                        lbError.Text = "Usuario y/o ontraseña incorrectos.";
                    }
                    break;

                case 1: case 2: this.Close(); break;
                case 3:
                    switch (txtPassword.PasswordChar)
                    {
                        case '\0': txtPassword.PasswordChar = '*'; break;
                        case '*': txtPassword.PasswordChar = '\0'; break;
                    }
                    break;
            }
            menu = 0;
        }
    }
}
