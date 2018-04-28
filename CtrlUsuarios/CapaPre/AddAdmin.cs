using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPre
{
    public partial class AddAdmin : UserControl
    {
        #region Instancias

        Negocio negocio = new Negocio();

        #endregion

        private Control[] arreglo;
        private byte menu;
        private char supersu = 'N';

        public AddAdmin()
        {
            InitializeComponent();
            btnAceptar.Enabled = false;
            //GridAdmin.SelectedRows[0].Selected = false;
        }

        private bool Validar()
        {
            if ((radioN.Checked == false && radioS.Checked == false) || txtNewPassword.Text.Trim() != txtConfirmPassword.Text.Trim() || string.IsNullOrEmpty(txtNewPassword.Text.Trim()) || string.IsNullOrEmpty(txtConfirmPassword.Text.Trim()))
            {
                supersu = 'N';
                return false;
            }
            else
            {
                supersu = (radioN.Checked) ? 'N' : 'S';
                return true;
            }
        }

        private void LimpiarCampos()
        {
            txtNewPassword.Text = "";
            txtNewPassword.PasswordChar = '*';
            txtConfirmPassword.Text = "";
            txtConfirmPassword.PasswordChar = '*';
            radioN.Checked = false;
            radioS.Checked = false;
            GridAdmin.SelectedRows[0].Selected = false;
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
                    Question pregunta;
                    try
                    {
                        if(negocio.ExistUserOrAdmin(GridAdmin.SelectedRows[0].Cells[0].Value.ToString(), "ExistAdmin").Rows.Count > 0)
                        {
                            pregunta = new Question((byte)TipoIcono.Warning, "Acción no valida", "Administrador ya existente", "El usuario " + 
                                GridAdmin.SelectedRows[0].Cells[1].Value.ToString() + " " + 
                                GridAdmin.SelectedRows[0].Cells[2].Value.ToString() + " " + 
                                GridAdmin.SelectedRows[0].Cells[3].Value.ToString() + " ya es un administrador.", false);
                            pregunta.Show();
                        }
                        else
                        {
                            negocio.AddNewAdmin(GridAdmin.SelectedRows[0].Cells[0].Value.ToString(),
                                GridAdmin.SelectedRows[0].Cells[1].Value.ToString(),
                                GridAdmin.SelectedRows[0].Cells[2].Value.ToString(),
                                GridAdmin.SelectedRows[0].Cells[3].Value.ToString(),
                                Convert.ToChar(GridAdmin.SelectedRows[0].Cells[4].Value.ToString()),
                                txtNewPassword.Text.Trim(), supersu);
                            pregunta = new Question((byte)TipoIcono.Info, "Tarea realizada", "Nuevo administrador agregado", "Se ha agregado a " + GridAdmin.SelectedRows[0].Cells[1].Value.ToString() + " " + GridAdmin.SelectedRows[0].Cells[2].Value.ToString() + " " +GridAdmin.SelectedRows[0].Cells[3].Value.ToString() + "\ncomo administrador de sistema.", false);
                            pregunta.Show();
                        }
                    }
                    catch(Exception) { Console.WriteLine("Error a la hora e registrar un nuevo administrador.\n"); }
                    LimpiarCampos();
                    break;
                case 1:
                    //btnCancelar
                    if (!(string.IsNullOrEmpty(txtNewPassword.Text.Trim())) && !(string.IsNullOrEmpty(txtConfirmPassword.Text.Trim())) && (radioN.Checked || radioS.Checked))
                    {
                        pregunta = new Question((byte)TipoIcono.Warning, "Deshacer cambios", "¿Deseas deshacer los cambios que llevas hasta el momento?", "Sí aceptas, se perderán todos los cambios a nuevos usuarios que hayas realizado y no hayas guardado con el botón de \"Aceptar\".", true);
                        DialogResult dr = pregunta.ShowDialog();
                        if (dr == DialogResult.Yes)
                            LimpiarCampos();
                    }
                    else
                    {
                        pregunta = new Question((byte)TipoIcono.Warning, "Campos incompletos", "Campos obligatorios vacios o sin asignar", "Asegurese de tener seleccionada la fila del usuario que será un nuevo administrador\nla nueva contraseña para el nuevo administrador, su confirmación y el\npermiso de \"Super Usuario\" asignado", false);
                        pregunta.Show();
                    }
                    break;
                case 2: txtNewPassword.PasswordChar = (txtNewPassword.PasswordChar == '*') ? '\0' : '*'; break;

                case 3: txtConfirmPassword.PasswordChar = (txtConfirmPassword.PasswordChar == '*') ? '\0' : '*'; break;
            }
            menu = 0;
        }

        private void ConfirmPassword(object sender, EventArgs e)
        {
            btnAceptar.Enabled = Validar();
        }
    }
}
