using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
