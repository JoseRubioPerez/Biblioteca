using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPre
{
    public partial class AddAdmin : UserControl
    {
        private Control[] arreglo;
        private byte menu;
        private char supersu = 'N';

        public AddAdmin()
        {
            InitializeComponent();
            btnAceptar.Enabled = false;
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
                    
                    break;
                case 1:
                    if (!(string.IsNullOrEmpty(txtNewPassword.Text.Trim())) && !(string.IsNullOrEmpty(txtConfirmPassword.Text.Trim())) && (radioN.Checked || radioS.Checked))
                    {
                        Question pregunta = new Question((byte)TipoIcono.Warning, "Deshacer cambios", "¿Deseas deshacer los cambios que llevas hasta el momento?", "Sí aceptas, se perderán todos los cambios a nuevos usuarios que hayas realizado y no hayas guardado con el botón de \"Aceptar\".", true);
                        DialogResult dr = pregunta.ShowDialog();
                        if (dr == DialogResult.Yes)
                        {
                            txtNewPassword.Text = "";
                            txtNewPassword.PasswordChar = '*';
                            txtConfirmPassword.Text = "";
                            txtConfirmPassword.PasswordChar = '*';
                            radioN.Checked = false;
                            radioS.Checked = false;
                        }
                    }
                    else
                    {
                        Question pregunta = new Question((byte)TipoIcono.Warning, "Campos incompletos", "Campos obligatorios vacios o sin asignar", "Asegurese de tener seleccionada la fila del usuario que será un nuevo administrador\nla nueva contraseña para el nuevo administrador, su confirmación y el\npermiso de \"Super Usuario\" asignado", false);
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
