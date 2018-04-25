using CapaNegocio;
using System;
using System.Windows.Forms;

namespace CapaPre
{
    public partial class MyPassword : UserControl
    {
        #region Instancias

        private Negocio negocio = new Negocio();

        #endregion Instancias

        private Control[] arreglo;
        private byte menu;
        public string[] Admin = new string[2];
        public char supersu;

        public MyPassword()
        {
            InitializeComponent();
            txtNewPassword.Enabled = false;
            txtConfirmPassword.Enabled = false;
        }

        public void Limpiar()
        {
            txtMyPassword.Focus();
            txtMyPassword.Text = "";
            txtMyPassword.PasswordChar = '*';
            txtNewPassword.Text = "";
            txtNewPassword.PasswordChar = '*';
            txtConfirmPassword.Text = "";
            txtConfirmPassword.PasswordChar = '*';
        }

        public void ChangePassword(string NewPassword)
        {
            Question pregunta = new Question((byte)TipoIcono.Warning, "Confirmación", "¿Estas seguro de que deaseas cambiar tu contraseña?", "Sí aceptas, tu contraseña será cambiada por la que acabas de ingresar.", true);
            DialogResult dr = pregunta.ShowDialog();
            if (dr == DialogResult.Yes)
            {
                negocio.ChangePassword(Admin[0], Admin[1], txtNewPassword.Text.Trim());
                Question ok = new Question((byte)TipoIcono.Info, "Tarea realizada", "Cambio de contraseña", "La contraseña se ha cambiado exitosamente.\nPara asegurar los cambios, por favor de cerrar sesión\ncon su anterior contraseña e iniciar con la nueva contraseña.", false);
                ok.Show();
                Limpiar();
            }
        }

        private void EventoClick(object sender, EventArgs e)
        {
            arreglo = new Control[] { btnAceptar, btnCancelar, pictureShowPass1, pictureShowPass2, pictureShowPass3 };
            for (; menu < arreglo.Length; menu++)
            {
                if (arreglo[menu] == sender)
                    break;
            }
            switch (menu)
            {
                case 0:
                    if (txtNewPassword.Text.Trim() == txtConfirmPassword.Text.Trim())
                        ChangePassword(txtNewPassword.Text.Trim());
                    else
                    {
                        Question alerta = new Question((byte)TipoIcono.Warning, "Contraseñas diferentes", "Verifique su información", "La contreaseña no coincide con su confirmación, verifique que ambas sean iguales", false);
                        alerta.Show();
                    }
                    break;

                case 1:
                    Limpiar();
                    txtMyPassword.PasswordChar = '*';
                    txtNewPassword.PasswordChar = '*';
                    txtConfirmPassword.PasswordChar = '*';
                    txtMyPassword.Focus();
                    break;

                case 2:
                    switch (txtMyPassword.PasswordChar)
                    {
                        case '\0': txtMyPassword.PasswordChar = '*'; break;
                        case '*': txtMyPassword.PasswordChar = '\0'; break;
                    }
                    break;

                case 3:
                    switch (txtNewPassword.PasswordChar)
                    {
                        case '\0': txtNewPassword.PasswordChar = '*'; break;
                        case '*': txtNewPassword.PasswordChar = '\0'; break;
                    }
                    break;

                case 4:
                    switch (txtConfirmPassword.PasswordChar)
                    {
                        case '\0': txtConfirmPassword.PasswordChar = '*'; break;
                        case '*': txtConfirmPassword.PasswordChar = '\0'; break;
                    }
                    break;
            }
            menu = 0;
        }

        private void Coincidencia(object sender, EventArgs e)
        {
            if (Admin[1] != txtMyPassword.Text.Trim() || txtMyPassword.Text == "")
            {
                txtNewPassword.Enabled = false;
                txtConfirmPassword.Enabled = false;
            }
            else
            {
                txtNewPassword.Enabled = true;
                txtConfirmPassword.Enabled = true;
            }
        }
    }
}