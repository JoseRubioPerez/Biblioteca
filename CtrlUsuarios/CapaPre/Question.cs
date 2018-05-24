using CapaPre.Properties;
using System;
using System.Windows.Forms;

namespace CapaPre
{
    public partial class Question : Form
    {
        private Control[] arreglo;
        private byte menu;

        public Question()
        {
            InitializeComponent();
            btnAceptar.DialogResult = DialogResult.Yes;
            btnCancelar.DialogResult = DialogResult.No;
        }

        public Question(byte TypeIcon, string textIcon, string titulo, string texto, bool opciones)
        {
            InitializeComponent();
            btnAceptar.DialogResult = DialogResult.Yes;
            btnCancelar.DialogResult = DialogResult.No;
            switch (TypeIcon)
            {
                case 1:pictureIcon.Image = Resources.danger; break;
                case 2: pictureIcon.Image = Resources.warning; break;
                case 3: pictureIcon.Image = Resources.help; break;
            }
            lbIcon.Text = textIcon;
            lbTitulo.Text = titulo;
            lbTexto.Text = texto;
            if (opciones)
            {
                btnAceptar.Show();
                btnCancelar.BackgroundImage = Resources.delete;
            }
            else
            {
                btnAceptar.Hide();
                btnCancelar.BackgroundImage = Resources.aceptar;
            }
        }

        private void EventoClick(object sender, EventArgs e)
        {
            arreglo = new Control[] { btnAceptar, btnCancelar, pictureClose };
            for (; menu < arreglo.Length; menu++)
            {
                if (arreglo[menu] == sender)
                    break;
            }
            switch (menu) { case 1: case 2: this.Hide(); break; }
            menu = 0;
        }
    }
}