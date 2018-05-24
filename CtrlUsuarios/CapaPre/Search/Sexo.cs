using System;
using System.Windows.Forms;

namespace CapaPre.Search
{
    public partial class Sexo : UserControl
    {
        public char sexo = 'H';

        public Sexo()
        {
            InitializeComponent();
        }

        private void Validar(object sender, EventArgs e)
        {
            sexo = (radioMujer.Checked) ? 'M' : 'H';
        }
    }
}