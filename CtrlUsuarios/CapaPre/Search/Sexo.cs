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
