using CapaNegocio;
using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CapaPre
{

    public partial class Main : Form
    {
        #region Instancias

        private Negocio negocio = new Negocio();

        #endregion Instancias

        byte i = 0;

        public Main()
        {
            InitializeComponent();
            lbFecha.Text = DateTime.Now.ToLongDateString();
            this.Size = new Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);
            MinimumSize = new Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);
            lbInfo.Text = "";
        }

        private void RegistrarMovimiento(object sender, EventArgs e)
        {
            try
            {
                negocio.Registry(txtNumControl.Text.Trim(), Convert.ToByte(txtServicio.Text.Trim()));
                lbInfo.Text = "Por favor, ingresa en menos de: ";
                txtNumControl.Focus();
                //Activar temporizador en el lbInfo
            }
            catch (Exception ex) { Console.WriteLine(ex.ToString()); }
        }

        private void LlenarNombreCarreraDepa(object sender, EventArgs e)
        {
            lbNombre.Text = (string.IsNullOrEmpty(txtNumControl.Text)) ? "Ingresa un número de control" : negocio.ExistUsuario(txtNumControl.Text.Trim()).Rows[0]["nombres"].ToString() + " " + negocio.ExistUsuario(txtNumControl.Text.Trim()).Rows[0]["apellidopat"].ToString() + " " + negocio.ExistUsuario(txtNumControl.Text.Trim()).Rows[0]["apellidomat"].ToString();
            lbCarreraDepa.Text = (string.IsNullOrEmpty(txtNumControl.Text)) ? "Ingresa un número de control" : negocio.ExistUsuario(txtNumControl.Text.Trim()).Rows[0]["area"].ToString();
        }

        private void ValidarServicio(object sender, EventArgs e)
        {
            switch (txtServicio.Text[0]) { case '8': case '9': case '0': txtServicio.Text = txtServicio.Text.Replace(txtServicio.Text[0], '\0'); break; }
            txtServicio.Text = (char.IsNumber(txtServicio.Text[0])) ? txtServicio.Text : txtServicio.Text.Replace(txtServicio.Text[0], '\0');
        }

        private void ValidarNumControl(object sender, EventArgs e)
        {
            txtNumControl.Text.ToLower();
            switch (txtNumControl.Text[0]) { case 'c': case 'b': txtNumControl.MaxLength = 9; i = 1; break; default: txtNumControl.MaxLength = 8; i = 0; break; }
            for (; i < txtNumControl.Text.Length; i++)
                txtNumControl.Text = (char.IsNumber(txtNumControl.Text[i])) ? txtNumControl.Text : txtNumControl.Text.Replace(txtNumControl.Text[i], '\0');
            Regex.Replace(txtNumControl.Text, "[d-z|\\s|\\W|añ]+", "");
            txtNumControl.Select(txtNumControl.Text.Length, 0);
            //14 54 00 74
            //01 23 45 67
            /*txtNumControl.Text = (txtNumControl.Text[2] != '5') ? txtNumControl.Text.Substring(2, 1) : txtNumControl.Text;
            txtNumControl.Text = (txtNumControl.Text[3] != '4') ? txtNumControl.Text.Substring(3, 1) : txtNumControl.Text;*/

            //lbNombre.Text = negocio.ExistUsuario(txtNumControl.Text.Trim()).Rows[0]["nombres"].ToString() + " " + negocio.ExistUsuario(txtNumControl.Text.Trim()).Rows[0]["apellidopat"].ToString() + " " + negocio.ExistUsuario(txtNumControl.Text.Trim()).Rows[0]["apellidomat"].ToString();
            //lbCarreraDepa.Text = negocio.ExistUsuario(txtNumControl.Text.Trim()).Rows[0]["area"].ToString();
        }

        private void CancelarF4(object sender, FormClosingEventArgs e)
        {
            switch (e.CloseReason)
            {
                case CloseReason.UserClosing: e.Cancel = true; break;
                case CloseReason.ApplicationExitCall: e.Cancel = false; break;
            }
        }

        private void CerrarPrograma(object sender, EventArgs e)
        {
            LogOut logout = new LogOut();
            logout.Show();
        }

        private void HoraActual(object sender, EventArgs e) { lbHora.Text = DateTime.Now.ToLongTimeString(); }
    }
}
