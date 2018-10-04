using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        private DataTable TablaComboDepartment = new DataTable();
        private List<string> ListaComboBox = new List<string>();
        private readonly Control[] ArrayControl;
        private byte Index;
        private DialogResult ObjDialog;

        public PopUpUsers()
        {
            InitializeComponent();
            ArrayControl = new Control[] { ButtonAccept, ButtonCancel, RadioButtonMan, RadioButtonWoman, RadioButtonActive, RadioButtonDisable };
        }

        public PopUpUsers(ModifyUsers ObjModifyUsers)
        {
            InitializeComponent();
            this.ObjModifyUsers = ObjModifyUsers;
            TextBoxNumControl.Text = ObjModifyUsers.NumControl;
            TextBoxFirstName.Text = ObjModifyUsers.FirstName;
            TextBoxSecondName.Text = ObjModifyUsers.SecondName;
            TextBoxLastName.Text = ObjModifyUsers.FirstLastName;
            TextBoxLastName2.Text = ObjModifyUsers.SecondLastName;
            ComboDepartmentCareer.SelectedValue = ObjModifyUsers.Department;
            if (ObjModifyUsers.Sex.Equals('M'))
            {
                RadioButtonWoman.Checked = false;
                RadioButtonMan.Checked = true;
            }
            else
            {
                RadioButtonWoman.Checked = true;
                RadioButtonMan.Checked = false;
            }
            if (ObjModifyUsers.Status.Equals('A'))
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
            TextBoxNumControl.Text = string.Empty;
            TextBoxFirstName.Text = string.Empty;
            TextBoxSecondName.Text = string.Empty;
            TextBoxLastName.Text = string.Empty;
            TextBoxLastName2.Text = string.Empty;
            ComboDepartmentCareer.SelectedIndex = -1;
            RadioButtonMan.Checked = false;
            RadioButtonWoman.Checked = false;
            RadioButtonActive.Checked = false;
            RadioButtonDisable.Checked = false;
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
        } //Clave de Método: PopUpUsers-CCM-02

        private void ComboDepartmentCareerClickMethod(object sender, EventArgs e)
        {
            TablaComboDepartment = ObjValidations.ComboSearchMethod(TypeModules.Users, TypeSearch.Users);
            foreach (DataRow row in TablaComboDepartment.Rows) ListaComboBox.Add(row["DESCRIPCION"].ToString());
            ComboDepartmentCareer.DataSource = ListaComboBox;
        } //Clave de Método: PopUpUsers-CDCCM
    }
}
