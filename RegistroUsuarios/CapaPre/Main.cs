using CapaNegocio;
using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CapaPre
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            lbFecha.Text = DateTime.Now.ToLongDateString();
            this.Size = new Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);
            MinimumSize = new Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);
            lbInfo.Text = "";
        }

        private void HoraActual(object sender, EventArgs e)
        {
            lbHora.Text = DateTime.Now.ToLongTimeString();
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

        #region Instancias

        private Negocio negocio = new Negocio();

        #endregion Instancias

        byte servicio = 0;

        internal enum Service { ConsultaReferncia = 1, BasesDeDatos = 2, Cubiculos = 3, SalaTrabajoEquipo = 4, SalaLecutra = 5, Banios = 6, Otros = 7 }

        private void TipoServicio(object sender, EventArgs e)
        {
            switch (comboServicio.SelectedIndex)
            {
                case 0: servicio = (byte)Service.ConsultaReferncia; break;
                case 1: servicio = (byte)Service.BasesDeDatos; break;
                case 2: servicio = (byte)Service.Cubiculos; break;
                case 3: servicio = (byte)Service.SalaTrabajoEquipo; break;
                case 4: servicio = (byte)Service.SalaLecutra; break;
                case 5: servicio = (byte)Service.Banios; break;
                case 6: servicio = (byte)Service.Otros; break;
            }
        }

        private void RegistrarMovimiento(object sender, EventArgs e)
        {
            if (comboServicio.SelectedIndex >= 0 && servicio > 0)
            {
                negocio.Registry(txtNumControl.Text.Trim(), servicio);
                MessageBox.Show("Tarea Realizada");
            }
            else
            {
                lbInfo.Text = "Selecciona un servicio, por favor.";
                comboServicio.Focus();
            }
        }
    }
}
