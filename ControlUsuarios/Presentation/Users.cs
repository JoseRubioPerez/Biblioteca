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
        private readonly Control[] ArrayControl;
        private byte Index;

        public Users(Session ObjSession)
        {
            InitializeComponent();
            this.ObjSession = ObjSession;
            ArrayControl = new Control[] { ButtonNewUser, PictureBoxInfo, ButtonCleanSearch, ButtonSearch };
            GridSearch.CellClick += GridSearchCellClickMethod;
        } //Clave de Constructor: Users-C1

        private void UsersLoadMethod(object sender, EventArgs e)
        {
            GridSearchLoadDataMethod();
            SearchInputsVisibleMethod();
            ComboTypeSearch.Items.Insert(0, "Número de Control");
            ComboTypeSearch.Items.Insert(1, "Nombres");
            ComboTypeSearch.Items.Insert(2, "Apellido Paterno");
            ComboTypeSearch.Items.Insert(3, "Apellido Materno");
            ComboTypeSearch.Items.Insert(4, "Ambos Apellidos");
            ComboTypeSearch.Items.Insert(5, "Sexo");
            ComboTypeSearch.Items.Insert(6, "Departamento o Carrera");
            ComboTypeSearch.Items.Insert(7, "Status");
            TablaComboDepartment = ObjValidations.GridSearchMethod(TypeModules.Users, TypeSearch.Areas);
            foreach (DataRow row in TablaComboDepartment.Rows) ListaComboBox2.Add(row["AREA"].ToString());
            ComboTypeDepartment.DataSource = ListaComboBox2;
        } //Clave de Método: Users-USM

        public void GridSearchLoadDataMethod()
        {
            GridSearch.DataSource = null;
            GridSearch.Columns.Clear();
            GridSearch.Rows.Clear();
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
        } //Clave de Método: Users-GSLDM

        private void GridSearchCellClickMethod(object sender, DataGridViewCellEventArgs e)
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
                using (PopUpUsers ObjPopUpUsers = new PopUpUsers(ObjModifyUsers))
                {
                    if (ObjPopUpUsers.ShowDialog() == DialogResult.OK)
                    {
                        GridSearchLoadDataMethod();
                    }
                }
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
                        LabelTotalResults.Text = GridSearch.Rows.Count.ToString();
                        TextBoxSearch.TextTextBox = string.Empty;
                        GridSearch.Columns["EDITAR"].DisplayIndex = GridSearch.Columns.Count - 1;
                        break;
                    }
                case 3: //ButtonSearch
                    {
                        bool Flag = false;
                        try
                        {
                            switch (ComboTypeSearch.SelectedIndex)
                            {
                                case 0:
                                case 1:
                                case 2:
                                case 3:
                                case 4:
                                    {
                                        Flag = !string.IsNullOrWhiteSpace(TextBoxSearch.TextTextBox) || !string.IsNullOrEmpty(TextBoxSearch.TextTextBox) ? true : false;
                                        break;
                                    }
                                case 5:
                                case 7:
                                    {
                                        Flag = RadioButtonOption1.Checked || RadioButtonOption2.Checked ? true : false;
                                        break;
                                    }
                                case 6:
                                    {
                                        Flag = ComboTypeDepartment.SelectedIndex > -1 ? true : false;
                                        break;
                                    }
                            }
                            if (Flag)
                            {
                                GridSearch.DataSource = ObjValidations.SearchUser(TypeModules.Users, 
                                    (byte)ComboTypeSearch.SelectedIndex,
                                    TextBoxSearch.TextTextBox.Trim().ToUpper(),
                                    RadioButtonOption1.Checked ? 'M' : 'F',
                                    (byte)ComboTypeDepartment.SelectedIndex,
                                    RadioButtonOption1.Checked ? 'A' : 'I');
                                GridSearch.Columns["EDITAR"].DisplayIndex = GridSearch.Columns.Count - 1;
                            }
                            else
                                throw new Exception();
                        }
                        catch (Exception)
                        {
                            Alerts ObjAlerts = new Alerts("Búsqueda Fallida", "", "Parece que ser que la búsqueda no se pudo completar.\nPor favor, revise los siguientes puntos:\n1. Es necesario que eliga un filtro de búsqueda."
                                                + "\n2. Ingrese un texto a buscar o seleccione una opción de búsqueda..\n3. Haga clic en el botón de búsqueda (lupa).", 1, "", "", "OK", TypeIcon.Warning);
                            if (ObjAlerts.ShowDialog() == DialogResult.OK)
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

        private void ComboTypeSearchSelectedChangedMethod(object sender, EventArgs e)
        {
            switch (ComboTypeSearch.SelectedIndex)
            {
                case 0:
                    {
                        TextBoxSearch.TextLabel = "Número de Control: ";
                        SearchInputsVisibleMethod();
                        break;
                    }
                case 1:
                    {
                        TextBoxSearch.TextLabel = "Nombres: ";
                        SearchInputsVisibleMethod();
                        break;
                    }
                case 2:
                    {
                        TextBoxSearch.TextLabel = "Apellido Paterno: ";
                        SearchInputsVisibleMethod();
                        break;
                    }
                case 3:
                    {
                        TextBoxSearch.TextLabel = "Apellido Materno: ";
                        SearchInputsVisibleMethod();
                        break;
                    }
                case 4:
                    {
                        TextBoxSearch.TextLabel = "Ambos Apellidos: ";
                        SearchInputsVisibleMethod();
                        break;
                    }
                case 5:
                    {
                        TextBoxSearch.TextLabel = "Sexo: ";
                        SearchInputsVisibleMethod(false, false, true);
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
    }
}