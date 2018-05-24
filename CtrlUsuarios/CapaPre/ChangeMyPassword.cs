using CapaNegocio;
using System;
using System.Windows.Forms;

namespace CapaPre
{
    public partial class ChangeMyPassword : FatherConfig
    {
        #region Instancias

        private Negocio negocio = new Negocio();

        #endregion Instancias

        private Control[] arreglo;
        private byte menu;
        private DialogResult dr;
        public string[] Admin = new string[2];
        public char supersu;

        public ChangeMyPassword()
        {
            InitializeComponent();
            txtNewPassword.Enabled = false;
            txtConfirmPassword.Enabled = false;
            lbError1.Text = "Primero llena el campo \"Contraseña actual\"";
            lbError2.Text = "Primero llena el campo \"Contraseña actual\"";
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
            Question pregunta;
            pregunta = new Question((byte)TypeIcon.Warning, "Confirmación", "¿Estas seguro de que deaseas cambiar tu contraseña?", "Sí aceptas, tu contraseña será cambiada por la que acabas de ingresar.", true);
            dr = pregunta.ShowDialog();
            if (dr == DialogResult.Yes)
            {
                negocio.ChangePassword(Admin[0], Admin[1], txtNewPassword.Text.Trim());
                Limpiar();
                pregunta = new Question((byte)TypeIcon.Info, "Tarea realizada", "Cambio de contraseña", "La contraseña se ha cambiado exitosamente.\nPara asegurar los cambios, por favor de cerrar sesión\ncon su anterior contraseña e iniciar con la nueva contraseña.", false);
                pregunta.Show();
            }
            dr = DialogResult.No;
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
                        Question pregunta = new Question((byte)TypeIcon.Warning, "Contraseñas diferentes", "Verifique su información", "La contreaseña no coincide con su confirmación, verifique que ambas sean iguales", false);
                        pregunta.Show();
                    }
                    break;

                case 1: Limpiar(); break;
                case 2: txtMyPassword.PasswordChar = (txtMyPassword.PasswordChar == '*') ? '\0' : '*'; break;
                case 3: txtNewPassword.PasswordChar = (txtNewPassword.PasswordChar == '*') ? '\0' : '*'; break;
                case 4: txtConfirmPassword.PasswordChar = (txtConfirmPassword.PasswordChar == '*') ? '\0' : '*'; break;
            }
            menu = 0;
        }

        private void Coincidencia(object sender, EventArgs e)
        {
            if (Admin[1] != txtMyPassword.Text.Trim() || txtMyPassword.Text == "")
            {
                txtNewPassword.Enabled = false;
                txtConfirmPassword.Enabled = false;
                lbError1.Text = "Primero llena el campo \"Contraseña actual\"";
                lbError2.Text = "Primero llena el campo \"Contraseña actual\"";
            }
            else
            {
                txtNewPassword.Enabled = true;
                txtConfirmPassword.Enabled = true;
                lbError1.Text = "";
                lbError2.Text = "";
            }
        }
    }
}