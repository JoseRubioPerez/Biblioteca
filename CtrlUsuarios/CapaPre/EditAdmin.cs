using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPre
{
    public partial class EditAdmin : UserControl
    {
        private char supersu = 'N';

        public EditAdmin()
        {
            InitializeComponent();
        }

        private void ConfirmarSuperUsuario(object sender, EventArgs e)
        {
            supersu = (radioN.Checked || (radioN.Checked == false && radioS.Checked == false)) ? 'N' : 'S';
        }
    }
}
