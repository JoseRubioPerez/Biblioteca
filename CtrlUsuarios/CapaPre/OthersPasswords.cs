using CapaNegocio;
using System;
using System.Windows.Forms;

namespace CapaPre
{
    public partial class OthersPasswords : UserControl
    {
        #region Instancias

        private Negocio negocio = new Negocio();

        #endregion Instancias

        private Control[] arreglo;
        private byte menu;
        public string[] Admin = new string[2];
        public char supersu;

        public OthersPasswords()
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
            arreglo = new Control[] { btnBuscar, btnAceptar, btnCancelar };
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
                    if (txtNewPassword.Text.Trim() == txtConfirmPassword.Text.Trim())
                    {
                        string nc = comboAdministrador.SelectedItem.ToString();
                        nc = nc.Substring(0, 8).Trim();
                        string user = comboAdministrador.SelectedItem.ToString();
                        user = user.Substring(9).Trim();
                        negocio.ChangeOthersPassword(nc, txtNewPassword.Text.Trim());
                        Question pregunta = new Question((byte)TipoIcono.Info, "Tarea realizada", "Contraseña del administrador " + user + " editada", "Se ha cambiado la contraseña del \nadministrador: \"" + nc + " - " + user + "\" exitosamente.", false);
                        pregunta.Show();
                        LimpiarCampos();
                    }
                    else
                    {
                        Question pregunta = new Question((byte)TipoIcono.Warning, "Error de coincidencia", "Las contraseñas no coinciden", "Por favor, verifique que la nueva contraseña y su confirmación sean iguales.", false);
                        pregunta.Show();
                    }
                    break;

                case 2:
                    LimpiarCampos();
                    break;
            }
            menu = 0;
        }

        private void ElegirAdministrador(object sender, EventArgs e)
        {
            negocio.ComboAdministradores(comboAdministrador, "ComboAdministradores");
        }
    }
}