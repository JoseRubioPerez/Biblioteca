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
    public partial class ChangeOthersPasswords : FatherConfig
    {
        #region Instancias

        private Negocio negocio = new Negocio();

        #endregion Instancias

        private Control[] arreglo;
        private byte menu;
        public string[] Admin = new string[2];
        public char supersu;
        DialogResult dr;

        public ChangeOthersPasswords()
        {
            InitializeComponent();
            TableChangePassword.Visible = false;
        }

        private void LimpiarCampos()
        {
            comboAdministrador.Items.Clear();
            txtNewPassword.Text = "";
            txtConfirmPassword.Text = "";
            TableChangePassword.Visible = false;
        }

        private void EventoClick(object sender, EventArgs e)
        {
            arreglo = new Control[] { btnBuscar, btnAceptar, btnCancelar, comboAdministrador, pictureShowPass1, pictureShowPass2 };
            for (; menu < arreglo.Length; menu++)
            {
                if (arreglo[menu] == sender)
                    break;
            }
            switch (menu)
            {
                case 0:
                    if (comboAdministrador.SelectedIndex != -1)
                        TableChangePassword.Visible = true;
                    else
                        TableChangePassword.Visible = false;
                    break;

                case 1:
                    Question pregunta;
                    if (txtNewPassword.Text.Trim() == txtConfirmPassword.Text.Trim())
                    {
                        string nc = comboAdministrador.SelectedItem.ToString();
                        nc = nc.Substring(0, 8).Trim();
                        string user = comboAdministrador.SelectedItem.ToString();
                        user = user.Substring(9).Trim();
                        pregunta = new Question((byte)TypeIcon.Warning, "Confirmación", "¿Estas seguro de cambiar la contraseña de " + user + "?", "Sí aceptas, la contraseña del administrador " + user + " será cambiada por la que acabas de ingresar.", true);
                        dr = pregunta.ShowDialog();
                        if (dr == DialogResult.Yes)
                        {
                            negocio.ChangeOthersPassword(nc, txtNewPassword.Text.Trim());
                            LimpiarCampos();
                            pregunta = new Question((byte)TypeIcon.Info, "Tarea realizada", "Contraseña del administrador " + user + " editada", "Se ha cambiado la contraseña del \nadministrador: \"" + nc + " - " + user + "\" exitosamente.", false);
                            pregunta.Show();
                        }
                    }
                    else
                    {
                        pregunta = new Question((byte)TypeIcon.Warning, "Error de coincidencia", "Las contraseñas no coinciden", "Por favor, verifique que la nueva contraseña y su confirmación sean iguales.", false);
                        pregunta.Show();
                    }
                    pregunta.Close();
                    dr = DialogResult.No;
                    break;

                case 2:
                    LimpiarCampos();
                    break;
                case 3:
                    negocio.ComboAdministradores(comboAdministrador, "ComboAdministradores");
                    break;
                case 4: txtNewPassword.PasswordChar = (txtNewPassword.PasswordChar == '*') ? '\0' : '*'; break;
                case 5: txtConfirmPassword.PasswordChar = (txtConfirmPassword.PasswordChar == '*') ? '\0' : '*'; break;
            }
            menu = 0;
        }
    }
}
