using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Entity;
using Business;
using Presentation.Inputs;
using Options;

namespace Presentation
{
    public partial class Moves : FormFather
    {
        private Validations ObjValidations = new Validations();
        private readonly Session ObjSession = new Session();
        private DataTable TablaComboSearch = new DataTable();
        private List<string> ListaComboBox = new List<string>();
        private Alerts ObjAlerts;
        private readonly Control[] ArrayControl;
        private byte Index;
        private DialogResult ObjDialog;

        public Moves()
        {
            InitializeComponent();
            ArrayControl = new Control[] { ButtonSearch, ButtonCleanSearch, ButtonCreateReport, PictureBoxInfo };
            GridSearch.DataSource = ObjValidations.GridSearchMethod(TypeModules.Moves, TypeSearch.Moves);
            ListaComboBox.Add("NINGUN FILTRO");
        }

        public Moves(Session ObjSession)
        {
            InitializeComponent();
            this.ObjSession = ObjSession;
            ArrayControl = new Control[] { ButtonSearch, ButtonCleanSearch, ButtonCreateReport, PictureBoxInfo };
            GridSearch.DataSource = ObjValidations.GridSearchMethod(TypeModules.Moves, TypeSearch.Moves);
            ListaComboBox.Add("NINGUN FILTRO");
        } //Clave de Constructor: Moves-C

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
                        GridSearch.DataSource = ObjValidations.GridSearchMethod(TypeModules.Moves, TypeSearch.Moves);
                        LabelTotalResults.Text = "0";
                        TextBoxSearch.TextTextBox = string.Empty;
                        ComboTypeSearch.SelectedIndex = -1;
                        break;
                    }
                case 2:
                    {
                        break;
                    }
                case 3:
                    {
                        break;
                    }
                default:
                    throw new Exception("Excepción en Método: Moves-CCM", new IndexOutOfRangeException());
            }
        } //Clave de Método: Moves-CCM
    }
}
