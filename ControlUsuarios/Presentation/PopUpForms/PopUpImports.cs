using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Entity;
using Business;
using Options;

namespace Presentation.PopUpForms
{
    public partial class PopUpImports : PopUpFather
    {
        private Validations ObjValidations = new Validations();
        private ModifyUsers ObjModifyUsers = new ModifyUsers();
        public ModifyUsers ObjModifyUsers2 = new ModifyUsers();
        private DataTable TablaComboDepartment = new DataTable();
        private List<string> ListaComboBox = new List<string>();
        private readonly Control[] ArrayControl;
        private byte Index;
        private DialogResult ObjDialog;

        public PopUpImports()
        {
            InitializeComponent();
            TextBoxNumControl.Enabled = true;
            ButtonAccept.DialogResult = DialogResult.OK;
            ButtonCancel.DialogResult = DialogResult.Cancel;
            ArrayControl = new Control[] { ButtonAccept, ButtonCancel, RadioButtonMan, RadioButtonWoman, RadioButtonActive, RadioButtonDisable };
            TablaComboDepartment = ObjValidations.GridSearchMethod(TypeModules.Users, TypeSearch.Areas);
            foreach (DataRow row in TablaComboDepartment.Rows) ListaComboBox.Add(row["AREA"].ToString());
            ComboDepartmentCareer.DataSource = ListaComboBox;
        } //Clave de Constructor: PopUpImports-C1

        public PopUpImports(ModifyUsers ObjModifyUsers)
        {
            InitializeComponent();
            ButtonAccept.DialogResult = DialogResult.OK;
            ButtonCancel.DialogResult = DialogResult.Cancel;
            ArrayControl = new Control[] { ButtonAccept, ButtonCancel, RadioButtonMan, RadioButtonWoman, RadioButtonActive, RadioButtonDisable };
            this.ObjModifyUsers = ObjModifyUsers;
            TextBoxNumControl.Enabled = false;
            TablaComboDepartment = ObjValidations.GridSearchMethod(TypeModules.Users, TypeSearch.Areas);
            foreach (DataRow row in TablaComboDepartment.Rows) ListaComboBox.Add(row["AREA"].ToString());
            ComboDepartmentCareer.DataSource = ListaComboBox;
            TextBoxNumControl.Text = ObjModifyUsers.NumControl;
            TextBoxFirstName.Text = ObjModifyUsers.FirstName;
            TextBoxSecondName.Text = ObjModifyUsers.SecondName;
            TextBoxLastName.Text = ObjModifyUsers.FirstLastName;
            TextBoxLastName2.Text = ObjModifyUsers.SecondLastName;
            ComboDepartmentCareer.SelectedIndex = ObjModifyUsers.IndexDeparment;
            if (ObjModifyUsers.Sex == 'M')
            {
                RadioButtonMan.Checked = true;
                RadioButtonWoman.Checked = false;
            }
            else
            {
                RadioButtonWoman.Checked = true;
                RadioButtonMan.Checked = false;
            }
            if (ObjModifyUsers.Status == 'A')
            {
                RadioButtonActive.Checked = true;
                RadioButtonDisable.Checked = false;
            }
            else
            {
                RadioButtonDisable.Checked = true;
                RadioButtonActive.Checked = false;
            }
        } //Clave de Constructor: PopUpImports-C2

        private void ClearControlsMethod()
        {
            TextBoxFirstName.Text = ObjModifyUsers.FirstName;
            TextBoxSecondName.Text = ObjModifyUsers.SecondName;
            TextBoxLastName.Text = ObjModifyUsers.FirstLastName;
            TextBoxLastName2.Text = ObjModifyUsers.SecondLastName;
            ComboDepartmentCareer.SelectedItem = ObjModifyUsers.Department;
            if (ObjModifyUsers.Sex == 'M')
            {
                RadioButtonMan.Checked = true;
                RadioButtonWoman.Checked = false;
            }
            else
            {
                RadioButtonWoman.Checked = true;
                RadioButtonMan.Checked = false;
            }
            if (ObjModifyUsers.Status == 'A')
            {
                RadioButtonActive.Checked = true;
                RadioButtonDisable.Checked = false;
            }
            else
            {
                RadioButtonDisable.Checked = true;
                RadioButtonActive.Checked = false;
            }
        } //Clave de Método: PopUpImports-CCM

        private void ControlClickMethod(object sender, EventArgs e)
        {
            for (; Index < ArrayControl.Length; Index++)
                if (ArrayControl[Index] == sender)
                    break;
            switch (Index)
            {
                case 0: //ButtonAccept
                    {
                        ObjModifyUsers2.NumControl = TextBoxNumControl.Text.Trim();
                        ObjModifyUsers2.FirstName = TextBoxFirstName.Text.Trim().ToUpper();
                        ObjModifyUsers2.SecondName = TextBoxSecondName.Text.Trim().ToUpper();
                        ObjModifyUsers2.FirstAndSecondName = (!string.IsNullOrEmpty(TextBoxSecondName.Text)) ? TextBoxFirstName.Text.Trim().ToUpper() + " " + TextBoxSecondName.Text.Trim().ToUpper() : TextBoxFirstName.Text.Trim().ToUpper();
                        ObjModifyUsers2.FirstLastName = TextBoxLastName.Text.Trim().ToUpper();
                        ObjModifyUsers2.SecondLastName = TextBoxLastName2.Text.Trim().ToUpper();
                        ObjModifyUsers2.Department = ComboDepartmentCareer.SelectedItem.ToString();
                        ObjModifyUsers2.Sex = (RadioButtonMan.Checked) ? 'M' : 'F';
                        ObjModifyUsers2.Status = (RadioButtonActive.Checked) ? 'A' : 'I';
                        ObjModifyUsers2.IndexDeparment = (byte)ComboDepartmentCareer.SelectedIndex;
                        break;
                    }
                case 1: //ButtonCancel
                    {
                        ClearControlsMethod();
                        break;
                    }
                case 2: //RadioButtonMan
                    {
                        RadioButtonWoman.Checked = false;
                        break;
                    }
                case 3: //RadioButtonWoman
                    {
                        RadioButtonMan.Checked = false;
                        break;
                    }
                case 4: //RadioButtonActive
                    {
                        RadioButtonDisable.Checked = false;
                        break;
                    }
                case 5: //RadioButtonDisable
                    {
                        RadioButtonActive.Checked = false;
                        break;
                    }
                default:
                    throw new Exception("Excepción en Método: PopUpImports-CCM-02", new IndexOutOfRangeException());
            }
            Index = 0;
        } //Clave de Método: PopUpImports-CCM-02
    }
}
