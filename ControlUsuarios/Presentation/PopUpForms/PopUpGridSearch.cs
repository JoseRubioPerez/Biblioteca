using System;
using System.Data;
using System.Windows.Forms;
using Options;
using Entity;
using Report;

namespace Presentation.PopUpForms
{
    public partial class PopUpGridSearch : PopUpFather
    {
        public PopUpGridSearch()
        {
            InitializeComponent();
            ButtonAccept.Visible = false;
            ButtonAccept.DialogResult = DialogResult.OK;
            ButtonCancel.Visible = false;
            ButtonCancel.DialogResult = DialogResult.Cancel;
        }

        public PopUpGridSearch(TypeModules Module, Search ObjSearch, string ModuloText)
        {
            InitializeComponent();
            GridSearch.DataSource = ObjSearch.Table;
            LabelTotalResults.Text = ObjSearch.Table.Rows.Count.ToString();
            LabelComboSearch.Text = ModuloText;
            ButtonAccept.Visible = false;
            ButtonAccept.DialogResult = DialogResult.OK;
            ButtonCancel.Visible = false;
            ButtonCancel.DialogResult = DialogResult.Cancel;
        }

        private void ButtonCreateReport_Click(object sender, EventArgs e)
        {
            if (GridSearch.Rows.Count > 0)
            {
                using (SaveFileDialog ObjDialog = new SaveFileDialog() { Filter = "Excel Workbook|*xls" })
                {
                    if (ObjDialog.ShowDialog() == DialogResult.OK)
                    {
                        using (CreateExcel ObjExcel = new CreateExcel())
                        {
                            ObjExcel.ExportDataGridView(ObjDialog.FileName, (DataTable)GridSearch.DataSource);
                            using (Alerts ObjAlerts = new Alerts("Información Exportada", "", "La información de su reporte fue exportada en Excel (formato \".xls\").\n\nSe generó un reporte con " + GridSearch.Rows.Count.ToString() + " filas.", 1))
                            {
                                ObjAlerts.ShowDialog();
                            }
                        }
                    }
                }
            }
        }
    }
}
