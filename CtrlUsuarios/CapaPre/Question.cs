using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaPre.Properties;

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

        public Question(byte tipoIcono, string textIcon, string titulo, string texto, bool opciones)
        {
            InitializeComponent();
            btnAceptar.DialogResult = DialogResult.Yes;
            btnCancelar.DialogResult = DialogResult.No;
            switch (tipoIcono)
            {
                case 1: //danger
                    pictureIcon.Image = Resources.danger;
                    break;

                case 2: //warning
                    pictureIcon.Image = Resources.warning;
                    break;

                case 3: //info
                    pictureIcon.Image = Resources.help;
                    break;
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
            switch (menu)
            {
                case 1:
                case 2:
                    this.Hide();
                    break;
            }
            menu = 0;
        }
    }
}
