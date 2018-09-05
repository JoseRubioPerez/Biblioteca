using CapaNegocio;
using System;
using System.Drawing;
using System.Media;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CapaPre
{

    public partial class Main : Form
    {
        #region Instancias

        private Negocio ObjBusiness = new Negocio();

        #endregion Instancias

        byte i = 0;
        private SoundPlayer audio;
        byte contador = 0;

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
                if(ObjBusiness.ExistUsuario(txtNumControl.Text.Trim()).Rows.Count > 0)
                {
                    ObjBusiness.Registry(txtNumControl.Text.Trim(), Convert.ToByte(txtServicio.Text.Trim()));
                    audio = new SoundPlayer(Environment.CurrentDirectory + @"\Sonidos\Ingresa.wav");
                    audio.Play();
                    TiempoParaPasar.Enabled = true;
                    txtNumControl.Focus();
                }
                else
                {
                    lbInfo.Text = "El usuario no existe\nNo será registrado.";
                    audio = new SoundPlayer(Environment.CurrentDirectory + @"\ElUsuarioNoExiste.wav");
                    audio.Play();
                }
                txtNumControl.Text = "";
                txtServicio.Text = "";
            }
            catch (Exception ex) { Console.WriteLine(ex.ToString()); }
        }

        private void LlenarNombreCarreraDepa(object sender, EventArgs e)
        {
            try
            {
                System.Data.DataRow row = ObjBusiness.ExistUsuario(txtNumControl.Text.Trim()).Rows[0];
                lbNombre.Text = (string.IsNullOrEmpty(txtNumControl.Text)) ? "Ingresa un número de control" : row.ItemArray[0].ToString() + " " + row.ItemArray[1].ToString() + " " + row.ItemArray[2].ToString();
                lbCarreraDepa.Text = (string.IsNullOrEmpty(txtNumControl.Text)) ? "Ingresa un número de control" : row.ItemArray[3].ToString();
            }
            catch
            {
                lbNombre.Text = "¡ESTE USUARIO NO EXISTE!";
                lbCarreraDepa.Text = "Contacte con el administrador";
            }
        }

        private void ValidarServicio(object sender, EventArgs e)
        {
            try
            {
                if (txtServicio.Text != string.Empty)
                {
                    switch (int.Parse(txtServicio.Text[0].ToString()))
                    {
                        case 8:
                        case 9:
                        case 0:
                            txtServicio.Text = txtServicio.Text.Replace(txtServicio.Text[0], '7');
                            txtServicio.Select(txtServicio.Text.Length, 0);
                            break;
                    }
                    txtServicio.Text = (char.IsNumber(txtServicio.Text[0])) ? txtServicio.Text : txtServicio.Text.Replace(txtServicio.Text[0], '\0');
                }
            }
            catch(Exception ex) { Console.WriteLine(ex.ToString()); }
        }

        private void ValidarNumControl(object sender, EventArgs e)
        {
            if(txtNumControl.Text != string.Empty)
            {
                txtNumControl.Text.ToLower();
                switch (txtNumControl.Text[0])
                {
                    case 'c': case 'b': txtNumControl.MaxLength = 9; i = 1; break;
                    default: txtNumControl.MaxLength = 8; i = 0; break;
                }
                for (; i < txtNumControl.Text.Length; i++)
                    txtNumControl.Text = (char.IsNumber(txtNumControl.Text[i])) ? txtNumControl.Text : txtNumControl.Text.Replace(txtNumControl.Text[i], '\0');
                Regex.Replace(txtNumControl.Text, "[d-z|\\s|\\W|añ]+", "");
                txtNumControl.Select(txtNumControl.Text.Length, 0);
            }
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

        private void TiempoParaPasar_Tick(object sender, EventArgs e)
        {
            if(contador < 3)
            {
                lbInfo.Visible = true;
                button1.Enabled = false;
                contador++;
                lbInfo.Text = "¡Bienvenido! Trabaja en silencio, por favor";
            }
            else if(contador >= 3)
            {
                contador = 0;
                lbInfo.Visible = false;
                button1.Enabled = true;
                TiempoParaPasar.Enabled = false;
            }
        }
    }
}
