using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business;
using Entity;

namespace Presentation
{
    public partial class Reports : FormFather
    {
        private Validations ObjValidations = new Validations();
        private readonly Session ObjSession = new Session();
        private readonly Control[] ArrayControl;
        private readonly RadioButton[] ArrayRadio;
        private readonly CheckBox[] ArrayCheckBox;
        private DialogResult ObjDialog;
        private Alerts ObjAlerts;
        private byte Index;

        public Reports()
        {
            InitializeComponent();
            PanelDate.Visible = false;
            RadioButtonWoman.Checked = true;
            RadioButtonToday.Checked = true;
            ArrayControl = new Control[] { ButtonCreateReport, ButtonCancel, PictureBoxInfo };
            ArrayRadio = new RadioButton[] { RadioButtonWoman, RadioButtonMan, RadioButtonToday, RadioButtonWeek, RadioButtonMonth, RadioButtonPersonalize, RadioButtonAll };
            ArrayCheckBox = new CheckBox[] { CheckBoxService1, CheckBoxService2, CheckBoxService3, CheckBoxService4, CheckBoxService5, CheckBoxService6, CheckBoxService7 };
        }

        public Reports(Session ObjSession)
        {
            InitializeComponent();
            this.ObjSession = ObjSession;
            PanelDate.Visible = false;
            RadioButtonWoman.Checked = true;
            RadioButtonToday.Checked = true;
            ArrayControl = new Control[] { ButtonCreateReport, ButtonCancel, PictureBoxInfo };
            ArrayRadio = new RadioButton[] { RadioButtonWoman, RadioButtonMan, RadioButtonToday, RadioButtonWeek, RadioButtonMonth, RadioButtonPersonalize, RadioButtonAll };
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
