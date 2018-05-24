using System;
using System.Windows.Forms;

namespace CapaPre.Search
{
    public partial class Status : UserControl
    {
        public char status = 'A';

        public Status()
        {
            InitializeComponent();
        }

        private void Validar(object sender, EventArgs e)
        {
            status = (radioInactivo.Checked) ? 'I' : 'A';
        }
    }
}