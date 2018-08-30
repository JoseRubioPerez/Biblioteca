using BusinessLayer;
using System;
using System.Windows.Forms;

namespace Application
{
    public partial class AddAdmin : FatherConfig
    {
        #region Instancias

        private Business ObjBusiness = new Business();

        #endregion Instancias

        private DialogResult dr;
        private Control[] arreglo;
        private byte menu;
        private char supersu = 'N';

        public AddAdmin()
        {
            InitializeComponent();
            btnAceptar.Enabled = false;
        }

        private void LimpiarCampos()
        {
            txtNewPassword.Text = "";
            txtNewPassword.PasswordChar = '*';
            txtConfirmPassword.Text = "";
            txtConfirmPassword.PasswordChar = '*';
            radioN.Checked = false;
            radioS.Checked = false;
            supersu = 'N';
            btnAceptar.Enabled = false;
            dr = DialogResult.No;
        }

        private void CargarVentana(object sender, EventArgs e)
        {
            gridAddAdmin.DataSource = ObjBusiness.SelectAll("CargarUsuarios");
        }

        private void EventoClick(object sender, EventArgs e)
        {
            arreglo = new Control[] { btnAceptar, btnCancelar, pictureShowPass1, pictureShowPass2 };
            for (; menu < arreglo.Length; menu++)
            {
                if (arreglo[menu] == sender)
                    break;
            }
            switch (menu)
            {
                case 0:
                    //btnAceptar
                    Alerts pregunta;
                    try
                    {
                        if (ObjBusiness.ExistUserOrAdmin(gridAddAdmin.SelectedRows[0].Cells[0].Value.ToString(), "ExistAdmin").Rows.Count > 0)
                        {
                            pregunta = new Alerts((byte)TypeIcon.Warning, "Acción no valida", "Administrador ya existente", "El usuario " +
                                gridAddAdmin.SelectedRows[0].Cells[1].Value.ToString() + " " +
                                gridAddAdmin.SelectedRows[0].Cells[2].Value.ToString() + " " +
                                gridAddAdmin.SelectedRows[0].Cells[3].Value.ToString() + " ya es un administrador.", false);
                            pregunta.Show();
                        }
                        else
                        {
                            supersu = (!radioS.Checked && !radioN.Checked) ? 'N' : ((radioN.Checked && !radioS.Checked) ? 'N' : ((radioS.Checked && !radioN.Checked) ? 'S' : 'N'));
                            pregunta = new Alerts((byte)TypeIcon.Warning, "Agregar administrador", "¿Estas seguro en agregar un administrador?", "Se esta por agregar a " + gridAddAdmin.CurrentRow.Cells[1].Value.ToString() + " " + gridAddAdmin.CurrentRow.Cells[2].Value.ToString() + " " + gridAddAdmin.CurrentRow.Cells[3].Value.ToString() + ".", true);
                            dr = pregunta.ShowDialog();
                            if (dr == DialogResult.Yes)
                            {
                                try
                                {
                                    ObjBusiness.AddNewAdmin(gridAddAdmin.SelectedRows[0].Cells[0].Value.ToString(),
                                        gridAddAdmin.SelectedRows[0].Cells[1].Value.ToString(),
                                        gridAddAdmin.SelectedRows[0].Cells[2].Value.ToString(),
                                        gridAddAdmin.SelectedRows[0].Cells[3].Value.ToString(),
                                        Convert.ToChar(gridAddAdmin.SelectedRows[0].Cells[4].Value.ToString()),
                                        txtNewPassword.Text.Trim(), supersu);
                                }
                                catch (Exception) { Console.WriteLine("Error al agregar un administrador. Contactar al administrador."); }
                                pregunta = new Alerts((byte)TypeIcon.Info, "Tarea realizada", "Nuevo administrador agregado", "Se ha agregado a " + gridAddAdmin.SelectedRows[0].Cells[1].Value.ToString() + " " + gridAddAdmin.SelectedRows[0].Cells[2].Value.ToString() + " " + gridAddAdmin.SelectedRows[0].Cells[3].Value.ToString() + "\ncomo administrador de sistema.", false);
                                pregunta.Show();
                            }
                        }
                    }
                    catch (Exception) { Console.WriteLine("Error a la hora e registrar un nuevo administrador."); }
                    LimpiarCampos();
                    break;

                case 1:
                    //btnCancelar
                    pregunta = new Alerts((byte)TypeIcon.Warning, "Deshacer cambios", "¿Deseas deshacer los cambios que llevas hasta el momento?", "Sí aceptas, se perderán todos los cambios a nuevos usuarios que hayas realizado y no hayas guardado con el botón de \"Aceptar\".", true);
                    dr = pregunta.ShowDialog();
                    if (dr == DialogResult.Yes)
                        LimpiarCampos();

                    /*if (!(string.IsNullOrEmpty(txtNewPassword.Text.Trim())) && !(string.IsNullOrEmpty(txtConfirmPassword.Text.Trim())) && (radioN.Checked || radioS.Checked))
                    {
                        pregunta = new Question((byte)TypeIcon.Warning, "Deshacer cambios", "¿Deseas deshacer los cambios que llevas hasta el momento?", "Sí aceptas, se perderán todos los cambios a nuevos usuarios que hayas realizado y no hayas guardado con el botón de \"Aceptar\".", true);
                        DialogResult dr = pregunta.ShowDialog();
                        if (dr == DialogResult.Yes)
                            LimpiarCampos();
                    }
                    else
                    {
                        pregunta = new Question((byte)TypeIcon.Warning, "Campos incompletos", "Campos obligatorios vacios o sin asignar", "Asegurese de tener seleccionada la fila del usuario que será un nuevo administrador\nla nueva contraseña para el nuevo administrador, su confirmación y el\npermiso de \"Super Usuario\" asignado", false);
                        pregunta.Show();
                    }*/
                    dr = DialogResult.No;
                    break;

                case 2: txtNewPassword.PasswordChar = (txtNewPassword.PasswordChar == '*') ? '\0' : '*'; break;

                case 3: txtConfirmPassword.PasswordChar = (txtConfirmPassword.PasswordChar == '*') ? '\0' : '*'; break;
            }
            menu = 0;
        }

        private void ConfirmPassword(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(txtConfirmPassword.Text.Trim())) && !(string.IsNullOrEmpty(txtNewPassword.Text.Trim())) && txtNewPassword.Text.Trim().Equals(txtConfirmPassword.Text.Trim()))
                btnAceptar.Enabled = true;
            else
                btnAceptar.Enabled = false;
        }
    }
}