using ClosedXML.Excel;

namespace Report
{
    public class CreateExcel
    {
        public void ExportDataGridView(string NombreArchivo, System.Data.DataTable Tabla)
        {
            using (XLWorkbook Libro = new XLWorkbook())
            {
                IXLWorksheet Hoja = Libro.Worksheets.Add(Tabla, "Reporte");
                Hoja.Table(0).ShowAutoFilter = false;
                Hoja.Columns().AdjustToContents();
                Libro.SaveAs(NombreArchivo + ".xlsx");
            }
        }
    }
}
