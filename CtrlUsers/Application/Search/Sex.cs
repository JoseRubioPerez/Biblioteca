using System;
using System.Windows.Forms;

namespace Application.Search
{
    public partial class Sex : UserControl
    {
        public char sexo = 'H';

        public Sex()
        {
            InitializeComponent();
        }

        private void Validar(object sender, EventArgs e)
        {
            sexo = (radioMujer.Checked) ? 'M' : 'H';
        }
    }
}