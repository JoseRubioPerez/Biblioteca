using System.Drawing;
using System.Windows.Forms;

namespace Presentation.Inputs
{
    public partial class TextBoxUI : UserControl
    {
        public TextBoxUI()
        {
            InitializeComponent();
        }

        public Color BackColorTextBox { get { return TextBoxControl.BackColor; } set { TextBoxControl.BackColor = value; } }
        public Color ForeColorTextBox { get { return TextBoxControl.ForeColor; } set { TextBoxControl.ForeColor = value; } }
        public string TextTextBox { get { return TextBoxControl.Text; } set { TextBoxControl.Text = value; } }
        public char PasswordTextBox { get { return TextBoxControl.PasswordChar; } set { TextBoxControl.PasswordChar = value; } }
        public int MaxLengthTextBox { get { return TextBoxControl.MaxLength; } set { TextBoxControl.MaxLength = value; } }
        public bool EnableTextBox { get { return TextBoxControl.Enabled; } set { TextBoxControl.Enabled = value; } }
        public int SelectionStartTextBox { get { return TextBoxControl.SelectionStart; } set { TextBoxControl.SelectionStart = value; } }
        public int SelectionLengthTextBox { get { return TextBoxControl.SelectionLength; } set { TextBoxControl.SelectionLength = value; } }


        public Color BackColorLabel { get { return LabelControl.BackColor; } set { LabelControl.BackColor = value; } }
        public Color ForeColorLabel { get { return LabelControl.ForeColor; } set { LabelControl.ForeColor = value; } }
        public string TextLabel { get { return LabelControl.Text; } set { LabelControl.Text = value; } }

        public Color BackColorPanel { get { return PanelControl.BackColor; } set { PanelControl.BackColor = value; } }
    }
}
