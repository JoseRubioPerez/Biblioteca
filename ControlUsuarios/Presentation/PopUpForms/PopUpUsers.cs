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
        private Validations ObjValidations = new Validations();
        private ModifyUsers ObjModifyUsers = new ModifyUsers();
        private ModifyUsers ObjModifyUsers2 = new ModifyUsers();
        private DataTable TablaComboDepartment = new DataTable();
        private List<string> ListaComboBox = new List<string>();
        private readonly Control[] ArrayControl;
        private byte Index;

        public PopUpUsers()
        {
            InitializeComponent();
            TextBoxNumControl.Enabled = true;
            ButtonAccept.DialogResult = DialogResult.OK;
            ButtonCancel.DialogResult = DialogResult.Cancel;
            ArrayControl = new Control[] { ButtonAccept, ButtonCancel, RadioButtonMan, RadioButtonWoman, RadioButtonActive, RadioButtonDisable };
            TablaComboDepartment = ObjValidations.GridSearchMethod(TypeModules.Users, TypeSearch.Areas);
            foreach (DataRow row in TablaComboDepartment.Rows) ListaComboBox.Add(row["AREA"].ToString());
            ComboDepartmentCareer.DataSource = ListaComboBox;
        } //Clave de Constructor: PopUpUsers-C1

        public PopUpUsers(ModifyUsers ObjModifyUsers)
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
        } //Clave de Constructor: PopUpUsers-C2

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
                        ObjModifyUsers2.NumControl = TextBoxNumControl.Text.Trim();
                        ObjModifyUsers2.FirstName = TextBoxFirstName.Text.Trim().ToUpper();
                        ObjModifyUsers2.SecondName = TextBoxSecondName.Text.Trim().ToUpper();
                        ObjModifyUsers2.FirstLastName = TextBoxLastName.Text.Trim().ToUpper();
                        ObjModifyUsers2.SecondLastName = TextBoxLastName2.Text.Trim().ToUpper();
                        ObjModifyUsers2.Department = ComboDepartmentCareer.SelectedItem.ToString();
                        ObjModifyUsers2.Sex = (RadioButtonMan.Checked) ? 'M' : 'F';
                        ObjModifyUsers2.Status = (RadioButtonActive.Checked) ? 'A' : 'I';
                        ObjModifyUsers2.IndexDeparment = (byte)ComboDepartmentCareer.SelectedIndex;

                        if (TextBoxNumControl.Enabled)
                        {
                            switch(ObjValidations.AddUser(TypeModules.Users, ObjModifyUsers2))
                            {
                                case Result.Correct:
                                    {
                                        using (Alerts ObjAlerts = new Alerts("Usuario Añadido Correctamente", "", "El usuario con número de control \"" + ObjModifyUsers.NumControl + "\" ha sido agregado correctamente.", 1, "", "", "OK", TypeIcon.Info))
                                        {
                                            if (ObjAlerts.ShowDialog() == DialogResult.OK) ObjAlerts.Close();
                                        }
                                        break;
                                    }
                                case Result.Incorrect:
                                    {
                                        using (Alerts ObjAlerts = new Alerts("Error Inexplicable", "", "Ha ocurrido un problema interno en el programa.\n\nRecomendamos que verifique los datos que ingresó y/o que inicie sesión nuevamente en el sistema.", 1, "", "", "OK", TypeIcon.Danger))
                                        {
                                            if (ObjAlerts.ShowDialog() == DialogResult.OK) ObjAlerts.Close();
                                        }
                                        break;
                                    }
                                case Result.Warning:
                                    {
                                        using (Alerts ObjAlerts = new Alerts("Acción No Valida", "", "No se puede ingresar usuarios sin número de control.", 1, "", "", "OK", TypeIcon.Warning))
                                        {
                                            if (ObjAlerts.ShowDialog() == DialogResult.OK) ObjAlerts.Close();
                                        }
                                        break;
                                    }
                            }
                        }
                        else
                        {
                            if (ObjValidations.PopUpUsersValidations(ObjModifyUsers, ObjModifyUsers2))
                            {
                                try
                                {
                                    ObjValidations.UpdateUser(TypeModules.Users, ObjModifyUsers2);
                                    using (Alerts ObjAlerts = new Alerts("Actualización Exitosa", "", "El usuario con número de control \"" + ObjModifyUsers.NumControl + "\" ha sido modificado correctamente.", 1, "", "", "OK", TypeIcon.Info))
                                    {
                                        if (ObjAlerts.ShowDialog() == DialogResult.OK) ObjAlerts.Close();
                                    }
                                }
                                catch
                                {
                                    using (Alerts ObjAlerts = new Alerts("Actualización Fallida", "", "El usuario con número de control \"" + ObjModifyUsers.NumControl + "\" NO se ha actualizado de manera correcta\nRevisa los datos que ingresaste y verifica que sean correctos o cumplan los requisitos de validación..", 1, "", "", "OK", TypeIcon.Info))
                                    {
                                        if (ObjAlerts.ShowDialog() == DialogResult.OK) ObjAlerts.Close();
                                    }
                                }
                            }
                            else
                            {
                                using (Alerts ObjAlerts = new Alerts("Edición de Usuario Fallida", "", "No se pudo completar la edición de los cambios al usuario: " + ObjModifyUsers.FirstName + " " + ObjModifyUsers.SecondName + " " + ObjModifyUsers.FirstLastName + " " + ObjModifyUsers.SecondLastName
                                                    + "\nPara poder editar un usuario, necesitas modificar los valores antiguos por unos nuevos. Es importante que no sean iguales, de lo contrario no se realizarán cambios porque no es necesario.", 1, "", "", "OK", TypeIcon.Warning))
                                {
                                    if (ObjAlerts.ShowDialog() == DialogResult.OK) ObjAlerts.Close();
                                }
                            }
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
