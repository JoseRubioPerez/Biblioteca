﻿using BusinessLayer;
using System;
using System.Windows.Forms;

namespace Application
{
    public partial class ChangeOthersPasswords : FatherConfig
    {
        #region Instancias

        private Business ObjBusiness = new Business();

        #endregion Instancias

        private Control[] arreglo;
        private byte menu;
        public string[] Admin = new string[2];
        public char supersu;
        private DialogResult dr;

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
                    Alerts pregunta;
                    if (txtNewPassword.Text.Trim() == txtConfirmPassword.Text.Trim())
                    {
                        string nc = comboAdministrador.SelectedItem.ToString();
                        nc = nc.Substring(0, 8).Trim();
                        string user = comboAdministrador.SelectedItem.ToString();
                        user = user.Substring(9).Trim();
                        pregunta = new Alerts((byte)TypeIcon.Warning, "Confirmación", "¿Estas seguro de cambiar la contraseña de " + user + "?", "Sí aceptas, la contraseña del administrador " + user + " será cambiada por la que acabas de ingresar.", true);
                        dr = pregunta.ShowDialog();
                        if (dr == DialogResult.Yes)
                        {
                            ObjBusiness.ChangeOthersPassword(nc, txtNewPassword.Text.Trim());
                            LimpiarCampos();
                            pregunta = new Alerts((byte)TypeIcon.Info, "Tarea realizada", "Contraseña del administrador " + user + " editada", "Se ha cambiado la contraseña del \nadministrador: \"" + nc + " - " + user + "\" exitosamente.", false);
                            pregunta.Show();
                        }
                    }
                    else
                    {
                        pregunta = new Alerts((byte)TypeIcon.Warning, "Error de coincidencia", "Las contraseñas no coinciden", "Por favor, verifique que la nueva contraseña y su confirmación sean iguales.", false);
                        pregunta.Show();
                    }
                    pregunta.Close();
                    dr = DialogResult.No;
                    break;

                case 2:
                    LimpiarCampos();
                    break;

                case 3:
                    ObjBusiness.LlenarCombo(comboAdministrador, "ComboAdministradores", 0);
                    break;

                case 4: txtNewPassword.PasswordChar = (txtNewPassword.PasswordChar == '*') ? '\0' : '*'; break;
                case 5: txtConfirmPassword.PasswordChar = (txtConfirmPassword.PasswordChar == '*') ? '\0' : '*'; break;
            }
            menu = 0;
        }
    }
}