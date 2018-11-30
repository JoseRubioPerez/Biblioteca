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
            ComboTypeSearch.Items.Insert(0, "Número de Control");
            ComboTypeSearch.Items.Insert(1, "Sexo");
            ComboTypeSearch.Items.Insert(2, "Departamento o Carrera");
            ComboTypeSearch.Items.Insert(3, "Fecha");
            ComboTypeSearch.SelectedIndex = 0;
            ArrayControl = new Control[] { ButtonSearch, ButtonSearchAll, ButtonCleanSearch, PictureBoxInfo };
            MovesLoadMethod();
        } //Clave de Constructor: Moves-C1

        private void MovesLoadMethod()
        {
            TablaComboDepartment = ObjValidations.GridSearchMethod(TypeModules.Users, TypeSearch.Areas);
            foreach (DataRow row in TablaComboDepartment.Rows) ListCombo.Add(row["AREA"].ToString());
            ComboTypeDepartment.DataSource = ListCombo;
            ComboTypeDepartment.Visible = false;
            RadioButtonBothSex.Checked = false;
            RadioButtonMan.Checked = false;
            RadioButtonWoman.Checked = false;
            RadioButtonAllDepartments.Checked = false;
            RadioButtonSearchDepartment.Checked = false;
            DateTimePickerStart.Value = DateTime.Now.AddMonths(-1);
            DateTimePickerEnd.Value = DateTime.Now;
        } //Clave de Método: Moves-MLM

        private void ControlClickMethod(object sender, EventArgs e)
        {
            try
            {
                for (; Index < ArrayControl.Length; Index++)
                    if (ArrayControl[Index] == sender)
                        break;
                switch (Index)
                {
                    case 0: // ButtonSearch
                        {
                            if (TextBoxSearch.Visible)
                            {
                                if (ObjValidations.NumControlCheck(TextBoxSearch.TextTextBox.Trim()))
                                {
                                    ObjSearch.NumControl = TextBoxSearch.TextTextBox.Trim();
                                }
                                else
                                {
                                    throw new FormatException();
                                }
                            }
                            else
                            {
                                ObjSearch.NumControl = string.Empty;
                            }
                            if (RadioButtonAllDepartments.Checked || (!RadioButtonAllDepartments.Checked && !RadioButtonSearchDepartment.Checked) || !GroupBoxDepartment.Visible)
                            {
                                ObjSearch.IndexDeparmentStart = 0;
                                ObjSearch.IndexDeparmentEnd = 30;
                            }
                            else
                            {
                                ObjSearch.IndexDeparmentStart = ComboTypeDepartment.SelectedIndex;
                                ObjSearch.IndexDeparmentEnd = ComboTypeDepartment.SelectedIndex;
                            }
                            if (RadioButtonBothSex.Checked || (!RadioButtonBothSex.Checked && !RadioButtonMan.Checked && !RadioButtonWoman.Checked) || !GroupBoxSex.Visible)
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
                            if (PanelDate.Visible)
                            {
                                ObjSearch.DateStart = DateTimePickerStart.Value;
                                ObjSearch.DateEnd = DateTimePickerEnd.Value;
                            }
                            else
                            {
                                DateTimePickerStart.Value = DateTime.Parse("2000-01-01");
                                ObjSearch.DateEnd = DateTimePickerEnd.Value;
                            }
                            ObjValidations.SearchMoves(TypeModules.Moves, ObjSearch);
                            PopUpGridSearch ObjPopUpGridSearch = new PopUpGridSearch(TypeModules.Moves, ObjSearch, "Búsqueda de Movimientos");
                            ObjPopUpGridSearch.Show();
                            break;
                        }
                    case 1: // ButtonSearchAll
                        {
                            ObjSearch.NumControl = "";
                            ObjSearch.IndexDeparmentStart = 0;
                            ObjSearch.IndexDeparmentEnd = 30;
                            ObjSearch.SexStart = 'F';
                            ObjSearch.SexEnd = 'M';
                            DateTimePickerStart.Value = DateTime.Parse("2000-01-01");
                            ObjSearch.DateEnd = DateTimePickerEnd.Value;
                            ObjValidations.SearchMoves(TypeModules.Moves, ObjSearch);
                            PopUpGridSearch ObjPopUpGridSearch = new PopUpGridSearch(TypeModules.Moves, ObjSearch, "Búsqueda de Movimientos");
                            ObjPopUpGridSearch.Show();
                            break;
                        }
                    case 2: //ButtonCleanSearch
                        {
                            RadioButtonBothSex.Checked = false;
                            RadioButtonMan.Checked = false;
                            RadioButtonWoman.Checked = false;
                            RadioButtonAllDepartments.Checked = false;
                            RadioButtonSearchDepartment.Checked = false;
                            ComboTypeDepartment.Visible = false;
                            DateTimePickerStart.Value = DateTime.Now.AddMonths(-1);
                            DateTimePickerEnd.Value = DateTime.Now;
                            break;
                        }
                    default:
                        throw new Exception("Excepción en Método: Moves-CCM", new IndexOutOfRangeException());
                }
            }
            catch (IndexOutOfRangeException)
            {

            }
            catch (FormatException)
            {
                using (Alerts ObjAlerts = new Alerts("Número de Control Invalido", "", "El número de control ingresado no es valido\n\nVereifique el texto que ingresó.", 1, "", "", "OK", TypeIcon.Warning))
                {
                    if (ObjAlerts.ShowDialog() == DialogResult.OK)
                    {
                        ObjAlerts.Close();
                        ObjAlerts.Dispose();
                    }
                }
            }
            Index = 0;
        } //Clave de Método: Moves-CCM

        private void RadioButtonDepartmentCheckedChangedMethod(object sender, EventArgs e)
        {
            ComboTypeDepartment.Visible = !RadioButtonAllDepartments.Checked || RadioButtonSearchDepartment.Checked;
        } //Clave de Método: Moves-RBADCCM

        private void ComboTypeSearchSelectedChangedMethod(object sender, EventArgs e)
        {
            if (ComboTypeSearch.SelectedIndex > -1)
            {
                switch (ComboTypeSearch.SelectedIndex)
                {
                    case 0:
                        {
                            TextBoxSearch.Visible = true;
                            GroupBoxDepartment.Visible = false;
                            ComboTypeDepartment.Visible = false;
                            GroupBoxSex.Visible = false;
                            PanelDate.Visible = false;
                            break;
                        }
                    case 1:
                        {
                            TextBoxSearch.Visible = false;
                            GroupBoxDepartment.Visible = false;
                            ComboTypeDepartment.Visible = false;
                            GroupBoxSex.Visible = true;
                            PanelDate.Visible = false;
                            break;
                        }
                    case 2:
                        {
                            TextBoxSearch.Visible = false;
                            GroupBoxDepartment.Visible = true;
                            ComboTypeDepartment.Visible = true;
                            GroupBoxSex.Visible = false;
                            PanelDate.Visible = false;
                            break;
                        }
                    case 3:
                        {
                            TextBoxSearch.Visible = false;
                            GroupBoxDepartment.Visible = false;
                            ComboTypeDepartment.Visible = false;
                            GroupBoxSex.Visible = false;
                            PanelDate.Visible = true;
                            break;
                        }
                }
            }
            else
            {
                TextBoxSearch.Visible = false;
                TextBoxSearch.TextTextBox = string.Empty;

                RadioButtonMan.Checked = false;
                RadioButtonWoman.Checked = false;
                RadioButtonBothSex.Checked = false;
                GroupBoxSex.Visible = false;

                RadioButtonAllDepartments.Checked = false;
                RadioButtonAllDepartments.Checked = false;
                GroupBoxDepartment.Visible = false;

                DateTimePickerStart.Value = DateTime.Parse("01/01/2000");
                DateTimePickerEnd.Value = DateTime.Now;
                PanelDate.Visible = false;
            }
        } // Clave de Método: Moves-CTSSCM
    }
}
