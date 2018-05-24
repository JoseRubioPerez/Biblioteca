using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CapaPre.Search
{
    public partial class NumControl : UserControl
    {
        private byte i = 0;

        public NumControl()
        {
            InitializeComponent();
        }

        private void Validar(object sender, EventArgs e)
        {
            //Número de Control
            txtNumControl.Text.ToLower();
            try
            {
                if (!txtNumControl.Text.Equals(""))
                {
                    switch (txtNumControl.Text[0])
                    {
                        case 'c': case 'b': txtNumControl.MaxLength = 9; i = 1; break;
                        default: txtNumControl.MaxLength = 8; i = 0; break;
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Ocurrió un error:\n" + ex.ToString()); }
            for (; i < txtNumControl.Text.Length; i++)
                txtNumControl.Text = (char.IsNumber(txtNumControl.Text[i])) ? txtNumControl.Text : txtNumControl.Text.Replace(txtNumControl.Text[i], '\0');
            Regex.Replace(txtNumControl.Text, "[d-z|\\s|\\W|añ]+", "");
            txtNumControl.Select(txtNumControl.Text.Length, 0);
        }
    }
}