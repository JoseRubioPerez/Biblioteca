using System;
using System.Windows.Forms;
using Options;
using Presentation.Properties;

namespace Presentation
{
    public partial class Alerts : Form
    {
        private byte QuantityButtons;
        private readonly Button[] ArrayButton;

        public Alerts()
        {
            InitializeComponent();
            ArrayButton = new Button[] { ButtonYes, ButtonNo, ButtonCancel };
        }

        public Alerts(string LabelTitle, string LabelSubTitle, string LabelText, byte QuantityButtons = 3, string Button1 = "", string Button2 = "", string Button3 = "OK", TypeIcon Option = TypeIcon.Info)
        {
            InitializeComponent();
            ArrayButton = new Button[] { ButtonYes, ButtonNo, ButtonCancel };
            this.QuantityButtons = QuantityButtons;
            this.LabelTitle.Text = LabelTitle;
            this.LabelSubTitle.Text = LabelSubTitle;
            this.LabelText.Text = LabelText;
            ButtonYes.Text = Button1.Trim();
            ButtonNo.Text = Button2.Trim();
            ButtonCancel.Text = Button3.Trim();
            switch (Option)
            {
                case TypeIcon.Info:
                default:
                    {
                        PictureBoxIcon.Image = Resources.InformationWhite;
                        break;
                    }
                case TypeIcon.Warning:
                    {
                        PictureBoxIcon.Image = Resources.WarningWhite;
                        break;
                    }
                case TypeIcon.Danger:
                    {
                        PictureBoxIcon.Image = Resources.BugWhite;
                        break;
                    }
            }
            switch (QuantityButtons)
            {
                case 1:
                    {
                        ButtonYes.Hide();
                        ButtonNo.Hide();
                        ButtonCancel.Show();
                        ButtonCancel.DialogResult = DialogResult.OK;
                        break;
                    }
                case 2:
                    {
                        ButtonYes.Hide();
                        ButtonNo.Show();
                        ButtonNo.DialogResult = DialogResult.Yes;
                        ButtonCancel.Show();
                        ButtonCancel.DialogResult = DialogResult.No;
                        break;
                    }
                case 3:
                default:
                    {
                        ButtonYes.Show();
                        ButtonYes.DialogResult = DialogResult.Yes;
                        ButtonNo.Show();
                        ButtonNo.DialogResult = DialogResult.No;
                        ButtonCancel.Show();
                        ButtonCancel.DialogResult = DialogResult.Cancel;
                    }
                    break;

            }
        } //Clave de Método: Alerts-C

        private void PictureCloseClickMethod(object sender, EventArgs e)
        {
            Hide();
        } //Clave de Método: Alerts-PCCM
    }
}
