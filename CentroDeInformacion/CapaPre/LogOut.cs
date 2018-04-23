using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPre
{
    public partial class LogOut : Form
    {
        #region Instancias

        private Negocio negocio = new Negocio();

        #endregion Instancias

        private DataTable dt;
        private Control[] arreglo;
        private byte menu;
        private string[] Admin;
        private string placeholderUser = "";
        private string placeholderPassword = "";
        private bool bandera = false;

        public LogOut(string[] admin)
        {
            InitializeComponent();
            Admin = new string[admin.Length];
            for (int i = 0; i < Admin.Length; i++)
                Admin[i] = admin[i];
        }

        public bool ConfirmacionCerrar() { return bandera; }

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
                    if (txtUser.Text.Trim() == Admin[0] && txtPassword.Text.Trim() == Admin[1])
                        bandera = true;
                    else
                        bandera = false;
                    this.Close();
                    break;

                case 1: case 2: this.Close(); break;
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
