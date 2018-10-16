using System;
using System.Windows.Forms;

namespace Presentation.PopUpForms
{
    public partial class PopUpFather : Form
    {
        public PopUpFather()
        {
            InitializeComponent();
        }

        private void PictureCloseClickMethod(object sender, EventArgs e)
        {
            Close();
            Dispose();
        } //PopUpFather-PCCM
    }
}
