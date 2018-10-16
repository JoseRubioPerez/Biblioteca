using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Entity;
using Business;
using Options;

namespace Presentation.PopUpForms
{
    public partial class PopUpUsers : PopUpFather
    {
        private Alerts ObjAlerts;
        private Validations ObjValidations = new Validations();
        private readonly ModifyUsers ObjModifyUsers = new ModifyUsers();
        private ModifyUsers ObjModifyUsers2 = new ModifyUsers();
        private DataTable TablaComboDepartment = new DataTable();
        private List<string> ListaComboBox = new List<string>();
        private readonly Control[] ArrayControl;
        private byte Index;
        private char UserSex = '\0', UserStatus = '\0';
        private DialogResult ObjDialog;

        public PopUpUsers()
        {
            InitializeComponent();
            ArrayControl = new Control[] { ButtonAccept, ButtonCancel, RadioButtonMan, RadioButtonWoman, RadioButtonActive, RadioButtonDisable };
            TablaComboDepartment = ObjValidations.GridSearchMethod(TypeModules.Users, TypeSearch.Areas);
            foreach (DataRow row in TablaComboDepartment.Rows) ListaComboBox.Add(row["AREA"].ToString());
            ComboDepartmentCareer.DataSource = ListaComboBox;
        }

        public PopUpUsers(ModifyUsers ObjModifyUsers)
        {
            InitializeComponent();
            ArrayControl = new Control[] { ButtonAccept, ButtonCancel, RadioButtonMan, RadioButtonWoman, RadioButtonActive, RadioButtonDisable };
            this.ObjModifyUsers = ObjModifyUsers;
            TablaComboDepartment = ObjValidations.GridSearchMethod(TypeModules.Users, TypeSearch.Areas);
            foreach (DataRow row in TablaComboDepartment.Rows) ListaComboBox.Add(row["AREA"].ToString());
            ComboDepartmentCareer.DataSource = ListaComboBox;
            TextBoxNumControl.Text = ObjModifyUsers.NumControl;
            TextBoxFirstName.Text = ObjModifyUsers.FirstName;
            TextBoxSecondName.Text = ObjModifyUsers.SecondName;
            TextBoxLastName.Text = ObjModifyUsers.FirstLastName;
            TextBoxLastName2.Text = ObjModifyUsers.SecondLastName;
            ComboDepartmentCareer.SelectedItem = ObjModifyUsers.Department;
            UserSex = ObjModifyUsers.Sex;
            UserStatus = ObjModifyUsers.Status;
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
        }

        private void ClearControlsMethod()
        {
            TextBoxFirstName.Text = ObjModifyUsers.FirstName;
            TextBoxSecondName.Text = ObjModifyUsers.SecondName;
            TextBoxLastName.Text = ObjModifyUsers.FirstLastName;
            TextBoxLastName2.Text = ObjModifyUsers.SecondLastName;
            ComboDepartmentCareer.SelectedItem = ObjModifyUsers.Department;
            UserSex = ObjModifyUsers.Sex;
            UserStatus = ObjModifyUsers.Status;
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
        } //Clave de Método: PopUpUsers-CCM

        private void ControlClickMethod(object sender, EventArgs e)
        {
            for (; Index < ArrayControl.Length; Index++)
                if (ArrayControl[Index] == sender)
                    break;
            switch (Index)
            {
                case 0: //ButtonAccept
                    {
                        ObjModifyUsers2.NumControl = TextBoxNumControl.Text;
                        ObjModifyUsers2.FirstName = TextBoxFirstName.Text;
                        ObjModifyUsers2.SecondName = TextBoxSecondName.Text;
                        ObjModifyUsers2.FirstLastName = TextBoxLastName.Text;
                        ObjModifyUsers2.SecondLastName = TextBoxLastName2.Text;
                        ObjModifyUsers2.Department = ComboDepartmentCareer.SelectedItem.ToString();
                        ObjModifyUsers2.Sex = UserSex;
                        ObjModifyUsers2.Status = UserStatus;
                        if(ObjValidations.PopUpUsersValidations(ObjModifyUsers, ObjModifyUsers2))
                        {

                        }
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
                    throw new Exception("Excepción en Método: PopUpUsers-CCM-02", new IndexOutOfRangeException());
            }
            Index = 0;
        } //Clave de Método: PopUpUsers-CCM-02
    }
}
