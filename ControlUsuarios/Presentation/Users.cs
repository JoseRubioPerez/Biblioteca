using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Entity;
using Business;
using Presentation.PopUpForms;
using Options;

namespace Presentation
{
    public partial class Users : FormFather
    {
        private Validations ObjValidations = new Validations();
        private readonly Session ObjSession = new Session();
        private ModifyUsers ObjModifyUsers = new ModifyUsers();
        private DataTable TablaComboSearch = new DataTable();
        private DataTable TablaComboDepartment = new DataTable();
        private List<string> ListaComboBox = new List<string>();
        private List<string> ListaComboBox2 = new List<string>();
        private Alerts ObjAlerts;
        private readonly Control[] ArrayControl;
        private byte Index;
        private DialogResult ObjDialog;

        public void GridSearchLoadDataMethod()
        {
            GridSearch.DataSource = ObjValidations.GridSearchMethod(TypeModules.Users, TypeSearch.Users);
            DataGridViewButtonColumn ObjButtonColumnEdit = new DataGridViewButtonColumn();
            {
                ObjButtonColumnEdit.Name = "EDITAR";
                ObjButtonColumnEdit.HeaderText = "EDITAR";
                ObjButtonColumnEdit.Text = "EDITAR";
                ObjButtonColumnEdit.FlatStyle = FlatStyle.Flat;
                ObjButtonColumnEdit.UseColumnTextForButtonValue = true;
                GridSearch.Columns.Add(ObjButtonColumnEdit);
            }
            GridSearch.CellClick += GridSearchCellClickMthod;
        } //Clave de Método: Users-GSLDM

        private void GridSearchCellClickMthod(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == GridSearch.Columns["EDITAR"].Index)
            {
                ObjModifyUsers.NumControl = GridSearch.Rows[e.RowIndex].Cells["NUMERO DE CONTROL"].Value.ToString().Trim();
                if (GridSearch.Rows[e.RowIndex].Cells["NOMBRES"].Value.ToString().Contains(" "))
                {
                    ObjModifyUsers.FirstName = GridSearch.Rows[e.RowIndex].Cells["NOMBRES"].Value.ToString().Split(' ')[0].Trim();
                    ObjModifyUsers.SecondName = GridSearch.Rows[e.RowIndex].Cells["NOMBRES"].Value.ToString().Split(' ')[1].Trim();
                }
                else
                {
                    ObjModifyUsers.FirstName = GridSearch.Rows[e.RowIndex].Cells["NOMBRES"].Value.ToString().Trim();
                    ObjModifyUsers.SecondName = string.Empty;
                }
                ObjModifyUsers.FirstLastName = (string.IsNullOrEmpty(GridSearch.Rows[e.RowIndex].Cells["APELLIDO PATERNO"].Value.ToString().Trim())) ? string.Empty : GridSearch.Rows[e.RowIndex].Cells["APELLIDO PATERNO"].Value.ToString();
                ObjModifyUsers.SecondLastName = (string.IsNullOrEmpty(GridSearch.Rows[e.RowIndex].Cells["APELLIDO MATERNO"].Value.ToString().Trim())) ? string.Empty : GridSearch.Rows[e.RowIndex].Cells["APELLIDO MATERNO"].Value.ToString();
                ObjModifyUsers.Sex = Convert.ToChar(GridSearch.Rows[e.RowIndex].Cells["SEXO"].Value.ToString());
                ObjModifyUsers.Department = GridSearch.Rows[e.RowIndex].Cells["DEPARTAMENTO O CARRERA"].Value.ToString();
                ObjModifyUsers.Status = Convert.ToChar(GridSearch.Rows[e.RowIndex].Cells["STATUS"].Value.ToString());
                PopUpUsers ObjPopUpUsers = new PopUpUsers(ObjModifyUsers);
                ObjPopUpUsers.Show();
            }
        } //Clave de Método: Users-GSCCM

        private void SearchInputsVisibleMethod(bool Text = true, bool Combo = false, bool RadioButton = false)
        {
            LabelDepartment.Visible = Combo;
            ComboTypeDepartment.Visible = Combo;
            GroupBoxStatusAndSex.Visible = RadioButton;
            TextBoxSearch.Visible = Text;
            RadioButtonOption1.Checked = false;
            RadioButtonOption2.Checked = false;
        } //Clave de Método: Users-SIVM

        public Users()
        {
            InitializeComponent();
            ArrayControl = new Control[] { ButtonNewUser, PictureBoxInfo, ButtonCleanSearch, ButtonSearch };
            GridSearchLoadDataMethod();
            ListaComboBox.Add("NINGUN FILTRO");
            SearchInputsVisibleMethod();
        }

        public Users(Session ObjSession)
        {
            InitializeComponent();
            this.ObjSession = ObjSession;
            ArrayControl = new Control[] { ButtonNewUser, PictureBoxInfo, ButtonCleanSearch, ButtonSearch };
            GridSearchLoadDataMethod();
            ListaComboBox.Add("NINGUN FILTRO");
            SearchInputsVisibleMethod();
        } //Clave de Constructor: Users-C

        private void ControlClickMethod(object sender, EventArgs e)
        {
            for (; Index < ArrayControl.Length; Index++)
                if (ArrayControl[Index] == sender)
                    break;
            switch (Index)
            {
                case 0: //ButtonNewUser
                    {
                        PopUpUsers ObjPopUpUsers = new PopUpUsers();
                        ObjPopUpUsers.Show();
                        break;
                    }
                case 1: //PictureBoxInfo
                    {
                        break;
                    }
                case 2: //ButtonCleanSearch
                    {
                        GridSearch.DataSource = ObjValidations.GridSearchMethod(TypeModules.Users, TypeSearch.Users);
                        LabelTotalResults.Text = "0";
                        TextBoxSearch.TextTextBox = string.Empty;
                        ComboTypeSearch.SelectedIndex = -1;
                        break;
                    }
                case 3: //ButtonSearch
                    {
                        if (ComboTypeSearch.SelectedIndex > -1 && !string.IsNullOrEmpty(TextBoxSearch.TextTextBox) && !string.IsNullOrWhiteSpace(TextBoxSearch.TextTextBox))
                        {

                        }
                        else
                        {
                            ObjAlerts = new Alerts("Búsqueda Fallida", "", "Parece que ser que la búsqueda no se pudo completar." +
                                "\nPor favor, revise los siguientes puntos:\n1. Es necesario que eliga un filtro de búsqueda." +
                                "\n2. Ingrese un texto a buscar.\n3. Haga clic en el botón de búsqueda (la lupa).", 1, "OK", "", "", TypeIcon.Warning);
                            ObjAlerts.ShowDialog();
                            if(ObjDialog.Equals(DialogResult.OK))
                            {
                                ObjAlerts.Close();
                                ObjAlerts.Dispose();
                            }
                        }
                        break;
                    }
                default:
                    throw new Exception("Excepción en Método: Users-CCM", new IndexOutOfRangeException());
            }
            Index = 0;
        } //Clave de Método: Users-CCM

        private void DataSourceChangedMethod(object sender, EventArgs e)
        {
            LabelTotalResults.Text = (GridSearch.Rows.Count.Equals(null)) ? "0" : GridSearch.Rows.Count.ToString();
        } //Clave de Método: Users-DSCM

        private void ComboTypeSearchClickMethod(object sender, EventArgs e)
        {
            TablaComboSearch = ObjValidations.ComboSearchMethod(TypeModules.Users, TypeSearch.Users);
            foreach (DataRow row in TablaComboSearch.Rows) ListaComboBox.Add(row["DESCRIPCION"].ToString());
            ComboTypeSearch.DataSource = ListaComboBox;
        } //Clave de Método: Users-CTSCM

        private void ComboTypeSearchSelectedChangedMethod(object sender, EventArgs e)
        {
            switch (ComboTypeSearch.SelectedIndex)
            {
                case 0:
                    {
                        TextBoxSearch.TextLabel = "Buscar en Todo: ";
                        break;
                    }
                case 1:
                    {
                        TextBoxSearch.TextLabel = "Número de Control: ";
                        SearchInputsVisibleMethod();
                        break;
                    }
                case 2:
                    {
                        TextBoxSearch.TextLabel = "Nombres: ";
                        SearchInputsVisibleMethod();
                        break;
                    }
                case 3:
                    {
                        TextBoxSearch.TextLabel = "Apellido Paterno: ";
                        SearchInputsVisibleMethod();
                        break;
                    }
                case 4:
                    {
                        TextBoxSearch.TextLabel = "Apellido Materno: ";
                        SearchInputsVisibleMethod();
                        break;
                    }
                case 5:
                    {
                        TextBoxSearch.TextLabel = "Sexo: ";
                        SearchInputsVisibleMethod(false,false, true);
                        RadioButtonOption1.Text = "Hombre";
                        RadioButtonOption2.Text = "Mujer";
                        break;
                    }
                case 6:
                    {
                        TextBoxSearch.TextLabel = "Departamento / Carrera: ";
                        SearchInputsVisibleMethod(false, true, false);
                        break;
                    }
                case 7:
                    {
                        TextBoxSearch.TextLabel = "Status: ";
                        SearchInputsVisibleMethod(false, false, true);
                        RadioButtonOption1.Text = "Activo";
                        RadioButtonOption2.Text = "Inactivo";
                        break;
                    }
            }
        } // Clave de Método: Users-CTSSCM

        private void ComboTypeDepartmentClickMethod(object sender, EventArgs e)
        {
            TablaComboDepartment = ObjValidations.GridSearchMethod(TypeModules.Users, TypeSearch.Areas);
            foreach (DataRow row in TablaComboDepartment.Rows) ListaComboBox2.Add(row["AREA"].ToString());
            ComboTypeDepartment.DataSource = ListaComboBox2;
        } //Clave de Método: Users-CTDCM
    }
}