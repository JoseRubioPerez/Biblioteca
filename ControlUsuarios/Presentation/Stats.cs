using System;
using System.Windows.Forms;
using Business;
using Entity;
using Options;
using Presentation.PopUpForms;

namespace Presentation
{
    public partial class Stats : FormFather
    {
        private Validations ObjValidations = new Validations();
        private readonly Session ObjSession = new Session();
        private Search ObjSearch = new Search();
        private readonly Control[] ArrayControl;
        private readonly RadioButton[] ArrayRadioDate;
        private readonly RadioButton[] ArrayRadioSex;
        private readonly CheckBox[] ArrayCheckBox;
        private byte Index;

        public Stats(Session ObjSession)
        {
            InitializeComponent();
            this.ObjSession = ObjSession;
            PanelDate.Visible = false;
            ArrayControl = new Control[] { ButtonCreateReport, ButtonCancel, PictureBoxInfo };
            ArrayRadioSex = new RadioButton[] { RadioButtonWoman, RadioButtonMan, RadioButtonBothSex };
            ArrayRadioDate = new RadioButton[] { RadioButtonToday, RadioButtonWeek, RadioButtonMonth, RadioButtonYear, RadioButtonAnyDate, RadioButtonPersonalize };
            ArrayCheckBox = new CheckBox[] { CheckBoxService1, CheckBoxService2, CheckBoxService3, CheckBoxService4, CheckBoxService5, CheckBoxService6, CheckBoxService7 };
            RadioButtonWoman.Checked = false;
            RadioButtonToday.Checked = false;
        } //Clave de Método: Stats-C1

        public void CleanInputsMethod()
        {
            DateTimePickerStart.Value = DateTime.Now;
            DateTimePickerEnd.Value = DateTime.Now;
            foreach (RadioButton Value in ArrayRadioSex) Value.Checked = false;
            foreach (RadioButton Value in ArrayRadioDate) Value.Checked = false;
            foreach (CheckBox Value in ArrayCheckBox) Value.Checked = false;
            PanelDate.Visible = false;
        } //Clave de Método: Stats-CIM

        private void ControlClickMethod(object sender, EventArgs e)
        {
            for (; Index < ArrayControl.Length; Index++)
                if (ArrayControl[Index] == sender)
                    break;
            switch (Index)
            {
                case 0: //ButtonCreateReport
                    {
                        byte i = 0;
                        byte aux = 0;
                        try
                        {
                            foreach (RadioButton Value in ArrayRadioDate) if (!Value.Checked) i++; else aux = i;
                            if (i == 6) throw new Exception();
                            switch (aux)
                            {
                                case 0:
                                    {
                                        ObjSearch.DateStart = DateTime.Now;
                                        ObjSearch.DateEnd = DateTime.Now;
                                        break;
                                    }
                                case 1:
                                    {
                                        ObjSearch.DateStart = DateTime.Now.AddDays(-7);
                                        ObjSearch.DateEnd = DateTime.Now;
                                        break;
                                    }
                                case 2:
                                    {
                                        ObjSearch.DateStart = DateTime.Now.AddMonths(-1);
                                        ObjSearch.DateEnd = DateTime.Now;
                                        break;
                                    }
                                case 3:
                                    {
                                        ObjSearch.DateStart = DateTime.Now.AddYears(-1);
                                        ObjSearch.DateEnd = DateTime.Now;
                                        break;
                                    }
                                case 4:
                                    {
                                        ObjSearch.DateStart = DateTime.Parse("2016-01-01");
                                        ObjSearch.DateEnd = DateTime.Now;
                                        break;
                                    }
                                case 5:
                                    {
                                        ObjSearch.DateStart = DateTimePickerStart.Value;
                                        ObjSearch.DateEnd = DateTimePickerEnd.Value;
                                        break;
                                    }
                                default:
                                    throw new Exception();
                            }
                            i = 0;
                            foreach (CheckBox Value in ArrayCheckBox) if (!Value.Checked) i++;
                            if (i == 7) throw new Exception();

                            if (RadioButtonBothSex.Checked || (!RadioButtonBothSex.Checked && !RadioButtonMan.Checked && !RadioButtonWoman.Checked))
                            {
                                ObjSearch.SexStart = 'M';
                                ObjSearch.SexEnd = 'F';
                            }
                            else if (RadioButtonMan.Checked)
                            {
                                ObjSearch.SexStart = 'M';
                                ObjSearch.SexEnd = 'M';
                            }
                            else
                            {
                                ObjSearch.SexStart = 'F';
                                ObjSearch.SexEnd = 'F';
                            }
                            i = 1;
                            foreach (CheckBox Value in ArrayCheckBox)
                            {
                                if (Value.Checked) ObjSearch.Services.Add(i); else ObjSearch.Services.Add(0);
                                i++;
                            }
                            ObjValidations.SearchStats(TypeModules.Stats, ObjSearch);
                            PopUpGridSearch ObjPopUpGridSearch = new PopUpGridSearch(TypeModules.Moves, ObjSearch, "Búsqueda para Reportes");
                            ObjPopUpGridSearch.Show();
                        }
                        catch (Exception)
                        {
                            Alerts ObjAlerts = new Alerts("Falta Elegir Opciones", "", "Parece ser que no elegiste ningún tipo de servicio o ningún tipo de fecha. Estos datos son necesarios para generar el reporte.\n\nPor favor, elige algún servicio y alguna fecha para continuar.", 1);
                            ObjAlerts.ShowDialog();
                        }
                        finally
                        {
                            i = 0;
                            ObjSearch.Services.Clear();
                        }
                        break;
                    }
                case 1: //ButtonCancel
                    {
                        CleanInputsMethod();
                        break;
                    }
                case 2: //PictureBoxInfo
                    {
                        break;
                    }
                default:
                    throw new Exception("Excepción en Método: Stats-CCM", new IndexOutOfRangeException());
            }
            Index = 0;
        } //Clave de Método: Stats-CCM

        private void RadioButtonPersonalizeCheckedChangedMethod(object sender, EventArgs e)
        {
            PanelDate.Visible = RadioButtonPersonalize.Checked;
        }
    }
}
