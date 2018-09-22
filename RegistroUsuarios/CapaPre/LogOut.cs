using CapaNegocio;
using System;
using System.Data;
using System.Windows.Forms;

namespace CapaPre
{
    public partial class LogOut : Form
    {
        private Control[] arreglo;
        private byte menu;

        public LogOut()
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
                    Negocio negocio = new Negocio();
                    DataTable dt = negocio.Sesion(txtUser.Text.Trim(), txtPassword.Text.Trim());
                    if (dt.Rows.Count > 0)
                    {
                        negocio.Bitacora(txtUser.Text.Trim(), "Registro de Usuarios", "Salida");
                        Application.Exit();
                    }
                    else
                    {
                        txtUser.Text = "";
                        txtPassword.Text = "";
                        txtUser.Focus();
                        lbError.Text = "Usuario y/o ontraseña incorrectos.";
                    }
                    break;

                case 1: case 2: this.Hide(); break;
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
