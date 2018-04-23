using CapaNegocio;
using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CapaPre
{
    internal enum Servicio { ConsultaReferncia = 1, BasesDeDatos = 2, Cubiculos = 3, SalaTrabajoEquipo = 4, SalaLecutra = 5, Banios = 6, Otros = 7 }

    public partial class Main : Form
    {
        #region Instancias

        private Negocio negocio = new Negocio();

        #endregion Instancias

        public Main()
        {
            InitializeComponent();
            lbFecha.Text = DateTime.Now.ToLongDateString();
            this.Size = new Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);
            MinimumSize = new Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);
        }

        private void HoraActual(object sender, EventArgs e)
        {
            lbHora.Text = DateTime.Now.ToLongTimeString();
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

        private void ValidarNumControl(object sender, EventArgs e)
        {
            //[b-c]{2,}
            //(bc){2,}
            if (Regex.IsMatch(txtNumControl.Text, "(cb)?[A-Z|d-z|\\s|\\D|añÑ]+") || txtNumControl.Text.Length > 8)
            {
                txtNumControl.Text = txtNumControl.Text.Substring(0, (txtNumControl.Text.Length - 1));
            }
            txtNumControl.Select(txtNumControl.Text.Length, 0);
        }
    }
}
