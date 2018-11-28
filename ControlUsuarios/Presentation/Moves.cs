using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Entity;
using Business;
using Options;
using Presentation.PopUpForms;

namespace Presentation
{
    public partial class Moves : FormFather
    {
        private Validations ObjValidations = new Validations();
        private readonly Session ObjSession = new Session();
        private Search ObjSearch = new Search();
        private DataTable TablaComboDepartment = new DataTable();
        private List<string> ListCombo = new List<string>();
        //private Alerts ObjAlerts;
        private readonly Control[] ArrayControl;
        private byte Index;

        public Moves(Session ObjSession)
        {
            InitializeComponent();
            this.ObjSession = ObjSession;
            ArrayControl = new Control[] { ButtonSearch, ButtonSearchAll, ButtonCleanSearch, PictureBoxInfo };
            MovesLoadMethod();
        } //Clave de Constructor: Moves-C1

        private void MovesLoadMethod()
        {
            TablaComboDepartment = ObjValidations.GridSearchMethod(TypeModules.Users, TypeSearch.Areas);
            foreach (DataRow row in TablaComboDepartment.Rows) ListCombo.Add(row["AREA"].ToString());
            ComboDepartment.DataSource = ListCombo;
            ComboDepartment.Visible = false;
            RadioButtonAll.Checked = false;
            RadioButtonMan.Checked = false;
            RadioButtonWoman.Checked = false;
            RadioButtonAllDepartments.Checked = false;
            RadioButtonSearchDepartment.Checked = false;
            DateTimePickerStart.Value = DateTime.Now.AddMonths(-1);
            DateTimePickerEnd.Value = DateTime.Now;
        } //Clave de Método: Moves-MLM

        private void ControlClickMethod(object sender, EventArgs e)
        {
            for (; Index < ArrayControl.Length; Index++)
                if (ArrayControl[Index] == sender)
                    break;
            switch (Index)
            {
                case 0: // ButtonSearch
                    {
                        ObjSearch.FirstLastName = ObjValidations.OnlyWordsMethod(TextBoxFirstLastName.TextTextBox.ToUpper().Trim());
                        ObjSearch.SecondLastName = ObjValidations.OnlyWordsMethod(TextBoxSecondLastName.TextTextBox.ToUpper().Trim());
                        if (RadioButtonAllDepartments.Checked || (!RadioButtonAllDepartments.Checked && !RadioButtonSearchDepartment.Checked))
                        {
                            ObjSearch.IndexDeparmentStart = 0;
                            ObjSearch.IndexDeparmentEnd = 30;
                        }
                        else
                        {
                            ObjSearch.IndexDeparmentStart = ComboDepartment.SelectedIndex;
                            ObjSearch.IndexDeparmentEnd = ComboDepartment.SelectedIndex;
                        }
                        if (RadioButtonAll.Checked || (!RadioButtonAll.Checked && !RadioButtonMan.Checked && !RadioButtonWoman.Checked))
                        {
                            ObjSearch.SexStart = 'M';
                            ObjSearch.SexEnd = 'F';
                        }
                        else if(RadioButtonMan.Checked)
                        {
                            ObjSearch.SexStart = 'M';
                            ObjSearch.SexEnd = 'M';
                        }
                        else
                        {
                            ObjSearch.SexStart = 'F';
                            ObjSearch.SexEnd = 'F';
                        }
                        ObjSearch.DateStart = DateTimePickerStart.Value;
                        ObjSearch.DateEnd = DateTimePickerEnd.Value;
                        ObjValidations.SearchMoves(TypeModules.Moves, ObjSearch);
                        PopUpGridSearch ObjPopUpGridSearch = new PopUpGridSearch(TypeModules.Moves, ObjSearch, "Búsqueda de Movimientos");
                        ObjPopUpGridSearch.Show();
                        break;
                    }
                case 1: // ButtonSearchAll
                    {
                        ObjSearch.FirstLastName = "";
                        ObjSearch.SecondLastName = "";
                        ObjSearch.IndexDeparmentStart = 0;
                        ObjSearch.IndexDeparmentEnd = 30;
                        ObjSearch.SexStart = 'A';
                        ObjSearch.SexEnd = 'A';
                        ObjSearch.DateStart = DateTimePickerStart.Value;
                        ObjSearch.DateEnd = DateTimePickerEnd.Value;
                        ObjValidations.SearchMoves(TypeModules.Moves, ObjSearch);
                        PopUpGridSearch ObjPopUpGridSearch = new PopUpGridSearch(TypeModules.Moves, ObjSearch, "Búsqueda de Movimientos");
                        ObjPopUpGridSearch.Show();
                        break;
                    }
                case 2: //ButtonCleanSearch
                    {
                        RadioButtonAll.Checked = false;
                        RadioButtonMan.Checked = false;
                        RadioButtonWoman.Checked = false;
                        RadioButtonAllDepartments.Checked = false;
                        RadioButtonSearchDepartment.Checked = false;
                        ComboDepartment.Visible = false;
                        DateTimePickerStart.Value = DateTime.Now.AddMonths(-1);
                        DateTimePickerEnd.Value = DateTime.Now;
                        break;
                    }
                default:
                    throw new Exception("Excepción en Método: Moves-CCM", new IndexOutOfRangeException());
            }
            Index = 0;
        } //Clave de Método: Moves-CCM

        private void RadioButtonDepartmentCheckedChangedMethod(object sender, EventArgs e)
        {
            ComboDepartment.Visible = !RadioButtonAllDepartments.Checked || RadioButtonSearchDepartment.Checked;
        } //Clave de Método: Moves-RBADCCM
    }
}
