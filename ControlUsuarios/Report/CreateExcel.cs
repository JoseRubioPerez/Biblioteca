using System;
using ClosedXML.Excel;

namespace Report
{
    public class CreateExcel : IDisposable
    {
        public void ExportDataGridView(string NombreArchivo, System.Data.DataTable Tabla)
        {
            using (XLWorkbook Libro = new XLWorkbook())
            {
                IXLWorksheet Hoja = Libro.Worksheets.Add(Tabla, "Reporte");
                Hoja.Table(0).ShowAutoFilter = false;
                Libro.SaveAs(NombreArchivo + ".xlsx");
            }
        }

        void IDisposable.Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
