using System;
using System.Collections.Generic;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using Options;
using Business;

namespace Presentation.Inputs
{
    public partial class GridViewUI : UserControl
    {
        public TypeSearch OptionSearch;
        public TypeModules OptionModule;
        private Validations ObjValidations = new Validations();
        private Alerts ObjAlerts = new Alerts("Error", "Faltan Parámetros", "Parece ser falta algún parámetro para realizar la búsqueda, asegurate de que:\n\n1. Tengas elegido algún tipo de filtro.\n2. Haya escribido un texto para buscar.",1,string.Empty,string.Empty,"OK", TypeIcon.Warning);
        public DataTable TablaComboSearch = new DataTable();
        private List<string> ListaComboBox = new List<string>();

        public GridViewUI()
        {
            InitializeComponent();
            ListaComboBox.Add("NINGUN FILTRO");
            GridSearchUI.DataSource = ObjValidations.GridSearchMethod(OptionModule, OptionSearch);
        }
        public string TextTexboxUI { get { return TextBoxSearch.TextTextBox; } set { TextBoxSearch.TextTextBox = value; } }
        public string TextLabelUI { get { return TextBoxSearch.TextLabel; } set { TextBoxSearch.TextLabel = value; } }
        public AnchorStyles AnchorButtonUI { get { return ButtonCleanSearch.Anchor; } set { ButtonCleanSearch.Anchor = value; } }
        public AnchorStyles AnchorComboUI { get { return ComboTypeSearch.Anchor; } set { ComboTypeSearch.Anchor = value; } }
        public AnchorStyles AnchorTextBoxUI { get { return TextBoxSearch.Anchor; } set { TextBoxSearch.Anchor = value; } }
        public DockStyle DockStyleGridUI { get { return GridSearchUI.Dock; } set { GridSearchUI.Dock = value; } }
        public Size SizeGridUI { get { return GridSearchUI.Size; } set { GridSearchUI.Size = value; } }

        private void SearchClearMethod(object sender, EventArgs e)
        {
            GridSearchUI.DataSource = null;
            LabelTotalResults.Text = "0";
            TextBoxSearch.TextTextBox = string.Empty;
            ComboTypeSearch.SelectedIndex = -1;
        }

        private void DataSourceChangedMethod(object sender, EventArgs e)
        {
            LabelTotalResults.Text = (GridSearchUI.Rows.Count.Equals(null)) ? "0" : GridSearchUI.Rows.Count.ToString();
        }

        private void ComboTypeSearchClickMethod(object sender, EventArgs e)
        {
            TablaComboSearch = ObjValidations.ComboSearchMethod(TypeModules.Users, TypeSearch.Users);
            foreach (DataRow row in TablaComboSearch.Rows) ListaComboBox.Add(row["DESCRIPCION"].ToString());
            ComboTypeSearch.DataSource = ListaComboBox;
        }

        private void SearchClickMethod(object sender, EventArgs e)
        {
            if (ComboTypeSearch.SelectedIndex > -1 && !string.IsNullOrEmpty(TextBoxSearch.TextTextBox) && !string.IsNullOrWhiteSpace(TextBoxSearch.TextTextBox))
            {

            }
            else
            {
                ObjAlerts.ShowDialog();
            }
        }
    }
}
