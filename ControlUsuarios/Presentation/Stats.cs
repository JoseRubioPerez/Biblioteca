using System;
using System.Windows.Forms;
using Business;
using Entity;

namespace Presentation
{
    public partial class Stats : FormFather
    {
        private Validations ObjValidations = new Validations();
        private readonly Session ObjSession = new Session();
        private readonly Control[] ArrayControl;
        private readonly RadioButton[] ArrayRadio;
        private readonly CheckBox[] ArrayCheckBox;
        private DialogResult ObjDialog;
        private Alerts ObjAlerts;
        private byte Index;

        public Stats()
        {
            InitializeComponent();
            PanelDate.Visible = false;
            RadioButtonWoman.Checked = true;
            RadioButtonToday.Checked = true;
            ArrayControl = new Control[] { ButtonCreateReport, ButtonCancel, PictureBoxInfo };
            ArrayRadio = new RadioButton[] { RadioButtonWoman, RadioButtonMan, RadioButtonToday, RadioButtonWeek, RadioButtonMonth, RadioButtonYear, RadioButtonAll, RadioButtonPersonalize };
            ArrayCheckBox = new CheckBox[] { CheckBoxService1, CheckBoxService2, CheckBoxService3, CheckBoxService4, CheckBoxService5, CheckBoxService6, CheckBoxService7 };
        }

        public Stats(Session ObjSession)
        {
            InitializeComponent();
            this.ObjSession = ObjSession;
            PanelDate.Visible = false;
            RadioButtonWoman.Checked = true;
            RadioButtonToday.Checked = true;
            ArrayControl = new Control[] { ButtonCreateReport, ButtonCancel, PictureBoxInfo };
            ArrayRadio = new RadioButton[] { RadioButtonWoman, RadioButtonMan, RadioButtonToday, RadioButtonWeek, RadioButtonMonth, RadioButtonYear, RadioButtonAll, RadioButtonPersonalize };
        }

        private void ControlClickMethod(object sender, EventArgs e)
        {
            for (; Index < ArrayControl.Length; Index++)
                if (ArrayControl[Index] == sender)
                    break;
            switch (Index)
            {
                case 0:
                    {
                        break;
                    }
                case 1:
                    {
                        DateTimePickerStart.Value = DateTime.Now.AddYears(-1);
                        DateTimePickerEnd.Value = DateTime.Now;
                        foreach (RadioButton Value in ArrayRadio) Value.Checked = false;
                        foreach (CheckBox Value in ArrayCheckBox) Value.Checked = false;
                        RadioButtonWoman.Checked = true;
                        RadioButtonToday.Checked = true;
                        PanelDate.Visible = false;
                        break;
                    }
                case 2:
                    {
                        break;
                    }
                default:
                    throw new Exception("Excepción en Método: Reports-CCM", new IndexOutOfRangeException());
            }
        } //Clave de Método: Reports-CCM
    }
}
