using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Options;
using Entity;
using Business;
using Report;

namespace Presentation.PopUpForms
{
    public partial class PopUpGridSearch : PopUpFather
    {
        private CreateExcel ObjExcel = new CreateExcel();

        public PopUpGridSearch()
        {
            InitializeComponent();
            ButtonCancel.Visible = false;
            ButtonAccept.Visible = false;
        }

        public PopUpGridSearch(TypeModules Module, Search ObjSearch, string ModuloText)
        {
            InitializeComponent();
            GridSearch.DataSource = ObjSearch.Table;
            LabelTotalResults.Text = ObjSearch.Table.Rows.Count.ToString();
            LabelComboSearch.Text = ModuloText;
            ButtonCancel.Visible = false;
            ButtonAccept.Visible = false;
        }

        private void ButtonCreateReport_Click(object sender, EventArgs e)
        {
            if (GridSearch.Rows.Count > 0)
            {
                using (SaveFileDialog ObjDialog = new SaveFileDialog() { Filter = "Excel Workbook|*xls" })
                {
                    if (ObjDialog.ShowDialog() == DialogResult.OK)
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
