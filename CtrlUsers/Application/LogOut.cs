using BusinessLayer;
using System;
using System.Windows.Forms;
using Entity;

namespace Application
{
    public partial class LogOut : Form
    {
        private AdminEntity ObjSession = new AdminEntity();
        //private DataTable dt;
        private Control[] arreglo;

        private byte menu;
        private string placeholderUser = "";
        private string placeholderPassword = "";
        private bool bandera = false;

        public LogOut()
        {
            InitializeComponent();
        }

        public LogOut(AdminEntity ObjSession)
        {
            InitializeComponent();
            this.ObjSession.NumControl = ObjSession.NumControl;
            this.ObjSession.Password = ObjSession.Password;
            this.ObjSession.SuperSu = ObjSession.SuperSu;
        }

        public bool ConfirmacionCerrar()
        {
            return bandera;
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
                    Business negocio = new Business();
                    if (txtUser.Text.Trim() == this.ObjSession.NumControl && txtPassword.Text.Trim() == this.ObjSession.Password)
                        bandera = true;
                    else
                        bandera = false;
                    this.Close();
                    break;

                case 1: case 2: this.Close(); break;
            }
            menu = 0;
        }

        private void UserEnter(object sender, EventArgs e)
        {
            if (txtUser.Text == "Número de Control" || txtUser.Text == "")
                txtUser.Text = "";
        }

        private void UserLeave(object sender, EventArgs e)
        {
            placeholderUser = txtUser.Text.Trim();
            txtUser.Text = (placeholderUser.Equals("Número de Control")) ? txtUser.Text = "Número de Control" : ((placeholderUser.Equals("")) ? "Número de Control" : placeholderUser);
        }

        private void PasswordEnter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Contraseña" || txtPassword.Text == "")
                txtPassword.Text = "";
            txtPassword.PasswordChar = '*';
        }

        private void PasswordLeave(object sender, EventArgs e)
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